using System;
using CoreGraphics;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace YandexMapKit {
    
[Static]
//[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
    // extern const double kYMKMapStructsComparisonAccuracy;
    [Field ("kYMKMapStructsComparisonAccuracy", "__Internal")]
    double kYMKMapStructsComparisonAccuracy { get; }

    // extern const double kYMKMapStructsCoordinateLatitudeMinValue;
    [Field ("kYMKMapStructsCoordinateLatitudeMinValue", "__Internal")]
    double kYMKMapStructsCoordinateLatitudeMinValue { get; }

    // extern const double kYMKMapStructsCoordinateLatitudeMaxValue;
    [Field ("kYMKMapStructsCoordinateLatitudeMaxValue", "__Internal")]
    double kYMKMapStructsCoordinateLatitudeMaxValue { get; }

    // extern const double kYMKMapStructsCoordinateLongitudeMinValue;
    [Field ("kYMKMapStructsCoordinateLongitudeMinValue", "__Internal")]
    double kYMKMapStructsCoordinateLongitudeMinValue { get; }

    // extern const double kYMKMapStructsCoordinateLongitudeMaxValue;
    [Field ("kYMKMapStructsCoordinateLongitudeMaxValue", "__Internal")]
    double kYMKMapStructsCoordinateLongitudeMaxValue { get; }

    // extern const double kYMKMapRegionSizeDeltaLatitudeMinValue;
    [Field ("kYMKMapRegionSizeDeltaLatitudeMinValue", "__Internal")]
    double kYMKMapRegionSizeDeltaLatitudeMinValue { get; }

    // extern const double kYMKMapRegionSizeDeltaLatitudeMaxValue;
    [Field ("kYMKMapRegionSizeDeltaLatitudeMaxValue", "__Internal")]
    double kYMKMapRegionSizeDeltaLatitudeMaxValue { get; }

    // extern const double kYMKMapRegionSizeDeltaLongitudeMinValue;
    [Field ("kYMKMapRegionSizeDeltaLongitudeMinValue", "__Internal")]
    double kYMKMapRegionSizeDeltaLongitudeMinValue { get; }

    // extern const double kYMKMapRegionSizeDeltaLongitudeMaxValue;
    [Field ("kYMKMapRegionSizeDeltaLongitudeMaxValue", "__Internal")]
    double kYMKMapRegionSizeDeltaLongitudeMaxValue { get; }

    // extern const double YMKMapDegreesInvalid;
    [Field ("YMKMapDegreesInvalid", "__Internal")]
    double YMKMapDegreesInvalid { get; }
}

//[Static]
//[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
    // extern const CLLocationCoordinate2D CLLocationCoordinate2DZero;
    //[Field ("CLLocationCoordinate2DZero", "__Internal")]
    //CLLocationCoordinate2D CLLocationCoordinate2DZero { get; }

    // extern const CLLocationCoordinate2D CLLocationCoordinate2DInvalid;
    //[Field ("CLLocationCoordinate2DInvalid", "__Internal")]
    //CLLocationCoordinate2D CLLocationCoordinate2DInvalid { get; }

    // extern const YMKMapRegionSize YMKMapRegionSizeZero;
    //[Field ("YMKMapRegionSizeZero", "__Internal")]
    //YMKMapRegionSize YMKMapRegionSizeZero { get; }

    // extern const YMKMapRegionSize YMKMapRegionSizeInvalid;
    //[Field ("YMKMapRegionSizeInvalid", "__Internal")]
    //YMKMapRegionSize YMKMapRegionSizeInvalid { get; }

    // extern const YMKMapRegionSize YMKMapRegionSizeEarth;
    //[Field ("YMKMapRegionSizeEarth", "__Internal")]
    //YMKMapRegionSize YMKMapRegionSizeEarth { get; }
}

// @interface CLLocationCoordinate2D (NSValue)
[Category]
[BaseType (typeof(NSValue))]
interface NSValue_CLLocationCoordinate2D
{
    // +(NSValue *)valueWithCLLocationCoordinate2D:(CLLocationCoordinate2D)coordinate;
    [Static]
    [Export ("valueWithCLLocationCoordinate2D:")]
    NSValue ValueWithCLLocationCoordinate2D (CLLocationCoordinate2D coordinate);

    // -(CLLocationCoordinate2D)CLLocationCoordinate2DValue;
    [Export ("CLLocationCoordinate2DValue")]
    [Static]
    //[Verify (MethodToProperty)]
    CLLocationCoordinate2D CLLocationCoordinate2DValue { get; }
}

// @protocol YMKGeoObject <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface YMKGeoObject
{
    // @required -(CLLocationCoordinate2D)coordinate;
    //[Abstract]
    [Export ("coordinate")]
    //[Verify (MethodToProperty)]
    CLLocationCoordinate2D Coordinate { get; }
}

// @protocol YMKAnnotation <YMKGeoObject>
[Protocol, Model]
[BaseType(typeof(YMKGeoObject))]
interface YMKAnnotation
{
    // @optional -(NSString *)title;
    [Export ("title")]
    //[Verify (MethodToProperty)]
    string Title { get; }

