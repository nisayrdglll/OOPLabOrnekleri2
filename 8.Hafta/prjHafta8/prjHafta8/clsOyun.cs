using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjHafta8
{
    public static class clsOyun
    {
        static List<ucntrlKart> kartlar = new List<ucntrlKart>();
        static int _iSatirKartSayisi;
        static int _iSutunKartSayisi;

        public static void OyunKur(int iSatirKartSayisi, int iSutunKartSayisi, Panel pnl)
        {
            int iSayac, iSatir = 0, iSutun = 0, iX = 0, iY = 0, iResimIndex = 0, iAyniResimSayisi = 0;
            string sAcikResim = "", sKapaliResim = "kapali.png";
            ucntrlKart kart;
            List<string> lDosyalar = new List<string>();
            Random rnd = new Random();
            _iSatirKartSayisi = iSatirKartSayisi;
            _iSutunKartSayisi = iSutunKartSayisi;

            OyunuTemizle();

            lDosyalar = Directory.GetFiles("kartlar").ToList<string>();

            for (iSatir = 0; iSatir < _iSatirKartSayisi; iSatir++)
            {
                for (iSutun = 0; iSutun < _iSutunKartSayisi; iSutun++)
                {
                    iAyniResimSayisi = 2;
                    while (iAyniResimSayisi == 2)
                    {
                        iResimIndex = rnd.Next(_iSatirKartSayisi * _iSutunKartSayisi / 2);
                        iAyniResimSayisi = 0;
                        for (iSayac = 0; iSayac < kartlar.Count; iSayac++)
                        {
                            if (kartlar[iSayac].sAcikResim == lDosyalar[iResimIndex])
                            {
                                iAyniResimSayisi++;
                                if (iAyniResimSayisi == 2)
                                {
                                    break;
                                }
                            }
                        }
                    }

                    sAcikResim = lDosyalar[iResimIndex];
                    kart = new ucntrlKart();
                    iX = iSutun * (kart.Width + 20);
                    iY = iSatir * (kart.Height + 20);

                    kart.Ayarla(iX, iY, sAcikResim, sKapaliResim);
                    kartlar.Add(kart);
                    pnl.Controls.Add(kart);
                }
            }
        }

        public static void OyunuTemizle()
        {
            int iSayac = 0;
            for (iSayac = 0; iSayac < kartlar.Count; iSayac++)
            {
                kartlar[iSayac].Dispose();
                kartlar[iSayac] = null;
            }
            kartlar.Clear();
        }

        public static void KontrolEt()
        {
            bool bResimKaldiMi = false;
            ucntrlKart kart1 = null, kart2 = null;
            foreach (ucntrlKart kart in kartlar)
            {
                if (kart.bAcikMi && kart.Visible)
                {
                    if (kart1 == null)
                        kart1 = kart;
                    else
                        kart2 = kart;
                }
            }

            if(
                 kart1!=null 
                 && kart2!=null 
                 )
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                if (kart1.sAcikResim == kart2.sAcikResim)
                {
                    kart1.Visible = false;
                    kart2.Visible = false;
                }
                else
                {
                    kart1.ResmiKapat();
                    kart2.ResmiKapat();
                }
            }

            foreach (ucntrlKart kart in kartlar)
            {
                if (kart.Visible)
                {
                    bResimKaldiMi = true;
                    break;
                }
            }

            if(!bResimKaldiMi)
            {
                MessageBox.Show("Tebrikler oyunu tamamladınız :)");
            }
        }
    }
}