
using System;
using System.IO;

namespace Examples
{
    public static class _01_Licensing
    {
        /// <summary>
        /// Loading a License from File
        /// </summary>
        public static void Loading_a_License_from_File()
        {
            Console.WriteLine("***** {0} *****", "Loading a License from File");

            /* ********************* SAMPLE ********************* */
            // Path to license file
            string licensePath = @"D:\GroupDocs.Viewer.lic";

            // Setup license
            GroupDocs.Viewer.License lic = new GroupDocs.Viewer.License();
            lic.SetLicense(licensePath);
        }

        /// <summary>
        /// Loading a License from a Stream Object
        /// </summary>
        public static void Loading_a_License_from_a_Stream_Object()
        {
            Console.WriteLine("***** {0} *****", "Loading a License from a Stream Object");

            /* ********************* SAMPLE ********************* */

            // Obtain license stream
            FileStream licenseStream = new FileStream(@"D:\GroupDocs.Viewer.lic", FileMode.Open);

            // Setup license
            GroupDocs.Viewer.License lic = new GroupDocs.Viewer.License();
            lic.SetLicense(licenseStream);
        }
    }
}