    // @optional -(NSString *)subtitle;
    [Export ("subtitle")]
    //[Verify (MethodToProperty)]
    string Subtitle { get; }
}

// @interface YMKAnnotationImage : NSObject
[BaseType (typeof(NSObject))]
interface YMKAnnotationImage
{
    // +(instancetype)annotationImageWithImage:(UIImage *)image highlightedImage:(UIImage *)highlightedImage centerOffset:(CGPoint)centerOffset;
    [Static]
    [Export ("annotationImageWithImage:highlightedImage:centerOffset:")]
    YMKAnnotationImage AnnotationImageWithImage (UIImage image, UIImage highlightedImage, CGPoint centerOffset);

    // +(instancetype)annotationImageWithImage:(UIImage *)image centerOffset:(CGPoint)centerOffset;
    [Static]
    [Export ("annotationImageWithImage:centerOffset:")]
    YMKAnnotationImage AnnotationImageWithImage (UIImage image, CGPoint centerOffset);

    // -(instancetype)initWithImage:(UIImage *)image highlightedImage:(UIImage *)highlightedImage centerOffset:(CGPoint)centerOffset;
    [Export ("initWithImage:highlightedImage:centerOffset:")]
    IntPtr Constructor (UIImage image, UIImage highlightedImage, CGPoint centerOffset);

    // +(instancetype)blueAnnotationImage;
    [Static]
    [Export ("blueAnnotationImage")]
    YMKAnnotationImage BlueAnnotationImage ();

    // +(instancetype)greenAnnotationImage;
    [Static]
    [Export ("greenAnnotationImage")]
    YMKAnnotationImage GreenAnnotationImage ();

    // @property (assign, nonatomic) CGPoint centerOffset;
    [Export ("centerOffset", ArgumentSemantic.Assign)]
    CGPoint CenterOffset { get; set; }

    // @property (retain, nonatomic) UIImage * image;
    [Export ("image", ArgumentSemantic.Retain)]
    UIImage Image { get; set; }

    // @property (retain, nonatomic) UIImage * highlightedImage;
    [Export ("highlightedImage", ArgumentSemantic.Retain)]
    UIImage HighlightedImage { get; set; }
}

// @interface YMKAnnotationView : UIView
[BaseType (typeof(UIView))]
interface YMKAnnotationView
{
    // @property (readonly, nonatomic) NSString * reuseIdentifier;
    [Export ("reuseIdentifier")]
    string ReuseIdentifier { get; }

    // @property (retain, nonatomic) NSObject<YMKAnnotation> * annotation;
    [Export ("annotation", ArgumentSemantic.Retain)]
    YMKAnnotation Annotation { get; set; }

    // @property (nonatomic) CGPoint centerOffset;
    [Export ("centerOffset", ArgumentSemantic.Assign)]
    CGPoint CenterOffset { get; set; }

    // @property (getter = isSelected, nonatomic) BOOL selected;
    [Export ("selected")]
    bool Selected { [Bind ("isSelected")] get; set; }

    // @property (retain, nonatomic) UIImage * image;
    [Export ("image", ArgumentSemantic.Retain)]
    UIImage Image { get; set; }

    // @property (nonatomic, strong) UIImage * selectedImage;
    [Export ("selectedImage", ArgumentSemantic.Strong)]
    UIImage SelectedImage { get; set; }

    // @property (assign, nonatomic) BOOL alignCenter;
    [Export ("alignCenter")]
    bool AlignCenter { get; set; }

    // @property (assign, nonatomic) NSInteger zIndex;
    [Export ("zIndex")]
    nint ZIndex { get; set; }

    // @property (assign, nonatomic) BOOL canShowCallout;
    [Export ("canShowCallout")]
    bool CanShowCallout { get; set; }

    // @property (assign, nonatomic) CGPoint calloutOffset;
    [Export ("calloutOffset", ArgumentSemantic.Assign)]
    CGPoint CalloutOffset { get; set; }

    // @property (readonly, nonatomic) UIEdgeInsets minimumMargins;
    [Export ("minimumMargins")]
    UIEdgeInsets MinimumMargins { get; }

    // @property (readonly, nonatomic) YMKCalloutView * visibleCalloutView;
    [Export ("visibleCalloutView")]
    YMKCalloutView VisibleCalloutView { get; }

    // -(id)initWithAnnotation:(NSObject<YMKAnnotation> *)annotation reuseIdentifier:(NSString *)reuseIdentifier;
    [Export ("initWithAnnotation:reuseIdentifier:")]
    IntPtr Constructor (YMKAnnotation annotation, string reuseIdentifier);

    // -(void)prepareForReuse;
    [Export ("prepareForReuse")]
    void PrepareForReuse ();

    // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
    [Export ("setSelected:animated:")]
    void SetSelected (bool selected, bool animated);
}

// @protocol YMKCalloutContentView <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface YMKCalloutContentView
{
    // @optional -(void)setHighlighted:(BOOL)highlighted;
    [Export ("setHighlighted:")]
    void SetHighlighted (bool highlighted);
}

