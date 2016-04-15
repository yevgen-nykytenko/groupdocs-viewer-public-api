using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Handler;

namespace Examples._06._Other_operations
{
    public static class _11_How_to_create_and_use_file_with_localized_strings
    {
        public static void Run()
        {
            // Setup viewer config
            ViewerConfig viewerConfig = new ViewerConfig();
            viewerConfig.StoragePath = @"c:\\storage";
            viewerConfig.LocalesPath = @"c:\\locales";

            // Create html handler
            CultureInfo cultureInfo = new CultureInfo("fr-FR");
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(viewerConfig, cultureInfo); 
        }
    }
}
