
namespace AS2122_4E_INF_UbalducciMattia_CalcoloConti
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkSpinning = new System.Windows.Forms.CheckBox();
            this.chkDanza = new System.Windows.Forms.CheckBox();
            this.chkPesi = new System.Windows.Forms.CheckBox();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 23);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // chkSpinning
            // 
            this.chkSpinning.AutoSize = true;
            this.chkSpinning.Location = new System.Drawing.Point(112, 216);
            this.chkSpinning.Name = "chkSpinning";
            this.chkSpinning.Size = new System.Drawing.Size(73, 19);
            this.chkSpinning.TabIndex = 4;
            this.chkSpinning.Text = "Spinning";
            this.chkSpinning.UseVisualStyleBackColor = true;
            // 
            // chkDanza
            // 
            this.chkDanza.AutoSize = true;
            this.chkDanza.Location = new System.Drawing.Point(110, 241);
            this.chkDanza.Name = "chkDanza";
            this.chkDanza.Size = new System.Drawing.Size(58, 19);
            this.chkDanza.TabIndex = 5;
            this.chkDanza.Text = "Danza";
            this.chkDanza.UseVisualStyleBackColor = true;
            // 
            // chkPesi
            // 
            this.chkPesi.AutoSize = true;
            this.chkPesi.Location = new System.Drawing.Point(110, 266);
            this.chkPesi.Name = "chkPesi";
            this.chkPesi.Size = new System.Drawing.Size(47, 19);
            this.chkPesi.TabIndex = 6;
            this.chkPesi.Text = "Pesi";
            this.chkPesi.UseVisualStyleBackColor = true;
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(396, 293);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(75, 23);
            this.btnCalcola.TabIndex = 10;
            this.btnCalcola.Text = "CALCOLA";
            this.btnCalcola.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.chkPesi);
            this.Controls.Add(this.chkDanza);
            this.Controls.Add(this.chkSpinning);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "UbalducciMattia;lab2.2;Gestione palestra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkSpinning;
        private System.Windows.Forms.CheckBox chkDanza;
        private System.Windows.Forms.CheckBox chkPesi;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

