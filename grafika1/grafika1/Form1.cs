using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            labelUsername.Text = textBoxInput.Text;
            textBoxInput.Clear();
            if (textBoxInput.Text == "Piros")
            {
                Form1.ActiveForm.BackColor = Color.Red;
            }
            else if (textBoxInput.Text == "Zöld")
            {
                Form1.ActiveForm.BackColor = Color.Green;
            }
        }
        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}