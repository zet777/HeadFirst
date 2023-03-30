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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        
        private void SetUpGame()
        {
            //Create a list of animal emojis
            List<string> animalEmoji = new List<string>()
            {
                "🦊","🦊",
                "🐻","🐻",
                "🐼","🐼",
                "🐨","🐨",
                "🐯","🐯",
                "🦁","🦁",
                "🐮","🐮",
                "🐷","🐷"
            };

            //Create a random object
            Random rnd = new Random();

            //Loop through all the text blocks in the main grid
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                //Generate a random index
                int index = rnd.Next(animalEmoji.Count);

                //Set the text of the text block to the animal emoji at the random index
                textBlock.Text = animalEmoji[index];

                //Remove the animal emoji from the list
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
