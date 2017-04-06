namespace Lab_number_7_Model
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.N_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.number1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.StructuralScheme = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.number1.SuspendLayout();
            this.number2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StructuralScheme)).BeginInit();
            this.SuspendLayout();
            // 
            // N_tb
            // 
            this.N_tb.Location = new System.Drawing.Point(14, 13);
            this.N_tb.Name = "N_tb";
            this.N_tb.Size = new System.Drawing.Size(100, 20);
            this.N_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество терминалов (N)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.N_tb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(74, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 53);
            this.panel1.TabIndex = 16;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(296, 83);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(216, 37);
            this.start_btn.TabIndex = 18;
            this.start_btn.Text = "Далее";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.number1);
            this.tabControl1.Controls.Add(this.number2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 565);
            this.tabControl1.TabIndex = 20;
            // 
            // number1
            // 
            this.number1.Controls.Add(this.button1);
            this.number1.Controls.Add(this.StructuralScheme);
            this.number1.Controls.Add(this.start_btn);
            this.number1.Controls.Add(this.button2);
            this.number1.Controls.Add(this.panel1);
            this.number1.Location = new System.Drawing.Point(4, 22);
            this.number1.Name = "number1";
            this.number1.Padding = new System.Windows.Forms.Padding(3);
            this.number1.Size = new System.Drawing.Size(811, 539);
            this.number1.TabIndex = 0;
            this.number1.Text = "tabPage1";
            this.number1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // number2
            // 
            this.number2.Controls.Add(this.button3);
            this.number2.Location = new System.Drawing.Point(4, 22);
            this.number2.Name = "number2";
            this.number2.Padding = new System.Windows.Forms.Padding(3);
            this.number2.Size = new System.Drawing.Size(811, 539);
            this.number2.TabIndex = 1;
            this.number2.Text = "tabPage2";
            this.number2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // StructuralScheme
            // 
            this.StructuralScheme.Image = global::Lab_number_7_Model.Properties.Resources.Структурная_схема1;
            this.StructuralScheme.Location = new System.Drawing.Point(40, 155);
            this.StructuralScheme.Name = "StructuralScheme";
            this.StructuralScheme.Size = new System.Drawing.Size(495, 346);
            this.StructuralScheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StructuralScheme.TabIndex = 19;
            this.StructuralScheme.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(803, 526);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.number1.ResumeLayout(false);
            this.number1.PerformLayout();
            this.number2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StructuralScheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox N_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.PictureBox StructuralScheme;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage number1;
        private System.Windows.Forms.TabPage number2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

