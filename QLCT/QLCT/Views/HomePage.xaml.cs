using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QLCT.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{

			InitializeComponent ();

        }

		protected async override void OnAppearing()
		{
			base.OnAppearing();
            Wallet wallet = await App.walletManager.GetTasksAsync();
			txtCurrentMoney.Text = wallet.currentMoney.ToString();
			txtThuNhap.Text = wallet.thuNhap.ToString();
			txtDuDinhDung.Text = wallet.duDinhDung.ToString();
			txtDuDinhTichLuy.Text = wallet.duDinhTichLuy.ToString();
        }

		
    }
}