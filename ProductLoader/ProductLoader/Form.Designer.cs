
namespace ProductLoader
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.lsbProducts = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRemove = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPriceXpath = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtMaximumPrice = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDesiredPrice = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lsbProducts
			// 
			this.lsbProducts.FormattingEnabled = true;
			this.lsbProducts.ItemHeight = 15;
			this.lsbProducts.Location = new System.Drawing.Point(12, 27);
			this.lsbProducts.Name = "lsbProducts";
			this.lsbProducts.Size = new System.Drawing.Size(242, 214);
			this.lsbProducts.TabIndex = 0;
			this.lsbProducts.SelectedValueChanged += new System.EventHandler(this.lsbProducts_SelectedValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Products";
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(260, 218);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(260, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(260, 27);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(272, 23);
			this.txtName.TabIndex = 4;
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(260, 71);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(272, 23);
			this.txtUrl.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(260, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Url";
			// 
			// txtPriceXpath
			// 
			this.txtPriceXpath.Location = new System.Drawing.Point(260, 115);
			this.txtPriceXpath.Name = "txtPriceXpath";
			this.txtPriceXpath.Size = new System.Drawing.Size(272, 23);
			this.txtPriceXpath.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(260, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Price Xpath";
			// 
			// txtMaximumPrice
			// 
			this.txtMaximumPrice.Location = new System.Drawing.Point(260, 159);
			this.txtMaximumPrice.Name = "txtMaximumPrice";
			this.txtMaximumPrice.Size = new System.Drawing.Size(141, 23);
			this.txtMaximumPrice.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(260, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "Maximum Price (xxxx.xx)";
			// 
			// txtDesiredPrice
			// 
			this.txtDesiredPrice.Location = new System.Drawing.Point(407, 159);
			this.txtDesiredPrice.Name = "txtDesiredPrice";
			this.txtDesiredPrice.Size = new System.Drawing.Size(125, 23);
			this.txtDesiredPrice.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(407, 141);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Desired Price (xxxx.xx)";
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(457, 218);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(75, 23);
			this.btnInsert.TabIndex = 13;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(260, 188);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 14;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 252);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtDesiredPrice);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtMaximumPrice);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPriceXpath);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lsbProducts);
			this.MaximumSize = new System.Drawing.Size(570, 291);
			this.MinimumSize = new System.Drawing.Size(570, 291);
			this.Name = "Form";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Manage Products";
			this.Load += new System.EventHandler(this.Form_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriceXpath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaximumPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesiredPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnNew;
    }
}

