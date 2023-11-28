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
    [Activity(Label = "proarc")]
    public class proarc : Activity
    {
        ImageButton edit1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.arc);
            edit1 = FindViewById<ImageButton>(Resource.Id.edit1);
            edit1.Click += Clicku;
        }

        private void Clicku(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(importprocs));
            StartActivity(i);
        }
    }
}