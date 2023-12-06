namespace Airline_Management_System
{
    partial class Ticket
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
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            PNameTb = new TextBox();
            TIdTb = new TextBox();
            FCodeCb = new ComboBox();
            PIdCb = new ComboBox();
            label8 = new Label();
            PPassTb = new TextBox();
            label9 = new Label();
            label10 = new Label();
            PAmtTb = new TextBox();
            label11 = new Label();
            label12 = new Label();
            TicketDGV = new DataGridView();
            PNatTb = new TextBox();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)TicketDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(325, 67);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 10;
            label2.Text = "Ticket Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(325, 21);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 11;
            label1.Text = "Sky Jet Airline";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(41, 234);
            label4.Name = "label4";
            label4.Size = new Size(104, 27);
            label4.TabIndex = 40;
            label4.Text = "Passport";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(41, 182);
            label3.Name = "label3";
            label3.Size = new Size(147, 27);
            label3.TabIndex = 41;
            label3.Text = "PassengerId";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(41, 135);
            label5.Name = "label5";
            label5.Size = new Size(99, 27);
            label5.TabIndex = 42;
            label5.Text = "TicketId";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(393, 182);
            label6.Name = "label6";
            label6.Size = new Size(81, 27);
            label6.TabIndex = 43;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(393, 135);
            label7.Name = "label7";
            label7.Size = new Size(134, 27);
            label7.TabIndex = 44;
            label7.Text = "FlightCode";
            // 
            // PNameTb
            // 
            PNameTb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PNameTb.Location = new Point(533, 175);
            PNameTb.Multiline = true;
            PNameTb.Name = "PNameTb";
            PNameTb.Size = new Size(195, 34);
            PNameTb.TabIndex = 45;
            PNameTb.TextAlign = HorizontalAlignment.Right;
            PNameTb.TextChanged += PNameTb_TextChanged;
            // 
            // TIdTb
            // 
            TIdTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            TIdTb.Location = new Point(192, 128);
            TIdTb.Multiline = true;
            TIdTb.Name = "TIdTb";
            TIdTb.Size = new Size(195, 34);
            TIdTb.TabIndex = 47;
            // 
            // FCodeCb
            // 
            FCodeCb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FCodeCb.FormattingEnabled = true;
            FCodeCb.Location = new Point(532, 128);
            FCodeCb.Name = "FCodeCb";
            FCodeCb.Size = new Size(195, 31);
            FCodeCb.TabIndex = 49;
            // 
            // PIdCb
            // 
            PIdCb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PIdCb.FormattingEnabled = true;
            PIdCb.Location = new Point(192, 185);
            PIdCb.Name = "PIdCb";
            PIdCb.Size = new Size(195, 31);
            PIdCb.TabIndex = 50;
            PIdCb.SelectedIndexChanged += PIdCb_SelectedIndexChanged;
            PIdCb.SelectionChangeCommitted += PIdCb_SelectionChangeCommitted;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(393, 237);
            label8.Name = "label8";
            label8.Size = new Size(133, 27);
            label8.TabIndex = 52;
            label8.Text = "Nationality";
            // 
            // PPassTb
            // 
            PPassTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PPassTb.Location = new Point(192, 230);
            PPassTb.Multiline = true;
            PPassTb.Name = "PPassTb";
            PPassTb.Size = new Size(195, 34);
            PPassTb.TabIndex = 53;
            PPassTb.TextAlign = HorizontalAlignment.Right;
            PPassTb.TextChanged += PPassTb_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(41, 287);
            label9.Name = "label9";
            label9.Size = new Size(0, 27);
            label9.TabIndex = 54;
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.MidnightBlue;
            label10.Location = new Point(286, 298);
            label10.Name = "label10";
            label10.Size = new Size(101, 27);
            label10.TabIndex = 56;
            label10.Text = "Amount";
            // 
            // PAmtTb
            // 
            PAmtTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PAmtTb.Location = new Point(402, 287);
            PAmtTb.Multiline = true;
            PAmtTb.Name = "PAmtTb";
            PAmtTb.Size = new Size(195, 34);
            PAmtTb.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(945, -1);
            label11.Name = "label11";
            label11.Size = new Size(34, 34);
            label11.TabIndex = 58;
            label11.Text = "X";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(357, 403);
            label12.Name = "label12";
            label12.Size = new Size(145, 34);
            label12.TabIndex = 59;
            label12.Text = " Bookings";
            // 
            // TicketDGV
            // 
            TicketDGV.BackgroundColor = SystemColors.ButtonHighlight;
            TicketDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketDGV.Location = new Point(13, 440);
            TicketDGV.Name = "TicketDGV";
            TicketDGV.RowHeadersWidth = 51;
            TicketDGV.RowTemplate.Height = 29;
            TicketDGV.Size = new Size(949, 317);
            TicketDGV.TabIndex = 60;
            // 
            // PNatTb
            // 
            PNatTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PNatTb.Location = new Point(532, 230);
            PNatTb.Multiline = true;
            PNatTb.Name = "PNatTb";
            PNatTb.Size = new Size(195, 34);
            PNatTb.TabIndex = 61;
            PNatTb.TextAlign = HorizontalAlignment.Right;
            PNatTb.TextChanged += PNatTb_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(581, 345);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 65;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(393, 345);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 63;
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
            button1.Location = new Point(192, 345);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 62;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 761);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PNatTb);
            Controls.Add(TicketDGV);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(PAmtTb);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(PPassTb);
            Controls.Add(label8);
            Controls.Add(PIdCb);
            Controls.Add(FCodeCb);
            Controls.Add(TIdTb);
            Controls.Add(PNameTb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            Load += Ticket_Load;
            ((System.ComponentModel.ISupportInitialize)TicketDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox PNameTb;
        private TextBox TIdTb;
        private ComboBox FCodeCb;
        private ComboBox PIdCb;
        private Label label8;
        private TextBox PPassTb;
        private Label label9;
        private Label label10;
        private TextBox PAmtTb;
        private Label label11;
        private Label label12;
        private DataGridView TicketDGV;
        private TextBox PNatTb;
        private Button button4;
        private Button button2;
        private Button button1;
    }
}