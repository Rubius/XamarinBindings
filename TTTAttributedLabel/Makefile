XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch
PROJECT_ROOT=TTTAttributedLabel
PROJECT=$(PROJECT_ROOT)/TTTAttributedLabel.xcodeproj
TARGET=TTTAttributedLabel

all: TTTAttributedLabel.dll

TTTAttributedLabel-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

TTTAttributedLabel-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

TTTAttributedLabel.a: TTTAttributedLabel-armv7.a TTTAttributedLabel-i386.a
	lipo -create -output $@ $^

TTTAttributedLabel.dll: bindings/AssemblyInfo.cs bindings/StructsAndEnums.cs bindings/ApiDefinition.cs TTTAttributedLabel.a
	$(BTOUCH) -s:bindings/StructsAndEnums.cs --unsafe bindings/ApiDefinition.cs -x:bindings/AssemblyInfo.cs -x:bindings/Extra.cs --out=$@ --link-with=TTTAttributedLabel.a,TTTAttributedLabel.a 

clean: 
	-rm -f *.a *.dll