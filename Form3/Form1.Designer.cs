namespace Form3
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
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnToonDatum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(23, 26);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 0;
            // 
            // btnToonDatum
            // 
            this.btnToonDatum.Location = new System.Drawing.Point(23, 52);
            this.btnToonDatum.Name = "btnToonDatum";
            this.btnToonDatum.Size = new System.Drawing.Size(200, 23);
            this.btnToonDatum.TabIndex = 1;
            this.btnToonDatum.Text = "Toon geselecteerde datum";
            this.btnToonDatum.UseVisualStyleBackColor = true;
            this.btnToonDatum.Click += new System.EventHandler(this.btnToonDatum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 90);
            this.Controls.Add(this.btnToonDatum);
            this.Controls.Add(this.dtpDatum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnToonDatum;
    }
}

