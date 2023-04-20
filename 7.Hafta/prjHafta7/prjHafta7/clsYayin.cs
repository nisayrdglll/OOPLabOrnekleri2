 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsYayin
{
    int _iNo;
    string _sSaati;
    string _sResimYolu;
    string _sProgramAdi;
    string _sProgramTuru;

    public clsYayin(int iNo, string sSaati, string sResimYolu, string sProgramAdi, string sProgramTuru)
    {
        this._iNo = iNo;
        this._sSaati = sSaati;
        this._sResimYolu = sResimYolu;
        this._sProgramAdi = sProgramAdi;
        this._sProgramTuru = sProgramTuru;
    }

    public int iNo
    {
        get
        {
            return _iNo;
        }
    }

    public string sSaati
    {
        get
        {
            return _sSaati;
        }
    }

    public string sResimYolu
    {
        get
        {
            return _sResimYolu;
        }
    }

    public string sProgramAdi
    {
        get
        {
            return _sProgramAdi;
        }
    }

    public string sProgramTuru
    {
        get
        {
            return _sProgramTuru;
        }
    }
}
