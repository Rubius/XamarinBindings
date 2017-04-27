using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
namespace MLPAutoCompleteTextFieldBinding
{
	// @protocol MLPAutoCompleteTextFieldDataSource <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MLPAutoCompleteTextFieldDataSource
	{
		// @optional -(void)autoCompleteTextField:(MLPAutoCompleteTextField *)textField possibleCompletionsForString:(NSString *)string completionHandler:(void (^)(NSArray *))handler;
		[Export("autoCompleteTextField:possibleCompletionsForString:completionHandler:")]
		void AutoCompleteTextField(MLPAutoCompleteTextField textField, string @string, Action<NSArray> handler);

		// @optional -(NSArray *)autoCompleteTextField:(MLPAutoCompleteTextField *)textField possibleCompletionsForString:(NSString *)string;
		[Export("autoCompleteTextField:possibleCompletionsForString:")]
		//[Verify (StronglyTypedNSArray)]
		NSObject[] AutoCompleteTextField(MLPAutoCompleteTextField textField, string @string);
	}

	// @protocol MLPAutoCompletionObject <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MLPAutoCompletionObject
	{
		// @required -(NSString *)autocompleteString;
		[Abstract]
		[Export("autocompleteString")]
		//[Verify (MethodToProperty)]
		string AutocompleteString { get; }
	}

	// @protocol MLPAutoCompleteTextFieldDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MLPAutoCompleteTextFieldDelegate
	{
		// @optional -(BOOL)autoCompleteTextField:(MLPAutoCompleteTextField *)textField shouldStyleAutoCompleteTableView:(UITableView *)autoCompleteTableView forBorderStyle:(UITextBorderStyle)borderStyle;
		[Export("autoCompleteTextField:shouldStyleAutoCompleteTableView:forBorderStyle:")]
		bool AutoCompleteTextField(MLPAutoCompleteTextField textField, UITableView autoCompleteTableView, UITextBorderStyle borderStyle);

		// @optional -(BOOL)autoCompleteTextField:(MLPAutoCompleteTextField *)textField shouldConfigureCell:(UITableViewCell *)cell withAutoCompleteString:(NSString *)autocompleteString withAttributedString:(NSAttributedString *)boldedString forAutoCompleteObject:(id<MLPAutoCompletionObject>)autocompleteObject forRowAtIndexPath:(NSIndexPath *)indexPath;
		[Export("autoCompleteTextField:shouldConfigureCell:withAutoCompleteString:withAttributedString:forAutoCompleteObject:forRowAtIndexPath:")]
		bool AutoCompleteTextField(MLPAutoCompleteTextField textField, UITableViewCell cell, string autocompleteString, NSAttributedString boldedString, MLPAutoCompletionObject autocompleteObject, NSIndexPath indexPath);

		// @optional -(void)autoCompleteTextField:(MLPAutoCompleteTextField *)textField didSelectAutoCompleteString:(NSString *)selectedString withAutoCompleteObject:(id<MLPAutoCompletionObject>)selectedObject forRowAtIndexPath:(NSIndexPath *)indexPath;
		[Export("autoCompleteTextField:didSelectAutoCompleteString:withAutoCompleteObject:forRowAtIndexPath:")]
		void AutoCompleteTextField(MLPAutoCompleteTextField textField, string selectedString, MLPAutoCompletionObject selectedObject, NSIndexPath indexPath);

		// @optional -(void)autoCompleteTextField:(MLPAutoCompleteTextField *)textField willShowAutoCompleteTableView:(UITableView *)autoCompleteTableView;
		[Export("autoCompleteTextField:willShowAutoCompleteTableView:")]
		void AutoCompleteTextField(MLPAutoCompleteTextField textField, UITableView autoCompleteTableView);
	}

	// @protocol MLPAutoCompleteSortOperationDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MLPAutoCompleteSortOperationDelegate
	{
		// @required -(void)autoCompleteTermsDidSort:(NSArray *)completions;
		[Abstract]
		[Export("autoCompleteTermsDidSort:")]
		//[Verify(StronglyTypedNSArray)]
		void AutoCompleteTermsDidSort(NSObject[] completions);
	}

