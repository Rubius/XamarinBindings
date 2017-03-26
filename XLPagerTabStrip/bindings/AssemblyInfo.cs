using System;
using ObjCRuntime;

[assembly: LinkWith ("XLPagerTabStrip.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true, Frameworks="CoreGraphics CoreText")]
