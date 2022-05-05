namespace WinFormsApp1
{
    partial class Employeeinfo
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
            this.idlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.designationlabel = new System.Windows.Forms.Label();
            this.salarylabel = new System.Windows.Forms.Label();
            this.deptlabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.desitextBox = new System.Windows.Forms.TextBox();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.depttextBox = new System.Windows.Forms.TextBox();
            this.writetofilebutton = new System.Windows.Forms.Button();
            this.readfromfilebutton = new System.Windows.Forms.Button();
            this.createfolderbutton = new System.Windows.Forms.Button();
            this.createfilebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(196, 39);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(56, 20);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "Emp Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(196, 92);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(83, 20);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Emp Name";
            // 
            // designationlabel
            // 
            this.designationlabel.AutoSize = true;
            this.designationlabel.Location = new System.Drawing.Point(196, 143);
            this.designationlabel.Name = "designationlabel";
            this.designationlabel.Size = new System.Drawing.Size(89, 20);
            this.designationlabel.TabIndex = 2;
            this.designationlabel.Text = "Designation";
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Location = new System.Drawing.Point(196, 200);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(49, 20);
            this.salarylabel.TabIndex = 3;
            this.salarylabel.Text = "Salary";
            // 
            // deptlabel
            // 
            this.deptlabel.AutoSize = true;
            this.deptlabel.Location = new System.Drawing.Point(196, 258);
            this.deptlabel.Name = "deptlabel";
            this.deptlabel.Size = new System.Drawing.Size(89, 20);
            this.deptlabel.TabIndex = 4;
            this.deptlabel.Text = "Department";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(350, 32);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(125, 27);
            this.idtextBox.TabIndex = 5;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(350, 85);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(125, 27);
            this.nametextBox.TabIndex = 6;
            // 
            // desitextBox
            // 
            this.desitextBox.Location = new System.Drawing.Point(350, 136);
            this.desitextBox.Name = "desitextBox";
            this.desitextBox.Size = new System.Drawing.Size(125, 27);
            this.desitextBox.TabIndex = 7;
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(350, 193);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(125, 27);
            this.salarytextBox.TabIndex = 8;
            // 
            // depttextBox
            // 
            this.depttextBox.Location = new System.Drawing.Point(350, 251);
            this.depttextBox.Name = "depttextBox";
            this.depttextBox.Size = new System.Drawing.Size(125, 27);
            this.depttextBox.TabIndex = 9;
            // 
            // writetofilebutton
            // 
            this.writetofilebutton.Location = new System.Drawing.Point(196, 325);
            this.writetofilebutton.Name = "writetofilebutton";
            this.writetofilebutton.Size = new System.Drawing.Size(116, 29);
            this.writetofilebutton.TabIndex = 10;
            this.writetofilebutton.Text = "Write To File";
            this.writetofilebutton.UseVisualStyleBackColor = true;
            this.writetofilebutton.Click += new System.EventHandler(this.writetofilebutton_Click);
            // 
            // readfromfilebutton
            // 
            this.readfromfilebutton.Location = new System.Drawing.Point(381, 325);
            this.readfromfilebutton.Name = "readfromfilebutton";
            this.readfromfilebutton.Size = new System.Drawing.Size(130, 29);
            this.readfromfilebutton.TabIndex = 11;
            this.readfromfilebutton.Text = "Read from File";
            this.readfromfilebutton.UseVisualStyleBackColor = true;
            this.readfromfilebutton.Click += new System.EventHandler(this.readfromfilebutton_Click);
            // 
            // createfolderbutton
            // 
            this.createfolderbutton.Location = new System.Drawing.Point(196, 397);
            this.createfolderbutton.Name = "createfolderbutton";
            this.createfolderbutton.Size = new System.Drawing.Size(116, 29);
            this.createfolderbutton.TabIndex = 12;
            this.createfolderbutton.Text = "Create Folder";
            this.createfolderbutton.UseVisualStyleBackColor = true;
            this.createfolderbutton.Click += new System.EventHandler(this.createfolderbutton_Click);
            // 
            // createfilebutton
            // 
            this.createfilebutton.Location = new System.Drawing.Point(381, 397);
            this.createfilebutton.Name = "createfilebutton";
            this.createfilebutton.Size = new System.Drawing.Size(94, 29);
            this.createfilebutton.TabIndex = 13;
            this.createfilebutton.Text = "Create File";
            this.createfilebutton.UseVisualStyleBackColor = true;
            this.createfilebutton.Click += new System.EventHandler(this.createfilebutton_Click);
            // 
            // Employeeinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createfilebutton);
            this.Controls.Add(this.createfolderbutton);
            this.Controls.Add(this.readfromfilebutton);
            this.Controls.Add(this.writetofilebutton);
            this.Controls.Add(this.depttextBox);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.desitextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.deptlabel);
            this.Controls.Add(this.salarylabel);
            this.Controls.Add(this.designationlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Name = "Employeeinfo";
            this.Text = "Employeeinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label idlabel;
        private Label namelabel;
        private Label designationlabel;
        private Label salarylabel;
        private Label deptlabel;
        private TextBox idtextBox;
        private TextBox nametextBox;
        private TextBox desitextBox;
        private TextBox salarytextBox;
        private TextBox depttextBox;
        private Button writetofilebutton;
        private Button readfromfilebutton;
        private Button createfolderbutton;
        private Button createfilebutton;
    }
}