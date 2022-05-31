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
using System.Security.Cryptography;
using System.Security;

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
            var xml = new XmlHandler()
            {
                Path = this.openFileXml.FileName
            };
            this.privateKeyText.Text = xml.LoadPrivateKey();

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

            try
            {
                this.decryptionText.Text = this.decryptRadioBtn.Checked ? rsa.Decrypt() : rsa.Encrypt();
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show($"ERROR WHILE PERFORMING ACTION: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (XmlSyntaxException ex)
            {
                MessageBox.Show($"ERROR IN XML: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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
            if (this.decryptRadioBtn.Checked || this.encryptRadioBtn.Checked)
            {
                this.importTxtBtn.Enabled = true;
            }
            else
            {
                this.privateKeyText.Text = String.Empty;
            }
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            if ((this.decryptRadioBtn.Checked || this.encryptRadioBtn.Checked) && this.importTxtBtn.Enabled)
            {
                this.Execute.Enabled = true;
            }
            else
            {
                this.txtText.Text = string.Empty;
            }
        }
    }
}
