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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ProFind.Lib.Admin.Views.Professionals_Page.Controls
{
    public sealed partial class ProfessionalTile : UserControl
    {
        public ProfessionalTile()
        {
            this.InitializeComponent();
        }

      /*  public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(ProfessionalView), new PropertyMetadata(null));
*/
      public string NameXD
        {
            get { return (string)GetValue(NameXDProperty); }
            set { SetValue(NameXDProperty, value); }
        }

        public static readonly DependencyProperty NameXDProperty =
            DependencyProperty.Register("NameXD", typeof(string), typeof(ProfessionalTile), new PropertyMetadata(null));

    }
}
