using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;


[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadCartesianChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer))]
[assembly: Xamarin.Forms.ExportRenderer(typeof(Telerik.XamarinForms.Chart.RadPieChart), typeof(Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer))]



namespace TelerikXamarinForms.iOS
{

    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;


        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            //Added
            new Telerik.XamarinForms.ChartRenderer.iOS.PieChartRenderer();

            new Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer();
            //End
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            window.RootViewController = App.GetMainPage().CreateViewController();

            window.MakeKeyAndVisible();

            return true;
        }
    }
}
