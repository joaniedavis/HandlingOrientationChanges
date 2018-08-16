using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages.SwapViews
{
    public partial class SwapPortrait : ContentView
    {
        public SwapPortrait()
        {
            InitializeComponent();
            back.Command = new Command(() => Navigation.PopModalAsync());
        }
    }
}
