using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend;

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
            var decrypted = RSA.Decrypt(XmlHandler.LoadPrivateKeyXml(this.openFileXml.FileName),
                "ZDA3dzNpMnJTVG0yQ3FQS25RUFBIV0tLWjVrNHlqQi9oM3hTVFFRdWxsbnRMcU1tQzdGb2E5RW82a0FRSTJxODVpYWp5Nkhzc2hGWXBRcVNVN0FIWnRhU24wVnBxL1F2cE5lZXBxdm9qYm52YnFndnRqVEJnSzU5bzNjeHJRU2ptTVFYanYwYWlmektaSmhnZ3R1MTNKMlBrZlBKVzJzUzVUQzNBT3NVUlJ3PQ==");

        }

        private void importXMLBtn_Click(object sender, EventArgs e)
        {
            this.openFileXml.ShowDialog();
        }
    }
}
