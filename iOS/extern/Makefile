IOS_GIT_BRANCH=master
XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
WORKSPACE=TOCropViewControllerExample.xcodeproj
WORKSPACE_DIR=ios/TOCropViewController
SCHEME=TOCropViewController
BUILD_ROOT=build/Build/Products
VALID_ARCHS="armv7 armv7s arm64 i386 x86_64"

all: clean TOCropViewController.framework

Podfile.lock:
	mkdir -p ios
	cd ios && git clone https://github.com/TimOliver/TOCropViewController.git
	cd ios/TOCropViewController && git checkout $(IOS_GIT_BRANCH)

TOCropViewController-iphonesimulator: Podfile.lock
	cd $(WORKSPACE_DIR) && $(XBUILD) -project $(WORKSPACE) -scheme $(SCHEME) -sdk iphonesimulator -configuration Release VALID_ARCHS=$(VALID_ARCHS) ENABLE_BITCODE=NO ONLY_ACTIVE_ARCH=NO EFFECTIVE_PLATFORM_NAME="-iphonesimulator" -derivedDataPath build clean build	
	mv $(WORKSPACE_DIR)/$(BUILD_ROOT)/Release-iphonesimulator/TOCropViewController.framework/TOCropViewController $@

TOCropViewController-iphoneos: Podfile.lock
	cd $(WORKSPACE_DIR) && $(XBUILD) -project $(WORKSPACE) -scheme $(SCHEME) -sdk iphoneos -configuration Release ONLY_ACTIVE_ARCH=NO ENABLE_BITCODE=NO -derivedDataPath build clean build
	mv $(WORKSPACE_DIR)/$(BUILD_ROOT)/Release-iphoneos/TOCropViewController.framework/TOCropViewController $@
	cp -R $(WORKSPACE_DIR)/$(BUILD_ROOT)/Release-iphoneos/TOCropViewController.framework TOCropViewController.framework

TOCropViewController.framework: TOCropViewController-iphoneos TOCropViewController-iphonesimulator
	lipo -create -output $@/TOCropViewController $^	

clean:
	rm -rf ios

.PHONY: all clean