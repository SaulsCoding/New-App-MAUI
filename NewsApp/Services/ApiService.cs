using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class ApiService
    {
        public async Task<Root> GetNews(string categoryName)
        {
            var httpClient = new HttpClient();//Take request to server
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=0490fc4d95cd20a50f9c1e3b06a15085&lang=en&topic=" + categoryName.ToLower());
            //Deserialized in C# classes
            return JsonConvert.DeserializeObject<Root>(response);// map accroding to the Root class
        }
       
    }
}
