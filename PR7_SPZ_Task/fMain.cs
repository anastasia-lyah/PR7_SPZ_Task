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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvAbonent.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Number";
            column.Name = "Номер";
            gvAbonent.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Ім'я";
            gvAbonent.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Tariff";
            column.Name = "Тариф";
            gvAbonent.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Balance";
            column.Name = "Баланс";
            gvAbonent.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ActivationDate";
            column.Name = "Дата активації";
            gvAbonent.Columns.Add(column);           

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasInternet";
            column.Name = "Інтернет";
            column.Width = 100;
            gvAbonent.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasDigitalTV";
            column.Name = "Телебачення";
            column.Width = 100;
            gvAbonent.Columns.Add(column);

           
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Abonent ab = new Abonent();
            fAbonent ft = new fAbonent(ref ab);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcAbonent.Add(ab);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Abonent ab = (Abonent)bindSrcAbonent.List[bindSrcAbonent.Position];
            fAbonent ft = new fAbonent(ref ab);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcAbonent.List[bindSrcAbonent.Position] = ab;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис ?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcAbonent.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcAbonent.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
