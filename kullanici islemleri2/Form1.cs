using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace kullanici_islemleri2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int sayac = 0;
        string[] tckimlik = new string[100];
        string[] sinif = new string[100];
        string[] tel = new string[100];
        string[] cinsiyet = new string[100];
        string[] ad= new string[100];
        string[] soyad= new string[100];
        string[] bolum = new string[100];



        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox2.Items.Add("Bilişim");
            comboBox2.Items.Add("Kimya");
            comboBox2.Items.Add("Elektrik");




        }
        
        

        private void kaydet_Click(object sender, EventArgs e)
        {
            //ad   
            ad[sayac] = textBox2.Text;
            //soyad
            soyad[sayac] = textBox3.Text;
            //bölüm
            bolum[sayac] = comboBox2.Text;
            //tckimlik
            tckimlik[sayac] = textBox1.Text;
            //sinif
            sinif[sayac] = (comboBox1.Text);
            //tel
            tel[sayac] = maskedTextBox1.Text;
            //cinsiyet
            if (radioButton1.Checked)
            {
                cinsiyet[sayac] = "Kadın";
            }
            else if (radioButton2.Checked)
            {
                cinsiyet[sayac] = "Erkek";
            }
            else
            {
                MessageBox.Show("Cinsiyet Seçmediniz");
            }
            sayac++;
            label8.Text = "Başarıyla Kaydedildi";
        }

        private void listele_Click(object sender, EventArgs e)
        {
         
            listBox1.Items.Clear();
            for (int i = 0; i <tckimlik.Length; i++)
            {
                listBox1.Items.Add(tckimlik[i] + "     " + ad[i] + "     " + soyad[i] + "    " + cinsiyet[i] + "     " + bolum[i] + "     " + sinif[i] + "     " + tel[i]);
                
            }

            

        }

        private void temizle_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();
            maskedTextBox1.Clear();
            
          
        }

        private void kayıtara_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Tcyi giriniz");
            
            for (int i = 0; i < tckimlik.Length; i++)
            {
                if (x==tckimlik[i])
                {
                    label23.Text = tckimlik[i];
                    label24.Text = ad[i];
                    label25.Text = soyad[i];
                    label26.Text = bolum[i];
                    label27.Text = sinif[i];
                    label28.Text = tel[i];
                    label29.Text = cinsiyet[i];


                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
