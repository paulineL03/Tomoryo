using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.View;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Navigation;
using Google.Android.Material.Snackbar;
using SQLite;

namespace Tomoryo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            var imageButton1 = FindViewById<Android.Widget.ImageButton>(Resource.Id.imageButton1);
            imageButton1.Click += BuOnClick;

            var imageButton2 = FindViewById<Android.Widget.ImageButton>(Resource.Id.maill);
            imageButton2.Click += BuOnClick2;

            var imageButton3 = FindViewById<Android.Widget.ImageButton>(Resource.Id.pupol);
            imageButton3.Click += BuOnClick3;

            var imageButton4 = FindViewById<Android.Widget.ImageButton>(Resource.Id.busines);
            imageButton4.Click += BuOnClick4;

            var imageButton5 = FindViewById<Android.Widget.ImageButton>(Resource.Id.cartu);
            imageButton5.Click += BuOnClick5;

            var imageButton6 = FindViewById<Android.Widget.ImageButton>(Resource.Id.cerd);
            imageButton6.Click += BuOnClick6;

            /*var propic = FindViewById<Android.Widget.Button>(Resource.Id.propic);
            propic.Click += (sender, args) =>
            {
                Intent i = new Intent(this, typeof(propayl));
                StartActivity(i);
            };*/

        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if(drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                Intent i = new Intent(this, typeof(set));
                StartActivity(i);
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            Intent i = new Intent(this, typeof(newmess));
            StartActivity(i);
            /* View view = (View) sender;
             Snackbar.Make(view, "No Internet Can't, Create Message", Snackbar.LengthLong)
                 .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();*/
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            int id = item.ItemId;

            if (id == Resource.Id.nav_camera)
            {
                Intent i = new Intent(this, typeof(importprocs));
                StartActivity(i);
            }
            else if (id == Resource.Id.nav_gallery)
            {
                Intent i = new Intent(this, typeof(proarc));
                StartActivity(i);
            }
            else if (id == Resource.Id.nav_slideshow)
            {
                Intent i = new Intent(this, typeof(copp));
                StartActivity(i);
            }
            else if (id == Resource.Id.nav_manage)
            {
                Intent i = new Intent(this, typeof(manacc));
                StartActivity(i);
            }
            else if (id == Resource.Id.nav_share)
            {
                Intent i = new Intent(this, typeof(conn));
                StartActivity(i);
            }
            else if (id == Resource.Id.nav_send)
            {
                Intent i = new Intent(this, typeof(sendd));
                StartActivity(i);
            }

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void BuOnClick(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(cash));
            StartActivity(i);
        }
        
        private void BuOnClick2(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(mess));
            StartActivity(i);
        }

        private void BuOnClick3(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(pipol));
            StartActivity(i);
        }

        private void BuOnClick4(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(bus));
            StartActivity(i);
        }

        private void BuOnClick5(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(sho));
            StartActivity(i);
        }

        private void BuOnClick6(object sender, EventArgs e)
        {
            Intent i = new Intent(this, typeof(traa));
            StartActivity(i);
        }

    }
}

