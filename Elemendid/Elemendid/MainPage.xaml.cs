using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid
{
    public partial class MainPage : ContentPage
    {
        string[] maakonnad = { "Валгамаа", "Вильяндимаа", "Вырумаа", "Ида-Вирумаа", "Йыгевамаа", "Ляэне-Вирумаа", "Ляэнемаа", "Пылвамаа", "Пярнумаа", "Рапламаа", "Сааремаа",
        "Тартумаа", "Харьюмаа", "Хийумаа", "Ярвамаа"};
        string[] pealinnad = { "Валга", "Вильянди", "Выру", "Йыхви","Йыгева","Раквере","Хаапсалу", "Пылва", "Пярну", "Рапла", "Курессааре", "Тарту", "Таллинн",
        "Кярдла", "Пайде"};
        public MainPage()
        {
            InitializeComponent();
            Maakond.ItemsSource = maakonnad;
            Pealinn.ItemsSource = pealinnad;
        }

        private void Maakond_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (Maakond.SelectedItem)
            {
                case "Валгамаа":
                    Pealinn.SelectedItem = pealinnad[0];
                    pic.Source = @"Resources/drawable/valgamaa.png";
                    nfo.Text = "Валгамаа (эст. Valgamaa или Валгаский уезд, Valga maakond) - уезд в Эстонии, расположенный в южной части страны. ";
                    break;
                case "Вильяндимаа":
                    Pealinn.SelectedItem = pealinnad[1];
                    pic.Source = @"Resources/drawable/viljandi.png";
                    nfo.Text = "Ви́льяндимаа (эст. Viljandimaa или Viljandi maakond) — уезд в Эстонии, расположенный в южной части страны.";
                    break;
                case "Вырумаа":
                    Pealinn.SelectedItem = pealinnad[2];
                    pic.Source = @"Resources/drawable/voru.png";
                    nfo.Text = "Вырумаа (эст. Võrumaa или Võru maakond, выруск. Võromaa или Võro maakund) — уезд в Эстонии, расположенный в юго-восточной части страны.";
                    break;
                case "Ида-Вирумаа":
                    Pealinn.SelectedItem = pealinnad[3];
                    pic.Source = @"Resources/drawable/idaviru.png";
                    nfo.Text = "И́да-Ви́румаа (эст. Ida-Virumaa), или И́да-Ви́руский уезд (эст. Ida-Viru maakond) — уезд (мааконд) на северо-востоке Эстонии.";
                    break;
                case "Йыгевамаа":
                    Pealinn.SelectedItem = pealinnad[4];
                    pic.Source = @"Resources/drawable/joge.png";
                    nfo.Text = "Йыгевамаа (эст. Jõgevamaa или Jõgeva maakond) — уезд в Эстонии, расположенный в восточной части страны.";
                    break;
                case "Ляэне-Вирумаа":
                    Pealinn.SelectedItem = pealinnad[5];
                    pic.Source = @"Resources/drawable/laanevir.png";
                    nfo.Text = "Ля́эне-Ви́румаа (эст. Lääne-Virumaa или Lääne-Viru maakond) — уезд в Эстонии, расположенный в северо-восточной части страны.";
                    break;
                case "Ляэнемаа":
                    Pealinn.SelectedItem = pealinnad[6];
                    pic.Source = @"Resources/drawable/laane.png";
                    nfo.Text = "Ляэнемаа (эст. Läänemaa или Lääne maakond) — уезд в Эстонии, расположенный на крайнем западе материковой части страны.";
                    break;
                case "Пылвамаа":
                    Pealinn.SelectedItem = pealinnad[7];
                    pic.Source = @"Resources/drawable/polvamaa.png";
                    nfo.Text = "Пы́лвамаа (старое написание Пыльвамаа; эст. Põlvamaa или Põlva maakond) — уезд на юго-востоке Эстонии.";
                    break;
                case "Пярнумаа":
                    Pealinn.SelectedItem = pealinnad[8];
                    pic.Source = @"Resources/drawable/parnu.png";
                    nfo.Text = "Пярнумаа (эст. Pärnumaa или Pärnu maakond) — самый крупный по площади уезд в Эстонии, расположенный в юго-западной части страны на побережье Рижского залива.";
                    break;
                case "Рапламаа":
                    Pealinn.SelectedItem = pealinnad[9];
                    pic.Source = @"Resources/drawable/rapla.png";
                    nfo.Text = "Рапламаа (эст. Raplamaa или Rapla maakond) — уезд в Эстонии, расположенный в западной части страны.";
                    break;
                case "Сааремаа":
                    Pealinn.SelectedItem = pealinnad[10];
                    pic.Source = @"Resources/drawable/saare.png";
                    nfo.Text = "Са́аремаа (эст. Saaremaa или Saare maakond) — уезд в Эстонии, территория которого состоит из островов Сааремаа, Муху, Абрука, Вилсанди, Рухну и других более мелких островов.";
                    break;
                case "Тартумаа":
                    Pealinn.SelectedItem = pealinnad[11];
                    pic.Source = @"Resources/drawable/tartu.png";
                    nfo.Text = "Та́ртумаа (также Та́ртуский уе́зд — эст. Tartu maakond) — один из 15 уездов Эстонской Республики.";
                    break;
                case "Харьюмаа":
                    Pealinn.SelectedItem = pealinnad[12];
                    pic.Source = @"Resources/drawable/harju.png";
                    nfo.Text = "Харьюмаа, или Харью (эст. Harju maakond или Harjumaa), — один из 15 уездов Эстонии.";
                    break;
                case "Хийумаа":
                    Pealinn.SelectedItem = pealinnad[13];
                    pic.Source = @"Resources/drawable/hiiu.png";
                    nfo.Text = "Хийумаа (эст. Hiiu maakond) — уезд в Эстонии, территория которого состоит из острова Хийумаа и окружающих его малых островов.";
                    break;
                case "Ярвамаа":
                    Pealinn.SelectedItem = pealinnad[14];
                    pic.Source = @"Resources/drawable/jarva.png";
                    nfo.Text = "Ярвамаа (эст. Järvamaa или Järva maakond) — уезд в Эстонии, расположенный в центральной части страны.";
                    break;
            }
        }

        private void Pealinn_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (Pealinn.SelectedItem)
            {
                case "Валга":
                    Maakond.SelectedItem = maakonnad[0];
                    pic.Source = @"Resources/drawable/valgacity.jpg";
                    nfo.Text = "Ва́лга (эст. Valga, нем. Walk, до 1920 рус. Валк, старинное рус. название — Влех) — город на юге Эстонии, административный центр уезда Валгамаа.";
                    break;
                case "Вильянди":
                    Maakond.SelectedItem = maakonnad[1];
                    pic.Source = @"Resources/drawable/vilcity.jpg";
                    nfo.Text = "Ви́льянди (эст. Viljandi, до 1919 года Феллин (нем. Fellin)) — город в Эстонии, административный центр уезда Вильяндимаа.";
                    break;
                case "Выру":
                    Maakond.SelectedItem = maakonnad[2];
                    pic.Source = @"Resources/drawable/vorucity.jpg";
                    nfo.Text = "Вы́ру (эст. Võru, вырус. Võro, нем. Werro, до 1917 г. рус. Верро) — город в Эстонии, административный центр уезда Вырумаа и волости Выру.";
                    break;
                case "Йыхви":
                    Maakond.SelectedItem = maakonnad[3];
                    pic.Source = @"Resources/drawable/johvicity.jpg";
                    nfo.Text = "Йы́хви (эст. Jõhvi) — город на северо-востоке Эстонии, столица уезда Ида-Вирумаа.";
                    break;
                case "Йыгева":
                    Maakond.SelectedItem = maakonnad[4];
                    pic.Source = @"Resources/drawable/jogevacity.jpg";
                    nfo.Text = "Йы́гева (эст. Jõgeva) — город на востоке Эстонии, на правом берегу реки Педья (бассейн Эмайыги); административный центр уезда Йыгевамаа.";
                    break;
                case "Раквере":
                    Maakond.SelectedItem = maakonnad[5];
                    pic.Source = @"Resources/drawable/rakvcity.jpg";
                    nfo.Text = "Ра́квере (эст. Rakvere) — город в Эстонии, административный центр уезда Ляэне-Вирумаа.";
                    break;
                case "Хаапсалу":
                    Maakond.SelectedItem = maakonnad[6];
                    pic.Source = @"Resources/drawable/haapscity.jpg";
                    nfo.Text = "Ха́апсалу (эст. Haapsalu, старое русское название — Га́псаль, Хапсаль (швед. Hapsal, нем. Hapsal) — город на северо-западе Эстонии, административный центр Ляэнеского мааконда (уезда).";
                    break;
                case "Пылва":
                    Maakond.SelectedItem = maakonnad[7];
                    pic.Source = @"Resources/drawable/polvacity.jpg";
                    nfo.Text = "Пы́лва (старое написание Пыльва; эст. Põlva), Пёльве или Пёльва (нем. Pölwe или Pölwa) — город в Эстонии, административный центр уезда Пылвамаа и волости Пылва.";
                    break;
                case "Пярну":
                    Maakond.SelectedItem = maakonnad[8];
                    pic.Source = @"Resources/drawable/parnucity.jpg";
                    nfo.Text = "Пя́рну (эст. Pärnu), рус. Пернов, Пернау (нем. Pernau) — портовый город на юго-западе Эстонии с населением 40 700 жителей (2017), является четвёртым по величине и по численности населения городом в Эстонии.";
                    break;
                case "Рапла":
                    Maakond.SelectedItem = maakonnad[9];
                    pic.Source = @"Resources/drawable/raplacity.jpg";
                    nfo.Text = "Ра́пла (эст. Rapla), Раппель (нем. Rappel) — внутриволостной город в Эстонии, административный центр уезда Рапламаа и волостной центр и составная часть волости Рапла.";
                    break;
                case "Курессааре":
                    Maakond.SelectedItem = maakonnad[10];
                    pic.Source = @"Resources/drawable/kurecity.jpg";
                    nfo.Text = "Ку́рессааре (эст. Kuressaare ) — город в Эстонии, на острове Сааремаа, когда-то так называли весь архипелаг, а остров называли Курессааре, крупнейший населённый пункт и административный центр уезда Сааремаа.";
                    break;
                case "Тарту":
                    Maakond.SelectedItem = maakonnad[11];
                    pic.Source = @"Resources/drawable/tartucity.jpg";
                    nfo.Text = "Та́рту (эст. Tartu), второй по численности населения после Таллина город Эстонии, административный центр уезда Тартумаа.";
                    break;
                case "Таллинн":
                    Maakond.SelectedItem = maakonnad[12];
                    pic.Source = @"Resources/drawable/talcity.jpg";
                    nfo.Text = "Та́ллин (Та́ллинн; эст. Tallinn [ˈtɑlʲˑinˑ]) — столица Эстонской Республики, крупный пассажирский и грузовой морской порт.";
                    break;
                case "Кярдла":
                    Maakond.SelectedItem = maakonnad[13];
                    pic.Source = @"Resources/drawable/kardcity.jpg";
                    nfo.Text = "Кя́рдла (эст. Kärdla, швед. Kärrdal, нем. Kertel) — административный центр и крупнейший город эстонского уезда Хийумаа.";
                    break;
                case "Пайде":
                    Maakond.SelectedItem = maakonnad[14];
                    pic.Source = @"Resources/drawable/paidcity.jpg";
                    nfo.Text = "Па́йде (эст. Paide), Вейсенштейн (Вайссенштайн) (нем. Weißenstein — Белый камень), Виттенштейн (Виттенштайн) (н.-нем. Wittenstein — Белый камень) — город в центральной части Эстонии, административный центр уезда Ярвамаа.";
                    break;
            }
        }
    }
}
