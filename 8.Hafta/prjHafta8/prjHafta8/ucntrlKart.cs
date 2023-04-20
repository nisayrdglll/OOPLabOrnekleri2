using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta8
{
    public partial class ucntrlKart : UserControl
    {
        public ucntrlKart()
        {
            InitializeComponent();
        }

        string _sAcikResim = "";
        string _sKapaliResim = "";
        bool _bAcikMi;

        public string sAcikResim
        {
            get
            {
                return _sAcikResim;
            }
        }

        public bool bAcikMi
        {
            get
            {
                return _bAcikMi;
            }
        }

        public void Ayarla(int iX, int iY, string sAcikResim, string sKapaliResim)
        {
            this.Location=new Point(iX,iY);
            this._sAcikResim = sAcikResim;
            this._sKapaliResim = sKapaliResim;
            this._bAcikMi = false;
            lblResim.Image = Image.FromFile(this._sKapaliResim);
        }
        
        private void lblResim_Click(object sender, EventArgs e)
        {
            this._bAcikMi = true;
            lblResim.Image = Image.FromFile(_sAcikResim);
            clsOyun.KontrolEt();
        }

        public void ResmiKapat()
        {
            this._bAcikMi = false;
            lblResim.Image = Image.FromFile(_sKapaliResim);
        }
    }
}
