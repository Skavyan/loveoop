using ObjectOrientedPractics1.Services;
using System;

namespace ObjectOrientedPractics1.Model
{
    /// <summary>
    /// Представляет товар.
    /// </summary>
    public class Item
    {
        private static int _idCounter = 1;

        // Закрытые поля
        private readonly int _id;
        private string _name;
        private string _info;
        private decimal _cost;

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Описание товара.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Стоимость товара.
        /// </summary>
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

        /// <summary>
        /// Конструктор для создания нового товара.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="info">Описание товара.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, decimal cost)
        {
            _id = _idCounter++;
            Name = name;  // Используем свойства, чтобы применить валидацию
            Info = info;
            Cost = cost;
        }

        /// <summary>
        /// Переопределяем метод ToString для отображения названия товара в списке.
        /// </summary>
        public override string ToString()
        {
            return Name;
        }
    }
}
