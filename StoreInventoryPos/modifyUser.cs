using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventoryPos
{
    public partial class modifyUser : Form
    {
        public modifyUser()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDashboard Back = new adminDashboard();
            Back.Show();
        }
    }
}
