using ObjectOrientedPractics1.Services;

namespace ObjectOrientedPractics1.Model
{
    public class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        private static int _idCounter = 0;

        public int Id => _id;
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        public Customer(string fullname,
                        string address)
        {
            _id = ++_idCounter;
            Fullname = fullname;
            Address = address;
        }
    }
}