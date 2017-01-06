using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace screensize.Droid
{
    [Activity(Label = "screensize", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            
            //###########################################################################################
            //# Android #################################################################################
            //###########################################################################################
            
            // Store off the device sizes, so we can access them within Xamarin Forms
            //  Screen Width = WidthPixels / Density
            //  Screen Height = HeightPixels / Density

            App.DisplayScreenWidth  = (double)Resources.DisplayMetrics.WidthPixels / (double)Resources.DisplayMetrics.Density;
            App.DisplayScreenHeight = (double)Resources.DisplayMetrics.HeightPixels / (double)Resources.DisplayMetrics.Density; 
            App.DisplayScaleFactor  = (double)Resources.DisplayMetrics.Density;
            
            //###########################################################################################
            //###########################################################################################
            //###########################################################################################

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

