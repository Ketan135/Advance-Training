namespace WindowsFormsApp2
{
    partial class Product
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
            this.showbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.binarywritebutton = new System.Windows.Forms.Button();
            this.binaryreadbutton = new System.Windows.Forms.Button();
            this.xmlwritebutton = new System.Windows.Forms.Button();
            this.xmlreadbutton = new System.Windows.Forms.Button();
            this.soapwritebutton = new System.Windows.Forms.Button();
            this.soapreadbutton = new System.Windows.Forms.Button();
            this.jsonwritebutton = new System.Windows.Forms.Button();
            this.jsonreadbutton = new System.Windows.Forms.Button();
            this.idlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nameetextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.categorytextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(246, 288);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 0;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(392, 288);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 1;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // binarywritebutton
            // 
            this.binarywritebutton.Location = new System.Drawing.Point(640, 38);
            this.binarywritebutton.Name = "binarywritebutton";
            this.binarywritebutton.Size = new System.Drawing.Size(97, 23);
            this.binarywritebutton.TabIndex = 2;
            this.binarywritebutton.Text = "Binary Write";
            this.binarywritebutton.UseVisualStyleBackColor = true;
            this.binarywritebutton.Click += new System.EventHandler(this.binarywritebutton_Click);
            // 
            // binaryreadbutton
            // 
            this.binaryreadbutton.Location = new System.Drawing.Point(640, 67);
            this.binaryreadbutton.Name = "binaryreadbutton";
            this.binaryreadbutton.Size = new System.Drawing.Size(97, 23);
            this.binaryreadbutton.TabIndex = 3;
            this.binaryreadbutton.Text = "Binary Read";
            this.binaryreadbutton.UseVisualStyleBackColor = true;
            this.binaryreadbutton.Click += new System.EventHandler(this.binaryreadbutton_Click);
            // 
            // xmlwritebutton
            // 
            this.xmlwritebutton.Location = new System.Drawing.Point(640, 109);
            this.xmlwritebutton.Name = "xmlwritebutton";
            this.xmlwritebutton.Size = new System.Drawing.Size(97, 23);
            this.xmlwritebutton.TabIndex = 4;
            this.xmlwritebutton.Text = "XML Write";
            this.xmlwritebutton.UseVisualStyleBackColor = true;
            this.xmlwritebutton.Click += new System.EventHandler(this.xmlwritebutton_Click);
            // 
            // xmlreadbutton
            // 
            this.xmlreadbutton.Location = new System.Drawing.Point(640, 138);
            this.xmlreadbutton.Name = "xmlreadbutton";
            this.xmlreadbutton.Size = new System.Drawing.Size(97, 23);
            this.xmlreadbutton.TabIndex = 5;
            this.xmlreadbutton.Text = "XML Read";
            this.xmlreadbutton.UseVisualStyleBackColor = true;
            this.xmlreadbutton.Click += new System.EventHandler(this.xmlreadbutton_Click);
            // 
            // soapwritebutton
            // 
            this.soapwritebutton.Location = new System.Drawing.Point(640, 183);
            this.soapwritebutton.Name = "soapwritebutton";
            this.soapwritebutton.Size = new System.Drawing.Size(97, 23);
            this.soapwritebutton.TabIndex = 6;
            this.soapwritebutton.Text = "SOAP Write";
            this.soapwritebutton.UseVisualStyleBackColor = true;
            this.soapwritebutton.Click += new System.EventHandler(this.soapwritebutton_Click);
            // 
            // soapreadbutton
            // 
            this.soapreadbutton.Location = new System.Drawing.Point(640, 212);
            this.soapreadbutton.Name = "soapreadbutton";
            this.soapreadbutton.Size = new System.Drawing.Size(97, 23);
            this.soapreadbutton.TabIndex = 7;
            this.soapreadbutton.Text = "SOAP Read";
            this.soapreadbutton.UseVisualStyleBackColor = true;
            this.soapreadbutton.Click += new System.EventHandler(this.soapreadbutton_Click);
            // 
            // jsonwritebutton
            // 
            this.jsonwritebutton.Location = new System.Drawing.Point(640, 259);
            this.jsonwritebutton.Name = "jsonwritebutton";
            this.jsonwritebutton.Size = new System.Drawing.Size(97, 23);
            this.jsonwritebutton.TabIndex = 8;
            this.jsonwritebutton.Text = "JSON Write";
            this.jsonwritebutton.UseVisualStyleBackColor = true;
            this.jsonwritebutton.Click += new System.EventHandler(this.jsonwritebutton_Click);
            // 
            // jsonreadbutton
            // 
            this.jsonreadbutton.Location = new System.Drawing.Point(640, 288);
            this.jsonreadbutton.Name = "jsonreadbutton";
            this.jsonreadbutton.Size = new System.Drawing.Size(97, 23);
            this.jsonreadbutton.TabIndex = 9;
            this.jsonreadbutton.Text = "JSON Read";
            this.jsonreadbutton.UseVisualStyleBackColor = true;
            this.jsonreadbutton.Click += new System.EventHandler(this.jsonreadbutton_Click);
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(243, 67);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(67, 16);
            this.idlabel.TabIndex = 10;
            this.idlabel.Text = "Product Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(243, 116);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(93, 16);
            this.namelabel.TabIndex = 11;
            this.namelabel.Text = "Product Name";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(243, 165);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(87, 16);
            this.pricelabel.TabIndex = 12;
            this.pricelabel.Text = "Product Price";
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(243, 219);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(62, 16);
            this.Categorylabel.TabIndex = 13;
            this.Categorylabel.Text = "Category";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(367, 61);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 14;
            // 
            // nameetextBox
            // 
            this.nameetextBox.Location = new System.Drawing.Point(367, 110);
            this.nameetextBox.Name = "nameetextBox";
            this.nameetextBox.Size = new System.Drawing.Size(100, 22);
            this.nameetextBox.TabIndex = 15;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(367, 159);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 22);
            this.pricetextBox.TabIndex = 16;
            // 
            // categorytextBox
            // 
            this.categorytextBox.Location = new System.Drawing.Point(367, 216);
            this.categorytextBox.Name = "categorytextBox";
            this.categorytextBox.Size = new System.Drawing.Size(100, 22);
            this.categorytextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 18;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categorytextBox);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.nameetextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.Categorylabel);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.jsonreadbutton);
            this.Controls.Add(this.jsonwritebutton);
            this.Controls.Add(this.soapreadbutton);
            this.Controls.Add(this.soapwritebutton);
            this.Controls.Add(this.xmlreadbutton);
            this.Controls.Add(this.xmlwritebutton);
            this.Controls.Add(this.binaryreadbutton);
            this.Controls.Add(this.binarywritebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.showbutton);
            this.Name = "Product";
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button binarywritebutton;
        private System.Windows.Forms.Button binaryreadbutton;
        private System.Windows.Forms.Button xmlwritebutton;
        private System.Windows.Forms.Button xmlreadbutton;
        private System.Windows.Forms.Button soapwritebutton;
        private System.Windows.Forms.Button soapreadbutton;
        private System.Windows.Forms.Button jsonwritebutton;
        private System.Windows.Forms.Button jsonreadbutton;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox nameetextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.TextBox categorytextBox;
        private System.Windows.Forms.Label label1;
    }
}