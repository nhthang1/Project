using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLCT
{
	public interface IExchangeRestService
	{
		Task <List<Exchange>> RefreshDataAsync();

		Task<List<Exchange>> getKhoanThu();
		Task<List<Exchange>> getKhoanChi();
		Task GetDetailExchange();

        Task SaveTodoItemAsync (Exchange item, bool isNewItem);

		Task DeleteTodoItemAsync (string _id);
	}
}
