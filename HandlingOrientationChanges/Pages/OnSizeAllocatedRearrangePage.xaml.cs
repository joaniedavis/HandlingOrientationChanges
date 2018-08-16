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

                grid.RowDefinitions.Clear();
                grid.ColumnDefinitions.Clear();

                if(width > height)
                {
                    SetupLandscapeLayout();
                }
                else 
                {
                    SetupPortraitLayout();
                }
            }
        }

        void SetupLandscapeLayout()
        {
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            grid.Children.Add(view: title, left: 0, top: 0);
            grid.Children.Add(view: title, left: 0, top: 0);
            grid.Children.Add(view: title, left: 0, top: 0);
                       
        }

        void SetupPortraitLayout()
        {
            
        }
    }
}
