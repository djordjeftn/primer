using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
      
        private readonly ProductBusiness productBusiness;
        public Form1()
        {
            this.productBusiness = new ProductBusiness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillList(); 
        }
        private void FillList()
        {
            
            listBoxLista.Items.Clear();
            List<Products> products = this.productBusiness.GetAllProducts();

            foreach (Products b in products)
            {
                listBoxLista.Items.Add(b.Id + ". " + b.Name + "(" + b.Description + ") - " +
                    string.Format("{0:dd/MM/yyyy}", b.ExpiryDate.Date));
            }
        }
        private void DODAJ_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNaziv.Text) &&
                !string.IsNullOrEmpty(textBoxOpis.Text) &&
                !string.IsNullOrEmpty(textBoxRok.Text) &&
                textBoxNaziv.Text.Length <= 100)

            {
                Products p = new Products();
                p.Name = textBoxNaziv.Text;
                p.Description = textBoxOpis.Text;
                p.ExpiryDate = Convert.ToDateTime(textBoxRok.Text);

                if (this.productBusiness.InsertProducts(p))
                {
                    FillList();
                    textBoxNaziv.Text = "";
                    textBoxOpis.Text = "";
                    textBoxRok.Text = "";
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
            else
            {
                // MessageBox.Show("Morate popuniti sva polja!");
                label4.Text = "Nesto nije validno!";
            }
        }
    }
}

