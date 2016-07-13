XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=YandexMapKit
TARGET=YandexMapKit

all: YandexMapKit.dll

libYandexMapKit.a: 
	sharpie pod init ios YandexMapKit -force
	cp Pods/YandexMapKit/libYandexMapKit.a libYandexMapKit.a

YandexMapKit.dll: bindings/AssemblyInfo.cs bindings/StructsAndEnums.cs bindings/ApiDefinitions.cs libYandexMapKit.a
	$(BTOUCH) --new-style -s:bindings/StructsAndEnums.cs --unsafe bindings/ApiDefinitions.cs -x:bindings/AssemblyInfo.cs -x:bindings/Extra.cs --out=$@ --link-with=libYandexMapKit.a,libYandexMapKit.a

clean: 
	-rm -f *.a *.dll