using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XplatformProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {

        public TabbedPage1()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            DateTime dt = DateTime.Now;
            string myDate = dt.ToString("dd.MM");
            if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                string xaml1 = "<Page1 Title=\"Пн " + myDate + " \" />";
                pn.LoadFromXaml(xaml1);
                DateTime dt2 = dt.AddDays(1);
                string d2 = dt2.ToString("dd.MM");
                DateTime dt3 = DateTime.Now.AddDays(2);
                string d3 = dt3.ToString("dd.MM");
                DateTime dt4 = DateTime.Now.AddDays(3);
                string d4 = dt4.ToString("dd.MM");
                DateTime dt5 = DateTime.Now.AddDays(4);
                string d5 = dt5.ToString("dd.MM");
                DateTime dt6 = DateTime.Now.AddDays(5);
                string d6 = dt6.ToString("dd.MM");
                string xaml2 = "<Page2 Title=\"Вт " + d2 + " \" />";
                vt.LoadFromXaml(xaml2);
                string xaml3 = "<Page3 Title=\"Ср " + d3 + " \" />";
                sr.LoadFromXaml(xaml3);
                string xaml4 = "<Page4 Title=\"Чт " + d4 + " \" />";
                ch.LoadFromXaml(xaml4);
                string xaml5 = "<Page5 Title=\"Пт " + d5 + " \" />";
                pyt.LoadFromXaml(xaml5);
                string xaml6 = "<Page6 Title=\"Сб " + d6 + " \" />";
                sub.LoadFromXaml(xaml6);
            }
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
            {
                DateTime dt2 = DateTime.Now.AddDays(-1);
                string d2 = dt2.ToString("dd.MM");
                string xaml1 = "<Page1 Title=\"Пн " + d2 + " \" />";
                pn.LoadFromXaml(xaml1);
                DateTime dt3 = DateTime.Now.AddDays(1);
                string d3 = dt3.ToString("dd.MM");
                DateTime dt4 = DateTime.Now.AddDays(2);
                string d4 = dt4.ToString("dd.MM");
                DateTime dt5 = DateTime.Now.AddDays(3);
                string d5 = dt5.ToString("dd.MM");
                DateTime dt6 = DateTime.Now.AddDays(4);
                string d6 = dt6.ToString("dd.MM");
                string xaml2 = "<Page2 Title=\"Вт " + myDate + " \" />";
                vt.LoadFromXaml(xaml2);
                string xaml3 = "<Page3 Title=\"Ср " + d3 + " \" />";
                sr.LoadFromXaml(xaml3);
                string xaml4 = "<Page4 Title=\"Чт " + d4 + " \" />";
                ch.LoadFromXaml(xaml4);
                string xaml5 = "<Page5 Title=\"Пт " + d5 + " \" />";
                pyt.LoadFromXaml(xaml5);
                string xaml6 = "<Page6 Title=\"Сб " + d6 + " \" />";
                sub.LoadFromXaml(xaml6);
            }
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
            {

                DateTime dt2 = DateTime.Now.AddDays(-2);
                DateTime dt3 = DateTime.Now.AddDays(-1);
                DateTime dt4 = DateTime.Now.AddDays(1);
                DateTime dt5 = DateTime.Now.AddDays(2);
                DateTime dt6 = DateTime.Now.AddDays(3);
                string d2 = dt2.ToString("dd.MM");
                string d3 = dt3.ToString("dd.MM");
                string d4 = dt4.ToString("dd.MM");
                string d5 = dt5.ToString("dd.MM");
                string d6 = dt6.ToString("dd.MM");

                string xaml1 = "<Page1 Title=\"Пн " + d2 + " \" />";
                pn.LoadFromXaml(xaml1);
                string xaml2 = "<Page2 Title=\"Вт " + d3 + " \" />";
                vt.LoadFromXaml(xaml2);
                string xaml3 = "<Page3 Title=\"Ср " + myDate + " \" />";
                sr.LoadFromXaml(xaml3);
                string xaml4 = "<Page4 Title=\"Чт " + d4 + " \" />";
                ch.LoadFromXaml(xaml4);
                string xaml5 = "<Page5 Title=\"Пт " + d5 + " \" />";
                pyt.LoadFromXaml(xaml5);
                string xaml6 = "<Page6 Title=\"Сб " + d6 + " \" />";
                sub.LoadFromXaml(xaml6);
            }
            if (dt.DayOfWeek == DayOfWeek.Thursday)
            {

                DateTime dt2 = DateTime.Now.AddDays(-3);
                DateTime dt3 = DateTime.Now.AddDays(-2);
                DateTime dt4 = DateTime.Now.AddDays(-1);
                DateTime dt5 = DateTime.Now.AddDays(1);
                DateTime dt6 = DateTime.Now.AddDays(2);
                string d2 = dt2.ToString("dd.MM");
                string d3 = dt3.ToString("dd.MM");
                string d4 = dt4.ToString("dd.MM");
                string d5 = dt5.ToString("dd.MM");
                string d6 = dt6.ToString("dd.MM");

                string xaml1 = "<Page1 Title=\"Пн " + d2 + " \" />";
                pn.LoadFromXaml(xaml1);
                string xaml2 = "<Page2 Title=\"Вт " + d3 + " \" />";
                vt.LoadFromXaml(xaml2);
                string xaml3 = "<Page3 Title=\"Ср " + d4 + " \" />";
                sr.LoadFromXaml(xaml3);
                string xaml4 = "<Page4 Title=\"Чт " + myDate + " \" />";
                ch.LoadFromXaml(xaml4);
                string xaml5 = "<Page5 Title=\"Пт " + d5 + " \" />";
                pyt.LoadFromXaml(xaml5);
                string xaml6 = "<Page6 Title=\"Сб " + d6 + " \" />";
                sub.LoadFromXaml(xaml6);
            }
            if (dt.DayOfWeek == DayOfWeek.Friday)
            {

                DateTime dt2 = DateTime.Now.AddDays(-4);
                DateTime dt3 = DateTime.Now.AddDays(-3);
                DateTime dt4 = DateTime.Now.AddDays(-2);
                DateTime dt5 = DateTime.Now.AddDays(-1);
                DateTime dt6 = DateTime.Now.AddDays(1);
                string d2 = dt2.ToString("dd.MM");
                string d3 = dt3.ToString("dd.MM");
                string d4 = dt4.ToString("dd.MM");
                string d5 = dt5.ToString("dd.MM");
                string d6 = dt6.ToString("dd.MM");

                string xaml1 = "<Page1 Title=\"Пн " + d2 + " \" />";
                pn.LoadFromXaml(xaml1);
                string xaml2 = "<Page2 Title=\"Вт " + d3 + " \" />";
                vt.LoadFromXaml(xaml2);
                string xaml3 = "<Page3 Title=\"Ср " + d4 + " \" />";
                sr.LoadFromXaml(xaml3);
                string xaml4 = "<Page4 Title=\"Чт " + d5 + " \" />";
                ch.LoadFromXaml(xaml4);
                string xaml5 = "<Page5 Title=\"Пт " + myDate + " \" />";
                pyt.LoadFromXaml(xaml5);
                string xaml6 = "<Page6 Title=\"Сб " + d6 + " \" />";
                sub.LoadFromXaml(xaml6);
            }
            if (dt.DayOfWeek == DayOfWeek.Saturday)
            {

                DateTime dt2 = DateTime.Now.AddDays(-5);
                DateTime dt3 = DateTime.Now.AddDays(-4);
                DateTime dt4 = DateTime.Now.AddDays(-3);
                DateTime dt5 = DateTime.Now.AddDays(-2);
                DateTime dt6 = DateTime.Now.AddDays(-1);
                string d2 = dt2.ToString("dd.MM");
                string d3 = dt3.ToString("dd.MM");
                string d4 = dt4.ToString("dd.MM");
                string d5 = dt5.ToString("dd.MM");
                string d6 = dt6.ToString("dd.MM");

                string xaml1 = "<Page1 Title=\"Пн " + d2 + " \" />";
                pn.LoadFromXaml(xaml1);
                string xaml2 = "<Page2 Title=\"Вт " + d3 + " \" />";
                vt.LoadFromXaml(xaml2);
                string xaml3 = "<Page3 Title=\"Ср " + d4 + " \" />";
                sr.LoadFromXaml(xaml3);
                string xaml4 = "<Page4 Title=\"Чт " + d5 + " \" />";
                ch.LoadFromXaml(xaml4);
                string xaml5 = "<Page5 Title=\"Пт " + d6 + " \" />";
                pyt.LoadFromXaml(xaml5);
                string xaml6 = "<Page6 Title=\"Сб " + myDate + " \" />";
                sub.LoadFromXaml(xaml6);
            }
            if (dt.DayOfWeek == DayOfWeek.Sunday)
            {

                DateTime dt2 = DateTime.Now.AddDays(-6);
                DateTime dt3 = DateTime.Now.AddDays(-5);
                DateTime dt4 = DateTime.Now.AddDays(-4);
                DateTime dt5 = DateTime.Now.AddDays(-3);
                DateTime dt6 = DateTime.Now.AddDays(-2);
                DateTime dt7 = DateTime.Now.AddDays(-1);
                string d2 = dt2.ToString("dd.MM");
                string d3 = dt3.ToString("dd.MM");
                string d4 = dt4.ToString("dd.MM");
                string d5 = dt5.ToString("dd.MM");
                string d6 = dt6.ToString("dd.MM");
                string d7 = dt7.ToString("dd.MM");

                string xaml1 = "<Page1 Title=\"Пн " + d2 + " \" />";
                pn.LoadFromXaml(xaml1);
                string xaml2 = "<Page2 Title=\"Вт " + d3 + " \" />";
                vt.LoadFromXaml(xaml2);
                string xaml3 = "<Page3 Title=\"Ср " + d4 + " \" />";
                sr.LoadFromXaml(xaml3);
                string xaml4 = "<Page4 Title=\"Чт " + d5 + " \" />";
                ch.LoadFromXaml(xaml4);
                string xaml5 = "<Page5 Title=\"Пт " + d6 + " \" />";
                pyt.LoadFromXaml(xaml5);
                string xaml6 = "<Page6 Title=\"Сб " + d7 + " \" />";
                sub.LoadFromXaml(xaml6);
            }
        }

    }
}