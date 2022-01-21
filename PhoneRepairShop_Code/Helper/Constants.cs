using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneRepairShop.Helper
{
    class Constants
    {
        public static class RepairComplexity
        {
            public const string Low = "L";
            public const string Medium = "M";
            public const string High = "H";
        }

        public static class RepairItemTypeConstants 
        {
            public const string Battery = "BT";
            public const string Screen  = "SR";
            public const string ScreenCover = "SC";
            public const string BackCover = "BC";
            public const string Motherboard = "MB";
            
        }
        
    }
}
