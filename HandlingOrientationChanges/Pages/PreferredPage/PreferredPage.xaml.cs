using System;
using System.Collections.Generic;
using HandlingOrientationChanges.Pages.BasePage;
using HandlingOrientationChanges.Pages.SwapViews;
using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages.PreferredPage
{
    public partial class PreferredPage : PreferredOrientationContentPage
    {
        private SwapLandscape Landscape;
        private SwapPortrait Portrait;
        
        public PreferredPage()
        {
            InitializeComponent();
            Portrait = new SwapPortrait();
            Landscape = new SwapLandscape();
        }

        protected override void SetupLandscapeLayout()
        {
            Content = Landscape;
        }

        protected override void SetupPortraitLayout()
        {
            Content = Portrait;
        }
    }
}
