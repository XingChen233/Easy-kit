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
            File.WriteAllText(textBox6.Text+@"\"+textBox9.Text+".txt", textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Encrypt(textBox10.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.Decrypt(textBox11.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*.*)|*.*"; if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                label10.Text = file;
               
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            File.WriteAllText(textBox12.Text+textBox13.Text, label10.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string gg = listBox1.SelectedItem.ToString();
            if (gg == "LINUX终端")
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            if (gg == "IROBOTQ")
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"XP使用下载功能请前往http://www.interlog.com/~tcharron/wgetwin-1_5_3_1-binary.zip下载ZIP然后将内部的文件放入C:\Windows\System32");
            MessageBox.Show("XP下载无法自定义文件名");
      }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/k wget" + " " + textBox1.Text);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            label15.Text = File.ReadAllText("cfg.ini").ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/k ping" + " " + textBox2.Text + " " + "-r" + " " + "1");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
