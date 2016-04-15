using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using System;

namespace Examples
{
    public static class _02_Get_Document_Information
    {
        /// <summary>
        /// Get Document Information
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("***** {0} *****", "Get Document Information");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);

            string documentName = "word.doc";
            // Get document information
            DocumentInfoOptions options = new DocumentInfoOptions(documentName);
            DocumentInfoContainer documentInfo = htmlHandler.GetDocumentInfo(options);

            Console.WriteLine("DateCreated: {0}", documentInfo.DateCreated);
            Console.WriteLine("DocumentType: {0}", documentInfo.DocumentType);
            Console.WriteLine("Extension: {0}", documentInfo.Extension);
            Console.WriteLine("FileType: {0}", documentInfo.FileType);
            Console.WriteLine("Guid: {0}", documentInfo.Guid);
            Console.WriteLine("LastModificationDate: {0}", documentInfo.LastModificationDate);
            Console.WriteLine("Name: {0}", documentInfo.Name);
            Console.WriteLine("PageCount: {0}", documentInfo.Pages.Count);
            Console.WriteLine("Size: {0}", documentInfo.Size);

            foreach (PageData pageData in documentInfo.Pages)
            {
                Console.WriteLine("Page number: {0}", pageData.Number);
                Console.WriteLine("Page name: {0}", pageData.Name);
            }
        }
    }
}
