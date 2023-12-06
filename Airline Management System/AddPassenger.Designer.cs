namespace Airline_Management_System
{
    partial class AddPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassenger));
            label2 = new Label();
            label1 = new Label();
            bbbb = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Pass = new Label();
            GenderCb = new ComboBox();
            label8 = new Label();
            NationalityCb = new ComboBox();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            PassAdd = new TextBox();
            PassNum = new TextBox();
            PassName = new TextBox();
            PassId = new TextBox();
            PhoneTb = new TextBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(289, 81);
            label2.Name = "label2";
            label2.Size = new Size(278, 37);
            label2.TabIndex = 7;
            label2.Text = "Record Passenger";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(318, 44);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 6;
            label1.Text = "Sky Jet Airline";
            // 
            // bbbb
            // 
            bbbb.AutoSize = true;
            bbbb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            bbbb.ForeColor = Color.MidnightBlue;
            bbbb.Location = new Point(23, 165);
            bbbb.Name = "bbbb";
            bbbb.Size = new Size(153, 27);
            bbbb.TabIndex = 12;
            bbbb.Text = "Passenger Id";
            bbbb.Click += Passid_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(23, 505);
            label4.Name = "label4";
            label4.Size = new Size(83, 27);
            label4.TabIndex = 13;
            label4.Text = "Phone";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(23, 333);
            label5.Name = "label5";
            label5.Size = new Size(221, 27);
            label5.TabIndex = 14;
            label5.Text = "Passenger Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MidnightBlue;
            label6.Location = new Point(23, 282);
            label6.Name = "label6";
            label6.Size = new Size(200, 27);
            label6.TabIndex = 15;
            label6.Text = "Passport Number";
            // 
            // Pass
            // 
            Pass.AutoSize = true;
            Pass.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Pass.ForeColor = Color.MidnightBlue;
            Pass.Location = new Point(23, 223);
            Pass.Name = "Pass";
            Pass.Size = new Size(201, 27);
            Pass.TabIndex = 16;
            Pass.Text = "Passenger Name";
            // 
            // GenderCb
            // 
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "MALE", "FEMALE" });
            GenderCb.Location = new Point(262, 447);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(195, 28);
            GenderCb.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(23, 450);
            label8.Name = "label8";
            label8.Size = new Size(97, 27);
            label8.TabIndex = 17;
            label8.Text = "Gender";
            // 
            // NationalityCb
            // 
            NationalityCb.FormattingEnabled = true;
            NationalityCb.Items.AddRange(new object[] { "INDIAN", "CHINESE", "AMERICAN", "CONGOLESE", "NIGERIAN", "SPANISH", "TURKISH" });
            NationalityCb.Location = new Point(262, 385);
            NationalityCb.Name = "NationalityCb";
            NationalityCb.Size = new Size(195, 28);
            NationalityCb.TabIndex = 20;
            NationalityCb.SelectedIndexChanged += NationalityCb_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(23, 392);
            label9.Name = "label9";
            label9.Size = new Size(133, 27);
            label9.TabIndex = 19;
            label9.Text = "Nationality";
            label9.Click += label9_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(318, 608);
            button2.Name = "button2";
            button2.Size = new Size(124, 35);
            button2.TabIndex = 22;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(155, 608);
            button1.Name = "button1";
            button1.Size = new Size(124, 35);
            button1.TabIndex = 21;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PassAdd
            // 
            PassAdd.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassAdd.Location = new Point(262, 327);
            PassAdd.Multiline = true;
            PassAdd.Name = "PassAdd";
            PassAdd.Size = new Size(195, 34);
            PassAdd.TabIndex = 29;
            PassAdd.TextChanged += PassAdd_TextChanged;
            // 
            // PassNum
            // 
            PassNum.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassNum.Location = new Point(262, 275);
            PassNum.Multiline = true;
            PassNum.Name = "PassNum";
            PassNum.Size = new Size(195, 34);
            PassNum.TabIndex = 30;
            // 
            // PassName
            // 
            PassName.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassName.Location = new Point(262, 223);
            PassName.Multiline = true;
            PassName.Name = "PassName";
            PassName.Size = new Size(195, 34);
            PassName.TabIndex = 31;
            // 
            // PassId
            // 
            PassId.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PassId.Location = new Point(262, 159);
            PassId.Multiline = true;
            PassId.Name = "PassId";
            PassId.Size = new Size(195, 34);
            PassId.TabIndex = 32;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneTb.Location = new Point(262, 499);
            PhoneTb.MaxLength = 20;
            PhoneTb.Multiline = true;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(195, 34);
            PhoneTb.TabIndex = 33;
            PhoneTb.TextChanged += textBox5_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(34, 34);
            label10.TabIndex = 34;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(499, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Navy;
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(879, 41);
            flowLayoutPanel1.TabIndex = 36;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(262, 665);
            button3.Name = "button3";
            button3.Size = new Size(204, 35);
            button3.TabIndex = 37;
            button3.Text = "ViewPassengers";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(485, 608);
            button4.Name = "button4";
            button4.Size = new Size(124, 35);
            button4.TabIndex = 38;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // AddPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 749);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(PhoneTb);
            Controls.Add(PassId);
            Controls.Add(PassName);
            Controls.Add(PassNum);
            Controls.Add(PassAdd);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NationalityCb);
            Controls.Add(label9);
            Controls.Add(GenderCb);
            Controls.Add(label8);
            Controls.Add(Pass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(bbbb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPassenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPassenger";
            Load += AddPassenger_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label bbbb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label Pass;
        private ComboBox GenderCb;
        private Label label8;
        private ComboBox NationalityCb;
        private Label label9;
        private Button button2;
        private Button button1;
        private TextBox PassAdd;
        private TextBox PassNum;
        private TextBox PassName;
        private TextBox PassId;
        private TextBox PhoneTb;
        private Label label10;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button3;
        private Button button4;
    }
}