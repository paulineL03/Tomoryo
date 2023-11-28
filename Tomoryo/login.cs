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
    [Activity(Label = "login", Theme ="@style/AppTheme.NoActionBar")]
    public class login : Activity
    {
        EditText passwarudo;
        Button loginn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login);
            passwarudo = FindViewById<EditText>(Resource.Id.passwarudo);
            loginn = FindViewById<Button>(Resource.Id.login);



           loginn.Click += delegate {
                if (passwarudo.Text == "password")
                {
                    Toast.MakeText(this, "Welcome", ToastLength.Long).Show();
                   Intent i = new Intent(this, typeof(MainActivity));
                   StartActivity(i);
               }
                else
                {
                    Toast.MakeText(this, "Wrong Password", ToastLength.Long).Show();
                }

            };
        }


    }
}