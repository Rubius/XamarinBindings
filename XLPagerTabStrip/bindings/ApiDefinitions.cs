using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace XLPagerTabStrip {
// @interface XLBarView : UIView
[BaseType (typeof(UIView))]
interface XLBarView
{
	// @property (readonly, nonatomic) UIView * selectedBar;
	[Export ("selectedBar")]
	UIView SelectedBar { get; }

	// -(id)initWithFrame:(CGRect)frame optionsAmount:(NSUInteger)optionsAmount selectedOptionIndex:(NSUInteger)selectedOptionIndex;
	[Export ("initWithFrame:optionsAmount:selectedOptionIndex:")]
	IntPtr Constructor (CGRect frame, nuint optionsAmount, nuint selectedOptionIndex);

	// -(void)moveToIndex:(NSUInteger)index animated:(BOOL)animated;
	[Export ("moveToIndex:animated:")]
	void MoveToIndex (nuint index, bool animated);

	// -(void)moveFromIndex:(NSInteger)fromIndex toIndex:(NSInteger)toIndex withProgressPercentage:(CGFloat)progressPercentage;
	[Export ("moveFromIndex:toIndex:withProgressPercentage:")]
	void MoveFromIndex (nint fromIndex, nint toIndex, nfloat progressPercentage);

	// -(void)setOptionsAmount:(NSUInteger)optionsAmount animated:(BOOL)animated;
	[Export ("setOptionsAmount:animated:")]
	void SetOptionsAmount (nuint optionsAmount, bool animated);
}

[BaseType (typeof(UIViewController))]
interface XLPagerTabStripChildItemViewController : XLPagerTabStripChildItem {
}

// @protocol XLPagerTabStripChildItem <NSObject>
[Protocol, Model]
//[BaseType (typeof(NSObject))]
interface XLPagerTabStripChildItem
{
	// @required -(NSString *)titleForPagerTabStripViewController:(XLPagerTabStripViewController *)pagerTabStripViewController;
	[Abstract]
	[Export ("titleForPagerTabStripViewController:")]
	string TitleForPagerTabStripViewController (XLPagerTabStripViewController pagerTabStripViewController);

	// @optional -(UIImage *)imageForPagerTabStripViewController:(XLPagerTabStripViewController *)pagerTabStripViewController;
	[Export ("imageForPagerTabStripViewController:")]
	UIImage ImageForPagerTabStripViewController (XLPagerTabStripViewController pagerTabStripViewController);

	// @optional -(UIColor *)colorForPagerTabStripViewController:(XLPagerTabStripViewController *)pagerTabStripViewController;
	[Export ("colorForPagerTabStripViewController:")]
	UIColor ColorForPagerTabStripViewController (XLPagerTabStripViewController pagerTabStripViewController);
}

// @protocol XLPagerTabStripViewControllerDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface XLPagerTabStripViewControllerDelegate
{
	// @optional -(void)pagerTabStripViewController:(XLPagerTabStripViewController *)pagerTabStripViewController updateIndicatorFromIndex:(NSInteger)fromIndex toIndex:(NSInteger)toIndex;
	[Export ("pagerTabStripViewController:updateIndicatorFromIndex:toIndex:")]
	void UpdateIndicatorFromIndex (XLPagerTabStripViewController pagerTabStripViewController, nint fromIndex, nint toIndex);

	// @optional -(void)pagerTabStripViewController:(XLPagerTabStripViewController *)pagerTabStripViewController updateIndicatorFromIndex:(NSInteger)fromIndex toIndex:(NSInteger)toIndex withProgressPercentage:(CGFloat)progressPercentage indexWasChanged:(BOOL)indexWasChanged;
	[Export ("pagerTabStripViewController:updateIndicatorFromIndex:toIndex:withProgressPercentage:indexWasChanged:")]
	void UpdateIndicatorFromIndex (XLPagerTabStripViewController pagerTabStripViewController, nint fromIndex, nint toIndex, nfloat progressPercentage, bool indexWasChanged);
}

// @protocol XLPagerTabStripViewControllerDataSource <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface XLPagerTabStripViewControllerDataSource
{
	// @required -(NSArray *)childViewControllersForPagerTabStripViewController:(XLPagerTabStripViewController *)pagerTabStripViewController;
	[Abstract]
	[Export ("childViewControllersForPagerTabStripViewController:")]
	//[Verify (StronglyTypedNSArray)]
	UIViewController[] ChildViewControllersForPagerTabStripViewController (XLPagerTabStripViewController pagerTabStripViewController);
}

// @interface XLPagerTabStripViewController : UIViewController <XLPagerTabStripViewControllerDelegate, XLPagerTabStripViewControllerDataSource, UIScrollViewDelegate>
[BaseType (typeof(UIViewController))]
interface XLPagerTabStripViewController : XLPagerTabStripViewControllerDelegate, XLPagerTabStripViewControllerDataSource, IUIScrollViewDelegate
{
	// @property (readonly) NSArray * pagerTabStripChildViewControllers;
	[Export ("pagerTabStripChildViewControllers")]
	//[Verify (StronglyTypedNSArray)]
	UIViewController[] PagerTabStripChildViewControllers { get; }

	// @property (retain, nonatomic) UIScrollView * containerView;
	[Export ("containerView", ArgumentSemantic.Retain)]
	UIScrollView ContainerView { get; set; }

	[Wrap ("WeakDelegate")]
	XLPagerTabStripViewControllerDelegate Delegate { get; set; }

	// @property (assign, nonatomic) id<XLPagerTabStripViewControllerDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (assign, nonatomic) id<XLPagerTabStripViewControllerDataSource> dataSource;
	[Export ("dataSource", ArgumentSemantic.Assign)]
	XLPagerTabStripViewControllerDataSource DataSource { get; set; }

	// @property (readonly) NSUInteger currentIndex;
	[Export ("currentIndex")]
	nuint CurrentIndex { get; }

	// @property BOOL skipIntermediateViewControllers;
	[Export ("skipIntermediateViewControllers")]
	bool SkipIntermediateViewControllers { get; set; }

	// @property BOOL isProgressiveIndicator;
	[Export ("isProgressiveIndicator")]
	bool IsProgressiveIndicator { get; set; }

	// @property BOOL isElasticIndicatorLimit;
	[Export ("isElasticIndicatorLimit")]
	bool IsElasticIndicatorLimit { get; set; }

	// -(void)moveToViewControllerAtIndex:(NSUInteger)index;
	[Export ("moveToViewControllerAtIndex:")]
	void MoveToViewControllerAtIndex (nuint index);

	// -(void)moveToViewControllerAtIndex:(NSUInteger)index animated:(_Bool)animated;
	[Export ("moveToViewControllerAtIndex:animated:")]
	void MoveToViewControllerAtIndex (nuint index, bool animated);

	// -(void)moveToViewController:(UIViewController *)viewController;
	[Export ("moveToViewController:")]
	void MoveToViewController (UIViewController viewController);

	// -(void)moveToViewController:(UIViewController *)viewController animated:(_Bool)animated;
	[Export ("moveToViewController:animated:")]
	void MoveToViewController (UIViewController viewController, bool animated);

	// -(void)reloadPagerTabStripView;
	[Export ("reloadPagerTabStripView")]
	void ReloadPagerTabStripView ();
}

// @interface XLBarPagerTabStripViewController : XLPagerTabStripViewController
[BaseType (typeof(XLPagerTabStripViewController))]
interface XLBarPagerTabStripViewController
{
	// @property (nonatomic) XLBarView * barView;
	[Export ("barView", ArgumentSemantic.Assign)]
	XLBarView BarView { get; set; }
}

// @interface XLButtonBarView : UICollectionView
[BaseType (typeof(UICollectionView))]
interface XLButtonBarView
{
	// @property (readonly, nonatomic) UIView * selectedBar;
	[Export ("selectedBar")]
	UIView SelectedBar { get; }

	// @property UIFont * labelFont;
	[Export ("labelFont", ArgumentSemantic.Assign)]
	UIFont LabelFont { get; set; }

	// @property NSUInteger leftRightMargin;
	[Export ("leftRightMargin", ArgumentSemantic.Assign)]
	nuint LeftRightMargin { get; set; }

	// -(void)moveToIndex:(NSUInteger)index animated:(BOOL)animated swipeDirection:(XLPagerTabStripDirection)swipeDirection;
	[Export ("moveToIndex:animated:swipeDirection:")]
	void MoveToIndex (nuint index, bool animated, XLPagerTabStripDirection swipeDirection);

	// -(void)moveFromIndex:(NSInteger)fromIndex toIndex:(NSInteger)toIndex withProgressPercentage:(CGFloat)progressPercentage;
	[Export ("moveFromIndex:toIndex:withProgressPercentage:")]
	void MoveFromIndex (nint fromIndex, nint toIndex, nfloat progressPercentage);
}

// @interface XLButtonBarViewCell : UICollectionViewCell
[BaseType (typeof(UICollectionViewCell))]
interface XLButtonBarViewCell
{
	// @property (readonly, nonatomic) UIImageView * imageView;
	[Export ("imageView")]
	UIImageView ImageView { get; }

	// @property (readonly, nonatomic) UILabel * label;
	[Export ("label")]
	UILabel Label { get; }
}

// @interface XLButtonBarPagerTabStripViewController : XLPagerTabStripViewController
[BaseType (typeof(XLPagerTabStripViewController))]
interface XLButtonBarPagerTabStripViewController
{
	// @property (copy) void (^changeCurrentIndexProgressiveBlock)(XLButtonBarViewCell *XLButtonBarViewCell *CGFloatBOOLBOOL);
	[Export ("changeCurrentIndexProgressiveBlock", ArgumentSemantic.Copy)]
	Action<XLButtonBarViewCell, XLButtonBarViewCell, nfloat, bool, bool> ChangeCurrentIndexProgressiveBlock { get; set; }

	// @property (copy) void (^changeCurrentIndexBlock)(XLButtonBarViewCell *XLButtonBarViewCell *BOOL);
	[Export ("changeCurrentIndexBlock", ArgumentSemantic.Copy)]
	Action<XLButtonBarViewCell, XLButtonBarViewCell, bool> ChangeCurrentIndexBlock { get; set; }

	// @property (readonly, nonatomic) XLButtonBarView * buttonBarView;
	[Export ("buttonBarView")]
	XLButtonBarView ButtonBarView { get; }
}

// @interface XLSegmentedPagerTabStripViewController : XLPagerTabStripViewController
[BaseType (typeof(XLPagerTabStripViewController))]
interface XLSegmentedPagerTabStripViewController
{
	// @property (readonly, nonatomic) UISegmentedControl * segmentedControl;
	[Export ("segmentedControl")]
	UISegmentedControl SegmentedControl { get; }
}

// @interface XLTwitterPagerTabStripViewController : XLPagerTabStripViewController
[BaseType (typeof(XLPagerTabStripViewController))]
interface XLTwitterPagerTabStripViewController
{
	// @property (readonly, nonatomic) UIView * navigationView;
	[Export ("navigationView")]
	UIView NavigationView { get; }

	// @property (nonatomic) UIFont * landscapeTitleFont;
	[Export ("landscapeTitleFont", ArgumentSemantic.Assign)]
	UIFont LandscapeTitleFont { get; set; }

	// @property (nonatomic) UIFont * portraitTitleFont;
	[Export ("portraitTitleFont", ArgumentSemantic.Assign)]
	UIFont PortraitTitleFont { get; set; }
}
	/*
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGPathRef FXPageControlDotShapeCircle;
	[Field ("FXPageControlDotShapeCircle")]
	unsafe CGPathRef* FXPageControlDotShapeCircle { get; }

	// extern const CGPathRef FXPageControlDotShapeSquare;
	[Field ("FXPageControlDotShapeSquare")]
	unsafe CGPathRef* FXPageControlDotShapeSquare { get; }

	// extern const CGPathRef FXPageControlDotShapeTriangle;
	[Field ("FXPageControlDotShapeTriangle")]
	unsafe CGPathRef* FXPageControlDotShapeTriangle { get; }
}
*/
// @interface FXPageControl : UIControl
[BaseType (typeof(UIControl))]
interface FXPageControl
{
	// -(void)setUp;
	[Export ("setUp")]
	void SetUp ();

	// -(CGSize)sizeForNumberOfPages:(NSInteger)pageCount;
	[Export ("sizeForNumberOfPages:")]
	CGSize SizeForNumberOfPages (nint pageCount);

	// -(void)updateCurrentPageDisplay;
	[Export ("updateCurrentPageDisplay")]
	void UpdateCurrentPageDisplay ();

	[Wrap ("WeakDelegate")]
	FXPageControlDelegate Delegate { get; set; }

	// @property (nonatomic, unsafe_unretained) id<FXPageControlDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
	NSObject WeakDelegate { get; set; }

	// @property (assign, nonatomic) NSInteger currentPage;
	[Export ("currentPage", ArgumentSemantic.Assign)]
	nint CurrentPage { get; set; }

	// @property (assign, nonatomic) NSInteger numberOfPages;
	[Export ("numberOfPages", ArgumentSemantic.Assign)]
	nint NumberOfPages { get; set; }

	// @property (assign, nonatomic) BOOL defersCurrentPageDisplay;
	[Export ("defersCurrentPageDisplay")]
	bool DefersCurrentPageDisplay { get; set; }

	// @property (assign, nonatomic) BOOL hidesForSinglePage;
	[Export ("hidesForSinglePage")]
	bool HidesForSinglePage { get; set; }

	// @property (getter = isWrapEnabled, assign, nonatomic) BOOL wrapEnabled;
	[Export ("wrapEnabled")]
	bool WrapEnabled { [Bind ("isWrapEnabled")] get; set; }

	// @property (getter = isVertical, assign, nonatomic) BOOL vertical;
	[Export ("vertical")]
	bool Vertical { [Bind ("isVertical")] get; set; }

	// @property (nonatomic, strong) UIImage * dotImage;
	[Export ("dotImage", ArgumentSemantic.Strong)]
	UIImage DotImage { get; set; }

		/*
	// @property (assign, nonatomic) CGPathRef dotShape;
	[Export ("dotShape", ArgumentSemantic.Assign)]
	unsafe CGPathRef* DotShape { get; set; }
		*/
	// @property (assign, nonatomic) CGFloat dotSize;
	[Export ("dotSize", ArgumentSemantic.Assign)]
	nfloat DotSize { get; set; }

	// @property (nonatomic, strong) UIColor * dotColor;
	[Export ("dotColor", ArgumentSemantic.Strong)]
	UIColor DotColor { get; set; }

	// @property (nonatomic, strong) UIColor * dotShadowColor;
	[Export ("dotShadowColor", ArgumentSemantic.Strong)]
	UIColor DotShadowColor { get; set; }

	// @property (assign, nonatomic) CGFloat dotShadowBlur;
	[Export ("dotShadowBlur", ArgumentSemantic.Assign)]
	nfloat DotShadowBlur { get; set; }

	// @property (assign, nonatomic) CGSize dotShadowOffset;
	[Export ("dotShadowOffset", ArgumentSemantic.Assign)]
	CGSize DotShadowOffset { get; set; }

	// @property (nonatomic, strong) UIImage * selectedDotImage;
	[Export ("selectedDotImage", ArgumentSemantic.Strong)]
	UIImage SelectedDotImage { get; set; }

		/*
	// @property (assign, nonatomic) CGPathRef selectedDotShape;
	[Export ("selectedDotShape", ArgumentSemantic.Assign)]
	unsafe CGPathRef* SelectedDotShape { get; set; }
		*/

	// @property (assign, nonatomic) CGFloat selectedDotSize;
	[Export ("selectedDotSize", ArgumentSemantic.Assign)]
	nfloat SelectedDotSize { get; set; }

	// @property (nonatomic, strong) UIColor * selectedDotColor;
	[Export ("selectedDotColor", ArgumentSemantic.Strong)]
	UIColor SelectedDotColor { get; set; }

	// @property (nonatomic, strong) UIColor * selectedDotShadowColor;
	[Export ("selectedDotShadowColor", ArgumentSemantic.Strong)]
	UIColor SelectedDotShadowColor { get; set; }

	// @property (assign, nonatomic) CGFloat selectedDotShadowBlur;
	[Export ("selectedDotShadowBlur", ArgumentSemantic.Assign)]
	nfloat SelectedDotShadowBlur { get; set; }

	// @property (assign, nonatomic) CGSize selectedDotShadowOffset;
	[Export ("selectedDotShadowOffset", ArgumentSemantic.Assign)]
	CGSize SelectedDotShadowOffset { get; set; }

	// @property (assign, nonatomic) CGFloat dotSpacing;
	[Export ("dotSpacing", ArgumentSemantic.Assign)]
	nfloat DotSpacing { get; set; }
}

// @protocol FXPageControlDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface FXPageControlDelegate
{
	// @optional -(UIImage *)pageControl:(FXPageControl *)pageControl imageForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:imageForDotAtIndex:")]
	UIImage ImageForDotAtIndex (FXPageControl pageControl, nint index);

	/*// @optional -(CGPathRef)pageControl:(FXPageControl *)pageControl shapeForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:shapeForDotAtIndex:")]
	unsafe CGPathRef* PageControl (FXPageControl pageControl, nint index);
*/
	// @optional -(UIColor *)pageControl:(FXPageControl *)pageControl colorForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:colorForDotAtIndex:")]
	UIColor ColorForDotAtIndex (FXPageControl pageControl, nint index);

	// @optional -(UIImage *)pageControl:(FXPageControl *)pageControl selectedImageForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:selectedImageForDotAtIndex:")]
	UIImage SelectedImageForDotAtIndex (FXPageControl pageControl, nint index);

	/*// @optional -(CGPathRef)pageControl:(FXPageControl *)pageControl selectedShapeForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:selectedShapeForDotAtIndex:")]
	unsafe CGPathRef* PageControl (FXPageControl pageControl, nint index);
*/
	// @optional -(UIColor *)pageControl:(FXPageControl *)pageControl selectedColorForDotAtIndex:(NSInteger)index;
	[Export ("pageControl:selectedColorForDotAtIndex:")]
	UIColor SelectedColorForDotAtIndex (FXPageControl pageControl, nint index);
}

}