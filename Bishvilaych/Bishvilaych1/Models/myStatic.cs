using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bishvilaych1.Models
{
    public static class myStatic
    {
        public static bool IsValidId(string value)
        {
            if (value.GetType() == typeof(string))
            {
                int tz = Convert.ToInt32(value);
                int flag = 0;
                if (tz == 0)
                    flag = 1;
                int[] id = new int[9];
                int[] temp = new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
                int sum = 0;
                for (int i = 8; i >= 0; i--)// שם את התעודת זהות במערך
                {
                    id[i] = tz % 10;
                    tz /= 10;
                }
                for (int i = 0; i < 9; i++)
                {
                    temp[i] = temp[i] * id[i];
                    if (temp[i] > 9)// אם המכפלה גדולה מ - 10 
                        temp[i] = temp[i] % 10 + temp[i] / 10 % 10;
                }
                for (int i = 0; i < 9; i++)
                {
                    sum += temp[i];
                }
                if (sum % 10 == 0 && flag == 0)
                    return true;
                else
                    if (sum % 10 != 0)
                    return false;
            }
            return false;
        }
    }
}