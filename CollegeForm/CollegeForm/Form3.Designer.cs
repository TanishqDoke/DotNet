namespace CollegeForm
{
    partial class Form3
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 130);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter number of t-shirts to buy :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(448, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 22F, FontStyle.Bold);
            label2.Location = new Point(361, 298);
            label2.Name = "label2";
            label2.Size = new Size(110, 49);
            label2.TabIndex = 5;
            label2.Text = "Offer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(171, 367);
            label3.Name = "label3";
            label3.Size = new Size(556, 35);
            label3.TabIndex = 6;
            label3.Text = "Apply Promocode \"TRUEBLUE\" for 10% discount.";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(364, 417);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(432, 588);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(278, 584);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 9;
            label4.Text = "Final Price:";
            // 
            // button1
            // 
            button1.Location = new Point(377, 477);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(207, 183);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Small (Rs 125)";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(207, 220);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(143, 24);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Medium (Rs 175)";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(207, 256);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(125, 24);
            checkBox3.TabIndex = 13;
            checkBox3.Text = "Large (Rs 250)";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(361, 9);
            label5.Name = "label5";
            label5.Size = new Size(241, 46);
            label5.TabIndex = 14;
            label5.Text = "Tshirt Booking ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox1.Location = new Point(364, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(39, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox2.Location = new Point(364, 218);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(39, 28);
            comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox3.Location = new Point(364, 252);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(39, 28);
            comboBox3.TabIndex = 17;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1046, 624);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label5;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}