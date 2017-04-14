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
	[Register("SHSPhoneNumberFormatter", true)]
	public unsafe partial class SHSPhoneNumberFormatter : NSFormatter {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SHSPhoneNumberFormatter");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SHSPhoneNumberFormatter () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SHSPhoneNumberFormatter (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SHSPhoneNumberFormatter (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SHSPhoneNumberFormatter (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("digitOnlyString:")]
		[CompilerGenerated]
		public virtual string DigitOnlyString (string aString)
		{
			if (aString == null)
				throw new ArgumentNullException ("aString");
			var nsaString = NSString.CreateNative (aString);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("digitOnlyString:"), nsaString));
			} else {
				ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("digitOnlyString:"), nsaString));
			}
			NSString.ReleaseNative (nsaString);
			
			return ret;
		}
		
		[Export ("digitOnlyString:")]
		[CompilerGenerated]
		public static string DigitOnlyStringStatic (string aString)
		{
			if (aString == null)
				throw new ArgumentNullException ("aString");
			var nsaString = NSString.CreateNative (aString);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("digitOnlyString:"), nsaString));
			NSString.ReleaseNative (nsaString);
			
			return ret;
		}
		
		[Export ("formattedRemove:AtIndex:")]
		[CompilerGenerated]
		public static string FormattedRemove (string @string, NSRange range)
		{
			if (@string == null)
				throw new ArgumentNullException ("@string");
			var nsstring = NSString.CreateNative (@string);
			
			string ret;
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_NSRange (class_ptr, Selector.GetHandle ("formattedRemove:AtIndex:"), nsstring, range));
			NSString.ReleaseNative (nsstring);
			
			return ret;
		}
		
		[Export ("isValuableChar:")]
		[CompilerGenerated]
		public static bool IsValuableChar (global::System.UInt16 ch)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UInt16 (class_ptr, Selector.GetHandle ("isValuableChar:"), ch);
		}
		
		[Export ("valuableCharCountIn:")]
		[CompilerGenerated]
		public static global::System.nint ValuableCharCountIn (string @string)
		{
			if (@string == null)
				throw new ArgumentNullException ("@string");
			var nsstring = NSString.CreateNative (@string);
			
			global::System.nint ret;
			ret = global::ApiDefinition.Messaging.nint_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("valuableCharCountIn:"), nsstring);
			NSString.ReleaseNative (nsstring);
			
			return ret;
		}
		
		[Export ("valuesForString:")]
		[CompilerGenerated]
		public virtual NSDictionary ValuesForString (string aString)
		{
			if (aString == null)
				throw new ArgumentNullException ("aString");
			var nsaString = NSString.CreateNative (aString);
			
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("valuesForString:"), nsaString));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("valuesForString:"), nsaString));
			}
			NSString.ReleaseNative (nsaString);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual bool CanAffectLeftViewByFormatter {
			[Export ("canAffectLeftViewByFormatter")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canAffectLeftViewByFormatter"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canAffectLeftViewByFormatter"));
				}
			}
			
			[Export ("setCanAffectLeftViewByFormatter:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCanAffectLeftViewByFormatter:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCanAffectLeftViewByFormatter:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Prefix {
			[Export ("prefix")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("prefix")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("prefix")));
				}
			}
			
			[Export ("setPrefix:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPrefix:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPrefix:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_TextField_var;
		[CompilerGenerated]
		public virtual SHSPhoneTextField TextField {
			[Export ("textField", ArgumentSemantic.Weak)]
			get {
				SHSPhoneTextField ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SHSPhoneTextField> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textField")));
				} else {
					ret =  Runtime.GetNSObject<SHSPhoneTextField> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textField")));
				}
				MarkDirty ();
				__mt_TextField_var = ret;
				return ret;
			}
			
			[Export ("setTextField:", ArgumentSemantic.Weak)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextField:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTextField:"), value.Handle);
				}
				MarkDirty ();
				__mt_TextField_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TextField_var = null;
			}
		}
	} /* class SHSPhoneNumberFormatter */
}
