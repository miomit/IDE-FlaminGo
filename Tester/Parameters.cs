using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();

            //Data.LocationCompiler = "dsa";

            textBox1.Text = Data.LocationCompiler;
        }

        private void save_Click(object sender, EventArgs e)
        {
            Data.LocationCompiler = textBox1.Text;

            this.Close();
        }

        private void openLocationCompiler_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                textBox1.Text = openFile.FileName;
        }
    }
}
