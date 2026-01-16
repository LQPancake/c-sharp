using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( cukorSok.Checked == true)
            {labelEredmeny.Text = "Sok cukor";}
            else { labelEredmeny.Text = "Nem sok cukor"; }
        }

        private void tea_CheckedChanged(object sender, EventArgs e)
        {
            checkboxCitrom.Enabled = true;
            checkboxCitrom.Checked = false;
            checkboxKavekrem.Enabled = false;
            checkboxTejpor.Enabled = false;
            checkboxTejszin.Enabled = false;
            checkboxTejszin.Checked = false;
            checkboxKavekrem.Checked = false;
            checkboxTejpor.Checked = false;
        }

        private void espresso_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
        }

        private void duplaKave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
        }

        private void hosszuKave_CheckedChanged(object sender, EventArgs e)
        {
            IngredientsSettings();
        }
        private void IngredientsSettings()
        {
            checkboxCitrom.Enabled = false;
            checkboxCitrom.Checked = false;
            checkboxKavekrem.Enabled = true;
            checkboxTejpor.Enabled = true;
            checkboxTejszin.Enabled = true;
            checkboxTejszin.Checked = false;
            checkboxKavekrem.Checked = false;
            checkboxTejpor.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}