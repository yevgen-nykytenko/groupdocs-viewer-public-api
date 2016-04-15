using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Handler;

namespace Examples._06._Other_operations
{
    public static class _09_Get_all_supported_document_formats
    {
        public static void Run()
        {
            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image or html handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            // Get supported document formats
            DocumentFormatsContainer documentFormatsContainer = imageHandler.GetSupportedDocumentFormats();
            Dictionary<string, string> supportedDocumentFormats = documentFormatsContainer.SupportedDocumentFormats;

            foreach (KeyValuePair<string, string> supportedDocumentFormat in supportedDocumentFormats)
            {
                Console.WriteLine(string.Format("Extension: '{0}'; Document format: '{1}'", supportedDocumentFormat.Key, supportedDocumentFormat.Value));
            }
        }
    }
}
