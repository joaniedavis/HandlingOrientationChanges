using System.Drawing;
using HandlingOrientationChanges.Pages.BasePage;
using HandlingOrientationChanges.Pages.SwapViews;
using Xamarin.Forms.Internals;

namespace HandlingOrientationChanges.Pages.PreferredPage
{
    public partial class PreferredPage : PreferredOrientationContentPage
    {
        
        public PreferredPage()
        {
            InitializeComponent();
            this.PortraitLayoutType = typeof(SwapPortrait);
        }


        protected override void SetupLandscapeLayout()
        {
            Content = new SwapLandscape();
            Content.BackgroundColor = Color.DarkSlateGray;
        }
    }
}
