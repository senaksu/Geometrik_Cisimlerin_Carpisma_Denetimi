/**********************************************************************************************************************************
 ***
 ***
 ***                                                      SAKARYA ÜNİVERSİTESİ
 ***                                           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 ***                                                BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ 
 ***                                                  NESNEYE DAYALI PROGRAMLAMA DERSİ
 ***
 ***                                                     ÖDEV NUMARASI : 1
 ***                                                     ÖĞRENCİ NUMARASI :   B211210008
 ***                                                     ÖĞRENCİ ADI SOYADI : SENA AKSU
 ***                                                     DERS GRUBU :          2/B
 ***                                                     YOUTUBE LİNK :    https://www.youtube.com/watch?v=eVYm0HLrAi8
 ***
 ***
 ***
 ***
 ***
 ***
**************************************************************************************************************************************/



using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cisimcarpismadenetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Yazıyı ortalamak için TextAlign özelliğini kullanın
            textBox1.TextAlign = HorizontalAlignment.Center;

           
            int paddingValue = 10; // İstediğiniz boşluk değerini burada belirle
            textBox1.Multiline = true; // Çok satırlı modu etkinleştir
            textBox1.Height = (textBox1.Font.Height * 2) + (2 * paddingValue); // TextBox yüksekliğini ayarla
            textBox1.Margin = new Padding(paddingValue); // TextBox kenar boşluğunu ayarla

        }

        private bool button1Clicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1Clicked= true;
            panel1.Invalidate();
        }


        private bool button2Clicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2Clicked = true;
            panel1.Invalidate();

        }
        private bool button3Clicked = false;
        private void button3_Click(object sender, EventArgs e)
        {
            button3Clicked = true;
            panel1.Invalidate();

        }
        private bool button4Clicked = false;
        private void button4_Click(object sender, EventArgs e)
        {
            button4Clicked = true;
            panel1.Invalidate();

        }
        private bool button5Clicked = false;
        private void button5_Click(object sender, EventArgs e)
        {
            button5Clicked = true;
            panel1.Invalidate();
        }
        private bool button6Clicked = false;
        private void button6_Click(object sender, EventArgs e)
        {
            button6Clicked = true;
            panel1.Invalidate();
        }
        private bool button7Clicked = false;
        private void button7_Click(object sender, EventArgs e)
        {
            button7Clicked = true;
            panel1.Invalidate();
        }
        private bool button8Clicked = false;
        private void button8_Click(object sender, EventArgs e)
        {
            button8Clicked = true;
            panel1.Invalidate();
        }
        private bool button9Clicked = false;
        private void button9_Click(object sender, EventArgs e)
        {
            button9Clicked = true;
            panel1.Invalidate();
        }
        private bool button10Clicked = false;
        private void button10_Click(object sender, EventArgs e)
        {
            button10Clicked = true;
            panel1.Invalidate();
        }
        private bool button11Clicked = false;
        private void button11_Click(object sender, EventArgs e)
        {
            button11Clicked = true;
            panel1.Invalidate();
        }
        private bool button12Clicked = false;
        private void button12_Click(object sender, EventArgs e)
        {
            button12Clicked = true;
            panel1.Invalidate();
        }
        private bool button13Clicked = false;
        private void button13_Click(object sender, EventArgs e)
        {
            button13Clicked = true;
            panel1.Invalidate();
        }
        private bool button14Clicked = false;
        private void button14_Click(object sender, EventArgs e)
        {
            button14Clicked = true;
            panel1.Invalidate();
        }
        private bool button15Clicked = false;
        private void button15_Click(object sender, EventArgs e)
        {
            button15Clicked = true;
            panel1.Invalidate();
        }
        private bool button16Clicked = false;
        private void button16_Click(object sender, EventArgs e)
        {
            button16Clicked = true;
            panel1.Invalidate();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g= e.Graphics;
            // panelin ölçüleri
            int panelGenislik = panel1.Width;
            int panelYukseklik = panel1.Height;

            // Koordinat sistemini düzeltme
            g.ScaleTransform(panelGenislik / 100f, panelYukseklik / 100f);

            // düzgün çizim için
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if(button1Clicked)  // NOKTA DİKDORTGEN
            {
                textBox1.Clear();
                Brush fırca = new SolidBrush(Color.Red);

                Nokta n1 = new Nokta(15, 20);
                dikdortgen d1 = new dikdortgen(new Nokta(8,8), 13, 16);

                // Noktayı çizme
               
                Point noktaKonumu =new Point(n1.X, n1.Y);

                g.FillEllipse(fırca, noktaKonumu.X, noktaKonumu.Y, 1, 1);

                //dikdörtgen çizimi
                int dikdortgenX = d1.M.X;
                int dikdortgenY = d1.M.Y;
                int dikdortgenEn = d1.En;
                int dikdortgenBoy=d1.Boy;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.Blue, kalemgenislik);
                g.DrawRectangle(kalem, dikdortgenX, dikdortgenY, dikdortgenEn, dikdortgenBoy);

                if (carpisma.noktadikdortgencarpisma(n1, d1))
                {
                    textBox1.Text = " Nokta ve Dikdörtgen Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Nokta ve Dikdörtgen Çarpışmıyor.";
                }

                button1Clicked = false;
            }
            if (button2Clicked) // NOKTA CEMBER
            {
                textBox1.Clear();
                //NOKTA CİZİM
                Brush fırca = new SolidBrush(Color.Red);
                Nokta n1 = new Nokta(35, 45);
                Point noktaKonumu = new Point(n1.X, n1.Y);
                g.FillEllipse(fırca, noktaKonumu.X, noktaKonumu.Y, 1, 1);

                //CEMBER CİZİM
                cember c1 = new cember(new Nokta(15, 20), 10);
                Point cemberMerkezi = new Point(c1.M.X, c1.M.Y);
                int cemberYaricapi = c1.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.Blue, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi , cemberMerkezi.Y - cemberYaricapi, cemberCapi,cemberCapi);

                if (carpisma.noktacembercarpisma(n1, c1))
                {
                    textBox1.Text = " Nokta ve Çember Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Nokta ve Çember Çarpışmıyor.";
                }

                button2Clicked = false;

            }

            if (button3Clicked)  // DİKDORTGEN DİKDORTGEN
            {
                textBox1.Clear();
                dikdortgen d1 = new dikdortgen(new Nokta(15, 4), 23, 16);
                dikdortgen d2 = new dikdortgen(new Nokta(8, 9), 15, 17);

                //dikdörtgen çizimi
                int dikdortgenX = d1.M.X;
                int dikdortgenY = d1.M.Y;
                int dikdortgenEn = d1.En;
                int dikdortgenBoy = d1.Boy;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.Red, kalemgenislik);
                g.DrawRectangle(kalem, dikdortgenX, dikdortgenY, dikdortgenEn, dikdortgenBoy);


                //dikdörtgen çizimi
                int dikdortgen2X = d2.M.X;
                int dikdortgen2Y = d2.M.Y;
                int dikdortgen2En = d2.En;
                int dikdortgen2Boy = d2.Boy;
             
                Pen kalem2 = new Pen(Color.Blue, kalemgenislik);
                g.DrawRectangle(kalem2, dikdortgen2X, dikdortgen2Y, dikdortgen2En, dikdortgen2Boy);

                if (carpisma.dikdortgendikdortgencarpisma(d1, d2))
                {
                    textBox1.Text = " Dikdortgen ve Dikdortgen Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Dikdortgen ve  Dikdortgen Çarpışmıyor.";
                }
                button3Clicked = false;
            }

     
            if (button4Clicked)  //  DİKDORTGEN CEMBER
            {
                textBox1.Clear();
                dikdortgen d1 = new dikdortgen(new Nokta(15, 14), 23, 16);
                //dikdörtgen çizimi
                int dikdortgenX = d1.M.X;
                int dikdortgenY = d1.M.Y;
                int dikdortgenEn = d1.En;
                int dikdortgenBoy = d1.Boy;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.Red, kalemgenislik);
                g.DrawRectangle(kalem, dikdortgenX, dikdortgenY, dikdortgenEn, dikdortgenBoy);

                //CEMBER CİZİM
                cember c1 = new cember(new Nokta(15, 20), 10);
                Point cemberMerkezi = new Point(c1.M.X, c1.M.Y);
                int cemberYaricapi = c1.R;
                int cemberCapi = cemberYaricapi * 2;
                
                Pen kalem2 = new Pen(Color.Blue, kalemgenislik);
                g.DrawEllipse(kalem2, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                if (carpisma.dikdortgencembercarpisma(d1, c1))
                {
                    textBox1.Text = " Dikdortgen ve Çember Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Dikdortgen ve Çember Çarpışmıyor.";
                }

                button4Clicked = false;
            }

            if (button5Clicked) // CEMBER CEMBER 
            {
                textBox1.Clear();
                //Cember 1
                cember c1 = new cember(new Nokta(15, 20), 5);
                Point cemberMerkezi = new Point(c1.M.X, c1.M.Y);
                int cemberYaricapi = c1.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                //cember 2
                cember c2 = new cember(new Nokta(45, 10), 10);
                Point cemberMerkezi2 = new Point(c2.M.X, c2.M.Y);
                int cemberYaricapi2 = c2.R;
                int cemberCapi2 = cemberYaricapi * 2;

                Pen kalem2 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem2, cemberMerkezi2.X - cemberYaricapi2, cemberMerkezi2.Y - cemberYaricapi2, cemberCapi2, cemberCapi2);

                if (carpisma.cembercembercarpisma(c1, c2))
                {
                    textBox1.Text = " Çember ve Çember Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Çember ve Çember Çarpışmıyor.";
                }

                button5Clicked = false;
            }

            if (button6Clicked)   //NOKTA KÜRE
            {
                textBox1.Clear();
                //NOKTA CİZİM
                Brush fırca = new SolidBrush(Color.Red);
                Nokta3d n1 = new Nokta3d(35, 45,2);
                Point noktaKonumu = new Point(n1.X, n1.Y);
                g.FillEllipse(fırca, noktaKonumu.X, noktaKonumu.Y, 1, 1);


                //KÜRE CİZİM 
                kure k = new kure(new Nokta3d(20, 33, 5), 17);

                
                Point cemberMerkezi = new Point(k.M.X, k.M.Y);
                int cemberYaricapi = k.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                Pen kalem1 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem1, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                // elips ekvator cizgisi 
                int elipsYaricapX = cemberYaricapi;  //elipsinx eksenindeki yarıçpı
                int elipsYaricapY = cemberYaricapi / 2;  //elipsin y ekseni üzerindeki yarıçapı cemberin yarısı
                int elipsMerkeziX = cemberMerkezi.X;  // elipsin merkezi cemberin merkeziyle aynı x kordinatı
                int elipsMerkeziY = cemberMerkezi.Y;   // elipsin merkezi cemberin merkeziyle aynı y kordinatı
                Rectangle elipsRect = new Rectangle(elipsMerkeziX - elipsYaricapX, elipsMerkeziY - elipsYaricapY, elipsYaricapX * 2, elipsYaricapY * 2);
               
                g.DrawEllipse(kalem1, elipsRect);



                if (carpisma.noktakurecarpisma(n1, k))
                {
                    textBox1.Text = " Nokta ve Küre Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Nokta ve Küre Çarpışmıyor.";
                }
                button6Clicked = false;
            }

            if(button7Clicked) // NOKTA VE DİKDORTGEN PRİZMA
            {
                textBox1.Clear();

      
                  //NOKTA CİZİM
                Brush fırca = new SolidBrush(Color.Red);
                Nokta3d n1 = new Nokta3d(13, 12, 1);
                Point noktaKonumu = new Point(n1.X, n1.Y);
                g.FillEllipse(fırca, noktaKonumu.X, noktaKonumu.Y, 1, 1);

                // DİKDORTGEN PRİZMA ÇİZİM
                dikdortgenprizma dp = new dikdortgenprizma(new Nokta3d(8,8,1),17,15,16);
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkBlue, kalemgenislik);
                // ilk dikdortgenin kordinatları ve boyutları
                int x1 = dp.M.X;
                int y1 = dp.M.Y;
                int en1 = dp.En;
                int boy1 = dp.Boy;

                //ikinci dikdortgenin kordinatları ve boyutları
                int x2 = dp.M.X + dp.Derinlik;
                int y2 = dp.M.Y+ dp.Derinlik;
                int en2 = dp.En;
                int boy2 = dp.Boy;

                // köşeleri birleştirerek prizma cizme işlemi
                g.DrawLine(kalem, x1, y1, x2, y2);
                g.DrawLine(kalem, x1 + en1, y1, x2 + en2, y2);
                g.DrawLine(kalem, x1, y1 + boy1, x2, y2 + boy2);
                g.DrawLine(kalem, x1 + en1, y1 + boy1, x2 + en2, y2 + boy2);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem, x1, y1, x1 + en1, y1);
                g.DrawLine(kalem, x1, y1 + boy1, x1 + en1 , y1+ boy1);
                g.DrawLine(kalem, x1, y1 , x1, y1 + boy1);
                g.DrawLine(kalem, x1 + en1, y1 , x1+en1, y1 +boy1);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem, x2, y2, x2 + en2, y2);
                g.DrawLine(kalem, x2, y2 + boy2, x2 + en2 , y2+ boy2);
                g.DrawLine(kalem, x2, y2, x2, y2 + boy2);
                g.DrawLine(kalem, x2 + en2, y2, x2 + en2, y2 + boy2);



                if (carpisma.noktadikdortgenprizmacarpisma(n1, dp))
                {
                    textBox1.Text = " Nokta ve Dikdörtgen Prizma Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Nokta ve Dikdörtgen Prizma Çarpışmıyor.";
                }
            

                button7Clicked = false;
            }

            if (button8Clicked)  //NOKTA SİLİNDİR
            {
                textBox1.Clear();
                //NOKTA CİZİM
                Brush fırca = new SolidBrush(Color.Red);
                Nokta n1 = new Nokta(25, 27);
                Point noktaKonumu = new Point(n1.X, n1.Y);
                g.FillEllipse(fırca, noktaKonumu.X, noktaKonumu.Y, 1, 1);

                // SİLİNDİR ÇİZİM

                silindir s1 = new silindir(new Nokta3d(45,14,2),4,45);

                // Silindir üst cember
                Point cemberMerkezi = new Point(s1.M.X, s1.M.Y);
                int cemberYaricapi = s1.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                //silindir alt cember

                Point cemberMerkezi2 = new Point(s1.M.X, s1.M.Y+s1.H);
                int cemberYaricapi2 = s1.R;
                int cemberCapi2 = cemberYaricapi * 2;        
                g.DrawEllipse(kalem, cemberMerkezi2.X - cemberYaricapi2, cemberMerkezi2.Y - cemberYaricapi2, cemberCapi2, cemberCapi2);

                // silindir yan cizgiler
                Point  baslangicNoktasi= new Point(s1.M.X-s1.R, s1.M.Y);
                Point bitisNoktasi = new Point(s1.M.X - s1.R, s1.M.Y + s1.H);
                g.DrawLine(kalem,baslangicNoktasi, bitisNoktasi);


                Point baslangicNoktasi2 = new Point(s1.M.X + s1.R, s1.M.Y);
                Point bitisNoktasi2 = new Point(s1.M.X + s1.R, s1.M.Y + s1.H);
                g.DrawLine(kalem, baslangicNoktasi2, bitisNoktasi2);




                if (carpisma.noktasilindircarpisma(n1, s1))
                {
                    textBox1.Text = " Nokta ve Silindir Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Nokta ve Silindir Çarpışmıyor.";
                }
                button8Clicked = false;
            }

            if (button9Clicked)
            {
                textBox1.Clear();
                // SİLİNDİR ÇİZİM

                silindir s1 = new silindir(new Nokta3d(45, 44, 2), 4, 25);

                // Silindir üst cember
                Point cemberMerkezi = new Point(s1.M.X, s1.M.Y);
                int cemberYaricapi = s1.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                //silindir alt cember

                Point cemberMerkezi2 = new Point(s1.M.X, s1.M.Y + s1.H);
                int cemberYaricapi2 = s1.R;
                int cemberCapi2 = cemberYaricapi * 2;
                g.DrawEllipse(kalem, cemberMerkezi2.X - cemberYaricapi2, cemberMerkezi2.Y - cemberYaricapi2, cemberCapi2, cemberCapi2);

                // silindir yan cizgiler
                Point baslangicNoktasi = new Point(s1.M.X - s1.R, s1.M.Y);
                Point bitisNoktasi = new Point(s1.M.X - s1.R, s1.M.Y + s1.H);
                g.DrawLine(kalem, baslangicNoktasi, bitisNoktasi);


                Point baslangicNoktasi2 = new Point(s1.M.X + s1.R, s1.M.Y);
                Point bitisNoktasi2 = new Point(s1.M.X + s1.R, s1.M.Y + s1.H);
                g.DrawLine(kalem, baslangicNoktasi2, bitisNoktasi2);



                // SİLİNDİR ÇİZİM 2

                silindir s2 = new silindir(new Nokta3d(25, 14, 2), 4, 35);

                // Silindir üst cember
                Point cemberMerkezi3 = new Point(s2.M.X, s2.M.Y);
                int cemberYaricapi3 = s2.R;
                int cemberCapi3 = cemberYaricapi3 * 2;
                float kalemgenislik3 = 0.3f;
                Pen kalem2 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem2, cemberMerkezi3.X - cemberYaricapi3, cemberMerkezi3.Y - cemberYaricapi3, cemberCapi3, cemberCapi3);

                //silindir alt cember

                Point cemberMerkezi4 = new Point(s2.M.X, s2.M.Y + s2.H);
                int cemberYaricapi4 = s2.R;
                int cemberCapi4 = cemberYaricapi3 * 2;
                g.DrawEllipse(kalem2, cemberMerkezi4.X - cemberYaricapi4, cemberMerkezi4.Y - cemberYaricapi4, cemberCapi4, cemberCapi4);

                // silindir yan cizgiler
                Point baslangicNoktasi3 = new Point(s2.M.X - s2.R, s2.M.Y);
                Point bitisNoktasi3 = new Point(s2.M.X - s2.R, s2.M.Y + s2.H);
                g.DrawLine(kalem2, baslangicNoktasi3, bitisNoktasi3);


                Point baslangicNoktasi4 = new Point(s2.M.X + s2.R, s2.M.Y);
                Point bitisNoktasi4 = new Point(s2.M.X + s2.R, s2.M.Y + s2.H);
                g.DrawLine(kalem2, baslangicNoktasi4, bitisNoktasi4);



                if (carpisma.silindirsilindircarpisma(s1, s2))
                {
                    textBox1.Text = " Silindir ve Silindir Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Silindir ve Silindir Çarpışmıyor.";
                }
            


                button9Clicked = false;
            }
            if (button10Clicked)   // KÜRE KÜRE
            {
                textBox1.Clear();
                //KÜRE CİZİM 
                kure k = new kure(new Nokta3d(40, 23, 5), 7);


                Point cemberMerkezi = new Point(k.M.X, k.M.Y);
                int cemberYaricapi = k.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                // elips ekvator cizgisi 
                int elipsYaricapX = cemberYaricapi;  //elipsinx eksenindeki yarıçpı
                int elipsYaricapY = cemberYaricapi / 2;  //elipsin y ekseni üzerindeki yarıçapı cemberin yarısı
                int elipsMerkeziX = cemberMerkezi.X;  // elipsin merkezi cemberin merkeziyle aynı x kordinatı
                int elipsMerkeziY = cemberMerkezi.Y;   // elipsin merkezi cemberin merkeziyle aynı y kordinatı
                Rectangle elipsRect = new Rectangle(elipsMerkeziX - elipsYaricapX, elipsMerkeziY - elipsYaricapY, elipsYaricapX * 2, elipsYaricapY * 2);
                Pen kalem1 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem, elipsRect);



                //KÜRE CİZİM 2
                kure k2 = new kure(new Nokta3d(22, 33, 5), 15);


                Point cemberMerkezi2 = new Point(k2.M.X, k2.M.Y);
                int cemberYaricapi2 = k2.R;
                int cemberCapi2 = cemberYaricapi2 * 2;
                float kalemgenislik2 = 0.3f;
                Pen kalem2 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem2, cemberMerkezi2.X - cemberYaricapi2, cemberMerkezi2.Y - cemberYaricapi2, cemberCapi2, cemberCapi2);

                // elips ekvator cizgisi 
                int elipsYaricap2X = cemberYaricapi2;  //elipsinx eksenindeki yarıçpı
                int elipsYaricap2Y = cemberYaricapi2 / 2;  //elipsin y ekseni üzerindeki yarıçapı cemberin yarısı
                int elipsMerkezi2X = cemberMerkezi2.X;  // elipsin merkezi cemberin merkeziyle aynı x kordinatı
                int elipsMerkezi2Y = cemberMerkezi2.Y;   // elipsin merkezi cemberin merkeziyle aynı y kordinatı
                Rectangle elipsRect2 = new Rectangle(elipsMerkezi2X - elipsYaricap2X, elipsMerkezi2Y - elipsYaricap2Y, elipsYaricap2X * 2, elipsYaricap2Y * 2);
                Pen kalem3 = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem2, elipsRect2);



                if (carpisma.kurekurecarpisma(k, k2))
                {
                    textBox1.Text = " Küre ve Küre Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Küreve Küre Çarpışmıyor.";
                }
               

                button10Clicked = false;
            }

            if (button11Clicked)  // küre silindir
            {
                textBox1.Clear();

                //KÜRE CİZİM 
                kure k = new kure(new Nokta3d(40, 23, 5), 7);


                Point cemberMerkezi = new Point(k.M.X, k.M.Y);
                int cemberYaricapi = k.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                // elips ekvator cizgisi 
                int elipsYaricapX = cemberYaricapi;  //elipsinx eksenindeki yarıçpı
                int elipsYaricapY = cemberYaricapi / 2;  //elipsin y ekseni üzerindeki yarıçapı cemberin yarısı
                int elipsMerkeziX = cemberMerkezi.X;  // elipsin merkezi cemberin merkeziyle aynı x kordinatı
                int elipsMerkeziY = cemberMerkezi.Y;   // elipsin merkezi cemberin merkeziyle aynı y kordinatı
                Rectangle elipsRect = new Rectangle(elipsMerkeziX - elipsYaricapX, elipsMerkeziY - elipsYaricapY, elipsYaricapX * 2, elipsYaricapY * 2);
                Pen kalem1 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem, elipsRect);



                silindir s2 = new silindir(new Nokta3d(45, 24, 2), 4, 25);

                // Silindir üst cember
                Point cemberMerkezi3 = new Point(s2.M.X, s2.M.Y);
                int cemberYaricapi3 = s2.R;
                int cemberCapi3 = cemberYaricapi3 * 2;
                float kalemgenislik3 = 0.3f;
                Pen kalem2 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem2, cemberMerkezi3.X - cemberYaricapi3, cemberMerkezi3.Y - cemberYaricapi3, cemberCapi3, cemberCapi3);

                //silindir alt cember

                Point cemberMerkezi4 = new Point(s2.M.X, s2.M.Y + s2.H);
                int cemberYaricapi4 = s2.R;
                int cemberCapi4 = cemberYaricapi3 * 2;
                g.DrawEllipse(kalem2, cemberMerkezi4.X - cemberYaricapi4, cemberMerkezi4.Y - cemberYaricapi4, cemberCapi4, cemberCapi4);

                // silindir yan cizgiler
                Point baslangicNoktasi3 = new Point(s2.M.X - s2.R, s2.M.Y);
                Point bitisNoktasi3 = new Point(s2.M.X - s2.R, s2.M.Y + s2.H);
                g.DrawLine(kalem2, baslangicNoktasi3, bitisNoktasi3);


                Point baslangicNoktasi4 = new Point(s2.M.X + s2.R, s2.M.Y);
                Point bitisNoktasi4 = new Point(s2.M.X + s2.R, s2.M.Y + s2.H);
                g.DrawLine(kalem2, baslangicNoktasi4, bitisNoktasi4);


                if (carpisma.kuresilindircarpisma(k, s2))
                {
                    textBox1.Text = " Küre ve Silindir Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Küre ve Silindir Çarpışmıyor.";
                }
             


                button11Clicked = false;
            }

            if (button12Clicked){
                textBox1.Clear();


                //KÜRE CİZİM 
                kure k = new kure(new Nokta3d(32, 43, 5), 18);


                Point cemberMerkezi = new Point(k.M.X, k.M.Y);
                int cemberYaricapi = k.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                // elips ekvator cizgisi 
                int elipsYaricapX = cemberYaricapi;  //elipsinx eksenindeki yarıçpı
                int elipsYaricapY = cemberYaricapi / 2;  //elipsin y ekseni üzerindeki yarıçapı cemberin yarısı
                int elipsMerkeziX = cemberMerkezi.X;  // elipsin merkezi cemberin merkeziyle aynı x kordinatı
                int elipsMerkeziY = cemberMerkezi.Y;   // elipsin merkezi cemberin merkeziyle aynı y kordinatı
                Rectangle elipsRect = new Rectangle(elipsMerkeziX - elipsYaricapX, elipsMerkeziY - elipsYaricapY, elipsYaricapX * 2, elipsYaricapY * 2);
                Pen kalem1 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem, elipsRect);


                //YÜZEY ÇİZİM
                yuzey y = new yuzey(new Nokta3d(23, 43, 0),17, 17);
                float kalemGenislik2 = 7f;
                Pen kalem2 = new Pen(Color.DarkBlue, kalemGenislik2);

                // yüzeyin köşe noktalarını hesapla
                float x1 = y.M.X - y.En /2;
                float x2 = y.M.X + y.En / 2;
                float y1 = y.M.Y - y.En / 2;
                float y2 = y.M.Y + y.En / 2;


                float dx = (x2 - x1);
                float dy = (y2 - y1);
                PointF[] points = new PointF[]
                {
                    new PointF(x1, y1),
                    new PointF(x1+dx, y1+dy),
                    new PointF(x2+dx, y2+dy),
                    new PointF(x2, y2),

                };
                g.DrawPolygon(kalem2, points);


                if (carpisma.yuzeykurecarpisma(y, k))
                {
                    textBox1.Text = " Yüzey ve Küre Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Yüzey ve Küre Çarpışmıyor.";
                }

                button12Clicked = false;
            }


            if (button13Clicked)
            {
                textBox1.Clear();

                // DİKDORTGEN PRİZMA ÇİZİM
                dikdortgenprizma dp = new dikdortgenprizma(new Nokta3d(23, 38, 1), 19, 15, 16);
          
                float kalemgenislik = 0.3f;
                Pen kalem2 = new Pen(Color.DarkBlue, kalemgenislik);
                Pen kalem1 = new Pen(Color.DarkRed, kalemgenislik);
                // ilk dikdortgenin kordinatları ve boyutları
                int x1 = dp.M.X;
                int y1 = dp.M.Y;
                int en1 = dp.En;
                int boy1 = dp.Boy;

                //ikinci dikdortgenin kordinatları ve boyutları
                int x2 = dp.M.X + dp.Derinlik;
                int y2 = dp.M.Y + dp.Derinlik;
                int en2 = dp.En;
                int boy2 = dp.Boy;

                // köşeleri birleştirerek prizma cizme işlemi
                g.DrawLine(kalem1, x1, y1, x2, y2);
                g.DrawLine(kalem1, x1 + en1, y1, x2 + en2, y2);
                g.DrawLine(kalem1, x1, y1 + boy1, x2, y2 + boy2);
                g.DrawLine(kalem1, x1 + en1, y1 + boy1, x2 + en2, y2 + boy2);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem1, x1, y1, x1 + en1, y1);
                g.DrawLine(kalem1, x1, y1 + boy1, x1 + en1, y1 + boy1);
                g.DrawLine(kalem1, x1, y1, x1, y1 + boy1);
                g.DrawLine(kalem1, x1 + en1, y1, x1 + en1, y1 + boy1);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem1, x2, y2, x2 + en2, y2);
                g.DrawLine(kalem1, x2, y2 + boy2, x2 + en2, y2 + boy2);
                g.DrawLine(kalem1, x2, y2, x2, y2 + boy2);
                g.DrawLine(kalem1, x2 + en2, y2, x2 + en2, y2 + boy2);



                //YÜZEY ÇİZİM
                yuzey y = new yuzey(new Nokta3d(73, 23, 0), 17, 8);
                float kalemGenislik2 = 7f;
                Pen kalem3 = new Pen(Color.DarkBlue, kalemGenislik2);

                // yüzeyin köşe noktalarını hesapla
                float x3 = y.M.X - y.En / 2;
                float x4 = y.M.X + y.En / 2;
                float y3 = y.M.Y - y.En / 2;
                float y4 = y.M.Y + y.En / 2;


                float dx = (x4 - x3);
                float dy = (y4 - y3);
                PointF[] points = new PointF[]
                {
                    new PointF(x3, y3),
                    new PointF(x3+dx, y3+dy),
                    new PointF(x4+dx, y4+dy),
                    new PointF(x4, y4),

                };
                g.DrawPolygon(kalem3, points);

                if (carpisma.yuzeydikdortgenprizmacarpisma(y, dp))
                {
                    textBox1.Text = " Yüzey ve Dikdörtgen Prizma Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Yüzey ve Dikdörtgen Prizma Çarpışmıyor.";
                }

                button13Clicked = false;
            }

            if (button14Clicked)
            {
                textBox1.Clear();
                // SİLİNDİR ÇİZİM

                silindir s1 = new silindir(new Nokta3d(54, 44, 0), 18, 25);
                yuzey y = new yuzey(new Nokta3d(53, 23, 0), 17, 18);

                // Silindir üst cember
                Point cemberMerkezi = new Point(s1.M.X, s1.M.Y);
                int cemberYaricapi = s1.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                //silindir alt cember

                Point cemberMerkezi2 = new Point(s1.M.X, s1.M.Y + s1.H);
                int cemberYaricapi2 = s1.R;
                int cemberCapi2 = cemberYaricapi * 2;
                g.DrawEllipse(kalem, cemberMerkezi2.X - cemberYaricapi2, cemberMerkezi2.Y - cemberYaricapi2, cemberCapi2, cemberCapi2);

                // silindir yan cizgiler
                Point baslangicNoktasi = new Point(s1.M.X - s1.R, s1.M.Y);
                Point bitisNoktasi = new Point(s1.M.X - s1.R, s1.M.Y + s1.H);
                g.DrawLine(kalem, baslangicNoktasi, bitisNoktasi);


                Point baslangicNoktasi2 = new Point(s1.M.X + s1.R, s1.M.Y);
                Point bitisNoktasi2 = new Point(s1.M.X + s1.R, s1.M.Y + s1.H);
                g.DrawLine(kalem, baslangicNoktasi2, bitisNoktasi2);

                //YÜZEY ÇİZİM
               
                float kalemGenislik2 = 7f;
                Pen kalem3 = new Pen(Color.DarkBlue, kalemGenislik2);

                // yüzeyin köşe noktalarını hesapla
                float x3 = y.M.X - y.En / 2;
                float x4 = y.M.X + y.En / 2;
                float y3 = y.M.Y - y.En / 2;
                float y4 = y.M.Y + y.En / 2;


                float dx = (x4 - x3);
                float dy = (y4 - y3);
                PointF[] points = new PointF[]
                {
                    new PointF(x3, y3),
                    new PointF(x3+dx, y3+dy),
                    new PointF(x4+dx, y4+dy),
                    new PointF(x4, y4),

                };
                g.DrawPolygon(kalem3, points);

                if (carpisma.yuzeysilindircarpisma(y, s1))
                {
                    textBox1.Text = " Yüzey ve Silindir Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Yüzey ve Silindir Çarpışmıyor.";
                }


                button14Clicked = false;
            }

            if (button15Clicked)     // küre dikdortgen prizma
            {
                textBox1.Clear();

                //KÜRE CİZİM 
                kure k = new kure(new Nokta3d(20, 20, 20), 10);


                Point cemberMerkezi = new Point(k.M.X, k.M.Y);
                int cemberYaricapi = k.R;
                int cemberCapi = cemberYaricapi * 2;
                float kalemgenislik = 0.3f;
                Pen kalem = new Pen(Color.DarkRed, kalemgenislik);
                g.DrawEllipse(kalem, cemberMerkezi.X - cemberYaricapi, cemberMerkezi.Y - cemberYaricapi, cemberCapi, cemberCapi);

                // elips ekvator cizgisi 
                int elipsYaricapX = cemberYaricapi;  //elipsinx eksenindeki yarıçpı
                int elipsYaricapY = cemberYaricapi / 2;  //elipsin y ekseni üzerindeki yarıçapı cemberin yarısı
                int elipsMerkeziX = cemberMerkezi.X;  // elipsin merkezi cemberin merkeziyle aynı x kordinatı
                int elipsMerkeziY = cemberMerkezi.Y;   // elipsin merkezi cemberin merkeziyle aynı y kordinatı
                Rectangle elipsRect = new Rectangle(elipsMerkeziX - elipsYaricapX, elipsMerkeziY - elipsYaricapY, elipsYaricapX * 2, elipsYaricapY * 2);
                Pen kalem1 = new Pen(Color.DarkBlue, kalemgenislik);
                g.DrawEllipse(kalem, elipsRect);

                // DİKDORTGEN PRİZMA ÇİZİM
                dikdortgenprizma dp = new dikdortgenprizma(new Nokta3d(16, 16, 16), 8, 8, 8);
              
                Pen kalem2 = new Pen(Color.DarkBlue, kalemgenislik);
                // ilk dikdortgenin kordinatları ve boyutları
                int x1 = dp.M.X;
                int y1 = dp.M.Y;
                int en1 = dp.En;
                int boy1 = dp.Boy;

                //ikinci dikdortgenin kordinatları ve boyutları
                int x2 = dp.M.X + dp.Derinlik;
                int y2 = dp.M.Y + dp.Derinlik;
                int en2 = dp.En;
                int boy2 = dp.Boy;

                // köşeleri birleştirerek prizma cizme işlemi
                g.DrawLine(kalem2, x1, y1, x2, y2);
                g.DrawLine(kalem2, x1 + en1, y1, x2 + en2, y2);
                g.DrawLine(kalem2, x1, y1 + boy1, x2, y2 + boy2);
                g.DrawLine(kalem2, x1 + en1, y1 + boy1, x2 + en2, y2 + boy2);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem2, x1, y1, x1 + en1, y1);
                g.DrawLine(kalem2, x1, y1 + boy1, x1 + en1, y1 + boy1);
                g.DrawLine(kalem2, x1, y1, x1, y1 + boy1);
                g.DrawLine(kalem2, x1 + en1, y1, x1 + en1, y1 + boy1);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem2, x2, y2, x2 + en2, y2);
                g.DrawLine(kalem2, x2, y2 + boy2, x2 + en2, y2 + boy2);
                g.DrawLine(kalem2, x2, y2, x2, y2 + boy2);
                g.DrawLine(kalem2, x2 + en2, y2, x2 + en2, y2 + boy2);


                if (carpisma.kuredikdortgenprizmacarpisma(k, dp))
                {
                    textBox1.Text = " Küre ve Dikdörtgen Prizma Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Küre ve Dikdörtgen Prizma Çarpışmıyor.";
                }


                button15Clicked = false;
            }

            if (button16Clicked)
            {
                textBox1.Clear();
                // DİKDORTGEN PRİZMA ÇİZİM
                dikdortgenprizma dp = new dikdortgenprizma(new Nokta3d(23, 38, 1), 19, 15, 16);
                dikdortgenprizma dp2 = new dikdortgenprizma(new Nokta3d(60, 38, 1), 19, 7, 6);
                float kalemgenislik = 0.3f;
                Pen kalem2 = new Pen(Color.DarkBlue, kalemgenislik);
                Pen kalem1 = new Pen(Color.DarkRed, kalemgenislik);
                // ilk dikdortgenin kordinatları ve boyutları
                int x1 = dp.M.X;
                int y1 = dp.M.Y;
                int en1 = dp.En;
                int boy1 = dp.Boy;

                //ikinci dikdortgenin kordinatları ve boyutları
                int x2 = dp.M.X + dp.Derinlik;
                int y2 = dp.M.Y + dp.Derinlik;
                int en2 = dp.En;
                int boy2 = dp.Boy;

                // köşeleri birleştirerek prizma cizme işlemi
                g.DrawLine(kalem1, x1, y1, x2, y2);
                g.DrawLine(kalem1, x1 + en1, y1, x2 + en2, y2);
                g.DrawLine(kalem1, x1, y1 + boy1, x2, y2 + boy2);
                g.DrawLine(kalem1, x1 + en1, y1 + boy1, x2 + en2, y2 + boy2);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem1, x1, y1, x1 + en1, y1);
                g.DrawLine(kalem1, x1, y1 + boy1, x1 + en1, y1 + boy1);
                g.DrawLine(kalem1, x1, y1, x1, y1 + boy1);
                g.DrawLine(kalem1, x1 + en1, y1, x1 + en1, y1 + boy1);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem1, x2, y2, x2 + en2, y2);
                g.DrawLine(kalem1, x2, y2 + boy2, x2 + en2, y2 + boy2);
                g.DrawLine(kalem1, x2, y2, x2, y2 + boy2);
                g.DrawLine(kalem1, x2 + en2, y2, x2 + en2, y2 + boy2);


                // ilk dikdortgenin kordinatları ve boyutları
                int x3 = dp2.M.X;
                int y3 = dp2.M.Y;
                int en3 = dp2.En;
                int boy3 = dp2.Boy;

                //ikinci dikdortgenin kordinatları ve boyutları
                int x4 = dp2.M.X + dp2.Derinlik;
                int y4 = dp2.M.Y + dp2.Derinlik;
                int en4 = dp2.En;
                int boy4 = dp2.Boy;

                // köşeleri birleştirerek prizma cizme işlemi
                g.DrawLine(kalem2, x3, y3, x4, y4);
                g.DrawLine(kalem2, x3 + en3, y3, x4 + en4, y4);
                g.DrawLine(kalem2, x3, y3 + boy3, x4, y4 + boy4);
                g.DrawLine(kalem2, x3 + en3, y3 + boy3, x4 + en4, y4 + boy4);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem2, x3, y3, x3 + en3, y3);
                g.DrawLine(kalem2, x3, y3 + boy3, x3 + en3, y3 + boy3);
                g.DrawLine(kalem2, x3, y3, x3, y3 + boy3);
                g.DrawLine(kalem2, x3 + en3, y3, x3 + en3, y3 + boy3);

                //ilk dikdortgenin çizgileri
                g.DrawLine(kalem2, x4, y4, x4 + en4, y4);
                g.DrawLine(kalem2, x4, y4 + boy4, x4 + en4, y4 + boy4);
                g.DrawLine(kalem2, x4, y4, x4, y4 + boy4);
                g.DrawLine(kalem2, x4 + en4, y4, x4 + en4, y4 + boy4);


                if (carpisma.dikdortgenprizmalarcarpisma(dp, dp2))
                {
                    textBox1.Text = "Dikdörtgen Prizma ve Dikdörtgen Prizma Çarpışıyor.";
                }
                else
                {
                    textBox1.Text = " Dikdörtgen Prizma ve Dikdörtgen Prizma Çarpışmıyor.";
                }

                button16Clicked = false;
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Nokta
    {
        int x, y;
        public Nokta()
        {
            x = 0;
            y = 0;

        }
        public Nokta(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
    public class Nokta3d
    {
        int z;
        int x, y;
        public Nokta3d() : base() { z = 0; }
        public Nokta3d(int X, int Y, int Z)
        {

            x = X;
            y = Y;
            z = Z;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
    }

    public class cember
    {
        Nokta m; int r;
        public cember()
        {
            m = new Nokta();
            r = 0;
        }

        public cember(Nokta P, int R)
        {
            m = P;
            r = R;
        }
        public int R { get => r; set => r = value; }
        public Nokta M { get => m; set => m = value; }
    }


    public class dikdortgen
    {
        Nokta m; int en; int boy;
        public dikdortgen()
        {
            m = new Nokta();
            en = 0;
            boy = 0;
        }

        public dikdortgen(Nokta p, int En, int Boy)
        {
            m = p;
            en = En;
            boy = Boy;
        }
        public int Boy { get => boy; set => boy = value; }
        public Nokta M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
    }

    public class dikdortgenprizma
    {
        Nokta3d m; int en; int boy; int derinlik;
        public dikdortgenprizma()
        {
            m = new Nokta3d();
            en = 0;
            boy = 0;
            derinlik = 0;
        }
        public dikdortgenprizma(Nokta3d p, int En, int Boy, int Derinlik)
        {
            m = p;
            en = En;
            boy = Boy;
            derinlik = Derinlik;
        }
        public int Boy { get => boy; set => boy = value; }
        public Nokta3d M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
        public int Derinlik { get => derinlik; set => derinlik = value; }
    }

    public class silindir
    {
        Nokta3d m; int r; int h;
        public silindir()
        {
            m = new Nokta3d();
            r = 0;
            h = 0;

        }
        public silindir(Nokta3d p, int R, int H)
        {
            m = p;
            r = R;
            h = H;
        }

        public int R { get => r; set => r = value; }
        public int H { get => h; set => h = value; }
        public Nokta3d M { get => m; set => m = value; }
    }
    public class kure
    {
        Nokta3d m; int r;
        public kure()
        {
            m = new Nokta3d();
            r = 0;
        }

        public kure(Nokta3d p, int R)
        {
            m = p;
            r = R;

        }
        public int R { get => r; set => r = value; }
        public Nokta3d M { get => m; set => m = value; }
    }



    public class yuzey
    {
        Nokta3d m; int en; int boy; 
        public yuzey()
        {
            m = new Nokta3d();
            en = 0;
            boy = 0;
        
        }
        public yuzey(Nokta3d p, int En, int Boy )
        {
            m = p;
            en = En;
            boy = Boy;
          
        }
        public int Boy { get => boy; set => boy = value; }
        public Nokta3d M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
   
    }

    public static class carpisma
    {

        public static bool noktadikdortgencarpisma(Nokta n, dikdortgen d)
        {
            if (n.X >= d.M.X && n.X <= d.M.X + d.En && n.Y >= d.M.Y && n.Y <= d.M.Y + d.Boy)
            {
                return true;
            }
            return false;
        }
        public static bool noktacembercarpisma(Nokta n, cember c)
        {
            float uzaklik = (float)Math.Sqrt(Math.Pow(n.X - c.M.X, 2) + Math.Pow(n.Y - c.M.Y, 2));
            if (uzaklik <= c.R)
                return true;
            else
                return false;
        }


        public static bool dikdortgendikdortgencarpisma(dikdortgen d1, dikdortgen d2)
        {
            if (d1.M.X < d2.M.X + d2.En &&
                d1.M.X + d1.En > d2.M.X &&
                d1.M.Y < d2.M.Y + d2.Boy &&
                d1.M.Y + d1.Boy > d2.M.Y)
            {
                return true;
            }
            return false;
        }

        public static bool dikdortgencembercarpisma(dikdortgen d, cember c)
        {
            int dikdortgenMinX = d.M.X - (d.En / 2);
            int dikdortgenMaxX = d.M.X + (d.En / 2);
            int dikdortgenMinY = d.M.Y - (d.Boy / 2);
            int dikdortgenMaxY = d.M.Y + (d.Boy / 2);

            int dx = Math.Abs(c.M.X - dikdortgenMinX);
            int dy = Math.Abs(c.M.Y - dikdortgenMinY);

            if (dx > (d.En / 2) + c.R || dy > (d.Boy / 2) + c.R)
                return false;

            if (dx <= (d.En / 2) || dy <= (d.Boy / 2))
                return true;

            int koseuzaklik = (dx - d.En / 2) ^ 2 + (dy - d.Boy / 2) ^ 2;

            return koseuzaklik <= (c.R ^ 2);
        }

        public static bool cembercembercarpisma(cember c1, cember c2)
        {
            int dx = c1.M.X - c2.M.X;
            int dy = c1.M.Y - c2.M.Y;
            int d = (int)Math.Sqrt(dx * dx + dy * dy);

            if (d <= c1.R + c2.R)
                return true;
            else
                return false;
        }

        public static bool noktakurecarpisma(Nokta3d n, kure k)
        {
            int mesafeKare = (n.X - k.M.X) * (n.X - k.M.X) +
                              (n.Y - k.M.Y) * (n.Y - k.M.Y) +
                              (n.Z - k.M.Z) * (n.Z - k.M.Z);

            int rKare = k.R * k.R;

            if (mesafeKare <= rKare)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool noktadikdortgenprizmacarpisma(Nokta3d n, dikdortgenprizma dp)
        {
            // Dikdörtgen prizmanın sınırlarının koordinatları
            int xMin = dp.M.X;
            int xMax = dp.M.X + dp.En;
            int yMin = dp.M.Y;
            int yMax = dp.M.Y + dp.Boy;
            int zMin = dp.M.Z;
            int zMax = dp.M.Z + dp.Derinlik;

            // Noktanın koordinatları
            int x = n.X;
            int y = n.Y;
            int z = n.Z;

            // Koordinatların sınırlar içinde olup olmadığını kontrol et
            if ((x >= xMin && x <= xMax) && (y >= yMin && y <= yMax) && (z >= zMin && z <= zMax))
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        public static bool noktasilindircarpisma(Nokta n, silindir s)
        {
            // Noktanın silindirin taban düzleminin üstünde veya altında olup olmadığını kontrol edin
            if (n.Y < s.M.Y - s.H / 2 || n.Y > s.M.Y + s.H / 2)

            {
                return false;
            }

            // Noktanın silindirin yanal koordinatlarının arasında olup olmadığını kontrol edin
            int dx = n.X - s.M.X;
            int dy = n.Y - s.M.Y;
            if (dx * dx + dy * dy > s.R * s.R)
            {
                return false;
            }

            // Nokta, silindirin içindeyse çarpışma vardır
            return true;
        }
        public static bool silindirsilindircarpisma(silindir s1, silindir s2)
        {
            int x1 = s1.M.X;
            int y1 = s1.M.Y;
            int z1 = s1.M.Z;

            int x2 = s2.M.X;
            int y2 = s2.M.Y;
            int z2 = s2.M.Z;

            int r1 = s1.R;
            int r2 = s2.R;

            int h1 = s1.H;
            int h2 = s2.H;

            double mesafeKare = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);

            if (Math.Sqrt(mesafeKare) > r1 + r2)
            {
                return false;
            }

            if (Math.Abs(z2 - z1) > h1 + h2)
            {
                return false;
            }

            return true;
        }

        public static bool kurekurecarpisma(kure k1, kure k2)
        {
            int x1 = k1.M.X;
            int y1 = k1.M.Y;
            int z1 = k1.M.Z;
            int r1 = k1.R;

            int x2 = k2.M.X;
            int y2 = k2.M.Y;
            int z2 = k2.M.Z;
            int r2 = k2.R;

            int dx = x2 - x1;
            int dy = y2 - y1;
            int dz = z2 - z1;
            int distanceSquare = dx * dx + dy * dy + dz * dz;
            int sumOfRadius = r1 + r2;
            int sumOfRadiusSquare = sumOfRadius * sumOfRadius;

            if (distanceSquare <= sumOfRadiusSquare)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool kuresilindircarpisma(kure k, silindir s)
        {
            int x1 = k.M.X;
            int y1 = k.M.Y;
            int z1 = k.M.Z;
            int r1 = k.R;

            int x2 = s.M.X;
            int y2 = s.M.Y;
            int z2 = s.M.Z;
            int r2 = s.R;
            int h = s.H;

            // Kürenin merkezi ve silindirin ekseni arasındaki mesafeyi hesaplayın
            double mesafe = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

            // Küre ve silindir çarpışıyor mu kontrol edin
            if (mesafe <= r1 + r2 && z1 >= z2 && z1 <= z2 + h)
            {
                return true;
            }

            return false;
        }

        public static bool kuredikdortgenprizmacarpisma(kure k, dikdortgenprizma dp)
        {
            // Kürenin merkezi
            int x1 = k.M.X;
            int y1 = k.M.Y;
            int z1 = k.M.Z;

            // Prizmanın merkezi
            int x2 = dp.M.X;
            int y2 = dp.M.Y;
            int z2 = dp.M.Z;

            // Prizmanın kenar uzunlukları
            int en = dp.En;
            int boy = dp.Boy;
            int derinlik = dp.Derinlik;

            // Kürenin yarıçapı
            int r = k.R;

            // Kürenin merkezi ile prizmanın merkezi arasındaki uzaklık
            int dx = Math.Abs(x1 - x2);
            int dy = Math.Abs(y1 - y2);
            int dz = Math.Abs(z1 - z2);

            // Prizmanın kenar uzunluklarının yarısı
            int en2 = en / 2;
            int boy2 = boy / 2;
            int derinlik2 = derinlik / 2;

            // Kürenin merkezi, prizmanın kenarlarından en az birinin içinde mi?
            if (dx > en2 + r || dy > boy2 + r || dz > derinlik2 + r)
            {
                // Kürenin merkezi prizmanın sınırlarının dışında
                return false;
            }

            // Kürenin merkezi, prizmanın içinde mi?
            if (dx <= en2 || dy <= boy2 || dz <= derinlik2)
            {
                // Kürenin merkezi prizmanın içinde
                return true;
            }

            // Köşe noktalarının kontrolü
            int x = dx - en2;
            int y = dy - boy2;
            int z = dz - derinlik2;
            return x * x + y * y + z * z <= r * r;
        }

        public static bool dikdortgenprizmalarcarpisma(dikdortgenprizma dp1, dikdortgenprizma dp2)
        {
            int x1 = dp1.M.X;
            int y1 = dp1.M.Y;
            int z1 = dp1.M.Z;

            int x2 = dp2.M.X;
            int y2 = dp2.M.Y;
            int z2 = dp2.M.Z;

            if (Math.Abs(x1 - x2) <= (dp1.En + dp2.En) / 2 &&
                Math.Abs(y1 - y2) <= (dp1.Boy + dp2.Boy) / 2 &&
                Math.Abs(z1 - z2) <= (dp1.Derinlik + dp2.Derinlik) / 2)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        public static bool yuzeykurecarpisma (yuzey y, kure k)
        {
            // Kürenin merkezi
            int kureX = k.M.X;
            int kureY = k.M.Y;
            int kureZ = k.M.Z;

            // Kürenin yarıçapı
            int kureR = k.R;

            // Yüzeyin köşe noktası
            int yuzeyX = y.M.X;
            int yuzeyY = y.M.Y;
            int yuzeyZ = y.M.Z;

            // Yüzeyin boyutları
            int yuzeyEn = y.En;
            int yuzeyBoy = y.Boy;

            // Çarpışma denetlemesi
            if (kureX >= yuzeyX && kureX <= yuzeyX + yuzeyEn &&
                kureY >= yuzeyY && kureY <= yuzeyY + yuzeyBoy &&
                kureZ >= yuzeyZ && kureZ <= yuzeyZ + kureR)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool yuzeydikdortgenprizmacarpisma(yuzey y, dikdortgenprizma prizma)
        {
            int prizmaXMin = prizma.M.X;
            int prizmaXMax = prizma.M.X + prizma.En;
            int prizmaYMin = prizma.M.Y;
            int prizmaYMax = prizma.M.Y + prizma.Boy;
            int prizmaZMin = prizma.M.Z;
            int prizmaZMax = prizma.M.Z + prizma.Derinlik;

            int yuzeyXMin = y.M.X;
            int yuzeyXMax = y.M.X + y.En;
            int yuzeyYMin = y.M.Y;
            int yuzeyYMax = y.M.Y + y.Boy;

            bool carpismaX = (prizmaXMin <= yuzeyXMax) && (prizmaXMax >= yuzeyXMin);
            bool carpismaY = (prizmaYMin <= yuzeyYMax) && (prizmaYMax >= yuzeyYMin);
            bool carpismaZ = (prizmaZMin <= y.M.Z) && (prizmaZMax >= y.M.Z);

            return carpismaX && carpismaY && carpismaZ;
        }

        public static bool yuzeysilindircarpisma(yuzey y, silindir s)
        {
            // Silindirin taban noktasının koordinatlarını al
            int silindirTabanX = s.M.X;
            int silindirTabanY = s.M.Y;
            int silindirTabanZ = s.M.Z;

            // Silindirin taban noktasının X ve Y koordinatlarıyla yüzeyin köşe noktasını karşılaştır
            if (silindirTabanX >= y.M.X && silindirTabanX <= y.M.X + y.En && silindirTabanY >= y.M.Y && silindirTabanY <= y.M.Y + y.Boy)
            {
                // Eğer silindirin taban noktası yüzeyin içinde ise çarpışma var

                return true;
            }

            // Silindirin taban noktasının Z koordinatıyla yüzeyin derinliğini karşılaştır
            if (silindirTabanZ <= y.M.Z && silindirTabanZ >= y.M.Z - s.H)
            {

                return true;
            }


            return false;
        }



    }


}
