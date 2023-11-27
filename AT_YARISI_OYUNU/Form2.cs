using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT_YARISI_OYUNU
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Random rnd_201104112 = new Random();//Random sayi uretmesi icin random sinifindan deger atadim
        

        


       

        private void Form2_Load(object sender, EventArgs e)
        {

            if (Form1.gonderilceksayi_201104112 == 2)//Form1 den 2 degeri girildi ise form2 de 2 tane at resmi ve 2 buton yukluyor diger 3 ve 4 uncu resmi ve butonlari gizliyor
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
               
            
             
                this.label5.Width = 56;//2 tane at uretecegi icin bitis cizgisinin onlara gore ayarlanmasi icin
                this.label5.Height = 291;//2 tane at uretecegi icin bitis cizgisinin onlara gore ayarlanmasi icin




            }
            if (Form1.gonderilceksayi_201104112 == 3)//Form1 den 3 degeri girildi ise form2 de 3 tane at resmi ve 3 buton yukluyor diger 4 uncu resmi ve butonu gizliyor
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                button6.Visible = false;

                this.label5.Width = 56;//3 tane at uretecegi icin bitis cizgisinin onlara gore ayarlanmasi icin
                this.label5.Height = 418;//3 tane at uretecegi icin bitis cizgisinin onlara gore ayarlanmasi icin


            }
            if (Form1.gonderilceksayi_201104112 == 4)//Form1 den 4 degeri girildi ise form2 de 4 tane at resmi ve 4 buton yukluyor 
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                this.label5.Width = 56;//4 tane at uretecegi icin bitis cizgisinin onlara gore ayarlanmasi icin
                this.label5.Height =548;//4 tane at uretecegi icin bitis cizgisinin onlara gore ayarlanmasi icin

            }

            //Basla butonuna basmadan oyuna baslamamasi icin form yuklendiginde butonlari devre disi biraktim 
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;







        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Basla butonuna bastiginda 1.at icin butonu aktif hale getirdim
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button1.Enabled = false;//Kullanici oyun basladiginda tekrardan basla butonuna basip oyuncu1 e tekrardan sira gecmemesi icin basla butonunu devre disi biraktim

        }

        private void button3_Click(object sender, EventArgs e)
        {

            int rasgele1_201104112 = rnd_201104112.Next(50,111);//Random sayi uretmesi icin random sinifindaki degeri bir int degiskenine atadim ve randomu 50 ile 100 degerinde yaptim
            pictureBox1.Left += rasgele1_201104112;//Resmin hareket etmesi icin rasgele uretilen sayiyi resmin soluna ekliyor

            if (Form1.gonderilceksayi_201104112 == 2)//Eger kullanici 2 tane at istemis ise oyuncu1 oynadigi zaman oyuncu2 nin butonu aktif hale gelicek
            {
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            if (Form1.gonderilceksayi_201104112 == 3)//Eger kullanici 3 tane at istemis ise oyuncu1 oynadigi zaman oyuncu2 nin butonu aktif hale gelicek
            {
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            if (Form1.gonderilceksayi_201104112 == 4)//Eger kullanici 4 tane at istemis ise oyuncu1 oynadigi zaman oyuncu2 nin butonu aktif hale gelicek
            {
                button3.Enabled = false;
                button4.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
            }
           

            if (pictureBox1.Right>label5.Left)//Oyuncu1 in ati bitis cizgisine geldiginde oyunu oyuncu1 kazanicak ve diger oyuncu butonlari ve basla butonunu devre disi birakacak sadece sifirla butonu aktif olucak ve basildiginda oyun tekrar baslicak
            {
                MessageBox.Show("1.Oyuncu Oyunu Kazanmistir","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rasgele2_201104112 = rnd_201104112.Next(50,111);//Random sayi uretmesi icin random sinifindaki degeri bir int degiskenine atadim ve randomu 50 ile 100 degerinde yaptim
            pictureBox2.Left += rasgele2_201104112;//Resmin hareket etmesi icin rasgele uretilen sayiyi resmin soluna ekliyor
            if (Form1.gonderilceksayi_201104112 == 2)//Eger kullanici 2 tane at degeri girdi ise 3.oyuncuya gecmemesi icin tekrardan 1.oyuncunun butonu aktif oluyor
            {
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            if (Form1.gonderilceksayi_201104112 == 3)//Eger kullanici 3 tane at degeri girdi ise oyuncu 3 un butonu aktif oluyor
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
            }
            if (Form1.gonderilceksayi_201104112 == 4)//Eger kullanici 4 tane at degeri girdi ise oyuncu 3 un butonu aktif oluyor
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = false;
            }



            if (pictureBox2.Right > label5.Left)//Oyuncu2 in ati bitis cizgisine geldiginde oyunu oyuncu2 kazanicak ve diger oyuncu butonlari ve basla butonunu devre disi birakacak sadece sifirla butonu aktif olucak ve basildiginda oyun tekrar baslicak
            {
                MessageBox.Show("2.Oyuncu Oyunu Kazanmistir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rasgele3_201104112 = rnd_201104112.Next(50, 111);//Random sayi uretmesi icin random sinifindaki degeri bir int degiskenine atadim ve randomu 50 ile 100 degerinde yaptim
            pictureBox3.Left += rasgele3_201104112;//Resmin hareket etmesi icin rasgele uretilen sayiyi resmin soluna ekliyor
           
            if (Form1.gonderilceksayi_201104112 == 3)//Eger kullanici 3 tane at degeri girdiyse oyuncu4 e gecmemesi icin tekrardan oyuncu1 e geciyor
            {
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            if (Form1.gonderilceksayi_201104112 == 4)//Eger kullanici 4 tane at degeri girdiyse oyuncu4 un butonu aktif oluyor
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = true;
            }



            if (pictureBox3.Right > label5.Left)//Oyuncu3 in ati bitis cizgisine geldiginde oyunu oyuncu3 kazanicak ve diger oyuncu butonlari ve basla butonunu devre disi birakacak sadece sifirla butonu aktif olucak ve basildiginda oyun tekrar baslicak
            {
                MessageBox.Show("3.Oyuncu Oyunu Kazanmistir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rasgele4_201104112 = rnd_201104112.Next(50, 111);//Random sayi uretmesi icin random sinifindaki degeri bir int degiskenine atadim ve randomu 50 ile 100 degerinde yaptim
            pictureBox4.Left += rasgele4_201104112;//Resmin hareket etmesi icin rasgele uretilen sayiyi resmin soluna ekliyor


            if (Form1.gonderilceksayi_201104112 == 4)//Eger kullanici 4 tane at degeri girdiyse tekrardan oyuncu1 in butonu aktif oluyor
            {
                button3.Enabled = true;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }


            if (pictureBox4.Right > label5.Left)//Oyuncu4 in ati bitis cizgisine geldiginde oyunu oyuncu4 kazanicak ve diger oyuncu butonlari ve basla butonunu devre disi birakacak sadece sifirla butonu aktif olucak ve basildiginda oyun tekrar baslicak
            {
                MessageBox.Show("4.Oyuncu Oyunu Kazanmistir", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();//Form2 yi temizler ve ilk bastaki durumuna alir
            this.InitializeComponent();
            if (Form1.gonderilceksayi_201104112 == 2)//Eger kullanici 2 degerini girdi ise sifirla butonuna bastiginda tekrardan 2 tane at gosterir digerlerini gizler
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                this.label5.Width = 56;
                this.label5.Height = 291;




            }
            if (Form1.gonderilceksayi_201104112 == 3)//Eger kullanici 3 degerini girdi ise sifirla butonuna bastiginda tekrardan 3 tane at gosterir digerini gizler
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = false;
                button6.Visible = false;
                this.label5.Width = 56;
                this.label5.Height = 418;


            }
            if (Form1.gonderilceksayi_201104112 == 4)//Eger kullanici 4 degerini girer ise sifirla butonuna bastiginda tekrardan 4 tane at gosterir
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                this.label5.Width = 56;
                this.label5.Height = 548;

            }

            //Kullanici sifirla butonuna bastiginda kullanici tekrardan basla butonuna basmadan oyunu baslatmamasi icin butonlari devre disi biraktim#
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;




        }
    }
}
