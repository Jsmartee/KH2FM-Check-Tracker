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

namespace KH2FM_Randomizer_Checklist
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Item> items = new List<Item>();
        public List<World> worlds = new List<World>();
        public List<Item> datas = new List<Item>();

        public MainWindow()
        {
            InitializeComponent();
            SetGrids();
        }

        public void SetGrids()
        {
            Style checkImg = this.FindResource("CheckImage") as Style;
            Style countImg = this.FindResource("CounterImage") as Style;
            Style intCount = this.FindResource("IntCounter") as Style;
            Style worldImg = this.FindResource("WorldImage") as Style;
            Style worldTxt = this.FindResource("WorldText") as Style;

            //Item Tracker
            List<Item> itemslist = new List<Item>
            {
                //Item Name, Image, Image Style, Initial Text, Max
                new Item("Baseball Charm", "charmbaseball_0.png", checkImg),
                new Item("Lamp Charm", "charmlamp_0.png", checkImg),
                new Item("Ukulele Charm", "charmukulele_0.png", checkImg),
                new Item("Feather Charm", "charmfeather_0.png", checkImg),

                new Item("Fire", "magicfire_0.png", countImg, "", 3),
                new Item("Blizzard", "magicblizzard_0.png", countImg, "", 3),
                new Item("Thunder", "magicthunder_0.png", countImg, "", 3),
                new Item("Cure", "magiccure_0.png", countImg, "", 3),
                new Item("Reflect", "magicorb_0.png", countImg, "", 3),
                new Item("Magnet", "magicorb_0.png", countImg, "", 3),

                new Item("Valor Form", "formvalor_0.png", countImg, "", 7),
                new Item("Wisdom Form", "formwisdom_0.png", countImg, "", 7),
                new Item("Limit Form", "formlimit_0.png", countImg, "", 7),
                new Item("Master Form", "formmaster_0.png", countImg, "", 7),
                new Item("Final Form", "formfinal_0.png", countImg, "", 7),

                new Item("Proof of Peace", "ProofPeace_0.png", checkImg),
                new Item("Proof of Nonexistence", "ProofNonexistence_0.png", checkImg),
                new Item("Proof of Connection", "ProofConnection_0.png", checkImg),

                new Item("Promise Charm", "Charm_0.png", checkImg),
                new Item("Torn Pages", "pages_0.png", countImg, "0", 5)

            };

            items = itemslist;

            //Put items on grid
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Image currentImage = items.ElementAt(b + 5 * a).ItemImage;
                    Grid.SetRow(currentImage, a);
                    Grid.SetColumn(currentImage, b);
                    ItemTracker.Children.Add(currentImage);

                    currentImage.ToolTip = items.ElementAt(b + 5 * a).ItemName;
                    currentImage.Tag = items.ElementAt(b + 5 * a).ItemName;

                    TextBlock text = new TextBlock
                    {
                        Style = intCount,
                        Text = items.ElementAt(b + 5 * a).ItemCurrentString
                    };
                    items.ElementAt(b + 5 * a).ItemText = text;
                    Grid.SetRow(items.ElementAt(b + 5 * a).ItemText, a);
                    Grid.SetColumn(items.ElementAt(b + 5 * a).ItemText, b);
                    ItemTracker.Children.Add(items.ElementAt(b + 5 * a).ItemText);
                }
            }

            //World Tracker

            List<string> STT = new List<string>
            {
                "Not visited",
                "Mansion",
                "Axel 2"
            };

            List<string> TT = new List<string>
            {
                "Not visited",
                "1: Station",
                "1: Yen Sid",
                "2: Sandlot",
                "2: Oathkeeper",
                "3: Underground",
                "3: Sunset Terrace",
                "3: Mickey",
                "3: Mansion",
                "3: Betwixt"
            };

            List<string> HB = new List<string>
            {
                "Not visited",
                "1: Merlin",
                "1: Bailey",
                "2: Ansem's Study",
                "3: Corridor Fight",
                "3: Demyx",
                "3: FF Fights",
                "3: 1K",
                "Post: Chests",
                "Post: Mushroom",
                "Post: Sephiroth"
            };

            List<string> COR = new List<string>
            {
                "Not visited",
                "Depths",
                "Mineshaft",
                "Wisdom Fight",
                "Mining Area",
                "Engine Chamber",
                "Master Fight",
                "Last chest"
            };

            List<string> LoD = new List<string>
            {
                "Not visited",
                "1: Bamboo",
                "1: Missions",
                "1: Mountain",
                "1: Cave",
                "1: Summit",
                "1: Shan Yu",
                "2: Riku",
                "2: Imperial Square",
                "2: Throne Room",
                "2: Storm Rider"
            };

            List<string> BC = new List<string>
            {
                "Not visited",
                "1: Thresholder",
                "1: Cogsworth",
                "1: Beast",
                "1: Dark Thorn",
                "2: Rumbling Rose",
                "2: Xaldin"
            };

            List<string> OC = new List<string>
            {
                "Not visited",
                "1: Cave of the Dead",
                "1: Hades Escape",
                "1: Cerberus",
                "1: Urns",
                "1: Demyx",
                "1: Pete",
                "1: Hydra",
                "2: Hades Chamber",
                "2: Hades",
                "Post: 1 Cup",
                "Post: 2 Cups",
                "Post: 3 Cups",
                "Post: 4 Cups"
            };

            List<string> DC = new List<string>
            {
                "Not visited",
                "Library",
                "Minnie Escort",
                "Pier Pete",
                "Windows",
                "Boat Pete",
                "Timeless Pete",
                "Lingering Will"
            };

            List<string> PR = new List<string>
            {
                "Not visited",
                "1: Rampart",
                "1: Town",
                "1: Cave Mouth",
                "1: Boat Fight",
                "1: Barbossa",
                "2: Harbor",
                "2: Grim Reaper 1",
                "2: Medallions",
                "2: Grim Reaper 2"
            };

            List<string> AG = new List<string>
            {
                "Not visited",
                "1: Bazaar",
                "1: Enter Cave",
                "1: Abu Escort",
                "1: Falling Segment",
                "1: Treasure Room",
                "1: Twin Lords",
                "2: Carpet",
                "2: Jafar"
            };

            List<string> HT = new List<string>
            {
                "Not visited",
                "1: Candy Cane Lane",
                "1: Prison Keeper",
                "1: Oogie",
                "2: Presents",
                "2: Experiment"
            };

            List<string> PL = new List<string>
            {
                "Not visited",
                "1: Gorge",
                "1: Simba",
                "1: Hyenas",
                "1: Scar",
                "2: Hyenas 2",
                "2: Groundshaker"
            };

            List<string> SP = new List<string>
            {
                "Not visited",
                "1: Cube Game",
                "1: Comms Room",
                "1: Hostile Program",
                "2: Central Computer",
                "2: MCP"
            };

            List<string> AT = new List<string>
            {
                "Not visited",
                "Tutorial",
                "1: Swim This Way",
                "2: Part of Your World",
                "3: Under the Sea",
                "4: Ursula's Revenge",
                "5: A New Day"
            };

            List<string> AW = new List<string>
            {
                "Not visited",
                "Pooh's House",
                "1: Piglet chests",
                "1: Piglet Game",
                "2: Rabbit chests",
                "2: Hunny Slide",
                "3: Kanga chests",
                "3: Bouncing Game",
                "4: Spooky Cave",
                "5: Starry Hill"
            };

            List<string> TWTNW = new List<string>
            {
                "Not visited",
                "Fragment Crossing",
                "Roxas",
                "Twilight's View",
                "Xigbar",
                "Oblivion",
                "Luxord",
                "Saix",
                "Xemnas"
            };

            List<World> worldlist = new List<World>
            {
                //World name, Image, Style, List of checks
                new World("Simulated Twilight Town", "Simulated Twilight Town.png", worldImg, STT),
                new World("Disney Castle", "Disney Castle.png", worldImg, DC),
                new World("Atlantica", "Atlantica.png", worldImg, AT),
                new World("100 Acre Wood", "100 Acre Wood.png", worldImg, AW),

                new World("Twilight Town", "Twilight Town.png", worldImg, TT),
                new World("Hollow Bastion", "Hollow Bastion.png", worldImg, HB),
                new World("Cavern of Remembrance", "cor.png", worldImg, COR),
                new World("The World That Never Was", "The World That Never Was.png", worldImg, TWTNW),

                new World("Land of Dragons", "The Land of Dragons.png", worldImg, LoD),
                new World("Beast's Castle", "Beast's Castle.png", worldImg, BC),
                new World("Olympus Coliseum", "Olympus Coliseum.png", worldImg, OC),
                new World("Port Royal", "Port Royal.png", worldImg, PR),

                new World("Agrabah", "Agrabah.png", worldImg, AG),
                new World("Halloween Town", "Halloween Town.png", worldImg, HT),
                new World("Pride Lands", "Pride Lands.png", worldImg, PL),
                new World("Space Paranoids", "Space Paranoids.png", worldImg, SP)
            };

            worlds = worldlist;

            //Put worlds on grid
            for (int a = 0; a < 4; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Image currentImage = worlds.ElementAt(b + 4 * a).WorldImage;
                    Grid.SetRow(currentImage, a);
                    Grid.SetColumn(currentImage, b);
                    WorldTracker.Children.Add(currentImage);

                    currentImage.Tag = worlds.ElementAt(b + 4 * a).WorldName;

                    TextBlock text = new TextBlock
                    {
                        Style = worldTxt,
                        Text = worlds.ElementAt(b + 4 * a).WorldProgression.ElementAt(0)
                    };
                    worlds.ElementAt(b + 4 * a).WorldText = text;
                    Grid.SetRow(worlds.ElementAt(b + 4 * a).WorldText, a);
                    Grid.SetColumn(worlds.ElementAt(b + 4 * a).WorldText, b);
                    WorldTracker.Children.Add(worlds.ElementAt(b + 4 * a).WorldText);
                }
            }

            //Data Org Tracker
            List<Item> dataorg = new List<Item>
            {
                new Item("Xemnas", "dataxemnas_0.png", checkImg),
                new Item("Xigbar", "dataxigbar_0.png", checkImg),
                new Item("Xaldin", "dataxaldin_0.png", checkImg),
                new Item("Vexen", "datavexen_0.png", checkImg),
                new Item("Lexaeus", "datalexaeus_0.png", checkImg),

                new Item("Zexion", "datazexion_0.png", checkImg),
                new Item("Saix", "datasaix_0.png", checkImg),
                new Item("Axel", "dataaxel_0.png", checkImg),
                new Item("Demyx", "datademyx_0.png", checkImg),
                new Item("Luxord", "dataluxord_0.png", checkImg),

                new Item("Marluxia", "datamarluxia_0.png", checkImg),
                new Item("Larxene", "datalarxene_0.png", checkImg),
                new Item("Roxas", "dataroxas_0.png", checkImg)
            };

            datas = dataorg;

            //Put data org symbols on grid
            for(int a = 0; a < 3; a++)
            {
                for(int b = 0; b < 5; b++)
                {
                    if(a == 2 && b == 3)
                    {
                        break;
                    }

                    Image currentImage = datas.ElementAt(b + 5 * a).ItemImage;
                    Grid.SetRow(currentImage, a);
                    Grid.SetColumn(currentImage, b);
                    DataTracker.Children.Add(currentImage);

                    currentImage.ToolTip = datas.ElementAt(b + 5 * a).ItemName;
                }
            }


        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void HowTo_Click(object sender, RoutedEventArgs e)
        {
            HowToUse how = new HowToUse();
            how.Show();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Author: Jsmartee" + "\n" + "Images from khwiki.com and khinsider.com", "KH2FM Checklist v1.2");
        }
    }
}
