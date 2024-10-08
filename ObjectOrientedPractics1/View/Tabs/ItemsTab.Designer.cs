using System.Collections.Generic;
using ObjectOrientedPractics1.Model;

namespace ObjectOrientedPractics1.View.Tabs
{
    partial class ItemsTab
    {

        private System.ComponentModel.IContainer components = null;
        private List<Item> _items = new();

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            ItemsListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            button2 = new Button();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            NameTextBox = new RichTextBox();
            button1 = new Button();
            DescriptionTextBox = new RichTextBox();
            IdLabel = new Label();
            CostLabel = new Label();
            NameLabel = new Label();
            DescriptionLabel = new Label();
            SelecteditemLabel = new Label();
            ItemsLabel = new Label();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(4, 20);
            ItemsListBox.Margin = new Padding(4, 3, 4, 3);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(300, 604);
            ItemsListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(4, 631);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(98, 53);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(108, 631);
            RemoveButton.Margin = new Padding(4, 3, 4, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(98, 53);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(154, 646);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(9, 9);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(384, 33);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(185, 23);
            IdTextBox.TabIndex = 4;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(384, 67);
            CostTextBox.Margin = new Padding(4, 3, 4, 3);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(185, 23);
            CostTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(334, 138);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(518, 117);
            NameTextBox.TabIndex = 6;
            NameTextBox.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(688, 328);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(9, 9);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(334, 291);
            DescriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(518, 177);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.Text = "";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(330, 37);
            IdLabel.Margin = new Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 9;
            IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(330, 70);
            CostLabel.Margin = new Padding(4, 0, 4, 0);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 10;
            CostLabel.Text = "Cost:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(330, 120);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Name:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(330, 272);
            DescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 12;
            DescriptionLabel.Text = "Description:";
            // 
            // SelecteditemLabel
            // 
            SelecteditemLabel.AutoSize = true;
            SelecteditemLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelecteditemLabel.Location = new Point(330, 1);
            SelecteditemLabel.Margin = new Padding(4, 0, 4, 0);
            SelecteditemLabel.Name = "SelecteditemLabel";
            SelecteditemLabel.Size = new Size(85, 13);
            SelecteditemLabel.TabIndex = 13;
            SelecteditemLabel.Text = "Selected Item";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(4, 1);
            ItemsLabel.Margin = new Padding(4, 0, 4, 0);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(37, 13);
            ItemsLabel.TabIndex = 14;
            ItemsLabel.Text = "Items";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsLabel);
            Controls.Add(SelecteditemLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(NameLabel);
            Controls.Add(CostLabel);
            Controls.Add(IdLabel);
            Controls.Add(DescriptionTextBox);
            Controls.Add(button1);
            Controls.Add(NameTextBox);
            Controls.Add(CostTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(button2);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ItemsListBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ItemsTab";
            Size = new Size(891, 688);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.RichTextBox NameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label SelecteditemLabel;
        private System.Windows.Forms.Label ItemsLabel;
    }
}
