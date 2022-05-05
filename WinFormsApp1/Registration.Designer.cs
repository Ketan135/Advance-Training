namespace WinFormsApp1
{
    partial class Registration
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
            this.Namelabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Contactlabel = new System.Windows.Forms.Label();
            this.Addresslabel = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.Showbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(242, 68);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(49, 20);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(242, 116);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(63, 20);
            this.Emaillabel.TabIndex = 1;
            this.Emaillabel.Text = "Email Id";
            // 
            // Contactlabel
            // 
            this.Contactlabel.AutoSize = true;
            this.Contactlabel.Location = new System.Drawing.Point(242, 167);
            this.Contactlabel.Name = "Contactlabel";
            this.Contactlabel.Size = new System.Drawing.Size(84, 20);
            this.Contactlabel.TabIndex = 2;
            this.Contactlabel.Text = "Contact No";
            // 
            // Addresslabel
            // 
            this.Addresslabel.AutoSize = true;
            this.Addresslabel.Location = new System.Drawing.Point(242, 214);
            this.Addresslabel.Name = "Addresslabel";
            this.Addresslabel.Size = new System.Drawing.Size(62, 20);
            this.Addresslabel.TabIndex = 3;
            this.Addresslabel.Text = "Address";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(353, 68);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(125, 27);
            this.NametextBox.TabIndex = 4;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(353, 113);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(125, 27);
            this.EmailtextBox.TabIndex = 5;
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Location = new System.Drawing.Point(353, 160);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(125, 27);
            this.ContacttextBox.TabIndex = 6;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(353, 207);
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(125, 27);
            this.AddresstextBox.TabIndex = 7;
            // 
            // Showbutton
            // 
            this.Showbutton.Location = new System.Drawing.Point(292, 277);
            this.Showbutton.Name = "Showbutton";
            this.Showbutton.Size = new System.Drawing.Size(94, 29);
            this.Showbutton.TabIndex = 8;
            this.Showbutton.Text = "Show";
            this.Showbutton.UseVisualStyleBackColor = true;
            this.Showbutton.Click += new System.EventHandler(this.Showbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(444, 277);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(94, 29);
            this.Clearbutton.TabIndex = 9;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(387, 349);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 10;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Showbutton);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.ContacttextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.Addresslabel);
            this.Controls.Add(this.Contactlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Namelabel);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Namelabel;
        private Label Emaillabel;
        private Label Contactlabel;
        private Label Addresslabel;
        private TextBox NametextBox;
        private TextBox EmailtextBox;
        private TextBox ContacttextBox;
        private TextBox AddresstextBox;
        private Button Showbutton;
        private Button Clearbutton;
        private Label lblOutput;
    }
}