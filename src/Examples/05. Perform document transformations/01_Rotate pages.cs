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
    public static class _05_01_Rotate_pages
    {
        /// <summary>
        /// Rotate page in Image mode
        /// </summary>
        public static void Rotate_page_in_Image_mode()
        {
            Console.WriteLine("***** {0} *****", "Rotate page in Image mode");

            /* ********************* SAMPLE ********************* */

            string licensePath = @"D:\GroupDocs.Viewer.lic";

            // Setup license
            GroupDocs.Viewer.License lic = new GroupDocs.Viewer.License();
            lic.SetLicense(licensePath);


            /* ********************  SAMPLE BEGIN *********************** */
            /* ********************  Rotate 1st page of the document by 90 deg *********************** */
            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "word.doc";

            // Set rotation angle 90 for page number 1
            RotatePageOptions rotateOptions = new RotatePageOptions(guid, 1, 90);

            // Perform page rotation
            imageHandler.RotatePage(rotateOptions);


            /* ********************  Retrieve all document pages including transformation *********************** */
            // Set image options to include rotate transformations
            ImageOptions imageOptions = new ImageOptions
            {
                Transformations = Transformation.Rotate
            };

            // Get image representation of all document pages, including rotate transformations 
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


            /*********************  SAMPLE END *************************/

            //foreach (PageImage page in pages)
            //{
            //    // Page number
            //    Console.WriteLine("Page number: {0}", page.PageNumber);

            //    // Page image stream
            //    Stream imageContent = page.Stream;

            //    using (
            //        FileStream file = new FileStream(string.Format(@"C:\{0}.png", page.PageNumber),
            //            FileMode.Create, FileAccess.ReadWrite))
            //    {
            //        MemoryStream xxx = new MemoryStream();
            //        page.Stream.CopyTo(xxx);
            //        var arr = xxx.ToArray();
            //        file.Write(arr, 0, arr.Length);
            //    }
            //}
        }

        /// <summary>
        /// Rotate page in Html mode
        /// </summary>
        public static void Rotate_Page_In_Html_Mode()
        {
            Console.WriteLine("***** {0} *****", "Rotate page in Html mode");

            /* ********************* SAMPLE ********************* */

            string licensePath = @"D:\GroupDocs.Viewer.lic";

            // Setup license
            GroupDocs.Viewer.License lic = new GroupDocs.Viewer.License();
            lic.SetLicense(licensePath);

            /* ********************  SAMPLE BEGIN ************************ */
            /* ********************  Rotate 1st page of the document by 90 deg *********************** */
            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create html handler
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config);
            string guid = "word.doc";

            // Set rotation angle 90 for page number 1
            RotatePageOptions rotateOptions = new RotatePageOptions(guid, 1, 90);

            // Perform page rotation
            htmlHandler.RotatePage(rotateOptions);


            /* ********************  Retrieve all document pages including transformation *********************** */
            // Set html options to include rotate transformations
            HtmlOptions htmlOptions = new HtmlOptions
            {
                Transformations = Transformation.Rotate
            };

            // Get html representation of all document pages, including rotate transformations 
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

            /*********************  SAMPLE END *************************/
            //foreach (PageHtml page in pages)
            //{
            //    // Page number
            //    Console.WriteLine("Page number: {0}", page.PageNumber);
            //}
        }
    }
}
