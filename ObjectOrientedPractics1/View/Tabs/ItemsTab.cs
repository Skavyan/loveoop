using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics1.Model;

namespace ObjectOrientedPractics1.View.Tabs
{
    public partial class ItemsTab : UserControl
    {

        public ItemsTab()
        {
            InitializeComponent();
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearValidation(); // Сброс цвета перед валидацией

            try
            {
                // Валидация
                string name = NameTextBox.Text;
                string description = DescriptionTextBox.Text;

                if (string.IsNullOrWhiteSpace(name) || name.Length > 200)
                {
                    ShowValidationError(NameTextBox, "Name must be between 1 and 200 characters.");
                    return;
                }

                if (description.Length > 1000)
                {
                    ShowValidationError(DescriptionTextBox, "Description cannot exceed 1000 characters.");
                    return;
                }

                if (!decimal.TryParse(CostTextBox.Text, out decimal cost) || cost < 0 || cost > 100000)
                {
                    ShowValidationError(CostTextBox, "Cost must be a number between 0 and 100000.");
                    return;
                }

                // Создание нового товара и добавление его в список
                Item newItem = new(name, description, cost);
                _items.Add(newItem);

                // Добавление в ListBox
                ItemsListBox.Items.Add(newItem);
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                // Удаление выбранного элемента из ListBox и списка _items
                int selectedIndex = ItemsListBox.SelectedIndex;
                _items.RemoveAt(selectedIndex);
                ItemsListBox.Items.RemoveAt(selectedIndex);

                ClearTextFields(); // Очищаем текстовые поля
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error");
            }
        }

        // Метод для выбора элемента из списка
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is Item selectedItem)
            {
                // Заполнение текстовых полей данными выбранного товара
                IdTextBox.Text = selectedItem.Id.ToString();
                NameTextBox.Text = selectedItem.Name;
                CostTextBox.Text = selectedItem.Cost.ToString();
                DescriptionTextBox.Text = selectedItem.Info;
            }
        }

        // Метод для очистки полей после добавления или удаления товара
        private void ClearTextFields()
        {
            IdTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Метод для отображения ошибки валидации, делает TextBox красным.
        /// </summary>
        /// <param name="textBox">Поле с ошибкой.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        private void ShowValidationError(Control control, string errorMessage)
        {
            control.BackColor = Color.Red; // Изменение цвета фона
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Метод для очистки выделения ошибок в TextBox-ах.
        /// </summary>
        private void ClearValidation()
        {
            NameTextBox.BackColor = SystemColors.Window;
            DescriptionTextBox.BackColor = SystemColors.Window;
            CostTextBox.BackColor = SystemColors.Window;
        }
    }
}
