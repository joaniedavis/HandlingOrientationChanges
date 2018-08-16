using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages.SwapViews
{
    public partial class SwapLandscape : ContentView
    {
        public SwapLandscape()
        {
            InitializeComponent();
            back.Command = new Command(() => Navigation.PopModalAsync());
        }
    }
}
