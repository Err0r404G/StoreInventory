﻿using System;
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
    public partial class managerDashboard : Form
    {
        public managerDashboard()
        {
            InitializeComponent();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage back = new LoginPage(); // Back
            back.Show();

        }
    }


    }
