XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=MDSpreadView
PROJECT=$(PROJECT_ROOT)/MDSpreadView.xcodeproj
TARGET=MDSpreadView

all: MDSpreadView.dll

MDSpreadView-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

MDSpreadView-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

MDSpreadView-x64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@
	
MDSpreadView.a: MDSpreadView-i386.a MDSpreadView-armv7.a MDSpreadView-x64.a
	lipo -create -output $@ $^

MDSpreadView.dll: bindings/AssemblyInfo.cs bindings/StructsAndEnums.cs bindings/ApiDefinition.cs MDSpreadView.a
	$(BTOUCH) --new-style -s:bindings/StructsAndEnums.cs bindings/ApiDefinition.cs -x:bindings/AssemblyInfo.cs -x:bindings/Extra.cs --out=$@ --link-with=MDSpreadView.a,MDSpreadView.a  

clean: 
	-rm -f *.a *.dll