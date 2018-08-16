using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HandlingOrientationChanges.Pages
{
    public partial class OnSizeAllocatedRearrangePage : ContentPage
    {
        public OnSizeAllocatedRearrangePage()
        {
            InitializeComponent();
            width = this.Width;
            height = this.Height;

            back.Command = new Command(() => Navigation.PopModalAsync());
            
        }

        private double width = 0;
        private double height = 0;

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
            grid.RowDefinitions.Clear();
            grid.ColumnDefinitions.Clear();
            grid.Children.Clear();

            if(width > height)
            {
                SetupLandscapeLayout();
            }
            else 
            {
                SetupPortraitLayout();
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
            
            grid.Children.Add(view: background, left: 3, right: 4, top: 0, bottom: 3);
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
            
            grid.Children.Add(view: background, left: 0, right: 1, top: 0, bottom: 5);
            grid.LowerChild(background);
        }
    }
}
