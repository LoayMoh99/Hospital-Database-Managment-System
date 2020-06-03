using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Database
{
    class ValidationFunctions
    {
        public static Object isPositiveInteger(String input, StringBuilder err)
        {
            Object returnData = null;
            try
            {
                int x = Convert.ToInt32(input);
                if (x < 0)
                {
                    err.Append("Input " + input + " is a negative number");
                }
                else
                {
                    returnData = x;
                }
            }
            catch
            {
                err.Append("Input " + input + " is not a valid integer");
            }
            return returnData;
        }

        public bool Validate_Number(string Number)
        {
            if (Number.Length == 0)
                return false;
            foreach (char C in Number)
                if (C < '0' || C > '9')
                    return false;
            return true;
        }

        public bool Validate_Date(string date)
        {
            date.Trim();
            if (date.Length != 10)
                return false;
            if (date[4].ToString() != "-" || date[7].ToString() != "-")
                return false;
            string Y = date[0].ToString() + date[1].ToString() + date[2].ToString() + date[3].ToString();
            string M = date[5].ToString() + date[6].ToString();
            string D = date[8].ToString() + date[9].ToString();
            if (!Validate_Number(Y))
                return false;
            if (!Validate_Number(M))
                return false;
            if (!Validate_Number(D))
                return false;
            return true;
        }
    }
}
