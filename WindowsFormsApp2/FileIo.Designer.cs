namespace WinFormsApp1
{
    partial class FileIo
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
            this.writetofilebutton = new System.Windows.Forms.Button();
            this.readfromfilebutton = new System.Windows.Forms.Button();
            this.deptlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.locationlabel = new System.Windows.Forms.Label();
            this.depttextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.locationtextBox = new System.Windows.Forms.TextBox();
            this.createfolderbutton = new System.Windows.Forms.Button();
            this.createfilebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writetofilebutton
            // 
            this.writetofilebutton.Location = new System.Drawing.Point(238, 235);
            this.writetofilebutton.Name = "writetofilebutton";
            this.writetofilebutton.Size = new System.Drawing.Size(133, 29);
            this.writetofilebutton.TabIndex = 0;
            this.writetofilebutton.Text = "Write To File";
            this.writetofilebutton.UseVisualStyleBackColor = true;
            this.writetofilebutton.Click += new System.EventHandler(this.writetofilebutton_Click);
            // 
            // readfromfilebutton
            // 
            this.readfromfilebutton.Location = new System.Drawing.Point(450, 235);
            this.readfromfilebutton.Name = "readfromfilebutton";
            this.readfromfilebutton.Size = new System.Drawing.Size(140, 29);
            this.readfromfilebutton.TabIndex = 1;
            this.readfromfilebutton.Text = "Read From File";
            this.readfromfilebutton.UseVisualStyleBackColor = true;
            this.readfromfilebutton.Click += new System.EventHandler(this.readfromfilebutton_Click);
            // 
            // deptlabel
            // 
            this.deptlabel.AutoSize = true;
            this.deptlabel.Location = new System.Drawing.Point(277, 65);
            this.deptlabel.Name = "deptlabel";
            this.deptlabel.Size = new System.Drawing.Size(59, 20);
            this.deptlabel.TabIndex = 2;
            this.deptlabel.Text = "Dept Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(277, 117);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(86, 20);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Dept Name";
            // 
            // locationlabel
            // 
            this.locationlabel.AutoSize = true;
            this.locationlabel.Location = new System.Drawing.Point(277, 173);
            this.locationlabel.Name = "locationlabel";
            this.locationlabel.Size = new System.Drawing.Size(66, 20);
            this.locationlabel.TabIndex = 4;
            this.locationlabel.Text = "Location";
            // 
            // depttextBox
            // 
            this.depttextBox.Location = new System.Drawing.Point(419, 62);
            this.depttextBox.Name = "depttextBox";
            this.depttextBox.Size = new System.Drawing.Size(125, 27);
            this.depttextBox.TabIndex = 5;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(419, 110);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(125, 27);
            this.nametextBox.TabIndex = 6;
            // 
            // locationtextBox
            // 
            this.locationtextBox.Location = new System.Drawing.Point(419, 166);
            this.locationtextBox.Name = "locationtextBox";
            this.locationtextBox.Size = new System.Drawing.Size(125, 27);
            this.locationtextBox.TabIndex = 7;
            // 
            // createfolderbutton
            // 
            this.createfolderbutton.Location = new System.Drawing.Point(238, 292);
            this.createfolderbutton.Name = "createfolderbutton";
            this.createfolderbutton.Size = new System.Drawing.Size(133, 29);
            this.createfolderbutton.TabIndex = 8;
            this.createfolderbutton.Text = "Create Folder";
            this.createfolderbutton.UseVisualStyleBackColor = true;
            this.createfolderbutton.Click += new System.EventHandler(this.createfolderbutton_Click);
            // 
            // createfilebutton
            // 
            this.createfilebutton.Location = new System.Drawing.Point(450, 292);
            this.createfilebutton.Name = "createfilebutton";
            this.createfilebutton.Size = new System.Drawing.Size(94, 29);
            this.createfilebutton.TabIndex = 9;
            this.createfilebutton.Text = "Create File";
            this.createfilebutton.UseVisualStyleBackColor = true;
            this.createfilebutton.Click += new System.EventHandler(this.createfilebutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createfilebutton);
            this.Controls.Add(this.createfolderbutton);
            this.Controls.Add(this.locationtextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.depttextBox);
            this.Controls.Add(this.locationlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.deptlabel);
            this.Controls.Add(this.readfromfilebutton);
            this.Controls.Add(this.writetofilebutton);
            this.Name = "Form2";
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button writetofilebutton;
        private Button readfromfilebutton;
        private Label deptlabel;
        private Label namelabel;
        private Label locationlabel;
        private TextBox depttextBox;
        private TextBox nametextBox;
        private TextBox locationtextBox;
        private Button createfolderbutton;
        private Button createfilebutton;
    }
}