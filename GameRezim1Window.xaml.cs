using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for GameRezim1Window.xaml
    /// </summary>
    public partial class GameRezim1Window : Window
    {
        public static GameRezim1Window Instance;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Korisnik\source\repos\Iks-oks_game\bin\Debug\music.wav");
        static private String programSimbol = "";
        static int[] generisaniBrojevi = new int[9] ;
       // static int[] generisaniBrojevi = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int i = 0;
        static int br = 0;
        static String znak = "";//znak koji je user izabrao
       // static int brojIgranja = 1;
       // static bool korisnikPobjedio = false;
       // static bool programPobjedio = false;
        static bool gameOver = false;
        public static String rezimRada = "";
        public static int brojIgraca = 0;
        // public static String trenutniZnak;
        public  int bodoviIgraca1;
        public  int bodoviIgraca2;
        public int brojIgranja;
        public GameRezim1Window()
        {
            try
            {
                Instance = this;
                rezimRada = Window1.Instance.brojIgraca; // ime = PodaciOKorisnikuWindow.Instance.username; // znak = PodaciOKorisnikuWindow.Instance.simbol;//ynak koji je user iyabrao //  brojIgranja = PodaciOKorisnikuWindow.Instance.redniBrojIgraca;
                i = 0;
                br = 0;
                brojIgranja++;
                //  rezultatiButton.IsEnabled = false;
                gameOver = false;
                for (int j = 0; j < 9; j++)
                {
                    generisaniBrojevi[j] = 0;
                }
                if (rezimRada == "Jedan igrac")
                {

                    brojIgraca = 1;
                }
                if (rezimRada == "Dva igraca")
                {
                    brojIgraca = 2;

                }

                znak = "X";
                //trenutniZnak = "X";
                // brojIgranja = 1;
                InitializeComponent();  // ispisTextBox.Text = ime; /* if (znak.Equals("X")){ programSimbol = "O";} else{programSimbol = "X";}*/
                player.Load();
                //player.Play();
                player.PlayLooping();
                Stop.Visibility = Visibility.Visible;
                Play.Visibility = Visibility.Hidden;
                programSimbol = "O";
                setAllButtonsEnable();
                rezultatiButton.IsEnabled = false;
              
                /*   if (brojIgranja == 1){// ispisTextBox.Text = ime + ", sada je tvoj red";setAllButtonsEnable();}else if (brojIgranja == 2)//program igra{ // ispisTextBox.Text = "sada je random"; // setAllButtonsDisable(); //Thread.Sleep(1000); randomIzaberiPolje();//postavi na button content vrijednost i to dugme disable// ispisTextBox.Text = ime + ", sada je tvoj red";}*/
                if (brojIgraca == 1)
                {
                    player1TextBox.Visibility = Visibility.Hidden;
                    player2TextBox.Visibility = Visibility.Hidden;

                }
                if (brojIgraca == 2)
                {
                    player1TextBox.Text = "igrač 1 (X) je na redu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }


        public GameRezim1Window(int igra1B,int igra2B,int brojIgara)
        {
            try
            {
                Instance = this;
                rezimRada = Window1.Instance.brojIgraca; // ime = PodaciOKorisnikuWindow.Instance.username; // znak = PodaciOKorisnikuWindow.Instance.simbol;//ynak koji je user iyabrao //  brojIgranja = PodaciOKorisnikuWindow.Instance.redniBrojIgraca;
                i = 0;
                br = 0;
                bodoviIgraca1 = igra1B;
                bodoviIgraca2 = igra2B;
                brojIgranja = brojIgara;
                brojIgranja++;
                gameOver = false;
                for (int j = 0; j < 9; j++)
                {
                    generisaniBrojevi[j] = 0;
                }
                if (rezimRada == "Jedan igrac")
                {

                    brojIgraca = 1;
                }
                if (rezimRada == "Dva igraca")
                {
                    brojIgraca = 2;

                }

                znak = "X";
                //trenutniZnak = "X";
                // brojIgranja = 1;
                InitializeComponent();  // ispisTextBox.Text = ime; /* if (znak.Equals("X")){ programSimbol = "O";} else{programSimbol = "X";}*/
                player.Load();
                rezultatiButton.IsEnabled = false;
                //player.Play();
                player.PlayLooping();
                Stop.Visibility = Visibility.Visible;
                Play.Visibility = Visibility.Hidden;
                programSimbol = "O";
                setAllButtonsEnable();
                /*   if (brojIgranja == 1){// ispisTextBox.Text = ime + ", sada je tvoj red";setAllButtonsEnable();}else if (brojIgranja == 2)//program igra{ // ispisTextBox.Text = "sada je random"; // setAllButtonsDisable(); //Thread.Sleep(1000); randomIzaberiPolje();//postavi na button content vrijednost i to dugme disable// ispisTextBox.Text = ime + ", sada je tvoj red";}*/
                if (brojIgraca == 1)
                {
                    player1TextBox.Visibility = Visibility.Hidden;
                    player2TextBox.Visibility = Visibility.Hidden;

                }
                if (brojIgraca == 2)
                {
                    player1TextBox.Text = "igrač 1 (X) je na redu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        public void setAllButtonsEnable()
        {
            try
            {

            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }

        }
        public void setAllButtonsDisable()
        {
            try
            {

            button1.IsEnabled = false;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }

        }
        public int checkLogic()
        {

            if (((button1.Content == "X" & button3.Content == "X") | (button5.Content == "X" & button8.Content == "X")) & button2.Content == "")
            {
                return 2;
            }
            if (((button4.Content == "X" & button6.Content == "X") | (button2.Content == "X" & button8.Content == "X") | (button1.Content == "X" & button9.Content == "X") | (button3.Content == "X" & button7.Content == "X")) & button5.Content == "")
            {
                return 5;
            }
            if (((button7.Content == "X" & button9.Content == "X") | (button2.Content == "X" & button5.Content == "X")) & button8.Content == "")
            {
                return 8;
            }
            if (((button1.Content == "X" & button5.Content == "X") | (button3.Content == "X" & button6.Content == "X") | (button7.Content == "X" & button8.Content == "X")) & button9.Content == "")
            {
                return 9;
            }
            if (((button7.Content == "X" & button5.Content == "X") | (button1.Content == "X" & button2.Content == "X") | (button6.Content == "X" & button9.Content == "X")) & button3.Content == "")
            {
                return 3;
            }
            else
            {
                Random rnd = new Random();
                do
                {
                    br = rnd.Next(1, 10);
                } while (generisaniBrojeviContains(br));
                return br;
            }


        }
        
        public void randomIzaberiPolje()
        {
            try
            {

                int pom=checkLogic();
            generisaniBrojevi[i] =pom;
            i++;
            switch (pom)
            {
                case 1:
                    button1.Content = programSimbol;
                    button1.IsEnabled = false;
                    break;
                case 2:
                    button2.Content = programSimbol;
                    button2.IsEnabled = false;
                    break;
                case 3:
                    button3.Content = programSimbol;
                    button3.IsEnabled = false;
                    break;
                case 4:
                    button4.Content = programSimbol;
                    button4.IsEnabled = false;
                    break;
                case 5:
                    button5.Content = programSimbol;
                    button5.IsEnabled = false;
                    break;
                case 6:
                    button6.Content = programSimbol;
                    button6.IsEnabled = false;
                    break;
                case 7:
                    button7.Content = programSimbol;
                    button7.IsEnabled = false;
                    break;
                case 8:
                    button8.Content = programSimbol;
                    button8.IsEnabled = false;
                    break;
                case 9:
                    button9.Content = programSimbol;
                    button9.IsEnabled = false;
                    break;



            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
        public bool generisaniBrojeviContains(int br)
        {
           

            int j = 0;
            do
            {
                if (generisaniBrojevi[j] == br)
                {
                    return true;
                }
                j++;
            } while (j < generisaniBrojevi.Length);

            return false;
            
           
        }

        async Task SendWithDelay() 
        {
            await Task.Delay(200);
            randomIzaberiPolje();
        }

        public void execute()//provjeri pobjedu i iyaberi random polje
        {
            try
            {

            win();


            if (gameOver == false && i < 9)
            {

                randomIzaberiPolje();

            win();
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
        public void executeZaDvaIgraca()
        {
            try
            {
                win();
                if (gameOver == true)
                {
                    player1TextBox.Text = "";
                    player2TextBox.Text = "";
                }
                else
                {
                    if (znak == "X" && i % 2 == 1) //1 3 5 7 9
                    {
                        player1TextBox.Text = "";
                        player2TextBox.Text = "igrač 2 (O) je na redu";
                        znak = "O";
                    }
                    if (znak == "O" && i % 2 == 0)
                    {
                        player2TextBox.Text = "";
                        player1TextBox.Text = "igrač 1 (X) je na redu";
                        znak = "X";
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                button1.Content = znak;
                generisaniBrojevi[i] = 1;
                i++;
                button1.IsEnabled = false;
                if (brojIgraca == 1)
                {
                    execute();
                    // SendWithDelay();
                }
                if (brojIgraca == 2)
                {
                    executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                button2.Content = znak;
                generisaniBrojevi[i] = 2;
                i++;
                button2.IsEnabled = false;
                if (brojIgraca == 1)
                {
                    execute();
                    // SendWithDelay();
                }
                if (brojIgraca == 2)
                {
                    executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            try { 
            button3.Content = znak;
            generisaniBrojevi[i] = 3;
            i++;
            button3.IsEnabled = false;
            if (brojIgraca == 1)
            {
                execute();
                // SendWithDelay();
            }
            if (brojIgraca == 2)
            {
                executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            try { 
            button4.Content = znak;
            generisaniBrojevi[i] = 4;
            i++;
            button4.IsEnabled = false;
            if (brojIgraca == 1)
            {
                execute();
                // SendWithDelay();
            }
            if (brojIgraca == 2)
            {
                executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            try { 
            button5.Content = znak;
            generisaniBrojevi[i] = 5;
            i++;
            button5.IsEnabled = false;
            if (brojIgraca == 1)
            {
                execute();
                // SendWithDelay();
            }
            if (brojIgraca == 2)
            {
                executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try { 
            button6.Content = znak;
            generisaniBrojevi[i] = 6;
            i++;
            button6.IsEnabled = false;
            if (brojIgraca == 1)
            {
                execute();
                // SendWithDelay();
            }
            if (brojIgraca == 2)
            {
                executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            try { 
            button9.Content = znak;
            generisaniBrojevi[i] = 9;
            i++;
            button9.IsEnabled = false;
            if (brojIgraca == 1)
            {
                execute();
                // SendWithDelay();
            }
            if (brojIgraca == 2)
            {
                executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            try { 
            button7.Content = znak;
            generisaniBrojevi[i] = 7;
            i++;
            button7.IsEnabled = false;
            if (brojIgraca == 1)
            {
                execute();
                // SendWithDelay();
            }
            if (brojIgraca == 2)
            {
                executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            try { 
            button8.Content = znak;
            generisaniBrojevi[i] = 8;
            i++;
            button8.IsEnabled = false;
            if (brojIgraca == 1)
            {
                execute();
                // SendWithDelay();
            }
            if (brojIgraca == 2)
            {
                executeZaDvaIgraca();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void ispisTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void win()
        {
            try { 
             if ((button1.Content == znak & button2.Content == znak &
                  button3.Content == znak)                     
                | (button1.Content ==znak & button4.Content == znak &
                  button7.Content == znak)                     
                | (button1.Content ==znak & button5.Content == znak &
                  button9.Content == znak)                     
                | (button2.Content ==znak & button5.Content == znak &
                  button8.Content == znak)                     
                | (button3.Content ==znak & button6.Content == znak &
                  button9.Content == znak)                     
                | (button4.Content ==znak & button5.Content == znak &
                  button6.Content == znak)                     
                | (button7.Content ==znak & button8.Content == znak &
                  button9.Content == znak)                     
                | (button3.Content ==znak & button5.Content == znak &
                  button7.Content == znak))
             {
                    player1TextBox.Text = "";
                    player2TextBox.Text = "";
                 if(znak == "X")
                {

                    MessageBox.Show("Pobjedio je igrač 1");
                        bodoviIgraca1++;
                        rezultatiButton.IsEnabled = true;


                }
                if (znak == "O")
                {
                    MessageBox.Show("Pobjedio je igrač 2");
                        bodoviIgraca2++;
                        rezultatiButton.IsEnabled = true;
                    }
                
                gameOver = true;
               
                 setAllButtonsDisable();
             }
             else if((button1.Content == programSimbol & button2.Content == programSimbol &
                  button3.Content == programSimbol)
                | (button1.Content ==programSimbol & button4.Content ==programSimbol &
                  button7.Content == programSimbol)                    
                | (button1.Content ==programSimbol & button5.Content ==programSimbol &
                  button9.Content == programSimbol)                    
                | (button2.Content ==programSimbol & button5.Content ==programSimbol &
                  button8.Content == programSimbol)                    
                | (button3.Content ==programSimbol & button6.Content == programSimbol&
                  button9.Content == programSimbol)                    
                | (button4.Content ==programSimbol & button5.Content == programSimbol&
                  button6.Content == programSimbol)                    
                | (button7.Content ==programSimbol & button8.Content == programSimbol&
                  button9.Content == programSimbol)                    
                | (button3.Content ==programSimbol & button5.Content ==programSimbol &
                  button7.Content == programSimbol))
            {

                if(brojIgraca==1)
                {
                    MessageBox.Show("Pobjedio je program");
                        bodoviIgraca2++;
                        rezultatiButton.IsEnabled = true;
                    }
                if (brojIgraca == 2)
                {
                    MessageBox.Show("Pobjedio je igrač 2");
                        bodoviIgraca2++;
                        rezultatiButton.IsEnabled = true;
                    }

                gameOver = true;

                setAllButtonsDisable();

            }
            else
             {
                if(i==9)
                {
                   
                    MessageBox.Show("Igra je gotova, nema pobjednika");
                        rezultatiButton.IsEnabled = true;
                    }
                gameOver = false;

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void NovaIgra_Button_Click_1(object sender, RoutedEventArgs e)
        {
            try { 
            for(int j = 0; j < 9; j++)
            {
                generisaniBrojevi[j] = 0;
            }
             i = 0;
             br=0;
            znak = "X";
                brojIgranja++;
            player2TextBox.Text = "";
            player1TextBox.Text = "igrač 1 (X) je na redu";
            gameOver = false;
            button1.Content = ""; button2.Content = ""; button3.Content = ""; button4.Content = ""; button5.Content = ""; button6.Content = ""; button7.Content = ""; button8.Content = ""; button9.Content = "";
            setAllButtonsEnable();
                rezultatiButton.IsEnabled=false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void izadji_Button_Click(object sender, RoutedEventArgs e)
        {
            try { 
            Window1 pocetak=new Window1();
            this.Close();
            player.Stop();
            pocetak.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void pomoc_Click(object sender, RoutedEventArgs e)
        {
            try { 
            string title = "Uputstvo";
            string message = "Igru iks – oks igraju dva igrača. Igra se na dvodimenzionalnoj tabli, sa dve vrste simbola(uobičajeno je da se koriste simboli X i O).Igrač sa simbolom X prvi započinje igru. Igrači naizmjenično upisuju svoje simbole u prazna polja table.Cilj igre je povezati određen broj svojih simbola u jednoj liniji.";
            if (brojIgraca == 1)
            {
                
            MessageBox.Show(message, title);
            }
            if (brojIgraca == 2)
            {
               // string message = "SMISLICEMO NEKI TEXT ";

                MessageBox.Show(message, title);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            try { 
            player.Stop();
            Stop.Visibility = Visibility.Hidden;
            Play.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            try { 
            player.Play();
            Play.Visibility = Visibility.Hidden;
            Stop.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }

        private void rezultatiButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

           ScoreWindow score = new ScoreWindow();
            this.Close();
            player.Stop();
            score.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Unos nije validan");
            }
        }
    }
}

     