// @protocol YMKCalloutViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface YMKCalloutViewDelegate
{
    // @optional -(void)calloutViewGotSingleTap:(YMKCalloutView *)view;
    [Export ("calloutViewGotSingleTap:")]
    void CalloutViewGotSingleTap (YMKCalloutView view);

    // @optional -(void)calloutViewGotTapAtLeftAccessoryView:(YMKCalloutView *)view;
    [Export ("calloutViewGotTapAtLeftAccessoryView:")]
    void CalloutViewGotTapAtLeftAccessoryView (YMKCalloutView view);

    // @optional -(void)calloutViewGotTapAtRightAccessoryView:(YMKCalloutView *)view;
    [Export ("calloutViewGotTapAtRightAccessoryView:")]
    void CalloutViewGotTapAtRightAccessoryView (YMKCalloutView view);
}

// @interface YMKCalloutView : UIView
[BaseType (typeof(UIView))]
interface YMKCalloutView
{
    // -(id)initWithReuseIdentifier:(NSString *)reuseIdentifier;
    [Export ("initWithReuseIdentifier:")]
    IntPtr Constructor (string reuseIdentifier);

    [Wrap ("WeakDelegate")]
    YMKCalloutViewDelegate Delegate { get; set; }

    // @property (assign, nonatomic) id<YMKCalloutViewDelegate> delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
    NSObject WeakDelegate { get; set; }

    // @property (retain, nonatomic) UIView * leftView;
    [Export ("leftView", ArgumentSemantic.Retain)]
    UIView LeftView { get; set; }

    // -(void)setLeftView:(UIView *)leftView animated:(BOOL)animated;
    [Export ("setLeftView:animated:")]
    void SetLeftView (UIView leftView, bool animated);

    // @property (retain, nonatomic) UIView * rightView;
    [Export ("rightView", ArgumentSemantic.Retain)]
    UIView RightView { get; set; }

    // -(void)setRightView:(UIView *)rightView animated:(BOOL)animated;
    [Export ("setRightView:animated:")]
    void SetRightView (UIView rightView, bool animated);

    // @property (retain, nonatomic) UIView<YMKCalloutContentView> * contentView;
    [Export ("contentView", ArgumentSemantic.Retain)]
    YMKCalloutContentView ContentView { get; set; }

    // @property (readonly, assign, nonatomic) BOOL highlighted;
    [Export ("highlighted")]
    bool Highlighted { get; }

    // @property (readonly, getter = isHidden, assign, nonatomic) BOOL hidden;
    //[Export ("hidden")]
    //bool Hidden { [Bind ("isHidden")] get; }

    // +(UIView *)defaultDisclosureIndicatorView;
    [Static]
    [Export ("defaultDisclosureIndicatorView")]
    ////[Verify (MethodToProperty)]
    UIView DefaultDisclosureIndicatorView { get; }

    // -(void)setAnchorPoint:(CGPoint)point boundaryRect:(CGRect)rect;
    [Export ("setAnchorPoint:boundaryRect:")]
    void SetAnchorPoint (CGPoint point, CGRect rect);

    // -(void)hide;
    [Export ("hide")]
    void Hide ();

    // @property (readonly, copy, nonatomic) NSString * reuseIdentifier;
    [Export ("reuseIdentifier")]
    string ReuseIdentifier { get; }

    // -(void)prepareForReuse;
    [Export ("prepareForReuse")]
    void PrepareForReuse ();

    // -(void)showAtAnnotationView:(YMKAnnotationView *)annotationView;
    [Export ("showAtAnnotationView:")]
    void ShowAtAnnotationView (YMKAnnotationView annotationView);

    // -(void)showAtAnnotationView:(YMKAnnotationView *)annotationView animated:(BOOL)animated;
    [Export ("showAtAnnotationView:animated:")]
    void ShowAtAnnotationView (YMKAnnotationView annotationView, bool animated);

    // -(CGSize)sizeWithContentView:(UIView *)contentView leftView:(UIView *)leftView rightView:(UIView *)rightView boundaryRect:(CGRect)rect;
    [Export ("sizeWithContentView:leftView:rightView:boundaryRect:")]
    CGSize SizeWithContentView (UIView contentView, UIView leftView, UIView rightView, CGRect rect);
}

// @interface YMKConfiguration : NSObject
[BaseType (typeof(NSObject))]
interface YMKConfiguration
{
    // @property (readonly, retain, nonatomic) YMKMapLayersConfiguration * mapLayers;
    [Export ("mapLayers", ArgumentSemantic.Retain)]
    YMKMapLayersConfiguration MapLayers { get; }

    // @property (copy, nonatomic) NSString * apiKey;
    [Export ("apiKey")]
    string ApiKey { get; set; }

    // @property (assign, nonatomic) BOOL useNewBundle;
    [Export ("useNewBundle")]
    bool UseNewBundle { get; set; }

    // +(YMKConfiguration *)sharedInstance;
    [Static]
    [Export ("sharedInstance")]
    //[Verify (MethodToProperty)]
    YMKConfiguration SharedInstance { get; }
}

