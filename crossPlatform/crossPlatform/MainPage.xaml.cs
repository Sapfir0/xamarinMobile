using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace crossPlatform{
    public partial class MainPage : ContentPage{
        public MainPage() {
            InitializeComponent();

        }

        private void ConvertBtn_OnClicked(object sender, EventArgs e) {
            string decimalNumberString = this.editDecimal.Text;
            if (String.IsNullOrEmpty(decimalNumberString)) {
                DisplayAlert("Error", "Поле пустое", "Я понял");
                return;
            }

            int decimalNumber = 0;
            if (!int.TryParse(editDecimal.Text, out decimalNumber)) {
                DisplayAlert("Error", "Убери точку", "Я понял");
                return;
            }
            int binaryNumber = Int32.Parse(Convert.ToString(decimalNumber, 2));
            editBinary.Text = binaryNumber.ToString();
        }
        
        void OnPinchUpdated (object sender, PinchGestureUpdatedEventArgs e)
        {
	        // Handle the pinch
        }
   
    }
}