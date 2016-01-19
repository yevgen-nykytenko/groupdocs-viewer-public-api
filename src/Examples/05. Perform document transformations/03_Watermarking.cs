
using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Converter.Options;
using GroupDocs.Viewer.Domain;
using GroupDocs.Viewer.Domain.Html;
using GroupDocs.Viewer.Domain.Image;
using GroupDocs.Viewer.Handler;
using System;
using System.Collections.Generic;

namespace Examples
{
    public static class _05_03_Watermarking
    {
        public static void Add_Watermark_For_Image()
        {
            Console.WriteLine("***** {0} *****", "Add Watermark to Image page representation");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";

            ImageOptions options = new ImageOptions();

            // Set watermark properties
            Watermark watermark = new Watermark("This is watermark text");
            watermark.Color = System.Drawing.Color.Blue;
            watermark.Position = WatermarkPosition.Diagonal;
            watermark.Width = 100;

            options.Watermark = watermark;

            // Get document pages image representation with watermark
            List<PageImage> pages = imageHandler.GetPages(guid, options);
        }

        /// <summary>
        /// Add Watermark to Html page representation
        /// </summary>
        public static void Add_Watermark_For_Html()
        {
            Console.WriteLine("***** {0} *****", "Add Watermark to Html page representation");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);
            string guid = "word.doc";

            HtmlOptions options = new HtmlOptions();

            // Set watermark properties
            Watermark watermark = new Watermark("This is watermark text");
            watermark.Color = System.Drawing.Color.Blue;
            watermark.Position = WatermarkPosition.Diagonal;
            watermark.Width = 100;

            options.Watermark = watermark;

            // Get document pages html representation with watermark
            List<PageHtml> pages = htmlHandler.GetPages(guid, options);
        }

    }
}
