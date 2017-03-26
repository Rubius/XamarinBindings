XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=ICViewPager
PROJECT=$(PROJECT_ROOT)/ICViewPager.xcodeproj
TARGET=ICViewPager

all: ICViewPager.dll

ICViewPager-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

ICViewPager-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@


ICViewPager-x64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

ICViewPager.a: ICViewPager-armv7.a ICViewPager-i386.a ICViewPager-x64.a
	lipo -create -output $@ $^

ICViewPager.dll: bindings/AssemblyInfo.cs bindings/StructsAndEnums.cs bindings/ApiDefinitions.cs ICViewPager.a
	$(BTOUCH) --new-style -s:bindings/StructsAndEnums.cs --unsafe bindings/ApiDefinitions.cs -x:bindings/AssemblyInfo.cs -x:bindings/Extra.cs --out=$@ --link-with=ICViewPager.a,ICViewPager.a 

clean: 
	-rm -f *.a *.dll