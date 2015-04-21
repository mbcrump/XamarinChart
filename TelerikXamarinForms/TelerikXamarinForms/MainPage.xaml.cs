using TelerikXamarinForms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.XamarinForms.Chart;
using Xamarin.Forms;

namespace TelerikXamarinForms
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            BackgroundColor = Xamarin.Forms.Device.OnPlatform(Xamarin.Forms.Color.White, Xamarin.Forms.Color.White, Xamarin.Forms.Color.Transparent);

            var chart = new RadCartesianChart
            {
                HorizontalAxis = new CategoricalAxis(),
                VerticalAxis = new NumericalAxis(),
                BindingContext = new CategoricalViewModel()
            };

            var series = new BarSeries();
            series.SetBinding(BarSeries.ItemsSourceProperty, new Binding("CategoricalData"));
            //var series = new AreaSeries();
            //series.SetBinding(AreaSeries.ItemsSourceProperty, new Binding("CategoricalData"));   
            series.ValueBinding = new PropertyNameDataPointBinding("Value");
            series.CategoryBinding = new PropertyNameDataPointBinding("Category");

            chart.Series.Add(series);

            this.Content = chart;
        }
    }
}
