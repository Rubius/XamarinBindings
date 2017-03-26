XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=./FSCalendar/XcodeProject
TARGET=FSCalendar
PROJECT=$(PROJECT_ROOT)/$(TARGET).xcodeproj
BINDINGS=FSCalendar

all: $(TARGET).a $(TARGET).dll

lib$(TARGET)-x86_64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch x86_64 -configuration Release clean build
	-mv  $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@
lib$(TARGET)-i386.a:
		$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -arch i386 -configuration Release clean build
		-mv  $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@
lib$(TARGET)-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv  $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@
lib$(TARGET)-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv  $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@
$(TARGET).a: lib$(TARGET)-x86_64.a lib$(TARGET)-i386.a lib$(TARGET)-armv7.a lib$(TARGET)-arm64.a
	xcrun -sdk iphoneos lipo -create -output $@ $^


$(TARGET).dll: $(BINDINGS)/Structs.cs $(BINDINGS)/ApiDefinition.cs  $(BINDINGS)/LinkWith.cs $(TARGET).a
	$(BTOUCH) --new-style -s:$(BINDINGS)/Structs.cs $(BINDINGS)/ApiDefinition.cs -x:$(BINDINGS)/LinkWith.cs  --out=$@ --link-with=$(TARGET).a,$(TARGET).a


clean:
	-rm -f *.a *.dll
