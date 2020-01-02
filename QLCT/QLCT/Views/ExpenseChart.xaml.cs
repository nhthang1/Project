using Microcharts;
using QLCT.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Entry = Microcharts.Entry;

namespace QLCT.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpenseChart : ContentPage
    {

        public ExpenseChart()
        {
            InitializeComponent();
            Chart1.Chart = new BarChart() { Entries = chart1 };
            
        }
        List<Entry> chart1 = new List<Entry>
        {
            new Entry(200)
            {
                Label = "Tháng 1",
                ValueLabel = "200",
                Color = SKColor.Parse("#266489")
            },
            new Entry(400)
            {
                Label = "Tháng 2",
                ValueLabel = "400",
                Color = SKColor.Parse("#68B9C0")
            },
            new Entry(100)
            {
                Label = "Tháng 3",
                ValueLabel = "100",
                Color = SKColor.Parse("#90D585")
            },
            new Entry(300)
            {
                Label = "Tháng 4",
                ValueLabel = "300",
                Color = SKColor.Parse("#00FF00")
            },
            new Entry(120)
            {
                Label = "Tháng 5",
                ValueLabel = "120",
                Color = SKColor.Parse("#FF00FF")
            },
            new Entry(150)
            {
            Label = "Tháng 6",
            ValueLabel = "150",
            Color = SKColor.Parse("#808080")
            },
            new Entry(105)
            {
            Label = "Tháng 7",
            ValueLabel = "105",
            Color = SKColor.Parse("#808000")
            },
            new Entry(140)
            {
            Label = "Tháng 8",
            ValueLabel = "140",
            Color = SKColor.Parse("#800080")
            },
            new Entry(220)
            {
            Label = "Tháng 9",
            ValueLabel = "220",
            Color = SKColor.Parse("#008080")
            },
            new Entry(400)
            {
            Label = "Tháng 10",
            ValueLabel = "400",
            Color = SKColor.Parse("#000080")
            },
            new Entry(320)
            {
            Label = "Tháng 11",
            ValueLabel = "320",
            Color = SKColor.Parse("#000000")
            },
            new Entry(200)
            {
            Label = "Tháng 12",
            ValueLabel = "200",
            Color = SKColor.Parse("#FFFF00")
            },
        };
        List<Entry> chart2 = new List<Entry>();
        //{
        //    new Entry(400)
        //    {
        //        Label = "Tháng 2",
        //        ValueLabel = "400",
        //        Color = SKColor.Parse("#68B9C0")
        //    },
        //    new Entry(400)
        //    {
        //        Label = "Tháng 2",
        //        ValueLabel = "400",
        //        Color = SKColor.Parse("#90D585")
        //    },
        //    new Entry(400)
        //    {
        //        Label = "Tháng 2",
        //        ValueLabel = "400",
        //        Color = SKColor.Parse("#00FF00")
        //    },
        //    new Entry(400)
        //    {
        //        Label = "Tháng 2",
        //        ValueLabel = "400",
        //        Color = SKColor.Parse("#266489")
        //    },
        //};

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            List<PayChart> a = await App.PayChartManager.GetTasksAsync();
            String[] color = new String[] { "#266489", "#00FF00", "#90D585", "#68B9C0", "#FF00FF", "#808080", "#808000", "#800080"};
            int i = 0;
            foreach(PayChart b in a)
            {
                Entry temp = new Entry(b.totalAmount)
                {
                    Label = b._id,
                    ValueLabel = b.totalAmount.ToString(),
                    Color = SKColor.Parse(color[i])
                };
                i++;
                Debug.WriteLine(b._id);
                chart2.Add(temp);
            }
            Chart2.Chart = new DonutChart() { Entries = chart2, LabelTextSize=25 };
        }

    }

}

        