/*Elliott McArthur
 * 313502
 * Program reads numbers off of the web from either 2017 or 2018
 * 4/11/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _313502WebReaderChallenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int month2017;
        
        private void TwentySeventeenbutton_Click(object sender, RoutedEventArgs e)
        {
            System.Net.WebClient web = new System.Net.WebClient();
            web.BaseAddress = "https://github.com/IanMcT/April8_2019Assignment";
            System.IO.StreamReader stream = new System.IO.StreamReader(web.OpenRead("https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2017.txt"));
            if((bool)JanuaryRadio.IsChecked)
            {
                month2017 = 1;
            }
            if((bool)FebuaryRadio.IsChecked)
            {
                month2017 = 2;
            }
            if((bool)MarchRadio.IsChecked)
            {
                month2017 = 3;
            }
            if((bool)AprilRadio.IsChecked)
            {
                month2017 = 4;
            }
            if((bool)MayRadio.IsChecked)
            {
                month2017 = 5;
            }
            if((bool)JuneRadio.IsChecked)
            {
                month2017 = 6;
            }
            if((bool)JulyRadio.IsChecked)
            {
                month2017 = 7;
            }
            if((bool)AugustRadio.IsChecked)
            {
                month2017 = 8;
            }
            if((bool)SeptemberRadio.IsChecked)
            {
                month2017 = 9;
            }
            if((bool)OctoberRadio.IsChecked)
            {
                month2017 = 10;
            }
            if((bool)NovmeberRadio.IsChecked)
            {
                month2017 = 11;
            }
            if((bool)DecemberRadio.IsChecked)
            {
                month2017 = 12;
            }
            for(int i = 0; i <month2017; i++)
            {
                stream.ReadLine();
            }
            lblOutput.Content = "$" + stream.ReadLine();
            stream.Close();
        }
        int month2018;
        private void TwentyEighteenbutton_Click(object sender, RoutedEventArgs e)
        {
            System.Net.WebClient web = new System.Net.WebClient();
            web.BaseAddress = "https://github.com/IanMcT/April8_2019Assignment";
            System.IO.StreamReader stream = new System.IO.StreamReader(web.OpenRead("https://raw.githubusercontent.com/IanMcT/April8_2019Assignment/master/2018.txt"));
            if((bool)JanuaryRadio.IsChecked)
            {
                month2018 = 1;
            }
            if((bool)FebuaryRadio.IsChecked)
            {
                month2018 = 2;
            }
            if((bool)MarchRadio.IsChecked)
            {
                month2018 = 3;
            }
            if((bool)AprilRadio.IsChecked)
            {
                month2018 = 4;
            }
            if((bool)MayRadio.IsChecked)
            {
                month2018 = 5;
            }
            if((bool)JuneRadio.IsChecked)
            {
                month2018 = 6;
            }
            if((bool)JulyRadio.IsChecked)
            {
                month2018 = 7;
            }
            if((bool)AugustRadio.IsChecked)
            {
                month2018 = 8;
            }
            if((bool)SeptemberRadio.IsChecked)
            {
                month2018 = 9;
            }
            if((bool)OctoberRadio.IsChecked)
            {
                month2018 = 10;
            }
            if((bool)NovmeberRadio.IsChecked)
            {
                month2018 = 11;
            }
            if((bool)DecemberRadio.IsChecked)
            {
                month2018 = 12;
            }
            for (int i = 0; i < month2017; i++)
            {
                stream.ReadLine();
            }
            lblOutput.Content = "$" + stream.ReadLine();
            stream.Close();
        }
    }
}
