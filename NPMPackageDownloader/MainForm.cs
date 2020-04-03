using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace NPMPackageDownloader
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            labelRegistry.Text = "";
            labelProgress.Text = "";
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            IList<Registry> registryList = new List<Registry>
            {
                new Registry()
                {
                    Name = "NPM",
                    Url = "https://registry.npmjs.com"
                },
                new Registry()
                {
                    Name = "Taobao",
                    Url = "https://registry.npm.taobao.org"
                }
            };

            comboBoxRegistry.DataSource = registryList;
            comboBoxRegistry.DisplayMember = "Name";
            comboBoxRegistry.ValueMember = "Url";

            labelRegistry.Text = comboBoxRegistry.SelectedValue.ToString();
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                btnCheck.Enabled = false;

                // Clear the comboBox first
                //comboBoxVersion.Items.Clear();


                var url = $"{comboBoxRegistry.SelectedValue}/{textBoxName.Text.ToLower()}";

                HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
                webRequest.Timeout = 10000;
                webRequest.Method = "GET";
                webRequest.Accept = "application/json";

                try
                {
                    HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

                    StreamReader sr = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8);
                    var jsonText = sr.ReadToEnd();

                    JObject jObject = JObject.Parse(jsonText);

                    IList<Package> packageList = new List<Package>();

                    foreach (var item in jObject["versions"])
                    {
                        packageList.Add(new Package()
                        {
                            Version = item.First["version"].ToString(),
                            Url = item.First["dist"]["tarball"].ToString()
                        });
                    }

                    comboBoxVersion.DataSource = packageList;
                    comboBoxVersion.DisplayMember = "Version";
                    comboBoxVersion.ValueMember = "Url";

                    btnCheck.Enabled = true;
                    comboBoxVersion.Enabled = true;
                    btnDownload.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    btnCheck.Enabled = true;
                }
            }
            else MessageBox.Show("Please input the package name");

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var downloadLink = comboBoxVersion.SelectedValue.ToString();
            var filename = downloadLink.Substring(downloadLink.LastIndexOf('/') + 1);
            DownloadFile(downloadLink, filename, DownloadProgressChanged, DownloadFileCompleted);
        }

        private void comboBoxRegistry_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelRegistry.Text = comboBoxRegistry.SelectedValue.ToString();
        }

        #region Download Function

        private void DownloadFile(string url, string saveFile, Action<int> downloadProgressChanged, Action downloadFileCompleted)
        {
            WebClient client = new WebClient();
            //client.Proxy = null;
            if (downloadProgressChanged != null)
            {
                client.DownloadProgressChanged += delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    Invoke(downloadProgressChanged, e.ProgressPercentage);
                };
            }
            if (downloadFileCompleted != null)
            {
                client.DownloadFileCompleted += delegate (object sender, AsyncCompletedEventArgs e)
                {
                    Invoke(downloadFileCompleted);
                };
            }
            try
            {
                client.DownloadFileAsync(new Uri(url), saveFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DownloadProgressChanged(int val)
        {
            progressBarDownload.Value = val;
            labelProgress.Text = $"{val}%";
            //if (val == 100) labelProgress.Text = "Done!";
            progressBarDownload.PerformStep();
        }

        private void DownloadFileCompleted()
        {
            labelProgress.Text = "Done!";
        }

        #endregion

        #region Lists

        public class Registry
        {
            public string Name { get; set; }
            public string Url { get; set; }
        }

        public class Package
        {
            public string Version { get; set; }
            public string Url { get; set; }
        }

        #endregion

    }
}
