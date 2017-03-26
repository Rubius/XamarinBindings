using System;
using ObjCRuntime;

[assembly: LinkWith ("MDSpreadView.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.Arm64, ForceLoad = true, Frameworks="CoreGraphics QuartzCore", IsCxx=true)]
