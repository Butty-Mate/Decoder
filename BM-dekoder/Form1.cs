using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BM_dekoder
{
    public partial class Form1 : Form
    {
        const string UzenetKezdete = "xxx";
        const string UzenetVege = ".-+.";
        const string FileVege = ".-.-.+.+.";
        const string Elvalaszto = ".x.";

        public Form1()
        {
            InitializeComponent();
            dataGridView_send.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Sorszám");
            tabla.Columns.Add("IP1");
            tabla.Columns.Add("IP2");
            tabla.Columns.Add("Üzenet");
            tabla.Columns.Add("Időbélyeg");

            dataGridView_send.DataSource = tabla;
        }

        private void DekodolEsMegjelenit()
        {

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Sorszám");
            tabla.Columns.Add("IP1");
            tabla.Columns.Add("IP2");
            tabla.Columns.Add("Üzenet");
            tabla.Columns.Add("Időbélyeg");

            string[] sorok = File.ReadAllLines("messages.log");
            int sorszam = 1;

            foreach (string sor in sorok)
            {

                if (sor.Contains(UzenetKezdete) && sor.Contains(UzenetVege))
                {
                    string[] reszek = sor.Split(new string[] { Elvalaszto }, StringSplitOptions.None);

                    if (reszek.Length >= 4)
                    {
                        string idoBelyeg = reszek[0].Substring(UzenetKezdete.Length);
                        idoBelyeg = idoBelyeg.Substring(idoBelyeg.Length - 18);
                        DateTime datumIdo = new DateTime(long.Parse(idoBelyeg));


                        string uzenet = reszek[1];
                        string feladoIp = reszek[2];
                        string cimzettIp = reszek[3].Substring(0, reszek[3].IndexOf(UzenetVege));


                        string feladoIpDec = BinarisbolIp(feladoIp);
                        string cimzettIpDec = BinarisbolIp(cimzettIp);



                            tabla.Rows.Add(sorszam, feladoIpDec, cimzettIpDec, uzenet, datumIdo);
                            sorszam++;

                    }
                }
            }


            dataGridView_send.DataSource = tabla;
        }

        private string BinarisbolIp(string binarisIp)
        {

            if (binarisIp.Length != 32)
            {
                MessageBox.Show($"Hibás bináris IP cím hossz: {binarisIp.Length} karakter. Pontosan 32 karakternek kell lennie.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            string ipCim = "";

            for (int i = 0; i < 32; i += 8)
            {
                int decimális = Convert.ToInt32(binarisIp.Substring(i, 8), 2);
                ipCim += decimális;

                if (i < 24)
                {
                    ipCim += ".";
                }
            }

            return ipCim;
        }


        private void btn_send_Click(object sender, EventArgs e)
        {
            string feladoIp = ip1.Text;
            string cimzettIp = ip2.Text;
            string uzenet = message.Text;
            long idoBelyeg = DateTime.Now.Ticks;


            string feladoIpBin = IpbolBinaris(feladoIp);
            string cimzettIpBin = IpbolBinaris(cimzettIp);

            if (string.IsNullOrEmpty(feladoIpBin) || string.IsNullOrEmpty(cimzettIpBin))
            {
                MessageBox.Show("Hibás IP cím formátum!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string ujSor = $"xxx{idoBelyeg}.x.{uzenet}.x.{feladoIpBin}.x.{cimzettIpBin}.-+.";


            File.AppendAllText("messages.log", ujSor + "\r\n");


            ip1.Text = "";
            ip2.Text = "";
            message.Text = "";

            MessageBox.Show("Üzenet elküldve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string IpbolBinaris(string ip)
        {
            string[] reszek = ip.Split('.');
            string binaris = "";

            foreach (string resz in reszek)
            {

                if (!int.TryParse(resz, out int decimális))
                {
                    MessageBox.Show($"Hibás IP cím rész: {resz}. Csak számok megengedettek.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }


                if (decimális < 0 || decimális > 255)
                {
                    MessageBox.Show($"Hibás IP cím rész: {resz}. Az értéknek 0 és 255 között kell lennie.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }


                binaris += Convert.ToString(decimális, 2).PadLeft(8, '0');
            }

            return binaris;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dekod_Click(object sender, EventArgs e)
        {
            DekodolEsMegjelenit();
        }
    }
}