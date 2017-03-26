using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace ICViewPager {
// @interface ViewPagerController : UIViewController
[BaseType (typeof(UIViewController))]
interface ViewPagerController
{
	// @property (weak) id<ViewPagerDataSource> dataSource;
	[Export ("dataSource", ArgumentSemantic.Weak)]
	ViewPagerDataSource DataSource { get; set; }

	[Wrap ("WeakDelegate")]
	ViewPagerDelegate Delegate { get; set; }

	// @property (weak) id<ViewPagerDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// -(void)reloadData;
	[Export ("reloadData")]
	void ReloadData ();

	// -(void)selectTabAtIndex:(NSUInteger)index;
	[Export ("selectTabAtIndex:")]
	void SelectTabAtIndex (nuint index);

	// -(void)setNeedsReloadOptions;
	[Export ("setNeedsReloadOptions")]
	void SetNeedsReloadOptions ();

	// -(void)setNeedsReloadColors;
	[Export ("setNeedsReloadColors")]
	void SetNeedsReloadColors ();

	// -(CGFloat)valueForOption:(ViewPagerOption)option;
	[Export ("valueForOption:")]
	nfloat ValueForOption (ViewPagerOption option);

	// -(UIColor *)colorForComponent:(ViewPagerComponent)component;
	[Export ("colorForComponent:")]
	UIColor ColorForComponent (ViewPagerComponent component);
}

// @protocol ViewPagerDataSource <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ViewPagerDataSource
{
	// @required -(NSUInteger)numberOfTabsForViewPager:(ViewPagerController *)viewPager;
	[Abstract]
	[Export ("numberOfTabsForViewPager:")]
	nuint NumberOfTabsForViewPager (ViewPagerController viewPager);

	// @required -(UIView *)viewPager:(ViewPagerController *)viewPager viewForTabAtIndex:(NSUInteger)index;
	[Abstract]
	[Export ("viewPager:viewForTabAtIndex:")]
	UIView ViewForTabAtIndex (ViewPagerController viewPager, nuint index);

	// @optional -(UIViewController *)viewPager:(ViewPagerController *)viewPager contentViewControllerForTabAtIndex:(NSUInteger)index;
	[Export ("viewPager:contentViewControllerForTabAtIndex:")]
	UIViewController ContentViewControllerForTabAtIndex (ViewPagerController viewPager, nuint index);

	// @optional -(UIView *)viewPager:(ViewPagerController *)viewPager contentViewForTabAtIndex:(NSUInteger)index;
	[Export ("viewPager:contentViewForTabAtIndex:")]
	UIView ContentViewForTabAtIndex (ViewPagerController viewPager, nuint index);
}

// @protocol ViewPagerDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface ViewPagerDelegate
{
	// @optional -(void)viewPager:(ViewPagerController *)viewPager didChangeTabToIndex:(NSUInteger)index;
	[Export ("viewPager:didChangeTabToIndex:")]
	void DidChangeTabToIndex (ViewPagerController viewPager, nuint index);

	// @optional -(void)viewPager:(ViewPagerController *)viewPager didChangeTabToIndex:(NSUInteger)index fromIndex:(NSUInteger)previousIndex;
	[Export ("viewPager:didChangeTabToIndex:fromIndex:")]
	void DidChangeTabToIndexFromIndex (ViewPagerController viewPager, nuint index, nuint previousIndex);

	// @optional -(void)viewPager:(ViewPagerController *)viewPager didChangeTabToIndex:(NSUInteger)index fromIndex:(NSUInteger)previousIndex didSwipe:(BOOL)didSwipe;
	[Export ("viewPager:didChangeTabToIndex:fromIndex:didSwipe:")]
	void DidChangeTabToIndexFromIndexDidSwipe (ViewPagerController viewPager, nuint index, nuint previousIndex, bool didSwipe);

	// @optional -(CGFloat)viewPager:(ViewPagerController *)viewPager valueForOption:(ViewPagerOption)option withDefault:(CGFloat)value;
	[Export ("viewPager:valueForOption:withDefault:")]
	nfloat ValueForOption (ViewPagerController viewPager, ViewPagerOption option, nfloat value);

	// @optional -(UIColor *)viewPager:(ViewPagerController *)viewPager colorForComponent:(ViewPagerComponent)component withDefault:(UIColor *)color;
	[Export ("viewPager:colorForComponent:withDefault:")]
	UIColor ColorForComponent (ViewPagerController viewPager, ViewPagerComponent component, UIColor color);
}
}