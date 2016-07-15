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
    public partial class frmAddRule : Form
    {
        public string RuleName { get; set; }
        public string Rule { get; set; }
        public string ClassNames { get; set; }
        public string Parameter { get; set; }
        public string ReturnType { get; set; }

        public frmAddRule()
        {
            InitializeComponent();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            RuleName = this.textBox1.Text;
            SourceCodeGenerator codeGenerate = new SourceCodeGenerator();
            codeGenerate.ClassName = "Unit_" + RuleName;
            codeGenerate.MethodImplementaion = rtxtRuleContent.Text;
            codeGenerate.ParameterType = ClassNames;
            codeGenerate.ParameterName = Parameter;
            codeGenerate.ReturnType = ReturnType;
            string error = codeGenerate.Compile();
            this.Rule = codeGenerate.MethodImplementaion;
            MessageBox.Show(string.IsNullOrEmpty(error) ? "Compiled successfully." : error);
         
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            frmParameters param = new frmParameters();
            if(param.ShowDialog() == DialogResult.OK)
            {
                ClassNames = param.ClassNames;
                Parameter = param.Parameter;
                ReturnType = param.ReturnType;
                string methodInfo = string.Format("public {0} Run ({1} {2})", param.ReturnType, param.ClassNames, param.Parameter);
                lblMethod.Text = methodInfo;
            }
        }
    }
}
