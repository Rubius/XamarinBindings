XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
BTOUCH=/Developer/MonoTouch/usr/bin/btouch-native
PROJECT_ROOT=Pods
PROJECT=Pods/Pods.xcodeproj
TARGET=CZPicker
BINDING=$(TARGET)

all: $(TARGET).dll

$(PROJECT):
	sharpie pod init ios $(TARGET)
	
$(TARGET)-sim.framework: $(PROJECT)
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv build/Release-iphonesimulator/$(TARGET)/$(TARGET).framework $@

$(TARGET)-iphone.framework: $(PROJECT)
	$(XBUILD) ONLY_ACTIVE_ARCH=NO OTHER_CFLAGS="-fembed-bitcode" BITCODE_GENERATION_MODE=bitcode  -project $(PROJECT) -target $(TARGET) -sdk iphoneos -configuration Release clean build 
	-mv build/Release-iphoneos/$(TARGET)/$(TARGET).framework $@

$(TARGET).framework: $(TARGET)-sim.framework $(TARGET)-iphone.framework
	cp -R $(TARGET)-iphone.framework $@
	rm $@/$(TARGET)
	lipo -create -output $@/$(TARGET) $(TARGET)-sim.framework/$(TARGET) $(TARGET)-iphone.framework/$(TARGET)

$(TARGET).dll: $(TARGET).framework $(BINDING)/$(BINDING).csproj
	msbuild $(BINDING) /p:Configuration=Release
	cp $(BINDING)/bin/Release/$(TARGET).dll $(TARGET).dll

clean: 
	-rm -rf *.a *.framework *.dll
	-rm -rf bin/* obj/* $(PROJECT_ROOT)/build
