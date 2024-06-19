using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

using System.Configuration;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Net.NetworkInformation;

/*
 TODO: 
・プロセスキルがうまくいかない
・スクロールが毎回上にいってしまう
https://www.ipentec.com/document/csharp-detect-scroll-in-control
 */

namespace yt_dlp_GUI
{
    public partial class Form1 : Form
    {
        private string version = "1.5";


        private Process ytDlpProcess;
        private StringBuilder output;
        private Task processTask;
        private CancellationTokenSource cancellationTokenSource;

        private bool isRunning = false; // 追加：実行中かどうかを表す変数
        private bool isScrollenable = true; // 追加：スクロール可能かどうかを表す変数

        private string codecID = "";
        private string subtitleLang = "";

        private int prevOutputLength = 0;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Form1()
        {
            InitializeComponent();

            // もし、App.config が !notSet!なら、ユーザーのVideosフォルダを設定
            if (config.AppSettings.Settings["DIR"].Value == "!notSet!")
            {
                config.AppSettings.Settings["DIR"].Value = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                config.Save();
            }

            versionUpdater();
        }

        private string DeleteQuery(string url)
        {
            string pattern = @"([&?](si|list|ab_channle)[^&]*)";
            url = System.Text.RegularExpressions.Regex.Replace(url, pattern, "");
            url = System.Text.RegularExpressions.Regex.Replace(url, @"[&?]$", "");
            return url;
        }

        private void URLInput_TextChanged(object sender, EventArgs e)
        {
            // 入力されたURLからクエリを削除
            URLInput.Text = DeleteQuery(URLInput.Text);
        }

        private void YtDlpCommandWrapper(int kind) {
            string url = URLInput.Text;
            string DIR = config.AppSettings.Settings["DIR"].Value;
            string BROWSER = config.AppSettings.Settings["BROWSER"].Value;

            string command = "";

            if (url == "")
            {
                MessageBox.Show("URLを入力してください。");
                return;
            }

            switch (kind) {
                case 1:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" -f \"bestvideo[ext=mp4]+bestaudio[ext=m4a]\" --no-mtime";
                    break;
                case 2:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" -f \"bestaudio[ext=m4a]\" --no-mtime";
                    break;
                case 3:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" -f \"bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best\" --no-mtime";
                    break;
                case 4:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s_thumbnail.%(ext)s\" --write-thumbnail --skip-download --no-mtime";
                    break;
                case 5:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" --no-mtime";
                    break;
                case 6:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" --write-auto-sub --sub-lang {subtitleLang} --skip-download";
                    break;
                case 7:
                    command = $"yt-dlp {url} --list-formats --skip-download";
                    break;
                case 8:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" -f {codecID} --no-mtime";
                    break;
                case 9:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" --live-from-start";
                    break;
                case 10:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" -f \"bestaudio[ext=m4a]\" --no-mtime --cookies-from-browser {BROWSER}";
                    break;
                case 11:
                    command = $"yt-dlp {url} --list-formats --skip-download --cookies-from-browser {BROWSER}";
                    break;
                case 12:
                    command = $"yt-dlp {url} -o \"{DIR}\\%(title)s.%(ext)s\" -f {codecID} --no-mtime --cookies-from-browser {BROWSER}";
                    break;
                case 13:
                    command = "yt-dlp " + manualCodeInput.Text;
                    break;
                default:
                    MessageBox.Show("エラーが発生しました。");
                    return;

            }

            ExecuteYtDlpCommand(command);
        }

