using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinViewer
{
    public class AppSettings
    {
        public string SettingsSubKey { get; set; } = default!;
        public int MaxRecentlyUsedFiles { get; set; } = 5;
    }
}
