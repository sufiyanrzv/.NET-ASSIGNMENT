namespace Airline_Management_System
{
    partial class ViewFlights
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            FDate = new DateTimePicker();
            FDestCb = new ComboBox();
            FSrcCb = new ComboBox();
            SeatNum = new TextBox();
            FCodeTb = new TextBox();
            FlightDGV = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)FlightDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(260, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 4;
            label1.Text = "Sky Jet Airline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(207, 56);
            label2.Name = "label2";
            label2.Size = new Size(348, 37);
            label2.TabIndex = 5;
            label2.Text = "View Scheduled Flights";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(328, 314);
            label4.Name = "label4";
            label4.Size = new Size(0, 27);
            label4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(32, 214);
            label7.Name = "label7";
            label7.Size = new Size(139, 27);
            label7.TabIndex = 27;
            label7.Text = "TakeofDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(441, 151);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 25;
            label6.Text = "Source";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(441, 212);
            label5.Name = "label5";
            label5.Size = new Size(137, 27);
            label5.TabIndex = 24;
            label5.Text = "Destination";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(188, 287);
            label3.Name = "label3";
            label3.Size = new Size(161, 27);
            label3.TabIndex = 23;
            label3.Text = "Num Of Seats";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(31, 147);
            label8.Name = "label8";
            label8.Size = new Size(140, 27);
            label8.TabIndex = 22;
            label8.Text = "Flight Code";
            // 
            // FDate
            // 
            FDate.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            FDate.Location = new Point(207, 205);
            FDate.Name = "FDate";
            FDate.Size = new Size(201, 36);
            FDate.TabIndex = 32;
            FDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // FDestCb
            // 
            FDestCb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FDestCb.FormattingEnabled = true;
            FDestCb.Items.AddRange(new object[] { "Benglore", "Mumbai", "Chennai", "Delhi", "Dubai", "Jaipur", "Madrid", "NewYork", "Beejing" });
            FDestCb.Location = new Point(584, 217);
            FDestCb.Name = "FDestCb";
            FDestCb.Size = new Size(195, 31);
            FDestCb.TabIndex = 31;
            // 
            // FSrcCb
            // 
            FSrcCb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FSrcCb.FormattingEnabled = true;
            FSrcCb.Items.AddRange(new object[] { "Benglore", "Mumbai", "Chennai", "Delhi", "Dubai", "Jaipur", "Madrid", "NewYork", "Beejing" });
            FSrcCb.Location = new Point(595, 147);
            FSrcCb.Name = "FSrcCb";
            FSrcCb.Size = new Size(195, 31);
            FSrcCb.TabIndex = 30;
            FSrcCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // SeatNum
            // 
            SeatNum.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            SeatNum.Location = new Point(364, 287);
            SeatNum.Multiline = true;
            SeatNum.Name = "SeatNum";
            SeatNum.Size = new Size(201, 34);
            SeatNum.TabIndex = 29;
            // 
            // FCodeTb
            // 
            FCodeTb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FCodeTb.Location = new Point(207, 141);
            FCodeTb.Multiline = true;
            FCodeTb.Name = "FCodeTb";
            FCodeTb.Size = new Size(195, 34);
            FCodeTb.TabIndex = 28;
            // 
            // FlightDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 128);
            FlightDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            FlightDGV.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            FlightDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            FlightDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightDGV.GridColor = SystemColors.ActiveCaption;
            FlightDGV.Location = new Point(12, 409);
            FlightDGV.Name = "FlightDGV";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkGreen;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.GrayText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            FlightDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            FlightDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(0, 0, 192);
            FlightDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            FlightDGV.RowTemplate.Height = 29;
            FlightDGV.Size = new Size(779, 288);
            FlightDGV.TabIndex = 33;
            FlightDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(396, 351);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 35;
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
            button1.Location = new Point(136, 351);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 34;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(266, 351);
            button3.Name = "button3";
            button3.Size = new Size(124, 35);
            button3.TabIndex = 36;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(526, 351);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 37;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 700);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FlightDGV);
            Controls.Add(FDate);
            Controls.Add(FDestCb);
            Controls.Add(FSrcCb);
            Controls.Add(SeatNum);
            Controls.Add(FCodeTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewFlights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewFlightscs";
            Load += ViewFlightscs_Load;
            ((System.ComponentModel.ISupportInitialize)FlightDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label8;
        private DateTimePicker FDate;
        private ComboBox FDestCb;
        private ComboBox FSrcCb;
        private TextBox SeatNum;
        private TextBox FCodeTb;
        private DataGridView FlightDGV;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}