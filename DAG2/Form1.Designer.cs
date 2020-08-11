namespace DAG2
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
            this.components = new System.ComponentModel.Container();
            this.tbToevoegen = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lbLinks = new System.Windows.Forms.ListBox();
            this.lbRechts = new System.Windows.Forms.ListBox();
            this.btnListBoxRechts = new System.Windows.Forms.Button();
            this.btnListBoxLinks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbToevoegen
            // 
            this.tbToevoegen.Location = new System.Drawing.Point(12, 12);
            this.tbToevoegen.Name = "tbToevoegen";
            this.tbToevoegen.Size = new System.Drawing.Size(100, 20);
            this.tbToevoegen.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(118, 9);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lbLinks
            // 
            this.lbLinks.FormattingEnabled = true;
            this.lbLinks.Location = new System.Drawing.Point(12, 60);
            this.lbLinks.Name = "lbLinks";
            this.lbLinks.Size = new System.Drawing.Size(100, 134);
            this.lbLinks.TabIndex = 3;
            // 
            // lbRechts
            // 
            this.lbRechts.FormattingEnabled = true;
            this.lbRechts.Location = new System.Drawing.Point(199, 60);
            this.lbRechts.Name = "lbRechts";
            this.lbRechts.Size = new System.Drawing.Size(100, 134);
            this.lbRechts.TabIndex = 4;
            // 
            // btnListBoxRechts
            // 
            this.btnListBoxRechts.Location = new System.Drawing.Point(118, 96);
            this.btnListBoxRechts.Name = "btnListBoxRechts";
            this.btnListBoxRechts.Size = new System.Drawing.Size(75, 23);
            this.btnListBoxRechts.TabIndex = 5;
            this.btnListBoxRechts.Text = "=>";
            this.btnListBoxRechts.UseVisualStyleBackColor = true;
            this.btnListBoxRechts.Click += new System.EventHandler(this.btnListBoxRechts_Click);
            // 
            // btnListBoxLinks
            // 
            this.btnListBoxLinks.Location = new System.Drawing.Point(118, 125);
            this.btnListBoxLinks.Name = "btnListBoxLinks";
            this.btnListBoxLinks.Size = new System.Drawing.Size(75, 23);
            this.btnListBoxLinks.TabIndex = 6;
            this.btnListBoxLinks.Text = "<=";
            this.btnListBoxLinks.UseVisualStyleBackColor = true;
            this.btnListBoxLinks.Click += new System.EventHandler(this.btnListBoxLinks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inactief";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Actief";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListBoxLinks);
            this.Controls.Add(this.btnListBoxRechts);
            this.Controls.Add(this.lbRechts);
            this.Controls.Add(this.lbLinks);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.tbToevoegen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToevoegen;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ListBox lbLinks;
        private System.Windows.Forms.ListBox lbRechts;
        private System.Windows.Forms.Button btnListBoxRechts;
        private System.Windows.Forms.Button btnListBoxLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

