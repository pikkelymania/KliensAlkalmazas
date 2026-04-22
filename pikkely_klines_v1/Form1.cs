using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace pikkely_klines_v1
{
    public partial class Form1 : Form
    {
        private const string ApiKey = "1-befdaca0-4407-469d-a078-66359f0487d2";
        private const string BaseUrl = "http://www.pikkelymania.hu/DesktopModules/Hotcakes/API/rest/v1/";

        // A HttpClient felelõs a hálózati kommunikációért
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            // Felhasználói visszajelzés a gombnyomáskor
            lblResult.Text = "Kapcsolódás folyamatban...";
            lblResult.ForeColor = System.Drawing.Color.Orange;
            btnTestConnection.Enabled = false;

            // Bármelyik létezõ végpont jó a tesztre, használjuk a 'products'-ot
            string url = $"{BaseUrl}products?key={ApiKey}";

            // Írjuk ki a képernyõre a pontos URL-t küldés elõtt:
            MessageBox.Show($"Ezt az URL-t hívjuk meg:\n{url}", "Cím ellenõrzése");

            try
            {
                // Elküldjük a GET kérést, de csak a fejrész/státuszkód érdekel minket
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // Ha a státuszkód 200-299 közötti (pl. 200 OK)
                    lblResult.Text = "Sikeres kapcsolat az API-val!";
                    lblResult.ForeColor = System.Drawing.Color.Green;

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    txtRawData.Text = jsonResponse;

                    // 2. A szöveg átalakítása C# objektummá (Deszerializáció)
                    var apiResult = JsonConvert.DeserializeObject<Rootobject>(jsonResponse);

                    // 3. Az adatok betöltése a táblázatba
                    // Ellenõrizzük, hogy van-e tartalom és vannak-e termékek
                    if (apiResult != null && apiResult.Content != null && apiResult.Content.Products != null)
                    {
                        // A DataGridView DataSource tulajdonsága automatikusan létrehozza az oszlopokat!
                        dgvProducts.DataSource = apiResult.Content.Products;
                    }
                }
                else
                {
                    // Ha a kulcs rossz, vagy nincs jogosultság (pl. 401, 403, 404)
                    lblResult.Text = $"Sikertelen! Válaszkód: {response.StatusCode} ({(int)response.StatusCode})";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (HttpRequestException httpEx)
            {
                // Hálózati hiba (pl. nincs internet, vagy nem elérhetõ a szerver)
                lblResult.Text = "Hálózati hiba történt.";
                lblResult.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Nem sikerült elérni a szervert:\n{httpEx.Message}", "Hiba");
            }
            finally
            {
                // A gombot mindenképpen újra engedélyezzük a folyamat végén
                btnTestConnection.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
