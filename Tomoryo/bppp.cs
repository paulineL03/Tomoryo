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
    [Activity(Label = "bppp")]
    public class bppp : Activity
    {
        Button bopp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.bpp);

            bopp = FindViewById<Button>(Resource.Id.bod);
            bopp.Click += delegate
            {

                Toast.MakeText(this, "Added To Cart", ToastLength.Long).Show();
            };
        }
    }
}