namespace Airline_Management_System
{
    partial class CancellationTbl
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
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            CIdTb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TIdCb = new ComboBox();
            CancelDGV = new DataGridView();
            label12 = new Label();
            label11 = new Label();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            FCodeTb = new TextBox();
            CancDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)CancelDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(303, 59);
            label2.Name = "label2";
            label2.Size = new Size(295, 37);
            label2.TabIndex = 6;
            label2.Text = "Ticket Cancellation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(339, 16);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 5;
            label1.Text = "Sky Jet Airline";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(497, 208);
            label8.Name = "label8";
            label8.Size = new Size(65, 27);
            label8.TabIndex = 66;
            label8.Text = "Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(70, 204);
            label7.Name = "label7";
            label7.Size = new Size(134, 27);
            label7.TabIndex = 63;
            label7.Text = "FlightCode";
            label7.Click += label7_Click;
            // 
            // CIdTb
            // 
            CIdTb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CIdTb.Location = new Point(219, 128);
            CIdTb.Multiline = true;
            CIdTb.Name = "CIdTb";
            CIdTb.Size = new Size(195, 34);
            CIdTb.TabIndex = 73;
            CIdTb.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(70, 131);
            label5.Name = "label5";
            label5.Size = new Size(131, 27);
            label5.TabIndex = 72;
            label5.Text = "Cancelled";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(497, 131);
            label4.Name = "label4";
            label4.Size = new Size(99, 27);
            label4.TabIndex = 70;
            label4.Text = "Ticketid";
            // 
            // TIdCb
            // 
            TIdCb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TIdCb.FormattingEnabled = true;
            TIdCb.Location = new Point(619, 128);
            TIdCb.Name = "TIdCb";
            TIdCb.Size = new Size(195, 31);
            TIdCb.TabIndex = 74;
            TIdCb.SelectedIndexChanged += TIdCb_SelectedIndexChanged;
            TIdCb.SelectionChangeCommitted += TIdCb_SelectionChangeCommitted;
            // 
            // CancelDGV
            // 
            CancelDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CancelDGV.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Yellow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CancelDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CancelDGV.ColumnHeadersHeight = 29;
            CancelDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CancelDGV.Location = new Point(22, 414);
            CancelDGV.Name = "CancelDGV";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Red;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CancelDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CancelDGV.RowHeadersWidth = 51;
            CancelDGV.RowTemplate.Height = 29;
            CancelDGV.Size = new Size(945, 335);
            CancelDGV.TabIndex = 76;
            CancelDGV.AllowUserToAddRowsChanged += CancelDGV_AllowUserToAddRowsChanged;
            CancelDGV.CellContentClick += CancelDGV_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(339, 348);
            label12.Name = "label12";
            label12.Size = new Size(237, 34);
            label12.TabIndex = 75;
            label12.Text = "Cancellation List";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(947, -2);
            label11.Name = "label11";
            label11.Size = new Size(34, 34);
            label11.TabIndex = 77;
            label11.Text = "X";
            label11.Click += label11_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(564, 278);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 80;
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
            button2.Location = new Point(400, 278);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 79;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(241, 278);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 78;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FCodeTb
            // 
            FCodeTb.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FCodeTb.Location = new Point(219, 201);
            FCodeTb.Multiline = true;
            FCodeTb.Name = "FCodeTb";
            FCodeTb.Size = new Size(195, 34);
            FCodeTb.TabIndex = 81;
            FCodeTb.TextChanged += FCodeTb_TextChanged;
            // 
            // CancDate
            // 
            CancDate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CancDate.Location = new Point(619, 199);
            CancDate.Name = "CancDate";
            CancDate.Size = new Size(201, 32);
            CancDate.TabIndex = 82;
            // 
            // CancellationTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 761);
            Controls.Add(CancDate);
            Controls.Add(FCodeTb);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(CancelDGV);
            Controls.Add(label12);
            Controls.Add(TIdCb);
            Controls.Add(CIdTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancellationTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancellationTblcs";
            Load += CancellationTblcs_Load;
            ((System.ComponentModel.ISupportInitialize)CancelDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label8;
        private Label label7;
        private TextBox CIdTb;
        private Label label5;
        private Label label4;
        private ComboBox TIdCb;
        private DataGridView CancelDGV;
        private Label label12;
        private Label label11;
        private Button button4;
        private Button button2;
        private Button button1;
        private TextBox FCodeTb;
        private DateTimePicker CancDate;
    }
}