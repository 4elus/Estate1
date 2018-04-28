using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.estateTableAdapter.Update(this.dataBaseDataSet.Estate); // Добавляем записи в базу
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Estate". При необходимости она может быть перемещена или удалена.
            this.estateTableAdapter.Fill(this.dataBaseDataSet.Estate);

        }
        public string txt = string.Empty;
        private void searchBtn_Click(object sender, EventArgs e)
        {

            txt = "";
            string op = "and ";
            string[] a;

            if (cityCmb.Text != "")
            {
                estateBindingSource.Filter = "Область = \'" + cityCmb.Text + "\'";
                txt += "Область LIKE '%" + cityCmb.Text + "%'";
            }

            if (roomsCmb.Text != "")
            {
                if (txt != "") txt += op;
                
                    
                txt += "Этаж LIKE '%" + roomsCmb.Text + "%'";
            }

            if (statusCmb.Text != "")
            {
                if (txt != "") txt += op;
                txt += "Статус LIKE '%" + statusCmb.Text + "%'";
            }

            a = new string[dataGridView1.RowCount];

            if (priceTxt.Text != "")
            {
                if (txt != "") txt += op;

                txt += "Цена <= " + Convert.ToInt32(priceTxt.Text);


            }
           
            estateBindingSource.Filter = txt;
           

        }

        private void targetCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (targetCmb.Text == "Переезд")
            {
                Test f = new Test();
                f.Show();
            }
        }
    }
}


