using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using System;

namespace Examples
{
    public static class _06_06_Get_printable_html
    {
        /// <summary>
        /// Get document html for print
        /// </summary>
        public static void Get_PrintableHtml()
        {
            Console.WriteLine("***** {0} *****", "Get document html for print");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";

            // Get document html for print
            var options = new PrintableHtmlOptions(guid);
            var container = imageHandler.GetPrintableHtml(options);

            Console.WriteLine("Html content: {0}", container.HtmlContent);
        }

        /// <summary>
        /// Get document html for print with watermark
        /// </summary>
        public static void Get_PrintableHtml_WithWatermark()
        {
            Console.WriteLine("***** {0} *****", "Get document html for print with watermark");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";

            // Get document html for print with watermark
            var options = new PrintableHtmlOptions(guid, new Watermark("Watermark text"));
            var container = imageHandler.GetPrintableHtml(options);

            Console.WriteLine("Html content: {0}", container.HtmlContent);
        }

        /// <summary>
        /// Get document html for print with custom css
        /// </summary>
        public static void Get_PrintableHtml_WithCss()
        {
            Console.WriteLine("***** {0} *****", "Get document html for print with custom css");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";
            string css = "a { color: hotpink; }"; // Some style

            // Get document html for print with custom css
            var options = new PrintableHtmlOptions(guid, css);
            var container = imageHandler.GetPrintableHtml(options);

            Console.WriteLine("Html content: {0}", container.HtmlContent);
        }
    }
}
