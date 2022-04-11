using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Enum.Metro;
using ReaLTaiizor.Forms;

namespace BDO_Tools
{
    public partial class Home : MetroForm
    {
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public Home()
        {

            InitializeComponent();
        }

        private void BtnAgree_Click(object sender, EventArgs e)
        {
            this.Alert("Thank you for using BDO Toolbox !", Form_Alert.enmType.Info);
            Panel panel = new Panel();
            this.Hide();

            panel.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
