namespace GymManagement
{
    partial class UpdateDelete
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            TimingCb = new ComboBox();
            AmountTb = new TextBox();
            label9 = new Label();
            label8 = new Label();
            GenderCb = new ComboBox();
            label7 = new Label();
            AgeTb = new TextBox();
            PhoneTb = new TextBox();
            label6 = new Label();
            label5 = new Label();
            NameTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label10 = new Label();
            MemberSDGV = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1080, 604);
            button3.Name = "button3";
            button3.Size = new Size(131, 48);
            button3.TabIndex = 35;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(742, 607);
            button2.Name = "button2";
            button2.Size = new Size(131, 48);
            button2.TabIndex = 34;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(578, 605);
            button1.Name = "button1";
            button1.Size = new Size(131, 50);
            button1.TabIndex = 33;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TimingCb
            // 
            TimingCb.FormattingEnabled = true;
            TimingCb.Items.AddRange(new object[] { "6AM - 8AM", "8AM - 10AM", "6PM - 8PM", "8PM - 10PM" });
            TimingCb.Location = new Point(83, 564);
            TimingCb.Name = "TimingCb";
            TimingCb.Size = new Size(215, 28);
            TimingCb.TabIndex = 32;
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountTb.Location = new Point(83, 497);
            AmountTb.Name = "AmountTb";
            AmountTb.PlaceholderText = "Enter Amount";
            AmountTb.Size = new Size(215, 29);
            AmountTb.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(83, 539);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 30;
            label9.Text = "Timing";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 469);
            label8.Name = "label8";
            label8.Size = new Size(154, 25);
            label8.TabIndex = 29;
            label8.Text = "Monthly Amount";
            // 
            // GenderCb
            // 
            GenderCb.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female", "Other" });
            GenderCb.Location = new Point(83, 423);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(215, 30);
            GenderCb.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(83, 398);
            label7.Name = "label7";
            label7.Size = new Size(77, 25);
            label7.TabIndex = 27;
            label7.Text = "Gender";
            // 
            // AgeTb
            // 
            AgeTb.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgeTb.Location = new Point(83, 348);
            AgeTb.Name = "AgeTb";
            AgeTb.PlaceholderText = "Enter Your Age";
            AgeTb.Size = new Size(215, 29);
            AgeTb.TabIndex = 26;
            // 
            // PhoneTb
            // 
            PhoneTb.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneTb.Location = new Point(83, 275);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.PlaceholderText = "Enter Your Number";
            PhoneTb.Size = new Size(215, 29);
            PhoneTb.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(83, 323);
            label6.Name = "label6";
            label6.Size = new Size(48, 25);
            label6.TabIndex = 24;
            label6.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(83, 250);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 23;
            label5.Text = "Phone Number";
            // 
            // NameTb
            // 
            NameTb.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTb.Location = new Point(83, 202);
            NameTb.Name = "NameTb";
            NameTb.PlaceholderText = "Enter Member Name";
            NameTb.Size = new Size(215, 29);
            NameTb.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(83, 177);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 21;
            label4.Text = "Member Name";
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1253, 9);
            label3.Name = "label3";
            label3.Size = new Size(124, 78);
            label3.TabIndex = 20;
            label3.Text = "X";
            label3.TextAlign = ContentAlignment.TopRight;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(518, 80);
            label2.Name = "label2";
            label2.Size = new Size(390, 44);
            label2.TabIndex = 19;
            label2.Text = "Update And Delete Member";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(518, 20);
            label1.Name = "label1";
            label1.Size = new Size(355, 48);
            label1.TabIndex = 18;
            label1.Text = "Fitness Centre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(734, 130);
            label10.Name = "label10";
            label10.Size = new Size(361, 44);
            label10.TabIndex = 36;
            label10.Text = "Click On The Member To Be Deleted";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MemberSDGV
            // 
            MemberSDGV.AllowUserToAddRows = false;
            MemberSDGV.AllowUserToDeleteRows = false;
            MemberSDGV.AllowUserToResizeColumns = false;
            MemberSDGV.AllowUserToResizeRows = false;
            MemberSDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MemberSDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MemberSDGV.BackgroundColor = SystemColors.ControlLightLight;
            MemberSDGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Brown;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MemberSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MemberSDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            MemberSDGV.DefaultCellStyle = dataGridViewCellStyle2;
            MemberSDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            MemberSDGV.GridColor = SystemColors.ControlLightLight;
            MemberSDGV.Location = new Point(468, 184);
            MemberSDGV.Margin = new Padding(10);
            MemberSDGV.Name = "MemberSDGV";
            MemberSDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            MemberSDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MemberSDGV.RowHeadersVisible = false;
            MemberSDGV.RowHeadersWidth = 5;
            MemberSDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            MemberSDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            MemberSDGV.RowTemplate.Height = 25;
            MemberSDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberSDGV.ShowCellErrors = false;
            MemberSDGV.ShowCellToolTips = false;
            MemberSDGV.ShowEditingIcon = false;
            MemberSDGV.Size = new Size(849, 393);
            MemberSDGV.TabIndex = 45;
            MemberSDGV.CellContentClick += MemberSDGV_CellContentClick;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(913, 605);
            button4.Name = "button4";
            button4.Size = new Size(131, 48);
            button4.TabIndex = 46;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UpdateDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 809);
            Controls.Add(button4);
            Controls.Add(MemberSDGV);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TimingCb);
            Controls.Add(AmountTb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(GenderCb);
            Controls.Add(label7);
            Controls.Add(AgeTb);
            Controls.Add(PhoneTb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(NameTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.IBeam;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateDelete";
            Load += UpdateDelete_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox TimingCb;
        private TextBox AmountTb;
        private Label label9;
        private Label label8;
        private ComboBox GenderCb;
        private Label label7;
        private TextBox AgeTb;
        private TextBox PhoneTb;
        private Label label6;
        private Label label5;
        private TextBox NameTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label10;
        private DataGridView MemberSDGV;
        private Button button4;
    }
}