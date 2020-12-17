using System;
using System.IO;
using iText.Html2pdf;

namespace ConvertHtml2Pdf{

    class Pdf{

        public static bool save(string html, string  dest){
            try{            
	            HtmlConverter.ConvertToPdf(html, new FileStream(dest, FileMode.Create));
                return true;
            }catch(Exception e){
                Console.Error.WriteLine("\nException Caught!");	
                Console.Error.WriteLine("Message :{0} ",e.Message);
            }
            return false;
        }
    }
}