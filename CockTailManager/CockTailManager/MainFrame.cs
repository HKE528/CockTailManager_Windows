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
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {

        }
    }
}
