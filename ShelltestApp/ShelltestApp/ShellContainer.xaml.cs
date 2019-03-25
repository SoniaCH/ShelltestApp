using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShelltestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShellContainer : Shell
    {
        public ShellContainer()
        {
            InitializeComponent();
        }
    }
}