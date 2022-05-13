namespace EntityDataModel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(283, 74);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 20;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(283, 26);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 19;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(198, 194);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 18;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(61, 194);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 17;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(127, 124);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(100, 22);
            this.salarytextBox.TabIndex = 16;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(127, 78);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 15;
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(127, 27);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 14;
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Location = new System.Drawing.Point(58, 124);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(46, 16);
            this.salarylabel.TabIndex = 13;
            this.salarylabel.Text = "Salary";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(58, 81);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(44, 16);
            this.namelabel.TabIndex = 12;
            this.namelabel.Text = "Name";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(58, 33);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(18, 16);
            this.idlabel.TabIndex = 11;
            this.idlabel.Text = "Id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(417, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(537, 194);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 22;
            this.showbutton.Text = "Show All";
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
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.salarylabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Name = "Form1";
            this.Text = "Ado.Net Entity Data Model";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showbutton;
    }
}

