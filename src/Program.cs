using System;
using System.Threading.Tasks;

namespace ConvertHtml2Pdf
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            // Init 
            Console.WriteLine(" Script  Started");

            //set variables
            string url = args[0];
            string dest = args[1];
            string htmlstring = null;

            //Getting url
            Console.WriteLine($"[*] Getting url.. \"{url}\" ");
            try{
                htmlstring = await Html.GetUrl(url);
                Console.WriteLine($"----Geted html----");
            }catch(InvalidOperationException){
                Console.Error.WriteLine("Error!!! The url need be absolute!");
                return 1;
            }

            // Saving Pdf
            Console.WriteLine($"[*] Saving PDF in  \"{dest}\" ");
            bool saved = Pdf.save(htmlstring, dest);

            //finishing
            if(saved){
                Console.WriteLine("[*] PDF was save!! ");
                Console.WriteLine($"----Exit----");
                return 0;
            }else{
                Console.Error.WriteLine("[*] PDF wasn't save!! ");
                Console.WriteLine($"----Exit----");
                return 1;
            }

        }   
    }
}