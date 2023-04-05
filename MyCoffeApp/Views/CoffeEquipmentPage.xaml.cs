using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeEquipmentPage : ContentPage
    {
        public CoffeEquipmentPage()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void ButtonClick_Clicked(object sender, EventArgs e)
        {
            counter++;
            LabelCount.Text = $"You have clicked {counter} times!";
        }
    }
}