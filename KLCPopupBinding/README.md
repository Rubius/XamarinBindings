## Forked from https://github.com/Flasher-11/KLCPopupBinding

## Info
Binding KLCPopup for Xamarin.iOS

[Original repo KLCPopup (Obj-C)](https://github.com/jmascia/KLCPopup)

##Usage
Clone the repo, build and add to reference `KLCPopup.dll`


##Structs
Name | Description |
------------ | ------------- |
KLCPopupLayout|KLCPopupLayout structure and maker functions

##Enums
Name | Description |
------------ | ------------- |
KLCPopupShow|Controls how the popup will be presented
KLCPopupDismiss|Controls how the popup will be dismissed
KLCPopupHorizontalLayout|Controls where the popup will come to rest horizontally
KLCPopupVerticalLayout|Controls where the popup will come to rest vertically

##Methods
Method name | Params | Description |
------------ | ------------- | ------------- |
PopupWithContentView|`UIView` contentView|Convenience method for creating popup with default values (mimics UIAlertView)|
PopupWithContentView|`UIView` contentView, `KLCPopupShow` showType, `KLCPopupDismiss` dismissType, `KLCPopupMask` maskType, `bool` dismissOnBackgroundTouch, `bool` dismissOnContentTouch|Convenience method for creating popup with default values (mimics UIAlertView)|
DismissAllPopups|None|Dismisses all the popups in the app. Use as a fail-safe for cleaning up|
Show|None|Show popup with center layout. Animation determined by showType|
ShowWithLayout|`KLCPopupLayout` layout|Show with specified layout|
ShowWithDuration|`double` duration|Show and then dismiss after duration. 0.0 or less will be considered infinity|
ShowWithLayout|`KLCPopupLayout` layout, `double` duration|Show with layout and dismiss after duration|
ShowAtCenter|`CGPoint` center, `UIView` view|Show centered at point in view's coordinate system. If view is nil use screen base coordinates|
ShowAtCenter|`CGPoint` center, `UIView` view, `double` duration|Show centered at point in view's coordinate system, then dismiss after duration|
ShowWithLayout|`bool` animated|Dismiss popup. Uses dismissType if animated is YES|




## Properties

Property name | Property type | Description | 
------------ | ------------- | ------------- | 
ContentView|`UIView`|This is the view that you want to appear in Popup|
ShowType | `KLCPopupShow` | TAnimation transition for presenting contentView. Default = shrink in |
DismissType | `KLCPopupDismiss` | Animation transition for dismissing contentView. Default = shrink out|
MaskType | `KLCPopupMask` | Mask prevents background touches from passing to underlying views. Default = dimmed |
DimmedMaskAlpha | `nfloat` | Overrides alpha value for dimmed background mask. Default = 0.5 |
ShouldDismissOnBackgroundTouch | `bool` | If true, then popup will get dismissed when background is touched. Default = true|
ShouldDismissOnContentTouch |  `bool`  | If true, then popup will get dismissed when content view is touched. Default = false|
DidFinishShowingCompletion | `Action`  | Called after show animation finishes|
WillStartDismissingCompletion | `Action`  | Called when dismiss animation starts|
DidFinishDismissingCompletion | `Action`  | Called after dismiss animation finishes|
