namespace WinFormsApp1
{
    partial class Studentinfo
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
            this.rollnolabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.perrcentagelabel = new System.Windows.Forms.Label();
            this.streamlabel = new System.Windows.Forms.Label();
            this.citylabel = new System.Windows.Forms.Label();
            this.rollnotextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.percentagetextBox = new System.Windows.Forms.TextBox();
            this.streamtextBox = new System.Windows.Forms.TextBox();
            this.citytextBox = new System.Windows.Forms.TextBox();
            this.writetofilebutton = new System.Windows.Forms.Button();
            this.readfromfilebutton = new System.Windows.Forms.Button();
            this.createfolderbutton = new System.Windows.Forms.Button();
            this.ceatefilebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rollnolabel
            // 
            this.rollnolabel.AutoSize = true;
            this.rollnolabel.Location = new System.Drawing.Point(194, 49);
            this.rollnolabel.Name = "rollnolabel";
            this.rollnolabel.Size = new System.Drawing.Size(59, 20);
            this.rollnolabel.TabIndex = 0;
            this.rollnolabel.Text = "Roll No";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(194, 105);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(49, 20);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Name";
            // 
            // perrcentagelabel
            // 
            this.perrcentagelabel.AutoSize = true;
            this.perrcentagelabel.Location = new System.Drawing.Point(194, 167);
            this.perrcentagelabel.Name = "perrcentagelabel";
            this.perrcentagelabel.Size = new System.Drawing.Size(82, 20);
            this.perrcentagelabel.TabIndex = 2;
            this.perrcentagelabel.Text = "Percentage";
            // 
            // streamlabel
            // 
            this.streamlabel.AutoSize = true;
            this.streamlabel.Location = new System.Drawing.Point(194, 225);
            this.streamlabel.Name = "streamlabel";
            this.streamlabel.Size = new System.Drawing.Size(56, 20);
            this.streamlabel.TabIndex = 3;
            this.streamlabel.Text = "Stream";
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.Location = new System.Drawing.Point(194, 288);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(34, 20);
            this.citylabel.TabIndex = 4;
            this.citylabel.Text = "City";
            // 
            // rollnotextBox
            // 
            this.rollnotextBox.Location = new System.Drawing.Point(312, 46);
            this.rollnotextBox.Name = "rollnotextBox";
            this.rollnotextBox.Size = new System.Drawing.Size(125, 27);
            this.rollnotextBox.TabIndex = 5;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(312, 98);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(125, 27);
            this.nametextBox.TabIndex = 6;
            // 
            // percentagetextBox
            // 
            this.percentagetextBox.Location = new System.Drawing.Point(312, 160);
            this.percentagetextBox.Name = "percentagetextBox";
            this.percentagetextBox.Size = new System.Drawing.Size(125, 27);
            this.percentagetextBox.TabIndex = 7;
            // 
            // streamtextBox
            // 
            this.streamtextBox.Location = new System.Drawing.Point(312, 218);
            this.streamtextBox.Name = "streamtextBox";
            this.streamtextBox.Size = new System.Drawing.Size(125, 27);
            this.streamtextBox.TabIndex = 8;
            // 
            // citytextBox
            // 
            this.citytextBox.Location = new System.Drawing.Point(312, 281);
            this.citytextBox.Name = "citytextBox";
            this.citytextBox.Size = new System.Drawing.Size(125, 27);
            this.citytextBox.TabIndex = 9;
            // 
            // writetofilebutton
            // 
            this.writetofilebutton.Location = new System.Drawing.Point(194, 324);
            this.writetofilebutton.Name = "writetofilebutton";
            this.writetofilebutton.Size = new System.Drawing.Size(119, 29);
            this.writetofilebutton.TabIndex = 10;
            this.writetofilebutton.Text = "Write To File";
            this.writetofilebutton.UseVisualStyleBackColor = true;
            this.writetofilebutton.Click += new System.EventHandler(this.writetofilebutton_Click);
            // 
            // readfromfilebutton
            // 
            this.readfromfilebutton.Location = new System.Drawing.Point(378, 324);
            this.readfromfilebutton.Name = "readfromfilebutton";
            this.readfromfilebutton.Size = new System.Drawing.Size(121, 29);
            this.readfromfilebutton.TabIndex = 11;
            this.readfromfilebutton.Text = "Read From File";
            this.readfromfilebutton.UseVisualStyleBackColor = true;
            this.readfromfilebutton.Click += new System.EventHandler(this.readfromfilebutton_Click);
            // 
            // createfolderbutton
            // 
            this.createfolderbutton.Location = new System.Drawing.Point(194, 394);
            this.createfolderbutton.Name = "createfolderbutton";
            this.createfolderbutton.Size = new System.Drawing.Size(119, 29);
            this.createfolderbutton.TabIndex = 12;
            this.createfolderbutton.Text = "Create Folder";
            this.createfolderbutton.UseVisualStyleBackColor = true;
            this.createfolderbutton.Click += new System.EventHandler(this.createfolderbutton_Click);
            // 
            // ceatefilebutton
            // 
            this.ceatefilebutton.Location = new System.Drawing.Point(378, 394);
            this.ceatefilebutton.Name = "ceatefilebutton";
            this.ceatefilebutton.Size = new System.Drawing.Size(121, 29);
            this.ceatefilebutton.TabIndex = 13;
            this.ceatefilebutton.Text = "Create File";
            this.ceatefilebutton.UseVisualStyleBackColor = true;
            this.ceatefilebutton.Click += new System.EventHandler(this.ceatefilebutton_Click);
            // 
            // Studentinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ceatefilebutton);
            this.Controls.Add(this.createfolderbutton);
            this.Controls.Add(this.readfromfilebutton);
            this.Controls.Add(this.writetofilebutton);
            this.Controls.Add(this.citytextBox);
            this.Controls.Add(this.streamtextBox);
            this.Controls.Add(this.percentagetextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.rollnotextBox);
            this.Controls.Add(this.citylabel);
            this.Controls.Add(this.streamlabel);
            this.Controls.Add(this.perrcentagelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.rollnolabel);
            this.Name = "Studentinfo";
            this.Text = "Studentinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label rollnolabel;
        private Label namelabel;
        private Label perrcentagelabel;
        private Label streamlabel;
        private Label citylabel;
        private TextBox rollnotextBox;
        private TextBox nametextBox;
        private TextBox percentagetextBox;
        private TextBox streamtextBox;
        private TextBox citytextBox;
        private Button writetofilebutton;
        private Button readfromfilebutton;
        private Button createfolderbutton;
        private Button ceatefilebutton;
    }
}