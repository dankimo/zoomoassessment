using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomoAssessment
{
    public static class Question1
    {
        public static bool isNullorEmpty(string input)
        {
            if (input == null)
            {
                return true;
            }

            if (input.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
