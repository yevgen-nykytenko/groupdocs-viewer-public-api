
using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain.Image;
using GroupDocs.Viewer.Handler;
using System;
using System.Collections.Generic;
using System.IO;

namespace Examples
{

    public static class _06_03_Get_document_representation_from
    {
        /// <summary>
        /// Get document representation from absolute path
        /// </summary>
        public static void Get_pages_absolute_path()
        {
            Console.WriteLine("***** {0} *****", "Get document representation from absolute path");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            // Set absolute path to file
            string guid = @"C:\storage\word.doc";

            // Get pages by absolute path
            List<PageImage> pages = imageHandler.GetPages(guid);
            Console.WriteLine("Page count: {0}", pages.Count);
        }

        /// <summary>
        /// Get document representation from relative path
        /// </summary>
        public static void Get_pages_relative_path()
        {
            Console.WriteLine("***** {0} *****", "Get document representation from relative path");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            // Set relative path. So that full path will be C:\storage\word.doc
            string guid = "word.doc";

            // Get pages by absolute path
            List<PageImage> pages = imageHandler.GetPages(guid);
            Console.WriteLine("Page count: {0}", pages.Count);
        }

        /// <summary>
        /// Get document representation from Uri
        /// </summary>
        public static void Get_pages_from_Uri()
        {
            Console.WriteLine("***** {0} *****", "Get document representation from Uri");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            Uri uri = new Uri("http://groupdocs.com/images/banner/carousel2/signature.png");

            // Get pages by absolute path
            List<PageImage> pages = imageHandler.GetPages(uri);
            Console.WriteLine("Page count: {0}", pages.Count);
        }

        /// <summary>
        /// Get document representation from Stream
        /// </summary>
        public static void Get_pages_from_stream()
        {
            Console.WriteLine("***** {0} *****", "Get document representation from Stream");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            using (FileStream fileStream = new FileStream(@"C:\storage\word.doc", FileMode.Open, FileAccess.Read))
            {
                // Get pages by absolute path
                List<PageImage> pages = imageHandler.GetPages(fileStream, "word.doc");
                Console.WriteLine("Page count: {0}", pages.Count);
            }
        }

    }
}
