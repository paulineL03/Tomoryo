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
    [Activity(Label = "blanku")]
    public class blanku : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.blank);
            Button shupu = FindViewById<Button>(Resource.Id.shupu);

            shupu.Click += delegate
            {
                Intent i = new Intent(this, typeof(sho));
                StartActivity(i);

            };

        }
    }
}