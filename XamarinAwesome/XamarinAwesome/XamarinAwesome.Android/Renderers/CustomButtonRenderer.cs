using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinAwesome.Control;
using XamarinAwesome.Droid.Renderers;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace XamarinAwesome.Droid.Renderers
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context) { }

        private GradientDrawable _gradientBackground;
        private ColorStateList colorStateList;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var view = (CustomButton)Element;
            if (view == null) return;
            Paint(view, view.StartColor, view.EndColor);
            var control = Control as Android.Widget.Button;
            control.Touch += (object sender, TouchEventArgs args) =>
            {
                args.Handled = false;
                if (view.AnimateCustomButton)
                {
                    if (args.Event.Action == MotionEventActions.Up || args.Event.Action == MotionEventActions.Cancel)
                    {
                        view.CustomBorderColor = Color.FromHex("#ECECEC");
                    }

                    else
                    {
                        //view.CustomBorderColor = Color.FromHex("#0386BD");
                    }
                }
            };
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == CustomButton.CustomBorderColorProperty.PropertyName ||
                 e.PropertyName == CustomButton.CustomBorderRadiusProperty.PropertyName ||
                 e.PropertyName == CustomButton.CustomBorderWidthProperty.PropertyName)
            {
                if (Element != null)
                {
                    Paint((CustomButton)Element, ((CustomButton)Element).StartColor, ((CustomButton)Element).EndColor);
                }
            }
        }
        private void Paint(CustomButton view, string startColor, string EndColor)
        {
            int[] colors = { Android.Graphics.Color.ParseColor(startColor), Android.Graphics.Color.ParseColor(EndColor) };
            int[] colors2 = { Android.Graphics.Color.ParseColor(EndColor), Android.Graphics.Color.ParseColor(startColor) };

            _gradientBackground = new GradientDrawable(GradientDrawable.Orientation.LeftRight, colors);
            colorStateList = new ColorStateList(new int[][]{
                new int[]{},
                new int[]{} }, colors2);
            //_gradientBackground.SetShape(ShapeType.Rectangle);
            //_gradientBackground.SetColors(colors);
            //_gradientBackground.SetColor(view.CustomBackgroundColor.ToAndroid());
            // Thickness of the stroke line  
            _gradientBackground.SetStroke((int)view.CustomBorderWidth, view.CustomBorderColor.ToAndroid());
            // Radius for the curves  
            _gradientBackground.SetCornerRadius(
                DpToPixels(this.Context, Convert.ToSingle(view.CustomBorderRadius)));
            // set the background of the label  
            Control.SetBackground(_gradientBackground);
            Control.SetTextColor(colorStateList);

            Control.SetPadding(2, 2, 2, 2);
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}