using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages
{
    public partial class XamarinEssentialsPage : ContentPage
    {
        private bool IsPortrait;
        public XamarinEssentialsPage()
        {
            InitializeComponent();
            IsPortrait = DeviceDisplay.ScreenMetrics.Orientation == ScreenOrientation.Portrait;
            UpdateLayout();
            back.Command = new Command(() => Navigation.PopModalAsync());
        }
        
        void UpdateLayout()
        {
            grid.RowDefinitions.Clear();
            grid.ColumnDefinitions.Clear();
            grid.Children.Clear();

            if(IsPortrait)
            {
                SetupPortraitLayout();
            }
            else 
            {
                SetupLandscapeLayout();
            }
        }

        void SetupLandscapeLayout()
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(view: title, left: 0, top: 0);
            grid.Children.Add(view: description, left: 0, top: 1);
            grid.Children.Add(view: fullTextLayout, left: 1, right: 2, top: 0, bottom: 3);
            grid.Children.Add(view: back, left: 0, top: 2);
            
            BackgroundColor = Color.DarkBlue;
            background.Opacity = 1.0;
            
            grid.Children.Add(view: background, left: 2, right: 3, top: 0, bottom: 3);
            grid.LowerChild(background);
                       
        }

        void SetupPortraitLayout()
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(view: title, left: 0, top: 0);
            grid.Children.Add(view: description, left: 0, top: 1);
            grid.Children.Add(view: fullTextLayout, left: 0, top: 2);
            grid.Children.Add(view: back, left: 0, top: 3);
            
            BackgroundColor = Color.Black;
            background.Opacity = 0.6;
            
            grid.Children.Add(view: background, left: 0, right: 1, top: 0, bottom: 5);
            grid.LowerChild(background);
        }
    }
}