//[Static]
//[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
    // extern BOOL YMKConsoleLoggingEnabled;
    [Field ("YMKConsoleLoggingEnabled", "__Internal")]
    int YMKConsoleLoggingEnabled { get; }
}

// @interface YMKDefaultCalloutView : YMKCalloutView
[BaseType (typeof(YMKCalloutView))]
interface YMKDefaultCalloutView
{
    // @property (nonatomic, strong) id<YMKAnnotation> annotation;
    [Export ("annotation", ArgumentSemantic.Strong)]
    YMKAnnotation Annotation { get; set; }
}

// @protocol YMKDraggableAnnotation <YMKAnnotation>
[Protocol, Model]
    [BaseType(typeof(YMKAnnotation))]
interface YMKDraggableAnnotation
{
    // @required -(void)setCoordinate:(CLLocationCoordinate2D)coordinate;
    [Abstract]
    [Export ("setCoordinate:")]
    void SetCoordinate (CLLocationCoordinate2D coordinate);
}

// @interface YMKPinAnnotationView : YMKAnnotationView
[BaseType (typeof(YMKAnnotationView))]
interface YMKPinAnnotationView
{
    // @property (assign, nonatomic) BOOL animatesDrop;
    [Export ("animatesDrop")]
    bool AnimatesDrop { get; set; }

    // @property (assign, nonatomic) YMKPinAnnotationColor pinColor;
    [Export ("pinColor")]
    nuint PinColor { get; set; }
}

// @protocol YMKDraggablePinAnnotationViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface YMKDraggablePinAnnotationViewDelegate
{
    // @optional -(void)draggablePinAnnotationViewDidStartInteraction:(YMKDraggablePinAnnotationView *)view;
    [Export ("draggablePinAnnotationViewDidStartInteraction:")]
    void DraggablePinAnnotationViewDidStartInteraction (YMKDraggablePinAnnotationView view);

    // @optional -(void)draggablePinAnnotationViewDidStartMoving:(YMKDraggablePinAnnotationView *)view;
    [Export ("draggablePinAnnotationViewDidStartMoving:")]
    void DraggablePinAnnotationViewDidStartMoving (YMKDraggablePinAnnotationView view);

    // @optional -(void)draggablePinAnnotationViewDidEndMoving:(YMKDraggablePinAnnotationView *)view;
    [Export ("draggablePinAnnotationViewDidEndMoving:")]
    void DraggablePinAnnotationViewDidEndMoving (YMKDraggablePinAnnotationView view);
}

// @interface YMKDraggablePinAnnotationView : YMKPinAnnotationView
[BaseType (typeof(YMKPinAnnotationView))]
interface YMKDraggablePinAnnotationView
{
    // @property (readonly, getter = isMoving, nonatomic) BOOL moving;
    [Export ("moving")]
    bool Moving { [Bind ("isMoving")] get; }

    [Wrap ("WeakDelegate")]
    YMKDraggablePinAnnotationViewDelegate Delegate { get; set; }

    // @property (assign, nonatomic) id<YMKDraggablePinAnnotationViewDelegate> delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
    NSObject WeakDelegate { get; set; }

    // -(id)initWithAnnotation:(id<YMKDraggableAnnotation>)annotation reuseIdentifier:(NSString *)reuseIdentifier;
    [Export ("initWithAnnotation:reuseIdentifier:")]
    IntPtr Constructor (YMKDraggableAnnotation annotation, string reuseIdentifier);
}

// @protocol YMKLocationFetcherDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface YMKLocationFetcherDelegate
{
    // @required -(void)locationFetcherDidFetchUserLocation:(YMKLocationFetcher *)locationFetcher;
    [Abstract]
    [Export ("locationFetcherDidFetchUserLocation:")]
    void LocationFetcherDidFetchUserLocation (YMKLocationFetcher locationFetcher);

    // @required -(void)locationFetcher:(YMKLocationFetcher *)locationFetcher didFailWithError:(NSError *)error;
    [Abstract]
    [Export ("locationFetcher:didFailWithError:")]
    void LocationFetcher (YMKLocationFetcher locationFetcher, NSError error);
}

// @interface YMKLocationFetcher : NSObject
[BaseType (typeof(NSObject))]
interface YMKLocationFetcher
{
    // @property (retain, nonatomic) YMKMapView * mapView __attribute__((iboutlet));
    [Export ("mapView", ArgumentSemantic.Retain)]
    YMKMapView MapView { get; set; }

    [Wrap ("WeakDelegate")]
    YMKLocationFetcherDelegate Delegate { get; set; }

