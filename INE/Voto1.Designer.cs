namespace INE
{
    partial class Voto1
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMorena = new System.Windows.Forms.RadioButton();
            this.rdbPRI = new System.Windows.Forms.RadioButton();
            this.rdbPAN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(61, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(211, 20);
            this.txtUser.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // rdbMorena
            // 
            this.rdbMorena.AutoSize = true;
            this.rdbMorena.Location = new System.Drawing.Point(6, 16);
            this.rdbMorena.Name = "rdbMorena";
            this.rdbMorena.Size = new System.Drawing.Size(225, 17);
            this.rdbMorena.TabIndex = 6;
            this.rdbMorena.TabStop = true;
            this.rdbMorena.Text = "MORENA - Andres Manuel Lopez Obrador";
            this.rdbMorena.UseVisualStyleBackColor = true;
            // 
            // rdbPRI
            // 
            this.rdbPRI.AutoSize = true;
            this.rdbPRI.Location = new System.Drawing.Point(6, 62);
            this.rdbPRI.Name = "rdbPRI";
            this.rdbPRI.Size = new System.Drawing.Size(149, 17);
            this.rdbPRI.TabIndex = 7;
            this.rdbPRI.TabStop = true;
            this.rdbPRI.Text = "PRI - José Antonio Meade";
            this.rdbPRI.UseVisualStyleBackColor = true;
            // 
            // rdbPAN
            // 
            this.rdbPAN.AutoSize = true;
            this.rdbPAN.Location = new System.Drawing.Point(6, 39);
            this.rdbPAN.Name = "rdbPAN";
            this.rdbPAN.Size = new System.Drawing.Size(126, 17);
            this.rdbPAN.TabIndex = 8;
            this.rdbPAN.TabStop = true;
            this.rdbPAN.Text = "PAN - Ricardo Anaya";
            this.rdbPAN.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPAN);
            this.groupBox1.Controls.Add(this.rdbPRI);
            this.groupBox1.Controls.Add(this.rdbMorena);
            this.groupBox1.Location = new System.Drawing.Point(6, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Votar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Voto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 205);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.MinimizeBox = false;
            this.Name = "Voto1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voto1";
            this.Load += new System.EventHandler(this.Voto1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMorena;
        private System.Windows.Forms.RadioButton rdbPRI;
        private System.Windows.Forms.RadioButton rdbPAN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}