        private void ExecuteYtDlpCommand(string command)
        {
            if (ytDlpProcess != null && !ytDlpProcess.HasExited)
            {
                MessageBox.Show("他のプロセスがすでに実行中です。");
                return;
            }

            isRunning = true; // 追加：実行開始を表す
            isRunningLabelText.Visible = isRunning; // 追加：ラベルの表示を更新
            // stopButton.Visible = isRunning; // 追加：停止ボタンの表示を更新

            // outputTextにコマンドを表示
            string dir = config.AppSettings.Settings["DIR"].Value;
            OutputText.AppendText($"{dir}>{command}" + Environment.NewLine);

            output = new StringBuilder();
            cancellationTokenSource = new CancellationTokenSource();

            ytDlpProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            ytDlpProcess.OutputDataReceived += (sender, args) => AppendOutput(args.Data);
            ytDlpProcess.ErrorDataReceived += (sender, args) => AppendOutput(args.Data);

            processTask = Task.Run(() =>
            {
                ytDlpProcess.Start();
                ytDlpProcess.BeginOutputReadLine();
                ytDlpProcess.BeginErrorReadLine();
                ytDlpProcess.WaitForExit();

                isRunning = false;
                this.Invoke((MethodInvoker)delegate
                {
                    isRunningLabelText.Visible = isRunning;
                    // stopButton.Visible = isRunning;
                });
            }, cancellationTokenSource.Token);
        }

        private void AppendOutput(string data)
        {
            
            if (data != null)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    // つねに一番下を表示
                    OutputText.AppendText(data + Environment.NewLine);
/*                    if (isScrollenable)
                    {
                        OutputText.AppendText(data + Environment.NewLine);
                        OutputText.SelectionStart = OutputText.Text.Length;
                        OutputText.ScrollToCaret();
                        prevOutputLength = OutputText.Text.Length;

                    }
                    else
                    {
                        // isScrollenableがfalseのときは自動スクロールを無効化
                        OutputText.Text += data + Environment.NewLine;
                        OutputText.SelectionStart = prevOutputLength;
                        OutputText.ScrollToCaret();
                    }*/
                });
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (ytDlpProcess != null && !ytDlpProcess.HasExited)
            {
                try
                {
                    cancellationTokenSource.Cancel();
                    ytDlpProcess.Kill();
                    AppendOutput("ユーザーによってプロセスが停止されました。");
                }
                catch (Exception ex)
                {
                    AppendOutput($"Error stopping process: {ex.Message}");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FuncLabel1Text_Click(object sender, EventArgs e)
        {

        }

        private void 保存先の指定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true; // フォルダ選択モードに設定
            dialog.InitialDirectory = config.AppSettings.Settings["DIR"].Value;
            dialog.Title = "保存先のフォルダを選択してください。";

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                config.AppSettings.Settings["DIR"].Value = dialog.FileName;
                config.Save();
            }
        }

