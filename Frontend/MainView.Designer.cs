
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
            this.Execute = new System.Windows.Forms.Button();
            this.decryptionText = new System.Windows.Forms.RichTextBox();
            this.encryptRadioBtn = new System.Windows.Forms.RadioButton();
            this.decryptRadioBtn = new System.Windows.Forms.RadioButton();
            this.rstBtn = new System.Windows.Forms.Button();
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
            this.privateKeyText.Location = new System.Drawing.Point(12, 87);
            this.privateKeyText.Name = "privateKeyText";
            this.privateKeyText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.privateKeyText.Size = new System.Drawing.Size(755, 187);
            this.privateKeyText.TabIndex = 1;
            this.privateKeyText.Text = "";
            this.privateKeyText.TextChanged += new System.EventHandler(this.privateKeyText_TextChanged);
            // 
            // importXMLBtn
            // 
            this.importXMLBtn.Enabled = false;
            this.importXMLBtn.Location = new System.Drawing.Point(345, 53);
            this.importXMLBtn.Margin = new System.Windows.Forms.Padding(2);
            this.importXMLBtn.Name = "importXMLBtn";
            this.importXMLBtn.Size = new System.Drawing.Size(95, 29);
            this.importXMLBtn.TabIndex = 0;
            this.importXMLBtn.Text = "Load Key";
            this.importXMLBtn.UseVisualStyleBackColor = true;
            this.importXMLBtn.Click += new System.EventHandler(this.importXMLBtn_Click);
            // 
            // importTxtBtn
            // 
            this.importTxtBtn.Enabled = false;
            this.importTxtBtn.Location = new System.Drawing.Point(345, 279);
            this.importTxtBtn.Margin = new System.Windows.Forms.Padding(2);
            this.importTxtBtn.Name = "importTxtBtn";
            this.importTxtBtn.Size = new System.Drawing.Size(95, 29);
            this.importTxtBtn.TabIndex = 2;
            this.importTxtBtn.Text = "Load Text";
            this.importTxtBtn.UseVisualStyleBackColor = true;
            this.importTxtBtn.Click += new System.EventHandler(this.importTxtBtn_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 313);
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtText.Size = new System.Drawing.Size(755, 58);
            this.txtText.TabIndex = 3;
            this.txtText.Text = "";
            this.txtText.TextChanged += new System.EventHandler(this.txtText_TextChanged);
            // 
            // openFileTxt
            // 
            this.openFileTxt.DefaultExt = "txt";
            this.openFileTxt.Filter = "TXT files (*.txt)|*.txt";
            this.openFileTxt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileTxt_FileOk);
            // 
            // Execute
            // 
            this.Execute.Enabled = false;
            this.Execute.Location = new System.Drawing.Point(345, 388);
            this.Execute.Margin = new System.Windows.Forms.Padding(2);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(95, 29);
            this.Execute.TabIndex = 4;
            this.Execute.Text = "Execute!";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // decryptionText
            // 
            this.decryptionText.Location = new System.Drawing.Point(12, 422);
            this.decryptionText.Name = "decryptionText";
            this.decryptionText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.decryptionText.Size = new System.Drawing.Size(755, 58);
            this.decryptionText.TabIndex = 5;
            this.decryptionText.Text = "";
            // 
            // encryptRadioBtn
            // 
            this.encryptRadioBtn.AutoSize = true;
            this.encryptRadioBtn.Location = new System.Drawing.Point(12, 12);
            this.encryptRadioBtn.Name = "encryptRadioBtn";
            this.encryptRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.encryptRadioBtn.TabIndex = 6;
            this.encryptRadioBtn.TabStop = true;
            this.encryptRadioBtn.Text = "Encrypt";
            this.encryptRadioBtn.UseVisualStyleBackColor = true;
            this.encryptRadioBtn.CheckedChanged += new System.EventHandler(this.encryptRadioBtn_CheckedChanged);
            // 
            // decryptRadioBtn
            // 
            this.decryptRadioBtn.AutoSize = true;
            this.decryptRadioBtn.Location = new System.Drawing.Point(12, 35);
            this.decryptRadioBtn.Name = "decryptRadioBtn";
            this.decryptRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.decryptRadioBtn.TabIndex = 7;
            this.decryptRadioBtn.TabStop = true;
            this.decryptRadioBtn.Text = "Decrypt";
            this.decryptRadioBtn.UseVisualStyleBackColor = true;
            this.decryptRadioBtn.CheckedChanged += new System.EventHandler(this.decryptRadioBtn_CheckedChanged);
            // 
            // rstBtn
            // 
            this.rstBtn.Location = new System.Drawing.Point(345, 494);
            this.rstBtn.Margin = new System.Windows.Forms.Padding(2);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(95, 29);
            this.rstBtn.TabIndex = 8;
            this.rstBtn.Text = "Reset";
            this.rstBtn.UseVisualStyleBackColor = true;
            this.rstBtn.Click += new System.EventHandler(this.rstBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 550);
            this.Controls.Add(this.rstBtn);
            this.Controls.Add(this.decryptRadioBtn);
            this.Controls.Add(this.encryptRadioBtn);
            this.Controls.Add(this.decryptionText);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.importTxtBtn);
            this.Controls.Add(this.privateKeyText);
            this.Controls.Add(this.importXMLBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Main view";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.RichTextBox privateKeyText;
        private System.Windows.Forms.Button importXMLBtn;
        private System.Windows.Forms.Button importTxtBtn;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.OpenFileDialog openFileTxt;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.RichTextBox decryptionText;
        private System.Windows.Forms.RadioButton encryptRadioBtn;
        private System.Windows.Forms.RadioButton decryptRadioBtn;
        private System.Windows.Forms.Button rstBtn;
    }
}

