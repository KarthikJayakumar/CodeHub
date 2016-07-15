using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GsfRulesValidator
{
    public partial class frmParameters : Form
    {
        public string ClassNames { get; set; }
        public string Parameter { get; set; }
        public string ReturnType { get; set; }
        public frmParameters()
        {
            InitializeComponent();
        }

        private void btnParamSave_Click(object sender, EventArgs e)
        {
            ClassNames = this.ucParameter2.ClassName;
            Parameter = this.ucParameter2.ParameterName;
            ReturnType = this.ucParameter2.ReturnType;
            this.Hide();
        }
    }
}
