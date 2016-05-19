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
            toyota moja = new toyota("Auris", 4, 1364);
            lbl_1.Text = moja.nazwa;
            lbl_2.Text = moja.wiek.ToString();
            lbl_3.Text = moja.poj_silnika.ToString();
        }        
    }

    class toyota
    {
        //public toyota()
        //{
        //    this.nazwa = null;
        //    this.wiek = 0;
        //    this.poj_silnika = 0;
        //}

        public toyota(string nazwa, int wiek, int poj_silnika)
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