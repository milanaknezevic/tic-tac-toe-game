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
using System.Windows.Shapes;

namespace Iks_oks_game
{
    /// <summary>
    /// Interaction logic for ScoreWindow.xaml
    /// </summary>
  
    public partial class ScoreWindow : Window
    {
        public static ScoreWindow Instance;
        int igrac1Bodovi;
        int igrac2Bodovi;
        int brojIgara;
        public ScoreWindow()
        {
            try
            {

            InitializeComponent();
            igrac1Bodovi = GameRezim1Window.Instance.bodoviIgraca1;
            igrac2Bodovi = GameRezim1Window.Instance.bodoviIgraca2;
            brojIgara    = GameRezim1Window.Instance.brojIgranja;
            BrojIgranjaLabel.Content="Broj igranja: " + brojIgara.ToString();
            Igrac1TextBox.Text = igrac1Bodovi.ToString();
            Igrac2TextBox.Text = igrac2Bodovi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            GameRezim1Window game = new GameRezim1Window(igrac1Bodovi,igrac2Bodovi,brojIgara);
            this.Close();
            // player.Stop();
            game.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
    }
}
