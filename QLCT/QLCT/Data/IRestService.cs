using System.Collections.Generic;
using System.Threading.Tasks;

namespace QLCT
{
	public interface IRestService
	{
		Task <Wallet> RefreshDataAsync();

        Task SaveTodoItemAsync (Wallet item, bool isNewItem);

		Task DeleteTodoItemAsync (string _id);
	}
}
