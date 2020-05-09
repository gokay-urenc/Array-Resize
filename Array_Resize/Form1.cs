using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Resize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[4];
            sayilar[0] = 3;
            sayilar[1] = 5;
            sayilar[2] = 10;
            sayilar[3] = 20;
            // sayilar[4] = 60; // Hatalı atamadır. Dizinin boyutundan fazladır.
            Array.Resize(ref sayilar, 2);
            Array.Resize(ref sayilar, 5);
        }

        int[] dinamik_dizi = new int[0];
        private void button2_Click(object sender, EventArgs e)
        {
            int eleman_sayisi = dinamik_dizi.Length;
            eleman_sayisi++;
            Array.Resize(ref dinamik_dizi, eleman_sayisi);
         // Array.Resize(ref dinamik_dizi, dinamik_dizi.Lenght + 1); // Böyle            kullanırsak 35. ve 36. satırdaki kodlara gerek kalmaz.
        }
    }
}
// Resize => Referans olarak gönderilen dizinin uzunluğunu değiştirir. Dizi tanımında    uzunluğun belirtilmesi gerektiği için problem çıkabilir. 10 elemanlı bir sayı         dizisine 11 eleman eklenemez. İlk parametre ref anahtar kelimesiyle gönderilecek      dizidir. İkinci parametre dizinin yeni boyutudur.


// 2 Label, 2 TextBox, 1 ListBox ve 1 Button olacak. Butonun texti Kişiyi Kaydet olacak. Labeller; ad ve soyad olacak. Bir iş yerine kayıt ve danışma için gelen kişilerin ad  ve soyad bilgilerini tutan program yazılacak. Listbox'ta adını ve soyadını            gösterecek. Günlük gelen kişi sayısı belli değildir. Kullanıcı bilgilerini ister ayrı dizilerde ister tek bir dizide yapılabilir.