namespace yt_dlp_GUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.execButton7 = new System.Windows.Forms.Button();
            this.URLInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.FuncLabelText7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.環境設定 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存先の指定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookie取得元ブラウザの指定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitApplicationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.このアプリケーションについてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSaveDIRButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isRunningLabelText = new System.Windows.Forms.Label();
            this.CodecIDInput = new System.Windows.Forms.TextBox();
            this.subtitleLangInput = new System.Windows.Forms.TextBox();
            this.stopScrollButton = new System.Windows.Forms.Button();
            this.execButton1 = new System.Windows.Forms.Button();
            this.FuncLabelText1 = new System.Windows.Forms.Label();
            this.execButton2 = new System.Windows.Forms.Button();
            this.execButton3 = new System.Windows.Forms.Button();
            this.execButton4 = new System.Windows.Forms.Button();
            this.execButton5 = new System.Windows.Forms.Button();
            this.execButton6 = new System.Windows.Forms.Button();
            this.execButton8 = new System.Windows.Forms.Button();
            this.execButton9 = new System.Windows.Forms.Button();
            this.execButton10 = new System.Windows.Forms.Button();
            this.execButton11 = new System.Windows.Forms.Button();
            this.execButton12 = new System.Windows.Forms.Button();
            this.execButton13 = new System.Windows.Forms.Button();
            this.FuncLabelText2 = new System.Windows.Forms.Label();
            this.FuncLabelText3 = new System.Windows.Forms.Label();
            this.FuncLabelText4 = new System.Windows.Forms.Label();
            this.FuncLabelText5 = new System.Windows.Forms.Label();
            this.FuncLabelText6 = new System.Windows.Forms.Label();
            this.FuncLabelText8 = new System.Windows.Forms.Label();
            this.FuncLabelText9 = new System.Windows.Forms.Label();
            this.FuncLabelText10 = new System.Windows.Forms.Label();
            this.FuncLabelText11 = new System.Windows.Forms.Label();
            this.FuncLabelText12 = new System.Windows.Forms.Label();
            this.FuncLabelText13 = new System.Windows.Forms.Label();
            this.manualCodeInput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // execButton7
            // 
            this.execButton7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton7.Location = new System.Drawing.Point(367, 159);
            this.execButton7.Name = "execButton7";
            this.execButton7.Size = new System.Drawing.Size(59, 31);
            this.execButton7.TabIndex = 0;
            this.execButton7.Text = "実行";
            this.execButton7.UseVisualStyleBackColor = true;
            this.execButton7.Click += new System.EventHandler(this.execButton7_Click);
            // 
            // URLInput
            // 
            this.URLInput.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.URLInput.Location = new System.Drawing.Point(51, 38);
            this.URLInput.Name = "URLInput";
            this.URLInput.Size = new System.Drawing.Size(275, 23);
            this.URLInput.TabIndex = 2;
            this.URLInput.TextChanged += new System.EventHandler(this.URLInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.SystemColors.WindowText;
            this.OutputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputText.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.ForeColor = System.Drawing.SystemColors.Window;
            this.OutputText.Location = new System.Drawing.Point(367, 437);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(885, 232);
            this.OutputText.TabIndex = 4;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.stopButton.Location = new System.Drawing.Point(12, 301);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(125, 41);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "プログラムを停止";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // FuncLabelText7
            // 
            this.FuncLabelText7.AutoSize = true;
            this.FuncLabelText7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText7.Location = new System.Drawing.Point(432, 166);
            this.FuncLabelText7.Name = "FuncLabelText7";
            this.FuncLabelText7.Size = new System.Drawing.Size(83, 16);
            this.FuncLabelText7.TabIndex = 7;
            this.FuncLabelText7.Text = "リストを表示";
            this.FuncLabelText7.Click += new System.EventHandler(this.FuncLabel1Text_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.ヘルプToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.環境設定,
            this.ExitApplicationMenu});
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 環境設定
            // 
            this.環境設定.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存先の指定ToolStripMenuItem,
            this.cookie取得元ブラウザの指定ToolStripMenuItem});
            this.環境設定.Name = "環境設定";
            this.環境設定.Size = new System.Drawing.Size(122, 22);
            this.環境設定.Text = "環境設定";
            // 
            // 保存先の指定ToolStripMenuItem
            // 
            this.保存先の指定ToolStripMenuItem.Name = "保存先の指定ToolStripMenuItem";
            this.保存先の指定ToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.保存先の指定ToolStripMenuItem.Text = "保存先の指定";
            this.保存先の指定ToolStripMenuItem.Click += new System.EventHandler(this.保存先の指定ToolStripMenuItem_Click);
            // 
            // cookie取得元ブラウザの指定ToolStripMenuItem
            // 
            this.cookie取得元ブラウザの指定ToolStripMenuItem.Name = "cookie取得元ブラウザの指定ToolStripMenuItem";
            this.cookie取得元ブラウザの指定ToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.cookie取得元ブラウザの指定ToolStripMenuItem.Text = "Cookie取得元ブラウザの指定";
            this.cookie取得元ブラウザの指定ToolStripMenuItem.Click += new System.EventHandler(this.cookie取得元ブラウザの指定ToolStripMenuItem_Click);
            // 
            // ExitApplicationMenu
            // 
            this.ExitApplicationMenu.Name = "ExitApplicationMenu";
            this.ExitApplicationMenu.Size = new System.Drawing.Size(122, 22);
            this.ExitApplicationMenu.Text = "終了";
            this.ExitApplicationMenu.Click += new System.EventHandler(this.ExitApplicationMenu_Click);
            // 
            // ヘルプToolStripMenuItem
            // 
            this.ヘルプToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョンToolStripMenuItem,
            this.このアプリケーションについてToolStripMenuItem});
            this.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            this.ヘルプToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // バージョンToolStripMenuItem
            // 
            this.バージョンToolStripMenuItem.Name = "バージョンToolStripMenuItem";
            this.バージョンToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.バージョンToolStripMenuItem.Text = "バージョン";
            this.バージョンToolStripMenuItem.Click += new System.EventHandler(this.バージョンToolStripMenuItem_Click);
            // 
            // このアプリケーションについてToolStripMenuItem
            // 
            this.このアプリケーションについてToolStripMenuItem.Name = "このアプリケーションについてToolStripMenuItem";
            this.このアプリケーションについてToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.このアプリケーションについてToolStripMenuItem.Text = "このアプリケーションについて";
            this.このアプリケーションについてToolStripMenuItem.Click += new System.EventHandler(this.このアプリケーションについてToolStripMenuItem_Click);
            // 
            // OpenSaveDIRButton
            // 
            this.OpenSaveDIRButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.OpenSaveDIRButton.Location = new System.Drawing.Point(12, 437);
            this.OpenSaveDIRButton.Name = "OpenSaveDIRButton";
            this.OpenSaveDIRButton.Size = new System.Drawing.Size(109, 41);
            this.OpenSaveDIRButton.TabIndex = 9;
            this.OpenSaveDIRButton.Text = "保存先を開く";
            this.OpenSaveDIRButton.UseVisualStyleBackColor = true;
            this.OpenSaveDIRButton.Click += new System.EventHandler(this.OpenSaveDIRButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "コーデックID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(9, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "字幕言語";
            // 
            // isRunningLabelText
            // 
            this.isRunningLabelText.AutoSize = true;
            this.isRunningLabelText.BackColor = System.Drawing.Color.IndianRed;
            this.isRunningLabelText.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.isRunningLabelText.Location = new System.Drawing.Point(14, 249);
            this.isRunningLabelText.Name = "isRunningLabelText";
            this.isRunningLabelText.Padding = new System.Windows.Forms.Padding(5);
            this.isRunningLabelText.Size = new System.Drawing.Size(164, 26);
            this.isRunningLabelText.TabIndex = 12;
            this.isRunningLabelText.Text = "プログラムを実行中です";
            this.isRunningLabelText.Visible = false;
            // 
            // CodecIDInput
            // 
            this.CodecIDInput.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.CodecIDInput.Location = new System.Drawing.Point(93, 103);
            this.CodecIDInput.Name = "CodecIDInput";
            this.CodecIDInput.Size = new System.Drawing.Size(100, 23);
            this.CodecIDInput.TabIndex = 13;
            this.CodecIDInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodecIDInput.TextChanged += new System.EventHandler(this.CodecIDInput_TextChanged);
            // 
            // subtitleLangInput
            // 
            this.subtitleLangInput.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.subtitleLangInput.Location = new System.Drawing.Point(93, 147);
            this.subtitleLangInput.Name = "subtitleLangInput";
            this.subtitleLangInput.Size = new System.Drawing.Size(100, 23);
            this.subtitleLangInput.TabIndex = 14;
            this.subtitleLangInput.Text = "ja";
            this.subtitleLangInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subtitleLangInput.TextChanged += new System.EventHandler(this.subtitleLangInput_TextChanged);
            // 
            // stopScrollButton
            // 
            this.stopScrollButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.stopScrollButton.Location = new System.Drawing.Point(12, 353);
            this.stopScrollButton.Name = "stopScrollButton";
            this.stopScrollButton.Size = new System.Drawing.Size(125, 41);
            this.stopScrollButton.TabIndex = 15;
            this.stopScrollButton.Text = "スクロールを停止";
            this.stopScrollButton.UseVisualStyleBackColor = true;
            this.stopScrollButton.Visible = false;
            this.stopScrollButton.Click += new System.EventHandler(this.stopScrollButton_Click);
            // 
            // execButton1
            // 
            this.execButton1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton1.Location = new System.Drawing.Point(367, 38);
            this.execButton1.Name = "execButton1";
            this.execButton1.Size = new System.Drawing.Size(59, 31);
            this.execButton1.TabIndex = 16;
            this.execButton1.Text = "実行";
            this.execButton1.UseVisualStyleBackColor = true;
            this.execButton1.Click += new System.EventHandler(this.execButton1_Click);
            // 
            // FuncLabelText1
            // 
            this.FuncLabelText1.AutoSize = true;
            this.FuncLabelText1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText1.Location = new System.Drawing.Point(432, 45);
            this.FuncLabelText1.Name = "FuncLabelText1";
            this.FuncLabelText1.Size = new System.Drawing.Size(58, 16);
            this.FuncLabelText1.TabIndex = 17;
            this.FuncLabelText1.Text = "通常DL";
            // 
            // execButton2
            // 
            this.execButton2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton2.Location = new System.Drawing.Point(517, 38);
            this.execButton2.Name = "execButton2";
            this.execButton2.Size = new System.Drawing.Size(59, 31);
            this.execButton2.TabIndex = 18;
            this.execButton2.Text = "実行";
            this.execButton2.UseVisualStyleBackColor = true;
            this.execButton2.Click += new System.EventHandler(this.execButton2_Click);
            // 
            // execButton3
            // 
            this.execButton3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton3.Location = new System.Drawing.Point(659, 38);
            this.execButton3.Name = "execButton3";
            this.execButton3.Size = new System.Drawing.Size(59, 31);
            this.execButton3.TabIndex = 19;
            this.execButton3.Text = "実行";
            this.execButton3.UseVisualStyleBackColor = true;
            this.execButton3.Click += new System.EventHandler(this.execButton3_Click);
            // 
            // execButton4
            // 
            this.execButton4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton4.Location = new System.Drawing.Point(827, 38);
            this.execButton4.Name = "execButton4";
            this.execButton4.Size = new System.Drawing.Size(59, 31);
            this.execButton4.TabIndex = 20;
            this.execButton4.Text = "実行";
            this.execButton4.UseVisualStyleBackColor = true;
            this.execButton4.Click += new System.EventHandler(this.execButton4_Click);
            // 
            // execButton5
            // 
            this.execButton5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton5.Location = new System.Drawing.Point(367, 75);
            this.execButton5.Name = "execButton5";
            this.execButton5.Size = new System.Drawing.Size(59, 31);
            this.execButton5.TabIndex = 21;
            this.execButton5.Text = "実行";
            this.execButton5.UseVisualStyleBackColor = true;
            this.execButton5.Click += new System.EventHandler(this.execButton5_Click);
            // 
            // execButton6
            // 
            this.execButton6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton6.Location = new System.Drawing.Point(367, 112);
            this.execButton6.Name = "execButton6";
            this.execButton6.Size = new System.Drawing.Size(59, 31);
            this.execButton6.TabIndex = 22;
            this.execButton6.Text = "実行";
            this.execButton6.UseVisualStyleBackColor = true;
            this.execButton6.Click += new System.EventHandler(this.execButton6_Click);
            // 
            // execButton8
            // 
            this.execButton8.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton8.Location = new System.Drawing.Point(367, 196);
            this.execButton8.Name = "execButton8";
            this.execButton8.Size = new System.Drawing.Size(59, 31);
            this.execButton8.TabIndex = 23;
            this.execButton8.Text = "実行";
            this.execButton8.UseVisualStyleBackColor = true;
            this.execButton8.Click += new System.EventHandler(this.execButton8_Click);
            // 
            // execButton9
            // 
            this.execButton9.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton9.Location = new System.Drawing.Point(367, 242);
            this.execButton9.Name = "execButton9";
            this.execButton9.Size = new System.Drawing.Size(59, 31);
            this.execButton9.TabIndex = 24;
            this.execButton9.Text = "実行";
            this.execButton9.UseVisualStyleBackColor = true;
            this.execButton9.Click += new System.EventHandler(this.execButton9_Click);
            // 
            // execButton10
            // 
            this.execButton10.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton10.Location = new System.Drawing.Point(367, 279);
            this.execButton10.Name = "execButton10";
            this.execButton10.Size = new System.Drawing.Size(59, 31);
            this.execButton10.TabIndex = 25;
            this.execButton10.Text = "実行";
            this.execButton10.UseVisualStyleBackColor = true;
            this.execButton10.Click += new System.EventHandler(this.execButton10_Click);
            // 
            // execButton11
            // 
            this.execButton11.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton11.Location = new System.Drawing.Point(367, 326);
            this.execButton11.Name = "execButton11";
            this.execButton11.Size = new System.Drawing.Size(59, 31);
            this.execButton11.TabIndex = 26;
            this.execButton11.Text = "実行";
            this.execButton11.UseVisualStyleBackColor = true;
            this.execButton11.Click += new System.EventHandler(this.execButton11_Click);
            // 
            // execButton12
            // 
            this.execButton12.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton12.Location = new System.Drawing.Point(367, 363);
            this.execButton12.Name = "execButton12";
            this.execButton12.Size = new System.Drawing.Size(59, 31);
            this.execButton12.TabIndex = 27;
            this.execButton12.Text = "実行";
            this.execButton12.UseVisualStyleBackColor = true;
            this.execButton12.Click += new System.EventHandler(this.execButton12_Click);
            // 
            // execButton13
            // 
            this.execButton13.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.execButton13.Location = new System.Drawing.Point(367, 400);
            this.execButton13.Name = "execButton13";
            this.execButton13.Size = new System.Drawing.Size(59, 31);
            this.execButton13.TabIndex = 28;
            this.execButton13.Text = "実行";
            this.execButton13.UseVisualStyleBackColor = true;
            this.execButton13.Click += new System.EventHandler(this.execButton13_Click);
            // 
            // FuncLabelText2
            // 
            this.FuncLabelText2.AutoSize = true;
            this.FuncLabelText2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText2.Location = new System.Drawing.Point(582, 45);
            this.FuncLabelText2.Name = "FuncLabelText2";
            this.FuncLabelText2.Size = new System.Drawing.Size(58, 16);
            this.FuncLabelText2.TabIndex = 29;
            this.FuncLabelText2.Text = "音声DL";
            // 
            // FuncLabelText3
            // 
            this.FuncLabelText3.AutoSize = true;
            this.FuncLabelText3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText3.Location = new System.Drawing.Point(724, 45);
            this.FuncLabelText3.Name = "FuncLabelText3";
            this.FuncLabelText3.Size = new System.Drawing.Size(74, 16);
            this.FuncLabelText3.TabIndex = 30;
            this.FuncLabelText3.Text = "高品質DL";
            // 
            // FuncLabelText4
            // 
            this.FuncLabelText4.AutoSize = true;
            this.FuncLabelText4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText4.Location = new System.Drawing.Point(892, 45);
            this.FuncLabelText4.Name = "FuncLabelText4";
            this.FuncLabelText4.Size = new System.Drawing.Size(90, 16);
            this.FuncLabelText4.TabIndex = 31;
            this.FuncLabelText4.Text = "サムネイルDL";
            // 
            // FuncLabelText5
            // 
            this.FuncLabelText5.AutoSize = true;
            this.FuncLabelText5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText5.Location = new System.Drawing.Point(432, 82);
            this.FuncLabelText5.Name = "FuncLabelText5";
            this.FuncLabelText5.Size = new System.Drawing.Size(106, 16);
            this.FuncLabelText5.TabIndex = 32;
            this.FuncLabelText5.Text = "フォーマット自動";
            // 
            // FuncLabelText6
            // 
            this.FuncLabelText6.AutoSize = true;
            this.FuncLabelText6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText6.Location = new System.Drawing.Point(432, 119);
            this.FuncLabelText6.Name = "FuncLabelText6";
            this.FuncLabelText6.Size = new System.Drawing.Size(58, 16);
            this.FuncLabelText6.TabIndex = 33;
            this.FuncLabelText6.Text = "字幕DL";
            // 
            // FuncLabelText8
            // 
            this.FuncLabelText8.AutoSize = true;
            this.FuncLabelText8.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText8.Location = new System.Drawing.Point(432, 203);
            this.FuncLabelText8.Name = "FuncLabelText8";
            this.FuncLabelText8.Size = new System.Drawing.Size(178, 16);
            this.FuncLabelText8.TabIndex = 34;
            this.FuncLabelText8.Text = "リストからコーデックIDを指定";
            // 
            // FuncLabelText9
            // 
            this.FuncLabelText9.AutoSize = true;
            this.FuncLabelText9.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText9.Location = new System.Drawing.Point(432, 249);
            this.FuncLabelText9.Name = "FuncLabelText9";
            this.FuncLabelText9.Size = new System.Drawing.Size(152, 16);
            this.FuncLabelText9.TabIndex = 35;
            this.FuncLabelText9.Text = "リストを表示(Premium)";
            // 
            // FuncLabelText10
            // 
            this.FuncLabelText10.AutoSize = true;
            this.FuncLabelText10.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText10.Location = new System.Drawing.Point(432, 286);
            this.FuncLabelText10.Name = "FuncLabelText10";
            this.FuncLabelText10.Size = new System.Drawing.Size(247, 16);
            this.FuncLabelText10.TabIndex = 36;
            this.FuncLabelText10.Text = "リストからコーデックIDを指定(Premium)";
            // 
            // FuncLabelText11
            // 
            this.FuncLabelText11.AutoSize = true;
            this.FuncLabelText11.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText11.Location = new System.Drawing.Point(432, 333);
            this.FuncLabelText11.Name = "FuncLabelText11";
            this.FuncLabelText11.Size = new System.Drawing.Size(177, 16);
            this.FuncLabelText11.TabIndex = 37;
            this.FuncLabelText11.Text = "YouTube Music(Premium)";
            // 
            // FuncLabelText12
            // 
            this.FuncLabelText12.AutoSize = true;
            this.FuncLabelText12.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText12.Location = new System.Drawing.Point(432, 370);
            this.FuncLabelText12.Name = "FuncLabelText12";
            this.FuncLabelText12.Size = new System.Drawing.Size(83, 16);
            this.FuncLabelText12.TabIndex = 38;
            this.FuncLabelText12.Text = "配信を録画";
            // 
            // FuncLabelText13
            // 
            this.FuncLabelText13.AutoSize = true;
            this.FuncLabelText13.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.FuncLabelText13.Location = new System.Drawing.Point(432, 407);
            this.FuncLabelText13.Name = "FuncLabelText13";
            this.FuncLabelText13.Size = new System.Drawing.Size(126, 16);
            this.FuncLabelText13.TabIndex = 39;
            this.FuncLabelText13.Text = "任意コード yt-dlp ";
            // 
            // manualCodeInput
            // 
            this.manualCodeInput.Location = new System.Drawing.Point(564, 407);
            this.manualCodeInput.Name = "manualCodeInput";
            this.manualCodeInput.Size = new System.Drawing.Size(671, 19);
            this.manualCodeInput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.manualCodeInput);
            this.Controls.Add(this.FuncLabelText13);
            this.Controls.Add(this.FuncLabelText12);
            this.Controls.Add(this.FuncLabelText11);
            this.Controls.Add(this.FuncLabelText10);
            this.Controls.Add(this.FuncLabelText9);
            this.Controls.Add(this.FuncLabelText8);
            this.Controls.Add(this.FuncLabelText6);
            this.Controls.Add(this.FuncLabelText5);
            this.Controls.Add(this.FuncLabelText4);
            this.Controls.Add(this.FuncLabelText3);
            this.Controls.Add(this.FuncLabelText2);
            this.Controls.Add(this.execButton13);
            this.Controls.Add(this.execButton12);
            this.Controls.Add(this.execButton11);
            this.Controls.Add(this.execButton10);
            this.Controls.Add(this.execButton9);
            this.Controls.Add(this.execButton8);
            this.Controls.Add(this.execButton6);
            this.Controls.Add(this.execButton5);
            this.Controls.Add(this.execButton4);
            this.Controls.Add(this.execButton3);
            this.Controls.Add(this.execButton2);
            this.Controls.Add(this.FuncLabelText1);
            this.Controls.Add(this.execButton1);
            this.Controls.Add(this.stopScrollButton);
            this.Controls.Add(this.subtitleLangInput);
            this.Controls.Add(this.CodecIDInput);
            this.Controls.Add(this.isRunningLabelText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenSaveDIRButton);
            this.Controls.Add(this.FuncLabelText7);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLInput);
            this.Controls.Add(this.execButton7);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "yt-dlp-GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button execButton7;
        private System.Windows.Forms.TextBox URLInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label FuncLabelText7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 環境設定;
        private System.Windows.Forms.ToolStripMenuItem ExitApplicationMenu;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem このアプリケーションについてToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存先の指定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookie取得元ブラウザの指定ToolStripMenuItem;
        private System.Windows.Forms.Button OpenSaveDIRButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label isRunningLabelText;
        private System.Windows.Forms.TextBox CodecIDInput;
        private System.Windows.Forms.TextBox subtitleLangInput;
        private System.Windows.Forms.Button stopScrollButton;
        private System.Windows.Forms.Button execButton1;
        private System.Windows.Forms.Label FuncLabelText1;
        private System.Windows.Forms.Button execButton2;
        private System.Windows.Forms.Button execButton3;
        private System.Windows.Forms.Button execButton4;
        private System.Windows.Forms.Button execButton5;
        private System.Windows.Forms.Button execButton6;
        private System.Windows.Forms.Button execButton8;
        private System.Windows.Forms.Button execButton9;
        private System.Windows.Forms.Button execButton10;
        private System.Windows.Forms.Button execButton11;
        private System.Windows.Forms.Button execButton12;
        private System.Windows.Forms.Button execButton13;
        private System.Windows.Forms.Label FuncLabelText2;
        private System.Windows.Forms.Label FuncLabelText3;
        private System.Windows.Forms.Label FuncLabelText4;
        private System.Windows.Forms.Label FuncLabelText5;
        private System.Windows.Forms.Label FuncLabelText6;
        private System.Windows.Forms.Label FuncLabelText8;
        private System.Windows.Forms.Label FuncLabelText9;
        private System.Windows.Forms.Label FuncLabelText10;
        private System.Windows.Forms.Label FuncLabelText11;
        private System.Windows.Forms.Label FuncLabelText12;
        private System.Windows.Forms.Label FuncLabelText13;
        private System.Windows.Forms.TextBox manualCodeInput;
        private System.Windows.Forms.ToolStripMenuItem バージョンToolStripMenuItem;
    }
}

