namespace MartManagementSystem
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProduct = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddStock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelShow = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnExit);
            this.bunifuGradientPanel1.Controls.Add(this.btnSale);
            this.bunifuGradientPanel1.Controls.Add(this.btnProduct);
            this.bunifuGradientPanel1.Controls.Add(this.btnAddStock);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SlateBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.BlueViolet;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Azure;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(266, 656);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 0;
            this.btnExit.ButtonText = "              Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Gray;
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExit.Iconimage")));
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = false;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = false;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = true;
            this.btnExit.Location = new System.Drawing.Point(0, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnExit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(266, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "              Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnExit.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSale
            // 
            this.btnSale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSale.BackColor = System.Drawing.Color.Transparent;
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSale.BorderRadius = 0;
            this.btnSale.ButtonText = "              Sale";
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.DisabledColor = System.Drawing.Color.Gray;
            this.btnSale.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSale.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSale.Iconimage")));
            this.btnSale.Iconimage_right = null;
            this.btnSale.Iconimage_right_Selected = null;
            this.btnSale.Iconimage_Selected = null;
            this.btnSale.IconMarginLeft = 0;
            this.btnSale.IconMarginRight = 0;
            this.btnSale.IconRightVisible = false;
            this.btnSale.IconRightZoom = 0D;
            this.btnSale.IconVisible = false;
            this.btnSale.IconZoom = 90D;
            this.btnSale.IsTab = true;
            this.btnSale.Location = new System.Drawing.Point(0, 264);
            this.btnSale.Name = "btnSale";
            this.btnSale.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnSale.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSale.selected = false;
            this.btnSale.Size = new System.Drawing.Size(266, 48);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "              Sale";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnSale.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.BorderRadius = 0;
            this.btnProduct.ButtonText = "              Product";
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.DisabledColor = System.Drawing.Color.Gray;
            this.btnProduct.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProduct.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProduct.Iconimage")));
            this.btnProduct.Iconimage_right = null;
            this.btnProduct.Iconimage_right_Selected = null;
            this.btnProduct.Iconimage_Selected = null;
            this.btnProduct.IconMarginLeft = 0;
            this.btnProduct.IconMarginRight = 0;
            this.btnProduct.IconRightVisible = false;
            this.btnProduct.IconRightZoom = 0D;
            this.btnProduct.IconVisible = false;
            this.btnProduct.IconZoom = 90D;
            this.btnProduct.IsTab = true;
            this.btnProduct.Location = new System.Drawing.Point(0, 210);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProduct.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnProduct.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProduct.selected = false;
            this.btnProduct.Size = new System.Drawing.Size(266, 48);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "              Product";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnProduct.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnAddStock.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStock.BorderRadius = 0;
            this.btnAddStock.ButtonText = "              Add Stock";
            this.btnAddStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStock.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddStock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddStock.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddStock.Iconimage")));
            this.btnAddStock.Iconimage_right = null;
            this.btnAddStock.Iconimage_right_Selected = null;
            this.btnAddStock.Iconimage_Selected = null;
            this.btnAddStock.IconMarginLeft = 0;
            this.btnAddStock.IconMarginRight = 0;
            this.btnAddStock.IconRightVisible = false;
            this.btnAddStock.IconRightZoom = 0D;
            this.btnAddStock.IconVisible = false;
            this.btnAddStock.IconZoom = 90D;
            this.btnAddStock.IsTab = true;
            this.btnAddStock.Location = new System.Drawing.Point(0, 156);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddStock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(36)))), ((int)(((byte)(95)))));
            this.btnAddStock.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddStock.selected = true;
            this.btnAddStock.Size = new System.Drawing.Size(266, 48);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "              Add Stock";
            this.btnAddStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStock.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.btnAddStock.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // panelShow
            // 
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(266, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(646, 656);
            this.panelShow.TabIndex = 1;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelShow;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(912, 656);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddStock;
        private Bunifu.Framework.UI.BunifuFlatButton btnSale;
        private Bunifu.Framework.UI.BunifuFlatButton btnProduct;
        private System.Windows.Forms.Panel panelShow;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

