using System;

namespace HandlingOrientationChanges.Pages.BasePage
{
    public class PageOrientationEventArgs: EventArgs
    {
        public PageOrientationEventArgs(PageOrientation orientation)
        {
            Orientation = orientation;
        }

        public PageOrientation Orientation { get; }
    }

    public enum PageOrientation
    {
        Horizontal = 0,
        Vertical = 1,
    }
        
}
