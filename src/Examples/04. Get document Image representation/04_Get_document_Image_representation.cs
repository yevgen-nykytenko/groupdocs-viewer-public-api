
using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain.Image;
using GroupDocs.Viewer.Handler;
using System;
using System.Collections.Generic;
using System.IO;

namespace Examples
{
    public static class _04_Get_document_Image_representation
    {
        /// <summary>
        /// Get document Image representation
        /// </summary>
        public static void Get_document_Image_representation()
        {
            Console.WriteLine("***** {0} *****", "Get document image representation");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";

            List<PageImage> pages = imageHandler.GetPages(guid);

            foreach (PageImage page in pages)
            {
                Console.WriteLine("Page number: {0}", page.PageNumber);

                // Page image stream
                Stream imageContent = page.Stream;
            }
        }
    }
}
