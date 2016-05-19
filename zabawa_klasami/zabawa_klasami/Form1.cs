using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zabawa_klasami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //toyota moja = new toyota();
            //samochod auris = new samochod("Auris", 4, 1364);
            samochod volkswagen = new samochod("Golf", 7, 1598);
            //lbl_1.Text = auris.nazwa;
            //lbl_2.Text = auris.wiek.ToString();
            //lbl_3.Text = auris.poj_silnika.ToString();

            lbl_1.Text = volkswagen.nazwa;
            lbl_2.Text = volkswagen.wiek.ToString();
            lbl_3.Text = volkswagen.poj_silnika.ToString();
        }        
    }

    class samochod
    {
        //public toyota()
        //{
        //    this.nazwa = null;
        //    this.wiek = 0;
        //    this.poj_silnika = 0;
        //}

        public samochod(string nazwa, int wiek, int poj_silnika)
        {
            this.nazwa = nazwa;
            this.wiek = wiek;
            this.poj_silnika = poj_silnika;
        }

        //public string Nazwa
        //{
        //    get { return this.nazwa; }
        //    set { this.nazwa = value; }
        //}

        //public int Wiek
        //{
        //    get { return this.wiek; }
        //    set { this.wiek = value; }
        //}

        //public int Poj_silnika
        //{
        //    get { return this.poj_silnika; }
        //    set { this.poj_silnika = value; }
        //}

        //string Nazwa;
        //int Wiek;
        //int Poj_silnika;

        public string nazwa {get; set; }
        public int wiek { get; set; }
        public int poj_silnika { get; set; }
    }
}