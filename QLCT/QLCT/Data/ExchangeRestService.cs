using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace QLCT
{
    public class ExchangeRestservice : IExchangeRestService
    {
        HttpClient _client;

        public List<Exchange> Items { get; private set; }

        public ExchangeRestservice()
        {
            _client = new HttpClient();
        }

        public async Task<List<Exchange>> RefreshDataAsync()
        {
            Items = new List<Exchange>();

            var uri = new Uri(string.Format(Constants.exchangeURI));

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    Items = JsonConvert.DeserializeObject<List<Exchange>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }
        public async Task<List<Exchange>> getKhoanThu()
        {
            Items = new List<Exchange>();

            var uri = new Uri(string.Format(Constants.exchangeGetUri, string.Empty));
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    Items = JsonConvert.DeserializeObject<List<Exchange>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task<List<Exchange>> getKhoanChi()
        {
            Items = new List<Exchange>();

            var uri = new Uri(string.Format(Constants.exchangePayUri, string.Empty));
            Debug.WriteLine(uri);
            Debug.WriteLine(uri);
            Debug.WriteLine(uri);
            Debug.WriteLine(uri);
            Debug.WriteLine(uri);
            Debug.WriteLine(uri);
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(content);
                    Items = JsonConvert.DeserializeObject<List<Exchange>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Items;
        }


        public async Task SaveTodoItemAsync(Exchange item, bool isNewItem)
        {
            var uri = new Uri(string.Format(Constants.TodoItemsUrl, string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await _client.PostAsync(uri, content);
                }
                else
                {
                    response = await _client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tExchange successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public async Task DeleteTodoItemAsync(string _id)
        {
            var uri = new Uri(string.Format(Constants.TodoItemsUrl, _id));

            try
            {
                var response = await _client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tExchange successfully deleted.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }

        public Task GetDetailExchange()
        {
            throw new NotImplementedException();
        }


    }
}
