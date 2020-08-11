namespace form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNotities = new System.Windows.Forms.ListBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.tbToonNotitie = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnSchrijfBij = new System.Windows.Forms.Button();
            this.btnLamineren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notitieboekje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notitie";
            // 
            // lbNotities
            // 
            this.lbNotities.FormattingEnabled = true;
            this.lbNotities.Location = new System.Drawing.Point(15, 28);
            this.lbNotities.Name = "lbNotities";
            this.lbNotities.Size = new System.Drawing.Size(128, 225);
            this.lbNotities.TabIndex = 2;
            this.lbNotities.SelectedIndexChanged += new System.EventHandler(this.lbNotities_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(15, 259);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(128, 23);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Voeg notitie toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(15, 288);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(128, 23);
            this.btnVerwijderen.TabIndex = 4;
            this.btnVerwijderen.Text = "Scheur notitie uit";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // tbToonNotitie
            // 
            this.tbToonNotitie.Enabled = false;
            this.tbToonNotitie.Location = new System.Drawing.Point(152, 28);
            this.tbToonNotitie.Name = "tbToonNotitie";
            this.tbToonNotitie.Size = new System.Drawing.Size(261, 225);
            this.tbToonNotitie.TabIndex = 6;
            this.tbToonNotitie.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bijschrijven";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(152, 291);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(221, 20);
            this.tbText.TabIndex = 8;
            // 
            // btnSchrijfBij
            // 
            this.btnSchrijfBij.Location = new System.Drawing.Point(379, 291);
            this.btnSchrijfBij.Name = "btnSchrijfBij";
            this.btnSchrijfBij.Size = new System.Drawing.Size(34, 20);
            this.btnSchrijfBij.TabIndex = 9;
            this.btnSchrijfBij.Text = "->";
            this.btnSchrijfBij.UseVisualStyleBackColor = true;
            this.btnSchrijfBij.Click += new System.EventHandler(this.btnSchrijfBij_Click);
            // 
            // btnLamineren
            // 
            this.btnLamineren.Location = new System.Drawing.Point(15, 317);
            this.btnLamineren.Name = "btnLamineren";
            this.btnLamineren.Size = new System.Drawing.Size(128, 23);
            this.btnLamineren.TabIndex = 10;
            this.btnLamineren.Text = "Lamineren";
            this.btnLamineren.UseVisualStyleBackColor = true;
            this.btnLamineren.Click += new System.EventHandler(this.btnLamineren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 353);
            this.Controls.Add(this.btnLamineren);
            this.Controls.Add(this.btnSchrijfBij);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbToonNotitie);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lbNotities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbNotities;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.RichTextBox tbToonNotitie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnSchrijfBij;
        private System.Windows.Forms.Button btnLamineren;
    }
}

