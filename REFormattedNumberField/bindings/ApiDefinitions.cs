using Foundation;
using UIKit;

namespace REFormattedNumberField
{
	// @interface RENumberFormat (NSString)
	[Category]
	[BaseType (typeof(NSString))]
	interface NSString_RENumberFormat
	{
		// -(NSString *)re_stringWithNumberFormat:(NSString *)format;
		[Export ("re_stringWithNumberFormat:")]
		string Re_stringWithNumberFormat (string format);
	}

	// @interface REFormattedNumberField : UITextField
	[BaseType (typeof(UITextField))]
	interface REFormattedNumberField
	{
		// @property (readwrite, copy, nonatomic) NSString * format;
		[Export ("format")]
		string Format { get; set; }

		// @property (readonly, copy, nonatomic) NSString * unformattedText;
		[Export ("unformattedText")]
		string UnformattedText { get; }

		// -(NSString *)string:(NSString *)string withNumberFormat:(NSString *)format __attribute__((deprecated("")));
		[Export ("string:withNumberFormat:")]
		string String (string @string, string format);
	}

}
