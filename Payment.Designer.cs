namespace GymManagement
{
    partial class Payment
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
            label2 = new Label();
            label1 = new Label();
            AmountTb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            payMonthDTP = new DateTimePicker();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            PaymentSDGV = new DataGridView();
            label6 = new Label();
            NameCb = new ComboBox();
            button1 = new Button();
            button5 = new Button();
            SearchName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PaymentSDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(551, 105);
            label2.Name = "label2";
            label2.Size = new Size(226, 47);
            label2.TabIndex = 3;
            label2.Text = "Payments";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(506, 54);
            label1.Name = "label1";
            label1.Size = new Size(322, 51);
            label1.TabIndex = 2;
            label1.Text = "Fitness Centre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AmountTb
            // 
            AmountTb.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountTb.Location = new Point(99, 382);
            AmountTb.Name = "AmountTb";
            AmountTb.PlaceholderText = "Enter Your Number";
            AmountTb.Size = new Size(215, 29);
            AmountTb.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 357);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 28;
            label5.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 284);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 26;
            label4.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(99, 206);
            label3.Name = "label3";
            label3.Size = new Size(149, 25);
            label3.TabIndex = 30;
            label3.Text = "Payment Month";
            // 
            // payMonthDTP
            // 
            payMonthDTP.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payMonthDTP.Location = new Point(99, 240);
            payMonthDTP.Name = "payMonthDTP";
            payMonthDTP.Size = new Size(215, 27);
            payMonthDTP.TabIndex = 31;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(230, 452);
            button3.Name = "button3";
            button3.Size = new Size(131, 48);
            button3.TabIndex = 37;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(60, 453);
            button2.Name = "button2";
            button2.Size = new Size(131, 48);
            button2.TabIndex = 36;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(146, 551);
            button4.Name = "button4";
            button4.Size = new Size(131, 48);
            button4.TabIndex = 40;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // PaymentSDGV
            // 
            PaymentSDGV.AllowUserToAddRows = false;
            PaymentSDGV.AllowUserToDeleteRows = false;
            PaymentSDGV.AllowUserToResizeColumns = false;
            PaymentSDGV.AllowUserToResizeRows = false;
            PaymentSDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PaymentSDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            PaymentSDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            PaymentSDGV.BackgroundColor = SystemColors.ControlLightLight;
            PaymentSDGV.BorderStyle = BorderStyle.None;
            PaymentSDGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Brown;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            PaymentSDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            PaymentSDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PaymentSDGV.DefaultCellStyle = dataGridViewCellStyle2;
            PaymentSDGV.EditMode = DataGridViewEditMode.EditProgrammatically;
            PaymentSDGV.GridColor = SystemColors.ControlLightLight;
            PaymentSDGV.Location = new Point(601, 336);
            PaymentSDGV.Margin = new Padding(10);
            PaymentSDGV.Name = "PaymentSDGV";
            PaymentSDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            PaymentSDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            PaymentSDGV.RowHeadersVisible = false;
            PaymentSDGV.RowHeadersWidth = 5;
            PaymentSDGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.SelectionBackColor = Color.Chocolate;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            PaymentSDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            PaymentSDGV.RowTemplate.Height = 25;
            PaymentSDGV.RowTemplate.ReadOnly = true;
            PaymentSDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PaymentSDGV.ShowCellErrors = false;
            PaymentSDGV.ShowCellToolTips = false;
            PaymentSDGV.ShowEditingIcon = false;
            PaymentSDGV.Size = new Size(400, 400);
            PaymentSDGV.TabIndex = 46;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(1321, 9);
            label6.Name = "label6";
            label6.Size = new Size(44, 50);
            label6.TabIndex = 47;
            label6.Text = "X";
            label6.TextAlign = ContentAlignment.TopRight;
            label6.Click += label6_Click;
            // 
            // NameCb
            // 
            NameCb.FormattingEnabled = true;
            NameCb.Items.AddRange(new object[] { "6AM - 8AM", "8AM - 10AM", "6PM - 8PM", "8PM - 10PM" });
            NameCb.Location = new Point(99, 312);
            NameCb.Name = "NameCb";
            NameCb.Size = new Size(215, 28);
            NameCb.TabIndex = 48;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(944, 261);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 51;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(807, 261);
            button5.Name = "button5";
            button5.Size = new Size(131, 38);
            button5.TabIndex = 50;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // SearchName
            // 
            SearchName.Location = new Point(633, 267);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(168, 27);
            SearchName.TabIndex = 49;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 762);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(SearchName);
            Controls.Add(NameCb);
            Controls.Add(label6);
            Controls.Add(PaymentSDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(payMonthDTP);
            Controls.Add(label3);
            Controls.Add(AmountTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)PaymentSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox AmountTb;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker payMonthDTP;
        private Button button3;
        private Button button2;
        private Button button4;
        private DataGridView PaymentSDGV;
        private Label label6;
        private ComboBox NameCb;
        private Button button1;
        private Button button5;
        private TextBox SearchName;
    }
}