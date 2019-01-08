namespace MartManagementSystem
{
    partial class tabProduct
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabProduct));
            this.panelShow = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnEditProduct = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDeleteProduct = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnSearchProduct = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShow.BackgroundImage")));
            this.panelShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.GradientBottomLeft = System.Drawing.Color.White;
            this.panelShow.GradientBottomRight = System.Drawing.Color.White;
            this.panelShow.GradientTopLeft = System.Drawing.Color.White;
            this.panelShow.GradientTopRight = System.Drawing.Color.White;
            this.panelShow.Location = new System.Drawing.Point(0, 118);
            this.panelShow.Name = "panelShow";
            this.panelShow.Quality = 10;
            this.panelShow.Size = new System.Drawing.Size(646, 538);
            this.panelShow.TabIndex = 6;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelMenu;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(646, 118);
            this.panelMenu.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.color = System.Drawing.Color.SeaGreen;
            this.btnAddProduct.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImagePosition = 0;
            this.btnAddProduct.ImageZoom = 0;
            this.btnAddProduct.LabelPosition = 34;
            this.btnAddProduct.LabelText = "Add";
            this.btnAddProduct.Location = new System.Drawing.Point(101, 39);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(88, 45);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEditProduct.color = System.Drawing.Color.SeaGreen;
            this.btnEditProduct.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Image")));
            this.btnEditProduct.ImagePosition = 0;
            this.btnEditProduct.ImageZoom = 0;
            this.btnEditProduct.LabelPosition = 34;
            this.btnEditProduct.LabelText = "Edit";
            this.btnEditProduct.Location = new System.Drawing.Point(211, 39);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(88, 45);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteProduct.color = System.Drawing.Color.SeaGreen;
            this.btnDeleteProduct.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImagePosition = 0;
            this.btnDeleteProduct.ImageZoom = 0;
            this.btnDeleteProduct.LabelPosition = 34;
            this.btnDeleteProduct.LabelText = "Delete";
            this.btnDeleteProduct.Location = new System.Drawing.Point(321, 39);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(88, 45);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSearchProduct.color = System.Drawing.Color.SeaGreen;
            this.btnSearchProduct.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.Image")));
            this.btnSearchProduct.ImagePosition = 0;
            this.btnSearchProduct.ImageZoom = 0;
            this.btnSearchProduct.LabelPosition = 34;
            this.btnSearchProduct.LabelText = "Search";
            this.btnSearchProduct.Location = new System.Drawing.Point(431, 39);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(88, 45);
            this.btnSearchProduct.TabIndex = 5;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // tabProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.panelMenu);
            this.Name = "tabProduct";
            this.Size = new System.Drawing.Size(646, 656);
            this.Load += new System.EventHandler(this.tabProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel panelShow;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton btnSearchProduct;
        private Bunifu.Framework.UI.BunifuTileButton btnDeleteProduct;
        private Bunifu.Framework.UI.BunifuTileButton btnEditProduct;
        private Bunifu.Framework.UI.BunifuTileButton btnAddProduct;
        private System.Windows.Forms.Panel panelMenu;
    }
}
