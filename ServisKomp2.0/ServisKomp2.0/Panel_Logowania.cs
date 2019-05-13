using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisKomp2._0
{
    public partial class Panel_Logowania : Form
    {
        public Panel_Logowania()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=root;password=;persistsecurityinfo=True;database=sevisbeta");
 
        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand("select * from pracownicy where  login='" + this.textBox1.Text + "'and haslo='" + this.textBox2.Text + "' ; ", conn);
            MySqlDataReader Reader;
            try
            {
                conn.Open();
                Reader = cmd.ExecuteReader();
                int count = 0;
                while (Reader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("login i haslo poprawne");
                    this.Hide();
                    panelAdrministracyjny panelAdm = new panelAdrministracyjny();
                    panelAdm.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("zduplikowane");
                }
                else
                {
                    MessageBox.Show("niepoprawne!");
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                Console.Write(ee);
            }



            
        }
    }
}
