using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == " ")
            {
                textBox1.Text = "Напишите что-нибудь";
            }

            Encrypt messEncrypt = new Encrypt();
            string refmessEncrypt = textBox1.Text.ToLower().ToString();
            messEncrypt.encrypt(ref refmessEncrypt);
            textBox3.Text = refmessEncrypt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == " ")
            {
                textBox2.Text = "Напишите что-нибудь";
            }

            Decrypt messDecrypt = new Decrypt();
            string refmessDecrypt = textBox2.Text.ToLower().ToString();
            messDecrypt.decrypt(ref refmessDecrypt);
            textBox4.Text = refmessDecrypt;
        }
    }
}
