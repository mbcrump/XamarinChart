using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikXamarinForms.ViewModel
{
    public class CategoricalViewModel
    {
        private static Random random = new Random();
        private static string[] categories = new string[] { "Greenings", "Perfecto", "NearBy", "Family", "Fresh" };

        public CategoricalViewModel()
        {
            this.CategoricalData = GetCategoricalData();
        }

        public ObservableCollection<CategoricalData> CategoricalData { get; set; }

        public static ObservableCollection<CategoricalData> GetCategoricalData()
        {
            var data = new ObservableCollection<CategoricalData>();
            for (int i = 0; i < categories.Length; i++)
            {
                data.Add(new CategoricalData() { Value = random.Next(50, 100), Category = categories[i] });
            }

            return data;
        }
    }
}
