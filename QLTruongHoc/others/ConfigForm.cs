using System.Configuration;


namespace QLTruongHoc.others
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            string hostname = ConfigurationManager.AppSettings["hostname"];
            string port = ConfigurationManager.AppSettings["port"];

            HostnameTxtBox.Text = hostname;
            PortTxtBox.Text = port;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string newHostname = HostnameTxtBox.Text;
                string newPort = PortTxtBox.Text;

                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["hostname"].Value = newHostname;
                config.AppSettings.Settings["port"].Value = newPort;
                config.Save(ConfigurationSaveMode.Modified);

                MessageBox.Show("Cập nhật cấu hình database thành công!");
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

