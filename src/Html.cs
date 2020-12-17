using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace ConvertHtml2Pdf{

    class Html{
    
        static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetUrl (string url){
        
            try{
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
               
            }catch(HttpRequestException e){
                Console.Error.WriteLine("\nException Caught!");	
                Console.Error.WriteLine("Message :{0} ",e.Message);
                return null;
            }
        }

    }
}