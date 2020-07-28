using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIOTQU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // ini form
            InitializeComponent();
            Text = Application.ProductName;
            PCConfig config = new PCConfig();
            // show computer data on form
            labelRAMString.Text = config.memoryTotalString;
            labelVideoAdapter.Text = config.videoAdapter;
            labelWin.Text = config.windows;
            labelProcessor.Text = config.processorName;
            // clear config use Dispose
            config.Dispose();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
