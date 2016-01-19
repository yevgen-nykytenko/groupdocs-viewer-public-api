using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Domain.Html;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using GroupDocs.Viewer.Handler.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Examples
{
    public static class _06_04_How_to_use_custom_input_data_handler
    {
        /// <summary>
        /// How to use custom input data handler
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("***** {0} *****", "How to use custom input data handler");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // File guid
            string guid = @"word.doc";

            // Use custom IInputDataHandler implementation
            IInputDataHandler inputDataHandler = new FtpInputDataHandler();

            // Get file HTML representation
            ViewerHtmlHandler htmlHandler = new ViewerHtmlHandler(config, inputDataHandler);

            List<PageHtml> pages = htmlHandler.GetPages(guid);

            Console.WriteLine("Pages count: {0}", pages.Count);

            // Get list of entities for ftp root folder
            FileTreeOptions options = new FileTreeOptions(@"ftp://localhost");
            FileTreeContainer container = htmlHandler.LoadFileTree(options);
        }
    }

    /// <summary>
    /// An implementation of IInputDataHandler interface for documents stored at FTP server
    /// </summary>
    public class FtpInputDataHandler : IInputDataHandler
    {
        private const string _server = "ftp://localhost";
        private const string _userName = "anonymous";
        private const string _userPassword = "";

        public FileDescription GetFileDescription(string guid)
        {
            return new FileDescription(guid);
        }

        public Stream GetFile(string guid)
        {
            Uri uri = GetUriFromGuid(guid);
            FtpWebRequest request = GetFtpRequest(uri, WebRequestMethods.Ftp.DownloadFile);

            Stream reader = request.GetResponse().GetResponseStream();
            MemoryStream result = new MemoryStream();

            int bytesRead = 0;
            byte[] buffer = new byte[2048];
            while (true)
            {
                bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                    break;

                result.Write(buffer, 0, bytesRead);
            }

            return result;
        }

        public DateTime GetLastModificationDate(string guid)
        {
            Uri uri = GetUriFromGuid(guid);
            FtpWebRequest request = GetFtpRequest(uri, WebRequestMethods.Ftp.GetDateTimestamp);

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                return response.LastModified;
        }

        public List<FileDescription> LoadFileTree(FileTreeOptions fileTreeOptions)
        {
            Uri uri = Uri.IsWellFormedUriString(fileTreeOptions.Path, UriKind.Absolute) ? new Uri(fileTreeOptions.Path) : GetUriFromGuid(fileTreeOptions.Path);
            FtpWebRequest request = GetFtpRequest(uri, WebRequestMethods.Ftp.ListDirectory);

            List<FileDescription> result = new List<FileDescription>();

            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                Stream responseStream = response.GetResponseStream();

                if (responseStream != null)
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        string guid;
                        while ((guid = reader.ReadLine()) != null)
                        {
                            result.Add(new FileDescription(guid, !guid.Contains(".")));
                        }
                    }
                }
            }

            return result;
        }

        private Uri GetUriFromGuid(string guid)
        {
            return Uri.IsWellFormedUriString(guid, UriKind.Absolute)
                ? new Uri(guid)
                : new Uri(string.Format("{0}/{1}", _server, guid));
        }

        private FtpWebRequest GetFtpRequest(Uri uri, string method)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(_userName, _userPassword);
            request.Method = method;
            return request;
        }
    }
}
