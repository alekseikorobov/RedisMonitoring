using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisMonitoring.Dialog
{
    public partial class ConfigForm : Form
    {
        private string jsonFile;

        public ConfigForm()
        {
            InitializeComponent();
        }

        public ConfigForm(string jsonFile) : this()
        {
            this.jsonFile = jsonFile;
            if (File.Exists(jsonFile))
            {
                try
                {
                    var json = File.ReadAllText(jsonFile);
                    config = Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private Config config;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IServer Server { get; set; }
        private void connectButton_Click(object sender, EventArgs e)
        {
            errorMassageLabel.Invoke((MethodInvoker)delegate
            {
                errorMassageLabel.Text = "Connecting...";
            });

            var th = new Thread(() =>
            {
                try
                {
                    config = new Config
                    {
                        ConnectionPassword = this.passwordTextBox.Text,
                        ConnectionString = this.connectionStringTextBox.Text
                    };

                    TryConnect();

                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(config);
                    File.WriteAllText(jsonFile, jsonString);

                    this.EndConnect();
                }
                catch (Exception ex)
                {
                    errorMassageLabel.Invoke((MethodInvoker)delegate
                    {
                        errorMassageLabel.Text = ex.Message;
                    });
                }
            });
            th.Start();
        }

        public bool TryConnect()
        {
            if (config == null) return false;

            this.connectionStringTextBox.Text = config.ConnectionString;
            this.passwordTextBox.Text = config.ConnectionPassword;

            string connectPass = "";
            if (!string.IsNullOrEmpty(this.passwordTextBox.Text))
                connectPass = ",password=" + passwordTextBox.Text;
            var connectionString = this.connectionStringTextBox.Text + connectPass;

            var connectionStringConfig = ConfigurationOptions.Parse(connectionString);
            ConnectionMultiplexer.SetFeatureFlag("preventthreadtheft", true);
            connectionStringConfig.AllowAdmin = true;

            var multiplexer = ConnectionMultiplexer.Connect(connectionStringConfig);

            Server = multiplexer.GetServer(connectionStringConfig.EndPoints[0]);

            return true;
        }

        private void EndConnect()
        {
            errorMassageLabel.Invoke((MethodInvoker)delegate
            {
                errorMassageLabel.Text = "Connected";
                this.DialogResult = DialogResult.OK;
            });
        }
    }
}
