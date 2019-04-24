namespace GUI_Products {
  partial class Produits {
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
      this.title = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
      this.SuspendLayout();
      // 
      // title
      // 
      this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.title.Location = new System.Drawing.Point(454, 38);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(114, 25);
      this.title.TabIndex = 0;
      this.title.Text = "PRODUITS";
      // 
      // btnSave
      // 
      this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
      this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSave.FlatAppearance.BorderSize = 0;
      this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.White;
      this.btnSave.Image = global::GUI_Products.Properties.Resources.producto;
      this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnSave.Location = new System.Drawing.Point(397, 516);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(250, 40);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Enregistrer";
      this.btnSave.UseVisualStyleBackColor = false;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClose.Image = global::GUI_Products.Properties.Resources.icon_cerrar2;
      this.btnClose.Location = new System.Drawing.Point(991, 38);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(20, 20);
      this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.btnClose.TabIndex = 3;
      this.btnClose.TabStop = false;
      this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // Produits
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(1050, 600);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.title);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Produits";
      this.Text = "Produits";
      ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label title;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.PictureBox btnClose;
  }
}