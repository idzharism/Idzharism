using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TOMBOL1_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            MessageBox.Show("Haii " +nama+"\nJANGAN LUPA SENYUM HARI INI","ADA PESAN DARI AYANG :*");

        }

    }
}
