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
	[Register("SHSFlagAccessoryView", true)]
	public unsafe partial class SHSFlagAccessoryView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SHSFlagAccessoryView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SHSFlagAccessoryView () : base (NSObjectFlag.Empty)
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
		public SHSFlagAccessoryView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SHSFlagAccessoryView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SHSFlagAccessoryView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTextField:")]
		[CompilerGenerated]
		public SHSFlagAccessoryView (global::UIKit.UITextField textField)
			: base (NSObjectFlag.Empty)
		{
			if (textField == null)
				throw new ArgumentNullException ("textField");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithTextField:"), textField.Handle), "initWithTextField:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTextField:"), textField.Handle), "initWithTextField:");
			}
		}
		
		[Export ("setImage:")]
		[CompilerGenerated]
		public virtual void SetImage (global::UIKit.UIImage image)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setImage:"), image.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setImage:"), image.Handle);
			}
		}
		
		public partial class SHSFlagAccessoryViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal SHSFlagAccessoryViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new SHSFlagAccessoryViewAppearance Appearance {
			get { return new SHSFlagAccessoryViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new SHSFlagAccessoryViewAppearance GetAppearance<T> () where T: SHSFlagAccessoryView {
			return new SHSFlagAccessoryViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new SHSFlagAccessoryViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new SHSFlagAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new SHSFlagAccessoryViewAppearance GetAppearance (UITraitCollection traits) {
			return new SHSFlagAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new SHSFlagAccessoryViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new SHSFlagAccessoryViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new SHSFlagAccessoryViewAppearance GetAppearance<T> (UITraitCollection traits) where T: SHSFlagAccessoryView {
			return new SHSFlagAccessoryViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new SHSFlagAccessoryViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: SHSFlagAccessoryView{
			return new SHSFlagAccessoryViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class SHSFlagAccessoryView */
}
