using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Internet_Analyzer
{
    public partial class Form1_Main : Form
    {
        private NetworkInterface[] nicArr;

        public Form1_Main()
        {
            InitializeComponent();
            InitializeNetworkInterface();
        }

        private void InitializeNetworkInterface()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();

            for (int i = 0; i < nicArr.Length; i++)
                ComboBoxInterface.Items.Add(nicArr[i].Name);

            ComboBoxInterface.SelectedIndex = 0;
        }

        private void UpdateNetworkInterface(object sender, EventArgs e)
        {
            NetworkInterface nic = nicArr[ComboBoxInterface.SelectedIndex];

            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            int bytesSentSpeed = (int)(interfaceStats.BytesSent - double.Parse(LabelBytesSent.Text)) / 1024;
            int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - double.Parse(LabelBytesReceived.Text)) / 1024;
            int bytesSentSpeedKBi = bytesSentSpeed * 8;
            int bytesReceivedSpeedKBi = bytesReceivedSpeed * 8;

            LabelBytesReceived.Text = interfaceStats.BytesReceived.ToString();
            LabelBytesSent.Text = interfaceStats.BytesSent.ToString();

            LabelUpload.Text = bytesSentSpeed.ToString() + " KB/s";
            LabelDownload.Text = bytesReceivedSpeed.ToString() + " KB/s";
            LabelUploadBi.Text = bytesSentSpeedKBi.ToString() + " Kbit/s";
            LabelDownloadBi.Text = bytesReceivedSpeedKBi.ToString() + " Kbit/s";

        }

        private void MenuItemRollup_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void MenuItemClose_Click(object sender, EventArgs e) => Application.Exit();

        private void Form1_Main_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}