    // @property (assign, nonatomic) id<YMKLocationFetcherDelegate> delegate __attribute__((iboutlet));
    [NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
    NSObject WeakDelegate { get; set; }

    // @property (getter = isFetchingLocation, assign, nonatomic) BOOL fetchingLocation;
    [Export ("fetchingLocation")]
    bool FetchingLocation { [Bind ("isFetchingLocation")] get; set; }

    // -(void)acquireUserLocationFromMapView;
    [Export ("acquireUserLocationFromMapView")]
    void AcquireUserLocationFromMapView ();
}

// @protocol YMKMapImageBuilderDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface YMKMapImageBuilderDelegate
{
    // @optional -(YMKAnnotationImage *)mapImageBuilder:(YMKMapImageBuilder *)builder annotationImageForAnnotation:(id<YMKAnnotation>)annotation;
    [Export ("mapImageBuilder:annotationImageForAnnotation:")]
    YMKAnnotationImage MapImageBuilder (YMKMapImageBuilder builder, YMKAnnotation annotation);

    // @optional -(void)mapImageBuilder:(YMKMapImageBuilder *)builder builtImage:(UIImage *)image;
    [Export ("mapImageBuilder:builtImage:")]
    void MapImageBuilder (YMKMapImageBuilder builder, UIImage image);

    // @optional -(void)mapImageBuilderFailedToLoadCompleteImage:(YMKMapImageBuilder *)builder partialImage:(UIImage *)image;
    [Export ("mapImageBuilderFailedToLoadCompleteImage:partialImage:")]
    void MapImageBuilderFailedToLoadCompleteImage (YMKMapImageBuilder builder, UIImage image);

    // @optional -(void)mapImageBuilderWasCancelled:(YMKMapImageBuilder *)builder;
    [Export ("mapImageBuilderWasCancelled:")]
    void MapImageBuilderWasCancelled (YMKMapImageBuilder builder);
}

// @interface YMKMapImageBuilder : NSObject
[BaseType (typeof(NSObject))]
interface YMKMapImageBuilder
{
    [Wrap ("WeakDelegate")]
    YMKMapImageBuilderDelegate Delegate { get; set; }

    // @property (assign, nonatomic) id<YMKMapImageBuilderDelegate> delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) CLLocationCoordinate2D centerCoordinate;
    [Export ("centerCoordinate", ArgumentSemantic.Assign)]
    CLLocationCoordinate2D CenterCoordinate { get; set; }

    // @property (assign, nonatomic) CGPoint centerOffset;
    [Export ("centerOffset", ArgumentSemantic.Assign)]
    CGPoint CenterOffset { get; set; }

    // @property (assign, nonatomic) NSUInteger zoomLevel;
    [Export ("zoomLevel")]
    nuint ZoomLevel { get; set; }

    // @property (assign, nonatomic) uint16_t layerIdentifier;
    [Export ("layerIdentifier")]
    ushort LayerIdentifier { get; set; }

    // @property (assign, nonatomic) CGSize imageSize;
    [Export ("imageSize", ArgumentSemantic.Assign)]
    CGSize ImageSize { get; set; }

    // @property (retain, nonatomic) UIColor * failedImageBgColor;
    [Export ("failedImageBgColor", ArgumentSemantic.Retain)]
    UIColor FailedImageBgColor { get; set; }

    // @property (copy, nonatomic) NSArray * annotations;
    [Export ("annotations", ArgumentSemantic.Copy)]
    //[Verify (StronglyTypedNSArray)]
    NSObject[] Annotations { get; set; }

    // -(instancetype)initWithAnnotation:(id<YMKAnnotation>)annotation;
    [Export ("initWithAnnotation:")]
    IntPtr Constructor (YMKAnnotation annotation);

    // -(instancetype)initWithAnnotations:(NSArray *)annotations;
    [Export ("initWithAnnotations:")]
    //[Verify (StronglyTypedNSArray)]
    IntPtr Constructor (NSObject[] annotations);

    // -(void)build;
    [Export ("build")]
    void Build ();

    // -(void)cancel;
    [Export ("cancel")]
    void Cancel ();
}

// @interface YMKMapLayerInfo : NSObject
[BaseType (typeof(NSObject))]
interface YMKMapLayerInfo
{
    // @property (assign, nonatomic) uint16_t identifier;
    [Export ("identifier")]
    ushort Identifier { get; set; }

    // @property (copy, nonatomic) NSString * localizedName;
    [Export ("localizedName")]
    string LocalizedName { get; set; }

    // @property (assign, nonatomic) BOOL auxiliary;
    [Export ("auxiliary")]
    bool Auxiliary { get; set; }

    // @property (assign, nonatomic) uint16_t sizeInPixels;
    [Export ("sizeInPixels")]
    ushort SizeInPixels { get; set; }

    // @property (assign, nonatomic) BOOL allowsNightMode;
    [Export ("allowsNightMode")]
    bool AllowsNightMode { get; set; }
}

// @interface YMKMapLayersConfiguration : NSObject
[BaseType (typeof(NSObject))]
interface YMKMapLayersConfiguration
{
    // @property (readonly, nonatomic) NSArray * infos;
    [Export ("infos")]
    //[Verify (StronglyTypedNSArray)]
    NSObject[] Infos { get; }

    // @property (readonly, nonatomic) BOOL hasServiceLayer;
    [Export ("hasServiceLayer")]
    bool HasServiceLayer { get; }

