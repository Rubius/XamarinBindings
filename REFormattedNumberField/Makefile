XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/REFormattedNumberField.xcodeproj
TARGET=REFormattedNumberField

all: $(TARGET).dll

$(TARGET)-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

$(TARGET)-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

$(TARGET)-x64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@
	
$(TARGET).a: $(TARGET)-i386.a $(TARGET)-armv7.a $(TARGET)-x64.a
	lipo -create -output $@ $^

$(TARGET).dll: bindings/ApiDefinitions.cs bindings/$(TARGET).linkwith.cs $(TARGET).a
	$(BTOUCH) --new-style bindings/ApiDefinitions.cs  -x:bindings/$(TARGET).linkwith.cs --out=$@ --link-with=$(TARGET).a,$(TARGET).a  

clean: 
	-rm -f *.a *.dll