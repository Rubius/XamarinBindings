using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("TTTAttributedLabel.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true, Frameworks="CoreGraphics CoreText")]
