using Project.BLL.DesignPatterns.Generic_Repository.ConcRep;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.ENTITIES.Models;

namespace Project.WinFormUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _crep;
        public Form1()
        {
            InitializeComponent();
            _crep=new CategoryRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _crep.Add(new Category { CategoryName = txtName.Text });
            CategoryList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Category c = (Category)lstKategoriler.SelectedItem;
            _crep.Delete(c);
            CategoryList();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Category Güncellenecek=lstKategoriler.SelectedItem as Category;
            Güncellenecek.CategoryName= txtName.Text;
            _crep.Update(Güncellenecek);
            CategoryList();
        }

        private void btnHepsi_Click(object sender, EventArgs e)
        {
            lstKategoriler.DataSource=_crep.GetAll();
        }

        private void btnAktif_Click(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnGüncel_Click(object sender, EventArgs e)
        {
            lstKategoriler.DataSource = _crep.GetModifiers();
        }

        private void btnPasif_Click(object sender, EventArgs e)
        {
            lstKategoriler.DataSource = _crep.GetPassive();
        }
        public void CategoryList()
        {
            lstKategoriler.DataSource= _crep.GetActive();
        }

        private void lstKategoriler_SelectedValueChanged(object sender, EventArgs e)
        {
            txtName.Text= lstKategoriler.SelectedItem.ToString();
        }

        private void btnYokEt_Click(object sender, EventArgs e)
        {
            Category c = lstKategoriler.SelectedItem as Category;
            _crep.Destroy(c);
            CategoryList();
        }
    }
}
