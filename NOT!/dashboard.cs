using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace NOT_
{
    public partial class dashboard : KryptonForm
    {

        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void hide_panel_btn_Click(object sender, EventArgs e)
        {
            kryptonPanel1.Hide();
        }

        private void return_panel_btn_Click(object sender, EventArgs e)
        {
            kryptonPanel1.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
                this.Close();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Show();
            this.Hide();
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            Payments payments = new Payments();
            payments.Show();
            this.Close();
        }
    }
}

