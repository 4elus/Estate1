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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
     
            // Устанавливает фильтр
            estateBindingSource.Filter = "Область = \'" + cityCmb.Text + "\'";
            estateBindingSource.Filter = "Статус = \'" + statusCmb.Text + "\'";
            estateBindingSource.Filter = "Этаж = \'" + roomsCmb.Text + "\'";
            if (priceTxt.Text != "")
            {
                estateBindingSource.Filter = "Цена = \'" + Convert.ToInt32(priceTxt.Text) + " руб." + "\'";
            }
        }
    }
}


