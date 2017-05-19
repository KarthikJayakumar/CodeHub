using CSScriptLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoCSharpScripting
{
    public partial class Form1 : Form
    {
        List<UnitDto> _lstDtoList = new List<UnitDto>();
        public Form1()
        {
            InitializeComponent();
            _lstDtoList.Add(new UnitDto { Id = 1, Name = "UN123P", Quantity = 10, Result = false });
            _lstDtoList.Add(new UnitDto { Id = 2, Name = "UN456P", Quantity = 20, Result = false });
            _lstDtoList.Add(new UnitDto { Id = 3, Name = "UN789P", Quantity = 30, Result = false });
            _lstDtoList.Add(new UnitDto { Id = 4, Name = "UM123T", Quantity = 40, Result = false });
            _lstDtoList.Add(new UnitDto { Id = 5, Name = "UM123T", Quantity = 50, Result = false });
            _lstDtoList.Add(new UnitDto { Id = 6, Name = "UM123T", Quantity = 60, Result = false });
            _lstDtoList.Add(new UnitDto { Id = 7, Name = "UM123T", Quantity = 70, Result = false });
            dataGridView1.DataSource = _lstDtoList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool Run(string strOptions)
        {
            if (strOptions.StartsWith("K"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                //string method = " string Run(string strOptions) {" + textBox1.Text + "}";
                string method = textBox1.Text ;
                dynamic script = CSScript.Evaluator
                                         .LoadMethod(method);
                string result = (string)script.Run("Karthik");
                MessageBox.Show(result.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
