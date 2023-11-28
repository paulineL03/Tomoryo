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
    [Activity(Label = "manacc")]
    public class manacc : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.acc);
            var propic = FindViewById<Button>(Resource.Id.propic);
            propic.Click += (sender, args) =>
            {
                Intent i = new Intent(this, typeof(propayl));
                StartActivity(i);
            };
        }
    }
}