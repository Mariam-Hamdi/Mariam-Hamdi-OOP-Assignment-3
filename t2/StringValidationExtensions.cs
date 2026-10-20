using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_ass_oop3.t2
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;
            string pattern = @"^(?:\+20|0)?1[0125][0-9]{8}$";
            return System.Text.RegularExpressions.Regex.IsMatch(phone, pattern);
        }
        public static bool IsValidEgyptianNationalId(this string nationalId)
        {
            if (string.IsNullOrEmpty(nationalId))
                return false;
            string pattern = @"^\d{14}$";
            return System.Text.RegularExpressions.Regex.IsMatch(nationalId, pattern);
        }
    }
}
