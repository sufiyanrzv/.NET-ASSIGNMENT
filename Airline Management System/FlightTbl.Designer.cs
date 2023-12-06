namespace Airline_Management_System
{
    partial class FlightTbl
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
            FCode = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            SeatNum = new TextBox();
            FSrc = new ComboBox();
            FDest = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            FDate = new DateTimePicker();
            label4 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(281, 32);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 3;
            label1.Text = "Sky Jet Airline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(251, 69);
            label2.Name = "label2";
            label2.Size = new Size(290, 37);
            label2.TabIndex = 4;
            label2.Text = "Record New Flights";
            // 
            // FCode
            // 
            FCode.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FCode.Location = new Point(247, 221);
            FCode.Multiline = true;
            FCode.Name = "FCode";
            FCode.Size = new Size(195, 34);
            FCode.TabIndex = 10;
            FCode.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(74, 228);
            label3.Name = "label3";
            label3.Size = new Size(140, 27);
            label3.TabIndex = 11;
            label3.Text = "Flight Code";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(74, 340);
            label5.Name = "label5";
            label5.Size = new Size(137, 27);
            label5.TabIndex = 13;
            label5.Text = "Destination";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(74, 283);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 14;
            label6.Text = "Source";
            label6.Click += label6_Click;
            // 
            // SeatNum
            // 
            SeatNum.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SeatNum.Location = new Point(247, 447);
            SeatNum.Multiline = true;
            SeatNum.Name = "SeatNum";
            SeatNum.Size = new Size(201, 34);
            SeatNum.TabIndex = 15;
            SeatNum.TextChanged += textBox1_TextChanged;
            // 
            // FSrc
            // 
            FSrc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FSrc.FormattingEnabled = true;
            FSrc.Items.AddRange(new object[] { "Benglore", "Mumbai", "Chennai", "Delhi", "Dubai", "Jaipur", "Madrid", "NewYork", "Beejing" });
            FSrc.Location = new Point(247, 286);
            FSrc.Name = "FSrc";
            FSrc.Size = new Size(195, 31);
            FSrc.TabIndex = 16;
            FSrc.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FDest
            // 
            FDest.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FDest.FormattingEnabled = true;
            FDest.Items.AddRange(new object[] { "Benglore", "Mumbai", "Chennai", "Delhi", "Dubai", "Jaipur", "Madrid", "NewYork", "Beejing" });
            FDest.Location = new Point(247, 340);
            FDest.Name = "FDest";
            FDest.Size = new Size(195, 31);
            FDest.TabIndex = 17;
            FDest.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(408, 547);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 19;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(77, 547);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 18;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.aeroplane2;
            pictureBox1.Location = new Point(454, 197);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(377, 311);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(77, 399);
            label7.Name = "label7";
            label7.Size = new Size(139, 27);
            label7.TabIndex = 21;
            label7.Text = "TakeofDate";
            label7.Click += label7_Click;
            // 
            // FDate
            // 
            FDate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FDate.Location = new Point(247, 399);
            FDate.Name = "FDate";
            FDate.Size = new Size(201, 32);
            FDate.TabIndex = 22;
            FDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(74, 454);
            label4.Name = "label4";
            label4.Size = new Size(161, 27);
            label4.TabIndex = 12;
            label4.Text = "Num Of Seats";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 26);
            panel2.TabIndex = 59;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 677);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 24);
            panel1.TabIndex = 60;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(247, 547);
            button3.Name = "button3";
            button3.Size = new Size(124, 35);
            button3.TabIndex = 61;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(568, 547);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 62;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FlightTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 701);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(FDate);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FDest);
            Controls.Add(FSrc);
            Controls.Add(SeatNum);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(FCode);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FllightTblcs";
            Load += FllightTblcs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FCode;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox SeatNum;
        private ComboBox FSrc;
        private ComboBox FDest;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label7;
        private DateTimePicker FDate;
        private Label label4;
        private Panel panel2;
        private Panel panel1;
        private Button button3;
        private Button button4;
    }
}