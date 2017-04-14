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
	[Register("SHSPhoneTextField", true)]
	public unsafe partial class SHSPhoneTextField : global::UIKit.UITextField {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SHSPhoneTextField");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SHSPhoneTextField () : base (NSObjectFlag.Empty)
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
		public SHSPhoneTextField (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SHSPhoneTextField (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SHSPhoneTextField (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setFormattedText:")]
		[CompilerGenerated]
		public virtual void SetFormattedText (string text)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = NSString.CreateNative (text);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFormattedText:"), nstext);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFormattedText:"), nstext);
			}
			NSString.ReleaseNative (nstext);
			
		}
		
		[CompilerGenerated]
		public virtual SHSPhoneNumberFormatter Formatter {
			[Export ("formatter", ArgumentSemantic.Retain)]
			get {
				SHSPhoneNumberFormatter ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SHSPhoneNumberFormatter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("formatter")));
				} else {
					ret =  Runtime.GetNSObject<SHSPhoneNumberFormatter> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("formatter")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PhoneNumber {
			[Export ("phoneNumber")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("phoneNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("phoneNumber")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string PhoneNumberWithoutPrefix {
			[Export ("phoneNumberWithoutPrefix")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("phoneNumberWithoutPrefix")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("phoneNumberWithoutPrefix")));
				}
			}
			
		}
		
		public partial class SHSPhoneTextFieldAppearance : global::UIKit.UITextField.UITextFieldAppearance {
			protected internal SHSPhoneTextFieldAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new SHSPhoneTextFieldAppearance Appearance {
			get { return new SHSPhoneTextFieldAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new SHSPhoneTextFieldAppearance GetAppearance<T> () where T: SHSPhoneTextField {
			return new SHSPhoneTextFieldAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new SHSPhoneTextFieldAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new SHSPhoneTextFieldAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new SHSPhoneTextFieldAppearance GetAppearance (UITraitCollection traits) {
			return new SHSPhoneTextFieldAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new SHSPhoneTextFieldAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new SHSPhoneTextFieldAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new SHSPhoneTextFieldAppearance GetAppearance<T> (UITraitCollection traits) where T: SHSPhoneTextField {
			return new SHSPhoneTextFieldAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new SHSPhoneTextFieldAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: SHSPhoneTextField{
			return new SHSPhoneTextFieldAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class SHSPhoneTextField */
}
