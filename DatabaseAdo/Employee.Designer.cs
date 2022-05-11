namespace DatabaseAdo
{
    partial class Employee
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
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.desitextBox = new System.Windows.Forms.TextBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salarylabel = new System.Windows.Forms.Label();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(101, 9);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(49, 16);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "Emp Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(101, 55);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(75, 16);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Emp Name";
            // 
            // designationlabel
            // 
            this.designationlabel.AutoSize = true;
            this.designationlabel.Location = new System.Drawing.Point(101, 104);
            this.designationlabel.Name = "designationlabel";
            this.designationlabel.Size = new System.Drawing.Size(79, 16);
            this.designationlabel.TabIndex = 2;
            this.designationlabel.Text = "Designation";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(194, 3);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 3;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(194, 49);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 4;
            // 
            // desitextBox
            // 
            this.desitextBox.Location = new System.Drawing.Point(194, 98);
            this.desitextBox.Name = "desitextBox";
            this.desitextBox.Size = new System.Drawing.Size(100, 22);
            this.desitextBox.TabIndex = 5;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(559, 217);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 6;
            this.showbutton.Text = "Show All";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(51, 197);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "Add New";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(176, 197);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(289, 197);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 9;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(333, 6);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 10;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(333, 48);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(414, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(374, 189);
            this.dataGridView1.TabIndex = 12;
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Location = new System.Drawing.Point(101, 150);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(46, 16);
            this.salarylabel.TabIndex = 13;
            this.salarylabel.Text = "Salary";
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(194, 144);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(100, 22);
            this.salarytextBox.TabIndex = 14;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.salarylabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.desitextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.designationlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Name = "Employee";
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label designationlabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox desitextBox;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label salarylabel;
        private System.Windows.Forms.TextBox salarytextBox;
    }
}