namespace Internet_Analyzer
{
    partial class Form1_Main
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
            this.components = new System.ComponentModel.Container();
            this.ComboBoxInterface = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelUpload = new System.Windows.Forms.Label();
            this.LabelDownload = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.LabelBytesReceived = new System.Windows.Forms.Label();
            this.LabelBytesSent = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ConMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemRollup = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelDownloadBi = new System.Windows.Forms.Label();
            this.LabelUploadBi = new System.Windows.Forms.Label();
            this.ConMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxInterface
            // 
            this.ComboBoxInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInterface.FormattingEnabled = true;
            this.ComboBoxInterface.Location = new System.Drawing.Point(70, 6);
            this.ComboBoxInterface.Name = "ComboBoxInterface";
            this.ComboBoxInterface.Size = new System.Drawing.Size(205, 21);
            this.ComboBoxInterface.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Interface:";
            // 
            // LabelUpload
            // 
            this.LabelUpload.AutoSize = true;
            this.LabelUpload.Location = new System.Drawing.Point(115, 117);
            this.LabelUpload.Name = "LabelUpload";
            this.LabelUpload.Size = new System.Drawing.Size(13, 13);
            this.LabelUpload.TabIndex = 27;
            this.LabelUpload.Text = "0";
            // 
            // LabelDownload
            // 
            this.LabelDownload.AutoSize = true;
            this.LabelDownload.Location = new System.Drawing.Point(115, 91);
            this.LabelDownload.Name = "LabelDownload";
            this.LabelDownload.Size = new System.Drawing.Size(13, 13);
            this.LabelDownload.TabIndex = 26;
            this.LabelDownload.Text = "0";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(65, 117);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 13);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Upload:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(51, 91);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 13);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Download:";
            // 
            // LabelBytesReceived
            // 
            this.LabelBytesReceived.AutoSize = true;
            this.LabelBytesReceived.Location = new System.Drawing.Point(115, 65);
            this.LabelBytesReceived.Name = "LabelBytesReceived";
            this.LabelBytesReceived.Size = new System.Drawing.Size(13, 13);
            this.LabelBytesReceived.TabIndex = 21;
            this.LabelBytesReceived.Text = "0";
            // 
            // LabelBytesSent
            // 
            this.LabelBytesSent.AutoSize = true;
            this.LabelBytesSent.Location = new System.Drawing.Point(115, 39);
            this.LabelBytesSent.Name = "LabelBytesSent";
            this.LabelBytesSent.Size = new System.Drawing.Size(13, 13);
            this.LabelBytesSent.TabIndex = 20;
            this.LabelBytesSent.Text = "0";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(25, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(84, 13);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Получено байт:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 39);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 13);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "Отправлено байт:";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.UpdateNetworkInterface);
            // 
            // ConMenuStrip
            // 
            this.ConMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRollup,
            this.MenuItemClose});
            this.ConMenuStrip.Name = "ConMenuStrip";
            this.ConMenuStrip.Size = new System.Drawing.Size(126, 48);
            // 
            // MenuItemRollup
            // 
            this.MenuItemRollup.Name = "MenuItemRollup";
            this.MenuItemRollup.Size = new System.Drawing.Size(125, 22);
            this.MenuItemRollup.Text = "Свернуть";
            this.MenuItemRollup.Click += new System.EventHandler(this.MenuItemRollup_Click);
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.Size = new System.Drawing.Size(125, 22);
            this.MenuItemClose.Text = "Закрыть";
            this.MenuItemClose.Click += new System.EventHandler(this.MenuItemClose_Click);
            // 
            // LabelDownloadBi
            // 
            this.LabelDownloadBi.AutoSize = true;
            this.LabelDownloadBi.Location = new System.Drawing.Point(195, 91);
            this.LabelDownloadBi.Name = "LabelDownloadBi";
            this.LabelDownloadBi.Size = new System.Drawing.Size(13, 13);
            this.LabelDownloadBi.TabIndex = 31;
            this.LabelDownloadBi.Text = "0";
            // 
            // LabelUploadBi
            // 
            this.LabelUploadBi.AutoSize = true;
            this.LabelUploadBi.Location = new System.Drawing.Point(195, 117);
            this.LabelUploadBi.Name = "LabelUploadBi";
            this.LabelUploadBi.Size = new System.Drawing.Size(13, 13);
            this.LabelUploadBi.TabIndex = 32;
            this.LabelUploadBi.Text = "0";
            // 
            // Form1_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(281, 142);
            this.ContextMenuStrip = this.ConMenuStrip;
            this.Controls.Add(this.LabelUploadBi);
            this.Controls.Add(this.LabelDownloadBi);
            this.Controls.Add(this.LabelUpload);
            this.Controls.Add(this.LabelDownload);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.LabelBytesReceived);
            this.Controls.Add(this.LabelBytesSent);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ComboBoxInterface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1_Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Internet Analyzer";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_Main_MouseDown);
            this.ConMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxInterface;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label LabelUpload;
        private System.Windows.Forms.Label LabelDownload;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label LabelBytesReceived;
        private System.Windows.Forms.Label LabelBytesSent;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ContextMenuStrip ConMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRollup;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
        private System.Windows.Forms.Label LabelDownloadBi;
        private System.Windows.Forms.Label LabelUploadBi;
    }
}