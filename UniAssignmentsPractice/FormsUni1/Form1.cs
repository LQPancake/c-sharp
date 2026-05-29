using ConsoleUni1;
using System;
using System.IO;
using System.Windows.Forms;

namespace FormsUni1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxCards.Items.Clear(); // Clear existing items
            try
            {
                using (StreamReader sr = new StreamReader("persondetails.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        listBoxCards.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading file: {ex.Message}");
            }
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
            using (StreamWriter sw = new StreamWriter("persondetails.csv", true))
            {
                if (!File.Exists("persondetails.csv"))
                {
                    sw.WriteLine("Name;Dob;Street;Postcode;City;Designation");
                }
                sw.WriteLine($"{person.Name};{person.Dob.ToShortDateString()};{person.Street};{person.Postcode};{person.City};{person.Designation}");
            }
        }

        private void labelNameOutput_Click(object sender, EventArgs e)
        {

        }

        private void listBoxCards_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
