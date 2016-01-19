using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Converter.Options;
using GroupDocs.Viewer.Domain.Html;
using GroupDocs.Viewer.Handler;
using System;
using System.Collections.Generic;
using System.IO;

namespace Examples
{
    public static class _03_Get_document_Html_representation
    {
        /// <summary>
        /// Get document html representation with embedded resources
        /// </summary>
        public static void Get_Html_EmbeddedResources()
        {
            Console.WriteLine("***** {0} *****", "Get document html representation with embedded resources");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);
            string guid = "word.doc";

            HtmlOptions options = new HtmlOptions();
            options.IsResourcesEmbedded = true;

            List<PageHtml> pages = htmlHandler.GetPages(guid, options);

            foreach (PageHtml page in pages)
            {
                Console.WriteLine("Page number: {0}", page.PageNumber);
                Console.WriteLine("Html content: {0}", page.HtmlContent);
            }
        }

        /// <summary>
        /// Get document html representation
        /// </summary>
        public static void Get_Html_With_Resources()
        {
            Console.WriteLine("***** {0} *****", "Get document html representation");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);
            string guid = "word.doc";

            List<PageHtml> pages = htmlHandler.GetPages(guid);

            foreach (PageHtml page in pages)
            {
                Console.WriteLine("Page number: {0}", page.PageNumber);
                Console.WriteLine("Resources count: {0}", page.HtmlResources.Count);
                Console.WriteLine("Html content: {0}", page.HtmlContent);

                // Html resources descriptions
                foreach (HtmlResource resource in page.HtmlResources)
                {
                    Console.WriteLine(resource.ResourceName, resource.ResourceType);

                    // Get html page resource stream
                    Stream resourceStream = htmlHandler.GetResource(guid, resource);
                }
            }
        }
    }
}
