using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace PhoneApp6
{
    public partial class ArcControl : UserControl
    {
        public ArcControl()
        {
            InitializeComponent();
        }




        public int Percentage
        {
            get { return (int)GetValue(PercentageProperty); }
            set 
            { 
                SetValue(PercentageProperty, value);
                Arc_to_Rotate.EndAngle = value * 3.6;
            }
        }


        // Using a DependencyProperty as the backing store for Percentage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PercentageProperty =
            DependencyProperty.Register("Percentage", typeof(int), typeof(ArcControl), new PropertyMetadata(0));








        public Brush ArcColor
        {
            get { return (Brush)GetValue(ArcColorProperty); }
            set { SetValue(ArcColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ArcColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ArcColorProperty =
            DependencyProperty.Register("ArcColor", typeof(Brush), typeof(ArcControl), null);

        
        


        


        
        
		
    }
}
