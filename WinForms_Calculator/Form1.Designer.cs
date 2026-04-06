namespace WinForms_Calculator
{
    partial class Form1
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
            Button button1;
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btn_add = new Button();
            button_0 = new Button();
            btn_sub = new Button();
            btn_multi = new Button();
            btn_div = new Button();
            btn_equal = new Button();
            btn_clear = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(15, 109);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 48);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonFace;
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(15, 26);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(362, 50);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(150, 109);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(96, 48);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(281, 109);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(96, 48);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(15, 190);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(96, 48);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(150, 190);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(96, 48);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(281, 190);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(96, 48);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(15, 272);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(96, 48);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F);
            button8.Location = new Point(150, 272);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(96, 48);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F);
            button9.Location = new Point(281, 272);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(96, 48);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(15, 355);
            btn_add.Margin = new Padding(4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(96, 48);
            btn_add.TabIndex = 10;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // button_0
            // 
            button_0.Font = new Font("Segoe UI", 12F);
            button_0.Location = new Point(150, 355);
            button_0.Margin = new Padding(4);
            button_0.Name = "button_0";
            button_0.Size = new Size(96, 48);
            button_0.TabIndex = 11;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_0_Click;
            // 
            // btn_sub
            // 
            btn_sub.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sub.Location = new Point(281, 355);
            btn_sub.Margin = new Padding(4);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(96, 48);
            btn_sub.TabIndex = 12;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn_multi
            // 
            btn_multi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_multi.Location = new Point(15, 438);
            btn_multi.Margin = new Padding(4);
            btn_multi.Name = "btn_multi";
            btn_multi.Size = new Size(96, 48);
            btn_multi.TabIndex = 14;
            btn_multi.Text = "*";
            btn_multi.UseVisualStyleBackColor = true;
            btn_multi.Click += btn_multi_Click;
            // 
            // btn_div
            // 
            btn_div.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_div.Location = new Point(150, 438);
            btn_div.Margin = new Padding(4);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(96, 48);
            btn_div.TabIndex = 15;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            btn_div.Click += btn_div_Click;
            // 
            // btn_equal
            // 
            btn_equal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_equal.Location = new Point(281, 438);
            btn_equal.Margin = new Padding(4);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(96, 48);
            btn_equal.TabIndex = 16;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(15, 514);
            btn_clear.Margin = new Padding(4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(362, 48);
            btn_clear.TabIndex = 17;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 619);
            Controls.Add(btn_clear);
            Controls.Add(btn_equal);
            Controls.Add(btn_div);
            Controls.Add(btn_multi);
            Controls.Add(btn_sub);
            Controls.Add(button_0);
            Controls.Add(btn_add);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btn_add;
        private Button button_0;
        private Button btn_sub;
        private Button btn_multi;
        private Button btn_div;
        private Button btn_equal;
        private Button btn_clear;
    }
}
