using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace NOT_
{
    public partial class getting_started : KryptonForm
    {
        public getting_started()
        {
            InitializeComponent();
        }

        private void getting_started_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_start_Click(object sender, EventArgs e)
        {
            dashboard Dashboard = new dashboard();
            Dashboard.Show();
          

            this.Hide();
        }

        private void credit_card_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_balance_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
