using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

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
