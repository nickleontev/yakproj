namespace Lab_number_7_Model
{
    partial class Form4
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
            this.deltat_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.late_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calculate_rb = new System.Windows.Forms.RadioButton();
            this.input_rb = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.T_tb = new System.Windows.Forms.TextBox();
            this.dT_tb = new System.Windows.Forms.TextBox();
            this.K_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deltat_tb
            // 
            this.deltat_tb.Location = new System.Drawing.Point(12, 205);
            this.deltat_tb.Name = "deltat_tb";
            this.deltat_tb.Size = new System.Drawing.Size(100, 20);
            this.deltat_tb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Приращение модельного времени (Δt):";
            // 
            // late_btn
            // 
            this.late_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.late_btn.Location = new System.Drawing.Point(161, 333);
            this.late_btn.Name = "late_btn";
            this.late_btn.Size = new System.Drawing.Size(216, 37);
            this.late_btn.TabIndex = 3;
            this.late_btn.Text = "Назад";
            this.late_btn.UseVisualStyleBackColor = true;
            this.late_btn.Click += new System.EventHandler(this.late_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next_btn.Location = new System.Drawing.Point(394, 333);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(216, 37);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = "Далее";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.calculate_rb);
            this.panel2.Controls.Add(this.input_rb);
            this.panel2.Location = new System.Drawing.Point(12, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 48);
            this.panel2.TabIndex = 18;
            // 
            // calculate_rb
            // 
            this.calculate_rb.AutoSize = true;
            this.calculate_rb.Location = new System.Drawing.Point(11, 26);
            this.calculate_rb.Name = "calculate_rb";
            this.calculate_rb.Size = new System.Drawing.Size(254, 17);
            this.calculate_rb.TabIndex = 0;
            this.calculate_rb.TabStop = true;
            this.calculate_rb.Text = "Расчитать приращение модельного времени";
            this.calculate_rb.UseVisualStyleBackColor = true;
            this.calculate_rb.CheckedChanged += new System.EventHandler(this.calculate_rb_CheckedChanged);
            // 
            // input_rb
            // 
            this.input_rb.AutoSize = true;
            this.input_rb.Location = new System.Drawing.Point(11, 3);
            this.input_rb.Name = "input_rb";
            this.input_rb.Size = new System.Drawing.Size(238, 17);
            this.input_rb.TabIndex = 1;
            this.input_rb.TabStop = true;
            this.input_rb.Text = "Задать приращение модельного времени";
            this.input_rb.UseVisualStyleBackColor = true;
            this.input_rb.CheckedChanged += new System.EventHandler(this.input_rb_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.T_tb);
            this.panel1.Controls.Add(this.dT_tb);
            this.panel1.Controls.Add(this.K_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 105);
            this.panel1.TabIndex = 19;
            // 
            // T_tb
            // 
            this.T_tb.Location = new System.Drawing.Point(11, 11);
            this.T_tb.Name = "T_tb";
            this.T_tb.Size = new System.Drawing.Size(100, 20);
            this.T_tb.TabIndex = 2;
            // 
            // dT_tb
            // 
            this.dT_tb.Location = new System.Drawing.Point(11, 38);
            this.dT_tb.Name = "dT_tb";
            this.dT_tb.Size = new System.Drawing.Size(100, 20);
            this.dT_tb.TabIndex = 3;
            // 
            // K_tb
            // 
            this.K_tb.Location = new System.Drawing.Point(11, 64);
            this.K_tb.Name = "K_tb";
            this.K_tb.Size = new System.Drawing.Size(100, 20);
            this.K_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Время проведения исследования (Т)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Период отображения информации о состоянии системы (ΔТ)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Крайняя граница для выбора количесва окон задержки";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(542, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 257);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.late_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deltat_tb);
            this.MinimumSize = new System.Drawing.Size(366, 110);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox deltat_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button late_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton calculate_rb;
        private System.Windows.Forms.RadioButton input_rb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox T_tb;
        private System.Windows.Forms.TextBox dT_tb;
        private System.Windows.Forms.TextBox K_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}