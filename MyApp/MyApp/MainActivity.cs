using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace MyApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
          TextView txtNumber;
        int number;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtNumber =  FindViewById<TextView>(Resource.Id.txtNumber);

            FindViewById<Button>(Resource.Id.btnIncrement).Click += (e, o) =>
            txtNumber.Text = (++number).ToString();

            FindViewById<Button>(Resource.Id.btnDecrement).Click += (e, o) =>
           txtNumber.Text = (--number).ToString();
        }

        
    }
}