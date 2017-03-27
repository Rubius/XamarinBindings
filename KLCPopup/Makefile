XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=KLCPopupObjC
PROJECT=$(PROJECT_ROOT)/KLCPopup.xcodeproj
TARGET=KLCPopup

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

$(TARGET).dll: bindings/AssemblyInfo.cs bindings/StructsAndEnums.cs bindings/ApiDefinition.cs bindings/libKLCPopup.linkwith.cs $(TARGET).a
	$(BTOUCH) --new-style -s:bindings/StructsAndEnums.cs bindings/ApiDefinition.cs -x:bindings/AssemblyInfo.cs -x:bindings/libKLCPopup.linkwith.cs --out=$@ --link-with=$(TARGET).a,$(TARGET).a  

clean: 
	-rm -f *.a *.dll