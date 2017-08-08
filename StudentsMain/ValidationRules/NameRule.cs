using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StudentsMain.ValidationRules
{
    class NameRule:ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            if (value!=null)
            {
                string s = value.ToString();
                if (s == "")
                {
                    return new ValidationResult(false, "enter at least 1 char");
                } 
            }
            else
            {
                return new ValidationResult(false, "enter at least 1 char");
            }
            return new ValidationResult(true, null);
        }
    }
}
