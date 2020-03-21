/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI:
** ÖĞRENCİ ADI: Ali Alper Doğan
** ÖĞRENCİ NUMARASI: B191200051
** DERSİN ALINDIĞI GRUP: A
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ali_Alper_Doğan
{
     
    public partial class Form1 : Form
    {
        //buton basımından etkilenmemeleri için stok ve kasa değişkenlerini giriyorum.
        // ) her buton basımında kasa 0 olma durumu )
        int kasa = 0;
        int formasayac = 0;
        int biletsayac = 0;
        int formatoplam = 10000;
        int bilettoplam = 20000;
       
        void Hesapla()                              //bir hesapla fonksiyonu oluşturuyorum.
        {

            if (TxtForma.Text == string.Empty)          //deger girilmediginde hata vermemesi icin sting.empty kullanıyorum ve message box ile uyarı yolluyorum.
            {
                MessageBox.Show("Adet girmediniz");
                MessageBox.Show("Bilet Siparisiniz Alindi");
            }
            else
            {
                forma = Convert.ToInt32(TxtForma.Text);
            }

            //Kaç Forma Satildi ögrenmek icin sayac kullaniyorum.

            formasayac = formasayac + forma;

            lbnsatılanformasayısı.Text = formasayac.ToString();

            formatoplam = formatoplam - forma;
            // stoğumda kaç formam kaldığını belirlemek için toplam formamdan girilen forma sayısını her buton basımında çıkartıyorum.
            lbnkalanforma.Text = formatoplam.ToString();
            // kasa hesabımı yapıyorum.  

            kasa = kasa + forma * 54;

            lbnkasa.Text = kasa.ToString() + " tl";

            bilettoplam = bilettoplam - bilet;
            //kalan bilet sayımı hesaplatıp yazdırıyorum.                             
            lbnkalanbilet.Text = bilettoplam.ToString();
            //kaç bilet sattığımı da ayrı değişkenler kullanarak bu kısımda hesaplıyorum. 
            
            int kategori = 1;

            // kategorıtext boxundan aldığım değer doğrultusunda bir ıf else koşulu kurdum 
            // 1. kategori kale arkası 2. kategori maraton 3. kategori numaralı olmak üzere 3 koşul var.
            if (kategori == 1)
            {

                if (TxtBilet.Text == string.Empty)
                {
                    MessageBox.Show("Adet girmediniz");
                    MessageBox.Show("Forma Siparisiniz Alindi");

                }
                else
                {
                    bilet = Convert.ToInt32(TxtBilet.Text);
                }

                kasa = kasa + bilet * 10;                   // kasaya eklenicek tutar bilet kategorilerine göre degisiklik gösteriyor.
                lbnkasa.Text = kasa.ToString() + " tl";
                label10.Text = ((forma * 54) + (bilet * 10)).ToString(); //label10 --> fiyat tutarı icin atadıgım label.

            }

            if (kategori == 2)
            {
                if (TxtBilet.Text == string.Empty)
                {
                    MessageBox.Show("Adet girmediniz");
                    MessageBox.Show("Forma Siparisiniz Alindi");
                }
                else
                {
                    bilet = Convert.ToInt32(TxtBilet.Text);
                }
                kasa = kasa + bilet * 20;
                lbnkasa.Text = kasa.ToString() + " tl";
                label10.Text = ((forma * 54) + (bilet * 20)).ToString();
            }

            if (kategori == 3)
            {
                if (TxtBilet.Text == string.Empty)
                {
                    MessageBox.Show("Adet girmediniz");
                    MessageBox.Show("Forma Siparisiniz Alindi");
                }
                else
                {
                    bilet = Convert.ToInt32(TxtBilet.Text);
                }
                kasa = kasa + bilet * 30;
                lbnkasa.Text = kasa.ToString() + " tl";
                label10.Text = ((forma * 54) + (bilet * 30)).ToString();
            }

            else
            {

            }
            biletsayac = biletsayac + bilet; // biletsayacımı da burdan ögreniyorum .

            lbnsatılanbiletsayısı.Text = biletsayac.ToString();

        }
        public int forma;
        public int bilet;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void lbntoplamkâr_Click(object sender, EventArgs e)
        {
            // BU KISIMLARI SİLDİĞİMDE HATA VERİYOR BİR ETKİSİ YOK SİLMEDİM .
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboSecim.Text == "Her Ikisi")                 // deger girilmediginde hata vermemesi ıcın byle bir cözüm buldum.
            {                                                   // satın alım seklini sectirip islemleri ona göre gerceklestirdim
                Hesapla();
            }
            if (comboSecim.Text=="Sadece Forma")
            {
                TxtBilet.Text = "0";
                Hesapla();
            }
            if (comboSecim.Text=="Sadece Bilet")
            {
                TxtForma.Text = "0";
                Hesapla();
            }
        }

    }
}

