﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
namespace Vexease.Views
{
    public partial class Login : CCSkinMain
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void Login_btn_login_Click(object sender, EventArgs e)
        {
            Adm adm = new Adm();
            adm.Show();
            this.Close();

        }

        private void Login_btn_cancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
