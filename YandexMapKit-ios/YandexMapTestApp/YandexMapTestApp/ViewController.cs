using System;
using Foundation;
using UIKit;
using YandexMapKit;

namespace YandexMapTestApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            View.BackgroundColor = UIColor.Yellow;
            YMKConfiguration.SharedInstance.ApiKey = "1j3yDUQHPj7YCeANE~TmkX3O0d1R2B2sXS5ADZFV8G1KnS7OOIPzzHxKQsd248BmoPKhHy2UXMK2H~MHgSkIw21QtN6aMubjouqBM0tbxvA=";
            var map = new YandexMapKit.YMKMapView();
            map.SetCenterCoordinate(new CoreLocation.CLLocationCoordinate2D(56.5, 84.9), 12, false);
            map.Frame = View.Bounds;
            map.ShowTraffic = false;
View.AddSubview(map);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

