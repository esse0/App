using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XplatformProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        int c = 0;
        public Page1()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, System.EventArgs e)
        {
            c += 1;
            Button btn = (Button)sender;
            if(c % 2 == 0)
            {
               
                string xaml = "<StackLayout IsVisible=\"false\" />";
                Visbl.LoadFromXaml(xaml);
                Visbl.FadeTo(0, 500, Easing.Linear);
            }
            else
            {
                string xaml = "<StackLayout IsVisible=\"true\" />";
                Visbl.LoadFromXaml(xaml);
                Visbl.FadeTo(1, 1500, Easing.Linear);
            }
           
        }
        
    }
}