        private void cookie取得元ブラウザの指定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm settingsForm = new SettingForm("BROWSER");
            settingsForm.StartPosition = FormStartPosition.CenterParent;
            settingsForm.ShowDialog(this);
        }

        private void ExitApplicationMenu_Click(object sender, EventArgs e)
        {
            // finish application
            Application.Exit();
        }

        private void このアプリケーションについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 特定のURLを開く
            async void OpenUrl(string url)
            {
                await Task.Run(() =>
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                });
            }

            OpenUrl("https://github.com/AkaakuHub/yt-dlp-GUI");
        }

        private void OpenSaveDIRButton_Click(object sender, EventArgs e)
        {
            // configのDIRのディレクトリを開く
            string dir = config.AppSettings.Settings["DIR"].Value;
            Debug.WriteLine(dir);
            if (dir == "")
            {
                MessageBox.Show("保存先が設定されていません。");
                return;
            }
            Process.Start(dir);
        }

        private void CodecIDInput_TextChanged(object sender, EventArgs e)
        {
            codecID = CodecIDInput.Text;
        }

        private void subtitleLangInput_TextChanged(object sender, EventArgs e)
        {
            subtitleLang = subtitleLangInput.Text;
        }

        private void stopScrollButton_Click(object sender, EventArgs e)
        {
            isScrollenable = !isScrollenable;
            stopScrollButton.Text = isScrollenable ? "スクロールを停止" : "スクロールを再開";
            // trueなら白、falseならピンク
            stopScrollButton.BackColor = isScrollenable ? Color.White : Color.LightPink;
        }




        private void execButton1_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(1);
        }

        private void execButton2_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(2);
        }

        private void execButton3_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(3);
        }

        private void execButton4_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(4);
        }

        private void execButton5_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(5);
        }

        private void execButton6_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(6);
        }
        private void execButton7_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(7);
        }

        private void execButton8_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(8);
        }

        private void execButton9_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(9);
        }

        private void execButton10_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(10);
        }

        private void execButton11_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(11);
        }

        private void execButton12_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(12);
        }

        private void execButton13_Click(object sender, EventArgs e)
        {
            YtDlpCommandWrapper(13);
        }


        /*        private void scrollDetectTextBox1_Scroll(object sender, ScrollEventArgs e)
                {
                    if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
                    {
                        textBox1.Text += "横方向スクロール:";
                    }
                    else if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
                    {
                        textBox1.Text += "縦方向スクロール:";

                    }

                    switch (e.Type)
                    {
                        case ScrollEventType.EndScroll:
                            textBox1.Text += "EndScroll \r\n";
                            break;
                        case ScrollEventType.First:
                            textBox1.Text += "First \r\n";
                            break;
                        case ScrollEventType.LargeDecrement:
                            textBox1.Text += "LargeDecrement \r\n";
                            break;
                        case ScrollEventType.LargeIncrement:
                            textBox1.Text += "LargeIncrement \r\n";
                            break;
                        case ScrollEventType.Last:
                            textBox1.Text += "Last \r\n";
                            break;
                        case ScrollEventType.SmallDecrement:
                            textBox1.Text += "SmallDecrement \r\n";
                            break;
                        case ScrollEventType.SmallIncrement:
                            textBox1.Text += "SmallIncrement \r\n";
                            break;
                        case ScrollEventType.ThumbPosition:
                            textBox1.Text += "ThumbPosition \r\n";
                            break;
                        case ScrollEventType.ThumbTrack:
                            textBox1.Text += "ThumbTrack \r\n";
                            break;
                    }
                }*/

        private void versionUpdater()
        {
            // ネットワーク接続の確認
            if (!NetworkInterface.GetIsNetworkAvailable())
            {
                Console.WriteLine("ネットワーク接続がありません。");
                return;
            }

            // GitHubのリリースからバージョンを取得
            string githubReleaseUrl = "https://github.com/AkaakuHub/yt-dlp-GUI/releases/latest";
            string latestVersion = GetLatestVersionFromGitHub(githubReleaseUrl);

            // プログラム内のバージョンと比較
/*            if (string.Compare(version, latestVersion) < 0)
            {
                // 新しいバージョンのダウンロードと置き換え
                DownloadAndReplaceExeFile();
            }*/
/*            else
            {
                Console.WriteLine("最新バージョンを使用しています。");
            }*/
        }

        static string GetLatestVersionFromGitHub(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.AllowAutoRedirect = true;
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            string redirectedURL = res.ResponseUri.ToString();
            // 最後の / 以降を取得
            string[] splitLocation = redirectedURL.Split('/');
            string latestVersion = splitLocation[splitLocation.Length - 1];
            return latestVersion;
        }

        static void DownloadAndReplaceExeFile()
        {
/*            // 新しいexeファイルをダウンロード
            string downloadUrl = "https://github.com/AkaakuHub/yt-dlp-GUI/releases/download/v1.2.3/your-app.exe";
            string newExePath = "new-app.exe"; // ダウンロードしたファイルの保存先

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(downloadUrl, newExePath);
            }

            // 古いexeファイルを置き換え
            string oldExePath = "your-app.exe"; // 古いファイルのパス
            File.Replace(newExePath, oldExePath, null);
            Console.WriteLine("アップデートが完了しました。");*/
        }
    }
}
