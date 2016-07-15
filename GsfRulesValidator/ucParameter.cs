using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GsfRulesValidator
{
    public partial class ucParameter : UserControl
    {
        public string ClassName { get; set; }
        public string ParameterName { get; set; }
        public string ReturnType { get; set; }
        public ucParameter()
        {
            InitializeComponent();
            LoadClassNames();
            LoadReturnTypes();
        }

        private void LoadReturnTypes()
        {
            cmbReturnTypes.Items.Clear();
            cmbReturnTypes.Items.Add("void");
            cmbReturnTypes.Items.Add("bool");
            cmbReturnTypes.Items.Add("byte");
            cmbReturnTypes.Items.Add("char");
            cmbReturnTypes.Items.Add("decimal");
            cmbReturnTypes.Items.Add("double");
            cmbReturnTypes.Items.Add("float");
            cmbReturnTypes.Items.Add("int");
            cmbReturnTypes.Items.Add("object");
            cmbReturnTypes.Items.Add("long");
            cmbReturnTypes.Items.Add("sbyte");
            cmbReturnTypes.Items.Add("string");
            cmbReturnTypes.Items.Add("uint");
            cmbReturnTypes.Items.Add("ulong");
            cmbReturnTypes.Items.Add("ushort");
            cmbReturnTypes.SelectedIndex = 0;
        }

        private void LoadClassNames()
        {
            cmbClassNames.Items.Clear();
            Assembly assembly = Assembly.LoadFile(Application.StartupPath + "\\DataTransferObjects.dll");
            foreach (Type type in assembly.GetTypes())
            {
                cmbClassNames.Items.Add(type.FullName.Split(new char[] { '.' })[1]);
            }
        }

        private void ucParameter_Load(object sender, EventArgs e)
        {

        }

        private void cmbClassNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassName = this.cmbClassNames.SelectedItem.ToString();
        }

        private void cmbReturnTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReturnType = this.cmbReturnTypes.SelectedItem.ToString();
            ParameterName = this.textBox1.Text;
        }
    }
}
