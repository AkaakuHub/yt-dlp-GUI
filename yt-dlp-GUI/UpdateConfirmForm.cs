using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yt_dlp_GUI
{
    public partial class UpdateConfirmForm : Form
    {
        public UpdateConfirmForm(string currentVersion, string newVersion)
        {
            InitializeComponent();

            currentVersionLabelText.Text = currentVersion;
            newVersionLabelText.Text = newVersion;
        }
        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void UpdateConfirmForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = yesButton;
        }
    }
}
