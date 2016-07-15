using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Mono.CSharp;
namespace GsfRulesValidator
{
    public partial class frmGsfValidator : Form
    {
        Evaluator evaluator;
        public frmGsfValidator()
        {
            InitializeComponent();
            ConstructCompiler();
        }

        private void ConstructCompiler()
        {
            evaluator = new Evaluator(new CompilerContext(new CompilerSettings(), new ConsoleReportPrinter()));
            // Make it reference our own assembly so it can use IFoo
            evaluator.ReferenceAssembly(typeof(IDynamicCodeGenerator).Assembly);

            // Feed it some code
            evaluator.Compile(
                @"
                    using GsfRulesValidator;
                    public class DynamicCodeGenerator : IDynamicCodeGenerator
                    {
                        public string Run(string rule) 
                        { 
                            return rule.ToUpper(); 
                        }
                    }
                ");
            string intializeDynamicObject = "GsfRulesValidator.IDynamicCodeGenerator codeToRun = new DynamicCodeGenerator();";
            string line = string.Empty;
            line = intializeDynamicObject;
            object result;
            bool result_set;
            evaluator.Evaluate(line, out result, out result_set);
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string line = string.Empty;
        //    line = @"codeToRun.Run(" + "\"" + rtxtConsole.Text + "\"" + ");";
        //    object result;
        //    bool result_set;
        //    evaluator.Evaluate(line, out result, out result_set);
        //    if (result_set)
        //    {
        //        textBox1.Text = "Result : " + result;
        //    }
        //}

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            frmAddRule rule = new frmAddRule();
            rule.ShowDialog();
            rtxtRule.Text = rule.Rule;
            lvRules.Items.Add(rule.RuleName);
        }
    }
}
