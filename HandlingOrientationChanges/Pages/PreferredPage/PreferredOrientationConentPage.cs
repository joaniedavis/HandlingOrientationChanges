using System;
using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages.BasePage
{
    public abstract class PreferredOrientationContentPage : ContentPage
    {
        private double width = 0;
        private double height = 0;

        public event EventHandler<PageOrientationEventArgs> OnOrientationChanged = (e, a) => { };

        public PreferredOrientationContentPage() : base()
        {
            Init();
        }

        private void Init()
        {
            width = this.Width;
            height = this.Height;
            UpdateLayout();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height); //must be called

            if (this.width != width || this.height != height)
            {
                this.width = width;
                this.height = height;
                
                UpdateLayout();
            } 
        }
        
        void UpdateLayout()
        {
            if(width > height)
            {
                SetupLandscapeLayout();
            }
            else 
            {
                SetupPortraitLayout();
            }
        }
        
        protected abstract void SetupLandscapeLayout();
        protected abstract void SetupPortraitLayout();
    } 
}