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
        private ToolStripLabel label_ram_context_menu;
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

        /// <summary>
        /// Copyred config pc to buffer system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCopyToBuffer_Click(object sender, EventArgs e)
        {
            string data = "Processor/Процессор: " + labelProcessor.Text + "\nRAM/Оперативная память: " + labelRAMString.Text + "\nWindows: " + labelWin.Text + "\nVideoadapter: " + labelVideoAdapter.Text;
            Clipboard.SetText(data);
            MessageBox.Show("data of configuration computer pasted to buffer your system.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// refreshed data % CPU and RAM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUpdateCPU_Tick(object sender, EventArgs e)
        {
            // get cpu %
          float cpu_data =  CPU.NextValue();
            if (cpu_data < 50)
            {
                temp_cpu.ForeColor = Color.LightGreen;
            }

            if (cpu_data >= 50)
            {
                temp_cpu.ForeColor = Color.Yellow;
            }

            if (cpu_data >= 85)
            {
                temp_cpu.ForeColor = Color.Red;
            }
            temp_cpu.Text = "CPU: " + string.Format("{0:0}%", cpu_data);

           
            // get ram %
            float ram_data = RAM.NextValue();
            if (ram_data < 50)
            {
               temp_ram.ForeColor = Color.LightGreen;
            }

            if (ram_data >= 50)
            {
                temp_ram.ForeColor = Color.Yellow;
            }

            if (ram_data >= 85)
            {
                temp_ram.ForeColor = Color.Red;
            }
            temp_ram.Text = "RAM: " + string.Format("{0:0}%", ram_data);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
