using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Handler;
using System;

namespace Examples
{
    public static class _06_01_Get_original_file
    {
        /// <summary>
        /// Get original file
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("***** {0} *****", "Get original file");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            string guid = "word.doc";

            // Get original file
            FileContainer container = imageHandler.GetFile(guid);
            Console.WriteLine("Stream lenght: {0}", container.Stream.Length);
        }
    }
}
