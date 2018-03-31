using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Amal");
            listBox1.Items.Add("Mohammed");
            listBox1.Items.Add("hanan");
            listBox1.Items.Add("Alaa");
            listBox1.Items.Add("khalid");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
                listBox1.Items.Remove(listBox1.SelectedItem);
                else 
                MessageBox .Show ("Please select the name you want to delete");
            
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }
    }
}
