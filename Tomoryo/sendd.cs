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
    [Activity(Label = "sendd")]
    public class sendd : Activity
    {
        Button sendu;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.send);
            sendu = FindViewById<Button>(Resource.Id.sendu);


            sendu.Click += delegate
            {
                Toast.MakeText(this, "Connection unstable, try again later", ToastLength.Long).Show();


            };
         }


    }
}