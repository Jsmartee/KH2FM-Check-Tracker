using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace KH2FM_Randomizer_Checklist
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        //Highlight item when left click
        public void CheckItem(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            String[] reference = pic.Source.ToString().Split('_');
            BitmapImage image = new BitmapImage(new Uri(reference[0] + "_1.png", UriKind.Absolute));
            pic.Source = image;
        }

        //Unhighlight item when right click
        public void UncheckItem(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            String[] reference = pic.Source.ToString().Split('_');
            BitmapImage image = new BitmapImage(new Uri(reference[0] + "_0.png", UriKind.Absolute));
            pic.Source = image;
        }

        //Add to counter when left click
        public void CountUp(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            string name = (string)pic.Tag;
            int item = GetItem(name);
            var mainWin = App.Current.MainWindow as MainWindow;

            if (mainWin.items.ElementAt(item).ItemCurrentCount == 0)
            {
                CheckItem(pic, e);
            }

            if(mainWin.items.ElementAt(item).ItemCurrentCount == mainWin.items.ElementAt(item).Max)
            {
                return;
            }

            int num = mainWin.items.ElementAt(item).ItemCurrentCount + 1;

            if (num == mainWin.items.ElementAt(item).Max)
            {
                mainWin.items.ElementAt(item).ItemText.Foreground = new SolidColorBrush(Color.FromRgb(0,204,0));
            }

            mainWin.items.ElementAt(item).ItemCurrentCount = num;
            mainWin.items.ElementAt(item).ItemText.Text = num.ToString();

        }

        //Subtract from counter when right click
        public void CountDown(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            string name = (string)pic.Tag;
            int item = GetItem(name);
            var mainWin = App.Current.MainWindow as MainWindow;

            if (mainWin.items.ElementAt(item).ItemCurrentCount == 1)
            {
                UncheckItem(pic, e);
                if(!mainWin.items.ElementAt(item).ItemName.Equals("Torn Pages"))
                {
                    int num1 = mainWin.items.ElementAt(item).ItemCurrentCount - 1;
                    mainWin.items.ElementAt(item).ItemCurrentCount = num1;
                    mainWin.items.ElementAt(item).ItemText.Text = "";
                    return;
                }
            }

            if (mainWin.items.ElementAt(item).ItemCurrentCount == 0)
            {
                return;
            }

            if (mainWin.items.ElementAt(item).ItemCurrentCount == mainWin.items.ElementAt(item).Max)
            {
                mainWin.items.ElementAt(item).ItemText.Foreground = new SolidColorBrush(Colors.White);
            }

            int num = mainWin.items.ElementAt(item).ItemCurrentCount - 1;
            mainWin.items.ElementAt(item).ItemCurrentCount = num;
            mainWin.items.ElementAt(item).ItemText.Text = num.ToString();
        }

        //Determine which item was clicked
        public int GetItem(String name)
        {
            var mainWin = App.Current.MainWindow as MainWindow;
            int num = 0;
            for(int i = 0; i < mainWin.items.Count; i++)
            {
                if(mainWin.items.ElementAt(i).ItemName.Equals(name))
                {
                    num = i;
                }
            }

            return num;
        }

        //Determine which world was clicked
        public int GetWorld(String name)
        {
            var mainWin = App.Current.MainWindow as MainWindow;
            int num = 0;
            for (int i = 0; i < mainWin.worlds.Count; i++)
            {
                if (mainWin.worlds.ElementAt(i).WorldName.Equals(name))
                {
                    num = i;
                }
            }

            return num;
        }

        //World progression forward on left click
        public void WorldForward(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            string name = (string)pic.Tag;
            int world = GetWorld(name);
            var mainWin = App.Current.MainWindow as MainWindow;

            if(mainWin.worlds.ElementAt(world).WorldCurrentCount == 0)
            {
                mainWin.worlds.ElementAt(world).WorldText.Foreground = new SolidColorBrush(Colors.White);
            }

            if (mainWin.worlds.ElementAt(world).WorldCurrentCount == mainWin.worlds.ElementAt(world).WorldMax - 1)
            {
                return;
            }

            int num = mainWin.worlds.ElementAt(world).WorldCurrentCount + 1;

            if (num == mainWin.worlds.ElementAt(world).WorldMax - 1)
            {
                mainWin.worlds.ElementAt(world).WorldText.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
            }

            mainWin.worlds.ElementAt(world).WorldCurrentCount = num;
            mainWin.worlds.ElementAt(world).WorldText.Text = mainWin.worlds.ElementAt(world).WorldProgression.ElementAt(num);

        }

        //World progression backward on right click
        public void WorldBackward(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            string name = (string)pic.Tag;
            int world = GetWorld(name);
            var mainWin = App.Current.MainWindow as MainWindow;

            if (mainWin.worlds.ElementAt(world).WorldCurrentCount == 0)
            {
                return;
            }

            if(mainWin.worlds.ElementAt(world).WorldCurrentCount == 1)
            {
                mainWin.worlds.ElementAt(world).WorldText.Foreground = new SolidColorBrush(Colors.Gray);
            }

            if (mainWin.worlds.ElementAt(world).WorldCurrentCount == mainWin.worlds.ElementAt(world).WorldMax - 1)
            {
                mainWin.worlds.ElementAt(world).WorldText.Foreground = new SolidColorBrush(Colors.White);
            }

            int num = mainWin.worlds.ElementAt(world).WorldCurrentCount - 1;
            mainWin.worlds.ElementAt(world).WorldCurrentCount = num;
            mainWin.worlds.ElementAt(world).WorldText.Text = mainWin.worlds.ElementAt(world).WorldProgression.ElementAt(num);
        }



    }
}
