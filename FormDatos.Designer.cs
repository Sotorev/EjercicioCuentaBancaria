namespace EjercicioCuentaBancaria
{
    partial class FormDatos
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelDPI = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelAge = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 123);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Location = new System.Drawing.Point(83, 218);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(177, 20);
            this.textBoxDPI.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(83, 174);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(177, 20);
            this.textBoxLastName.TabIndex = 8;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInput.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonInput.Location = new System.Drawing.Point(36, 310);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(75, 23);
            this.buttonInput.TabIndex = 10;
            this.buttonInput.Text = "INGRESAR DATOS";
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DPI";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de nacimiento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(469, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "DPI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(469, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Nombre";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(632, 159);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(29, 13);
            this.labelLastName.TabIndex = 18;
            this.labelLastName.Text = "Field";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(632, 240);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(29, 13);
            this.labelBirthDate.TabIndex = 17;
            this.labelBirthDate.Text = "Field";
            // 
            // labelDPI
            // 
            this.labelDPI.AutoSize = true;
            this.labelDPI.Location = new System.Drawing.Point(632, 201);
            this.labelDPI.Name = "labelDPI";
            this.labelDPI.Size = new System.Drawing.Size(29, 13);
            this.labelDPI.TabIndex = 16;
            this.labelDPI.Text = "Field";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(632, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Field";
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonOutput.Location = new System.Drawing.Point(472, 310);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonOutput.TabIndex = 19;
            this.buttonOutput.Text = "MOSTRAR DATOS";
            this.buttonOutput.UseVisualStyleBackColor = false;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Salida";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ir a las cuentas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(632, 273);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 23;
            this.labelAge.Text = "Field";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(469, 274);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Edad";
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelDPI);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDPI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDatos";
            this.Text = "FormDatos";
            this.Load += new System.EventHandler(this.FormDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelDPI;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label label12;
    }
}