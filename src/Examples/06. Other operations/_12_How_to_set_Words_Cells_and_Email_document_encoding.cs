using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Converter.Options;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Domain.Image;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using System.Collections.Generic;
using System.Text;

namespace Examples._06._Other_operations
{
    public static class _12_How_to_set_Words_Cells_and_Email_document_encoding
    {
        public static void Run()
        {
            //Initialize viewer config
            ViewerConfig viewerConfig = new ViewerConfig();
            viewerConfig.StoragePath = "c:\\storage";

            //Initialize viewer handler
            ViewerImageHandler viewerImageHandler = new ViewerImageHandler(viewerConfig);

            //Set encoding
            Encoding encoding = Encoding.GetEncoding("shift-jis");

            //Set image options
            ImageOptions imageOptions = new ImageOptions();
            imageOptions.WordsOptions.Encoding = encoding;
            imageOptions.CellsOptions.Encoding = encoding;
            imageOptions.EmailOptions.Encoding = encoding;

            //Get words document pages with encoding
            string wordsDocumentGuid = "document.txt";
            List<PageImage> wordsDocumentPages = viewerImageHandler.GetPages(wordsDocumentGuid, imageOptions);

            //Get cells document pages with encoding
            string cellsDocumentGuid = "document.csv";
            List<PageImage> cellsDocumentPages = viewerImageHandler.GetPages(cellsDocumentGuid, imageOptions);

            //Get email document pages with encoding
            string emailDocumentGuid = "document.msg";
            List<PageImage> emailDocumentPages = viewerImageHandler.GetPages(emailDocumentGuid, imageOptions);

            //Get words document info with encoding
            DocumentInfoOptions wordsDocumentInfoOptions = new DocumentInfoOptions(wordsDocumentGuid);
            wordsDocumentInfoOptions.WordsDocumentInfoOptions.Encoding = encoding;
            DocumentInfoContainer wordsDocumentInfoContainer = viewerImageHandler.GetDocumentInfo(wordsDocumentInfoOptions);

            //Get cells document info with encoding
            DocumentInfoOptions cellsDocumentInfoOptions = new DocumentInfoOptions(cellsDocumentGuid);
            cellsDocumentInfoOptions.CellsDocumentInfoOptions.Encoding = encoding;
            DocumentInfoContainer cellsDocumentInfoContainer = viewerImageHandler.GetDocumentInfo(cellsDocumentInfoOptions);

            //Get email document info with encoding
            DocumentInfoOptions emailDocumentInfoOptions = new DocumentInfoOptions(emailDocumentGuid);
            emailDocumentInfoOptions.EmailDocumentInfoOptions.Encoding = encoding;
            DocumentInfoContainer emailDocumentInfoContainer = viewerImageHandler.GetDocumentInfo(emailDocumentInfoOptions);
        }
    }
}
