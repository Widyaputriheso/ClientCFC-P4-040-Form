﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCFC_P4_040_Form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void penjumlahan1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
            penjumlahan1.Enabled = false;
            penjumlahan2.Enabled = false;
            pengurangan1.Enabled = false;
            pengurangan2.Enabled = false;
            perkalian1.Enabled = false;
            perkalian2.Enabled = false;
            pembagian1.Enabled = false;
            pembagian2.Enabled = false;
            hasiljumlah.Enabled = false;
            hasilkurang.Enabled = false;
            hasilkali.Enabled = false;
            hasilbagi.Enabled = false;

            int hasil;

            penjumlahan1.Text = "1";
            penjumlahan2.Text = "2";
            hasil = Convert.ToInt32(penjumlahan1.Text) + Convert.ToInt32(penjumlahan2.Text);
            hasiljumlah.Text = hasil.ToString();

            pengurangan1.Text = "3";
            pengurangan2.Text = "2";
            hasil = Convert.ToInt32(pengurangan1.Text) - Convert.ToInt32(pengurangan2.Text);
            hasilkurang.Text = hasil.ToString();

            perkalian1.Text = "2";
            perkalian2.Text = "2";
            hasil = Convert.ToInt32(perkalian1.Text) * Convert.ToInt32(perkalian2.Text);
            hasilkali.Text = hasil.ToString();

            pembagian1.Text = "2";
            pembagian2.Text = "2";
            hasil = Convert.ToInt32(pembagian1.Text) / Convert.ToInt32(pembagian2.Text);
            hasilbagi.Text = hasil.ToString();
        }
	}
}
