using System;
using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages.BasePage
{
    public abstract class PreferredOrientationContentPage : ContentPage
    {
        private double width = 0;
        private double height = 0;
        protected Type LandscapeLayoutType;
        protected Type PortraitLayoutType;

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

        protected virtual void SetupLandscapeLayout()
        {
            if (LandscapeLayoutType != null)
            {
                Content = Activator.CreateInstance(LandscapeLayoutType) as View; 
            }
        }

        protected virtual void SetupPortraitLayout()
        {
            if (PortraitLayoutType != null)
            {
                Content = Activator.CreateInstance(PortraitLayoutType) as View;
            }
        }
    } 
}