﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Modell;

namespace sudokuGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RechnenBtn_Click(object sender, EventArgs e)
        {
            String sud = sudtxt.Text;
            Evolution evo = new Evolution(sud);
        }
    }
}
