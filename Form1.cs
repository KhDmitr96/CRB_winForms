using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using CRB_winForms.cbrf;

namespace CRB_winForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            receiveDateTb.Text = DateTime.Today.ToString("dd/MM/yyyy");
            receiveDataGridView.Columns.Add("vname", "Сurrency Name");
            receiveDataGridView.Columns.Add("vcurs", "Exchange Rate");
            receiveDataGridView.Columns["vname"].DataPropertyName = "vname";
            receiveDataGridView.Columns["vname"].Width = 150;
            receiveDataGridView.Columns["vcurs"].DataPropertyName = "vcurs";
            receiveDataGridView.Columns["vcurs"].DefaultCellStyle.Format = "c";
        }

        private void receiveBtn_Click(object sender, EventArgs e)
        {
            System.DateTime receiveDate = Convert.ToDateTime(receiveDateTb.Text);
            DailyInfo di = new DailyInfo();
            DataSet curs = di.GetCursOnDate(receiveDate);

            receiveDataGridView.DataSource = curs.Tables[0];
            foreach (DataGridViewColumn column in receiveDataGridView.Columns)
                if (column.Name != "vname" && column.Name != "vcurs")
                    column.Visible = false;
        }
    }
}
