XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=SHSPhoneComponents
PROJECT=$(PROJECT_ROOT)/SHSPhoneComponent.xcodeproj
TARGET=SHSPhoneComponent

all: $(TARGET).dll

$(TARGET)-sim.framework:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/$(TARGET).framework $@

$(TARGET)-iphone.framework:
	$(XBUILD) ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/$(TARGET).framework $@

$(TARGET).framework: $(TARGET)-sim.framework $(TARGET)-iphone.framework
	cp -R $(TARGET)-iphone.framework $@
	rm $@/$(TARGET)
	lipo -create -output $@/$(TARGET) $(TARGET)-sim.framework/$(TARGET) $(TARGET)-iphone.framework/$(TARGET)

$(TARGET).dll: ApiDefinitions.cs $(TARGET).framework
	msbuild /p:Configuration=Release
	cp bin/Release/$(TARGET).dll $(TARGET).dll

clean: 
	-rm -rf *.a *.framework *.dll