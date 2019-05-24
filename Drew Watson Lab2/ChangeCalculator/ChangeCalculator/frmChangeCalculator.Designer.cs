namespace ChangeCalculator
{
    partial class frmChangeCalculator
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
            this.lblChange = new System.Windows.Forms.Label();
            this.lblQuaters = new System.Windows.Forms.Label();
            this.lblDimes = new System.Windows.Forms.Label();
            this.lblNickels = new System.Windows.Forms.Label();
            this.lblPennies = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuaters = new System.Windows.Forms.TextBox();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(65, 27);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(151, 13);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "Amount of change due (0-99): ";
            // 
            // lblQuaters
            // 
            this.lblQuaters.AutoSize = true;
            this.lblQuaters.Location = new System.Drawing.Point(166, 62);
            this.lblQuaters.Name = "lblQuaters";
            this.lblQuaters.Size = new System.Drawing.Size(50, 13);
            this.lblQuaters.TabIndex = 1;
            this.lblQuaters.Text = "Quaters: ";
            // 
            // lblDimes
            // 
            this.lblDimes.AutoSize = true;
            this.lblDimes.Location = new System.Drawing.Point(166, 92);
            this.lblDimes.Name = "lblDimes";
            this.lblDimes.Size = new System.Drawing.Size(39, 13);
            this.lblDimes.TabIndex = 2;
            this.lblDimes.Text = "Dimes:";
            // 
            // lblNickels
            // 
            this.lblNickels.AutoSize = true;
            this.lblNickels.Location = new System.Drawing.Point(166, 127);
            this.lblNickels.Name = "lblNickels";
            this.lblNickels.Size = new System.Drawing.Size(45, 13);
            this.lblNickels.TabIndex = 3;
            this.lblNickels.Text = "Nickels:";
            // 
            // lblPennies
            // 
            this.lblPennies.AutoSize = true;
            this.lblPennies.Location = new System.Drawing.Point(163, 160);
            this.lblPennies.Name = "lblPennies";
            this.lblPennies.Size = new System.Drawing.Size(48, 13);
            this.lblPennies.TabIndex = 4;
            this.lblPennies.Text = "Pennies:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // txtQuaters
            // 
            this.txtQuaters.Location = new System.Drawing.Point(222, 59);
            this.txtQuaters.Name = "txtQuaters";
            this.txtQuaters.ReadOnly = true;
            this.txtQuaters.Size = new System.Drawing.Size(50, 20);
            this.txtQuaters.TabIndex = 6;
            this.txtQuaters.TabStop = false;
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(222, 89);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.ReadOnly = true;
            this.txtDimes.Size = new System.Drawing.Size(50, 20);
            this.txtDimes.TabIndex = 7;
            this.txtDimes.TabStop = false;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(222, 24);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(50, 20);
            this.txtChange.TabIndex = 1;
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(222, 153);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.ReadOnly = true;
            this.txtPennies.Size = new System.Drawing.Size(50, 20);
            this.txtPennies.TabIndex = 9;
            this.txtPennies.TabStop = false;
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(222, 120);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.ReadOnly = true;
            this.txtNickels.Size = new System.Drawing.Size(50, 20);
            this.txtNickels.TabIndex = 10;
            this.txtNickels.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(197, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChangeCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.txtQuaters);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPennies);
            this.Controls.Add(this.lblNickels);
            this.Controls.Add(this.lblDimes);
            this.Controls.Add(this.lblQuaters);
            this.Controls.Add(this.lblChange);
            this.Name = "frmChangeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblQuaters;
        private System.Windows.Forms.Label lblDimes;
        private System.Windows.Forms.Label lblNickels;
        private System.Windows.Forms.Label lblPennies;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuaters;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

