using System;
using ObjCRuntime;

[assembly: LinkWith ("ICViewPager.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true, Frameworks="CoreGraphics CoreText")]
