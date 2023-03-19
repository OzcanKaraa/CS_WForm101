using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btonMessage_Click(object sender, EventArgs e)
        {
            string message;

            message = tboxMessage.Text;

            //MessageBox.Show("Ali veli 49 50"); // aslında burada parametre göndermişim
            MessageBox.Show("Ali veli 49 50");

            //   MessageBox.Show(message); // aslında burada parametre göndermişim


            tboxMessage.Text = "";
            tboxMessage.Clear();
        }
    }
}
