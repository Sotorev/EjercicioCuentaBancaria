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
    public partial class FormAccount : Form
    {
        Account account = new Account();
        public FormAccount()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            account.Id = textBoxNoCuenta.Text;
            account.DPI = textBoxDPI.Text;
            account.Asset = Convert.ToDouble(textBoxAsset.Text);
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            labelAccount.Text = account.Id;
            labelDPI.Text = account.DPI;
            labelAsset.Text = account.Asset.ToString();
        }
    }
}
