using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public static class CharExtensionMethods
    {
        private const string allowedAlphaInHex = "abcdefABCDEF";

        public static bool IsHexadecimal(this char ch)
        {
            if (char.IsDigit(ch))
                return true;

            return allowedAlphaInHex.Contains(ch);
        }
    }
}
