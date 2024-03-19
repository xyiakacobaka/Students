namespace WinFormsApp1
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
            LastNameLabel = new Label();
            LasrNameText = new TextBox();
            FirstNameLabel = new Label();
            FirstNameText = new TextBox();
            SecondNameLabel = new Label();
            SecondNameText = new TextBox();
            GroupLabel = new Label();
            Group = new TextBox();
            button_Add = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_Search = new Button();
            button_Delete = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(14, 29);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(95, 22);
            LastNameLabel.TabIndex = 0;
            LastNameLabel.Text = "Фамилия:";
            // 
            // LasrNameText
            // 
            LasrNameText.Location = new Point(114, 25);
            LasrNameText.Margin = new Padding(3, 2, 3, 2);
            LasrNameText.Name = "LasrNameText";
            LasrNameText.Size = new Size(118, 30);
            LasrNameText.TabIndex = 1;
            LasrNameText.TextChanged += LasrNameText_TextChanged;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(279, 29);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(52, 22);
            FirstNameLabel.TabIndex = 2;
            FirstNameLabel.Text = "Имя:";
            // 
            // FirstNameText
            // 
            FirstNameText.Location = new Point(334, 25);
            FirstNameText.Margin = new Padding(3, 2, 3, 2);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(118, 30);
            FirstNameText.TabIndex = 3;
            FirstNameText.TextChanged += FirstNameText_TextChanged;
            // 
            // SecondNameLabel
            // 
            SecondNameLabel.AutoSize = true;
            SecondNameLabel.Location = new Point(499, 29);
            SecondNameLabel.Name = "SecondNameLabel";
            SecondNameLabel.Size = new Size(95, 22);
            SecondNameLabel.TabIndex = 4;
            SecondNameLabel.Text = "Отчество:";
            // 
            // SecondNameText
            // 
            SecondNameText.Location = new Point(604, 25);
            SecondNameText.Margin = new Padding(3, 2, 3, 2);
            SecondNameText.Name = "SecondNameText";
            SecondNameText.Size = new Size(118, 30);
            SecondNameText.TabIndex = 5;
            SecondNameText.TextChanged += SecondNameText_TextChanged;
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Location = new Point(763, 29);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(77, 22);
            GroupLabel.TabIndex = 6;
            GroupLabel.Text = "Группа:";
            // 
            // Group
            // 
            Group.Location = new Point(842, 25);
            Group.Margin = new Padding(3, 2, 3, 2);
            Group.Name = "Group";
            Group.Size = new Size(118, 30);
            Group.TabIndex = 7;
            Group.TextChanged += Group_TextChanged;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(1003, 22);
            button_Add.Margin = new Padding(3, 2, 3, 2);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(112, 37);
            button_Add.TabIndex = 8;
            button_Add.Text = "Добавить";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 105);
            label1.Name = "label1";
            label1.Size = new Size(116, 22);
            label1.TabIndex = 9;
            label1.Text = "ПИ - 221 = 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 142);
            label2.Name = "label2";
            label2.Size = new Size(116, 22);
            label2.TabIndex = 10;
            label2.Text = "ПИ - 222 = 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1001, 105);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 11;
            label3.Text = "ИТ - 221 = 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1001, 142);
            label4.Name = "label4";
            label4.Size = new Size(114, 22);
            label4.TabIndex = 12;
            label4.Text = "ИТ - 222 = 4";
            // 
            // button_Search
            // 
            button_Search.Location = new Point(156, 227);
            button_Search.Margin = new Padding(3, 2, 3, 2);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(166, 78);
            button_Search.TabIndex = 13;
            button_Search.Text = "Поиск";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(732, 227);
            button_Delete.Margin = new Padding(3, 2, 3, 2);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(166, 78);
            button_Delete.TabIndex = 14;
            button_Delete.Text = "Удалить";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1085, 225);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(604, 186);
            label5.Name = "label5";
            label5.Size = new Size(290, 22);
            label5.TabIndex = 16;
            label5.Text = "Группа, которую нужно удалить:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F);
            textBox1.Location = new Point(900, 179);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 35);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 186);
            label6.Name = "label6";
            label6.Size = new Size(275, 22);
            label6.TabIndex = 18;
            label6.Text = "Фамилия человека для поиска:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F);
            textBox2.Location = new Point(304, 179);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 35);
            textBox2.TabIndex = 19;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 559);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button_Delete);
            Controls.Add(button_Search);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Add);
            Controls.Add(Group);
            Controls.Add(GroupLabel);
            Controls.Add(SecondNameText);
            Controls.Add(SecondNameLabel);
            Controls.Add(FirstNameText);
            Controls.Add(FirstNameLabel);
            Controls.Add(LasrNameText);
            Controls.Add(LastNameLabel);
            Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LastNameLabel;
        private TextBox LasrNameText;
        private Label FirstNameLabel;
        private TextBox FirstNameText;
        private Label SecondNameLabel;
        private TextBox SecondNameText;
        private Label GroupLabel;
        private TextBox Group;
        private Button button_Add;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_Search;
        private Button button_Delete;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
    }
}
