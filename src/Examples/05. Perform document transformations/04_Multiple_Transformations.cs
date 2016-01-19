using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Converter.Options;
using GroupDocs.Viewer.Domain;
using GroupDocs.Viewer.Domain.Html;
using GroupDocs.Viewer.Domain.Image;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using System;
using System.Collections.Generic;

namespace Examples
{
    public static class _05_04_Multiple_Transformations
    {
        /// <summary>
        /// Perform multiple transformations in Image mode
        /// </summary>
        public static void Multiple_Transformations_For_Image()
        {
            Console.WriteLine("***** {0} *****", "Perform multiple transformations in Image mode");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";

            // Rotate first page 90 degrees
            imageHandler.RotatePage(new RotatePageOptions(guid, 1, 90));

            // Rotate second page 180 degrees
            imageHandler.RotatePage(new RotatePageOptions(guid, 2, 180));

            // Reorder first and second pages
            imageHandler.ReorderPage(new ReorderPageOptions(guid, 1, 2));

            // Set options to include rotate and reorder transformations
            ImageOptions options = new ImageOptions { Transformations = Transformation.Rotate | Transformation.Reorder };

            // Set watermark properties
            Watermark watermark = new Watermark("This is watermark text")
            {
                Color = System.Drawing.Color.Blue,
                Position = WatermarkPosition.Diagonal,
                Width = 100
            };

            options.Watermark = watermark;

            // Get document pages image representation with multiple transformations
            List<PageImage> pages = imageHandler.GetPages(guid, options);
        }

        /// <summary>
        /// Perform multiple transformations in Html mode
        /// </summary>
        public static void Multiple_Transformations_For_Html()
        {
            Console.WriteLine("***** {0} *****", "Perform multiple transformations in Html mode");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);
            string guid = "word.doc";

            // Rotate first page 90 degrees
            htmlHandler.RotatePage(new RotatePageOptions(guid, 1, 90));

            // Rotate second page 180 degrees
            htmlHandler.RotatePage(new RotatePageOptions(guid, 2, 180));

            // Reorder first and second pages
            htmlHandler.ReorderPage(new ReorderPageOptions(guid, 1, 2));

            // Set options to include rotate and reorder transformations
            HtmlOptions options = new HtmlOptions { Transformations = Transformation.Rotate | Transformation.Reorder };

            // Set watermark properties
            Watermark watermark = new Watermark("This is watermark text")
            {
                Color = System.Drawing.Color.Blue,
                Position = WatermarkPosition.Diagonal,
                Width = 100
            };

            options.Watermark = watermark;

            // Get document pages html representation with multiple transformations
            List<PageHtml> pages = htmlHandler.GetPages(guid, options);
        }
    }
}
