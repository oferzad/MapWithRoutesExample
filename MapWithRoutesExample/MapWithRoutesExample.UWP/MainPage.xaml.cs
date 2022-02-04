using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MapWithRoutesExample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Maps key - AmXQdUA8yDAhmiRdH90spOr9fsp0YMx4rDk_A8CgH4tWpXK4Xklm7R9mfH8-F3Yu
            Xamarin.FormsMaps.Init("AmXQdUA8yDAhmiRdH90spOr9fsp0YMx4rDk_A8CgH4tWpXK4Xklm7R9mfH8-F3Yu");

            LoadApplication(new MapWithRoutesExample.App());
        }
    }
}
