namespace EjercicioCuentaBancaria
{
    partial class FormAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNoCuenta = new System.Windows.Forms.TextBox();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAsset = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAsset = new System.Windows.Forms.Label();
            this.labelDPI = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.buttonInput = new System.Windows.Forms.Button();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Cuenta";
            // 
            // textBoxNoCuenta
            // 
            this.textBoxNoCuenta.Location = new System.Drawing.Point(151, 78);
            this.textBoxNoCuenta.Name = "textBoxNoCuenta";
            this.textBoxNoCuenta.Size = new System.Drawing.Size(100, 20);
            this.textBoxNoCuenta.TabIndex = 1;
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(151, 134);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDPI.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DPI Cliente";
            // 
            // textBoxAsset
            // 
            this.textBoxAsset.Location = new System.Drawing.Point(151, 180);
            this.textBoxAsset.Name = "textBoxAsset";
            this.textBoxAsset.Size = new System.Drawing.Size(100, 20);
            this.textBoxAsset.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DPI Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "No. Cuenta";
            // 
            // labelAsset
            // 
            this.labelAsset.AutoSize = true;
            this.labelAsset.Location = new System.Drawing.Point(582, 183);
            this.labelAsset.Name = "labelAsset";
            this.labelAsset.Size = new System.Drawing.Size(34, 13);
            this.labelAsset.TabIndex = 11;
            this.labelAsset.Text = "Saldo";
            // 
            // labelDPI
            // 
            this.labelDPI.AutoSize = true;
            this.labelDPI.Location = new System.Drawing.Point(582, 137);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(60, 13);
            this.labelDPI.TabIndex = 10;
            this.labelDPI.Text = "DPI Cliente";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(582, 81);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(61, 13);
            this.labelAccount.TabIndex = 9;
            this.labelAccount.Text = "No. Cuenta";
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInput.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInput.Location = new System.Drawing.Point(64, 299);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 12;
            this.buttonInput.Text = "INGRESAR DATOS";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOutput.Location = new System.Drawing.Point(445, 299);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonOutput.TabIndex = 20;
            this.buttonOutput.Text = "MOSTRAR DATOS";
            this.buttonOutput.UseVisualStyleBackColor = false;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.labelAsset);
            this.Controls.Add(this.labelDPI);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAsset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNoCuenta);
            this.Controls.Add(this.label1);
            this.Name = "FormCuenta";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNoCuenta;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAsset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAsset;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Button buttonOutput;
    }
}

