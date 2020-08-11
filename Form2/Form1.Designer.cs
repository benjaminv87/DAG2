namespace Form2
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.numLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.gbProvincie = new System.Windows.Forms.GroupBox();
            this.rbNamen = new System.Windows.Forms.RadioButton();
            this.rbLux = new System.Windows.Forms.RadioButton();
            this.rbLuik = new System.Windows.Forms.RadioButton();
            this.rnHen = new System.Windows.Forms.RadioButton();
            this.rbWB = new System.Windows.Forms.RadioButton();
            this.rbWV = new System.Windows.Forms.RadioButton();
            this.rbVB = new System.Windows.Forms.RadioButton();
            this.rbOV = new System.Windows.Forms.RadioButton();
            this.rbLim = new System.Windows.Forms.RadioButton();
            this.rbAnt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIndienen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).BeginInit();
            this.gbGeslacht.SuspendLayout();
            this.gbProvincie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(57, 12);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(57, 40);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 20);
            this.tbAdres.TabIndex = 1;
            // 
            // numLeeftijd
            // 
            this.numLeeftijd.Location = new System.Drawing.Point(57, 66);
            this.numLeeftijd.Name = "numLeeftijd";
            this.numLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.numLeeftijd.TabIndex = 2;
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.Location = new System.Drawing.Point(12, 92);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(100, 70);
            this.gbGeslacht.TabIndex = 3;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht";
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(3, 39);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 1;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(3, 16);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // gbProvincie
            // 
            this.gbProvincie.Controls.Add(this.rbNamen);
            this.gbProvincie.Controls.Add(this.rbLux);
            this.gbProvincie.Controls.Add(this.rbLuik);
            this.gbProvincie.Controls.Add(this.rnHen);
            this.gbProvincie.Controls.Add(this.rbWB);
            this.gbProvincie.Controls.Add(this.rbWV);
            this.gbProvincie.Controls.Add(this.rbVB);
            this.gbProvincie.Controls.Add(this.rbOV);
            this.gbProvincie.Controls.Add(this.rbLim);
            this.gbProvincie.Controls.Add(this.rbAnt);
            this.gbProvincie.Location = new System.Drawing.Point(12, 168);
            this.gbProvincie.Name = "gbProvincie";
            this.gbProvincie.Size = new System.Drawing.Size(279, 141);
            this.gbProvincie.TabIndex = 4;
            this.gbProvincie.TabStop = false;
            this.gbProvincie.Text = "Provincie";
            // 
            // rbNamen
            // 
            this.rbNamen.AutoSize = true;
            this.rbNamen.Location = new System.Drawing.Point(179, 108);
            this.rbNamen.Name = "rbNamen";
            this.rbNamen.Size = new System.Drawing.Size(59, 17);
            this.rbNamen.TabIndex = 9;
            this.rbNamen.TabStop = true;
            this.rbNamen.Text = "Namen";
            this.rbNamen.UseVisualStyleBackColor = true;
            // 
            // rbLux
            // 
            this.rbLux.AutoSize = true;
            this.rbLux.Location = new System.Drawing.Point(179, 85);
            this.rbLux.Name = "rbLux";
            this.rbLux.Size = new System.Drawing.Size(77, 17);
            this.rbLux.TabIndex = 8;
            this.rbLux.TabStop = true;
            this.rbLux.Text = "Luxemburg";
            this.rbLux.UseVisualStyleBackColor = true;
            // 
            // rbLuik
            // 
            this.rbLuik.AutoSize = true;
            this.rbLuik.Location = new System.Drawing.Point(179, 62);
            this.rbLuik.Name = "rbLuik";
            this.rbLuik.Size = new System.Drawing.Size(45, 17);
            this.rbLuik.TabIndex = 7;
            this.rbLuik.TabStop = true;
            this.rbLuik.Text = "Luik";
            this.rbLuik.UseVisualStyleBackColor = true;
            // 
            // rnHen
            // 
            this.rnHen.AutoSize = true;
            this.rnHen.Location = new System.Drawing.Point(179, 39);
            this.rnHen.Name = "rnHen";
            this.rnHen.Size = new System.Drawing.Size(89, 17);
            this.rnHen.TabIndex = 6;
            this.rnHen.TabStop = true;
            this.rnHen.Text = "Henegouwen";
            this.rnHen.UseVisualStyleBackColor = true;
            // 
            // rbWB
            // 
            this.rbWB.AutoSize = true;
            this.rbWB.Location = new System.Drawing.Point(179, 16);
            this.rbWB.Name = "rbWB";
            this.rbWB.Size = new System.Drawing.Size(95, 17);
            this.rbWB.TabIndex = 5;
            this.rbWB.TabStop = true;
            this.rbWB.Text = "Waals-Brabant";
            this.rbWB.UseVisualStyleBackColor = true;
            // 
            // rbWV
            // 
            this.rbWV.AutoSize = true;
            this.rbWV.Location = new System.Drawing.Point(3, 108);
            this.rbWV.Name = "rbWV";
            this.rbWV.Size = new System.Drawing.Size(107, 17);
            this.rbWV.TabIndex = 4;
            this.rbWV.TabStop = true;
            this.rbWV.Text = "West-Vlaanderen";
            this.rbWV.UseVisualStyleBackColor = true;
            // 
            // rbVB
            // 
            this.rbVB.AutoSize = true;
            this.rbVB.Location = new System.Drawing.Point(3, 85);
            this.rbVB.Name = "rbVB";
            this.rbVB.Size = new System.Drawing.Size(99, 17);
            this.rbVB.TabIndex = 3;
            this.rbVB.TabStop = true;
            this.rbVB.Text = "Vlaams-Brabant";
            this.rbVB.UseVisualStyleBackColor = true;
            // 
            // rbOV
            // 
            this.rbOV.AutoSize = true;
            this.rbOV.Location = new System.Drawing.Point(3, 62);
            this.rbOV.Name = "rbOV";
            this.rbOV.Size = new System.Drawing.Size(104, 17);
            this.rbOV.TabIndex = 2;
            this.rbOV.TabStop = true;
            this.rbOV.Text = "Oost-Vlaanderen";
            this.rbOV.UseVisualStyleBackColor = true;
            // 
            // rbLim
            // 
            this.rbLim.AutoSize = true;
            this.rbLim.Location = new System.Drawing.Point(3, 39);
            this.rbLim.Name = "rbLim";
            this.rbLim.Size = new System.Drawing.Size(62, 17);
            this.rbLim.TabIndex = 1;
            this.rbLim.TabStop = true;
            this.rbLim.Text = "Limburg";
            this.rbLim.UseVisualStyleBackColor = true;
            // 
            // rbAnt
            // 
            this.rbAnt.AutoSize = true;
            this.rbAnt.Location = new System.Drawing.Point(3, 16);
            this.rbAnt.Name = "rbAnt";
            this.rbAnt.Size = new System.Drawing.Size(76, 17);
            this.rbAnt.TabIndex = 0;
            this.rbAnt.TabStop = true;
            this.rbAnt.Text = "Antwerpen";
            this.rbAnt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Leeftijd";
            // 
            // btnIndienen
            // 
            this.btnIndienen.Location = new System.Drawing.Point(221, 15);
            this.btnIndienen.Name = "btnIndienen";
            this.btnIndienen.Size = new System.Drawing.Size(75, 23);
            this.btnIndienen.TabIndex = 8;
            this.btnIndienen.Text = "Indienen";
            this.btnIndienen.UseVisualStyleBackColor = true;
            this.btnIndienen.Click += new System.EventHandler(this.btnIndienen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 317);
            this.Controls.Add(this.btnIndienen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbProvincie);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.numLeeftijd);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.tbNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numLeeftijd)).EndInit();
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.gbProvincie.ResumeLayout(false);
            this.gbProvincie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.NumericUpDown numLeeftijd;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.GroupBox gbProvincie;
        private System.Windows.Forms.RadioButton rbNamen;
        private System.Windows.Forms.RadioButton rbLux;
        private System.Windows.Forms.RadioButton rbLuik;
        private System.Windows.Forms.RadioButton rnHen;
        private System.Windows.Forms.RadioButton rbWB;
        private System.Windows.Forms.RadioButton rbWV;
        private System.Windows.Forms.RadioButton rbVB;
        private System.Windows.Forms.RadioButton rbOV;
        private System.Windows.Forms.RadioButton rbLim;
        private System.Windows.Forms.RadioButton rbAnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIndienen;
    }
}