	// @protocol MLPAutoCompleteFetchOperationDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface MLPAutoCompleteFetchOperationDelegate
	{
		// @required -(void)autoCompleteTermsDidFetch:(NSDictionary *)fetchInfo;
		[Abstract]
		[Export("autoCompleteTermsDidFetch:")]
		void AutoCompleteTermsDidFetch(NSDictionary fetchInfo);
	}

	// @interface MLPAutoCompleteTextField : UITextField <UITableViewDataSource, UITableViewDelegate, MLPAutoCompleteSortOperationDelegate, MLPAutoCompleteFetchOperationDelegate>
	[BaseType(typeof(UITextField))]
	interface MLPAutoCompleteTextField : IUITableViewDataSource, IUITableViewDelegate
	{
		// @property (readonly, strong) UITableView * autoCompleteTableView;
		[Export("autoCompleteTableView", ArgumentSemantic.Strong)]
		UITableView AutoCompleteTableView { get; }

		// @property (strong) id<MLPAutoCompleteTextFieldDataSource> autoCompleteDataSource __attribute__((iboutlet));
		[Export("autoCompleteDataSource", ArgumentSemantic.Strong)]
		MLPAutoCompleteTextFieldDataSource AutoCompleteDataSource { get; set; }

		[Wrap("WeakAutoCompleteDelegate")]
		MLPAutoCompleteTextFieldDelegate AutoCompleteDelegate { get; set; }

		[Export("stopObservingKeyPathsAndNotifications")]
		void StopObservingKeyPathsAndNotifications();

