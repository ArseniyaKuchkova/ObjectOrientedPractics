using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using OOP_1.Services;


namespace OOP_1.Model
{
    /// <summary>
    /// Класс для представления покупателя
    /// </summary>
    [DataContract]
     internal class Customer
     {
        private static int idCounter = 1;
        [DataMember]
        private readonly int _id;
        [DataMember]
        private string _fullname;
        [DataMember]
        private string _address;

        public Customer( string fullname, string address)
        {
            _id = idCounter++;
            Fullname = fullname;
            Address = address;
        }
        public Customer()
        {
            _id = idCounter++;
        }
        public int Id { get { return _id; } }
        public string Fullname 
        { get { return _fullname; } 
            set
            {
                if (value.Length <200)
                {
                    _fullname = value;
                }
                else
                {
                    throw new ArgumentException("Имя от 1 до 200 символов");
                }
            }
        
        }
       public string Address
       {
           get { return _address; }
           set
           {
                if (value.Length < 500)
                {
                    _address = value;
                }
                else
                {
                    throw new ArgumentException("Адрес о 1 до 500 символов");
                }
           }

       }
        public override string ToString()
        {
            return _fullname;
        }
     }
}
//public int Id => _id;
//public string Fullname => _fullname;
//public string Adress => _address;

//public Customer (string fullname, string address)
//    :this(IdGenerator.GetNextId(), fullname,address)
//{
//    if (string.IsNullOrEmpty(fullname) || fullname.Length > 200)
//        throw new ArgumentException("Имя от 1 до 200 символов");
//    if (string.IsNullOrEmpty(address) || address.Length > 500)
//        throw new ArgumentException("Адрес о 1 до 500 символов");
//}
// public static class IdGenerator
//{
//    private static int _nextId = 1;
//    public static int GetNextId =>_nextId++;
//}
