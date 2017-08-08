using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace StudentsMain.ValidationRules
{
    class AgeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int age;
            if (!int.TryParse(value.ToString(),out age))
            {
                return new ValidationResult(false, "Age must be an integer");
            }
            else if (age < 16 || age > 100)
            {
                return new ValidationResult(false, "Age must be between 16 and 100");
            }
            return new ValidationResult(true, null);
        }
    }

}
