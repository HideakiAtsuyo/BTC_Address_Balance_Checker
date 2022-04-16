using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BTCAddressBalanceChecker
{
    public partial class BTCAddressBalanceCheckerForm : Form
    {
        /*==========Move Form==========*/
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        /*==========Move Form==========*/
        public BTCAddressBalanceCheckerForm()
        {
            InitializeComponent();
            this.MouseDown += BTCAddressBalanceCheckerForm_MouseDown;
            Console.Title = "BTC Address Balance Checker | github.com/HideakiAtsuyo";
        }

        private void BTCAddressBalanceCheckerForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void HACloseBTN_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void HAMinimizeBTN_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void HAAddBTCAddressBTN_Click(object sender, EventArgs e) => HABTCAddressLB.Items.Add(HABTCAddressTB.Text);

        private void HARemoveBTCAddressBTN_Click(object sender, EventArgs e) => HABTCAddressLB.Items.Remove(HABTCAddressLB.SelectedItem);

        private void HACheckAddressesBTN_Click(object sender, EventArgs e)
        {
            Console.Clear();
            for (int i = 0; i < HABTCAddressLB.Items.Count; i++)
                checkBalance(HABTCAddressLB.Items[i].ToString());
        }

        private void HACheckAddressBTN_Click(object sender, EventArgs e)
        {
            if (HABTCAddressLB.SelectedIndex != -1)
            {
                Console.Clear();
                string addr = HABTCAddressLB.Items[HABTCAddressLB.SelectedIndex].ToString();
                if (addr.Length > 1)
                    checkBalance(addr);
            }
        }
        private void checkBalance(string address)
        {
            string uri = String.Format("https://api.blockcypher.com/v1/btc/main/addrs/{0}/balance", address);
            JObject json = JObject.Parse(new WebClient().DownloadString(uri));
            float balance = (float)((float)json["balance"] / 100000000);
            string final = String.Format("[{0}] {1}", address, balance);
            Console.WriteLine(final);
        }
    }
}
