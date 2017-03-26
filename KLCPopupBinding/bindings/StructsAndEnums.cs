using System;

namespace KLCPopupBinding
{
    public struct KLCPopupLayout
    {
        public KLCPopupHorizontalLayout horizontal;
        public KLCPopupVerticalLayout vertical;

        public KLCPopupLayout(KLCPopupHorizontalLayout horizontal, KLCPopupVerticalLayout vertical)
        {
            this.horizontal = horizontal;
            this.vertical = vertical;
        }
    }

    public enum KLCPopupShow
    {
        KLCPopupShowTypeNone,
        KLCPopupShowTypeFadeIn,
        KLCPopupShowTypeGrowIn,
        KLCPopupShowTypeShrinkIn,
        KLCPopupShowTypeSlideInFromTop,
        KLCPopupShowTypeSlideInFromBottom,
        KLCPopupShowTypeSlideInFromLeft,
        KLCPopupShowTypeSlideInFromRight,
        KLCPopupShowTypeBounceIn,
        KLCPopupShowTypeBounceInFromTop,
        KLCPopupShowTypeBounceInFromBottom,
        KLCPopupShowTypeBounceInFromLeft,
        KLCPopupShowTypeBounceInFromRight,
    }

    public enum KLCPopupDismiss
    {
        KLCPopupDismissTypeNone,
        KLCPopupDismissTypeFadeOut,
        KLCPopupDismissTypeGrowOut,
        KLCPopupDismissTypeShrinkOut,
        KLCPopupDismissTypeSlideOutToTop,
        KLCPopupDismissTypeSlideOutToBottom,
        KLCPopupDismissTypeSlideOutToLeft,
        KLCPopupDismissTypeSlideOutToRight,
        KLCPopupDismissTypeBounceOut,
        KLCPopupDismissTypeBounceOutToTop,
        KLCPopupDismissTypeBounceOutToBottom,
        KLCPopupDismissTypeBounceOutToLeft,
        KLCPopupDismissTypeBounceOutToRight,
    }

    public enum KLCPopupHorizontalLayout
    {
       KLCPopupHorizontalLayoutCustom,
       KLCPopupHorizontalLayoutLeft,
       KLCPopupHorizontalLayoutLeftOfCenter,
       KLCPopupHorizontalLayoutCenter,
       KLCPopupHorizontalLayoutRightOfCenter,
       KLCPopupHorizontalLayoutRight,
    }

    public enum KLCPopupVerticalLayout
    {
        KLCPopupHorizontalLayoutCustom,
        KLCPopupHorizontalLayoutLeft,
        KLCPopupHorizontalLayoutLeftOfCenter,
        KLCPopupHorizontalLayoutCenter,
        KLCPopupHorizontalLayoutRightOfCenter,
        KLCPopupHorizontalLayoutRight,
    }

    public enum KLCPopupMask
    {
        KLCPopupMaskTypeNone,
        KLCPopupMaskTypeClear,
        KLCPopupMaskTypeDimmed,
    }
}

