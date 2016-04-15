using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Converter.Options;
using GroupDocs.Viewer.Domain.Html;
using GroupDocs.Viewer.Domain.Image;
using GroupDocs.Viewer.Handler;
using System;
using System.Collections.Generic;
using System.IO;

namespace Examples._06._Other_operations
{
    public static class _07_Show_grid_lines_for_Excel_files
    {
        public static void InImageRepresentation()
        {
            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "document.xlsx";

            // Set image options to show grid lines
            ImageOptions options = new ImageOptions();
            options.CellsOptions.ShowGridLines = true;

            List<PageImage> pages = imageHandler.GetPages(guid, options);

            foreach (PageImage page in pages)
            {
                Console.WriteLine("Page number: {0}", page.PageNumber);

                // Page image stream
                Stream imageContent = page.Stream;
            }
        }

        public static void InHtmlRepresentation()
        {
            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);
            string guid = "document.xlsx";

            // Set html options to show grid lines
            HtmlOptions options = new HtmlOptions();
            options.CellsOptions.ShowGridLines = true;
            List<PageHtml> pages = htmlHandler.GetPages(guid, options);

            foreach (PageHtml page in pages)
            {
                Console.WriteLine("Page number: {0}", page.PageNumber);
                Console.WriteLine("Html content: {0}", page.HtmlContent);
            }
        }
    }
}
