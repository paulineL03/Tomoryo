using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.Media;
using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Bitmap = Android.Graphics.Bitmap;

namespace Tomoryo
{
    [Activity(Label = "importprocs")]
    public class importprocs : Activity
    {
        Button addpro;
        Button impic;
        EditText prodname;
        EditText categ;
        EditText pr;
        EditText qua;
        EditText descrip;
        Decimal prr;
        Int32 quaa;
        ImageView imgpreview;


        //readonly string [] 

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.importu);
            addpro = FindViewById<Button>(Resource.Id.addpro);
            impic = FindViewById<Button>(Resource.Id.impic);
            prodname = FindViewById<EditText>(Resource.Id.prodname);
            categ = FindViewById<EditText>(Resource.Id.categ);
            pr = FindViewById<EditText>(Resource.Id.pr);
            qua = FindViewById<EditText>(Resource.Id.qua);
            descrip = FindViewById<EditText>(Resource.Id.descrip);
            imgpreview = FindViewById<ImageView>(Resource.Id.imgpreview);
            addpro.Click += Addpro;
            impic.Click += ImpiClick;

            /*bool intResultTryParse = */
            decimal.TryParse((string)pr, out prr);
            /*if (intResultTryParse == true)
            {
                Console.WriteLine(intStr);
            }
            else
            {
                Console.WriteLine("Input is not in integer format");
            }
            Console.ReadLine();*/
            int.TryParse((string)qua, out quaa);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void ImpiClick(object sender, EventArgs e)
        {
            ImportPic();
        }


        async void ImportPic()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                Toast.MakeText(this, "Your Photot must be ugly try another one.", ToastLength.Short).Show();
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Full,
                CompressionQuality=40
        
             });

            byte[] imageArray = System.IO.File.ReadAllBytes(file.Path);

            Bitmap bitmap = BitmapFactory.DecodeByteArray(imageArray, 0, imageArray.Length);
            imgpreview.SetImageBitmap(bitmap);
        }

            private void Addpro(object sender, EventArgs e)
        {
           /* */
            try
            {
                /*prr = Convert.ToDecimal((string)pr);
                //result = Convert.ToDecimal(number);
                quaa = Convert.ToInt32((string)qua);*/
                string dpPath = System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "tomo.db");
                var db = new SQLiteConnection(dpPath);
                db.CreateTable<ImportProducts>();
                ImportProducts tbl = new ImportProducts();
                tbl.Product = prodname.Text;
                tbl.Category =categ.Text;
                tbl.Price = prr;
                tbl.Description = descrip.Text;
                tbl.Quantity = quaa;
                db.Insert(tbl);
                Clear();
                Toast.MakeText(this, "Record Added Successfully...,", ToastLength.Short).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();
            }
        }
        void Clear()
        {
            prodname.Text = "";
            categ.Text = "";
            descrip.Text = "";
            pr.Text = "";
            qua.Text = "";
        }
    }
}
