﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneLog
{
    public partial class Form_PhoneLog : Form
    {
        public Form_PhoneLog()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            Form_About form_About = new Form_About();
            form_About.Show();
        }
    }
}
