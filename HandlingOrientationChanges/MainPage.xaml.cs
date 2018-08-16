using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandlingOrientationChanges.Pages;
using HandlingOrientationChanges.Pages.SwapViews;
using HandlingOrientationChanges.ViewModels;
using Xamarin.Forms;

namespace HandlingOrientationChanges
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            sizeAllocatedR.Command = new Command(() => Navigation.PushModalAsync(new OnSizeAllocatedRearrangePage()
            {
                BindingContext = new PageViewModel()
            }));
            sizeAllocatedS.Command = new Command(() => Navigation.PushModalAsync(new OnSizeAllocatedSwapViewsPage()
            {
                BindingContext = new PageViewModel()
            }));
            basePage.Command = new Command(() => Navigation.PushModalAsync(new UsingBasePage()
            {
                BindingContext = new PageViewModel()
            }));
            xamarinEss.Command = new Command(() => Navigation.PushModalAsync(new XamarinEssentialsPage()
            {
                BindingContext = new PageViewModel()
            }));
        }
    }
}
