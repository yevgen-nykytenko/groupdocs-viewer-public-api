using GroupDocs.Viewer.Config;
using GroupDocs.Viewer.Domain.Containers;
using GroupDocs.Viewer.Domain.Options;
using GroupDocs.Viewer.Handler;
using System;

namespace Examples
{
    public static class _06_05_Load_file_tree
    {
        /// <summary>
        /// Load file tree list for ViewerConfig.StoragePath
        /// </summary>
        public static void LoadFileTree()
        {
            Console.WriteLine("***** {0} *****", "Load file tree list for ViewerConfig.StoragePath");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            // Load file tree list for ViewerConfig.StoragePath
            FileTreeContainer container = imageHandler.LoadFileTree();

            foreach (var node in container.FileTree)
            {
                if (node.IsDirectory)
                {
                    Console.WriteLine("Guid: {0} | Name: {1} | LastModificationDate: {2}",
                    node.Guid,
                    node.Name,
                    node.LastModificationDate);
                }
                else
                    Console.WriteLine("Guid: {0} | Name: {1} | Document type: {2} | File type: {3} | Extension: {4} | Size: {5} | LastModificationDate: {6}",
                        node.Guid,
                        node.Name,
                        node.DocumentType,
                        node.FileType,
                        node.Extension,
                        node.Size,
                        node.LastModificationDate);
            }
        }

        /// <summary>
        /// Load file tree list for custom path
        /// </summary>
        public static void LoadFileTree_CustomPath()
        {
            Console.WriteLine("***** {0} *****", "Load file tree list for custom path");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            // Load file tree list for custom path 
            var options = new FileTreeOptions(@"D:\");

            FileTreeContainer container = imageHandler.LoadFileTree(options);

            foreach (var node in container.FileTree)
            {
                if (node.IsDirectory)
                {
                    Console.WriteLine("Guid: {0} | Name: {1} | LastModificationDate: {2}",
                    node.Guid,
                    node.Name,
                    node.LastModificationDate);
                }
                else
                    Console.WriteLine("Guid: {0} | Name: {1} | Document type: {2} | File type: {3} | Extension: {4} | Size: {5} | LastModificationDate: {6}",
                        node.Guid,
                        node.Name,
                        node.DocumentType,
                        node.FileType,
                        node.Extension,
                        node.Size,
                        node.LastModificationDate);
            }
        }

        /// <summary>
        /// Load file tree list for custom path with order
        /// </summary>
        public static void LoadFileTree_CustomPath_Order()
        {
            Console.WriteLine("***** {0} *****", "Load file tree list for custom path with order");

            /* ********************* SAMPLE ********************* */

            // Setup GroupDocs.Viewer config
            ViewerConfig config = new ViewerConfig();
            config.StoragePath = @"C:\storage";

            // Create image handler
            ViewerImageHandler imageHandler = new ViewerImageHandler(config);

            // Load file tree list ordered by Name field for custom path 
            var options = new FileTreeOptions(@"D:\", FileTreeOptions.FileTreeOrderBy.Name, true);

            FileTreeContainer container = imageHandler.LoadFileTree(options);

            foreach (var node in container.FileTree)
            {
                if (node.IsDirectory)
                {
                    Console.WriteLine("Guid: {0} | Name: {1} | LastModificationDate: {2}",
                    node.Guid,
                    node.Name,
                    node.LastModificationDate);
                }
                else
                    Console.WriteLine("Guid: {0} | Name: {1} | Document type: {2} | File type: {3} | Extension: {4} | Size: {5} | LastModificationDate: {6}",
                        node.Guid,
                        node.Name,
                        node.DocumentType,
                        node.FileType,
                        node.Extension,
                        node.Size,
                        node.LastModificationDate);
            }
        }
    }
}
