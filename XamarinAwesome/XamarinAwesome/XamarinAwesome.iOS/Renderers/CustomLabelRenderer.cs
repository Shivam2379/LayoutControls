using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinAwesome.Control;
using XamarinAwesome.iOS.Renderers;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace XamarinAwesome.iOS.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            //if (e.OldElement == null)
            //{
            //var gradient = new CAGradientLayer();
            //gradient.CornerRadius = Control.Layer.CornerRadius = 10;
            //gradient.Frame = Control.Bounds;
            //gradient.StartPoint =new CGPoint(0.5, 0.0);
            //gradient.EndPoint = new CGPoint(0.5, 1.0);
            //gradient.Colors = new CGColor[]
            //{
            //    UIColor.FromRGB(51, 102, 104).CGColor,
            //    UIColor.FromRGB(20, 70, 234).CGColor
            //};
            //var layer = Control?.Layer.Sublayers.FirstOrDefault();
            // Control?.Layer.InsertSublayerBelow(gradient, layer);
            // }
        }
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            var btn = (CustomLabel)this.Element;
            CGColor startColor = Color.FromHex(btn.StartColor).ToCGColor();
            CGColor endColor = Color.FromHex(btn.EndColor).ToCGColor();
            #region for Vertical Gradient  
            //var gradientLayer = new CAGradientLayer();     
            #endregion
            #region for Horizontal Gradient  
            var gradientLayer = new CAGradientLayer()
            {
                StartPoint = new CGPoint(0, 0.5),
                EndPoint = new CGPoint(1, 0.5)
            };
            #endregion
            gradientLayer.Frame = rect;
            gradientLayer.Colors = new CGColor[] {
                startColor,
                endColor
            };
            NativeView.Layer.InsertSublayer(gradientLayer, 0);
        }
        //protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        //{
        //    base.OnElementChanged(e);
        //    var view = (CustomButton)Element;
        //    if (view == null) return;
        //    Paint(view);
        //}

        //protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    base.OnElementPropertyChanged(sender, e);
        //    if (e.PropertyName == CustomButton.CustomBorderRadiusProperty.PropertyName ||
        //       e.PropertyName == CustomButton.CustomBorderColorProperty.PropertyName ||
        //       e.PropertyName == CustomButton.CustomBorderWidthProperty.PropertyName)
        //    {
        //        if (Element != null)
        //        {
        //            Paint((CustomButton)Element);
        //        }
        //    }
        //}
        //private void Paint(CustomButton view)
        //{
        //    this.Layer.CornerRadius = (float)view.CustomBorderRadius;
        //    this.Layer.BorderColor = view.CustomBorderColor.ToCGColor();
        //    this.Layer.BackgroundColor = view.CustomBackgroundColor.ToCGColor();
        //    this.Layer.BorderWidth = (int)view.CustomBorderWidth;
        //    Control.LineBreakMode = UIKit.UILineBreakMode.WordWrap;
        //}
    }
}