using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_1.Services;

namespace OOP_1.Model
{
    /// <summary>
    /// Class for product
    /// </summary>
    [DataContract]
    internal class Item
    {
        private static long idCounter = 0;
        // unique product number
        [DataMember]
        private readonly long _id;
        // product name
        [DataMember]
        private string _name;
        // product information
        [DataMember]
        private string _info;
        // product price
        [DataMember]
        private double _cost;

        /// <summary>
        /// Конструктор для внутреннего использования
        /// </summary>
        public Item(string name, double cost, string info)
        {
            Name = name;
            Cost = cost;
            Info = info;
            _id = idCounter++;
        }
        public Item()
        {
            _id = idCounter++;
        }
        public long Id { get { return _id; } }
        public string Name
        {
            get { return _name; }
            set
            {

                if (ValueValidator.AssertStringOnLength(value, 200, "Name"))
                {
                    _name = value;
                }
            }

        }

        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value >= 0 && value <= 100000)
                {
                    _cost = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Info
        {
            get { return _info; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 1000, "Info"))
                {
                    _info = value;
                }
            }
        }

        public override string? ToString()
        {
            return Name;
        }
    }

}

        

//        /// <summary>
//        /// Основной конструктор
//        /// </summary>
//        public Item(string name, string info, decimal cost)
//            : this(Services.IdGenerator.GetNextId(), name, info, cost)
//        {
//        }

//        /// <summary>
//        /// Уникальный идентификатор товара
//        /// </summary>
//        public int Id => _id;

//        public string Name
//        {
//            get => _name;
//            private set
//            {
//                Services.ValueValidator.AssertStringOnLength(value, MaxNameLength, nameof(Name));
//                _name = value;
//            }
//        }
//        /// <summary>
//        /// Описание товара
//        /// </summary>
//        public string Info
//        {
//            get => _info;
//            private set
//            {
//                Services.ValueValidator.AssertStringOnLength(value, MaxInfoLength, nameof(Info));
//                _info = value;
//            }
//        }
//        public decimal Cost
//        {
//            get => _cost;
//            private set
//            {
//                if (value < MinCost || value > MaxCost)
//                    throw new ArgumentOutOfRangeException(nameof(Cost),
//                        $"Стоимость должна быть от {MinCost} до {MaxCost}");
//                _cost = value;
//            }
//        }

//    }
//}

//public int Id => _id;
//public string Name => _name;
//public string Info => _info;
//public decimal Cost => _cost;

//{
//    if (string.IsNullOrEmpty(name) || name.Length > 200)

//        throw new ArgumentException
//            ("Название должно быть от 1 до 200 символов ");

//    if (info.Length > 1000)

//        throw new ArgumentException
//            ("Описание не больше 1000 символов");

//    if (cost < 0 || cost > 100000)

//        throw new ArgumentException
//            ("Стоимость от 0 до 100 000");

//}
//public static class IdGenerator
//{
//    private static int _nextId = 1;
//    public static int GetNextId =>_nextId++;
//}