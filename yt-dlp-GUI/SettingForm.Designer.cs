namespace yt_dlp_GUI
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.SettingNameText = new System.Windows.Forms.Label();
            this.SettingInput = new System.Windows.Forms.TextBox();
            this.SettingOKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingNameText
            // 
            this.SettingNameText.AutoSize = true;
            this.SettingNameText.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.SettingNameText.Location = new System.Drawing.Point(12, 9);
            this.SettingNameText.Name = "SettingNameText";
            this.SettingNameText.Size = new System.Drawing.Size(41, 12);
            this.SettingNameText.TabIndex = 0;
            this.SettingNameText.Text = "aaaaaa";
            this.SettingNameText.Click += new System.EventHandler(this.SettingNameText_Click);
            // 
            // SettingInput
            // 
            this.SettingInput.Location = new System.Drawing.Point(12, 41);
            this.SettingInput.Name = "SettingInput";
            this.SettingInput.Size = new System.Drawing.Size(496, 19);
            this.SettingInput.TabIndex = 1;
            this.SettingInput.TextChanged += new System.EventHandler(this.SettingInput_TextChanged);
            // 
            // SettingOKButton
            // 
            this.SettingOKButton.Location = new System.Drawing.Point(529, 41);
            this.SettingOKButton.Name = "SettingOKButton";
            this.SettingOKButton.Size = new System.Drawing.Size(75, 19);
            this.SettingOKButton.TabIndex = 2;
            this.SettingOKButton.Text = "OK";
            this.SettingOKButton.UseVisualStyleBackColor = true;
            this.SettingOKButton.Click += new System.EventHandler(this.SettingOKButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 72);
            this.Controls.Add(this.SettingOKButton);
            this.Controls.Add(this.SettingInput);
            this.Controls.Add(this.SettingNameText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingNameText;
        private System.Windows.Forms.TextBox SettingInput;
        private System.Windows.Forms.Button SettingOKButton;
    }
}