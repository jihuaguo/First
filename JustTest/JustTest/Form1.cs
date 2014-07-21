using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JustTest
{
    public partial class Form1 : Form
    {
        private const string constString = "jihauguo";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Form1.constString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
