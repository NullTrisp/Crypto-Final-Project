
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
            this.importXMLBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileXml
            // 
            this.openFileXml.DefaultExt = "xml";
            this.openFileXml.Filter = "XML files (*.xml)|*.xml";
            this.openFileXml.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileXml_FileOk);
            // 
            // importXMLBtn
            // 
            this.importXMLBtn.Location = new System.Drawing.Point(21, 24);
            this.importXMLBtn.Name = "importXMLBtn";
            this.importXMLBtn.Size = new System.Drawing.Size(127, 36);
            this.importXMLBtn.TabIndex = 0;
            this.importXMLBtn.Text = "Load private key";
            this.importXMLBtn.UseVisualStyleBackColor = true;
            this.importXMLBtn.Click += new System.EventHandler(this.importXMLBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.importXMLBtn);
            this.Name = "MainView";
            this.Text = "Main view";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileXml;
        private System.Windows.Forms.Button importXMLBtn;
    }
}

