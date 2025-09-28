namespace FinalProjectOOP
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGoldenrodYellow;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.Olive;
            groupBox1.Location = new Point(277, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 111);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "PERSONAL INFORMATION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 93);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Balance :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 62);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Account Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Account ID :";
            // 
            // button1
            // 
            button1.Location = new Point(35, 416);
            button1.Name = "button1";
            button1.Size = new Size(87, 24);
            button1.TabIndex = 2;
            button1.Text = "Main Screen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 164);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(402, 260);
            button2.Name = "button2";
            button2.Size = new Size(101, 27);
            button2.TabIndex = 5;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(86, 64);
            button3.Name = "button3";
            button3.Size = new Size(73, 34);
            button3.TabIndex = 6;
            button3.Text = "!";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "CashOut Window";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
    }
}