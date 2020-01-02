using Xamarin.Forms;

namespace QLCT
{
	public static class Constants
	{
        // The iOS simulator can connect to localhost. However, Android emulators must use the 10.0.2.2 special alias to your host loopback interface.
        public static string BaseAddress = Device.RuntimePlatform == Device.Android ? "https://still-ridge-37958.herokuapp.com" : "https://still-ridge-37958.herokuapp.com";
        public static string TodoItemsUrl = BaseAddress + "/wallet/5dff6ba454a300189368d429";

        public static string exchangeURI = "https://still-ridge-37958.herokuapp.com/exchange";
        public static string exchangeGetUri = "https://still-ridge-37958.herokuapp.com/exchange?thuChi=thu";
        public static string exchangePayUri = "https://still-ridge-37958.herokuapp.com/exchange?thuChi=chi";
        public static string payChartUrl = "https://still-ridge-37958.herokuapp.com/exchange/pay-chart";
    }
}
// https://still-ridge-37958.herokuapp.com/wallet/5dff6ba454a300189368d429