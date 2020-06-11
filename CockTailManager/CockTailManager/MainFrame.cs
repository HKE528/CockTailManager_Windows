using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CockTailManager
{
    public partial class MainFrame : Form
    {
        List<CocktailDTO> cocktails;
        CocktailDAO cocktailDAO;

        public MainFrame()
        {
            InitializeComponent();

            cocktailDAO = new CocktailDAO();

            InitDateGridView();
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            CocktailInfo info = new CocktailInfo();

            info.btnSave.Click += new EventHandler(RefreshDGV);
            info.StartPosition = FormStartPosition.Manual;
            info.Location = new Point(this.Location.X + 30, this.Location.Y + 30);

            info.Show();
        }

        private void RefreshDGV(object sender, EventArgs e)
        {
            InitDateGridView();
        }
        private void cockTailDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CocktailDTO cocktail = new CocktailDTO();
            string name = cockTailDGV.SelectedCells[0].Value.ToString();
            cocktail.name = name;
            cocktail = cocktailDAO.SelectData(cocktail);

            CocktailInfo info = new CocktailInfo(cocktail);

            info.btnSave.Click += new EventHandler(RefreshDGV);
            info.StartPosition = FormStartPosition.Manual;
            info.Location = new Point(this.Location.X + 30, this.Location.Y + 30);

            info.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string name = cockTailDGV.SelectedCells[0].Value.ToString();

            if (name != "")
            {
                CocktailDTO cocktail = new CocktailDTO();
                cocktail.name = name;

                DialogResult result = MessageBox.Show(this, "정말로 삭제하겠습니까?", "", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    cocktailDAO.DeleteData(cocktail);

                    RefreshDGV(this, EventArgs.Empty);
                }
            }
        }
        private void InitDateGridView()
        {
            cocktails = cocktailDAO.GetCocktails();

            cockTailDGV.Rows.Clear();
            if (cocktails.Count != 0)
            {
                foreach (var cocktail in cocktails)
                {
                    cockTailDGV.Rows.Add(cocktail.name, cocktail.alcohol, cocktail.baseLiquor);
                }
            }
        }


    }
}
