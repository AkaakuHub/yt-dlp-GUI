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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OutputText = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.OpenSaveDIRButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isRunningLabelText = new System.Windows.Forms.Label();
            this.CodecIDInput = new System.Windows.Forms.TextBox();
            this.subtitleLangInput = new System.Windows.Forms.TextBox();
            this.stopScrollButton = new System.Windows.Forms.Button();
            this.FuncLabelText13 = new System.Windows.Forms.Label();
            this.manualCodeInput = new System.Windows.Forms.TextBox();
            this.execDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.triggerExecButton = new System.Windows.Forms.Button();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.環境設定 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存先の指定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookie取得元ブラウザの指定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitApplicationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョンToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.このアプリケーションについてToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.execDropDownPrev = new System.Windows.Forms.Button();
            this.execDropDownNext = new System.Windows.Forms.Button();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStripNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputText
            // 
            this.OutputText.BackColor = System.Drawing.SystemColors.WindowText;
            this.OutputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputText.Font = new System.Drawing.Font("Consolas", 10F);
            this.OutputText.ForeColor = System.Drawing.SystemColors.Window;
            this.OutputText.Location = new System.Drawing.Point(12, 437);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ReadOnly = true;
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(1240, 232);
            this.OutputText.TabIndex = 4;
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.stopButton.Location = new System.Drawing.Point(12, 234);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(125, 41);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "プログラムを停止";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // OpenSaveDIRButton
            // 
            this.OpenSaveDIRButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.OpenSaveDIRButton.Location = new System.Drawing.Point(12, 381);
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
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "コーデックID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label3.Location = new System.Drawing.Point(9, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "字幕言語";
            // 
            // isRunningLabelText
            // 
            this.isRunningLabelText.AutoSize = true;
            this.isRunningLabelText.BackColor = System.Drawing.Color.IndianRed;
            this.isRunningLabelText.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.isRunningLabelText.Location = new System.Drawing.Point(135, 386);
            this.isRunningLabelText.Name = "isRunningLabelText";
            this.isRunningLabelText.Padding = new System.Windows.Forms.Padding(5);
            this.isRunningLabelText.Size = new System.Drawing.Size(165, 31);
            this.isRunningLabelText.TabIndex = 12;
            this.isRunningLabelText.Text = "プログラムを実行中です";
            this.isRunningLabelText.Visible = false;
            // 
            // CodecIDInput
            // 
            this.CodecIDInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.CodecIDInput.Location = new System.Drawing.Point(93, 36);
            this.CodecIDInput.Name = "CodecIDInput";
            this.CodecIDInput.Size = new System.Drawing.Size(100, 29);
            this.CodecIDInput.TabIndex = 13;
            this.CodecIDInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodecIDInput.TextChanged += new System.EventHandler(this.CodecIDInput_TextChanged);
            // 
            // subtitleLangInput
            // 
            this.subtitleLangInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.subtitleLangInput.Location = new System.Drawing.Point(93, 80);
            this.subtitleLangInput.Name = "subtitleLangInput";
            this.subtitleLangInput.Size = new System.Drawing.Size(100, 29);
            this.subtitleLangInput.TabIndex = 14;
            this.subtitleLangInput.Text = "ja";
            this.subtitleLangInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subtitleLangInput.TextChanged += new System.EventHandler(this.subtitleLangInput_TextChanged);
            // 
            // stopScrollButton
            // 
            this.stopScrollButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.stopScrollButton.Location = new System.Drawing.Point(12, 286);
            this.stopScrollButton.Name = "stopScrollButton";
            this.stopScrollButton.Size = new System.Drawing.Size(125, 41);
            this.stopScrollButton.TabIndex = 15;
            this.stopScrollButton.Text = "スクロールを停止";
            this.stopScrollButton.UseVisualStyleBackColor = true;
            this.stopScrollButton.Visible = false;
            this.stopScrollButton.Click += new System.EventHandler(this.stopScrollButton_Click);
            // 
            // FuncLabelText13
            // 
            this.FuncLabelText13.AutoSize = true;
            this.FuncLabelText13.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.FuncLabelText13.Location = new System.Drawing.Point(366, 396);
            this.FuncLabelText13.Name = "FuncLabelText13";
            this.FuncLabelText13.Size = new System.Drawing.Size(123, 21);
            this.FuncLabelText13.TabIndex = 39;
            this.FuncLabelText13.Text = "任意コード yt-dlp ";
            // 
            // manualCodeInput
            // 
            this.manualCodeInput.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.manualCodeInput.Location = new System.Drawing.Point(495, 392);
            this.manualCodeInput.Name = "manualCodeInput";
            this.manualCodeInput.Size = new System.Drawing.Size(741, 29);
            this.manualCodeInput.TabIndex = 0;
            // 
            // execDropDown
            // 
            this.execDropDown.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.execDropDown.FormattingEnabled = true;
            this.execDropDown.ItemHeight = 21;
            this.execDropDown.Items.AddRange(new object[] {
            "1.通常DL",
            "2.音声DL",
            "3.最高品質DL",
            "4.サムネイルDL",
            "5.フォーマット自動DL",
            "6.字幕DL",
            "----------",
            "7.リストを表示",
            "8.コーデックIDを指定DL",
            "----------",
            "9.リストを表示(Pre)",
            "10.コーデックIDを指定DL(Pre)",
            "----------",
            "11.コーデックID141",
            "12.配信録画",
            "13.任意コード >yt-dlp"});
            this.execDropDown.Location = new System.Drawing.Point(82, 139);
            this.execDropDown.MaxDropDownItems = 100;
            this.execDropDown.Name = "execDropDown";
            this.execDropDown.Size = new System.Drawing.Size(268, 29);
            this.execDropDown.TabIndex = 40;
            this.execDropDown.SelectedIndexChanged += new System.EventHandler(this.execDropDown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 41;
            this.label4.Text = "モード";
            // 
            // triggerExecButton
            // 
            this.triggerExecButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.triggerExecButton.Location = new System.Drawing.Point(368, 36);
            this.triggerExecButton.Name = "triggerExecButton";
            this.triggerExecButton.Size = new System.Drawing.Size(868, 329);
            this.triggerExecButton.TabIndex = 42;
            this.triggerExecButton.Text = "ここをクリックして開始";
            this.triggerExecButton.UseVisualStyleBackColor = true;
            this.triggerExecButton.Click += new System.EventHandler(this.triggerExecButton_Click);
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
            // execDropDownPrev
            // 
            this.execDropDownPrev.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.execDropDownPrev.Location = new System.Drawing.Point(264, 173);
            this.execDropDownPrev.Name = "execDropDownPrev";
            this.execDropDownPrev.Size = new System.Drawing.Size(40, 38);
            this.execDropDownPrev.TabIndex = 43;
            this.execDropDownPrev.Text = "◀";
            this.execDropDownPrev.UseVisualStyleBackColor = true;
            this.execDropDownPrev.Click += new System.EventHandler(this.execDropDownPrev_Click);
            // 
            // execDropDownNext
            // 
            this.execDropDownNext.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.execDropDownNext.Location = new System.Drawing.Point(310, 173);
            this.execDropDownNext.Name = "execDropDownNext";
            this.execDropDownNext.Size = new System.Drawing.Size(40, 38);
            this.execDropDownNext.TabIndex = 43;
            this.execDropDownNext.Text = "▶";
            this.execDropDownNext.UseVisualStyleBackColor = true;
            this.execDropDownNext.Click += new System.EventHandler(this.execDropDownNext_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.contextMenuStripNotification;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "yt-dlp-GUI";
            this.notifyIconMain.Visible = true;
            // 
            // contextMenuStripNotification
            // 
            this.contextMenuStripNotification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.終了ToolStripMenuItem});
            this.contextMenuStripNotification.Name = "contextMenuStripNotification";
            this.contextMenuStripNotification.Size = new System.Drawing.Size(99, 26);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.execDropDownNext);
            this.Controls.Add(this.execDropDownPrev);
            this.Controls.Add(this.triggerExecButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.execDropDown);
            this.Controls.Add(this.manualCodeInput);
            this.Controls.Add(this.FuncLabelText13);
            this.Controls.Add(this.stopScrollButton);
            this.Controls.Add(this.subtitleLangInput);
            this.Controls.Add(this.CodecIDInput);
            this.Controls.Add(this.isRunningLabelText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OpenSaveDIRButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "yt-dlp-GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStripNotification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button OpenSaveDIRButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label isRunningLabelText;
        private System.Windows.Forms.TextBox CodecIDInput;
        private System.Windows.Forms.TextBox subtitleLangInput;
        private System.Windows.Forms.Button stopScrollButton;
        private System.Windows.Forms.Button execButton1;
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
        private System.Windows.Forms.Label FuncLabelText13;
        private System.Windows.Forms.TextBox manualCodeInput;
        private System.Windows.Forms.ComboBox execDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button triggerExecButton;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 環境設定;
        private System.Windows.Forms.ToolStripMenuItem 保存先の指定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cookie取得元ブラウザの指定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitApplicationMenu;
        private System.Windows.Forms.ToolStripMenuItem ヘルプToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョンToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem このアプリケーションについてToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button execDropDownPrev;
        private System.Windows.Forms.Button execDropDownNext;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotification;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}

