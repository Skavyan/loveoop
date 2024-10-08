namespace ObjectOrientedPractics1.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            CustomersListBox = new ListBox();
            SelectedCustomers = new ListBox();
            Panel2 = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            IdLabel = new Label();
            NameLabel = new Label();
            AddresLabel = new Label();
            label4 = new Label();
            IdTextBox = new TextBox();
            NameTextBox = new TextBox();
            AddresTextBox = new TextBox();
            SuspendLayout();
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(3, 18);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(288, 424);
            CustomersListBox.TabIndex = 0;
            // 
            // SelectedCustomers
            // 
            SelectedCustomers.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomers.FormattingEnabled = true;
            SelectedCustomers.ItemHeight = 15;
            SelectedCustomers.Location = new Point(297, 3);
            SelectedCustomers.Name = "SelectedCustomers";
            SelectedCustomers.Size = new Size(505, 199);
            SelectedCustomers.TabIndex = 1;
            // 
            // Panel2
            // 
            Panel2.FormattingEnabled = true;
            Panel2.ItemHeight = 15;
            Panel2.Location = new Point(297, 208);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(505, 289);
            Panel2.TabIndex = 2;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 448);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(91, 49);
            AddButton.TabIndex = 3;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(100, 448);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(98, 49);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(317, 37);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 5;
            IdLabel.Text = "ID:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(317, 67);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(64, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Full Name:";
            NameLabel.Click += NameLabel_Click;
            // 
            // AddresLabel
            // 
            AddresLabel.AutoSize = true;
            AddresLabel.Location = new Point(317, 103);
            AddresLabel.Name = "AddresLabel";
            AddresLabel.Size = new Size(47, 15);
            AddresLabel.TabIndex = 7;
            AddresLabel.Text = "Addres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 8;
            label4.Text = "Customers";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(401, 34);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(401, 63);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(381, 23);
            NameTextBox.TabIndex = 10;
            // 
            // AddresTextBox
            // 
            AddresTextBox.Location = new Point(401, 100);
            AddresTextBox.Multiline = true;
            AddresTextBox.Name = "AddresTextBox";
            AddresTextBox.Size = new Size(381, 85);
            AddresTextBox.TabIndex = 11;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddresTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label4);
            Controls.Add(AddresLabel);
            Controls.Add(NameLabel);
            Controls.Add(IdLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(Panel2);
            Controls.Add(SelectedCustomers);
            Controls.Add(CustomersListBox);
            Name = "CustomersTab";
            Size = new Size(805, 504);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CustomersListBox;
        private ListBox SelectedCustomers;
        private ListBox Panel2;
        private Button AddButton;
        private Button RemoveButton;
        private Label IdLabel;
        private Label NameLabel;
        private Label AddresLabel;
        private Label label4;
        private TextBox IdTextBox;
        private TextBox NameTextBox;
        private TextBox AddresTextBox;
    }
}
