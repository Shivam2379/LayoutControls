using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinAwesome.Control
{
    public class CustomButton : Button
    {
        public static readonly BindableProperty CustomBorderColorProperty =
              BindableProperty.Create(
                  nameof(CustomBorderColor),
                  typeof(Color),
                  typeof(CustomButton),
                  Color.Default);

        public Color CustomBorderColor
        {
            get { return (Color)GetValue(CustomBorderColorProperty); }
            set { SetValue(CustomBorderColorProperty, value); }
        }

        public static readonly BindableProperty AnimateCustomButtonProperty =
           BindableProperty.Create(
               nameof(AnimateCustomButton),
               typeof(bool),
               typeof(CustomButton),
               true);

        public bool AnimateCustomButton
        {
            get { return (bool)GetValue(AnimateCustomButtonProperty); }
            set { SetValue(AnimateCustomButtonProperty, value); }
        }

        public static readonly BindableProperty CustomBorderRadiusProperty =
             BindableProperty.Create(
                 nameof(CustomBorderRadius),
                 typeof(int),
                 typeof(CustomButton),
                 0);

        public int CustomBorderRadius
        {
            get { return (int)GetValue(CustomBorderRadiusProperty); }
            set { SetValue(CustomBorderRadiusProperty, value); }
        }

        public static readonly BindableProperty CustomBackgroundColorProperty =
           BindableProperty.Create(
               nameof(CustomBackgroundColor),
               typeof(Color),
               typeof(CustomButton),
               Color.Default
              );

        public Color CustomBackgroundColor
        {
            get { return (Color)GetValue(CustomBackgroundColorProperty); }
            set { SetValue(CustomBackgroundColorProperty, value); }
        }

        public static readonly BindableProperty CustomBorderWidthProperty =
             BindableProperty.Create(
                 nameof(CustomBorderWidth),
                 typeof(double),
                 typeof(CustomButton),
                 0.0);

        public double CustomBorderWidth
        {
            get { return (double)GetValue(CustomBorderWidthProperty); }
            set { SetValue(CustomBorderWidthProperty, value); }
        }
        public static readonly BindableProperty StartColorProperty = BindableProperty.Create("StartColor", typeof(string), typeof(CustomButton), "#729CC3");
        public static readonly BindableProperty EndColorProperty = BindableProperty.Create("EndColor", typeof(string), typeof(CustomButton), "#4676A3");
        public string StartColor
        {
            get
            {
                return (string)GetValue(StartColorProperty);
            }
            set
            {
                SetValue(StartColorProperty, value);
            }
        }
        public string EndColor
        {
            get
            {
                return (string)GetValue(EndColorProperty);
            }
            set
            {
                SetValue(EndColorProperty, value);
            }
        }
    }
}
