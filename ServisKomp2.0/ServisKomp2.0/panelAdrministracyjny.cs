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
    public partial class panelAdrministracyjny : Form
    {
        public panelAdrministracyjny()
        {
            InitializeComponent();
          
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Panel_Logowania panelLog = new Panel_Logowania();
            panelLog.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelPracownicy panelPrac = new panelPracownicy();
            panelPrac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelSprzetu panelSprz = new panelSprzetu();
            panelSprz.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelUsterka panelUst = new panelUsterka();
            panelUst.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelZgloszenia panelZgl = new panelZgloszenia();
            panelZgl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel_odbioru_sprzetu panelodbior = new panel_odbioru_sprzetu();
            panelodbior.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel_klientow panelklient = new panel_klientow();
            panelklient.Show();
        }
       public void userGuard()
        {

                    button2.Enabled = false;

        }
    }
    
}
