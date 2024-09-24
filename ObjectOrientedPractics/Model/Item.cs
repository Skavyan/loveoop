using ObjectOrientedPractics.Services;
using System;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        private static int _idCounter = 0;

        public int Id => _id;
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Стоимость должна быть в диапазоне от 0 до 100 000.");
                }
                _cost = value;
            }
        }

        public Item(string name, string info, double cost)
        {
            _id = ++_idCounter;
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}