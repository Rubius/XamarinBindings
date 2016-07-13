using System;
using ObjCRuntime;

[assembly: LinkWith ("libYandexMapKit.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true
                     , Frameworks="CoreGraphics CoreText AudioToolbox OpenAL AVFoundation CoreData CoreLocation CoreTelephony QuartzCore MessageUI OpenGLES Security SystemConfiguration"
                     , LinkerFlags = "-lsqlite3 -lstdc++.6 -lxml2 -lz")]
