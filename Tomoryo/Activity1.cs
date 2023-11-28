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
    [Activity(Label = "Tomoryo", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Splash);

            Handler h = new Handler();
            h.PostDelayed(new System.Action(() =>
            {
                Intent i = new Intent(this, typeof(login));
                StartActivity(i);
            }), 3000);
        }
    }
}