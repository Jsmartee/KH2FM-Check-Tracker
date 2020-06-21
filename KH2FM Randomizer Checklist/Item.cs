using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace KH2FM_Randomizer_Checklist
{
    public class Item
    {
        public Item(string name, string imgPath, Style style)
        {
            _itemName = name;

            Image img = new Image();
            String url = "pack://application:,,,/Resources/Images/" + imgPath;
            BitmapImage bitmap = new BitmapImage(new Uri(url, UriKind.Absolute));
            img.Source = bitmap;
            _itemImage = img;

            _itemStyle = style;
            _itemImage.Style = _itemStyle;
        }

        public Item(string name, string imgPath, Style style, string count, int max)
        {
            _itemName = name;

            Image img = new Image();
            String url = "pack://application:,,,/Resources/Images/" + imgPath;
            BitmapImage bitmap = new BitmapImage(new Uri(url, UriKind.Absolute));
            img.Source = bitmap;
            _itemImage = img;

            _itemStyle = style;
            _itemImage.Style = _itemStyle;

            _itemCurrentString = count;

            _itemCurrentCount = 0;

            _max = max;
        }

        //Name of item
        private string _itemName;
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        //Image of item
        private Image _itemImage;
        public Image ItemImage
        {
            get { return _itemImage; }
            set { _itemImage = value; }
        }

        //Style for image
        private Style _itemStyle;
        public Style ItemStyle
        {
            get { return _itemStyle; }
            set { _itemStyle = value; }
        }

        //Textblock to hold counter
        private TextBlock _itemText;
        public TextBlock ItemText
        {
            get { return _itemText; }
            set { _itemText = value; }
        }

        //Current text inside textblock
        private string _itemCurrentString;
        public string ItemCurrentString
        {
            get { return _itemCurrentString; }
            set { _itemCurrentString = value; }
        }

        //Current index of counter
        private int _itemCurrentCount;
        public int ItemCurrentCount
        {
            get { return _itemCurrentCount; }
            set { _itemCurrentCount = value; }
        }

        //Max value for counter
        private int _max;
        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
    }
}