		// @property (weak) id<MLPAutoCompleteTextFieldDelegate> autoCompleteDelegate __attribute__((iboutlet));
		[NullAllowed, Export("autoCompleteDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAutoCompleteDelegate { get; set; }

		// @property (assign) NSTimeInterval autoCompleteFetchRequestDelay;
		[Export("autoCompleteFetchRequestDelay")]
		double AutoCompleteFetchRequestDelay { get; set; }

		// @property (assign) BOOL sortAutoCompleteSuggestionsByClosestMatch;
		[Export("sortAutoCompleteSuggestionsByClosestMatch")]
		bool SortAutoCompleteSuggestionsByClosestMatch { get; set; }

		// @property (assign) BOOL applyBoldEffectToAutoCompleteSuggestions;
		[Export("applyBoldEffectToAutoCompleteSuggestions")]
		bool ApplyBoldEffectToAutoCompleteSuggestions { get; set; }

		// @property (assign) BOOL reverseAutoCompleteSuggestionsBoldEffect;
		[Export("reverseAutoCompleteSuggestionsBoldEffect")]
		bool ReverseAutoCompleteSuggestionsBoldEffect { get; set; }

		// @property (assign) BOOL showTextFieldDropShadowWhenAutoCompleteTableIsOpen;
		[Export("showTextFieldDropShadowWhenAutoCompleteTableIsOpen")]
		bool ShowTextFieldDropShadowWhenAutoCompleteTableIsOpen { get; set; }

		// @property (assign) BOOL showAutoCompleteTableWhenEditingBegins;
		[Export("showAutoCompleteTableWhenEditingBegins")]
		bool ShowAutoCompleteTableWhenEditingBegins { get; set; }

		// @property (assign) BOOL disableAutoCompleteTableUserInteractionWhileFetching;
		[Export("disableAutoCompleteTableUserInteractionWhileFetching")]
		bool DisableAutoCompleteTableUserInteractionWhileFetching { get; set; }

		// @property (assign) BOOL autoCompleteTableAppearsAsKeyboardAccessory;
		[Export("autoCompleteTableAppearsAsKeyboardAccessory")]
		bool AutoCompleteTableAppearsAsKeyboardAccessory { get; set; }

		// @property (assign) BOOL autoCompleteTableViewHidden;
		[Export("autoCompleteTableViewHidden")]
		bool AutoCompleteTableViewHidden { get; set; }

		// @property (assign) CGFloat autoCompleteFontSize;
		[Export("autoCompleteFontSize")]
		nfloat AutoCompleteFontSize { get; set; }

		// @property (strong) NSString * autoCompleteBoldFontName;
		[Export("autoCompleteBoldFontName", ArgumentSemantic.Strong)]
		string AutoCompleteBoldFontName { get; set; }

		// @property (strong) NSString * autoCompleteRegularFontName;
		[Export("autoCompleteRegularFontName", ArgumentSemantic.Strong)]
		string AutoCompleteRegularFontName { get; set; }

		// @property (assign) NSInteger maximumNumberOfAutoCompleteRows;
		[Export("maximumNumberOfAutoCompleteRows")]
		nint MaximumNumberOfAutoCompleteRows { get; set; }

		// @property (assign) CGFloat autoCompleteRowHeight;
		[Export("autoCompleteRowHeight")]
		nfloat AutoCompleteRowHeight { get; set; }

		// @property (assign) CGSize autoCompleteTableOriginOffset;
		[Export("autoCompleteTableOriginOffset", ArgumentSemantic.Assign)]
		CGSize AutoCompleteTableOriginOffset { get; set; }

		// @property (assign) CGFloat autoCompleteTableCornerRadius;
		[Export("autoCompleteTableCornerRadius")]
		nfloat AutoCompleteTableCornerRadius { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets autoCompleteContentInsets;
		[Export("autoCompleteContentInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets AutoCompleteContentInsets { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets autoCompleteScrollIndicatorInsets;
		[Export("autoCompleteScrollIndicatorInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets AutoCompleteScrollIndicatorInsets { get; set; }

		// @property (nonatomic, strong) UIColor * autoCompleteTableBorderColor;
		[Export("autoCompleteTableBorderColor", ArgumentSemantic.Strong)]
		UIColor AutoCompleteTableBorderColor { get; set; }

		// @property (assign, nonatomic) CGFloat autoCompleteTableBorderWidth;
		[Export("autoCompleteTableBorderWidth")]
		nfloat AutoCompleteTableBorderWidth { get; set; }

		// @property (nonatomic, strong) UIColor * autoCompleteTableBackgroundColor;
		[Export("autoCompleteTableBackgroundColor", ArgumentSemantic.Strong)]
		UIColor AutoCompleteTableBackgroundColor { get; set; }

		// @property (strong) UIColor * autoCompleteTableCellBackgroundColor;
		[Export("autoCompleteTableCellBackgroundColor", ArgumentSemantic.Strong)]
		UIColor AutoCompleteTableCellBackgroundColor { get; set; }

		// @property (strong) UIColor * autoCompleteTableCellTextColor;
		[Export("autoCompleteTableCellTextColor", ArgumentSemantic.Strong)]
		UIColor AutoCompleteTableCellTextColor { get; set; }

		// -(void)registerAutoCompleteCellNib:(UINib *)nib forCellReuseIdentifier:(NSString *)reuseIdentifier;
		[Export("registerAutoCompleteCellNib:forCellReuseIdentifier:")]
		void RegisterAutoCompleteCellNib(UINib nib, string reuseIdentifier);

		// -(void)registerAutoCompleteCellClass:(Class)cellClass forCellReuseIdentifier:(NSString *)reuseIdentifier;
		[Export("registerAutoCompleteCellClass:forCellReuseIdentifier:")]
		void RegisterAutoCompleteCellClass(Class cellClass, string reuseIdentifier);
	}

	// @interface Levenshtein (NSString)
	[Category]
	[BaseType(typeof(NSString))]
	interface NSString_Levenshtein
	{
		// -(float)asciiLevenshteinDistanceWithString:(NSString *)stringB;
		[Export("asciiLevenshteinDistanceWithString:")]
		float AsciiLevenshteinDistanceWithString(string stringB);

		// -(float)asciiLevenshteinDistanceWithString:(NSString *)stringB skippingCharacterSet:(NSCharacterSet *)charset;
		[Export("asciiLevenshteinDistanceWithString:skippingCharacterSet:")]
		float AsciiLevenshteinDistanceWithString(string stringB, NSCharacterSet charset);
	}

}