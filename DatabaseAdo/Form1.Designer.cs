namespace DatabaseAdo
{
    partial class Form1
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
            this.Idlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.pricetextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(161, 22);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(18, 16);
            this.Idlabel.TabIndex = 0;
            this.Idlabel.Text = "Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(161, 80);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(44, 16);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Name";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(161, 133);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(38, 16);
            this.pricelabel.TabIndex = 2;
            this.pricelabel.Text = "Price";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(251, 19);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 3;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(251, 74);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 4;
            // 
            // pricetextBox
            // 
            this.pricetextBox.Location = new System.Drawing.Point(251, 130);
            this.pricetextBox.Name = "pricetextBox";
            this.pricetextBox.Size = new System.Drawing.Size(100, 22);
            this.pricetextBox.TabIndex = 5;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(130, 202);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Add New";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(251, 202);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(369, 202);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 8;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(369, 15);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 9;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(369, 64);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 10;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(450, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(338, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(526, 202);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(132, 23);
            this.showbutton.TabIndex = 12;
            this.showbutton.Text = "Show All Product";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.pricetextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.Idlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox pricetextBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showbutton;
    }
}

