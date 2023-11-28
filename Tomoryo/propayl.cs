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
    [Activity(Label = "propayl")]
    public class propayl : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.profile);

            var comp = FindViewById<ImageButton>(Resource.Id.compp);
            comp.Click += cooo;
        }

        private void cooo(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(bus));
            StartActivity(i);
        }
    }
}