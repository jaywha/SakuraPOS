using MongoDB.Bson;
using MongoDB.Driver;
using SakuraPOS.Models;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Text;
using WinForms = System.Windows.Forms;

namespace SakuraPOS
{
    public partial class frmMain : Form
    {
        private System.Threading.Timer clock;

        public frmMain()
        {
            InitializeComponent();
            clock = new(clockTick, new AutoResetEvent(false), 0, 1000);
        }

        private async void connectToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlMenuTypes.Controls.Clear();

            byte[] enc = Convert.FromBase64String("Z3Jvb3Z5NGFsbA==");
            string pwd = Encoding.UTF8.GetString(enc);

            // Replace the uri string with your MongoDB deployment's connection string.
            var client = new MongoClient(
                $"mongodb+srv://gcadmin:{pwd}@rhythm-gnome-db.5tddy.mongodb.net/test?authSource=admin&replicaSet=atlas-ehyha0-shard-0&readPreference=primary&ssl=true"
            );
            var database = client.GetDatabase("Sakura-POS-DB");
            var collection = database.GetCollection<POSMenuCategoryModel>("menu_categories");

            using var cursor = await collection
                .Find(model => model.IsActive == true)
                .SortBy(model => model.Position)
                .ToCursorAsync();
            while (await cursor.MoveNextAsync())
            {
                foreach (var doc in cursor.Current)
                {
                    if (doc.Name == null) continue;

                    // Debug.WriteLine(doc.Name);
                    var btn = new Button() { 
                        Text = doc.Name,
                        Height = 60,
                        Width = 120,
                        BackColor = Color.CadetBlue,
                        ForeColor = Color.White
                    };
                    btn.Click += HandleMenuCategoryButtonClick;
                    pnlMenuTypes.Controls.Add(btn);
                }
            }
        }

        private void HandleMenuCategoryButtonClick(object? sender, EventArgs e)
        {
            //TODO: Handle Menu Load Based on Category Name
        }

        private void clockTick(object? stateInfo)
        {
            strpBottomTimestamp.Text = DateTime.Now.ToString("T");
        }
    }
}