namespace GsfRulesValidator
{
    partial class frmParameters
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnParamSave = new System.Windows.Forms.Button();
            this.ucParameter2 = new GsfRulesValidator.ucParameter();
            this.SuspendLayout();
            // 
            // btnParamSave
            // 
            this.btnParamSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnParamSave.Location = new System.Drawing.Point(624, 73);
            this.btnParamSave.Name = "btnParamSave";
            this.btnParamSave.Size = new System.Drawing.Size(75, 23);
            this.btnParamSave.TabIndex = 1;
            this.btnParamSave.Text = "Save";
            this.btnParamSave.UseVisualStyleBackColor = true;
            this.btnParamSave.Click += new System.EventHandler(this.btnParamSave_Click);
            // 
            // ucParameter2
            // 
            this.ucParameter2.ClassName = null;
            this.ucParameter2.Location = new System.Drawing.Point(3, 3);
            this.ucParameter2.Name = "ucParameter2";
            this.ucParameter2.ParameterName = null;
            this.ucParameter2.ReturnType = null;
            this.ucParameter2.Size = new System.Drawing.Size(715, 57);
            this.ucParameter2.TabIndex = 2;
            // 
            // frmParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 108);
            this.Controls.Add(this.ucParameter2);
            this.Controls.Add(this.btnParamSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParameters";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Parameters";
            this.ResumeLayout(false);

        }

        #endregion

        private ucParameter ucParameter1;
        private System.Windows.Forms.Button btnParamSave;
        private ucParameter ucParameter2;
    }
}