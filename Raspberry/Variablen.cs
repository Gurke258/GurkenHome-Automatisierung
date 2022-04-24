using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Raspberry
{
    class Variablen
    {
        public class DHT
        {
           public static string dhtresult;
           public static string dhtcommand = "sudo /home/pi/Adafruit_Python_DHT/examples/AdafruitDHT.py 11 22";
        }

        public class Wäsche
        {
            public class Unterwäsche
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

            public class Schwarze_Wäsche
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

            public class Bunte_Wäsche
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

            public class Weiße_Wäsche
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

            public class Windeln
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

            public class Sonstige
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
                public static int zeit;
            }
        }

        public class Pflanzen
        {
            public class Erdbeeren
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

            public class Tomaten
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

            public class Radieschen
            {
                public static Timer timer = new Timer();
                public static string countDownString;
                public static DateTime endtime;
            }

        }
    }
}
