using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR7_SPZ_Task
{    
    public partial class fAbonent : Form
    {
        private Abonent ab;
        public fAbonent(ref Abonent ab)
        {
            InitializeComponent();
            this.ab = ab;
        }

        private void fAbonent_Load(object sender, EventArgs e)
        {
            tbNumber.Text = ab.Number;
            tbName.Text = ab.Name;
            tbTariff.Text = ab.Tariff;
            tbBalance.Text = ab.Balance.ToString();
            if (ab.ActivationDate != DateTime.MinValue)
            {
                dtActivation.Value = ab.ActivationDate;
            }
            else
            {
                dtActivation.Value = DateTime.Now; 
            }
            cbHasInternet.Checked = ab.HasInternet;
            cbHasDigitalTV.Checked = ab.HasDigitalTV;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ab.Number = tbNumber.Text;
            ab.Name = tbName.Text;
            ab.Tariff = tbTariff.Text;
            ab.Balance = int.Parse(tbBalance.Text);
            ab.ActivationDate = dtActivation.Value;
            ab.HasInternet = cbHasInternet.Checked;
            ab.HasDigitalTV = cbHasDigitalTV.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
