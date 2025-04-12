namespace laboratorium6
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            numericUpDown6 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 94);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "PLANSZA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 125);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 161);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 2;
            label3.Text = "Y";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 203);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 5;
            label4.Text = "CZAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 67);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "DYDELF";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 130);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 11;
            label6.Text = "SZOPS";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 203);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 13;
            label7.Text = "KROKODYL";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Location = new Point(101, 276);
            button1.Name = "button1";
            button1.Size = new Size(233, 29);
            button1.TabIndex = 16;
            button1.Text = "kliknijj aby rozpoczac";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(144, 123);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 27);
            numericUpDown1.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(144, 161);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(48, 27);
            numericUpDown2.TabIndex = 18;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(260, 94);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(48, 27);
            numericUpDown3.TabIndex = 19;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(260, 159);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(48, 27);
            numericUpDown4.TabIndex = 20;
            numericUpDown4.ValueChanged += numericUpDown4_ValueChanged;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(260, 227);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(48, 27);
            numericUpDown5.TabIndex = 21;
            numericUpDown5.ValueChanged += numericUpDown5_ValueChanged;
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(141, 227);
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(48, 27);
            numericUpDown6.TabIndex = 22;
            numericUpDown6.ValueChanged += numericUpDown6_ValueChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private NumericUpDown numericUpDown6;
    }
}