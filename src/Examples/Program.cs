using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            _01_Licensing.Loading_a_License_from_File();
            _01_Licensing.Loading_a_License_from_a_Stream_Object();

            _02_Get_Document_Information.Run();

            _03_Get_document_Html_representation.Get_Html_EmbeddedResources();
            _03_Get_document_Html_representation.Get_Html_With_Resources();

            _04_Get_document_Image_representation.Get_document_Image_representation();

            _05_01_Rotate_pages.Rotate_Page_In_Html_Mode();
            _05_01_Rotate_pages.Rotate_page_in_Image_mode();

            _05_02_Reorder_pages.Reorder_Pages_In_Html_Mode();
            _05_02_Reorder_pages.Reorder_Pages_In_Image_Mode();

            _05_03_Watermarking.Add_Watermark_For_Html();
            _05_03_Watermarking.Add_Watermark_For_Image();

            _05_04_Multiple_Transformations.Multiple_Transformations_For_Html();
            _05_04_Multiple_Transformations.Multiple_Transformations_For_Image();

            _06_01_Get_original_file.Run();
            _06_02_Get_original_file_in_Pdf_format.Run();

            _06_03_Get_document_representation_from.Get_pages_absolute_path();
            _06_03_Get_document_representation_from.Get_pages_from_Uri();
            _06_03_Get_document_representation_from.Get_pages_from_stream();
            _06_03_Get_document_representation_from.Get_pages_relative_path();

            //  _06_04_How_to_use_custom_input_data_handler.Run();

            _06_05_Load_file_tree.LoadFileTree();
            _06_05_Load_file_tree.LoadFileTree_CustomPath();
            _06_05_Load_file_tree.LoadFileTree_CustomPath_Order();

            _06_06_Get_printable_html.Get_PrintableHtml();
            _06_06_Get_printable_html.Get_PrintableHtml_WithCss();
            _06_06_Get_printable_html.Get_PrintableHtml_WithWatermark();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
