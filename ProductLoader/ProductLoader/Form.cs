using BlackFridaySniffer.Models;
using ProductLoader.Data.Dtos;
using ProductLoader.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductLoader
{
    public partial class Form : System.Windows.Forms.Form
    {
        IProductService _productService;
		public Form(IProductService productService)
		{
			InitializeComponent();
			_productService = productService;
		}

		private void Form_Load(object sender, EventArgs e)
        {
            var products = _productService.GetProducts();
			foreach (var product in products)
			{
				lsbProducts.Items.Add(product);
			}
        }

		private void btnInsert_Click(object sender, EventArgs e)
		{
			try
			{
				CreateProductDto newProduct = new CreateProductDto
				{
					Name = txtName.Text,
					Url = txtUrl.Text,
					PriceXPath = txtPriceXpath.Text,
					MaximumPrice = double.Parse(txtMaximumPrice.Text),
					DesiredPrice = double.Parse(txtDesiredPrice.Text),
				};
				var product = _productService.CreateProduct(newProduct);
				lsbProducts.Items.Add(product);
				ClearFormTextBoxes();
			}
			catch (FormatException)
			{
				MessageBox.Show("Please select write a price on the specified format", "Wrong price format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			ClearFormTextBoxes();
			lsbProducts.ClearSelected();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			var product = (Product)lsbProducts.SelectedItem;

			if (product != null)
			{
				_productService.RemoveProduct(product);
				lsbProducts.Items.Remove(product);
				ClearFormTextBoxes();
			}
			else
			{
				MessageBox.Show("Please select a product to remove", "No product selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ClearFormTextBoxes()
		{
			foreach (var control in Controls)
			{
				if (control is TextBox)
				{
					((TextBox)control).Text = "";
				}
			}
		}

		private void lsbProducts_SelectedValueChanged(object sender, EventArgs e)
		{
			var product = (Product)lsbProducts.SelectedItem;
			if (product != null)
			{
				txtName.Text = product.Name;
				txtUrl.Text = product.Url;
				txtPriceXpath.Text = product.PriceXPath;
				txtMaximumPrice.Text = product.MaximumPrice.ToString();
				txtDesiredPrice.Text = product.DesiredPrice.ToString();
			}
		}
	}
}
