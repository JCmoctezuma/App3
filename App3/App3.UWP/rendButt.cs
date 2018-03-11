using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using app3.Droid.Renderer;

using App3;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using System.Diagnostics;

namespace app3.Droid.Renderer
{
    public class CustomButton : Button
    {
        public event PointerEventHandler Pressed;
        public event PointerEventHandler Released;

        protected override void OnPointerPressed(Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            Pressed?.Invoke(this, e);
            Debug.WriteLine("pressed");
            e.Handled = true;
        }

        protected override void OnPointerReleased(Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            Released?.Invoke(this, e);

            Debug.WriteLine("pressed");
            e.Handled = true;
        }
    }
}