﻿using System.Windows.Forms;

namespace WinPivot_GettingStarted {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            salesPersonTableAdapter1.Fill(nwindDataSet1.SalesPerson);
            pivotGridControl1.BestFit();
        }
    }
}
