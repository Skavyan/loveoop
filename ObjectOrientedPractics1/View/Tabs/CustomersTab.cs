using ObjectOrientedPractics1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics1.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        // Список клиентов
        private List<Customer> _customers = new List<Customer>();

        public CustomersTab()
        {
            InitializeComponent();

            // Привязываем события
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            AddButton.Click += AddButton_Click;
            RemoveButton.Click += RemoveButton_Click;
        }

        // Метод для добавления нового клиента
        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearValidation(); // Очищаем возможные ошибки валидации

            try
            {
                string fullName = NameTextBox.Text;
                string address = AddresTextBox.Text;

                // Проверка корректности имени и адреса
                if (string.IsNullOrWhiteSpace(fullName) || fullName.Length > 200)
                {
                    ShowValidationError(NameTextBox, "Full Name must be between 1 and 200 characters.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(address) || address.Length > 500)
                {
                    ShowValidationError(AddresTextBox, "Address cannot exceed 500 characters.");
                    return;
                }

                // Создаем нового клиента
                Customer newCustomer = new Customer(fullName, address);
                _customers.Add(newCustomer);

                // Обновляем ListBox
                CustomersListBox.Items.Add(newCustomer.Fullname);
                ClearTextFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        // Метод для удаления клиента
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);

                ClearTextFields(); // Очищаем поля после удаления
            }
            else
            {
                MessageBox.Show("Please select a customer to remove.", "Error");
            }
        }

        // Метод для отображения выбранного клиента
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                Customer selectedCustomer = _customers[selectedIndex];

                IdTextBox.Text = selectedCustomer.Id.ToString();
                NameTextBox.Text = selectedCustomer.Fullname;
                AddresTextBox.Text = selectedCustomer.Address;
            }
        }

        // Метод для очистки текстовых полей
        private void ClearTextFields()
        {
            IdTextBox.Text = string.Empty;
            NameTextBox.Text = string.Empty;
            AddresTextBox.Text = string.Empty;
        }

        // Метод для отображения ошибки валидации
        private void ShowValidationError(Control control, string errorMessage)
        {
            control.BackColor = Color.Red;
            MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Метод для очистки ошибок валидации
        private void ClearValidation()
        {
            NameTextBox.BackColor = SystemColors.Window;
            AddresTextBox.BackColor = SystemColors.Window;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}