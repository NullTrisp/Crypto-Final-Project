
namespace Frontend
{
    partial class MainView
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
            this.openFileXml = new System.Windows.Forms.OpenFileDialog();
            this.privateKeyText = new System.Windows.Forms.RichTextBox();
            this.importXMLBtn = new System.Windows.Forms.Button();
            this.importTxtBtn = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.openFileTxt = new System.Windows.Forms.OpenFileDialog();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.decryptionText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileXml
            // 
            this.openFileXml.DefaultExt = "xml";
            this.openFileXml.Filter = "XML files (*.xml)|*.xml";
            this.openFileXml.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileXml_FileOk);
            // 
            // privateKeyText
            // 
            this.privateKeyText.Enabled = false;
            this.privateKeyText.Location = new System.Drawing.Point(12, 74);
            this.privateKeyText.Name = "privateKeyText";
            this.privateKeyText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.privateKeyText.Size = new System.Drawing.Size(755, 187);
            this.privateKeyText.TabIndex = 1;
            this.privateKeyText.Text = "";
            // 
            // importXMLBtn
            // 
            this.importXMLBtn.Location = new System.Drawing.Point(345, 21);
            this.importXMLBtn.Margin = new System.Windows.Forms.Padding(2);
            this.importXMLBtn.Name = "importXMLBtn";
            this.importXMLBtn.Size = new System.Drawing.Size(95, 29);
            this.importXMLBtn.TabIndex = 0;
            this.importXMLBtn.Text = "Load private key";
            this.importXMLBtn.UseVisualStyleBackColor = true;
            this.importXMLBtn.Click += new System.EventHandler(this.importXMLBtn_Click);
            // 
            // importTxtBtn
            // 
            this.importTxtBtn.Enabled = false;
            this.importTxtBtn.Location = new System.Drawing.Point(345, 291);
            this.importTxtBtn.Margin = new System.Windows.Forms.Padding(2);
            this.importTxtBtn.Name = "importTxtBtn";
            this.importTxtBtn.Size = new System.Drawing.Size(95, 29);
            this.importTxtBtn.TabIndex = 2;
            this.importTxtBtn.Text = "Load Encrypted Text";
            this.importTxtBtn.UseVisualStyleBackColor = true;
            this.importTxtBtn.Click += new System.EventHandler(this.importTxtBtn_Click);
            // 
            // txtText
            // 
            this.txtText.Enabled = false;
            this.txtText.Location = new System.Drawing.Point(12, 325);
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtText.Size = new System.Drawing.Size(755, 58);
            this.txtText.TabIndex = 3;
            this.txtText.Text = "";
            // 
            // openFileTxt
            // 
            this.openFileTxt.DefaultExt = "txt";
            this.openFileTxt.Filter = "TXT files (*.txt)|*.txt";
            this.openFileTxt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileTxt_FileOk);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Enabled = false;
            this.decryptBtn.Location = new System.Drawing.Point(345, 419);
            this.decryptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(95, 29);
            this.decryptBtn.TabIndex = 4;
            this.decryptBtn.Text = "Decrypt!";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // decryptionText
            // 
            this.decryptionText.Enabled = false;
            this.decryptionText.Location = new System.Drawing.Point(12, 453);
            this.decryptionText.Name = "decryptionText";
            this.decryptionText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.decryptionText.Size = new System.Drawing.Size(755, 58);
            this.decryptionText.TabIndex = 5;
            this.decryptionText.Text = "";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 550);
            this.Controls.Add(this.decryptionText);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.importTxtBtn);
            this.Controls.Add(this.privateKeyText);
            this.Controls.Add(this.importXMLBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Main view";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.RichTextBox privateKeyText;
        private System.Windows.Forms.Button importXMLBtn;
        private System.Windows.Forms.Button importTxtBtn;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.OpenFileDialog openFileTxt;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.RichTextBox decryptionText;
    }
}

