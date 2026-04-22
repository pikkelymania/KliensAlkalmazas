using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pikkely_klines_v1
{
    public partial class HullokUserControl : UserControl
    {
        private const string ApiKey = "1-befdaca0-4407-469d-a078-66359f0487d2";
        private const string BaseUrl = "http://www.pikkelymania.hu/DesktopModules/Hotcakes/API/rest/v1/";

        private static readonly HttpClient client = new HttpClient();

        // 1. LÉPÉS: Osztályszintű változó! Ezt az osztályon belül minden gomb látni fogja.
        private List<Product> _baseProductList = new List<Product>();
        public HullokUserControl()
        {
            InitializeComponent();
        }

        private async void HullokUserControl_Load(object sender, EventArgs e)
        {
            string url = $"{BaseUrl}products?key={ApiKey}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var apiResult = JsonConvert.DeserializeObject<Rootobject>(jsonResponse);

                    // Ellenőrizzük a null értékeket (C# 6.0+ rövidebb szintaxisával)
                    if (apiResult?.Content?.Products != null)
                    {
                        // 2. LÉPÉS: A betöltött és alapból szűrt adatokat elmentjük a közös változóba
                        _baseProductList = apiResult.Content.Products
                            .Where(p => p.ProductTypeId == "d780ab12-56c7-41af-94c9-d6442710c51d")
                            .ToList();

                        // Megjelenítjük az alap (összes hüllő) listát
                        DisplayData(_baseProductList);
                    }
                }
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"Nem sikerült elérni a szervert:\n{httpEx.Message}", "Hiba");
            }

        }

        // 3. LÉPÉS: Egy saját segédmetódus a megjelenítésre. Így nem kell ismételni a kódot!
        private void DisplayData(List<Product> productsToShow)
        {
            // A BindingList jelzi a táblázatnak a változásokat (szerkesztéshez kiváló)
            dataGridView1.DataSource = new BindingList<Product>(productsToShow);
        }


        private void SzuresFajra(string keresettSkuReszlet)
        {
            if (_baseProductList != null && _baseProductList.Count > 0)
            {
                // Szűrjük a listát a kapott paraméter (keresettSkuReszlet) alapján.
                // A ToUpper()-t ráhúzzuk a paraméterre is, így teljesen mindegy, 
                // kis- vagy nagybetűvel adod-e át.
                var filtered = _baseProductList
                    .Where(p => p.Sku != null && p.Sku.ToUpper().Contains(keresettSkuReszlet.ToUpper()))
                    .ToList();

                // Megjelenítés
                DisplayData(filtered);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SzuresFajra("KIR-PIT");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SzuresFajra("GAB-SIK");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SzuresFajra("LEO-GEK");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SzuresFajra("VIT-GEK");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SzuresFajra("SZA-AGA");
        }
    }
}
