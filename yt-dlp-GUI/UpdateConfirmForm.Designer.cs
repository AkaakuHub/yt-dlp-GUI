namespace yt_dlp_GUI
{
    partial class UpdateConfirmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateConfirmForm));
            this.label1 = new System.Windows.Forms.Label();
            this.noButton = new System.Windows.Forms.Button();
            this.yesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentVersionLabelText = new System.Windows.Forms.Label();
            this.newVersionLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "新しいバージョンがあります。アップデートしますか？";
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(43, 87);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "いいえ";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(169, 87);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "はい";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "現在のバージョン：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "最新のバージョン：";
            // 
            // currentVersionLabelText
            // 
            this.currentVersionLabelText.AutoSize = true;
            this.currentVersionLabelText.Location = new System.Drawing.Point(169, 41);
            this.currentVersionLabelText.Name = "currentVersionLabelText";
            this.currentVersionLabelText.Size = new System.Drawing.Size(23, 12);
            this.currentVersionLabelText.TabIndex = 5;
            this.currentVersionLabelText.Text = "000";
            // 
            // newVersionLabelText
            // 
            this.newVersionLabelText.AutoSize = true;
            this.newVersionLabelText.Location = new System.Drawing.Point(169, 61);
            this.newVersionLabelText.Name = "newVersionLabelText";
            this.newVersionLabelText.Size = new System.Drawing.Size(23, 12);
            this.newVersionLabelText.TabIndex = 6;
            this.newVersionLabelText.Text = "000";
            // 
            // UpdateConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 131);
            this.Controls.Add(this.newVersionLabelText);
            this.Controls.Add(this.currentVersionLabelText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateConfirmForm";
            this.Text = "yt-dlp-GUI - アップデートの確認";
            this.Load += new System.EventHandler(this.UpdateConfirmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label currentVersionLabelText;
        private System.Windows.Forms.Label newVersionLabelText;
    }
}