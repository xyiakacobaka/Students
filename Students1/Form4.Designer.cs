namespace WinFormsApp1
{
    partial class Form4
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
            del_group = new Label();
            DelGroupName = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // del_group
            // 
            del_group.AutoSize = true;
            del_group.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            del_group.Location = new Point(212, 43);
            del_group.Name = "del_group";
            del_group.Size = new Size(374, 41);
            del_group.TabIndex = 0;
            del_group.Text = "Какую группу удалить?";
            // 
            // DelGroupName
            // 
            DelGroupName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DelGroupName.Location = new Point(212, 97);
            DelGroupName.Margin = new Padding(3, 2, 3, 2);
            DelGroupName.Name = "DelGroupName";
            DelGroupName.Size = new Size(374, 35);
            DelGroupName.TabIndex = 1;
            DelGroupName.TextAlign = HorizontalAlignment.Center;
            DelGroupName.TextChanged += DelGroupName_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(316, 153);
            button1.Name = "button1";
            button1.Size = new Size(160, 54);
            button1.TabIndex = 2;
            button1.Text = "Подтвердить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 236);
            Controls.Add(button1);
            Controls.Add(DelGroupName);
            Controls.Add(del_group);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form4";
            Text = "Диалоговое окно";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label del_group;
        private TextBox DelGroupName;
        private Button button1;
    }
}