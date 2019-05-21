using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Projet_Recettes
{
    public partial class frmCommentaires : Form
    {
        Bitmap bitmapBtnDisabled = new Bitmap(new Bitmap(@"../../../Images/Etoile_Blanche.png"), new Size(30, 30));
        Bitmap bitmapBtnEnabled = new Bitmap(new Bitmap(@"../../../Images/Etoile_Jaune.png"), new Size(30, 30));
        public frmCommentaires()
        {
            InitializeComponent();
        }

        private void btnNote1_Click(object sender, EventArgs e)
        {
            switch (this.Tag.ToString())
            {
                case "1":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnDisabled;
                    btnNote3.BackgroundImage = bitmapBtnDisabled;
                    btnNote4.BackgroundImage = bitmapBtnDisabled;
                    break;
                case "2":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnEnabled;
                    btnNote3.BackgroundImage = bitmapBtnDisabled;
                    btnNote4.BackgroundImage = bitmapBtnDisabled;
                    break;
                case "3":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnEnabled;
                    btnNote3.BackgroundImage = bitmapBtnEnabled;
                    btnNote4.BackgroundImage = bitmapBtnDisabled;
                    break;
                case "4":
                    btnNote1.BackgroundImage = bitmapBtnEnabled;
                    btnNote2.BackgroundImage = bitmapBtnEnabled;
                    btnNote3.BackgroundImage = bitmapBtnEnabled;
                    btnNote4.BackgroundImage = bitmapBtnEnabled;
                    break;
            }
        }

        private void frmCommentaires_Load(object sender, EventArgs e) {
            btnNote1.BackgroundImage = bitmapBtnEnabled;
            btnNote2.BackgroundImage = bitmapBtnDisabled;
            btnNote3.BackgroundImage = bitmapBtnDisabled;
            btnNote4.BackgroundImage = bitmapBtnDisabled;
        }
    }
}
