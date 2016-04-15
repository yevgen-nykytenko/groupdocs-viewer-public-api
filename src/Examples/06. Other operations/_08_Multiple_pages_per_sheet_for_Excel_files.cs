using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using System.IO;

namespace Examples._06._Other_operations
{
    public static class _08_Multiple_pages_per_sheet_for_Excel_files
    {
        public static void Run()
        {
            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image or html handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);
            string guid = "document.xlsx";

            // Set pdf file one page per sheet option to false, default value of this option is true
            PdfFileOptions pdfFileOptions = new PdfFileOptions();
            pdfFileOptions.Guid = guid;
            pdfFileOptions.CellsOptions.OnePagePerSheet = false;

            //Get pdf file
            FileContainer fileContainer = imageHandler.GetPdfFile(pdfFileOptions);

            //The pdf file stream
            Stream pdfStream = fileContainer.Stream;

        }
    }
}
