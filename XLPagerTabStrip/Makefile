XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=XLPagerTabStrip
PROJECT=$(PROJECT_ROOT)/XLPagerTabStrip.xcodeproj
TARGET=XLPagerTabStrip

all: XLPagerTabStrip.dll

XLPagerTabStrip-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

XLPagerTabStrip-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@


XLPagerTabStrip-x64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

XLPagerTabStrip.a: XLPagerTabStrip-armv7.a XLPagerTabStrip-i386.a XLPagerTabStrip-x64.a
	lipo -create -output $@ $^

XLPagerTabStrip.dll: bindings/AssemblyInfo.cs bindings/StructsAndEnums.cs bindings/ApiDefinitions.cs XLPagerTabStrip.a
	$(BTOUCH) --new-style -s:bindings/StructsAndEnums.cs --unsafe bindings/ApiDefinitions.cs -x:bindings/AssemblyInfo.cs -x:bindings/Extra.cs --out=$@ --link-with=XLPagerTabStrip.a,XLPagerTabStrip.a 

clean: 
	-rm -f *.a *.dll