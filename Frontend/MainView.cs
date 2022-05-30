using Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
        }

        private void openFileXml_FileOk(object sender, CancelEventArgs e)
        {
            this.privateKeyText.Text = XmlHandler.LoadPrivateKey(this.openFileXml.FileName);

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

            this.Execute.Enabled = true;
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            var rsa = new Rsa() { Key = this.privateKeyText.Text, Txt = this.txtText.Text };


            this.decryptionText.Text = this.decryptRadioBtn.Checked ? rsa.Decrypt() : rsa.Encrypt();
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            this.encryptRadioBtn.Checked = false;
            this.decryptRadioBtn.Checked = false;
            this.privateKeyText.Text = "";
            this.importXMLBtn.Enabled = false;
            this.txtText.Text = "";
            this.importTxtBtn.Enabled = false;
            this.Execute.Enabled = false;
            this.decryptionText.Text = "";

        }

        private void encryptRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.importXMLBtn.Enabled = true;
        }

        private void decryptRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.importXMLBtn.Enabled = true;
        }

        private void privateKeyText_TextChanged(object sender, EventArgs e)
        {
            this.importTxtBtn.Enabled = true;
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            this.Execute.Enabled = true;
        }
    }
}
