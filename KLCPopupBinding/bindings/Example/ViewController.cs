using System;
using CoreGraphics;
using UIKit;
using KLCPopupBinding;

namespace Example
{
    public partial class ViewController : UIViewController
    {
        KLCPopup popup;

        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            showButton.TouchUpInside += ShowButton_TouchUpInside;
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        void ShowButton_TouchUpInside (object sender, EventArgs e)
        {
            UIView view = new UIView(new CGRect(0,0,200,200));
            view.BackgroundColor = UIColor.Orange;
            view.Layer.CornerRadius = 10f;
            UIButton dismissButton = new UIButton(new CGRect(view.Layer.Frame.X/2, view.Layer.Frame.Y+80, 200, 40));
            dismissButton.TouchUpInside += DismissButton_TouchUpInside;
            dismissButton.SetTitle("Close", UIControlState.Normal);
            view.AddSubview(dismissButton);

            popup = KLCPopup.PopupWithContentView(view);
            popup.ShowType = KLCPopupShow.KLCPopupShowTypeBounceInFromLeft;
            popup.DismissType = KLCPopupDismiss.KLCPopupDismissTypeSlideOutToRight;
            popup.DidFinishDismissingCompletion = new Action(() =>
                {
                    UIAlertView alert = new UIAlertView("Info", "Window has been closed", null, "OK", null);
                    alert.Show();
                });
            popup.Show();
          }

        void DismissButton_TouchUpInside (object sender, EventArgs e)
        {
            popup.Dismiss(true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
            
    }
}

