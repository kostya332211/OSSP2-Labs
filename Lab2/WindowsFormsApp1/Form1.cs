using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveXCPP2Lib;
using AxActiveXCPP2Lib;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(axActiveXCPP21.Size.Width == axActiveXCPP21.Size.Height)
                MessageBox.Show("Circle radius:" + axActiveXCPP21.TestMyMethod(axActiveXCPP21.Size.Width));
            else
                MessageBox.Show("It's not a Circle. Radius:" + axActiveXCPP21.Size);
        }

    }
}
