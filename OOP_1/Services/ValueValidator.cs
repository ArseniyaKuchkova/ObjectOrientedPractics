using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1.Services
{
    internal class ValueValidator
    {
        public static bool AssertStringOnLength (string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(propertyName + " должен быть меньше"
                    + maxLength + " символов");
            }
            else
            {
                return true;
            }
        }
    }
}
