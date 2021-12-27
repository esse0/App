using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XplatformProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            picker.Items.Add("ИСИТ-1");
            picker.Items.Add("ИСИТ-2");
            picker.Items.Add("ИСИТ-3");
            picker.Items.Add("ПОИТ-4");
            picker.Items.Add("ПОИТ-5");
            picker.Items.Add("ПОИТ-6");
            picker.Items.Add("ПОИБМС-7");
            picker.Items.Add("ПОИБМС-8");
            picker.Items.Add("ДЭиВИ-9");
            picker.Items.Add("ДЭиВИ-10");
        }
        void tohw(object sender, System.EventArgs e)
        {
            //var pag = new Page7();
            //Navigation.PushAsync(pag);
            DisplayAlert("       ", "Данный раздел находится в разработке...", "Ok");
        }
        void ToPoit4(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }
        void ToPoit5(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }


        void ToPoit6(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }



        void ToIsit1(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }
        void ToIsit2(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }
        void ToIsit3(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }

        void ToPoib7(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }

        void ToPoib8(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }
        void ToDeivi9(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }
        void ToDeivi10(object sender, System.EventArgs e)
        {
            var page = new TabbedPage1();
            Navigation.PushAsync(page);
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            string nam = picker.Items[picker.SelectedIndex];
            Application.Current.Properties["Group"] = nam;

            if (name == "ПОИТ-6")
            {

                string xaml1 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml1);
                string xaml3 = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml3);

                string xaml6 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml6);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);
                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml = "<Frame IsVisible=\"true\" />";
                butt.LoadFromXaml(xaml);
                butt.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ПОИТ-4")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml3 = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml3);

                string xaml6 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml6);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml = "<Frame IsVisible=\"true\" />";
                poit.LoadFromXaml(xaml);
                poit.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ПОИТ-5")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);

                string xaml6 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml6);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml = "<Frame IsVisible=\"true\" />";
                pot.LoadFromXaml(xaml);
                pot.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ИСИТ-1")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);
                string xaml = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);



                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);

                string xaml3 = "<Frame IsVisible=\"true\" />";
                isit.LoadFromXaml(xaml3);
                isit.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ИСИТ-2")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);
                string xaml = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml);


                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);
                string xaml3 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml3);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml4 = "<Frame IsVisible=\"true\" />";
                isi.LoadFromXaml(xaml4);
                isi.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ИСИТ-3")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);
                string xaml = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml);


                string xaml3 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml3);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml5 = "<Frame IsVisible=\"true\" />";
                isii.LoadFromXaml(xaml5);
                isii.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ПОИБМС-7")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);
                string xaml = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml);


                string xaml3 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml3);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);


                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml7 = "<Frame IsVisible=\"true\" />";
                poib.LoadFromXaml(xaml7);
                poib.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ПОИБМС-8")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);
                string xaml = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml);


                string xaml3 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml3);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml8 = "<Frame IsVisible=\"true\" />";
                poibb.LoadFromXaml(xaml8);
                poibb.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ДЭиВИ-9")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);
                string xaml = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml);


                string xaml3 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml3);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);
                string xaml8 = "<Frame IsVisible=\"false\" />";
                poibb.LoadFromXaml(xaml8);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);

                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml9 = "<Frame IsVisible=\"true\" />";
                deiv.LoadFromXaml(xaml9);
                deiv.FadeTo(1, 1500, Easing.Linear);
            }
            if (name == "ДЭиВИ-10")
            {
                string xaml1 = "<Frame IsVisible=\"false\" />";
                butt.LoadFromXaml(xaml1);
                string xaml2 = "<Frame IsVisible=\"false\" />";
                poit.LoadFromXaml(xaml2);
                string xaml = "<Frame IsVisible=\"false\" />";
                pot.LoadFromXaml(xaml);


                string xaml3 = "<Frame IsVisible=\"false\" />";
                isit.LoadFromXaml(xaml3);
                string xaml4 = "<Frame IsVisible=\"false\" />";
                isi.LoadFromXaml(xaml4);
                string xaml5 = "<Frame IsVisible=\"false\" />";
                isii.LoadFromXaml(xaml5);

                string xaml7 = "<Frame IsVisible=\"false\" />";
                poib.LoadFromXaml(xaml7);
                string xaml9 = "<Frame IsVisible=\"false\" />";
                deiv.LoadFromXaml(xaml9);
                string xaml10 = "<Frame IsVisible=\"false\" />";
                deivv.LoadFromXaml(xaml10);

                string xaml8 = "<Frame IsVisible=\"true\" />";
                deivv.LoadFromXaml(xaml8);
                deivv.FadeTo(1, 1500, Easing.Linear);
            }
        }
    }
}
