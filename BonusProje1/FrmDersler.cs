﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonusProje1
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.DersEkle(TxtDersAd.Text);
            MessageBox.Show("Ders Ekleme İşlemi Yapılmıştır.");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(TxtDersID.Text));
            MessageBox.Show("Ders Silme İşlemi Yapılmıştır.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGuncelle(TxtDersAd.Text,byte.Parse(TxtDersID.Text));
            MessageBox.Show("Ders Güncelleme İşlemi Yapılmıştır.");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
