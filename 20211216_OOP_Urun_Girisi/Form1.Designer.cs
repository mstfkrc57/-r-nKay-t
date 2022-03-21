
namespace _20211216_OOP_Urun_Girisi
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
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tip = new System.Windows.Forms.TextBox();
            this.txt_desi = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_renk = new System.Windows.Forms.TextBox();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.ListBox();
            this.combo_listele = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_urunozellik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(139, 88);
            this.txt_ad.Multiline = true;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(145, 36);
            this.txt_ad.TabIndex = 0;
            // 
            // txt_tip
            // 
            this.txt_tip.Location = new System.Drawing.Point(139, 130);
            this.txt_tip.Multiline = true;
            this.txt_tip.Name = "txt_tip";
            this.txt_tip.Size = new System.Drawing.Size(145, 36);
            this.txt_tip.TabIndex = 1;
            // 
            // txt_desi
            // 
            this.txt_desi.Location = new System.Drawing.Point(139, 172);
            this.txt_desi.Multiline = true;
            this.txt_desi.Name = "txt_desi";
            this.txt_desi.Size = new System.Drawing.Size(145, 36);
            this.txt_desi.TabIndex = 2;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(139, 214);
            this.txt_model.Multiline = true;
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(145, 36);
            this.txt_model.TabIndex = 3;
            // 
            // txt_renk
            // 
            this.txt_renk.Location = new System.Drawing.Point(139, 256);
            this.txt_renk.Multiline = true;
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(145, 36);
            this.txt_renk.TabIndex = 4;
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(139, 303);
            this.txt_marka.Multiline = true;
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(145, 36);
            this.txt_marka.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(139, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listele
            // 
            this.listele.FormattingEnabled = true;
            this.listele.Location = new System.Drawing.Point(290, 88);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(146, 251);
            this.listele.TabIndex = 7;
            // 
            // combo_listele
            // 
            this.combo_listele.FormattingEnabled = true;
            this.combo_listele.Location = new System.Drawing.Point(442, 88);
            this.combo_listele.Name = "combo_listele";
            this.combo_listele.Size = new System.Drawing.Size(121, 21);
            this.combo_listele.TabIndex = 8;
            this.combo_listele.SelectedIndexChanged += new System.EventHandler(this.combo_listele_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ürün Ağırlığı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün Modeli:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ürün Rengi:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ürün Markası:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(291, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(488, 115);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 36);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_urunozellik
            // 
            this.lbl_urunozellik.AutoSize = true;
            this.lbl_urunozellik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(162)));
            this.lbl_urunozellik.Location = new System.Drawing.Point(288, 70);
            this.lbl_urunozellik.Name = "lbl_urunozellik";
            this.lbl_urunozellik.Size = new System.Drawing.Size(107, 15);
            this.lbl_urunozellik.TabIndex = 17;
            this.lbl_urunozellik.Text = "Ürün Özellikleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_urunozellik);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_listele);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.txt_renk);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.txt_desi);
            this.Controls.Add(this.txt_tip);
            this.Controls.Add(this.txt_ad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tip;
        private System.Windows.Forms.TextBox txt_desi;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_renk;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listele;
        private System.Windows.Forms.ComboBox combo_listele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Label lbl_urunozellik;
    }
}

