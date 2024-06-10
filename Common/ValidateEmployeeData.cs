using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common
{
    public class ValidateEmployeeData
    {
        public bool ValidateEmployee(string id, string name, string dateJoinedInput, string salaryCoefficientInput, out DateTime dateJoined, out double salaryCoefficient)
        {
            dateJoined = DateTime.MinValue;
            salaryCoefficient = 0;

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(dateJoinedInput) || string.IsNullOrWhiteSpace(salaryCoefficientInput))
            {
                return false;
            }

            if (!DateTime.TryParseExact(dateJoinedInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateJoined))
            {
                return false;
            }

            if (!double.TryParse(salaryCoefficientInput, out salaryCoefficient) || salaryCoefficient <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
