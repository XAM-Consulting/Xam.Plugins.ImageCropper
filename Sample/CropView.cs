using System;

using Xamarin.Forms;

namespace Xam.Plugins.ImageCropper.Sample
{
    public class CropView : ContentPage
    {
        public byte[] Image;
        public Action RefreshAction;
        public bool DidCrop = false;

        public CropView(byte[] imageAsByte, Action refreshAction)
        {

            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Color.Black;
            Image = imageAsByte;

            RefreshAction = refreshAction;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (DidCrop)
                RefreshAction.Invoke();
        }
    }
}


