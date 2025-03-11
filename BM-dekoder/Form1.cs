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
            // Fájl elérési útja
            string fajlUt = "messages.log";

            // DataTable létrehozása a táblázatos megjelenítéshez
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Sorszám");
            tabla.Columns.Add("IP1");
            tabla.Columns.Add("IP2");
            tabla.Columns.Add("Üzenet");
            tabla.Columns.Add("Időbélyeg");

            // Fájl beolvasása soronként
            string[] sorok = File.ReadAllLines(fajlUt);
            int sorszam = 1;

            foreach (string sor in sorok)
            {
                // Ellenőrizzük, hogy a sor tartalmazza-e az üzenet kezdetét és végét
                if (sor.Contains(UzenetKezdete) && sor.Contains(UzenetVege))
                {
                    // A sort részekre bontjuk az elválasztó alapján
                    string[] reszek = sor.Split(new string[] { Elvalaszto }, StringSplitOptions.None);

                    if (reszek.Length >= 4)
                    {
                        // Időbélyeg kinyerése és formázása
                        string idoBelyeg = reszek[0].Substring(UzenetKezdete.Length);
                        idoBelyeg = idoBelyeg.Substring(idoBelyeg.Length - 18);
                        DateTime datumIdo = new DateTime(long.Parse(idoBelyeg));

                        // Üzenet és IP címek kinyerése
                        string uzenet = reszek[1];
                        string feladoIp = reszek[2];
                        string cimzettIp = reszek[3].Substring(0, reszek[3].IndexOf(UzenetVege));

                        // IP címek binárisból decimálisba konvertálása
                        string feladoIpDec = BinarisbolIp(feladoIp);
                        string cimzettIpDec = BinarisbolIp(cimzettIp);

                        // Ha a konverzió sikeres, akkor hozzáadjuk a táblázathoz
                        if (!string.IsNullOrEmpty(feladoIpDec) && !string.IsNullOrEmpty(cimzettIpDec))
                        {
                            tabla.Rows.Add(sorszam, feladoIpDec, cimzettIpDec, uzenet, datumIdo);
                            sorszam++;
                        }
                    }
                }
            }

            // A DataGridView frissítése a dekódolt adatokkal
            dataGridView_send.DataSource = tabla;
        }

        // Bináris IP cím átalakítása decimális formátumba
        private string BinarisbolIp(string binarisIp)
        {
            // Ellenőrizzük, hogy a bináris IP cím pontosan 32 karakter hosszú-e
            if (binarisIp.Length != 32)
            {
                MessageBox.Show($"Hibás bináris IP cím hossz: {binarisIp.Length} karakter. Pontosan 32 karakternek kell lennie.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Ellenőrizzük, hogy a bináris IP cím csak 0 és 1 karaktereket tartalmaz-e
            foreach (char c in binarisIp)
            {
                if (c != '0' && c != '1')
                {
                    MessageBox.Show($"Hibás karakter a bináris IP címben: {c}. Csak 0 és 1 karakterek megengedettek.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
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

        // Új üzenet hozzáadása a fájlhoz
        private void btn_send_Click(object sender, EventArgs e)
        {
            string feladoIp = ip1.Text;
            string cimzettIp = ip2.Text;
            string uzenet = message.Text;
            long idoBelyeg = DateTime.Now.Ticks;

            // IP címek ellenőrzése és bináris formátumba konvertálása
            string feladoIpBin = IpbolBinaris(feladoIp);
            string cimzettIpBin = IpbolBinaris(cimzettIp);

            if (string.IsNullOrEmpty(feladoIpBin) || string.IsNullOrEmpty(cimzettIpBin))
            {
                MessageBox.Show("Hibás IP cím formátum!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Az új sor formázása a kódolási szabályok szerint
            string ujSor = $"xxx{idoBelyeg}.x.{uzenet}.x.{feladoIpBin}.x.{cimzettIpBin}.-+.";

            // Az új sor hozzáadása a fájlhoz
            File.AppendAllText("messages.log", ujSor + Environment.NewLine);

            // Üzenet elküldve, mezők törlése
            ip1.Text = "";
            ip2.Text = "";
            message.Text = "";

            MessageBox.Show("Üzenet elküldve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Decimális IP cím átalakítása bináris formátumba
        private string IpbolBinaris(string ip)
        {
            string[] reszek = ip.Split('.');
            string binaris = "";

            foreach (string resz in reszek)
            {
                // Ellenőrizzük, hogy az IP cím részei számok-e
                if (!int.TryParse(resz, out int decimális))
                {
                    MessageBox.Show($"Hibás IP cím rész: {resz}. Csak számok megengedettek.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                // Ellenőrizzük, hogy az IP cím részei 0 és 255 között vannak-e
                if (decimális < 0 || decimális > 255)
                {
                    MessageBox.Show($"Hibás IP cím rész: {resz}. Az értéknek 0 és 255 között kell lennie.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                // Bináris formátumba konvertálás (8 biten)
                binaris += Convert.ToString(decimális, 2).PadLeft(8, '0');
            }

            return binaris;
        }

        // Kilépés a programból
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Dekódolás gomb eseménykezelője
        private void btn_dekod_Click(object sender, EventArgs e)
        {
            DekodolEsMegjelenit();
        }
    }
}