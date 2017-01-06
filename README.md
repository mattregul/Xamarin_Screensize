# Xamarin_Screensize


## Android - [Jump to Code Page](https://github.com/mattregul/Xamarin_Screensize/blob/master/screensize/screensize/screensize/screensize.Droid/MainActivity.cs#L22-L36)
```c#
// Store off the device sizes, so we can access them within Xamarin Forms
//  Screen Width = WidthPixels / Density
//  Screen Height = HeightPixels / Density

App.DisplayScreenWidth  = (double)Resources.DisplayMetrics.WidthPixels / (double)Resources.DisplayMetrics.Density;
App.DisplayScreenHeight = (double)Resources.DisplayMetrics.HeightPixels / (double)Resources.DisplayMetrics.Density; 
App.DisplayScaleFactor  = (double)Resources.DisplayMetrics.Density;
```


## iOS - [Jump to Code Page](https://github.com/mattregul/Xamarin_Screensize/blob/master/screensize/screensize/screensize/screensize.iOS/AppDelegate.cs#L27-L38)
```c#
// Store off the device sizes, so we can access them within Xamarin Forms
App.DisplayScreenWidth  = (double)UIScreen.MainScreen.Bounds.Width;
App.DisplayScreenHeight = (double)UIScreen.MainScreen.Bounds.Height;
App.DisplayScaleFactor  = (double)UIScreen.MainScreen.Scale;
```


## UWP - [Jump to Code Page](https://github.com/mattregul/Xamarin_Screensize/blob/master/screensize/screensize/screensize/screensize.UWP/App.xaml.cs#L60-L85)
```c#
// You decided which is best for you...
//  Do you want Size of the App's View
//      or
//  Do you want the Display's resolution 
// ######################################

// Size of App's view
screensize.App.DisplayScreenHeight = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Height;
screensize.App.DisplayScreenWidth = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;

// Size of screen's resolution
//screensize.App.DisplayScreenWidth = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().ScreenHeightInRawPixels;
//screensize.App.DisplayScreenHeight = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().ScreenWidthInRawPixels;

// Pixels per View Pixel
// - https://msdn.microsoft.com/en-us/windows/uwp/layout/design-and-ui-intro#effective-pixels-and-scaling
// - https://msdn.microsoft.com/en-us/windows/uwp/layout/screen-sizes-and-breakpoints-for-responsive-design
screensize.App.DisplayScaleFactor = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
```

## Windows Phone 8.1 - [Jump to Code Page](https://github.com/mattregul/Xamarin_Screensize/blob/master/screensize/screensize/screensize/screensize.WinPhone/App.xaml.cs#L62-L77)
```c#
// Size of App's view
screensize.App.DisplayScreenHeight = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Height;
screensize.App.DisplayScreenWidth = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;

// Pixels per View Pixel
// - https://msdn.microsoft.com/en-us/windows/uwp/layout/design-and-ui-intro#effective-pixels-and-scaling
// - https://msdn.microsoft.com/en-us/windows/uwp/layout/screen-sizes-and-breakpoints-for-responsive-design
screensize.App.DisplayScaleFactor = Windows.Graphics.Display.DisplayInformation.GetForCurrentView().RawPixelsPerViewPixel;
```

## Windows 8.1 - [Jump to Code Page](https://github.com/mattregul/Xamarin_Screensize/blob/master/screensize/screensize/screensize/screensize.Windows/App.xaml.cs#L61-L72)
```c#
// Size of App's view
screensize.App.DisplayScreenHeight = Window.Current.Bounds.Height;
screensize.App.DisplayScreenWidth = Window.Current.Bounds.Width;
screensize.App.DisplayScaleFactor = 1; // No scaling here?  If you find a scaling for Windows 8.1, please let me know :)
```

## Xamarin Forms Page - [Jump to Code Page](https://github.com/mattregul/Xamarin_Screensize/blob/master/screensize/screensize/screensize/screensize/App.cs#L10-L44)
```c#
namespace screensize
{
    public class App : Application
    {
        public static double DisplayScreenWidth = 0f;
        public static double DisplayScreenHeight = 0f;
        public static double DisplayScaleFactor = 0f;

        public App()
        {

            string ScreenDetails = Device.OS.ToString() + " Device Screen Size:\n" +
                $"Width: {DisplayScreenWidth}\n" +
                $"Height: {DisplayScreenHeight}\n" +
                $"Scale Factor: {DisplayScaleFactor}";

            // The root page of your application
            var content = new ContentPage
            {
                Title = "Xamarin_GetDeviceScreensize",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
                            Text = ScreenDetails
                        }
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }

    }
}
```

 Additional Goodies
- jasonCodesAway made a nice Xamarin plugin to determine screen size
 - [Nuget Page](https://www.nuget.org/packages/Xam.Plugins.XamJam.Screen) || [Github Page](https://github.com/jasonCodesAway/XamJam/tree/master/XamJam.Screen)
