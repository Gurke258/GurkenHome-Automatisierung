using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Raspberry
{

    public partial class frmHaupt : Form
    {

        public frmHaupt()
        {
            //Initialisieren
            InitializeComponent();
            this.Load += frmHaupt_Load;
            timerUhrzeit.Start();
            cbSonstige.DropDownStyle = ComboBoxStyle.DropDownList;

            //Wäsche Timer
            Variablen.Wäsche.Unterwäsche.timer.Tick += new EventHandler(unterwäsche_Tick);
            Variablen.Wäsche.Unterwäsche.timer.Interval = 50;
            Variablen.Wäsche.Schwarze_Wäsche.timer.Tick += new EventHandler(schwarzewäsche_Tick);
            Variablen.Wäsche.Schwarze_Wäsche.timer.Interval = 50;
            Variablen.Wäsche.Bunte_Wäsche.timer.Tick += new EventHandler(buntewäsche_Tick);
            Variablen.Wäsche.Bunte_Wäsche.timer.Interval = 50;
            Variablen.Wäsche.Weiße_Wäsche.timer.Tick += new EventHandler(weißewäsche_Tick);
            Variablen.Wäsche.Weiße_Wäsche.timer.Interval = 50;
            Variablen.Wäsche.Windeln.timer.Tick += new EventHandler(windelwäsche_Tick);
            Variablen.Wäsche.Windeln.timer.Interval = 50;
            Variablen.Wäsche.Sonstige.timer.Tick += new EventHandler(sonstigewäsche_Tick);
            Variablen.Wäsche.Sonstige.timer.Interval = 50;

            //Pflanzen Timer
            Variablen.Pflanzen.Erdbeeren.timer.Tick += new EventHandler(Erdbeeren_Tick);
            Variablen.Pflanzen.Erdbeeren.timer.Interval = 50;
            Variablen.Pflanzen.Tomaten.timer.Tick += new EventHandler(Tomaten_Tick);
            Variablen.Pflanzen.Tomaten.timer.Interval = 50;
            Variablen.Pflanzen.Radieschen.timer.Tick += new EventHandler(Radieschen_Tick);
            Variablen.Pflanzen.Radieschen.timer.Interval = 50;

        }

        private void frmHaupt_Load(object sender, EventArgs e)
        {

          timerDHT.Start();
          Variablen.DHT.dhtresult = Variablen.DHT.dhtcommand.Bash();
          lblTemp.Text = Variablen.DHT.dhtresult;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerUhrzeit_Tick(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            lblUhrzeit.Text = today.ToString("dddd dd.MM.yyyy HH:mm");
        }

        //Timer für die Temperatur
        private void timerDHT_Tick(object sender, EventArgs e)
        {
            Variablen.DHT.dhtresult = Variablen.DHT.dhtcommand.Bash();
            lblTemp.Text = Variablen.DHT.dhtresult;
        }

        #region Wäsche
        //Unterwäsche
        private void cmdUnterwäsche_Click(object sender, EventArgs e)
        {
            if (cmdUnterwäsche.Text == "Start")
            {
                cmdUnterwäsche.Text = "Maschine läuft";
                cmdUnterwäsche.BackColor = Color.LightGreen;
                lblTimerUnter.ForeColor = Color.Green;
                Variablen.Wäsche.Unterwäsche.endtime = DateTime.Now.AddSeconds(10800);
                Variablen.Wäsche.Unterwäsche.timer.Start();

            }
            else if (cmdUnterwäsche.Text == "Maschine läuft")
            {
                cmdUnterwäsche.Text = "Aufhängen!";
                cmdUnterwäsche.BackColor = Color.Crimson;
                cmdUnterwäsche.ForeColor = Color.White;
                lblTimerUnter.ForeColor = Color.Red;
                Variablen.Wäsche.Unterwäsche.timer.Stop();

            }
            else if (cmdUnterwäsche.Text == "Aufhängen!")
            {
                cmdUnterwäsche.Text = "Start";
                cmdUnterwäsche.BackColor = Color.Transparent;
                cmdUnterwäsche.ForeColor = Color.Black;
                lblTimerUnter.ForeColor = Color.Black;
                lblTimerUnter.Text = "03:00:00";
            }
        }

        private void unterwäsche_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Wäsche.Unterwäsche.endtime.Subtract(DateTime.Now);
            if (leftTime.TotalSeconds < 0)
            {
                lblTimerUnter.ForeColor = Color.Red;
                Variablen.Wäsche.Unterwäsche.countDownString = "00:00:00";
                
                Variablen.Wäsche.Unterwäsche.timer.Stop();
                cmdUnterwäsche.BackColor = Color.Crimson;
                cmdUnterwäsche.ForeColor = Color.White;
                cmdUnterwäsche.Text = "Aufhängen!";
                MessageBox.Show("Unterwäsche ist fertig!");
            }
            else
            {
                Variablen.Wäsche.Unterwäsche.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                  lblTimerUnter.Text = Variablen.Wäsche.Unterwäsche.countDownString;  
            }
            
        }
        //Schwarze Wäsche
        private void cmdSchwarze_Click(object sender, EventArgs e)
        {
            if (cmdSchwarze.Text == "Start")
            {
                cmdSchwarze.Text = "Maschine läuft";
                cmdSchwarze.BackColor = Color.LightGreen; 
                lblTimerSchwarz.ForeColor = Color.Green;
                Variablen.Wäsche.Schwarze_Wäsche.endtime = DateTime.Now.AddSeconds(7200);
                Variablen.Wäsche.Schwarze_Wäsche.timer.Start();
            }
            else if (cmdSchwarze.Text == "Maschine läuft")
            {
                cmdSchwarze.Text = "Aufhängen!";
                cmdSchwarze.BackColor = Color.Crimson; 
                cmdSchwarze.ForeColor = Color.White;
                lblTimerSchwarz.ForeColor = Color.Red;
                Variablen.Wäsche.Schwarze_Wäsche.timer.Stop();
            }
            else if (cmdSchwarze.Text == "Aufhängen!")
            {
                cmdSchwarze.Text = "Start";
                cmdSchwarze.BackColor = Color.Transparent; 
                cmdSchwarze.ForeColor = Color.Black;
                lblTimerSchwarz.ForeColor = Color.Black;
                lblTimerSchwarz.Text = "02:00:00";
            }
        }

        private void schwarzewäsche_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Wäsche.Schwarze_Wäsche.endtime.Subtract(DateTime.Now);
            if (leftTime.TotalSeconds < 0)
            {
                lblTimerSchwarz.ForeColor = Color.Red;
                Variablen.Wäsche.Schwarze_Wäsche.countDownString = "00:00:00";

                Variablen.Wäsche.Schwarze_Wäsche.timer.Stop();
                cmdSchwarze.BackColor = Color.Crimson;
                cmdSchwarze.ForeColor = Color.White;
                cmdSchwarze.Text = "Aufhängen!";
                MessageBox.Show("Schwarze Wäsche ist fertig!");
            }
            else
            {
                Variablen.Wäsche.Schwarze_Wäsche.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerSchwarz.Text = Variablen.Wäsche.Schwarze_Wäsche.countDownString;
            }
        }

        private void cmdBunte_Click(object sender, EventArgs e)
        {
            if (cmdBunte.Text == "Start")
            {
                cmdBunte.Text = "Maschine läuft";
                cmdBunte.BackColor = Color.LightGreen;
                lblTimerBunt.ForeColor = Color.Green;
                Variablen.Wäsche.Bunte_Wäsche.endtime = DateTime.Now.AddSeconds(7200);
                Variablen.Wäsche.Bunte_Wäsche.timer.Start();
            }
            else if (cmdBunte.Text == "Maschine läuft")
            {
                cmdBunte.Text = "Aufhängen!";
                cmdBunte.BackColor = Color.Crimson;
                cmdBunte.ForeColor = Color.White;
                lblTimerBunt.ForeColor = Color.Red;
                Variablen.Wäsche.Bunte_Wäsche.timer.Stop();
            }
            else if (cmdBunte.Text == "Aufhängen!")
            {
                cmdBunte.Text = "Start";
                cmdBunte.BackColor = Color.Transparent;
                cmdBunte.ForeColor = Color.Black;
                lblTimerBunt.ForeColor = Color.Black;
                lblTimerBunt.Text = "02:00:00";
            }
        }

        private void buntewäsche_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Wäsche.Bunte_Wäsche.endtime.Subtract(DateTime.Now);
            if (leftTime.TotalSeconds < 0)
            {
                lblTimerBunt.ForeColor = Color.Red;
                Variablen.Wäsche.Bunte_Wäsche.countDownString = "00:00:00";

                Variablen.Wäsche.Bunte_Wäsche.timer.Stop();
                cmdBunte.BackColor = Color.Crimson;
                cmdBunte.ForeColor = Color.White;
                cmdBunte.Text = "Aufhängen!";
                MessageBox.Show("Bunte Wäsche ist fertig!");
            }
            else
            {
                Variablen.Wäsche.Bunte_Wäsche.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerBunt.Text = Variablen.Wäsche.Bunte_Wäsche.countDownString;
            }
        }
        private void cmdWeiße_Click(object sender, EventArgs e)
        {
            if (cmdWeiße.Text == "Start")
            {
                cmdWeiße.Text = "Maschine läuft";
                cmdWeiße.BackColor = Color.LightGreen;
                lblTimerWeiß.ForeColor = Color.Green;
                Variablen.Wäsche.Weiße_Wäsche.endtime = DateTime.Now.AddSeconds(7200);
                Variablen.Wäsche.Weiße_Wäsche.timer.Start();
            }
            else if (cmdWeiße.Text == "Maschine läuft")
            {
                cmdWeiße.Text = "Aufhängen!";
                cmdWeiße.BackColor = Color.Crimson;
                cmdWeiße.ForeColor = Color.White;
                lblTimerWeiß.ForeColor = Color.Red;
                Variablen.Wäsche.Weiße_Wäsche.timer.Stop();
            }
            else if (cmdWeiße.Text == "Aufhängen!")
            {
                cmdWeiße.Text = "Start";
                cmdWeiße.BackColor = Color.Transparent;
                cmdWeiße.ForeColor = Color.Black;
                lblTimerWeiß.ForeColor = Color.Black;
                lblTimerWeiß.Text = "02:00:00";
            }
        }

        private void weißewäsche_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Wäsche.Weiße_Wäsche.endtime.Subtract(DateTime.Now);
            if (leftTime.TotalSeconds < 0)
            {
                lblTimerWeiß.ForeColor = Color.Red;
                Variablen.Wäsche.Weiße_Wäsche.countDownString = "00:00:00";

                Variablen.Wäsche.Weiße_Wäsche.timer.Stop();
                cmdWeiße.BackColor = Color.Crimson;
                cmdWeiße.ForeColor = Color.White;
                cmdWeiße.Text = "Aufhängen!";
                MessageBox.Show("Weiße Wäsche ist fertig!");
            }
            else
            {
                Variablen.Wäsche.Weiße_Wäsche.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerWeiß.Text = Variablen.Wäsche.Weiße_Wäsche.countDownString;
            }
        }
        private void cmdWindeln_Click(object sender, EventArgs e)
        {
            if (cmdWindeln.Text == "Start")
            {
                cmdWindeln.Text = "Maschine läuft";
                cmdWindeln.BackColor = Color.LightGreen;
                lblTimerWindeln.ForeColor = Color.Green;
                Variablen.Wäsche.Windeln.endtime = DateTime.Now.AddSeconds(10800);
                Variablen.Wäsche.Windeln.timer.Start();
            }
            else if (cmdWindeln.Text == "Maschine läuft")
            {
                cmdWindeln.Text = "Aufhängen!";
                cmdWindeln.BackColor = Color.Crimson;
                cmdWindeln.ForeColor = Color.White;
                lblTimerWindeln.ForeColor = Color.Red;
                Variablen.Wäsche.Windeln.timer.Stop();
            }
            else if (cmdWindeln.Text == "Aufhängen!")
            {
                cmdWindeln.Text = "Start";
                cmdWindeln.BackColor = Color.Transparent;
                cmdWindeln.ForeColor = Color.Black;
                lblTimerWindeln.ForeColor = Color.Black;
                lblTimerWindeln.Text = "03:00:00";
            }
        }

        private void windelwäsche_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Wäsche.Windeln.endtime.Subtract(DateTime.Now);
            if (leftTime.TotalSeconds < 0)
            {
                lblTimerWindeln.ForeColor = Color.Red;
                Variablen.Wäsche.Windeln.countDownString = "00:00:00";

                Variablen.Wäsche.Windeln.timer.Stop();
                cmdWindeln.BackColor = Color.Crimson;
                cmdWindeln.ForeColor = Color.White;
                cmdWindeln.Text = "Aufhängen!";
                MessageBox.Show("Windeln sind fertig!");
            }
            else
            {
                Variablen.Wäsche.Windeln.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerWindeln.Text = Variablen.Wäsche.Windeln.countDownString;
            }
        }
        private void cmdSonstige_Click(object sender, EventArgs e)
        {

            if (cmdSonstige.Text == "Start")
            {
                cmdSonstige.Text = "Maschine läuft";
                cmdSonstige.BackColor = Color.LightGreen;
                lblTimerSonstige.ForeColor = Color.Green;

                if (cbSonstige.SelectedIndex == 0)
                {
                    Variablen.Wäsche.Sonstige.zeit = 900;
                }
                else if (cbSonstige.SelectedIndex == 1)
                {
                    Variablen.Wäsche.Sonstige.zeit = 1800;
                }
                else if (cbSonstige.SelectedIndex == 2)
                {
                    Variablen.Wäsche.Sonstige.zeit = 2100;
                }
                else if (cbSonstige.SelectedIndex == 3)
                {
                    Variablen.Wäsche.Sonstige.zeit = 2700;
                }
                else if (cbSonstige.SelectedIndex == 4)
                {
                    Variablen.Wäsche.Sonstige.zeit = 3600;
                }
                else if (cbSonstige.SelectedIndex == 5)
                {
                    Variablen.Wäsche.Sonstige.zeit = 5400;
                }
                else if (cbSonstige.SelectedIndex == 6)
                {
                    Variablen.Wäsche.Sonstige.zeit = 7200;
                }

                Variablen.Wäsche.Sonstige.endtime = DateTime.Now.AddSeconds(Variablen.Wäsche.Sonstige.zeit);
                Variablen.Wäsche.Sonstige.timer.Start();
            }
            else if (cmdSonstige.Text == "Maschine läuft")
            {
                cmdSonstige.Text = "Aufhängen!";
                cmdSonstige.BackColor = Color.Crimson;
                cmdSonstige.ForeColor = Color.White;
                lblTimerSonstige.ForeColor = Color.Red;
                Variablen.Wäsche.Sonstige.timer.Stop();
            }
            else if (cmdSonstige.Text == "Aufhängen!")
            {
                cmdSonstige.Text = "Start";
                cmdSonstige.BackColor = Color.Transparent;
                cmdSonstige.ForeColor = Color.Black;
                lblTimerSonstige.ForeColor = Color.Black;
                lblTimerSonstige.Text = "--:--:--";
            }
            
        }
        private void sonstigewäsche_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Wäsche.Sonstige.endtime.Subtract(DateTime.Now);
            if (leftTime.TotalSeconds < 0)
            {
                lblTimerSonstige.ForeColor = Color.Red;
                Variablen.Wäsche.Sonstige.countDownString = "00:00:00";

                Variablen.Wäsche.Sonstige.timer.Stop();
                cmdSonstige.BackColor = Color.Crimson;
                cmdSonstige.ForeColor = Color.White;
                cmdSonstige.Text = "Aufhängen!";
                MessageBox.Show("Was auch immer du gewaschen hast ist fertig!");
            }
            else
            {
                Variablen.Wäsche.Sonstige.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerSonstige.Text = Variablen.Wäsche.Sonstige.countDownString;
            }
        }
        #endregion

        #region Pflanzen
        private void Erdbeeren_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Pflanzen.Erdbeeren.endtime.Subtract(DateTime.Now);

            if (leftTime.TotalSeconds < 0)
            {
                lblTimerErdbeeren.ForeColor = Color.Red;
                Variablen.Pflanzen.Erdbeeren.countDownString = "00:00:00";

                Variablen.Pflanzen.Erdbeeren.timer.Stop();
                cmdErdbeeren.BackColor = Color.Crimson;
                cmdErdbeeren.ForeColor = Color.White;
                cmdErdbeeren.Text = "Jetzt gießen!";
                MessageBox.Show("Erdbeeren müssen gegossen werden!");
            }
            else
            {
                Variablen.Pflanzen.Erdbeeren.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerErdbeeren.Text = Variablen.Pflanzen.Erdbeeren.countDownString;
            }
        }

        private void Tomaten_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Pflanzen.Tomaten.endtime.Subtract(DateTime.Now);

            if (leftTime.TotalSeconds < 0)
            {
                lblTimerTomate.ForeColor = Color.Red;
                Variablen.Pflanzen.Tomaten.countDownString = "00:00:00";

                Variablen.Pflanzen.Tomaten.timer.Stop();
                cmdTomaten.BackColor = Color.Crimson;
                cmdTomaten.ForeColor = Color.White;
                cmdTomaten.Text = "Jetzt gießen!";
                MessageBox.Show("Tomaten müssen gegossen werden!");
            }
            else
            {
                Variablen.Pflanzen.Tomaten.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerTomate.Text = Variablen.Pflanzen.Tomaten.countDownString;
            }
        }

        private void Radieschen_Tick(object sender, EventArgs e)
        {
            TimeSpan leftTime = Variablen.Pflanzen.Radieschen.endtime.Subtract(DateTime.Now);

            if (leftTime.TotalSeconds < 0)
            {
                lblTimerRadieschen.ForeColor = Color.Red;
                Variablen.Pflanzen.Radieschen.countDownString = "00:00:00";

                Variablen.Pflanzen.Radieschen.timer.Stop();
                cmdRadieschen.BackColor = Color.Crimson;
                cmdRadieschen.ForeColor = Color.White;
                cmdRadieschen.Text = "Jetzt gießen!";
                MessageBox.Show("Radieschen müssen gegossen werden!");
            }
            else
            {
                Variablen.Pflanzen.Radieschen.countDownString = leftTime.Hours.ToString("00") + ":" +
                  leftTime.Minutes.ToString("00") + ":" +
                  leftTime.Seconds.ToString("00");
                lblTimerRadieschen.Text = Variablen.Pflanzen.Radieschen.countDownString;
            }
        }

        private void cmdErdbeeren_Click(object sender, EventArgs e)
        {
            if (cmdErdbeeren.Text == "Gegossen!")
            {
                cmdErdbeeren.Text = "Jetzt gießen!";
                cmdErdbeeren.BackColor = Color.Crimson;
                cmdErdbeeren.ForeColor = Color.White;
                lblTimerErdbeeren.ForeColor = Color.Red;
                Variablen.Pflanzen.Erdbeeren.timer.Stop();


            }
            else if (cmdErdbeeren.Text == "Jetzt gießen!")
            {
                cmdErdbeeren.Text = "Gegossen!";
                cmdErdbeeren.BackColor = Color.Transparent;
                cmdErdbeeren.ForeColor = Color.Black;
                lblTimerErdbeeren.ForeColor = Color.Black;
                Variablen.Pflanzen.Erdbeeren.endtime = DateTime.Now.AddSeconds(86400);
                Variablen.Pflanzen.Erdbeeren.timer.Start();

            }
        }
        #endregion

        private void cmdTomaten_Click(object sender, EventArgs e)
        {
            if (cmdTomaten.Text == "Gegossen!")
            {
                cmdTomaten.Text = "Jetzt gießen!";
                cmdTomaten.BackColor = Color.Crimson;
                cmdTomaten.ForeColor = Color.White;
                lblTimerTomate.ForeColor = Color.Red;
                Variablen.Pflanzen.Tomaten.timer.Stop();


            }
            else if (cmdTomaten.Text == "Jetzt gießen!")
            {
                cmdTomaten.Text = "Gegossen!";
                cmdTomaten.BackColor = Color.Transparent;
                cmdTomaten.ForeColor = Color.Black;
                lblTimerTomate.ForeColor = Color.Black;
                Variablen.Pflanzen.Tomaten.endtime = DateTime.Now.AddSeconds(86400);
                Variablen.Pflanzen.Tomaten.timer.Start();

            }
        }

        private void cmdRadieschen_Click(object sender, EventArgs e)
        {
            if (cmdRadieschen.Text == "Gegossen!")
            {
                cmdRadieschen.Text = "Jetzt gießen!";
                cmdRadieschen.BackColor = Color.Crimson;
                cmdRadieschen.ForeColor = Color.White;
                lblTimerRadieschen.ForeColor = Color.Red;
                Variablen.Pflanzen.Radieschen.timer.Stop();


            }
            else if (cmdRadieschen.Text == "Jetzt gießen!")
            {
                cmdRadieschen.Text = "Gegossen!";
                cmdRadieschen.BackColor = Color.Transparent;
                cmdRadieschen.ForeColor = Color.Black;
                lblTimerRadieschen.ForeColor = Color.Black;
                Variablen.Pflanzen.Radieschen.endtime = DateTime.Now.AddSeconds(86400);
                Variablen.Pflanzen.Radieschen.timer.Start();

            }
        }
    }
}
