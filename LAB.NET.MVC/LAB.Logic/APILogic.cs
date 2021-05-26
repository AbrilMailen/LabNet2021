using LAB.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LAB.Logic
{
   public class APILogic
    {
       public async Task<List<QuotesAPI>> getQuotes() {
            var httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync("https://futuramaapi.herokuapp.com/api/quotes");
            List<QuotesAPI> caracteres = JsonConvert.DeserializeObject<List<QuotesAPI>>(json);
            return caracteres;
        }
    }
}
