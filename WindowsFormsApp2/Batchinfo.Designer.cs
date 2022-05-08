namespace WindowsFormsApp2
{
    partial class Batchinfo
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
            this.startlabel = new System.Windows.Forms.Label();
            this.endlabel = new System.Windows.Forms.Label();
            this.lacationlabel = new System.Windows.Forms.Label();
            this.trainerlabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.starttextBox = new System.Windows.Forms.TextBox();
            this.endtextBox = new System.Windows.Forms.TextBox();
            this.locationtextBox = new System.Windows.Forms.TextBox();
            this.trainertextBox = new System.Windows.Forms.TextBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.writebutton = new System.Windows.Forms.Button();
            this.readbutton = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(228, 25);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(55, 16);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "Batch Id";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(228, 79);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(81, 16);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "Batch Name";
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Location = new System.Drawing.Point(228, 130);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(66, 16);
            this.startlabel.TabIndex = 2;
            this.startlabel.Text = "Start Date";
            // 
            // endlabel
            // 
            this.endlabel.AutoSize = true;
            this.endlabel.Location = new System.Drawing.Point(228, 180);
            this.endlabel.Name = "endlabel";
            this.endlabel.Size = new System.Drawing.Size(63, 16);
            this.endlabel.TabIndex = 3;
            this.endlabel.Text = "End Date";
            // 
            // lacationlabel
            // 
            this.lacationlabel.AutoSize = true;
            this.lacationlabel.Location = new System.Drawing.Point(228, 228);
            this.lacationlabel.Name = "lacationlabel";
            this.lacationlabel.Size = new System.Drawing.Size(58, 16);
            this.lacationlabel.TabIndex = 4;
            this.lacationlabel.Text = "Lacation";
            // 
            // trainerlabel
            // 
            this.trainerlabel.AutoSize = true;
            this.trainerlabel.Location = new System.Drawing.Point(228, 279);
            this.trainerlabel.Name = "trainerlabel";
            this.trainerlabel.Size = new System.Drawing.Size(90, 16);
            this.trainerlabel.TabIndex = 5;
            this.trainerlabel.Text = "Trainer Name";
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(326, 19);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(100, 22);
            this.idtextBox.TabIndex = 6;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(326, 73);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 22);
            this.nametextBox.TabIndex = 7;
            // 
            // starttextBox
            // 
            this.starttextBox.Location = new System.Drawing.Point(326, 124);
            this.starttextBox.Name = "starttextBox";
            this.starttextBox.Size = new System.Drawing.Size(100, 22);
            this.starttextBox.TabIndex = 8;
            // 
            // endtextBox
            // 
            this.endtextBox.Location = new System.Drawing.Point(326, 174);
            this.endtextBox.Name = "endtextBox";
            this.endtextBox.Size = new System.Drawing.Size(100, 22);
            this.endtextBox.TabIndex = 9;
            // 
            // locationtextBox
            // 
            this.locationtextBox.Location = new System.Drawing.Point(326, 222);
            this.locationtextBox.Name = "locationtextBox";
            this.locationtextBox.Size = new System.Drawing.Size(100, 22);
            this.locationtextBox.TabIndex = 10;
            // 
            // trainertextBox
            // 
            this.trainertextBox.Location = new System.Drawing.Point(326, 273);
            this.trainertextBox.Name = "trainertextBox";
            this.trainertextBox.Size = new System.Drawing.Size(100, 22);
            this.trainertextBox.TabIndex = 11;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(231, 339);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(75, 23);
            this.showbutton.TabIndex = 12;
            this.showbutton.Text = "Show";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(396, 339);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 13;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // writebutton
            // 
            this.writebutton.Location = new System.Drawing.Point(639, 72);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(99, 23);
            this.writebutton.TabIndex = 14;
            this.writebutton.Text = "Binary Write";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(639, 123);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(99, 23);
            this.readbutton.TabIndex = 15;
            this.readbutton.Text = "Binary Read";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(323, 400);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(0, 16);
            this.l1.TabIndex = 16;
            // 
            // Batchinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.writebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.trainertextBox);
            this.Controls.Add(this.locationtextBox);
            this.Controls.Add(this.endtextBox);
            this.Controls.Add(this.starttextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.trainerlabel);
            this.Controls.Add(this.lacationlabel);
            this.Controls.Add(this.endlabel);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idlabel);
            this.Name = "Batchinfo";
            this.Text = "Batchinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label startlabel;
        private System.Windows.Forms.Label endlabel;
        private System.Windows.Forms.Label lacationlabel;
        private System.Windows.Forms.Label trainerlabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox starttextBox;
        private System.Windows.Forms.TextBox endtextBox;
        private System.Windows.Forms.TextBox locationtextBox;
        private System.Windows.Forms.TextBox trainertextBox;
        private System.Windows.Forms.Button showbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.Label l1;
    }
}