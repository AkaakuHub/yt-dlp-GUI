using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace yt_dlp_GUI
{
    public partial class SettingForm : Form
    {
        private string settingName;

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public SettingForm(string settingName)
        {
            InitializeComponent();

            this.settingName = settingName;
            SettingNameText.Text = settingName + "の設定";

            // app.configから設定値を取得
            SettingInput.Text = config.AppSettings.Settings[settingName].Value;
        }

        private void SettingOKButton_Click(object sender, EventArgs e)
        {
            string settingValue = SettingInput.Text;
            config.AppSettings.Settings[settingName].Value = settingValue;
            config.Save();
            this.Close();

        }

        private void SettingInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingNameText_Click(object sender, EventArgs e)
        {

        }
    }
}
