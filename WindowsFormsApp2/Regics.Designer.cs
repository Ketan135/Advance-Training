namespace WindowsFormsApp2
{
    partial class Regics
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
            this.writebutton = new System.Windows.Forms.Button();
            this.readbutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.contactlabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.contacttextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.xmlwritebutton = new System.Windows.Forms.Button();
            this.xmlreadbutton = new System.Windows.Forms.Button();
            this.soapwritebutton = new System.Windows.Forms.Button();
            this.soapreadbutton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(273, 335);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 0;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(421, 335);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 1;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // writebutton
            // 
            this.writebutton.Location = new System.Drawing.Point(603, 77);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(75, 23);
            this.writebutton.TabIndex = 2;
            this.writebutton.Text = "Write";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(603, 152);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(75, 23);
            this.readbutton.TabIndex = 3;
            this.readbutton.Text = "Read";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(281, 66);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(44, 16);
            this.namelabel.TabIndex = 4;
            this.namelabel.Text = "Name";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(281, 131);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(55, 16);
            this.emaillabel.TabIndex = 5;
            this.emaillabel.Text = "Email Id";
            // 
            // contactlabel
            // 
            this.contactlabel.AutoSize = true;
            this.contactlabel.Location = new System.Drawing.Point(281, 190);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(73, 16);
            this.contactlabel.TabIndex = 6;
            this.contactlabel.Text = "Contact No";
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Location = new System.Drawing.Point(281, 248);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(58, 16);
            this.addresslabel.TabIndex = 7;
            this.addresslabel.Text = "Address";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(362, 60);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 8;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(362, 125);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(100, 22);
            this.emailtextBox.TabIndex = 9;
            // 
            // contacttextBox
            // 
            this.contacttextBox.Location = new System.Drawing.Point(362, 184);
            this.contacttextBox.Name = "contacttextBox";
            this.contacttextBox.Size = new System.Drawing.Size(100, 22);
            this.contacttextBox.TabIndex = 10;
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(362, 242);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(100, 22);
            this.addresstextBox.TabIndex = 11;
            // 
            // xmlwritebutton
            // 
            this.xmlwritebutton.Location = new System.Drawing.Point(603, 204);
            this.xmlwritebutton.Name = "xmlwritebutton";
            this.xmlwritebutton.Size = new System.Drawing.Size(75, 23);
            this.xmlwritebutton.TabIndex = 12;
            this.xmlwritebutton.Text = "XML Write";
            this.xmlwritebutton.UseVisualStyleBackColor = true;
            this.xmlwritebutton.Click += new System.EventHandler(this.xmlwritebutton_Click);
            // 
            // xmlreadbutton
            // 
            this.xmlreadbutton.Location = new System.Drawing.Point(603, 269);
            this.xmlreadbutton.Name = "xmlreadbutton";
            this.xmlreadbutton.Size = new System.Drawing.Size(105, 23);
            this.xmlreadbutton.TabIndex = 13;
            this.xmlreadbutton.Text = "XML Read";
            this.xmlreadbutton.UseVisualStyleBackColor = true;
            this.xmlreadbutton.Click += new System.EventHandler(this.xmlreadbutton_Click);
            // 
            // soapwritebutton
            // 
            this.soapwritebutton.Location = new System.Drawing.Point(633, 312);
            this.soapwritebutton.Name = "soapwritebutton";
            this.soapwritebutton.Size = new System.Drawing.Size(75, 23);
            this.soapwritebutton.TabIndex = 14;
            this.soapwritebutton.Text = "SOAP Write";
            this.soapwritebutton.UseVisualStyleBackColor = true;
            this.soapwritebutton.Click += new System.EventHandler(this.soapwritebutton_Click);
            // 
            // soapreadbutton
            // 
            this.soapreadbutton.Location = new System.Drawing.Point(633, 372);
            this.soapreadbutton.Name = "soapreadbutton";
            this.soapreadbutton.Size = new System.Drawing.Size(75, 23);
            this.soapreadbutton.TabIndex = 15;
            this.soapreadbutton.Text = "SOAP Read";
            this.soapreadbutton.UseVisualStyleBackColor = true;
            this.soapreadbutton.Click += new System.EventHandler(this.soapreadbutton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(398, 398);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 16);
            this.label.TabIndex = 16;
            // 
            // Regics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.soapreadbutton);
            this.Controls.Add(this.soapwritebutton);
            this.Controls.Add(this.xmlreadbutton);
            this.Controls.Add(this.xmlwritebutton);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.contacttextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.contactlabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.writebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.showbutton);
            this.Name = "Regics";
            this.Text = "Regics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label contactlabel;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox contacttextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Button xmlwritebutton;
        private System.Windows.Forms.Button xmlreadbutton;
        private System.Windows.Forms.Button soapwritebutton;
        private System.Windows.Forms.Button soapreadbutton;
        private System.Windows.Forms.Label label;
    }
}