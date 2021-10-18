using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCheckerBase
{
    internal class HelpingClass
    {
        public static List<string> list0;
        public static List<string> list1;

        public static int int0;
        public static int int1;

        static HelpingClass()
        {
            list0 = new List<string>();
            list1 = new List<string>();

            int0 = 0;
            int1 = 0;
        }
    }
}
