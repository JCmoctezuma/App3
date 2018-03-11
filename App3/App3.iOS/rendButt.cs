using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using App3;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Xamarin.Forms.Button), typeof(app3.iOS.Renderer.CustomButtonRenderer))]
namespace app3.iOS.Renderer
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            var customButton = e.NewElement as CustomButton;

            var thisButton = Control as UIButton;
            thisButton.TouchDown += delegate
            {
                customButton.OnPressed();
            };
            thisButton.TouchUpInside += delegate
            {
                customButton.OnReleased();
            };
        }
    }
}