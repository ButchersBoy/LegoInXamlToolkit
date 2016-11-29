using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace LegoInXamlToolkit
{
    public class LegoMale : Control
    {
        public LegoMale()
        {
            this.DefaultStyleKey = typeof(LegoMale);
            PointerEntered += (sender, args) => VisualStateManager.GoToState(this, "PointerOver", true);
            PointerExited += (sender, args) => VisualStateManager.GoToState(this, "Normal", true);            
        }

        public static readonly DependencyProperty FillProperty = DependencyProperty.Register(
            "Fill", typeof(Brush), typeof(LegoMale), new PropertyMetadata(default(Brush)));

        public Brush Fill
        {
            get { return (Brush) GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }        
    }
}
