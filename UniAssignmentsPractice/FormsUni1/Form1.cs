using ConsoleUni1;
using System;
using System.IO;
using System.Linq;
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
            LoadCsv();
        }
        private void LoadCsv()
        {
            string filePath = "persondetails.csv";
            listBoxCards.Items.Clear();

            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length < 6) continue;

                listBoxCards.Items.Add($"{parts[0]} | {parts[4]} | {parts[5]}");
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
            using (StreamWriter sw = new StreamWriter("..\\..\\..\\persondetails.csv", true))
            {
                if (!File.Exists("..\\..\\..\\persondetails.csv"))
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
            if (listBoxCards.SelectedIndex < 0)
                return;

            string filePath = "persondetails.csv";
            var lines = File.ReadAllLines(filePath);
            var dataLines = lines.ToArray();

            if (listBoxCards.SelectedIndex >= dataLines.Length)
                return;

            var parts = dataLines[listBoxCards.SelectedIndex].Split(';');
            if (parts.Length < 6) return;

            // Populate the result labels
            labelNameOutput.Text = $"Name: {parts[0]}";
            labelDobOutput.Text = $"DOB: {parts[1]}";
            labelAddressOutput.Text = $"Street: {parts[2]}";
            labelPostcodeOutput.Text = $"Postcode: {parts[3]}";
            labelCityOutput.Text = $"City: {parts[4]}";
            labelDesignationOutput.Text = $"Designation: {parts[5]}";
        }
    }
}
