using System;
using ObjCRuntime;

namespace Xam.Plugins.ImageCropper.iOS
{
    [Native]
    public enum TOCropViewControllerAspectRatio : long
    {
        Original,
        Square,
        TOCropViewControllerAspectRatio3x2,
        TOCropViewControllerAspectRatio5x3,
        TOCropViewControllerAspectRatio4x3,
        TOCropViewControllerAspectRatio5x4,
        TOCropViewControllerAspectRatio7x5,
        TOCropViewControllerAspectRatio16x9
    }

    [Native]
    public enum TOCropViewControllerToolbarPosition : long
    {
        Top,
        Bottom
    }
}

