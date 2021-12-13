using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layers.Bussiness
{
    public class ValidationHelpers
    {
        public static string VerifyStringNull(string str) 
        {
            if (str.Trim() == "")
                return null;
            return str;
        }
    }
}
