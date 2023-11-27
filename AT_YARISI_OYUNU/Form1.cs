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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public int gonderilceksayi_201104112;//Form2 ye deger gondermek icin burada public bir degisken tanimladim

        private void button1_Click(object sender, EventArgs e)
        {
            int oyuncusayisi_201104112;//Girilen oyuncu sayisini belirlemek icin degisken tanimladim
            Form2 yaris_201104112 = new Form2();//Form2 yi tanimladim
           
           
            try
            {
                oyuncusayisi_201104112 = Convert.ToInt32(textBox1.Text);
                if (oyuncusayisi_201104112 == 2)
                {
                    gonderilceksayi_201104112 = oyuncusayisi_201104112;//Girilen oyuncu sayisi 2 ise form2 2 degerini gonderiyor
                    this.Hide();//Form1 kapatiyor
                    yaris_201104112.ShowDialog();//Form2 yi diolog kutusu olarak gosteriyor
                    this.Show();//Form2 yi gosteriyor
                   

                }
                    
                                                               
                
                else if (oyuncusayisi_201104112 == 3)
                {
                    gonderilceksayi_201104112 = oyuncusayisi_201104112;//Girilen oyuncu sayisi 3 ise form2 3 degerini gonderiyor
                    this.Hide();//Form1 kapatiyor
                    yaris_201104112.ShowDialog();//Form2 yi diolog kutusu olarak gosteriyor
                    this.Show();//Form2 yi gosteriyor

                }
               else if (oyuncusayisi_201104112 == 4)
                {
                    gonderilceksayi_201104112 = oyuncusayisi_201104112;//Girilen oyuncu sayisi 4 ise form2 4 degerini gonderiyor
                    this.Hide();//Form1 kapatiyor
                    yaris_201104112.ShowDialog();//Form2 yi diolog kutusu olarak gosteriyor
                    this.Show();//Form2 yi gosteriyor

                }
                else
                {

                    MessageBox.Show("En Az 2 En Fazla 4 Oyuncu Giriniz","HATA!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);//Eger kullanici 2 ile 4 arasinda bir deger girmez ise hata kodu

                }

            }
            
            catch (Exception)
            {
               
                MessageBox.Show("Oyuncu Sayisi Girmediniz","HATA!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);//Eger kullanici deger girmez ise hata kodu
            }

          
            
          

        }
    }
}
