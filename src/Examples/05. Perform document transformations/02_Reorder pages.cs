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
    public static class _05_02_Reorder_pages
    {
        /// <summary>
        /// Rotate page in Image mode
        /// </summary>
        public static void Reorder_Pages_In_Image_Mode()
        {
            Console.WriteLine("***** {0} *****", "Reorder pages in Image mode");

            /* ********************* SAMPLE ********************* */
            /* ********************   Reorder 1st and 2nd pages  *********************** */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";
            int pageNumber = 1;
            int newPosition = 2;

            // Perform page reorder
            ReorderPageOptions options = new ReorderPageOptions(guid, pageNumber, newPosition);
            imageHandler.ReorderPage(options);


            /* ********************  Retrieve all document pages including transformation *********************** */

            // Set image options to include reorder transformations
            ImageOptions imageOptions = new ImageOptions
            {
                Transformations = Transformation.Reorder
            };

            // Get image representation of all document pages, including reorder transformations 
            List<PageImage> pages = imageHandler.GetPages(guid, imageOptions);


            /* ********************  Retrieve all document pages excluding transformation *********************** */

            // Set image options NOT to include ANY transformations
            ImageOptions noTransformationsOptions = new ImageOptions
            {
                Transformations = Transformation.None // This is by default
            };

            // Get image representation of all document pages, without transformations 
            List<PageImage> pagesWithoutTransformations = imageHandler.GetPages(guid, noTransformationsOptions);

            // Get image representation of all document pages, without transformations
            List<PageImage> pagesWithoutTransformations2 = imageHandler.GetPages(guid);
        }

        public static void Reorder_Pages_In_Html_Mode()
        {
            Console.WriteLine("***** {0} *****", "Reorder pages in Html mode");

            /* ********************* SAMPLE ********************* */
            /* ********************   Reorder 1st and 2nd pages  *********************** */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);
            string guid = "word.doc";
            int pageNumber = 1;
            int newPosition = 2;

            // Perform page reorder
            ReorderPageOptions options = new ReorderPageOptions(guid, pageNumber, newPosition);
            htmlHandler.ReorderPage(options);


            /* ********************  Retrieve all document pages including transformation *********************** */

            // Set html options to include reorder transformations
            HtmlOptions htmlOptions = new HtmlOptions
            {
                Transformations = Transformation.Reorder
            };

            // Get html representation of all document pages, including reorder transformations 
            List<PageHtml> pages = htmlHandler.GetPages(guid, htmlOptions);


            /* ********************  Retrieve all document pages excluding transformation *********************** */

            // Set html options NOT to include ANY transformations
            HtmlOptions noTransformationsOptions = new HtmlOptions
            {
                Transformations = Transformation.None // This is by default
            };

            // Get html representation of all document pages, without transformations 
            List<PageHtml> pagesWithoutTransformations = htmlHandler.GetPages(guid, noTransformationsOptions);

            // Get html representation of all document pages, without transformations
            List<PageHtml> pagesWithoutTransformations2 = htmlHandler.GetPages(guid);
        }
    }
}
