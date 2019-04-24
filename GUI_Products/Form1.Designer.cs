namespace GUI_Products {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.MenuVertical = new System.Windows.Forms.Panel();
      this.BarreTitle = new System.Windows.Forms.Panel();
      this.panelContent = new System.Windows.Forms.Panel();
      this.iconMaximize = new System.Windows.Forms.PictureBox();
      this.iconRestore = new System.Windows.Forms.PictureBox();
      this.iconMinimize = new System.Windows.Forms.PictureBox();
      this.iconClose = new System.Windows.Forms.PictureBox();
      this.btnSlide = new System.Windows.Forms.PictureBox();
      this.button6 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.btnProd = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.MenuVertical.SuspendLayout();
      this.BarreTitle.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // MenuVertical
      // 
      this.MenuVertical.BackColor = System.Drawing.SystemColors.MenuHighlight;
      this.MenuVertical.Controls.Add(this.button6);
      this.MenuVertical.Controls.Add(this.button5);
      this.MenuVertical.Controls.Add(this.button4);
      this.MenuVertical.Controls.Add(this.button3);
      this.MenuVertical.Controls.Add(this.button2);
      this.MenuVertical.Controls.Add(this.btnProd);
      this.MenuVertical.Controls.Add(this.pictureBox1);
      this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
      this.MenuVertical.Location = new System.Drawing.Point(0, 0);
      this.MenuVertical.Name = "MenuVertical";
      this.MenuVertical.Size = new System.Drawing.Size(250, 650);
      this.MenuVertical.TabIndex = 0;
      // 
      // BarreTitle
      // 
      this.BarreTitle.BackColor = System.Drawing.Color.WhiteSmoke;
      this.BarreTitle.Controls.Add(this.iconMaximize);
      this.BarreTitle.Controls.Add(this.iconRestore);
      this.BarreTitle.Controls.Add(this.iconMinimize);
      this.BarreTitle.Controls.Add(this.iconClose);
      this.BarreTitle.Controls.Add(this.btnSlide);
      this.BarreTitle.Dock = System.Windows.Forms.DockStyle.Top;
      this.BarreTitle.Location = new System.Drawing.Point(250, 0);
      this.BarreTitle.Name = "BarreTitle";
      this.BarreTitle.Size = new System.Drawing.Size(1050, 50);
      this.BarreTitle.TabIndex = 1;
      this.BarreTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarreTitle_MouseDown);
      // 
      // panelContent
      // 
      this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
      this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelContent.Location = new System.Drawing.Point(250, 50);
      this.panelContent.Name = "panelContent";
      this.panelContent.Size = new System.Drawing.Size(1050, 600);
      this.panelContent.TabIndex = 2;
      // 
      // iconMaximize
      // 
      this.iconMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.iconMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
      this.iconMaximize.Image = global::GUI_Products.Properties.Resources.icon_maximizar;
      this.iconMaximize.Location = new System.Drawing.Point(990, 13);
      this.iconMaximize.Name = "iconMaximize";
      this.iconMaximize.Size = new System.Drawing.Size(20, 20);
      this.iconMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.iconMaximize.TabIndex = 4;
      this.iconMaximize.TabStop = false;
      this.iconMaximize.Click += new System.EventHandler(this.iconMaximize_Click);
      // 
      // iconRestore
      // 
      this.iconRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.iconRestore.Cursor = System.Windows.Forms.Cursors.Hand;
      this.iconRestore.Image = global::GUI_Products.Properties.Resources.icon_restaurar;
      this.iconRestore.Location = new System.Drawing.Point(990, 12);
      this.iconRestore.Name = "iconRestore";
      this.iconRestore.Size = new System.Drawing.Size(20, 20);
      this.iconRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.iconRestore.TabIndex = 3;
      this.iconRestore.TabStop = false;
      this.iconRestore.Visible = false;
      this.iconRestore.Click += new System.EventHandler(this.iconRestore_Click);
      // 
      // iconMinimize
      // 
      this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
      this.iconMinimize.Image = global::GUI_Products.Properties.Resources.icon_minimizar;
      this.iconMinimize.Location = new System.Drawing.Point(964, 12);
      this.iconMinimize.Name = "iconMinimize";
      this.iconMinimize.Size = new System.Drawing.Size(20, 20);
      this.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.iconMinimize.TabIndex = 2;
      this.iconMinimize.TabStop = false;
      this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
      // 
      // iconClose
      // 
      this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.iconClose.Image = global::GUI_Products.Properties.Resources.icon_cerrar2;
      this.iconClose.Location = new System.Drawing.Point(1016, 13);
      this.iconClose.Name = "iconClose";
      this.iconClose.Size = new System.Drawing.Size(20, 20);
      this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.iconClose.TabIndex = 1;
      this.iconClose.TabStop = false;
      this.iconClose.Click += new System.EventHandler(this.IconClose_Click);
      // 
      // btnSlide
      // 
      this.btnSlide.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSlide.Image = global::GUI_Products.Properties.Resources.Mobile_Menu_Icon;
      this.btnSlide.Location = new System.Drawing.Point(6, 9);
      this.btnSlide.Name = "btnSlide";
      this.btnSlide.Size = new System.Drawing.Size(35, 35);
      this.btnSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.btnSlide.TabIndex = 0;
      this.btnSlide.TabStop = false;
      this.btnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
      // 
      // button6
      // 
      this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button6.FlatAppearance.BorderSize = 0;
      this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button6.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button6.ForeColor = System.Drawing.Color.White;
      this.button6.Image = global::GUI_Products.Properties.Resources.empleados;
      this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button6.Location = new System.Drawing.Point(0, 330);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(250, 40);
      this.button6.TabIndex = 6;
      this.button6.Text = "Paiments";
      this.button6.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button5.ForeColor = System.Drawing.Color.White;
      this.button5.Image = global::GUI_Products.Properties.Resources.pagos;
      this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button5.Location = new System.Drawing.Point(0, 284);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(250, 40);
      this.button5.TabIndex = 5;
      this.button5.Text = "Panier";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.ForeColor = System.Drawing.Color.White;
      this.button4.Image = global::GUI_Products.Properties.Resources.compras;
      this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button4.Location = new System.Drawing.Point(0, 238);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(250, 40);
      this.button4.TabIndex = 4;
      this.button4.Text = "Fournisseurs";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.ForeColor = System.Drawing.Color.White;
      this.button3.Image = global::GUI_Products.Properties.Resources.clientes;
      this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button3.Location = new System.Drawing.Point(1, 192);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(250, 40);
      this.button3.TabIndex = 3;
      this.button3.Text = "Clients";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.ForeColor = System.Drawing.Color.White;
      this.button2.Image = global::GUI_Products.Properties.Resources.venta;
      this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.button2.Location = new System.Drawing.Point(0, 146);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(250, 40);
      this.button2.TabIndex = 2;
      this.button2.Text = "Ventes";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // btnProd
      // 
      this.btnProd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnProd.FlatAppearance.BorderSize = 0;
      this.btnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnProd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnProd.ForeColor = System.Drawing.Color.White;
      this.btnProd.Image = global::GUI_Products.Properties.Resources.producto;
      this.btnProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnProd.Location = new System.Drawing.Point(1, 100);
      this.btnProd.Name = "btnProd";
      this.btnProd.Size = new System.Drawing.Size(250, 40);
      this.btnProd.TabIndex = 1;
      this.btnProd.Text = "Produits";
      this.btnProd.UseVisualStyleBackColor = true;
      this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::GUI_Products.Properties.Resources.IMO2;
      this.pictureBox1.Location = new System.Drawing.Point(5, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(256, 47);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1300, 650);
      this.Controls.Add(this.panelContent);
      this.Controls.Add(this.BarreTitle);
      this.Controls.Add(this.MenuVertical);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.Text = "Form1";
      this.MenuVertical.ResumeLayout(false);
      this.BarreTitle.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.iconMaximize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconRestore)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconMinimize)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btnSlide)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel MenuVertical;
    private System.Windows.Forms.Panel BarreTitle;
    private System.Windows.Forms.PictureBox btnSlide;
    private System.Windows.Forms.Panel panelContent;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox iconClose;
    private System.Windows.Forms.PictureBox iconMinimize;
    private System.Windows.Forms.PictureBox iconRestore;
    private System.Windows.Forms.PictureBox iconMaximize;
    private System.Windows.Forms.Button btnProd;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
  }
}

