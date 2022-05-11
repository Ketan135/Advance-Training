namespace DatabaseAdo
{
    partial class Empdetail
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
            this.deletebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.salarylabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(255, 66);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 20;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(255, 18);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 19;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(197, 177);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 18;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(55, 177);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 17;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(123, 122);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(100, 22);
            this.salarytextBox.TabIndex = 16;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(123, 67);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 15;
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(123, 19);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 14;
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Location = new System.Drawing.Point(52, 128);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(46, 16);
            this.salarylabel.TabIndex = 13;
            this.salarylabel.Text = "Salary";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(52, 73);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(44, 16);
            this.namelabel.TabIndex = 12;
            this.namelabel.Text = "Name";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(52, 25);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 16);
            this.idlabel.TabIndex = 11;
            this.idlabel.Text = "Id";
            // 
            // Empdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.salarylabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Name = "Empdetail";
            this.Text = "Empdetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label salarylabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label idlabel;
    }
}