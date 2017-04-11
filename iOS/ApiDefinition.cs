using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace Xam.Plugins.ImageCropper.iOS
{
    // @interface TOCropOverlayView : UIView
    [BaseType(typeof(UIView))]
    interface TOCropOverlayView
    {
        // @property (assign, nonatomic) BOOL gridHidden;
        [Export("gridHidden")]
        bool GridHidden { get; set; }

        // @property (assign, nonatomic) BOOL displayHorizontalGridLines;
        [Export("displayHorizontalGridLines")]
        bool DisplayHorizontalGridLines { get; set; }

        // @property (assign, nonatomic) BOOL displayVerticalGridLines;
        [Export("displayVerticalGridLines")]
        bool DisplayVerticalGridLines { get; set; }

        // -(void)setGridHidden:(BOOL)hidden animated:(BOOL)animated;
        [Export("setGridHidden:animated:")]
        void SetGridHidden(bool hidden, bool animated);
    }

    // @protocol TOCropViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface TOCropViewDelegate
    {
        // @required -(void)cropViewDidBecomeResettable:(TOCropView * _Nonnull)cropView;
        [Abstract]
        [Export("cropViewDidBecomeResettable:")]
        void CropViewDidBecomeResettable(TOCropView cropView);

        // @required -(void)cropViewDidBecomeNonResettable:(TOCropView * _Nonnull)cropView;
        [Abstract]
        [Export("cropViewDidBecomeNonResettable:")]
        void CropViewDidBecomeNonResettable(TOCropView cropView);
    }

    // @interface TOCropView : UIView
    [BaseType(typeof(UIView))]
    interface TOCropView
    {
        // @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (readonly, assign, nonatomic) TOCropViewCroppingStyle croppingStyle;
        [Export("croppingStyle", ArgumentSemantic.Assign)]
        TOCropViewCroppingStyle CroppingStyle { get; }

        // @property (readonly, nonatomic, strong) TOCropOverlayView * _Nonnull gridOverlayView;
        [Export("gridOverlayView", ArgumentSemantic.Strong)]
        TOCropOverlayView GridOverlayView { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        TOCropViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<TOCropViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL cropBoxResizeEnabled;
        [Export("cropBoxResizeEnabled")]
        bool CropBoxResizeEnabled { get; set; }

        // @property (readonly, nonatomic) BOOL canBeReset;
        [Export("canBeReset")]
        bool CanBeReset { get; }

        // @property (readonly, nonatomic) CGRect cropBoxFrame;
        [Export("cropBoxFrame")]
        CGRect CropBoxFrame { get; }

        // @property (readonly, nonatomic) CGRect imageViewFrame;
        [Export("imageViewFrame")]
        CGRect ImageViewFrame { get; }

        // @property (assign, nonatomic) UIEdgeInsets cropRegionInsets;
        [Export("cropRegionInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets CropRegionInsets { get; set; }

        // @property (assign, nonatomic) BOOL simpleRenderMode;
        [Export("simpleRenderMode")]
        bool SimpleRenderMode { get; set; }

        // @property (assign, nonatomic) BOOL internalLayoutDisabled;
        [Export("internalLayoutDisabled")]
        bool InternalLayoutDisabled { get; set; }

        // @property (assign, nonatomic) CGSize aspectRatio;
        [Export("aspectRatio", ArgumentSemantic.Assign)]
        CGSize AspectRatio { get; set; }

        // @property (assign, nonatomic) BOOL aspectRatioLockEnabled;
        [Export("aspectRatioLockEnabled")]
        bool AspectRatioLockEnabled { get; set; }

        // @property (assign, nonatomic) BOOL resetAspectRatioEnabled;
        [Export("resetAspectRatioEnabled")]
        bool ResetAspectRatioEnabled { get; set; }

        // @property (readonly, nonatomic) BOOL cropBoxAspectRatioIsPortrait;
        [Export("cropBoxAspectRatioIsPortrait")]
        bool CropBoxAspectRatioIsPortrait { get; }

        // @property (assign, nonatomic) NSInteger angle;
        [Export("angle")]
        nint Angle { get; set; }

        // @property (assign, nonatomic) BOOL croppingViewsHidden;
        [Export("croppingViewsHidden")]
        bool CroppingViewsHidden { get; set; }

        // @property (assign, nonatomic) CGRect imageCropFrame;
        [Export("imageCropFrame", ArgumentSemantic.Assign)]
        CGRect ImageCropFrame { get; set; }

        // @property (assign, nonatomic) BOOL gridOverlayHidden;
        [Export("gridOverlayHidden")]
        bool GridOverlayHidden { get; set; }

        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image;
        [Export("initWithImage:")]
        IntPtr Constructor(UIImage image);

        // -(instancetype _Nonnull)initWithCroppingStyle:(TOCropViewCroppingStyle)style image:(UIImage * _Nonnull)image;
        [Export("initWithCroppingStyle:image:")]
        IntPtr Constructor(TOCropViewCroppingStyle style, UIImage image);

        // -(void)setSimpleRenderMode:(BOOL)simpleMode animated:(BOOL)animated;
        [Export("setSimpleRenderMode:animated:")]
        void SetSimpleRenderMode(bool simpleMode, bool animated);

        // -(void)prepareforRotation;
        [Export("prepareforRotation")]
        void PrepareforRotation();

        // -(void)performRelayoutForRotation;
        [Export("performRelayoutForRotation")]
        void PerformRelayoutForRotation();

        // -(void)resetLayoutToDefaultAnimated:(BOOL)animated;
        [Export("resetLayoutToDefaultAnimated:")]
        void ResetLayoutToDefaultAnimated(bool animated);

        // -(void)setAspectRatio:(CGSize)aspectRatio animated:(BOOL)animated;
        [Export("setAspectRatio:animated:")]
        void SetAspectRatio(CGSize aspectRatio, bool animated);

        // -(void)rotateImageNinetyDegreesAnimated:(BOOL)animated;
        [Export("rotateImageNinetyDegreesAnimated:")]
        void RotateImageNinetyDegreesAnimated(bool animated);

        // -(void)rotateImageNinetyDegreesAnimated:(BOOL)animated clockwise:(BOOL)clockwise;
        [Export("rotateImageNinetyDegreesAnimated:clockwise:")]
        void RotateImageNinetyDegreesAnimated(bool animated, bool clockwise);

        // -(void)setGridOverlayHidden:(BOOL)gridOverlayHidden animated:(BOOL)animated;
        [Export("setGridOverlayHidden:animated:")]
        void SetGridOverlayHidden(bool gridOverlayHidden, bool animated);

        // -(void)setCroppingViewsHidden:(BOOL)hidden animated:(BOOL)animated;
        [Export("setCroppingViewsHidden:animated:")]
        void SetCroppingViewsHidden(bool hidden, bool animated);

        // -(void)setBackgroundImageViewHidden:(BOOL)hidden animated:(BOOL)animated;
        [Export("setBackgroundImageViewHidden:animated:")]
        void SetBackgroundImageViewHidden(bool hidden, bool animated);

        // -(void)moveCroppedContentToCenterAnimated:(BOOL)animated;
        [Export("moveCroppedContentToCenterAnimated:")]
        void MoveCroppedContentToCenterAnimated(bool animated);
    }

    // @interface TOCropToolbar : UIView
    [BaseType(typeof(UIView))]
    interface TOCropToolbar
    {
        // @property (assign, nonatomic) BOOL statusBarVisible;
        [Export("statusBarVisible")]
        bool StatusBarVisible { get; set; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull doneTextButton;
        [Export("doneTextButton", ArgumentSemantic.Strong)]
        UIButton DoneTextButton { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull doneIconButton;
        [Export("doneIconButton", ArgumentSemantic.Strong)]
        UIButton DoneIconButton { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull cancelTextButton;
        [Export("cancelTextButton", ArgumentSemantic.Strong)]
        UIButton CancelTextButton { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull cancelIconButton;
        [Export("cancelIconButton", ArgumentSemantic.Strong)]
        UIButton CancelIconButton { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull rotateCounterclockwiseButton;
        [Export("rotateCounterclockwiseButton", ArgumentSemantic.Strong)]
        UIButton RotateCounterclockwiseButton { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull resetButton;
        [Export("resetButton", ArgumentSemantic.Strong)]
        UIButton ResetButton { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull clampButton;
        [Export("clampButton", ArgumentSemantic.Strong)]
        UIButton ClampButton { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull rotateClockwiseButton;
        [Export("rotateClockwiseButton", ArgumentSemantic.Strong)]
        UIButton RotateClockwiseButton { get; }

        // @property (readonly, nonatomic) UIButton * _Nonnull rotateButton;
        [Export("rotateButton")]
        UIButton RotateButton { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) cancelButtonTapped;
        [NullAllowed, Export("cancelButtonTapped", ArgumentSemantic.Copy)]
        Action CancelButtonTapped { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) doneButtonTapped;
        [NullAllowed, Export("doneButtonTapped", ArgumentSemantic.Copy)]
        Action DoneButtonTapped { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) rotateCounterclockwiseButtonTapped;
        [NullAllowed, Export("rotateCounterclockwiseButtonTapped", ArgumentSemantic.Copy)]
        Action RotateCounterclockwiseButtonTapped { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) rotateClockwiseButtonTapped;
        [NullAllowed, Export("rotateClockwiseButtonTapped", ArgumentSemantic.Copy)]
        Action RotateClockwiseButtonTapped { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) clampButtonTapped;
        [NullAllowed, Export("clampButtonTapped", ArgumentSemantic.Copy)]
        Action ClampButtonTapped { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) resetButtonTapped;
        [NullAllowed, Export("resetButtonTapped", ArgumentSemantic.Copy)]
        Action ResetButtonTapped { get; set; }

        // @property (assign, nonatomic) BOOL clampButtonGlowing;
        [Export("clampButtonGlowing")]
        bool ClampButtonGlowing { get; set; }

        // @property (readonly, nonatomic) CGRect clampButtonFrame;
        [Export("clampButtonFrame")]
        CGRect ClampButtonFrame { get; }

        // @property (assign, nonatomic) BOOL clampButtonHidden;
        [Export("clampButtonHidden")]
        bool ClampButtonHidden { get; set; }

        // @property (assign, nonatomic) BOOL rotateCounterclockwiseButtonHidden;
        [Export("rotateCounterclockwiseButtonHidden")]
        bool RotateCounterclockwiseButtonHidden { get; set; }

        // @property (assign, nonatomic) BOOL rotateClockwiseButtonHidden;
        [Export("rotateClockwiseButtonHidden")]
        bool RotateClockwiseButtonHidden { get; set; }

        // @property (assign, nonatomic) BOOL resetButtonEnabled;
        [Export("resetButtonEnabled")]
        bool ResetButtonEnabled { get; set; }

        // @property (readonly, nonatomic) CGRect doneButtonFrame;
        [Export("doneButtonFrame")]
        CGRect DoneButtonFrame { get; }
    }

    // @protocol TOCropViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface TOCropViewControllerDelegate
    {
        // @optional -(void)cropViewController:(TOCropViewController * _Nonnull)cropViewController didCropImageToRect:(CGRect)cropRect angle:(NSInteger)angle;
        [Export("cropViewController:didCropImageToRect:angle:")]
        void DidCropImageToRect(TOCropViewController cropViewController, CGRect cropRect, nint angle);

        // @optional -(void)cropViewController:(TOCropViewController * _Nonnull)cropViewController didCropToImage:(UIImage * _Nonnull)image withRect:(CGRect)cropRect angle:(NSInteger)angle;
        [Export("cropViewController:didCropToImage:withRect:angle:")]
        void DidCropToImage(TOCropViewController cropViewController, UIImage image, CGRect cropRect, nint angle);

        // @optional -(void)cropViewController:(TOCropViewController * _Nonnull)cropViewController didCropToCircularImage:(UIImage * _Nonnull)image withRect:(CGRect)cropRect angle:(NSInteger)angle;
        [Export("cropViewController:didCropToCircularImage:withRect:angle:")]
        void DidCropToCircularImage(TOCropViewController cropViewController, UIImage image, CGRect cropRect, nint angle);

        // @optional -(void)cropViewController:(TOCropViewController * _Nonnull)cropViewController didFinishCancelled:(BOOL)cancelled;
        [Export("cropViewController:didFinishCancelled:")]
        void DidFinishCancelled(TOCropViewController cropViewController, bool cancelled);
    }

    // @interface TOCropViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface TOCropViewController
    {
        // @property (readonly, nonatomic) UIImage * _Nonnull image;
        [Export("image")]
        UIImage Image { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        TOCropViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<TOCropViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL showActivitySheetOnDone;
        [Export("showActivitySheetOnDone")]
        bool ShowActivitySheetOnDone { get; set; }

        // @property (readonly, nonatomic, strong) TOCropView * _Nonnull cropView;
        [Export("cropView", ArgumentSemantic.Strong)]
        TOCropView CropView { get; }

        // @property (assign, nonatomic) CGRect imageCropFrame;
        [Export("imageCropFrame", ArgumentSemantic.Assign)]
        CGRect ImageCropFrame { get; set; }

        // @property (assign, nonatomic) NSInteger angle;
        [Export("angle")]
        nint Angle { get; set; }

        // @property (readonly, nonatomic, strong) TOCropToolbar * _Nonnull toolbar;
        [Export("toolbar", ArgumentSemantic.Strong)]
        TOCropToolbar Toolbar { get; }

        // @property (readonly, nonatomic) TOCropViewCroppingStyle croppingStyle;
        [Export("croppingStyle")]
        TOCropViewCroppingStyle CroppingStyle { get; }

        // @property (assign, nonatomic) TOCropViewControllerAspectRatioPreset aspectRatioPreset;
        [Export("aspectRatioPreset", ArgumentSemantic.Assign)]
        TOCropViewControllerAspectRatioPreset AspectRatioPreset { get; set; }

        // @property (assign, nonatomic) CGSize customAspectRatio;
        [Export("customAspectRatio", ArgumentSemantic.Assign)]
        CGSize CustomAspectRatio { get; set; }

        // @property (assign, nonatomic) BOOL aspectRatioLockEnabled;
        [Export("aspectRatioLockEnabled")]
        bool AspectRatioLockEnabled { get; set; }

        // @property (assign, nonatomic) BOOL resetAspectRatioEnabled;
        [Export("resetAspectRatioEnabled")]
        bool ResetAspectRatioEnabled { get; set; }

        // @property (assign, nonatomic) TOCropViewControllerToolbarPosition toolbarPosition;
        [Export("toolbarPosition", ArgumentSemantic.Assign)]
        TOCropViewControllerToolbarPosition ToolbarPosition { get; set; }

        // @property (assign, nonatomic) BOOL rotateClockwiseButtonHidden;
        [Export("rotateClockwiseButtonHidden")]
        bool RotateClockwiseButtonHidden { get; set; }

        // @property (assign, nonatomic) BOOL rotateButtonsHidden;
        [Export("rotateButtonsHidden")]
        bool RotateButtonsHidden { get; set; }

        // @property (assign, nonatomic) BOOL aspectRatioPickerButtonHidden;
        [Export("aspectRatioPickerButtonHidden")]
        bool AspectRatioPickerButtonHidden { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable activityItems;
        [NullAllowed, Export("activityItems", ArgumentSemantic.Strong)]
        NSObject[] ActivityItems { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable applicationActivities;
        [NullAllowed, Export("applicationActivities", ArgumentSemantic.Strong)]
        NSObject[] ApplicationActivities { get; set; }

        // @property (nonatomic, strong) NSArray * _Nullable excludedActivityTypes;
        [NullAllowed, Export("excludedActivityTypes", ArgumentSemantic.Strong)]
        NSObject[] ExcludedActivityTypes { get; set; }

        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nonnull)image;
        [Export("initWithImage:")]
        IntPtr Constructor(UIImage image);

        // -(instancetype _Nonnull)initWithCroppingStyle:(TOCropViewCroppingStyle)style image:(UIImage * _Nonnull)image;
        [Export("initWithCroppingStyle:image:")]
        IntPtr Constructor(TOCropViewCroppingStyle style, UIImage image);

        // -(void)resetCropViewLayout;
        [Export("resetCropViewLayout")]
        void ResetCropViewLayout();

        // -(void)setAspectRatioPreset:(TOCropViewControllerAspectRatioPreset)aspectRatioPreset animated:(BOOL)animated;
        [Export("setAspectRatioPreset:animated:")]
        void SetAspectRatioPreset(TOCropViewControllerAspectRatioPreset aspectRatioPreset, bool animated);

        // -(void)presentAnimatedFromParentViewController:(UIViewController * _Nonnull)viewController fromView:(UIView * _Nullable)fromView fromFrame:(CGRect)fromFrame setup:(void (^ _Nullable)(void))setup completion:(void (^ _Nullable)(void))completion;
        [Export("presentAnimatedFromParentViewController:fromView:fromFrame:setup:completion:")]
        void PresentAnimatedFromParentViewController(UIViewController viewController, [NullAllowed] UIView fromView, CGRect fromFrame, [NullAllowed] Action setup, [NullAllowed] Action completion);

        // -(void)presentAnimatedFromParentViewController:(UIViewController * _Nonnull)viewController fromImage:(UIImage * _Nullable)image fromView:(UIView * _Nullable)fromView fromFrame:(CGRect)fromFrame angle:(NSInteger)angle toImageFrame:(CGRect)toFrame setup:(void (^ _Nullable)(void))setup completion:(void (^ _Nullable)(void))completion;
        [Export("presentAnimatedFromParentViewController:fromImage:fromView:fromFrame:angle:toImageFrame:setup:completion:")]
        void PresentAnimatedFromParentViewController(UIViewController viewController, [NullAllowed] UIImage image, [NullAllowed] UIView fromView, CGRect fromFrame, nint angle, CGRect toFrame, [NullAllowed] Action setup, [NullAllowed] Action completion);

        // -(void)dismissAnimatedFromParentViewController:(UIViewController * _Nonnull)viewController toView:(UIView * _Nullable)toView toFrame:(CGRect)frame setup:(void (^ _Nullable)(void))setup completion:(void (^ _Nullable)(void))completion;
        [Export("dismissAnimatedFromParentViewController:toView:toFrame:setup:completion:")]
        void DismissAnimatedFromParentViewController(UIViewController viewController, [NullAllowed] UIView toView, CGRect frame, [NullAllowed] Action setup, [NullAllowed] Action completion);

        // -(void)dismissAnimatedFromParentViewController:(UIViewController * _Nonnull)viewController withCroppedImage:(UIImage * _Nullable)image toView:(UIView * _Nullable)toView toFrame:(CGRect)frame setup:(void (^ _Nullable)(void))setup completion:(void (^ _Nullable)(void))completion;
        [Export("dismissAnimatedFromParentViewController:withCroppedImage:toView:toFrame:setup:completion:")]
        void DismissAnimatedFromParentViewController(UIViewController viewController, [NullAllowed] UIImage image, [NullAllowed] UIView toView, CGRect frame, [NullAllowed] Action setup, [NullAllowed] Action completion);
    }

}

