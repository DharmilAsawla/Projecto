using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projecto.UserInterface
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentView
    {
        public LoginPage()
        {
            InitializeComponent();

            
        }

        private void ButtonLogin_Clicked(object sender, EventArgs e)
        {

        }
    }
}