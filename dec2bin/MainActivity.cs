using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Java.Lang;

namespace dec2bin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity {
        protected override void OnCreate(Bundle savedInstanceState)  {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button convertBtn = FindViewById<Button>(Resource.Id.convertBtn);
            convertBtn.Click += (sender, e) =>
            {
                EditText editDecimal = FindViewById<EditText>(Resource.Id.decimalCode);
                EditText binaryResult = FindViewById<EditText>(Resource.Id.binaryCodeEdit);
                TextView binaryView = FindViewById<TextView>(Resource.Id.binaryView);
                int decimalNumber = Int32.Parse(editDecimal.Text);  // по идее тут возвращается сразу интушка, тут же не детский и нетипизированный котлин 
                int binaryNumber = Int32.Parse(Convert.ToString(decimalNumber, 2));
                binaryResult.Text = binaryNumber.ToString();
            };

        }
    }
}