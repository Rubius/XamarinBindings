using System;
using Foundation;
using ObjCRuntime;
using UIKit;


namespace SHSPhoneNumber
{
	// @interface SHSFlagAccessoryView : UIView
	[BaseType(typeof(UIView))]
	interface SHSFlagAccessoryView
	{
		// -(id)initWithTextField:(UITextField *)textField;
		[Export("initWithTextField:")]
		IntPtr Constructor(UITextField textField);

		// -(void)setImage:(UIImage *)image;
		[Export("setImage:")]
		void SetImage(UIImage image);
	}

	// @interface SHSPhoneNumberFormatter : NSFormatter
	[BaseType(typeof(NSFormatter))]
	interface SHSPhoneNumberFormatter
	{
		// -(NSDictionary *)valuesForString:(NSString *)aString;
		[Export("valuesForString:")]
		NSDictionary ValuesForString(string aString);

		// +(NSString *)formattedRemove:(NSString *)string AtIndex:(NSRange)range;
		[Static]
		[Export("formattedRemove:AtIndex:")]
		string FormattedRemove(string @string, NSRange range);

		// +(BOOL)isValuableChar:(unichar)ch;
		[Static]
		[Export("isValuableChar:")]
		bool IsValuableChar(ushort ch);

		// +(NSInteger)valuableCharCountIn:(NSString *)string;
		[Static]
		[Export("valuableCharCountIn:")]
		nint ValuableCharCountIn(string @string);

		// @property (readwrite) BOOL canAffectLeftViewByFormatter;
		[Export("canAffectLeftViewByFormatter")]
		bool CanAffectLeftViewByFormatter { get; set; }

		// @property (copy, nonatomic) NSString * prefix;
		[Export("prefix")]
		string Prefix { get; set; }

		// @property (weak) SHSPhoneTextField * textField;
		[Export("textField", ArgumentSemantic.Weak)]
		SHSPhoneTextField TextField { get; set; }

		// +(NSString *)digitOnlyString:(NSString *)aString;
		[Static]
		[Export("digitOnlyString:")]
		string DigitOnlyStringStatic(string aString);

		// -(NSString *)digitOnlyString:(NSString *)aString;
		[Export("digitOnlyString:")]
		string DigitOnlyString(string aString);
	}

	// @interface SHSPhoneLogic : NSObject <UITextFieldDelegate>
	[BaseType(typeof(NSObject))]
	interface SHSPhoneLogic : IUITextFieldDelegate
	{
		// +(BOOL)logicTextField:(SHSPhoneTextField *)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString *)string;
		[Static]
		[Export("logicTextField:shouldChangeCharactersInRange:replacementString:")]
		bool LogicTextField(SHSPhoneTextField textField, NSRange range, string @string);

		// +(void)applyFormat:(SHSPhoneTextField *)textField forText:(NSString *)text;
		[Static]
		[Export("applyFormat:forText:")]
		void ApplyFormat(SHSPhoneTextField textField, string text);

		[Wrap("WeakDelegate")]
		UITextFieldDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UITextFieldDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface UserConfig (SHSPhoneNumberFormatter)
	[Category]
	[BaseType(typeof(SHSPhoneNumberFormatter))]
	interface SHSPhoneNumberFormatter_UserConfig
	{
		// -(void)resetDefaultFormat;
		[Export("resetDefaultFormat")]
		void ResetDefaultFormat();

		// -(void)resetFormats;
		[Export("resetFormats")]
		void ResetFormats();

		// -(void)setDefaultOutputPattern:(NSString *)pattern imagePath:(NSString *)imagePath;
		[Export("setDefaultOutputPattern:imagePath:")]
		void SetDefaultOutputPattern(string pattern, string imagePath);

		// -(void)setDefaultOutputPattern:(NSString *)pattern;
		[Export("setDefaultOutputPattern:")]
		void SetDefaultOutputPattern(string pattern);

		// -(void)addOutputPattern:(NSString *)pattern forRegExp:(NSString *)regexp imagePath:(NSString *)imagePath;
		[Export("addOutputPattern:forRegExp:imagePath:")]
		void AddOutputPattern(string pattern, string regexp, string imagePath);

		// -(void)addOutputPattern:(NSString *)pattern forRegExp:(NSString *)regexp;
		[Export("addOutputPattern:forRegExp:")]
		void AddOutputPattern(string pattern, string regexp);


	}

	// @interface SHSPhoneTextField : UITextField
	[BaseType(typeof(UITextField))]
	interface SHSPhoneTextField
	{
		// @property (readonly, strong) SHSPhoneNumberFormatter * formatter;
		[Export("formatter", ArgumentSemantic.Strong)]
		SHSPhoneNumberFormatter Formatter { get; }

		// -(void)setFormattedText:(NSString *)text;
		[Export("setFormattedText:")]
		void SetFormattedText(string text);

		// -(NSString *)phoneNumber;
		[Export("phoneNumber")]
		string PhoneNumber { get; }

		// -(NSString *)phoneNumberWithoutPrefix;
		[Export("phoneNumberWithoutPrefix")]
		string PhoneNumberWithoutPrefix { get; }

		// @property (copy, nonatomic) SHSTextBlock textDidChangeBlock;
		//[Export("textDidChangeBlock", ArgumentSemantic.Copy)]
		//SHSTextBlock TextDidChangeBlock { get; set; }
	}

	// typedef void (^SHSTextBlock)(UITextField *);
	//delegate void SHSTextBlock(UITextField arg0);
}