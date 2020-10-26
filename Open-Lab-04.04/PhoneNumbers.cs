using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            
            string space = "";
            string formatedNumbers = "";
            foreach (int number in numbers)
            {
                formatedNumbers += string.Join(space, number);
                space = ", ";
            }
            return Convert.ToInt64(formatedNumbers).ToString("(0##) ###-####");
        }
    }
}
