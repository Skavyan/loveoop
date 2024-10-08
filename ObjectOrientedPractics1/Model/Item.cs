using ObjectOrientedPractics1.Services;
using System;

namespace ObjectOrientedPractics1.Model
{
    /// Представляет товар.
    public class Item
    {
        private static int _idCounter = 1;

        // Закрытые поля
        private readonly int _id;
        private string _name;
        private string _info;
        private decimal _cost;

        /// Уникальный идентификатор товара.
        public int Id => _id;

        /// Название товара.
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        /// Описание товара.
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }
        /// Стоимость товара.
        public decimal Cost
        {
            get => _cost;
            set
            {
                if (value < 0 || value > 100000)
                    throw new ArgumentOutOfRangeException(nameof(Cost), "Cost must be between 0 and 100000.");
                _cost = value;
            }
        }
        /// Конструктор для создания нового товара.
        public Item(string name, string info, decimal cost)
        {
            _id = _idCounter++;
            Name = name;  // Используем свойства, чтобы применить валидацию
            Info = info;
            Cost = cost;
        }
        /// Переопределяем метод ToString для отображения названия товара в списке.
        public override string ToString()
        {
            return Name;
        }
    }
}
