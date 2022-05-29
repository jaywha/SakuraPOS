using MongoDB.Bson;
using MongoDB.Driver;
using SakuraPOS.Models;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Text;
using WinForms = System.Windows.Forms;
using LinqExp = System.Linq.Expressions;

namespace SakuraPOS
{
    public partial class frmMain : Form
    {
        private readonly System.Threading.Timer clock;
        private readonly string pwd;
        private readonly MongoClient DBClient;

        private const int MenuButtonHeight = 60;
        private const int MenuButtonWidth = 120;
        private const string MongoDBName = "Sakura-POS-DB";
        private const string QueryParms = "authSource=admin&replicaSet=atlas-ehyha0-shard-0&readPreference=primary&ssl=true";

        public frmMain()
        {
            InitializeComponent();
            clock = new(clockTick, new AutoResetEvent(false), 0, 1000);
            pwd = Encoding.UTF8.GetString(Convert.FromBase64String("Z3Jvb3Z5NGFsbA=="));
            DBClient = new MongoClient($"mongodb+srv://gcadmin:{pwd}@rhythm-gnome-db.5tddy.mongodb.net/test?{QueryParms}");
        }

        private async void connectToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDBItems<POSMenuCategoryModel>(
                "menu_categories",
                model => model.IsActive == true,
                model => model.Position,
                Color.CadetBlue,
                Color.White,
                HandleMenuCategoryButtonClick,
                pnlMenuTypes
            );
        }

        private void HandleMenuCategoryButtonClick(object? sender, EventArgs e)
        {
            GetDBItems<POSMenuFoodItemModel>(
                "menu_foodItems",
                model => model.IsActive == true && model.Category == (sender as Button).Text,
                model => model.Position,
                Color.LightGray,
                Color.Black,
                HanldeMenuFoodItemButtonClick,
                pnlMenuItems
            );
        }

        private void HanldeMenuFoodItemButtonClick(object? sender, EventArgs e)
        {
            // TODO: Add Food Items to a list on the far right
        }

        private async void GetDBItems<T>(string collectionName,
            LinqExp.Expression<Func<T, bool>> findExpression,
            LinqExp.Expression<Func<T, object>> sortByExpression,
            Color menutItemBackColor,
            Color menutItemForeColor,
            EventHandler menuItemClickHandler,
            FlowLayoutPanel targetPanel) {
            if (DBClient == null)
            {
                MessageBox.Show("Database Client Not Initialized!");
                throw new MongoConnectionException(null, "Couldn't connect to rhythm-gnome-db data server!");
            }

            targetPanel.Controls.Clear();

            // Replace the uri string with your MongoDB deployment's connection string.
            var database = DBClient.GetDatabase(MongoDBName);
            var collection = database.GetCollection<T>(collectionName);

            using var cursor = await collection
                .Find(findExpression)
                .SortBy(sortByExpression)
                .ToCursorAsync();
            while (await cursor.MoveNextAsync())
            {
                if (cursor.Current == null) continue;

                foreach (dynamic doc in cursor.Current)
                {
                    if (doc.Name == null) continue;

                    // Debug.WriteLine(doc.Name);
                    var btn = new Button()
                    {
                        Text = doc.Name,
                        Height = MenuButtonHeight,
                        Width = MenuButtonWidth,
                        BackColor = menutItemBackColor,
                        ForeColor = menutItemForeColor
                    };
                    btn.Click += menuItemClickHandler;
                    targetPanel.Controls.Add(btn);
                }
            }
        }

        private void clockTick(object? stateInfo)
        {
            strpBottomTimestamp.Text = DateTime.Now.ToString("T");
        }
    }
}