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
    public partial class panel_odbioru_sprzetu : Form
    {
        public panel_odbioru_sprzetu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            panelAdrministracyjny panelAdm = new panelAdrministracyjny();
            panelAdm.Show();
        }
    }
}
