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

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace XamarinAwesome.Droid.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        public CustomLabelRenderer(Context context) : base(context) { }

        private GradientDrawable _gradientBackground;
        private ColorStateList colorStateList;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);
            var view = (CustomLabel)Element;
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
            if (e.PropertyName == CustomLabel.CustomBorderColorProperty.PropertyName ||
                 e.PropertyName == CustomLabel.CustomBorderRadiusProperty.PropertyName ||
                 e.PropertyName == CustomLabel.CustomBorderWidthProperty.PropertyName)
            {
                if (Element != null)
                {
                    Paint((CustomLabel)Element, ((CustomLabel)Element).StartColor, ((CustomLabel)Element).EndColor);
                }
            }
        }
        private void Paint(CustomLabel view, string startColor, string EndColor)
        {
            int[] colors = { Android.Graphics.Color.ParseColor(startColor), Android.Graphics.Color.ParseColor(EndColor) };
            _gradientBackground = new GradientDrawable(GradientDrawable.Orientation.LeftRight, colors);
            colorStateList = new ColorStateList(new int[][]{
                new int[]{},
                new int[]{} }, colors);
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
            //Control.SetTextColor(colorStateList);
            Control.SetPadding(2, 2, 2, 2);
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}