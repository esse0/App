using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XplatformProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {

        int b = 0;
        int bTWO = 0;
        int bTRE = 0;
        int bFOR = 0;
        int bFIV = 0;
        
        public Page4()
        {
            InitializeComponent();

            string gr = Application.Current.Properties["Group"].ToString();
            if (gr == "ИСИТ-1")
            {
                rasp.Text = "13:00-14:20 Пз 221-общ.2 Английский язык(1 Пгр)";
                raspTWO.Text = "14:40-16:00 Лр 413-1 Скриптовые языки программирования(1 Пгр)";
                raspFOR.Text = "18:05-19:25 Лр 308-1 Компьютерные языки разметки(1 Пгр)\n\n" + "18:05-19:25 Лр 413-1 Скриптовые языки программирования(2 Пгр)";
                raspTRE.Text = "16:30-17:50 Лк 200-3а Технологии разработки программного обеспечения ст. преп. Наркевич А.С.";
                LabFIV.IsVisible = false;
            }
            if (gr == "ИСИТ-2")
            {
                raspTWO.Text = "14:40-16:00  Лр 209-1 Технологии разработки программного обеспечения(2 Пгр)\n\n" + "II Пз 221-общ.2 Английский язык(1 Пгр)";

                rasp.Text = "13:00-14:20 II Лр 304-4 Основы алгоритмизации и программирования(1 Пгр)";

                raspFOR.Text = "18:05-19:25 II Пз 508-1 Арифметико-логические основы вычислительных систем";

                raspTRE.Text = "16:30-17:50 Лк 200-3а Технологии разработки программного обеспечения ст. преп. Наркевич А.С.";
                LabFIV.IsVisible = false;
            }
            if (gr == "ИСИТ-3")
            {
                rasp.Text = "13.00-14:20 Пз 220-2 общ.Франц. язык";
                raspTWO.Text = "14:40-16:00 Лр 324-1 Скриптовые языки программирования(2 Пгр)";
                raspTRE.Text = "16:30-17:50 Лк 200-3а Технологии разработки программного обеспечения ст. преп. Наркевич А.С.";
                raspFOR.Text = "18:05-19:25 Лр 102-1 Технологии разработки программного обеспечения(1 Пгр)\n\n" + "Лр 209-1 Технологии разработки программного обеспечения(2 Пгр)";
                raspFIV.Text = "19:40-21:00 Лр 202-4 Основы алгоритмизации и программирования(1 Пгр)";
            }
            if (gr == "ПОИТ-4")
            {

                rasp.Text = "14:40-16:00 I Пз 221-общ.2 Английский язык(1 Пгр)\n\n" + "II Пз 126-4 Арифметико-логические основы вычислительных систем";

                raspTWO.Text = "Лк 200-3а Основы программной инженерии ст. преп. Наркевич А.С";
                raspTRE.Text = "18:05-19:25 Пз 111-общ.2 Английский язык(2 Пгр)";
                LabFOR.IsVisible = false;
                LabFIV.IsVisible = false;
            }
            if (gr == "ПОИТ-5")
            {

                rasp.Text = "14:40-16:00 I Пз 126-4 Арифметико-логические основы вычислительных систем\n\n" + "II Пз 120-4 Математический анализ";

                raspTWO.Text = "16:30-17:50 Лк 200-3а Основы программной инженерии ст. преп. Наркевич А.С";
                raspTRE.Text = "18:05-19 Пз 112-общ.2 Английский язык(2 Пгр)";
                LabFOR.IsVisible = false;
                LabFIV.IsVisible = false;
            }
            if (gr == "ПОИТ-6")
            {
                rasp.Text = "13.00-14:20 Пз 220-2 общ. Французский язык";
                raspTWO.Text = "14:40-16:00 Лр 322-1 Основы алгоритмизации и программирования(2 Пгр)";
                raspTRE.Text = "16:30-17:50 Лк 200-3а Основы программной инженерии ст. преп. Наркевич А.С";
                raspFOR.Text = "18:05-19:25 Пз 426-4 Белорусский язык";
                raspFIV.Text = "19:40-21:00 Лр 310а-1 Основы алгоритмизации и программирования(1 Пгр)\n\n" + "II Пз 222-общ.2 Английский язык(2 Пгр)";

            }
            if (gr == "ПОИБМС-7")//------------------------------
            {
                rasp.Text = "14:40-16:00 Пз 212-общ.2 Английский язык(1 Пгр)\n\n" + "Пз 222-общ.2 Английский язык (2 Пгр)";
                raspTWO.Text = "16:30-17:50 Лр 202-4 Технологии frontend программирования (1 Пгр)\n\n" + "Лр 324-1 Компьютерные языки разметки(2 Пгр)";
                raspTRE.Text = "18:05-19:25 Пз 328-4 Математика";
                LabFOR.IsVisible = false;
                LabFIV.IsVisible = false;
            }
            if (gr == "ПОИБМС-8")
            {

                rasp.Text = "14:40-16:00 I Пз 404, 410, 506, 512-1 Физика(1 Пгр)\n\n" + "Пз 200а-4 Основы алгоритмизации и программирования(2 Пгр)\n\n" + "II Пз 200а-4 Основы алгоритмизации и программирования(1 Пгр)\n\n" + "Пз 404, 410, 506, 512-1 Физика(2 Пгр)";

                raspTWO.Text = "16:30-17:50 Пз 212-общ.2 Английский язык(1 Пгр)\n\n" + "Пз 222-общ.2 Английский язык(2 Пгр)";
                raspTRE.Text = "18:05-19:25 Лр 310а-1 Компьютерные языки разметки(1 Пгр)\n\n" + "Лр 324-1 Компьютерные языки разметки(2 Пгр)";
                LabFOR.IsVisible = false;
                LabFIV.IsVisible = false;
            }
            if (gr == "ДЭиВИ-9")
            {

                rasp.Text = "14:40-16:00 I Лк 301-4 Математика доц. Ловенецкая Е.И\n\n" + "II Лк 313-1 Контент-менеджмент ст. преп. Потапенко Н.И";

                raspFOR.Text = "19:40-21:00 II Лр 404,410,503,513, 506,512 - 1 Физика с осн. технической оптики(1 Пгр)";

                raspTWO.Text = "16:30-17:50 Лк 313-1 Основы алгоритмизации и программирования доц.Пустовалова Н.Н";
                raspTRE.Text = "18:05-19:25 Лр 322-1 Основы алгоритмизации и программирования(1 Пгр)\n\n" + "Лр 404, 410, 503, 513, 506, 512 - 1 Физика с основами технической оптики(2 Пгр)";
                LabFIV.IsVisible = false;
            }
            if (gr == "ДЭиВИ-10")
            {
                rasp.Text = "13:00-14:20 Пз 224-2 общ.Испанский язык, Пз 220 - 2 общ.Французский язык";

                raspTWO.Text = "14:40-16:00 I Лк 301-4 Математика доц. Ловенецкая Е.И\n\n" + "II Лк 313-1 Контент-менеджмент ст. преп. Потапенко Н.И";

                raspTRE.Text = "16:30-17:50 Лк 313-1 Основы алгоритмизации и программирования доц.Пустовалова Н.Н.";
                raspFOR.Text = "18:05-19:25 Лр 404, 410, 503, 513,506, 512 - 1 Физика сосновами технической оптики (1 Пгр)\n\n" + "Пз общ.Немец язык(239-2), Пз Англ(111 - 2 общ.)(2 Пгр)";
                LabFIV.IsVisible = false;
            }
        }
        protected override void OnAppearing()
        {

            string name = Preferences.Get("cnname", " ");
            string nameTWO = Preferences.Get("cnnameTWO", " ");
            string nameTRE = Preferences.Get("cnnameTRE", " ");
            string nameFOR = Preferences.Get("cnnameFOR", " ");
            string nameFIV = Preferences.Get("cnnameFIV", " ");
            entry.Text = name;
            entryTWO.Text = nameTWO;
            entryTRE.Text = nameTRE;
            entryFOR.Text = nameFOR;
            entryFIV.Text = nameFIV;
            EntryBox.Text = name;
            EntryBoxTWO.Text = nameTWO;
            EntryBoxTRE.Text = nameTRE;
            EntryBoxFOR.Text = nameFOR;
            EntryBoxFIV.Text = nameFIV;
            string nam = Preferences.Get("cnnam", "");
            string na = Preferences.Get("cnna", "");
            string namTWO = Preferences.Get("cnnamTWO", "");
            string naTWO = Preferences.Get("cnnaTWO", "");

            string namTRE = Preferences.Get("cnnamTRE", "");
            string naTRE = Preferences.Get("cnnaTRE", "");

            string namFOR = Preferences.Get("cnnamFOR", "");
            string naFOR = Preferences.Get("cnnaFOR", "");

            string namFIV = Preferences.Get("cnnamFIV", "");
            string naFIV = Preferences.Get("cnnaFIV", "");
            if (nam == "true")
            {
                swa.IsToggled = true;
            }
            else
            {
                swa.IsToggled = false;
            }
            if (na == "true")
            {
                swaa.IsToggled = true;
            }
            else
            {
                swaa.IsToggled = false;
            }

            if (namTWO == "true")
            {
                swaTWO.IsToggled = true;
            }
            else
            {
                swaTWO.IsToggled = false;
            }

            if (naTWO == "true")
            {
                swaaTWO.IsToggled = true;
            }
            else
            {
                swaaTWO.IsToggled = false;
            }

            if (namTRE == "true")
            {
                swaTRE.IsToggled = true;
            }
            else
            {
                swaTRE.IsToggled = false;
            }

            if (naTRE == "true")
            {
                swaaTRE.IsToggled = true;
            }
            else
            {
                swaaTRE.IsToggled = false;
            }


            if (namFOR == "true")
            {
                swaFOR.IsToggled = true;
            }
            else
            {
                swaFOR.IsToggled = false;
            }

            if (naFOR == "true")
            {
                swaaFOR.IsToggled = true;
            }
            else
            {
                swaaFOR.IsToggled = false;
            }


            if (namFIV == "true")
            {
                swaFIV.IsToggled = true;
            }
            else
            {
                swaFIV.IsToggled = false;
            }

            if (naFIV == "true")
            {
                swaaFIV.IsToggled = true;
            }
            else
            {
                swaaFIV.IsToggled = false;
            }
            base.OnAppearing();
        }
        private void ButtonClicked(object sender, System.EventArgs e)
        {
            b += 1;
            if (b % 2 == 0)
            {
                Visbl.IsVisible = false;
                blk.IsVisible = false;
                blk.FadeTo(0, 100, Easing.Linear);
            }
            else
            {
                Visbl.IsVisible = false;
                blk.IsVisible = true;
                blk.FadeTo(1, 600, Easing.Linear);
            }
        }
        private void ButtonClickedTWO(object sender, System.EventArgs e)
        {
            bTWO += 1;
            if (bTWO % 2 == 0)
            {
                VisblTWO.IsVisible = false;
                blkTWO.IsVisible = false;
                blkTWO.FadeTo(0, 100, Easing.Linear);
            }
            else
            {
                VisblTWO.IsVisible = false;
                blkTWO.IsVisible = true;
                blkTWO.FadeTo(1, 600, Easing.Linear);
            }
        }
        private void ButtonClickedTRE(object sender, System.EventArgs e)
        {
            bTRE += 1;
            if (bTRE % 2 == 0)
            {
                VisblTRE.IsVisible = false;
                blkTRE.IsVisible = false;
                blkTRE.FadeTo(0, 100, Easing.Linear);
            }
            else
            {
                VisblTRE.IsVisible = false;
                blkTRE.IsVisible = true;
                blkTRE.FadeTo(1, 600, Easing.Linear);
            }
        }
        private void ButtonClickedFOR(object sender, System.EventArgs e)
        {
            bFOR += 1;
            if (bFOR % 2 == 0)
            {
                VisblFOR.IsVisible = false;
                blkFOR.IsVisible = false;
                blkFOR.FadeTo(0, 100, Easing.Linear);
            }
            else
            {
                VisblFOR.IsVisible = false;
                blkFOR.IsVisible = true;
                blkFOR.FadeTo(1, 600, Easing.Linear);
            }
        }
        private void ButtonClickedFIV(object sender, System.EventArgs e)
        {
            bFIV += 1;
            if (bFIV % 2 == 0)
            {
                VisblFIV.IsVisible = false;
                blkFIV.IsVisible = false;
                blkFIV.FadeTo(0, 100, Easing.Linear);
            }
            else
            {
                VisblFIV.IsVisible = false;
                blkFIV.IsVisible = true;
                blkFIV.FadeTo(1, 600, Easing.Linear);
            }
        }
        private void OnButtonClicked(object sender, System.EventArgs e)
        {

            string dz1 = EntryBox.Text;
            entry.Text = dz1;
            string ss = "";
            Preferences.Set("cnname", dz1);
            if (swa.IsToggled == true)
            {
                ss = "true";
            }
            else
            {
                ss = "false";
            }
            Preferences.Set("cnnam", ss);
            string vv = "";
            if (swaa.IsToggled == true)
            {
                vv = "true";
            }
            else
            {
                vv = "false";
            }
            Preferences.Set("cnna", vv);

            if (blk.IsVisible == true)
            {
                Visbl.IsVisible = true;
                blk.IsVisible = false;
            }
            else
            {
                Visbl.IsVisible = false;
                blk.IsVisible = true;
            }
        }

        private void OnButtonClickedTWO(object sender, System.EventArgs e)
        {

            string dz2 = EntryBoxTWO.Text;
            entryTWO.Text = dz2;
            string rr = "";
            Preferences.Set("cnnameTWO", dz2);
            if (swaTWO.IsToggled == true)
            {
                rr = "true";
            }
            else
            {
                rr = "false";
            }
            Preferences.Set("cnnamTWO", rr);
            string dd = "";
            if (swaaTWO.IsToggled == true)
            {
                dd = "true";
            }
            else
            {
                dd = "false";
            }
            Preferences.Set("cnnaTWO", dd);

            if (blkTWO.IsVisible == true)
            {
                VisblTWO.IsVisible = true;
                blkTWO.IsVisible = false;
            }
            else
            {
                VisblTWO.IsVisible = false;
                blkTWO.IsVisible = true;
            }
        }

        private void OnButtonClickedTRE(object sender, System.EventArgs e)
        {

            string dz3 = EntryBoxTRE.Text;
            entryTRE.Text = dz3;
            string tr = "";
            Preferences.Set("cnnameTRE", dz3);
            if (swaTRE.IsToggled == true)
            {
                tr = "true";
            }
            else
            {
                tr = "false";
            }
            Preferences.Set("cnnamTRE", tr);
            string trr = "";
            if (swaaTRE.IsToggled == true)
            {
                trr = "true";
            }
            else
            {
                trr = "false";
            }
            Preferences.Set("cnnaTRE", trr);

            if (blkTRE.IsVisible == true)
            {
                VisblTRE.IsVisible = true;
                blkTRE.IsVisible = false;
            }
            else
            {
                VisblTRE.IsVisible = false;
                blkTRE.IsVisible = true;
            }
        }

        private void OnButtonClickedFOR(object sender, System.EventArgs e)
        {

            string dz4 = EntryBoxFOR.Text;
            entryFOR.Text = dz4;
            string fr = "";
            Preferences.Set("cnnameFOR", dz4);
            if (swaFOR.IsToggled == true)
            {
                fr = "true";
            }
            else
            {
                fr = "false";
            }
            Preferences.Set("cnnamFOR", fr);
            string frr = "";
            if (swaaFOR.IsToggled == true)
            {
                frr = "true";
            }
            else
            {
                frr = "false";
            }
            Preferences.Set("cnnaFOR", frr);

            if (blkFOR.IsVisible == true)
            {
                VisblFOR.IsVisible = true;
                blkFOR.IsVisible = false;
            }
            else
            {
                VisblFOR.IsVisible = false;
                blkFOR.IsVisible = true;
            }
        }

        private void OnButtonClickedFIV(object sender, System.EventArgs e)
        {

            string dz5 = EntryBoxFIV.Text;
            entryFIV.Text = dz5;
            string fv = "";
            Preferences.Set("cnnameFIV", dz5);
            if (swaFIV.IsToggled == true)
            {
                fv = "true";
            }
            else
            {
                fv = "false";
            }
            Preferences.Set("cnnamFIV", fv);
            string fvv = "";
            if (swaaFIV.IsToggled == true)
            {
                fvv = "true";
            }
            else
            {
                fvv = "false";
            }
            Preferences.Set("cnnaFIV", fvv);

            if (blkFIV.IsVisible == true)
            {
                VisblFIV.IsVisible = true;
                blkFIV.IsVisible = false;
            }
            else
            {
                VisblFIV.IsVisible = false;
                blkFIV.IsVisible = true;
            }
        }

        private void Switch_Toggled1(object sender, ToggledEventArgs e)
        {
            if (swa.IsToggled == false)
            {
                prop.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Пропуск\" />";
                propp.LoadFromXaml(xaml);
            }
            else
            {
                prop.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Присутсвовал(-ала)\" />";
                propp.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled1TWO(object sender, ToggledEventArgs e)
        {
            if (swaTWO.IsToggled == false)
            {
                propTWO.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Пропуск\" />";
                proppTWO.LoadFromXaml(xaml);
            }
            else
            {
                propTWO.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Присутсвовал(-ала)\" />";
                proppTWO.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled2(object sender, ToggledEventArgs e)
        {
            if (swaa.IsToggled == false)
            {
                zach.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Незачёт\" />";
                zachh.LoadFromXaml(xaml);
            }
            else
            {
                zach.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Зачёт\" />";
                zachh.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled2TWO(object sender, ToggledEventArgs e)
        {
            if (swaaTWO.IsToggled == false)
            {
                zachTWO.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Незачёт\" />";
                zachhTWO.LoadFromXaml(xaml);
            }
            else
            {
                zachTWO.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Зачёт\" />";
                zachhTWO.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled1TRE(object sender, ToggledEventArgs e)
        {
            if (swaTRE.IsToggled == false)
            {
                propTRE.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Пропуск\" />";
                proppTRE.LoadFromXaml(xaml);
            }
            else
            {
                propTRE.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Присутсвовал(-ала)\" />";
                proppTRE.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled2TRE(object sender, ToggledEventArgs e)
        {
            if (swaaTRE.IsToggled == false)
            {
                zachTRE.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Незачёт\" />";
                zachhTRE.LoadFromXaml(xaml);
            }
            else
            {
                zachTRE.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Зачёт\" />";
                zachhTRE.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled1FOR(object sender, ToggledEventArgs e)
        {
            if (swaFOR.IsToggled == false)
            {
                propFOR.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Пропуск\" />";
                proppFOR.LoadFromXaml(xaml);
            }
            else
            {
                propFOR.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Присутсвовал(-ала)\" />";
                proppFOR.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled2FOR(object sender, ToggledEventArgs e)
        {
            if (swaaFOR.IsToggled == false)
            {
                zachFOR.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Незачёт\" />";
                zachhFOR.LoadFromXaml(xaml);
            }
            else
            {
                zachFOR.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Зачёт\" />";
                zachhFOR.LoadFromXaml(xaml);
            }
        }

        private void Switch_Toggled1FIV(object sender, ToggledEventArgs e)
        {
            if (swaFIV.IsToggled == false)
            {
                propFIV.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Пропуск\" />";
                proppFIV.LoadFromXaml(xaml);
            }
            else
            {
                propFIV.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Присутсвовал(-ала)\" />";
                proppFIV.LoadFromXaml(xaml);
            }
        }
        private void Switch_Toggled2FIV(object sender, ToggledEventArgs e)
        {
            if (swaaFIV.IsToggled == false)
            {
                zachFIV.BackgroundColor = Color.Red;
                string xaml = "<Label Text=\"Незачёт\" />";
                zachhFIV.LoadFromXaml(xaml);
            }
            else
            {
                zachFIV.BackgroundColor = Color.Green;
                string xaml = "<Label Text=\"Зачёт\" />";
                zachhFIV.LoadFromXaml(xaml);
            }
        }
    }
}