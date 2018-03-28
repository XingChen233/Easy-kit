using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("powershell.exe", "Invoke-WebRequest"+" "+textBox1.Text+" "+ "-OutFile"+" "+textBox8.Text);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("powershell.exe","ping" +" "+ textBox2.Text +" " +"-r"+" "+"1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "ping" + " "  + textBox2.Text + " " + "-r");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            File.Delete(@textBox3.Text);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox4.Text,textBox5.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(textBox4.Text, textBox5.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText(textBox6.Text+@"\New.txt", textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
