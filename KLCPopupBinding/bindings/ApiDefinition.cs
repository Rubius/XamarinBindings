using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace KLCPopupBinding
{
    [BaseType(typeof(UIView))]
    public partial interface KLCPopup
    {
        [Export("contentView")]
        UIView ContentView { get; set;}

        [Export("showType")]
        KLCPopupShow ShowType { get; set;}

        [Export("dismissType")]
        KLCPopupDismiss DismissType { get; set;}

        [Export("maskType")]
        KLCPopupMask MaskType { get; set;}

        [Export("dimmedMaskAlpha")]
        nfloat DimmedMaskAlpha { get; set;}

        [Export("shouldDismissOnBackgroundTouch")]
        bool ShouldDismissOnBackgroundTouch { get; set;}

        [Export("shouldDismissOnContentTouch")]
        bool ShouldDismissOnContentTouch { get; set;}

        [Export("backgroundView")]
        UIView BackgroundView { get; }

        [Export("containerView")]
        UIView ContainerView { get; }

        [Export("isBeingShown")]
        bool IsBeingShown { get; }

        [Export("isShowing")]
        bool IsShowing { get; }

        [Export("isBeingDismissed")]
        bool IsBeingDismissed { get; }
              
        [Export("show")]
        void Show();

        [Export("showWithLayout:")]
        void ShowWithLayout (KLCPopupLayout layout);

        [Export("showWithDuration:")]
        void ShowWithDuration (double duration);

        [Export("showWithLayout:duration:")]
        void ShowWithDuration (KLCPopupLayout layout, double duration);

        [Export("showAtCenter:inView:")]
        void ShowAtCenter (CGPoint center, UIView view);

        [Export("showAtCenter:inView:withDuration:")]
        void ShowAtCenter (CGPoint center, UIView view, double duration);

        [Export("dismiss:")]
        void Dismiss (bool animated);

        [Static, Export("popupWithContentView:")]
        KLCPopup PopupWithContentView(UIView contentView);

        [Static, Export("popupWithContentView:showType:dismissType:maskType:dismissOnBackgroundTouch:dismissOnContentTouch:")]
        KLCPopup PopupWithContentView(UIView contentView, KLCPopupShow showType, KLCPopupDismiss dismissType, KLCPopupMask maskType, bool dismissOnBackgroundTouch, bool dismissOnContentTouch);

        [Static, Export("dismissAllPopups")]
        void DismissAllPopups();

        [Export("didFinishShowingCompletion")]
        Action DidFinishShowingCompletion { set; }

        [Export("willStartDismissingCompletion")]
        Action WillStartDismissingCompletion { set; }

        [Export("didFinishDismissingCompletion")]
        Action DidFinishDismissingCompletion { set; }

        [Export("willStartShowing")]
        void WillStartShowing();

        [Export("didFinishShowing")]
        void DidFinishShowing();

        [Export("willStartDismissing")]
        void WillStartDismissing();

        [Export("didFinishDismissing")]
        void DidFinishDismissing();
    }

    [BaseType(typeof(UIView))]
    [Category]
    public partial interface KLCPopup_UIView
    {
        [Export("forEachPopupDoBlock:block")]
        void ForEachPopupDoBlock (Action<KLCPopup> action);

        [Export("dismissPresentingPopup")]
        void DismissPresentingPopup();
    }
}