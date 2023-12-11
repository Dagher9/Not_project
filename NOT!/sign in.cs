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
    public partial class sign_up : KryptonForm
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
         
        }

        private void signin_start_Click(object sender, EventArgs e)
        {
            getting_started gettingStarted = new getting_started();
            gettingStarted.Show();
            this.Hide();
        }
    }
}