    // @property (readonly, nonatomic) YMKMapLayerInfo * serviceLayerInfo;
    [Export ("serviceLayerInfo")]
    YMKMapLayerInfo ServiceLayerInfo { get; }

    // -(YMKMapLayerInfo *)infoForLayerWithIdentifier:(uint16_t)identifier;
    [Export ("infoForLayerWithIdentifier:")]
    YMKMapLayerInfo InfoForLayerWithIdentifier (ushort identifier);
}

// @interface YMKMapView : UIView
[BaseType (typeof(UIView))]
interface YMKMapView
{
    [Wrap ("WeakDelegate")]
    YMKMapViewDelegate Delegate { get; set; }

    // @property (assign, nonatomic) id<YMKMapViewDelegate> delegate __attribute__((iboutlet));
    [NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) uint16_t visibleLayerIdentifier;
    [Export ("visibleLayerIdentifier")]
    ushort VisibleLayerIdentifier { get; set; }

    // @property (assign, nonatomic) YMKMapRegion region;
    [Export ("region", ArgumentSemantic.Assign)]
    YMKMapRegion Region { get; set; }

    // @property (assign, nonatomic) CLLocationCoordinate2D centerCoordinate;
    [Export ("centerCoordinate", ArgumentSemantic.Assign)]
    CLLocationCoordinate2D CenterCoordinate { get; set; }

    // @property (assign, nonatomic) YMKMapPoint centerMapPoint;
    [Export ("centerMapPoint", ArgumentSemantic.Assign)]
    YMKMapPoint CenterMapPoint { get; set; }

    // @property (readonly, nonatomic) NSUInteger zoomLevel;
    [Export ("zoomLevel")]
    nuint ZoomLevel { get; }

    // @property (readonly, nonatomic) NSArray * annotations;
    [Export ("annotations")]
    //[Verify (StronglyTypedNSArray)]
    NSObject[] Annotations { get; }

    // @property (readonly, nonatomic) YMKMapViewPort viewPort;
    [Export ("viewPort")]
    YMKMapViewPort ViewPort { get; }

    // @property (readonly, assign, nonatomic) double scale;
    [Export ("scale")]
    double Scale { get; }

    // @property (retain, nonatomic) id<YMKAnnotation> selectedAnnotation;
    [Export ("selectedAnnotation", ArgumentSemantic.Retain)]
    YMKAnnotation SelectedAnnotation { get; set; }

    // @property (readonly, nonatomic) YMKUserLocation * userLocation;
    [Export ("userLocation")]
    YMKUserLocation UserLocation { get; }

    // @property (readonly, nonatomic) BOOL userLocationVisible;
    [Export ("userLocationVisible")]
    bool UserLocationVisible { get; }

    // @property (assign, nonatomic) BOOL showsUserLocation;
    [Export ("showsUserLocation")]
    bool ShowsUserLocation { get; set; }

    // @property (assign, nonatomic) BOOL tracksUserLocation;
    [Export ("tracksUserLocation")]
    bool TracksUserLocation { get; set; }

    // @property (assign, nonatomic) BOOL showTraffic;
    [Export ("showTraffic")]
    bool ShowTraffic { get; set; }

    // @property (readonly, copy, nonatomic) NSArray * trafficInformers;
    [Export ("trafficInformers", ArgumentSemantic.Copy)]
    //[Verify (StronglyTypedNSArray)]
    NSObject[] TrafficInformers { get; }

    // @property (readonly, assign, nonatomic) BOOL fetchingJams;
    [Export ("fetchingJams")]
    bool FetchingJams { get; }

    // @property (assign, nonatomic) BOOL showRoute;
    [Export ("showRoute")]
    bool ShowRoute { get; set; }

    // @property (assign, nonatomic) CGFloat angle;
    [Export ("angle")]
    nfloat Angle { get; set; }

    // @property (assign, nonatomic) BOOL canUseCompass;
    [Export ("canUseCompass")]
    bool CanUseCompass { get; set; }

    // @property (getter = isBeingRotatedByUser, assign, nonatomic) BOOL beingRotatedByUser;
    [Export ("beingRotatedByUser")]
    bool BeingRotatedByUser { [Bind ("isBeingRotatedByUser")] get; set; }

    // @property (assign, nonatomic) BOOL nightMode;
    [Export ("nightMode")]
    bool NightMode { get; set; }

    // -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate animated:(BOOL)animated;
    [Export ("setCenterCoordinate:animated:")]
    void SetCenterCoordinate (CLLocationCoordinate2D coordinate, bool animated);

    // -(void)setRegion:(YMKMapRegion)region animated:(BOOL)animated;
    [Export ("setRegion:animated:")]
    void SetRegion (YMKMapRegion region, bool animated);

    // -(void)setCenterCoordinate:(CLLocationCoordinate2D)coordinate atZoomLevel:(NSUInteger)zoomLevel animated:(BOOL)animated;
    [Export ("setCenterCoordinate:atZoomLevel:animated:")]
    void SetCenterCoordinate (CLLocationCoordinate2D coordinate, nuint zoomLevel, bool animated);

