
using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using System;

namespace Examples
{
    public static class _06_02_Get_original_file_in_Pdf_format
    {
        /// <summary>
        /// Get original file in Pdf format
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("***** {0} *****", "Get original file in Pdf format");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            PdfFileOptions options = new PdfFileOptions();
            options.Guid = "word.doc";

            // Get file as pdf
            FileContainer container = imageHandler.GetPdfFile(options);
            Console.WriteLine("Stream lenght: {0}", container.Stream.Length);
        }

    }
}
