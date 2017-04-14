using ObjCRuntime;

[assembly: LinkWith ("REFormattedNumberField.a", LinkTarget.i386 | LinkTarget.x86_64 | LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true, Frameworks = "UIKit Foundation CoreGraphics", LinkerFlags = "-ObjC")]
