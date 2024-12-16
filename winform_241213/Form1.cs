using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_241213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //textBox_point.Text = "집가고싶다\r집가고싶다\n집가고시다\r\n집가고시다";
            int a = 23123;
        }

        private void textBox_point_MouseUp(object sender, MouseEventArgs e)
        {
            textBox_point.Text = "집가고싶다\r집가고싶다\n집가고시다\r\n집가고시다";
        }
    }
}
