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
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
            TxtBx_About.Text = "This is all about the phone log";
        }
    }
}
