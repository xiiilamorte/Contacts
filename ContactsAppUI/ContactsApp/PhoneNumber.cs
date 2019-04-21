using System;

namespace ContactsApp
{   /// <summary>
    /// Класс для номеров телефона
    /// </summary>
    public class PhoneNumber
    {
        /// <summary>
        /// Поле номера телефона
        /// </summary>
        private long _phoneNumber;

        /// <summary>
        /// Свойство номера телефона
        /// </summary>
        public long Number
        {
            get => _phoneNumber;
            set
            {
                var str = value.ToString();
                if (str[0] != '7')
                {
                    throw new FormatException("Номер телефона должен начинаться с 7, а начинается с " + str[0]);
                }
                else if (value < 70000000000 || value > 79999999999)
                {
                    throw new ArgumentException("Длина номера телефона должна быть ровно 11 символов, а был " + str.Length);
                }
                _phoneNumber = value;
            }
        }
    }
}
