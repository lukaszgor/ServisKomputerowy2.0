using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ServisKomp2._0
{
    public partial class panel_klientow : Form
    {
        public panel_klientow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelAdrministracyjny panelAdm = new panelAdrministracyjny();
            panelAdm.Show();
        }

        MySqlConnection SQL_Connect = new MySqlConnection("SERVER=localhost;PORT=3306;UID=root;PWD=;");
        public string name_tabel = "sevisbeta.klienci";
        MySqlDataAdapter db_select;
        DataSet db_data;
        
        public void DB_toDataGrid()
        {
            try
            {
                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                db_select = new MySqlDataAdapter("SELECT * FROM " + name_tabel, SQL_Connect);
                db_data = new System.Data.DataSet();
                db_select.Fill(db_data);
                dataGridView1.DataSource = db_data.Tables[0];
               
            }
            catch (Exception ee)
            {
                Console.Write(ee);
            }
        }
       

        private void panel_klientow_Load(object sender, EventArgs e)
        {
            DB_toDataGrid();
        }
    }
}
