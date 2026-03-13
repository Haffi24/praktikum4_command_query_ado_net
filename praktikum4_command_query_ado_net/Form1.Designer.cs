namespace praktikum4_command_query_ado_net
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnLatihan1 = new System.Windows.Forms.Button();
            this.btnLatihan2 = new System.Windows.Forms.Button();
            this.btnLatihan3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConnect.Location = new System.Drawing.Point(120, 276);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.BackColorChanged += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(445, 276);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHitungMK.Location = new System.Drawing.Point(216, 276);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(75, 23);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "Hitung Mk";
            this.btnHitungMK.UseVisualStyleBackColor = false;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(327, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(230, 177);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(290, 20);
            this.txtHasil.TabIndex = 5;
            // 
            // btnLatihan1
            // 
            this.btnLatihan1.Location = new System.Drawing.Point(404, 369);
            this.btnLatihan1.Name = "btnLatihan1";
            this.btnLatihan1.Size = new System.Drawing.Size(116, 23);
            this.btnLatihan1.TabIndex = 6;
            this.btnLatihan1.Text = "Hitung Dosen";
            this.btnLatihan1.UseVisualStyleBackColor = true;
            this.btnLatihan1.Click += new System.EventHandler(this.btnLatihan1_Click);
            // 
            // btnLatihan2
            // 
            this.btnLatihan2.Location = new System.Drawing.Point(545, 369);
            this.btnLatihan2.Name = "btnLatihan2";
            this.btnLatihan2.Size = new System.Drawing.Size(75, 23);
            this.btnLatihan2.TabIndex = 7;
            this.btnLatihan2.Text = "Update SKS";
            this.btnLatihan2.UseVisualStyleBackColor = true;
            this.btnLatihan2.Click += new System.EventHandler(this.btnLatihan2_Click);
            // 
            // btnLatihan3
            // 
            this.btnLatihan3.Location = new System.Drawing.Point(648, 369);
            this.btnLatihan3.Name = "btnLatihan3";
            this.btnLatihan3.Size = new System.Drawing.Size(75, 23);
            this.btnLatihan3.TabIndex = 8;
            this.btnLatihan3.Text = "Insert Prodi";
            this.btnLatihan3.UseVisualStyleBackColor = true;
            this.btnLatihan3.Click += new System.EventHandler(this.btnLatihan3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLatihan3);
            this.Controls.Add(this.btnLatihan2);
            this.Controls.Add(this.btnLatihan1);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnLatihan1;
        private System.Windows.Forms.Button btnLatihan2;
        private System.Windows.Forms.Button btnLatihan3;
    }
}

