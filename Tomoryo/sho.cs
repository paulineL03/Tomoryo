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
    [Activity(Label = "sho", Theme = "@style/AppTheme")]
    public class sho : Activity
    {
        ImageButton bop;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.shopp);

            bop = FindViewById<ImageButton>(Resource.Id.bop);
            bop.Click += delegate
            {
                Intent i = new Intent(this, typeof(bppp));
                StartActivity(i);
            };
        }
    }
}