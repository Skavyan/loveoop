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
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(4, 16);
            ItemsListBox.Margin = new Padding(4, 3, 4, 3);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(269, 514);
            ItemsListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(4, 536);
            AddButton.Margin = new Padding(4, 3, 4, 3);
            AddButton.MaximumSize = new Size(115, 68);
            AddButton.MinimumSize = new Size(115, 68);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(115, 68);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(155, 536);
            RemoveButton.Margin = new Padding(4, 3, 4, 3);
            RemoveButton.MaximumSize = new Size(115, 68);
            RemoveButton.MinimumSize = new Size(115, 68);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(115, 68);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(62, 30);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(65, 23);
            IdTextBox.TabIndex = 4;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(62, 79);
            CostTextBox.Margin = new Padding(4, 3, 4, 3);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(173, 23);
            CostTextBox.TabIndex = 5;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(62, 158);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(326, 117);
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
            DescriptionTextBox.Location = new Point(62, 367);
            DescriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(394, 163);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.Text = "";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(19, 33);
            IdLabel.Margin = new Padding(4, 0, 4, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 9;
            IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(19, 82);
            CostLabel.Margin = new Padding(4, 0, 4, 0);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 10;
            CostLabel.Text = "Cost:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(19, 140);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 11;
            NameLabel.Text = "Name:";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(19, 338);
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
            SelecteditemLabel.Location = new Point(4, 0);
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
            ItemsLabel.Location = new Point(4, 0);
            ItemsLabel.Margin = new Padding(4, 0, 4, 0);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(37, 13);
            ItemsLabel.TabIndex = 14;
            ItemsLabel.Text = "Items";
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.ForeColor = SystemColors.ControlText;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ItemsLabel);
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(RemoveButton);
            splitContainer1.Panel1.Controls.Add(AddButton);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DescriptionTextBox);
            splitContainer1.Panel2.Controls.Add(DescriptionLabel);
            splitContainer1.Panel2.Controls.Add(SelecteditemLabel);
            splitContainer1.Panel2.Controls.Add(CostTextBox);
            splitContainer1.Panel2.Controls.Add(IdLabel);
            splitContainer1.Panel2.Controls.Add(CostLabel);
            splitContainer1.Panel2.Controls.Add(NameLabel);
            splitContainer1.Panel2.Controls.Add(IdTextBox);
            splitContainer1.Panel2.Controls.Add(NameTextBox);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(833, 607);
            splitContainer1.SplitterDistance = 277;
            splitContainer1.TabIndex = 15;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ItemsTab";
            Size = new Size(839, 613);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
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
        private SplitContainer splitContainer1;
    }
}
