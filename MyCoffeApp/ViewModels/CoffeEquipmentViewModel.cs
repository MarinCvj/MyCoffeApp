using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyCoffeApp.ViewModels
{
    public class CoffeEquipmentViewModel : BindableObject
    {
        public CoffeEquipmentViewModel()
        {
            IncreseCount = new Command(OnIncrese);
        }

        public ICommand IncreseCount { get; }

        int counter = 0;
        string countDisplay = "Click me!";
        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                {
                    return;
                }
                else
                {
                    countDisplay = value;
                    OnPropertyChanged();
                }
            }
        }

        void OnIncrese()
        {
            counter++;
            CountDisplay = $"You have clicked {counter} times!";
        }
    }
}
