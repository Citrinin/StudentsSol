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
            var passValidation = value != null && value.ToString() != "";
            return new ValidationResult(passValidation, passValidation ? null : "enter at least 1 char");
        }
    }
}
