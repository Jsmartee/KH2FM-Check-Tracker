using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace KH2FM_Randomizer_Checklist
{
    public class World
    {
        public World(string name, string imgPath, Style style, List<string> checks)
        {
            _worldName = name;

            Image img = new Image();
            String url = "pack://application:,,,/Resources/Images/" + imgPath;
            BitmapImage bitmap = new BitmapImage(new Uri(url, UriKind.Absolute));
            img.Source = bitmap;
            _worldImage = img;

            _worldStyle = style;
            _worldImage.Style = _worldStyle;

            _worldProgression = checks;

            _worldCurrentCount = 0;

            _worldMax = checks.Count;
        }
        
        //Name of world
        private string _worldName;
        public string WorldName
        {
            get { return _worldName; }
            set { _worldName = value; }
        }

        //World logo image
        private Image _worldImage;
        public Image WorldImage
        {
            get { return _worldImage; }
            set { _worldImage = value; }
        }

        //Style for world image
        private Style _worldStyle;
        public Style WorldStyle
        {
            get { return _worldStyle; }
            set { _worldStyle = value; }
        }

        //Text under world logo
        private TextBlock _worldText;
        public TextBlock WorldText
        {
            get { return _worldText; }
            set { _worldText = value; }
        }

        //List of checks in world
        private List<string> _worldProgression;
        public List<string> WorldProgression
        {
            get { return _worldProgression; }
            set { _worldProgression = value; }
        }

        //Current index of list
        private int _worldCurrentCount;
        public int WorldCurrentCount
        {
            get { return _worldCurrentCount; }
            set { _worldCurrentCount = value; }
        }

        //Number of total checks in world
        private int _worldMax;
        public int WorldMax
        {
            get { return _worldMax; }
            set { _worldMax = value; }
        }
    }
}
