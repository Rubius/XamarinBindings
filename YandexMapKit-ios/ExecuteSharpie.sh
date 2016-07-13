sharpie pod init ios YandexMapKit

echo "#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import \"YandexMapKit.h\"" > Pods/YandexMapKit/Headers/All.h

sharpie bind -output Bindings -sdk iphoneos9.3 \
Pods/YandexMapKit/Headers/All.h 