    // -(YMKAnnotationView *)dequeueReusableAnnotationViewWithIdentifier:(NSString *)identifier;
    [Export ("dequeueReusableAnnotationViewWithIdentifier:")]
    YMKAnnotationView DequeueReusableAnnotationViewWithIdentifier (string identifier);

    // -(YMKCalloutView *)dequeueReusableCalloutViewWithIdentifier:(NSString *)identifier;
    [Export ("dequeueReusableCalloutViewWithIdentifier:")]
    YMKCalloutView DequeueReusableCalloutViewWithIdentifier (string identifier);

    // -(void)addAnnotation:(id<YMKAnnotation>)annotation;
    [Export ("addAnnotation:")]
    void AddAnnotation (YMKAnnotation annotation);

    // -(void)addAnnotations:(NSArray *)annotations;
    [Export ("addAnnotations:")]
    //[Verify (StronglyTypedNSArray)]
    void AddAnnotations (NSObject[] annotations);

    // -(void)removeAnnotation:(id<YMKAnnotation>)annotation;
    [Export ("removeAnnotation:")]
    void RemoveAnnotation (YMKAnnotation annotation);

    // -(void)removeAnnotations:(NSArray *)annotations;
    [Export ("removeAnnotations:")]
    //[Verify (StronglyTypedNSArray)]
    void RemoveAnnotations (NSObject[] annotations);

    // -(void)scrollToAnnotation:(id<YMKAnnotation>)annotation animated:(BOOL)animated;
    [Export ("scrollToAnnotation:animated:")]
    void ScrollToAnnotation (YMKAnnotation annotation, bool animated);

    // -(YMKAnnotationView *)viewForAnnotation:(id<YMKAnnotation>)annotation;
    [Export ("viewForAnnotation:")]
    YMKAnnotationView ViewForAnnotation (YMKAnnotation annotation);

    // -(CGPoint)convertLLToMapView:(CLLocationCoordinate2D)coord;
    [Export ("convertLLToMapView:")]
    CGPoint ConvertLLToMapView (CLLocationCoordinate2D coord);

    // -(CLLocationCoordinate2D)convertMapViewPointToLL:(CGPoint)point;
    [Export ("convertMapViewPointToLL:")]
    CLLocationCoordinate2D ConvertMapViewPointToLL (CGPoint point);

    // -(CGPoint)convertMapPointToMapView:(YMKMapPoint)point;
    [Export ("convertMapPointToMapView:")]
    CGPoint ConvertMapPointToMapView (YMKMapPoint point);

    // -(YMKMapPoint)convertMapViewPointToMapPoint:(CGPoint)point;
    [Export ("convertMapViewPointToMapPoint:")]
    YMKMapPoint ConvertMapViewPointToMapPoint (CGPoint point);

    // -(YMKMapRegion)fitRegion:(YMKMapRegion)region;
    [Export ("fitRegion:")]
    YMKMapRegion FitRegion (YMKMapRegion region);

    // -(void)setAngle:(CGFloat)angle animated:(BOOL)animated;
    [Export ("setAngle:animated:")]
    void SetAngle (nfloat angle, bool animated);

    // -(void)dismissHeadingCalibrationDisplay;
    [Export ("dismissHeadingCalibrationDisplay")]
    void DismissHeadingCalibrationDisplay ();

    // +(unsigned long long)calculateCacheSize:(NSError **)error;
    [Static]
    [Export ("calculateCacheSize:")]
    ulong CalculateCacheSize (out NSError error);

    // +(void)clearCache;
    [Static]
    [Export ("clearCache")]
    void ClearCache ();

    // -(void)zoomIn;
    [Export ("zoomIn")]
    void ZoomIn ();

