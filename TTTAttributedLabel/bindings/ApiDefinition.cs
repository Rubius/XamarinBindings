using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TTTAttributedLabelBindings {

//	[BaseType (typeof (NSObject))]
//	[Internal]
//	[DisableDefaultCtor] // An uncaught exception was raised: *** -range cannot be sent to an abstract object of class NSTextCheckingResult: Create a concrete instance!
//	public interface NSTextCheckingResult {
//		[Export ("resultType")]
//		NSTextCheckingType ResultType { get;  }
//
//		[Export ("range")]
//		NSRange Range { get;  }
//
//	}

	[BaseType (typeof (NSObject))]
	[Protocol]
	[Model]
	public interface TTTAttributedLabelDelegate {

		[Abstract]
		[Export ("attributedLabel:didSelectLinkWithURL:")]
		[EventArgs("TTTAttributedLabelLinkWithURLSelected")]
		void DidSelectLinkWithURL (TTTAttributedLabel label, NSUrl url);

		[Export ("attributedLabel:didSelectLinkWithAddress:")]
		[EventArgs("TTTAttributedLabelLinkWithAddressSelected")]
		void DidSelectLinkWithAddress (TTTAttributedLabel label, NSDictionary addressComponents);

		[Export ("attributedLabel:didSelectLinkWithPhoneNumber:")]
		[EventArgs("TTTAttributedLabelLinkWithPhoneSelected")]
		void DidSelectLinkWithPhoneNumber (TTTAttributedLabel label, string phoneNumber);

		[Export ("attributedLabel:didSelectLinkWithDate:")]
		[EventArgs("TTTAttributedLabelLinkWithDateSelected")]
		void DidSelectLinkWithDate (TTTAttributedLabel label, NSDate date);

		[Export ("attributedLabel:didSelectLinkWithDate:timeZone:duration:")]
		[EventArgs("TTTAttributedLabelLinkWithDateAndTimezoneSelected")]
		void DidSelectLinkWithDateAndTimezone (TTTAttributedLabel label, NSDate date, NSTimeZone timeZone, double duration);

		[Export ("attributedLabel:didSelectLinkWithTransitInformation:")]
		[EventArgs("TTTAttributedLabelLinkWithTransitionSelected")]
		void DidSelectLinkWithTransitInformation (TTTAttributedLabel label, NSDictionary components);

//		[Export ("attributedLabel:didSelectLinkWithTextCheckingResult:")]
//		[EventArgs("TTTAttributedLabelLinkWithCheckingResultSelected")]
//		void DidSelectLinkWithTextCheckingResult (TTTAttributedLabel label, NSTextCheckingResult result);
	}


	[BaseType (typeof (UILabel), Delegates=new [] {"WeakDelegate"}, Events=new [] { typeof (TTTAttributedLabelDelegate) }, Name="TTTAttributedLabel")]
	public interface TTTAttributedLabel  {

		[Wrap ("WeakDelegate")]
		TTTAttributedLabelDelegate Delegate { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Export ("enabledTextCheckingTypes")]
		NSTextCheckingTypes EnabledTextCheckingTypes { get; set; }

//		[Export ("links", ArgumentSemantic.Retain)]
//		NSTextCheckingResult [] Links { get; }

		[Export ("linkAttributes", ArgumentSemantic.Retain)]
		NSDictionary LinkAttributes { get; set; }

		[Export ("activeLinkAttributes", ArgumentSemantic.Retain)]
		NSDictionary ActiveLinkAttributes { get; set; }

		[Export ("shadowRadius")]
		float ShadowRadius { get; set; }

		[Export ("highlightedShadowRadius")]
		float HighlightedShadowRadius { get; set; }
//
		[Export ("highlightedShadowOffset", ArgumentSemantic.Assign)]
		SizeF HighlightedShadowOffset { get; set; }

		[Export ("highlightedShadowColor", ArgumentSemantic.Retain)]
		UIColor HighlightedShadowColor { get; set; }

		[Export ("firstLineIndent")]
		float FirstLineIndent { get; set; }

		[Export ("leading")]
		float Leading { get; set; }

		[Export ("lineHeightMultiple")]
		float LineHeightMultiple { get; set; }

		[Export ("textInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets TextInsets { get; set; }

		[Export ("verticalAlignment")]
		TTTAttributedLabelVerticalAlignment VerticalAlignment { get; set; }

		[Export ("truncationTokenString", ArgumentSemantic.Retain)]
		string TruncationTokenString { get; set; }

		[Export ("truncationTokenStringAttributes", ArgumentSemantic.Retain)]
		NSDictionary TruncationTokenStringAttributes { get; set; }

//		[Export ("text", ArgumentSemantic.Copy)]
//		NSObject Text { get; set; }

		[Export ("setText:afterInheritingLabelAttributesAndConfiguringWithBlock:")]
		void SetText (NSObject text, Action block);
//
//		[Export ("attributedText", ArgumentSemantic.Copy)]
//		override NSAttributedString AttributedText { get; set; }

//		[Export ("addLinkWithTextCheckingResult:")]
//		void AddLinkWithTextCheckingResult (NSTextCheckingResult result);

//		[Export ("addLinkWithTextCheckingResult:attributes:")]
//		void AddLinkWithTextCheckingResult (NSTextCheckingResult result, NSDictionary attributes);

		[Export ("addLinkToURL:withRange:")]
		void AddLinkToURL (NSUrl url, NSRange range);

		[Export ("addLinkToAddress:withRange:")]
		void AddLinkToAddress (NSDictionary addressComponents, NSRange range);

		[Export ("addLinkToPhoneNumber:withRange:")]
		void AddLinkToPhoneNumber (string phoneNumber, NSRange range);

		[Export ("addLinkToDate:withRange:")]
		void AddLinkToDate (NSDate date, NSRange range);

		[Export ("addLinkToDate:timeZone:duration:withRange:")]
		void AddLinkToDate (NSDate date, NSTimeZone timeZone, double duration, NSRange range);

		[Export ("addLinkToTransitInformation:withRange:")]
		void AddLinkToTransitInformation (NSDictionary components, NSRange range);
	}

}
