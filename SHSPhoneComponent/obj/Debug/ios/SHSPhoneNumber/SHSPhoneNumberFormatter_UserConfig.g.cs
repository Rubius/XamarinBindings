//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace SHSPhoneNumber {
	public unsafe static partial class SHSPhoneNumberFormatter_UserConfig  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SHSPhoneNumberFormatter");
		
		[Export ("addOutputPattern:forRegExp:imagePath:")]
		[CompilerGenerated]
		public static void AddOutputPattern (this SHSPhoneNumberFormatter This, string pattern, string regexp, string imagePath)
		{
			if (pattern == null)
				throw new ArgumentNullException ("pattern");
			if (regexp == null)
				throw new ArgumentNullException ("regexp");
			if (imagePath == null)
				throw new ArgumentNullException ("imagePath");
			var nspattern = NSString.CreateNative (pattern);
			var nsregexp = NSString.CreateNative (regexp);
			var nsimagePath = NSString.CreateNative (imagePath);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("addOutputPattern:forRegExp:imagePath:"), nspattern, nsregexp, nsimagePath);
			NSString.ReleaseNative (nspattern);
			NSString.ReleaseNative (nsregexp);
			NSString.ReleaseNative (nsimagePath);
			
		}
		
		[Export ("addOutputPattern:forRegExp:")]
		[CompilerGenerated]
		public static void AddOutputPattern (this SHSPhoneNumberFormatter This, string pattern, string regexp)
		{
			if (pattern == null)
				throw new ArgumentNullException ("pattern");
			if (regexp == null)
				throw new ArgumentNullException ("regexp");
			var nspattern = NSString.CreateNative (pattern);
			var nsregexp = NSString.CreateNative (regexp);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("addOutputPattern:forRegExp:"), nspattern, nsregexp);
			NSString.ReleaseNative (nspattern);
			NSString.ReleaseNative (nsregexp);
			
		}
		
		[Export ("resetDefaultFormat")]
		[CompilerGenerated]
		public static void ResetDefaultFormat (this SHSPhoneNumberFormatter This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetDefaultFormat"));
		}
		
		[Export ("resetFormats")]
		[CompilerGenerated]
		public static void ResetFormats (this SHSPhoneNumberFormatter This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetFormats"));
		}
		
		[Export ("setDefaultOutputPattern:imagePath:")]
		[CompilerGenerated]
		public static void SetDefaultOutputPattern (this SHSPhoneNumberFormatter This, string pattern, string imagePath)
		{
			if (pattern == null)
				throw new ArgumentNullException ("pattern");
			if (imagePath == null)
				throw new ArgumentNullException ("imagePath");
			var nspattern = NSString.CreateNative (pattern);
			var nsimagePath = NSString.CreateNative (imagePath);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("setDefaultOutputPattern:imagePath:"), nspattern, nsimagePath);
			NSString.ReleaseNative (nspattern);
			NSString.ReleaseNative (nsimagePath);
			
		}
		
		[Export ("setDefaultOutputPattern:")]
		[CompilerGenerated]
		public static void SetDefaultOutputPattern (this SHSPhoneNumberFormatter This, string pattern)
		{
			if (pattern == null)
				throw new ArgumentNullException ("pattern");
			var nspattern = NSString.CreateNative (pattern);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setDefaultOutputPattern:"), nspattern);
			NSString.ReleaseNative (nspattern);
			
		}
		
	} /* class SHSPhoneNumberFormatter_UserConfig */
}