    // -(void)zoomOut;
    [Export ("zoomOut")]
    void ZoomOut ();
}

// @protocol YMKMapViewDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface YMKMapViewDelegate
{
    // @optional -(YMKAnnotationView *)mapView:(YMKMapView *)mapView viewForAnnotation:(id<YMKAnnotation>)annotation;
    [Export ("mapView:viewForAnnotation:")]
    YMKAnnotationView MapView (YMKMapView mapView, YMKAnnotation annotation);

    // @optional -(YMKCalloutView *)mapView:(YMKMapView *)view calloutViewForAnnotation:(id<YMKAnnotation>)annotation;
    [Export ("mapView:calloutViewForAnnotation:")]
    YMKCalloutView MapCalloutView (YMKMapView view, YMKAnnotation annotation);

    // @optional -(void)mapView:(YMKMapView *)mapView annotationView:(YMKAnnotationView *)view calloutAccessoryControlTapped:(UIControl *)control;
    [Export ("mapView:annotationView:calloutAccessoryControlTapped:")]
    void MapView (YMKMapView mapView, YMKAnnotationView view, UIControl control);

    // @optional -(void)mapView:(YMKMapView *)mapView annotationViewCalloutTapped:(YMKAnnotationView *)view;
    [Export ("mapView:annotationViewCalloutTapped:")]
    void MapView (YMKMapView mapView, YMKAnnotationView view);

    // @optional -(void)mapView:(YMKMapView *)mapView didAddAnnotationViews:(NSArray *)views;
    [Export ("mapView:didAddAnnotationViews:")]
    //[Verify (StronglyTypedNSArray)]
    void MapView (YMKMapView mapView, NSObject[] views);

    // @optional -(void)mapView:(YMKMapView *)mapView regionDidChangeAnimated:(BOOL)animated;
    [Export ("mapView:regionDidChangeAnimated:")]
    void MapView (YMKMapView mapView, bool animated);

    // @optional -(void)mapView:(YMKMapView *)mapView regionWillChangeAnimated:(BOOL)animated;
    [Export ("mapView:regionWillChangeAnimated:")]
    void MapViewRegionWillChange (YMKMapView mapView, bool animated);

    // @optional -(void)mapViewWasDragged:(YMKMapView *)mapView;
    [Export ("mapViewWasDragged:")]
    void MapViewWasDragged (YMKMapView mapView);

    // @optional -(BOOL)mapViewShouldFollowUserLocation:(YMKMapView *)mapView;
    [Export ("mapViewShouldFollowUserLocation:")]
    bool MapViewShouldFollowUserLocation (YMKMapView mapView);

    // @optional -(BOOL)mapViewShouldDisplayHeadingCalibration:(YMKMapView *)mapView;
    [Export ("mapViewShouldDisplayHeadingCalibration:")]
    bool MapViewShouldDisplayHeadingCalibration (YMKMapView mapView);

    // @optional -(void)mapView:(YMKMapView *)mapView locationManagerDidReceiveError:(NSError *)error;
    [Export ("mapView:locationManagerDidReceiveError:")]
    void MapView (YMKMapView mapView, NSError error);

    // @optional -(void)mapView:(YMKMapView *)mapView didUpdateUserLocation:(YMKUserLocation *)userLocation;
    [Export ("mapView:didUpdateUserLocation:")]
    void MapView (YMKMapView mapView, YMKUserLocation userLocation);

    // @optional -(void)mapView:(YMKMapView *)mapView gotSingleTapAtCoordinate:(CLLocationCoordinate2D)coordinate;
    [Export ("mapView:gotSingleTapAtCoordinate:")]
    void MapView (YMKMapView mapView, CLLocationCoordinate2D coordinate);

    // @optional -(void)mapView:(YMKMapView *)mapView gotTapAndHoldAtCoordinate:(CLLocationCoordinate2D)coordinate;
    [Export ("mapView:gotTapAndHoldAtCoordinate:")]
    void MapViewGotTapAndHoldAtCoordinate (YMKMapView mapView, CLLocationCoordinate2D coordinate);

    // @optional -(void)mapViewDidResetRotationAngle:(YMKMapView *)mapView;
    [Export ("mapViewDidResetRotationAngle:")]
    void MapViewDidResetRotationAngle (YMKMapView mapView);

    // @optional -(CGRect)mapViewVisibleRect:(YMKMapView *)mapView;
    [Export ("mapViewVisibleRect:")]
    CGRect MapViewVisibleRect (YMKMapView mapView);
}

// @interface YMKRuler : UIView
[BaseType (typeof(UIView))]
interface YMKRuler
{
    // @property (assign, nonatomic) double scale;
    [Export ("scale")]
    double Scale { get; set; }

    // @property (assign, nonatomic) BOOL nightMode;
    [Export ("nightMode")]
    bool NightMode { get; set; }
}

// @interface YMKTrafficInformer : NSObject <NSCoding>
[BaseType (typeof(NSObject))]
interface YMKTrafficInformer : INSCoding
{
    // @property (assign, nonatomic) CLLocationCoordinate2D coord;
    [Export ("coord", ArgumentSemantic.Assign)]
    CLLocationCoordinate2D Coord { get; set; }

    // @property (assign, nonatomic) NSInteger value;
    [Export ("value")]
    nint Value { get; set; }

    // @property (assign, nonatomic) YMKTrafficInformerColor color;
    [Export ("color", ArgumentSemantic.Assign)]
    YMKTrafficInformerColor Color { get; set; }

    // @property (retain, nonatomic) NSDate * expirationDate;
    [Export ("expirationDate", ArgumentSemantic.Retain)]
    NSDate ExpirationDate { get; set; }

    // @property (retain, nonatomic) NSString * city;
    [Export ("city", ArgumentSemantic.Retain)]
    string City { get; set; }
}

// @interface YMKUserLocation : NSObject <YMKAnnotation>
[BaseType (typeof(NSObject))]
interface YMKUserLocation : YMKAnnotation
{
    // @property (readonly, nonatomic) CLLocation * location;
    [Export ("location")]
    CLLocation Location { get; }

    // @property (readonly, nonatomic) NSString * title;
    //[Export ("title")]
    //string Title { get; }

    // @property (copy, nonatomic) NSString * subtitle;
    //[Export ("subtitle")]
    //string Subtitle { get; set; }

    // @property (readonly, getter = isUpdating, nonatomic) BOOL updating;
    [Export ("updating")]
    bool Updating { [Bind ("isUpdating")] get; }
}
}