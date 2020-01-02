using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace QLCT 
{
    public class ExchangeManager : Exchange
    {
        IExchangeRestService restService;

        public ExchangeManager (IExchangeRestService service)
		{
			restService = service;
		}

		public Task<List<Exchange>> getKhoanChi()
		{
			return restService.getKhoanChi();
		}

		public Task<List<Exchange>> getKhoanThu()
		{
			return restService.getKhoanThu();
		}

		public Task<List<Exchange>> GetTasksAsync ()
		{
			return restService.RefreshDataAsync ();	
		}

		public Task SaveTaskAsync (Exchange item, bool isNewItem = false)
		{
			return restService.SaveTodoItemAsync (item, isNewItem);
		}

		public Task DeleteTaskAsync (Exchange item)
		{
			return restService.DeleteTodoItemAsync (item.soTienGiaoDich);
		}
    }
}