using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleUni1;

namespace FormsUni1
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

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePickerDob_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxPostcode_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            PersonDetails person = new PersonDetails
            {
                Name = textBoxName.Text,
                Dob = dateTimePickerDob.Value,
                Street = textBoxAddress.Text,
                Postcode = int.Parse(textBoxPostcode.Text),
                City = textBoxCity.Text,
                Designation = textBoxDesignation.Text
            };
            labelNameOutput.Text = $"Name: {person.Name}";
            labelDobOutput.Text = $"DOB: {person.Dob.ToShortDateString()}";
            labelAddressOutput.Text = $"Street: {person.Street}";
            labelPostcodeOutput.Text = $"Postcode: {person.Postcode}";
            labelCityOutput.Text = $"City: {person.City}";
            labelDesignationOutput.Text = $"Designation: {person.Designation}";

        }

        private void labelNameOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
