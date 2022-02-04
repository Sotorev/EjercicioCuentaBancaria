using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCuentaBancaria
{
    public partial class FormDatos : Form
    {
        Person person = new Person();
        public FormDatos()
        {
            InitializeComponent();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            person.Name = textBoxName.Text;
            person.LastName = textBoxLastName.Text;
            person.DPI = textBoxDPI.Text;
            person.BirthDate = dateTimePicker1.Value;
        }
        
        private void buttonOutput_Click(object sender, EventArgs e)
        {
            labelName.Text = person.Name;
            labelLastName.Text = person.LastName;
            labelDPI.Text = person.DPI;
            labelBirthDate.Text = person.BirthDate.ToString();
            labelAge.Text = person.Age().ToString();
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormAccount formCuenta = new FormAccount();
            formCuenta.Show();
        }
    }
}
