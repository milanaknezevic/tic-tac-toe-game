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
//using WMPLib;
namespace Iks_oks_game
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    { //WindowsMediaPlayer
        public static Window1 Instance;
        public String brojIgraca = "";
        public Window1()
        {
            try
            {

            InitializeComponent();
            Instance = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void jedanIgracButton_Click(object sender, RoutedEventArgs e)
        {
            try { 
             brojIgraca = "Jedan igrac";
             GameRezim1Window game = new GameRezim1Window();
             this.Close();
             game.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }

        }

        private void dvaIgracaButton_Click(object sender, RoutedEventArgs e)
        {
            try { 
            brojIgraca = "Dva igraca";
            GameRezim1Window game = new GameRezim1Window();
            this.Close();
            game.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            try { 
            Application.Current.Shutdown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
    }
}
