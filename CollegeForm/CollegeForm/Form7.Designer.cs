namespace CollegeForm
{
    partial class Form7
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(454, 58);
            label1.TabIndex = 0;
            label1.Text = "Railway Reservation Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 43);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 1;
            label2.Text = "From";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 93);
            label3.Name = "label3";
            label3.Size = new Size(32, 28);
            label3.TabIndex = 2;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 151);
            label4.Name = "label4";
            label4.Size = new Size(130, 28);
            label4.TabIndex = 3;
            label4.Text = "Train Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 212);
            label5.Name = "label5";
            label5.Size = new Size(55, 28);
            label5.TabIndex = 4;
            label5.Text = "Class";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(253, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(253, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(253, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 34);
            textBox3.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SL", "3A", "2A" });
            comboBox1.Location = new Point(253, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 36);
            comboBox1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 264);
            label6.Name = "label6";
            label6.Size = new Size(161, 28);
            label6.TabIndex = 9;
            label6.Text = "Number Of Seats";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox2.Location = new Point(253, 256);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 36);
            comboBox2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 54);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 11;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 324);
            label8.Name = "label8";
            label8.Size = new Size(144, 28);
            label8.TabIndex = 12;
            label8.Text = "Payment Mode";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(137, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 34);
            textBox4.TabIndex = 13;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(179, 322);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(127, 32);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "CreditCard";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(312, 324);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 32);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "DebitCard";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(36, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 366);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Train Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(137, 108);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 34);
            textBox5.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 111);
            label9.Name = "label9";
            label9.Size = new Size(59, 28);
            label9.TabIndex = 17;
            label9.Text = "Email";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(137, 161);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 34);
            textBox6.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 162);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 19;
            label10.Text = "Mobile no.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(482, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 351);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Details";
            // 
            // button1
            // 
            button1.Location = new Point(348, 512);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(800, 608);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private GroupBox groupBox2;
        private Button button1;
    }
}