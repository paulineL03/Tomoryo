using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tomoryo
{
    [Activity(Label = "copp")]
    public class copp : Activity
    {
        ImageButton bpbu;
        Button cancelo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cop);
            bpbu = FindViewById<ImageButton>(Resource.Id.bpbu);
            cancelo = FindViewById<Button>(Resource.Id.cancelo);

            bpbu.Click += delegate
            {
                Intent i = new Intent(this, typeof(bppp));
                StartActivity(i);
            };

            cancelo.Click += delegate
            {
                Intent i = new Intent(this, typeof(blanku));
                StartActivity(i);
                Toast.MakeText(this, "Order Cancelled", ToastLength.Long).Show();
            };

        }
    }
}