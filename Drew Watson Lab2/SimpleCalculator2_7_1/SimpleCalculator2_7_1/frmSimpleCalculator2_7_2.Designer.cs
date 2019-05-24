namespace SimpleCalculator2_7_1
{
    partial class frmSimpleCalculator2_7_2
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
            this.lblOperand = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperand
            // 
            this.lblOperand.AutoSize = true;
            this.lblOperand.Location = new System.Drawing.Point(26, 23);
            this.lblOperand.Name = "lblOperand";
            this.lblOperand.Size = new System.Drawing.Size(60, 13);
            this.lblOperand.TabIndex = 0;
            this.lblOperand.Text = "Operand 1:";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(26, 63);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(51, 13);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "Operator:";
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(26, 100);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(60, 13);
            this.lblOperand2.TabIndex = 4;
            this.lblOperand2.Text = "Operand 2:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(26, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(113, 23);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 1;
            this.txtOperand1.TextChanged += new System.EventHandler(this.txtOperand1_TextChanged);
            // 
            // txtOperator
            // 
            this.txtOperator.Location = new System.Drawing.Point(113, 60);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(100, 20);
            this.txtOperator.TabIndex = 3;
            this.txtOperator.TextChanged += new System.EventHandler(this.txtOperator_TextChanged);
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(113, 93);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 5;
            this.txtOperand2.TextChanged += new System.EventHandler(this.txtOperand2_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(113, 129);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            this.txtResult.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(29, 185);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(138, 185);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSimpleCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperator);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOperand);
            this.Name = "frmSimpleCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperand;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

