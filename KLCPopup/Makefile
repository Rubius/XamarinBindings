XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=KLCPopupObjC
PROJECT=$(PROJECT_ROOT)/KLCPopup.xcodeproj
TARGET=KLCPopup

all: KLCPopup.dll

KLCPopup-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

KLCPopup-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

KLCPopup-x64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@
	
KLCPopup.a: KLCPopup-i386.a KLCPopup-armv7.a KLCPopup-x64.a
	lipo -create -output $@ $^

KLCPopup.dll: bindings/AssemblyInfo.cs bindings/StructsAndEnums.cs bindings/ApiDefinition.cs KLCPopup.a
	$(BTOUCH) --new-style -s:bindings/StructsAndEnums.cs bindings/ApiDefinition.cs -x:bindings/AssemblyInfo.cs --out=$@ --link-with=KLCPopup.a,KLCPopup.a  

clean: 
	-rm -f *.a *.dll