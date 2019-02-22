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
            this.btnSearchProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelShow.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelShow.BackgroundImage")));
            this.panelShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShow.Controls.Add(this.btnDeleteProduct);
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
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelMenu.Controls.Add(this.btnSearchProduct);
            this.panelMenu.Controls.Add(this.btnAddProduct);
            this.panelMenu.Controls.Add(this.btnEditProduct);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(646, 118);
            this.panelMenu.TabIndex = 7;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.btnSearchProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchProduct.BorderRadius = 0;
            this.btnSearchProduct.ButtonText = "     Search";
            this.btnSearchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.Iconimage")));
            this.btnSearchProduct.Iconimage_right = null;
            this.btnSearchProduct.Iconimage_right_Selected = null;
            this.btnSearchProduct.Iconimage_Selected = null;
            this.btnSearchProduct.IconMarginLeft = 0;
            this.btnSearchProduct.IconMarginRight = 0;
            this.btnSearchProduct.IconRightVisible = true;
            this.btnSearchProduct.IconRightZoom = 0D;
            this.btnSearchProduct.IconVisible = true;
            this.btnSearchProduct.IconZoom = 50D;
            this.btnSearchProduct.IsTab = false;
            this.btnSearchProduct.Location = new System.Drawing.Point(463, 39);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(103)))), ((int)(((byte)(214)))));
            this.btnSearchProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(170)))), ((int)(((byte)(242)))));
            this.btnSearchProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchProduct.selected = false;
            this.btnSearchProduct.Size = new System.Drawing.Size(116, 48);
            this.btnSearchProduct.TabIndex = 7;
            this.btnSearchProduct.Text = "     Search";
            this.btnSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchProduct.Textcolor = System.Drawing.Color.White;
            this.btnSearchProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.BorderRadius = 0;
            this.btnAddProduct.ButtonText = "      Add";
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Iconimage")));
            this.btnAddProduct.Iconimage_right = null;
            this.btnAddProduct.Iconimage_right_Selected = null;
            this.btnAddProduct.Iconimage_Selected = null;
            this.btnAddProduct.IconMarginLeft = 0;
            this.btnAddProduct.IconMarginRight = 0;
            this.btnAddProduct.IconRightVisible = true;
            this.btnAddProduct.IconRightZoom = 0D;
            this.btnAddProduct.IconVisible = true;
            this.btnAddProduct.IconZoom = 50D;
            this.btnAddProduct.IsTab = false;
            this.btnAddProduct.Location = new System.Drawing.Point(58, 39);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.btnAddProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(227)))), ((int)(((byte)(116)))));
            this.btnAddProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProduct.selected = false;
            this.btnAddProduct.Size = new System.Drawing.Size(116, 48);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "      Add";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProduct.Textcolor = System.Drawing.Color.White;
            this.btnAddProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.btnEditProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditProduct.BorderRadius = 0;
            this.btnEditProduct.ButtonText = "      Edit";
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditProduct.Iconimage")));
            this.btnEditProduct.Iconimage_right = null;
            this.btnEditProduct.Iconimage_right_Selected = null;
            this.btnEditProduct.Iconimage_Selected = null;
            this.btnEditProduct.IconMarginLeft = 0;
            this.btnEditProduct.IconMarginRight = 0;
            this.btnEditProduct.IconRightVisible = true;
            this.btnEditProduct.IconRightZoom = 0D;
            this.btnEditProduct.IconVisible = true;
            this.btnEditProduct.IconZoom = 50D;
            this.btnEditProduct.IsTab = false;
            this.btnEditProduct.Location = new System.Drawing.Point(257, 39);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.btnEditProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(166)))), ((int)(((byte)(157)))));
            this.btnEditProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditProduct.selected = false;
            this.btnEditProduct.Size = new System.Drawing.Size(116, 48);
            this.btnEditProduct.TabIndex = 5;
            this.btnEditProduct.Text = "      Edit";
            this.btnEditProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditProduct.Textcolor = System.Drawing.Color.White;
            this.btnEditProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.btnDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteProduct.BorderRadius = 0;
            this.btnDeleteProduct.ButtonText = "      Delete";
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Iconimage")));
            this.btnDeleteProduct.Iconimage_right = null;
            this.btnDeleteProduct.Iconimage_right_Selected = null;
            this.btnDeleteProduct.Iconimage_Selected = null;
            this.btnDeleteProduct.IconMarginLeft = 0;
            this.btnDeleteProduct.IconMarginRight = 0;
            this.btnDeleteProduct.IconRightVisible = true;
            this.btnDeleteProduct.IconRightZoom = 0D;
            this.btnDeleteProduct.IconVisible = true;
            this.btnDeleteProduct.IconZoom = 50D;
            this.btnDeleteProduct.IsTab = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(530, 442);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
            this.btnDeleteProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnDeleteProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteProduct.selected = false;
            this.btnDeleteProduct.Size = new System.Drawing.Size(116, 48);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "      Delete";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteProduct.Textcolor = System.Drawing.Color.White;
            this.btnDeleteProduct.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.Visible = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // tabProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelMenu);
            this.Name = "tabProduct";
            this.Size = new System.Drawing.Size(646, 656);
            this.Load += new System.EventHandler(this.tabProduct_Load);
            this.panelShow.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel panelShow;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditProduct;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteProduct;
    }
}
