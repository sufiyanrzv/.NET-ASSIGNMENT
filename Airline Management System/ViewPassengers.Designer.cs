namespace Airline_Management_System
{
    partial class ViewPassengers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label2 = new Label();
            label1 = new Label();
            pidTb = new TextBox();
            label3 = new Label();
            passnameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ppassTb = new TextBox();
            passaddTb = new TextBox();
            pphoneTb = new TextBox();
            label6 = new Label();
            label7 = new Label();
            gendCb = new ComboBox();
            natCb = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            PassengerDGV = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(322, 72);
            label2.Name = "label2";
            label2.Size = new Size(258, 37);
            label2.TabIndex = 9;
            label2.Text = "View Passengers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(338, 35);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 8;
            label1.Text = "Sky Jet Airline";
            // 
            // pidTb
            // 
            pidTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            pidTb.Location = new Point(278, 143);
            pidTb.Multiline = true;
            pidTb.Name = "pidTb";
            pidTb.Size = new Size(195, 34);
            pidTb.TabIndex = 36;
            pidTb.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(119, 146);
            label3.Name = "label3";
            label3.Size = new Size(153, 27);
            label3.TabIndex = 35;
            label3.Text = "Passenger Id";
            label3.Click += label3_Click;
            // 
            // passnameTb
            // 
            passnameTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            passnameTb.Location = new Point(643, 139);
            passnameTb.Multiline = true;
            passnameTb.Name = "passnameTb";
            passnameTb.Size = new Size(195, 34);
            passnameTb.TabIndex = 40;
            passnameTb.TextChanged += passname_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(501, 150);
            label4.Name = "label4";
            label4.Size = new Size(81, 27);
            label4.TabIndex = 39;
            label4.Text = "Name";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(119, 195);
            label5.Name = "label5";
            label5.Size = new Size(94, 27);
            label5.TabIndex = 41;
            label5.Text = "Pasport";
            label5.Click += label5_Click;
            // 
            // ppassTb
            // 
            ppassTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ppassTb.Location = new Point(278, 195);
            ppassTb.Multiline = true;
            ppassTb.Name = "ppassTb";
            ppassTb.Size = new Size(195, 34);
            ppassTb.TabIndex = 42;
            // 
            // passaddTb
            // 
            passaddTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            passaddTb.Location = new Point(643, 195);
            passaddTb.Multiline = true;
            passaddTb.Name = "passaddTb";
            passaddTb.Size = new Size(195, 34);
            passaddTb.TabIndex = 43;
            // 
            // pphoneTb
            // 
            pphoneTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            pphoneTb.Location = new Point(432, 311);
            pphoneTb.Multiline = true;
            pphoneTb.Name = "pphoneTb";
            pphoneTb.Size = new Size(195, 34);
            pphoneTb.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(119, 247);
            label6.Name = "label6";
            label6.Size = new Size(133, 27);
            label6.TabIndex = 45;
            label6.Text = "Nationality";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(501, 202);
            label7.Name = "label7";
            label7.Size = new Size(101, 27);
            label7.TabIndex = 46;
            label7.Text = "Address";
            // 
            // gendCb
            // 
            gendCb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            gendCb.FormattingEnabled = true;
            gendCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            gendCb.Location = new Point(643, 248);
            gendCb.Name = "gendCb";
            gendCb.Size = new Size(195, 35);
            gendCb.TabIndex = 47;
            // 
            // natCb
            // 
            natCb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            natCb.FormattingEnabled = true;
            natCb.Items.AddRange(new object[] { "INDIAN", "CHINESE", "AMERICAN", "CONGOLESE", "NIGERIAN", "SPANISH", "TURKISH" });
            natCb.Location = new Point(278, 247);
            natCb.Name = "natCb";
            natCb.Size = new Size(195, 31);
            natCb.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(501, 248);
            label8.Name = "label8";
            label8.Size = new Size(97, 27);
            label8.TabIndex = 49;
            label8.Text = "Gender";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(311, 314);
            label9.Name = "label9";
            label9.Size = new Size(83, 27);
            label9.TabIndex = 50;
            label9.Text = "Phone";
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(598, 374);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 55;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(338, 374);
            button3.Name = "button3";
            button3.Size = new Size(124, 35);
            button3.TabIndex = 54;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(468, 374);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 53;
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
            button1.Location = new Point(194, 374);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 52;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PassengerDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.Gray;
            PassengerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            PassengerDGV.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.IndianRed;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PassengerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PassengerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PassengerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            PassengerDGV.Location = new Point(12, 437);
            PassengerDGV.Name = "PassengerDGV";
            PassengerDGV.RowHeadersWidth = 51;
            PassengerDGV.RowTemplate.Height = 29;
            PassengerDGV.Size = new Size(935, 306);
            PassengerDGV.TabIndex = 56;
            PassengerDGV.CellContentClick += PassengerDGV_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 743);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 24);
            panel1.TabIndex = 57;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 26);
            panel2.TabIndex = 58;
            // 
            // ViewPassengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 767);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PassengerDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(natCb);
            Controls.Add(gendCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pphoneTb);
            Controls.Add(passaddTb);
            Controls.Add(ppassTb);
            Controls.Add(label5);
            Controls.Add(passnameTb);
            Controls.Add(label4);
            Controls.Add(pidTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewPassengers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewPassengers";
            Load += ViewPassengers_Load;
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox pidTb;
        private Label label3;
        private TextBox passnameTb;
        private Label label4;
        private Label label5;
        private TextBox ppassTb;
        private TextBox passaddTb;
        private TextBox pphoneTb;
        private Label label6;
        private Label label7;
        private ComboBox gendCb;
        private ComboBox natCb;
        private Label label8;
        private Label label9;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView PassengerDGV;
        private Panel panel1;
        private Panel panel2;
    }
}