using System;
using System.Runtime.InteropServices;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace YandexMapKit {
public enum YMKMapType : uint
{
    Invalid = 0,
    Map = 1,
    Sattelite = 2,
    Wiki = 3,
    Hybrid = 4
}

[StructLayout (LayoutKind.Sequential)]
public struct YMKCoordinateComponents
{
    public short degrees;

    public ushort minutes;

    public float seconds;
}

[StructLayout (LayoutKind.Sequential)]
public struct YMKMapPoint
{
    public long x;

    public long y;
}

[StructLayout (LayoutKind.Sequential)]
public struct YMKMapRegionSize
{
    public double latitudeDelta;

    public double longitudeDelta;
}

[StructLayout (LayoutKind.Sequential)]
public struct YMKMapRegion
{
    public CLLocationCoordinate2D center;

    public YMKMapRegionSize span;
}

[StructLayout (LayoutKind.Sequential)]
public struct YMKMapRect
{
    public CLLocationCoordinate2D topLeft;

    public CLLocationCoordinate2D bottomRight;
}

[StructLayout (LayoutKind.Sequential)]
public struct YMKMapViewPort
{
    public YMKMapRect mapRect;

    public nuint zoomLevel;
}

static class CFunctions
{
    // extern NSString * NSStringFromMapDegrees (double degrees);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSString NSStringFromMapDegrees (double degrees);

    // extern double YMKMapDegreesFromString (NSString *string);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern double YMKMapDegreesFromString (NSString @string);

    // extern CLLocationCoordinate2D YMKMapCoordinateMake (double latitude, double longitude);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern CLLocationCoordinate2D YMKMapCoordinateMake (double latitude, double longitude);

    // extern BOOL YMKMapCoordinateEqualToMapCoordinate (CLLocationCoordinate2D ll1, CLLocationCoordinate2D ll2);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapCoordinateEqualToMapCoordinate (CLLocationCoordinate2D ll1, CLLocationCoordinate2D ll2);

    // extern BOOL YMKMapCoordinateIsZero (CLLocationCoordinate2D ll);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapCoordinateIsZero (CLLocationCoordinate2D ll);

    // extern BOOL YMKMapCoordinateIsValid (CLLocationCoordinate2D ll);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapCoordinateIsValid (CLLocationCoordinate2D ll);

    // extern NSDictionary * NSDictionaryFromMapCoordinate (CLLocationCoordinate2D ll);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSDictionary NSDictionaryFromMapCoordinate (CLLocationCoordinate2D ll);

    // extern CLLocationCoordinate2D YMKMapCoordinateFromDictionary (NSDictionary *dict);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern CLLocationCoordinate2D YMKMapCoordinateFromDictionary (NSDictionary dict);

    // extern NSString * NSStringFromMapCoordinate (CLLocationCoordinate2D ll);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSString NSStringFromMapCoordinate (CLLocationCoordinate2D ll);

    // extern CLLocationCoordinate2D YMKMapCoordinateFromString (NSString *string);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern CLLocationCoordinate2D YMKMapCoordinateFromString (NSString @string);

    // extern NSString * NSHumanReadableStringFromMapCoordinate (CLLocationCoordinate2D ll);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSString NSHumanReadableStringFromMapCoordinate (CLLocationCoordinate2D ll);

    // extern YMKCoordinateComponents YMKCoordinateComponentsFromMapDegrees (double degrees);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKCoordinateComponents YMKCoordinateComponentsFromMapDegrees (double degrees);

    // extern NSString * NSStringFromCoordinateComponents (YMKCoordinateComponents components);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSString NSStringFromCoordinateComponents (YMKCoordinateComponents components);

    // extern YMKMapRegionSize YMKMapRegionSizeMake (double latitudeDelta, double longitudeDelta);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRegionSize YMKMapRegionSizeMake (double latitudeDelta, double longitudeDelta);

    // extern BOOL YMKMapRegionSizeEqualToMapRegionSize (YMKMapRegionSize s1, YMKMapRegionSize s2);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionSizeEqualToMapRegionSize (YMKMapRegionSize s1, YMKMapRegionSize s2);

    // extern BOOL YMKMapRegionSizeIsZero (YMKMapRegionSize size);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionSizeIsZero (YMKMapRegionSize size);

    // extern BOOL YMKMapRegionSizeIsValid (YMKMapRegionSize size);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionSizeIsValid (YMKMapRegionSize size);

    // extern NSDictionary * NSDictionaryFromMapRegionSize (YMKMapRegionSize size);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSDictionary NSDictionaryFromMapRegionSize (YMKMapRegionSize size);

    // extern YMKMapRegionSize YMKMapRegionSizeFromDictionary (NSDictionary *dict);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRegionSize YMKMapRegionSizeFromDictionary (NSDictionary dict);

    // extern YMKMapRegion YMKMapRegionMake (CLLocationCoordinate2D center, YMKMapRegionSize span);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRegion YMKMapRegionMake (CLLocationCoordinate2D center, YMKMapRegionSize span);

    // extern BOOL YMKMapRegionEqualToMapRegion (YMKMapRegion r1, YMKMapRegion r2);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionEqualToMapRegion (YMKMapRegion r1, YMKMapRegion r2);

    // extern BOOL YMKMapRegionIsZero (YMKMapRegion region);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionIsZero (YMKMapRegion region);

    // extern BOOL YMKMapRegionIsValid (YMKMapRegion region);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionIsValid (YMKMapRegion region);

    // extern BOOL YMKMapRegionContainsMapCoordinate (YMKMapRegion region, CLLocationCoordinate2D ll);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionContainsMapCoordinate (YMKMapRegion region, CLLocationCoordinate2D ll);

    // extern BOOL YMKMapRegionContainsMapRegion (YMKMapRegion r1, YMKMapRegion r2);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRegionContainsMapRegion (YMKMapRegion r1, YMKMapRegion r2);

    // extern CLLocationCoordinate2D YMKMapRegionGetTopLeftCoordinate (YMKMapRegion region);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern CLLocationCoordinate2D YMKMapRegionGetTopLeftCoordinate (YMKMapRegion region);

    // extern CLLocationCoordinate2D YMKMapRegionGetBottomRightCoordinate (YMKMapRegion region);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern CLLocationCoordinate2D YMKMapRegionGetBottomRightCoordinate (YMKMapRegion region);

    // extern NSDictionary * NSDictionaryFromMapRegion (YMKMapRegion region);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSDictionary NSDictionaryFromMapRegion (YMKMapRegion region);

    // extern YMKMapRegion YMKMapRegionFromDictionary (NSDictionary *dict);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRegion YMKMapRegionFromDictionary (NSDictionary dict);

    // extern YMKMapRect YMKMapRectFromMapRegion (YMKMapRegion region);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRect YMKMapRectFromMapRegion (YMKMapRegion region);

    // extern YMKMapRect YMKMapRectMake (CLLocationCoordinate2D firstCoordinate, CLLocationCoordinate2D secondCoordinate);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRect YMKMapRectMake (CLLocationCoordinate2D firstCoordinate, CLLocationCoordinate2D secondCoordinate);

    // extern BOOL YMKMapRectEqualToMapRect (YMKMapRect r1, YMKMapRect r2);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRectEqualToMapRect (YMKMapRect r1, YMKMapRect r2);

    // extern BOOL YMKMapRectIsZero (YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRectIsZero (YMKMapRect rect);

    // extern BOOL YMKMapRectIsEmpty (YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRectIsEmpty (YMKMapRect rect);

    // extern BOOL YMKMapRectIsValid (YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRectIsValid (YMKMapRect rect);

    // extern BOOL YMKMapRectContainsMapCoordinate (YMKMapRect rect, CLLocationCoordinate2D ll);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRectContainsMapCoordinate (YMKMapRect rect, CLLocationCoordinate2D ll);

    // extern BOOL YMKMapRectContainsMapRect (YMKMapRect r1, YMKMapRect r2);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRectContainsMapRect (YMKMapRect r1, YMKMapRect r2);

    // extern YMKMapRect YMKMapRectByAddingCoordinate (YMKMapRect rect, CLLocationCoordinate2D coordinate);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRect YMKMapRectByAddingCoordinate (YMKMapRect rect, CLLocationCoordinate2D coordinate);

    // extern BOOL YMKMapRectIntersectsMapRect (YMKMapRect r1, YMKMapRect r2);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapRectIntersectsMapRect (YMKMapRect r1, YMKMapRect r2);

    // extern NSDictionary * NSDictionaryFromMapRect (YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSDictionary NSDictionaryFromMapRect (YMKMapRect rect);

    // extern YMKMapRect YMKMapRectFromDictionary (NSDictionary *dict);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRect YMKMapRectFromDictionary (NSDictionary dict);

    // extern NSString * NSStringFromMapRect (YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSString NSStringFromMapRect (YMKMapRect rect);

    // extern YMKMapRect YMKMapRectFromString (NSString *string);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRect YMKMapRectFromString (NSString @string);

    // extern YMKMapRegion YMKMapRegionFromMapRect (YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRegion YMKMapRegionFromMapRect (YMKMapRect rect);

    // extern YMKMapRect YMKMapRectMakeWithCenterAndMeters (CLLocationCoordinate2D center, long long meters);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRect YMKMapRectMakeWithCenterAndMeters (CLLocationCoordinate2D center, long meters);

    // extern CLLocationCoordinate2D YMKMapRectGetCenterCoordinate (YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern CLLocationCoordinate2D YMKMapRectGetCenterCoordinate (YMKMapRect rect);

    // extern YMKMapRect YMKMapRectNormalize (const YMKMapRect rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapRect YMKMapRectNormalize (YMKMapRect rect);

    // extern YMKMapRect YMKMapRectBoundingCoordinates (NSArray *coordinates);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke), Verify (StronglyTypedNSArray)]
    static extern YMKMapRect YMKMapRectBoundingCoordinates (NSObject[] coordinates);

    // extern YMKMapRect YMKMapRectBoundingAnnotations (NSArray *annotations);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke), Verify (StronglyTypedNSArray)]
    static extern YMKMapRect YMKMapRectBoundingAnnotations (NSObject[] annotations);

    // extern YMKMapViewPort YMKMapViewPortMake (YMKMapRect rect, NSUInteger zoomLevel);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapViewPort YMKMapViewPortMake (YMKMapRect rect, nuint zoomLevel);

    // extern BOOL YMKMapViewPortContainsViewPort (YMKMapViewPort viewPort, YMKMapViewPort subViewPort);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapViewPortContainsViewPort (YMKMapViewPort viewPort, YMKMapViewPort subViewPort);

    // extern BOOL YMKMapViewPortEqualToViewPort (YMKMapViewPort a, YMKMapViewPort b);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapViewPortEqualToViewPort (YMKMapViewPort a, YMKMapViewPort b);

    // extern BOOL YMKMapViewPortIsZero (YMKMapViewPort rect);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapViewPortIsZero (YMKMapViewPort rect);

    // extern BOOL YMKMapViewPortIsValid (YMKMapViewPort viewPort);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern bool YMKMapViewPortIsValid (YMKMapViewPort viewPort);

    // extern NSString * NSStringFromMapViewPort (YMKMapViewPort viewPort);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSString NSStringFromMapViewPort (YMKMapViewPort viewPort);

    // extern YMKMapViewPort YMKMapViewPortFromString (NSString *string);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapViewPort YMKMapViewPortFromString (NSString @string);

    // extern NSDictionary * NSDictionaryFromMapViewPort (YMKMapViewPort viewPort);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern NSDictionary NSDictionaryFromMapViewPort (YMKMapViewPort viewPort);

    // extern YMKMapViewPort YMKMapViewPortFromDictionary (NSDictionary *dict);
    [DllImport ("__Internal")]
    //[Verify (PlatformInvoke)]
    static extern YMKMapViewPort YMKMapViewPortFromDictionary (NSDictionary dict);
}

//[Verify (InferredFromMemberPrefix)]
public enum YMKPinAnnotationColor : uint
{
    Blue = 0,
    Green,
    BlueCommercial
}

[Native]
public enum YMKTrafficInformerColor : ulong
{
    No,
    Red,
    Yellow,
    Green
}
}