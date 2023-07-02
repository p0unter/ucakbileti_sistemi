namespace Ucaq_Bilet
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            groupBox3 = new GroupBox();
            maskedTextBox2 = new MaskedTextBox();
            label7 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(507, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 383);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Verdana", 5F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(386, 105);
            label8.Name = "label8";
            label8.Size = new Size(39, 12);
            label8.TabIndex = 11;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 6F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(189, 157);
            button2.Name = "button2";
            button2.Size = new Size(236, 22);
            button2.TabIndex = 10;
            button2.Text = "Değiştir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox1.Location = new Point(189, 278);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(75, 32);
            maskedTextBox1.TabIndex = 8;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Font = new Font("Microsoft YaHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(88, 274);
            label6.Name = "label6";
            label6.Size = new Size(86, 39);
            label6.TabIndex = 7;
            label6.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("UD Digi Kyokasho NP-B", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(189, 232);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 31);
            dateTimePicker1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Font = new Font("Microsoft YaHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 224);
            label5.Name = "label5";
            label5.Size = new Size(95, 39);
            label5.TabIndex = 5;
            label5.Text = "Tarih:";
            label5.Click += label5_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Antalya", "Samsun", "Malatya", "Adana", "İstanbul", "Hatay", "Ankara" });
            comboBox2.Location = new Point(189, 182);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 33);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Antalya", "Samsun", "Malatya", "Adana", "İstanbul", "Hatay", "Ankara" });
            comboBox1.Location = new Point(189, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 33);
            comboBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Microsoft YaHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 176);
            label4.Name = "label4";
            label4.Size = new Size(126, 39);
            label4.TabIndex = 2;
            label4.Text = "Nereye:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Microsoft YaHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(27, 120);
            label3.Name = "label3";
            label3.Size = new Size(147, 39);
            label3.TabIndex = 1;
            label3.Text = "Nereden:";
            label3.Click += label3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 550);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(967, 154);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 494);
            button1.Name = "button1";
            button1.Size = new Size(967, 45);
            button1.TabIndex = 3;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-12, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 86);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("AR DESTINE", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 11);
            label1.Name = "label1";
            label1.Size = new Size(377, 58);
            label1.TabIndex = 0;
            label1.Text = "Jupiter AIRLES";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-12, 724);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 79);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 12);
            label2.Name = "label2";
            label2.Size = new Size(312, 25);
            label2.TabIndex = 0;
            label2.Text = "Jupiter AIRLES© - Tüm hakları saklıdır.";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(maskedTextBox2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(maskedTextBox3);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(472, 383);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yolcu Bilgileri";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox2.Location = new Point(205, 192);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(178, 32);
            maskedTextBox2.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Microsoft YaHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(117, 185);
            label7.Name = "label7";
            label7.Size = new Size(73, 39);
            label7.TabIndex = 11;
            label7.Text = "TEL:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Font = new Font("Verdana", 10F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox3.Location = new Point(205, 246);
            maskedTextBox3.Mask = "00000000000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(157, 32);
            maskedTextBox3.TabIndex = 10;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(205, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 32);
            textBox1.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Microsoft YaHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(129, 239);
            label9.Name = "label9";
            label9.Size = new Size(61, 39);
            label9.TabIndex = 2;
            label9.Text = "TC:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Font = new Font("Microsoft YaHei", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(25, 132);
            label10.Name = "label10";
            label10.Size = new Size(165, 39);
            label10.TabIndex = 1;
            label10.Text = "Ad-Soyad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 770);
            Controls.Add(groupBox3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private Label label6;
        private GroupBox groupBox3;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox1;
        private Label label9;
        private Label label10;
        private MaskedTextBox maskedTextBox2;
        private Label label7;
        private Button button2;
        private Label label8;
    }
}