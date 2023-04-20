using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
public class clsYayinAkisi
{
    List<clsYayin> lYayinlar = new List<clsYayin>();

    public clsYayinAkisi()
    {

    }

    public void Oku()
    {
        int iNo;
        string sSaati;
        string sResimYolu;
        string sProgramAdi;
        string sProgramTuru;
        string sKlasorYolu = "yayinakisi\\";
        string[] sDosyalar;
        string[] sDosyaBilgileri;
        clsYayin yayin;
        sDosyalar = Directory.GetFiles(sKlasorYolu);
        foreach (string sDosya in sDosyalar)
        {
            sDosyaBilgileri = sDosya.Replace(sKlasorYolu,"").Split('-');
            if (sDosyaBilgileri.Length < 4)
                continue;
            iNo = int.Parse(sDosyaBilgileri[0]);
            sSaati = sDosyaBilgileri[1].Replace("_", ":");
            sResimYolu = sDosya;
            sProgramAdi = sDosyaBilgileri[2];
            sProgramTuru = sDosyaBilgileri[3].Substring(0, sDosyaBilgileri[3].IndexOf("."));

            yayin = new clsYayin(iNo, sSaati, sResimYolu, sProgramAdi, sProgramTuru);
            lYayinlar.Add(yayin);
        }
    }

    public void Yazdir(Form frm)
    {
        Label lblSaati, lblProgramAdi, lblProgramTuru;
        PictureBox pbResim;
        foreach (clsYayin yayin in lYayinlar)
        {
            lblSaati = new Label();
            lblProgramAdi = new Label();
            lblProgramTuru = new Label();
            pbResim = new PictureBox();
            lblSaati.Text = yayin.sSaati;
            lblSaati.AutoSize = false;
            lblSaati.Width = 50;
            lblSaati.Height = 100;
            lblSaati.Location = new Point(30, 30 + (lblSaati.Height + 20) * (yayin.iNo - 1));

            pbResim.ImageLocation = yayin.sResimYolu;
            pbResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pbResim.Width = 200;
            pbResim.Height = 100;
            pbResim.Location = new Point(lblSaati.Location.X + lblSaati.Width+10 , lblSaati.Location.Y);

            lblProgramAdi.Text = yayin.sProgramAdi;
            lblProgramAdi.AutoSize = false;
            lblProgramAdi.Width = 100;
            lblProgramAdi.Height = 100;
            lblProgramAdi.Location = new Point(pbResim.Location.X + pbResim.Width + 10, lblSaati.Location.Y);

            lblProgramTuru.Text = yayin.sProgramTuru;
            lblProgramTuru.AutoSize = false;
            lblProgramTuru.Width = 100;
            lblProgramTuru.Height = 100;
            lblProgramTuru.Location = new Point(lblProgramAdi.Location.X + lblProgramAdi.Width + 10, lblSaati.Location.Y);
            
            frm.Controls.Add(lblSaati);
            frm.Controls.Add(lblProgramAdi);
            frm.Controls.Add(lblProgramTuru);
            frm.Controls.Add(pbResim);
        }
    }
}
