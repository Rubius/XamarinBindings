using System;

using Foundation;
using ObjCRuntime;
using UIKit;

namespace CZPicker {
// @protocol CZPickerViewDataSource <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface CZPickerViewDataSource
{
	// @required -(NSInteger)numberOfRowsInPickerView:(CZPickerView *)pickerView;
	[Abstract]
	[Export ("numberOfRowsInPickerView:")]
	nint NumberOfRowsInPickerView (CZPickerView pickerView);

	// @optional -(NSAttributedString *)czpickerView:(CZPickerView *)pickerView attributedTitleForRow:(NSInteger)row;
	[Export ("czpickerView:attributedTitleForRow:")]
	NSAttributedString AttributedTitleForRow (CZPickerView pickerView, nint row);

	// @optional -(NSString *)czpickerView:(CZPickerView *)pickerView titleForRow:(NSInteger)row;
	[Export ("czpickerView:titleForRow:")]
	string TitleForRow (CZPickerView pickerView, nint row);

	// @optional -(UIImage *)czpickerView:(CZPickerView *)pickerView imageForRow:(NSInteger)row;
	[Export ("czpickerView:imageForRow:")]
	UIImage ImageForRow (CZPickerView pickerView, nint row);
}

// @protocol CZPickerViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface CZPickerViewDelegate
{
	// @optional -(void)czpickerView:(CZPickerView *)pickerView didConfirmWithItemAtRow:(NSInteger)row;
	[Export ("czpickerView:didConfirmWithItemAtRow:")]
	void DidConfirmWithItemAtRow (CZPickerView pickerView, nint row);

	// @optional -(void)czpickerView:(CZPickerView *)pickerView didConfirmWithItemsAtRows:(NSArray *)rows;
	[Export ("czpickerView:didConfirmWithItemsAtRows:")]
	//[Verify (StronglyTypedNSArray)]
	void DidConfirmWithItemsAtRows (CZPickerView pickerView, NSObject[] rows);

	// @optional -(void)czpickerViewDidClickCancelButton:(CZPickerView *)pickerView;
	[Export ("czpickerViewDidClickCancelButton:")]
	void ViewDidClickCancelButton (CZPickerView pickerView);

	// @optional -(void)czpickerViewWillDisplay:(CZPickerView *)pickerView;
	[Export ("czpickerViewWillDisplay:")]
	void ViewWillDisplay (CZPickerView pickerView);

	// @optional -(void)czpickerViewDidDisplay:(CZPickerView *)pickerView;
	[Export ("czpickerViewDidDisplay:")]
	void ViewDidDisplay (CZPickerView pickerView);

	// @optional -(void)czpickerViewWillDismiss:(CZPickerView *)pickerView;
	[Export ("czpickerViewWillDismiss:")]
	void ViewWillDismiss (CZPickerView pickerView);

	// @optional -(void)czpickerViewDidDismiss:(CZPickerView *)pickerView;
	[Export ("czpickerViewDidDismiss:")]
	void ViewDidDismiss (CZPickerView pickerView);
}

// @interface CZPickerView : UIView <UITableViewDataSource, UITableViewDelegate>
[BaseType (typeof(UIView))]
interface CZPickerView : IUITableViewDataSource, IUITableViewDelegate
{
	// -(id)initWithHeaderTitle:(NSString *)headerTitle cancelButtonTitle:(NSString *)cancelButtonTitle confirmButtonTitle:(NSString *)confirmButtonTitle;
	[Export ("initWithHeaderTitle:cancelButtonTitle:confirmButtonTitle:")]
	IntPtr Constructor (string headerTitle, string cancelButtonTitle, string confirmButtonTitle);

	// -(void)show;
	[Export ("show")]
	void Show ();

	// -(void)showInContainer:(id)container;
	[Export ("showInContainer:")]
	void ShowInContainer (NSObject container);

	// -(void)reloadData;
	[Export ("reloadData")]
	void ReloadData ();

	// -(NSArray *)selectedRows;
	// -(void)setSelectedRows:(NSArray *)rows;
	[Export ("selectedRows")]
	//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
	NSIndexPath[] SelectedRows { get; set; }

	// -(void)unselectAll;
	[Export ("unselectAll")]
	void UnselectAll ();

	[Wrap ("WeakDelegate")]
	CZPickerViewDelegate Delegate { get; set; }

	// @property id<CZPickerViewDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property id<CZPickerViewDataSource> dataSource;
	[Export ("dataSource", ArgumentSemantic.Assign)]
	CZPickerViewDataSource DataSource { get; set; }

	// @property BOOL needFooterView;
	[Export ("needFooterView")]
	bool NeedFooterView { get; set; }

	// @property BOOL tapBackgroundToDismiss;
	[Export ("tapBackgroundToDismiss")]
	bool TapBackgroundToDismiss { get; set; }

	// @property BOOL allowMultipleSelection;
	[Export ("allowMultipleSelection")]
	bool AllowMultipleSelection { get; set; }

	// @property (nonatomic, strong) UIColor * headerBackgroundColor;
	[Export ("headerBackgroundColor", ArgumentSemantic.Strong)]
	UIColor HeaderBackgroundColor { get; set; }

	// @property (nonatomic, strong) UIFont * headerTitleFont;
	[Export ("headerTitleFont", ArgumentSemantic.Strong)]
	UIFont HeaderTitleFont { get; set; }

	// @property (nonatomic, strong) UIColor * headerTitleColor;
	[Export ("headerTitleColor", ArgumentSemantic.Strong)]
	UIColor HeaderTitleColor { get; set; }

	// @property (nonatomic, strong) UIColor * cancelButtonBackgroundColor;
	[Export ("cancelButtonBackgroundColor", ArgumentSemantic.Strong)]
	UIColor CancelButtonBackgroundColor { get; set; }

	// @property (nonatomic, strong) UIColor * cancelButtonNormalColor;
	[Export ("cancelButtonNormalColor", ArgumentSemantic.Strong)]
	UIColor CancelButtonNormalColor { get; set; }

	// @property (nonatomic, strong) UIColor * cancelButtonHighlightedColor;
	[Export ("cancelButtonHighlightedColor", ArgumentSemantic.Strong)]
	UIColor CancelButtonHighlightedColor { get; set; }

	// @property (nonatomic, strong) UIColor * confirmButtonBackgroundColor;
	[Export ("confirmButtonBackgroundColor", ArgumentSemantic.Strong)]
	UIColor ConfirmButtonBackgroundColor { get; set; }

	// @property (nonatomic, strong) UIColor * confirmButtonNormalColor;
	[Export ("confirmButtonNormalColor", ArgumentSemantic.Strong)]
	UIColor ConfirmButtonNormalColor { get; set; }

	// @property (nonatomic, strong) UIColor * confirmButtonHighlightedColor;
	[Export ("confirmButtonHighlightedColor", ArgumentSemantic.Strong)]
	UIColor ConfirmButtonHighlightedColor { get; set; }

	// @property (nonatomic, strong) UIColor * checkmarkColor;
	[Export ("checkmarkColor", ArgumentSemantic.Strong)]
	UIColor CheckmarkColor { get; set; }

	// @property CGFloat animationDuration;
	[Export ("animationDuration")]
	nfloat AnimationDuration { get; set; }

	// @property CGFloat pickerWidth;
	[Export ("pickerWidth")]
	nfloat PickerWidth { get; set; }
}
}