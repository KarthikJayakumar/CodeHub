namespace GsfRulesValidator
{
    partial class ucParameter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblObject = new System.Windows.Forms.Label();
            this.cmbClassNames = new System.Windows.Forms.ComboBox();
            this.lblParameter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbReturnTypes = new System.Windows.Forms.ComboBox();
            this.lblReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblObject
            // 
            this.lblObject.AutoSize = true;
            this.lblObject.Location = new System.Drawing.Point(4, 24);
            this.lblObject.Name = "lblObject";
            this.lblObject.Size = new System.Drawing.Size(95, 13);
            this.lblObject.TabIndex = 0;
            this.lblObject.Text = "Select the Object :";
            // 
            // cmbClassNames
            // 
            this.cmbClassNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassNames.FormattingEnabled = true;
            this.cmbClassNames.Location = new System.Drawing.Point(105, 20);
            this.cmbClassNames.Name = "cmbClassNames";
            this.cmbClassNames.Size = new System.Drawing.Size(121, 21);
            this.cmbClassNames.TabIndex = 1;
            this.cmbClassNames.SelectedIndexChanged += new System.EventHandler(this.cmbClassNames_SelectedIndexChanged);
            // 
            // lblParameter
            // 
            this.lblParameter.AutoSize = true;
            this.lblParameter.Location = new System.Drawing.Point(242, 24);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(55, 13);
            this.lblParameter.TabIndex = 2;
            this.lblParameter.Text = "Parameter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 3;
            // 
            // cmbReturnTypes
            // 
            this.cmbReturnTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnTypes.FormattingEnabled = true;
            this.cmbReturnTypes.Location = new System.Drawing.Point(580, 20);
            this.cmbReturnTypes.Name = "cmbReturnTypes";
            this.cmbReturnTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbReturnTypes.TabIndex = 5;
            this.cmbReturnTypes.SelectedIndexChanged += new System.EventHandler(this.cmbReturnTypes_SelectedIndexChanged);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(530, 24);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(44, 13);
            this.lblReturn.TabIndex = 4;
            this.lblReturn.Text = "Returns";
            // 
            // ucParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbReturnTypes);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblParameter);
            this.Controls.Add(this.cmbClassNames);
            this.Controls.Add(this.lblObject);
            this.Name = "ucParameter";
            this.Size = new System.Drawing.Size(715, 57);
            this.Load += new System.EventHandler(this.ucParameter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObject;
        private System.Windows.Forms.ComboBox cmbClassNames;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbReturnTypes;
        private System.Windows.Forms.Label lblReturn;
    }
}
