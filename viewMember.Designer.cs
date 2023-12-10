namespace GymManagement
{
    partial class viewMember
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SearchName = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            MemberSDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1368, 11);
            label3.Name = "label3";
            label3.Size = new Size(91, 81);
            label3.TabIndex = 5;
            label3.Text = "X";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(588, 89);
            label2.Name = "label2";
            label2.Size = new Size(226, 47);
            label2.TabIndex = 4;
            label2.Text = "Member List";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(545, 28);
            label1.Name = "label1";
            label1.Size = new Size(322, 51);
            label1.TabIndex = 3;
            label1.Text = "Fitness Centre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchName
            // 
            SearchName.Location = new Point(478, 181);
            SearchName.Name = "SearchName";
            SearchName.Size = new Size(160, 27);
            SearchName.TabIndex = 39;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(644, 175);
            button2.Name = "button2";
            button2.Size = new Size(131, 38);
            button2.TabIndex = 40;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(781, 175);
            button1.Name = "button1";
            button1.Size = new Size(131, 38);
            button1.TabIndex = 41;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(683, 664);
            button3.Name = "button3";
            button3.Size = new Size(131, 48);
            button3.TabIndex = 42;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            MemberSDGV.Location = new Point(282, 242);
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
            MemberSDGV.Size = new Size(863, 400);
            MemberSDGV.TabIndex = 46;
            // 
            // viewMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 762);
            Controls.Add(MemberSDGV);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(SearchName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "viewMember";
            Text = "viewMember";
            Load += viewMember_Load;
            ((System.ComponentModel.ISupportInitialize)MemberSDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox SearchName;
        private Button button2;
        private Button button1;
        private Button button3;
        private DataGridView MemberSDGV;
    }
}