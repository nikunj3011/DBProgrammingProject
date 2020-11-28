using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerFields
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(100);
                for (int i = 0; i <= 100; i++)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        progressBar1.Value = i;
                        System.Threading.Thread.Sleep(50);
                        progressBar1.Refresh();
                    });
                }
            }).ContinueWith((x) => {
                this.Invoke((MethodInvoker)delegate
                { this.Close(); });
            });
        }
    }
}
