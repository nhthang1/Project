using Newtonsoft.Json;
using QLCT.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLCT.Data
{
    public class PayChartService : IPayChartService
    {
        HttpClient _client;

        public List<PayChart> Items { get; private set; }

        public PayChartService()
        {
            _client = new HttpClient();
        }
        public async Task<List<PayChart>> getDuLieu()
        {
            Items = new List<PayChart>();
            var uri = new Uri(string.Format(Constants.payChartUrl));
            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    Items = JsonConvert.DeserializeObject<List<PayChart>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }
    }
}
