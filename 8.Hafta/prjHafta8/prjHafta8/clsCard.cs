using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public class clsCard
{
    int _iX;
    int _iY;
    string _sAcikResim = "";
    string _sKapaliResim = "";
    bool _bAcikMi;
    Label _lblResim;

    public clsCard(int iX, int iY, string sAcikResim,string sKapaliResim)
    {
        this._iX = iX;
        this._iY = iY;
        this._sAcikResim = sAcikResim;
        this._sKapaliResim = sKapaliResim;
        _lblResim = new Label();
        _lblResim.Image = Image.FromFile(_sKapaliResim);
        this._bAcikMi = false;
    }

    public void AcKapat()
    {
        this._bAcikMi = this._bAcikMi ? false : true;
        _lblResim.Image = Image.FromFile(this._bAcikMi ? _sAcikResim : _sKapaliResim);
    }
}