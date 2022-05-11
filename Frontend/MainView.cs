using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class MainView : Form
    {
        private PrivateKey privateKey;
        private string textToDecrypt;
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
        }

        private void openFileXml_FileOk(object sender, CancelEventArgs e)
        {
            this.privateKey = XmlHandler.LoadPrivateKeyXml(this.openFileXml.FileName);
            this.privateKeyText.Text = "Modulus: " + this.privateKey.Modulus;
            this.privateKeyText.Text += "\nExponent: " + this.privateKey.Exponent;
            this.privateKeyText.Text += "\nP: " + this.privateKey.P;
            this.privateKeyText.Text += "\nQ: " + this.privateKey.Q;
            this.privateKeyText.Text += "\nDP: " + this.privateKey.DP;
            this.privateKeyText.Text += "\nDQ: " + this.privateKey.DQ;
            this.privateKeyText.Text += "\nInverseQ: " + this.privateKey.InverseQ;
            this.privateKeyText.Text += "\nD: " + this.privateKey.D;

            this.importTxtBtn.Enabled = true;
        }

        private void importXMLBtn_Click(object sender, EventArgs e)
        {
            this.openFileXml.ShowDialog();
        }

        private void importTxtBtn_Click(object sender, EventArgs e)
        {
            this.openFileTxt.ShowDialog();
        }

        private void openFileTxt_FileOk(object sender, CancelEventArgs e)
        {
            this.txtText.Text = System.IO.File.ReadAllText(this.openFileTxt.FileName);
            this.textToDecrypt = this.txtText.Text;
            this.decryptBtn.Enabled = true;
        }

        private async void decryptBtn_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
           var content = new StringContent(JsonConvert.SerializeObject(new DecryptionRequest() { privateKey = this.privateKey, encryptedString = this.textToDecrypt}), Encoding.UTF8, "application/json");
            var res = await client.PostAsync("https://localhost:44355/api/Rsa", content);
            this.decryptionText.Text = await res.Content.ReadAsStringAsync();
        }
    }
}
