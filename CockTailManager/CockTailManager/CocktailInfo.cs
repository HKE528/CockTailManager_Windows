using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Authentication;

namespace CockTailManager
{
    public partial class CocktailInfo : Form
    {
        public CocktailInfo()
        {
            InitializeComponent();
        }

        ~CocktailInfo()
        {
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CocktailDTO cocktail = new CocktailDTO();
            CocktailDAO cocktailDAO = new CocktailDAO();

            cocktail.name = tbName.Text;
            cocktail.alcohol = int.Parse(tbAlcohol.Text);
            cocktail.baseLiquor = tbBaseLiquor.Text;
            cocktail.material = tbMaterial.Text;
            cocktail.recipe = tbRecipe.Text;

            bool isSuccess = cocktailDAO.InsertData(cocktail);

            if(isSuccess)
            {
                this.Dispose();
            }
        }
    }
}
