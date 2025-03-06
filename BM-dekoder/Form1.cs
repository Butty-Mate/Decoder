using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BM_dekoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const string uzenetKezdete = "xxx";
            const string uzenetVege = ".-+.";
            const string fileVege = ".-.-.+.+.";
            const string elvalaszto = ".x.";

            string inputFilePath = "messages.log";
            string outputFilePath = "output.txt";

            StringBuilder output = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);
            int lineNumber = 1;

            foreach (string line in lines)
            {
                if (line.Contains(uzenetKezdete) && line.Contains(uzenetVege))
                {
                    string[] parts = line.Split(new string[] { elvalaszto }, StringSplitOptions.None);
                    if (parts.Length >= 4)
                    {
                        string timestamp = parts[0].Substring(uzenetKezdete.Length);
                        Debug.WriteLine($" hiba {timestamp}");
                        timestamp = timestamp.Substring(timestamp.Length - 18);
                        Debug.WriteLine($" jo {timestamp}");
                        string message = parts[1];
                        string ip1Hex = parts[2];
                        string ip2Hex = parts[3].Substring(0, parts[3].IndexOf(uzenetVege));

                        long ticks = long.Parse(timestamp);
                        DateTime dateTime = new DateTime(ticks);


                        output.AppendLine($"{lineNumber} - {dateTime} - {message} - {BinaryToIp(ip1Hex)} - {BinaryToIp(ip2Hex)}");
                        lineNumber++;
                    }
                }
            }

            File.WriteAllText(outputFilePath, output.ToString());

            /*
            string[] adat = File.ReadAllLines("message.log");
            int db = 0;
            foreach (string i in adat)
            { 
            if (i == "x"){
                db++;
                    if (db == 3)
                    {

                    }
            }
            else db = 0;
                
            }
            */

        }
        static string BinaryToIp(string binary)
        {
            string ipCim = "";

            for (int i = 0; i < 32; i += 8)
            {

                int ipdeci = Convert.ToInt32(binary.Substring(i, 8), 2);
                ipCim += ipdeci;

                if (i < 24)
                {
                    ipCim += ".";
                }
            }

            return ipCim;
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            /*
            StreamWriter writer = new StreamWriter("message.txt"); 
            //if (ip1.TextLength < 15 && ip1.Text < 7)
            string Ip1Send = ip1.Text;
            string Ip2Send = ip2.Text;
            string MessageSend = message.Text;
            string DateSend = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string ujSor = $"";
            */
        }
    }
}
