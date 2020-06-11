using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CockTailManager
{
    public partial class CocktailInfo : Form
    {
        public CocktailInfo()
        {
            InitializeComponent();

            btnSave.Visible = true;
            btnUpdate.Visible = false;
        }
        public CocktailInfo(CocktailDTO cocktail)
        {
            InitializeComponent();

            tbName.Text = cocktail.name;
            tbAlcohol.Text = cocktail.alcohol.ToString();
            tbBaseLiquor.Text = cocktail.baseLiquor;
            tbMaterial.Text = cocktail.material;
            tbRecipe.Text = cocktail.recipe;

            btnSave.Visible = false;
            btnUpdate.Visible = true;
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
            CocktailDAO cocktailDAO = new CocktailDAO();
            CocktailDTO cocktail = SetDTO();

            bool isSuccess = cocktailDAO.InsertData(cocktail);

            if(isSuccess)
            {
                this.Dispose();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            tbName.Text = "";
            tbAlcohol.Text = "";
            tbBaseLiquor.Text = "";
            tbMaterial.Text = "";
            tbRecipe.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CocktailDAO cocktailDAO = new CocktailDAO();
            CocktailDTO cocktail = SetDTO();

            bool isSuccess = cocktailDAO.UpdateData(cocktail);

            if (isSuccess)
            {
                this.Dispose();
            }
        }

        private CocktailDTO SetDTO()
        {
            CocktailDTO cocktail = new CocktailDTO();

            cocktail.name = tbName.Text;
            cocktail.alcohol = int.Parse(tbAlcohol.Text);
            cocktail.baseLiquor = tbBaseLiquor.Text;
            cocktail.material = tbMaterial.Text;
            cocktail.recipe = tbRecipe.Text;

            return cocktail;
        }
    }
}
