using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages.SwapViews
{
    public partial class OnSizeAllocatedSwapViewsPage : ContentPage
    {
        
        private double width = 0;
        private double height = 0;

        private SwapLandscape Landscape;
        private SwapPortrait Portrait;
        
        public OnSizeAllocatedSwapViewsPage()
        {
            InitializeComponent();
            Portrait = new SwapPortrait();
            Landscape = new SwapLandscape();
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
            if (width > height)
            {
                Content = Landscape;
            }
            else
            {
                Content = Portrait;
            }
        }
    }
}
