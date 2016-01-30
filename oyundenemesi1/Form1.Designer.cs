namespace oyundenemesi1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kucult = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ekranbilgisi = new System.Windows.Forms.Label();
            this.ekrankartilabel = new System.Windows.Forms.Label();
            this.ramlabel = new System.Windows.Forms.Label();
            this.rambilgisi = new System.Windows.Forms.Label();
            this.islemcilabel = new System.Windows.Forms.Label();
            this.islemcibilgisi = new System.Windows.Forms.Label();
            this.anakartlabel = new System.Windows.Forms.Label();
            this.anakartbilgisi = new System.Windows.Forms.Label();
            this.bioslabel = new System.Windows.Forms.Label();
            this.biosbilgisi = new System.Windows.Forms.Label();
            this.isletimsistemilabel = new System.Windows.Forms.Label();
            this.isletimsistemibilgisi = new System.Windows.Forms.Label();
            this.bilgisayarmodellabel = new System.Windows.Forms.Label();
            this.bilgisayarmodelbilgisi = new System.Windows.Forms.Label();
            this.sistembilgisilabel = new System.Windows.Forms.Label();
            this.kurkixlabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bilgisayareadilabel = new System.Windows.Forms.Label();
            this.bilgisayaradibilgisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kucult
            // 
            this.kucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(115)))));
            this.kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kucult.Location = new System.Drawing.Point(813, -1);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(53, 23);
            this.kucult.TabIndex = 2;
            this.kucult.Text = "---";
            this.kucult.UseVisualStyleBackColor = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(209)))), ((int)(((byte)(115)))));
            this.kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kapat.Location = new System.Drawing.Point(860, -1);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(58, 23);
            this.kapat.TabIndex = 1;
            this.kapat.Text = "X";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // ekranbilgisi
            // 
            this.ekranbilgisi.AutoSize = true;
            this.ekranbilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekranbilgisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ekranbilgisi.Location = new System.Drawing.Point(174, 84);
            this.ekranbilgisi.Name = "ekranbilgisi";
            this.ekranbilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.ekranbilgisi.Size = new System.Drawing.Size(69, 33);
            this.ekranbilgisi.TabIndex = 3;
            this.ekranbilgisi.Text = "label1";
            this.ekranbilgisi.Visible = false;
            // 
            // ekrankartilabel
            // 
            this.ekrankartilabel.AutoSize = true;
            this.ekrankartilabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ekrankartilabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ekrankartilabel.Location = new System.Drawing.Point(13, 84);
            this.ekrankartilabel.Name = "ekrankartilabel";
            this.ekrankartilabel.Padding = new System.Windows.Forms.Padding(6);
            this.ekrankartilabel.Size = new System.Drawing.Size(122, 33);
            this.ekrankartilabel.TabIndex = 4;
            this.ekrankartilabel.Text = "Ekran Kartı:";
            this.ekrankartilabel.Visible = false;
            // 
            // ramlabel
            // 
            this.ramlabel.AutoSize = true;
            this.ramlabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramlabel.ForeColor = System.Drawing.SystemColors.Info;
            this.ramlabel.Location = new System.Drawing.Point(13, 118);
            this.ramlabel.Name = "ramlabel";
            this.ramlabel.Padding = new System.Windows.Forms.Padding(6);
            this.ramlabel.Size = new System.Drawing.Size(68, 33);
            this.ramlabel.TabIndex = 5;
            this.ramlabel.Text = "RAM:";
            this.ramlabel.Visible = false;
            // 
            // rambilgisi
            // 
            this.rambilgisi.AutoSize = true;
            this.rambilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rambilgisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rambilgisi.Location = new System.Drawing.Point(174, 118);
            this.rambilgisi.Name = "rambilgisi";
            this.rambilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.rambilgisi.Size = new System.Drawing.Size(69, 33);
            this.rambilgisi.TabIndex = 6;
            this.rambilgisi.Text = "label1";
            this.rambilgisi.Visible = false;
            // 
            // islemcilabel
            // 
            this.islemcilabel.AutoSize = true;
            this.islemcilabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.islemcilabel.ForeColor = System.Drawing.SystemColors.Info;
            this.islemcilabel.Location = new System.Drawing.Point(12, 151);
            this.islemcilabel.Name = "islemcilabel";
            this.islemcilabel.Padding = new System.Windows.Forms.Padding(6);
            this.islemcilabel.Size = new System.Drawing.Size(79, 33);
            this.islemcilabel.TabIndex = 7;
            this.islemcilabel.Text = "İşlemci:";
            this.islemcilabel.Visible = false;
            // 
            // islemcibilgisi
            // 
            this.islemcibilgisi.AutoSize = true;
            this.islemcibilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.islemcibilgisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.islemcibilgisi.Location = new System.Drawing.Point(174, 151);
            this.islemcibilgisi.Name = "islemcibilgisi";
            this.islemcibilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.islemcibilgisi.Size = new System.Drawing.Size(69, 33);
            this.islemcibilgisi.TabIndex = 8;
            this.islemcibilgisi.Text = "label1";
            this.islemcibilgisi.Visible = false;
            // 
            // anakartlabel
            // 
            this.anakartlabel.AutoSize = true;
            this.anakartlabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anakartlabel.ForeColor = System.Drawing.SystemColors.Info;
            this.anakartlabel.Location = new System.Drawing.Point(11, 184);
            this.anakartlabel.Name = "anakartlabel";
            this.anakartlabel.Padding = new System.Windows.Forms.Padding(6);
            this.anakartlabel.Size = new System.Drawing.Size(90, 33);
            this.anakartlabel.TabIndex = 9;
            this.anakartlabel.Text = "Anakart:";
            this.anakartlabel.Visible = false;
            // 
            // anakartbilgisi
            // 
            this.anakartbilgisi.AutoSize = true;
            this.anakartbilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anakartbilgisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anakartbilgisi.Location = new System.Drawing.Point(174, 184);
            this.anakartbilgisi.Name = "anakartbilgisi";
            this.anakartbilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.anakartbilgisi.Size = new System.Drawing.Size(69, 33);
            this.anakartbilgisi.TabIndex = 10;
            this.anakartbilgisi.Text = "label1";
            this.anakartbilgisi.Visible = false;
            // 
            // bioslabel
            // 
            this.bioslabel.AutoSize = true;
            this.bioslabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bioslabel.ForeColor = System.Drawing.SystemColors.Info;
            this.bioslabel.Location = new System.Drawing.Point(13, 217);
            this.bioslabel.Name = "bioslabel";
            this.bioslabel.Padding = new System.Windows.Forms.Padding(6);
            this.bioslabel.Size = new System.Drawing.Size(70, 33);
            this.bioslabel.TabIndex = 11;
            this.bioslabel.Text = "BIOS:";
            this.bioslabel.Visible = false;
            // 
            // biosbilgisi
            // 
            this.biosbilgisi.AutoSize = true;
            this.biosbilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biosbilgisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.biosbilgisi.Location = new System.Drawing.Point(174, 217);
            this.biosbilgisi.Name = "biosbilgisi";
            this.biosbilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.biosbilgisi.Size = new System.Drawing.Size(69, 33);
            this.biosbilgisi.TabIndex = 12;
            this.biosbilgisi.Text = "label1";
            this.biosbilgisi.Visible = false;
            // 
            // isletimsistemilabel
            // 
            this.isletimsistemilabel.AutoSize = true;
            this.isletimsistemilabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isletimsistemilabel.ForeColor = System.Drawing.SystemColors.Info;
            this.isletimsistemilabel.Location = new System.Drawing.Point(13, 250);
            this.isletimsistemilabel.Name = "isletimsistemilabel";
            this.isletimsistemilabel.Padding = new System.Windows.Forms.Padding(6);
            this.isletimsistemilabel.Size = new System.Drawing.Size(139, 33);
            this.isletimsistemilabel.TabIndex = 13;
            this.isletimsistemilabel.Text = "İşletim Sistemi:";
            this.isletimsistemilabel.Visible = false;
            // 
            // isletimsistemibilgisi
            // 
            this.isletimsistemibilgisi.AutoSize = true;
            this.isletimsistemibilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isletimsistemibilgisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isletimsistemibilgisi.Location = new System.Drawing.Point(174, 250);
            this.isletimsistemibilgisi.Name = "isletimsistemibilgisi";
            this.isletimsistemibilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.isletimsistemibilgisi.Size = new System.Drawing.Size(69, 33);
            this.isletimsistemibilgisi.TabIndex = 14;
            this.isletimsistemibilgisi.Text = "label1";
            this.isletimsistemibilgisi.Visible = false;
            // 
            // bilgisayarmodellabel
            // 
            this.bilgisayarmodellabel.AutoSize = true;
            this.bilgisayarmodellabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgisayarmodellabel.ForeColor = System.Drawing.SystemColors.Info;
            this.bilgisayarmodellabel.Location = new System.Drawing.Point(13, 322);
            this.bilgisayarmodellabel.Name = "bilgisayarmodellabel";
            this.bilgisayarmodellabel.Padding = new System.Windows.Forms.Padding(6);
            this.bilgisayarmodellabel.Size = new System.Drawing.Size(166, 33);
            this.bilgisayarmodellabel.TabIndex = 15;
            this.bilgisayarmodellabel.Text = "Bilgisayar Modeli:";
            this.bilgisayarmodellabel.Visible = false;
            // 
            // bilgisayarmodelbilgisi
            // 
            this.bilgisayarmodelbilgisi.AutoSize = true;
            this.bilgisayarmodelbilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgisayarmodelbilgisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bilgisayarmodelbilgisi.Location = new System.Drawing.Point(170, 322);
            this.bilgisayarmodelbilgisi.Name = "bilgisayarmodelbilgisi";
            this.bilgisayarmodelbilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.bilgisayarmodelbilgisi.Size = new System.Drawing.Size(69, 33);
            this.bilgisayarmodelbilgisi.TabIndex = 16;
            this.bilgisayarmodelbilgisi.Text = "label1";
            this.bilgisayarmodelbilgisi.Visible = false;
            // 
            // sistembilgisilabel
            // 
            this.sistembilgisilabel.AutoSize = true;
            this.sistembilgisilabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sistembilgisilabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.sistembilgisilabel.Location = new System.Drawing.Point(384, 23);
            this.sistembilgisilabel.Name = "sistembilgisilabel";
            this.sistembilgisilabel.Padding = new System.Windows.Forms.Padding(6);
            this.sistembilgisilabel.Size = new System.Drawing.Size(190, 46);
            this.sistembilgisilabel.TabIndex = 19;
            this.sistembilgisilabel.Text = "Sistem Bilgisi";
            this.sistembilgisilabel.Visible = false;
            // 
            // kurkixlabel
            // 
            this.kurkixlabel.AutoSize = true;
            this.kurkixlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kurkixlabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.kurkixlabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.kurkixlabel.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.kurkixlabel.Location = new System.Drawing.Point(727, 361);
            this.kurkixlabel.Name = "kurkixlabel";
            this.kurkixlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kurkixlabel.Size = new System.Drawing.Size(189, 21);
            this.kurkixlabel.TabIndex = 20;
            this.kurkixlabel.TabStop = true;
            this.kurkixlabel.Text = "Kurkix © - kurkix.com";
            this.kurkixlabel.Visible = false;
            this.kurkixlabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kurkixlabel_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(57, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(367, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // bilgisayareadilabel
            // 
            this.bilgisayareadilabel.AutoSize = true;
            this.bilgisayareadilabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgisayareadilabel.ForeColor = System.Drawing.SystemColors.Info;
            this.bilgisayareadilabel.Location = new System.Drawing.Point(13, 289);
            this.bilgisayareadilabel.Name = "bilgisayareadilabel";
            this.bilgisayareadilabel.Padding = new System.Windows.Forms.Padding(6);
            this.bilgisayareadilabel.Size = new System.Drawing.Size(140, 33);
            this.bilgisayareadilabel.TabIndex = 22;
            this.bilgisayareadilabel.Text = "Bilgisayar Adı:";
            this.bilgisayareadilabel.Visible = false;
            // 
            // bilgisayaradibilgisi
            // 
            this.bilgisayaradibilgisi.AutoSize = true;
            this.bilgisayaradibilgisi.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bilgisayaradibilgisi.ForeColor = System.Drawing.SystemColors.Info;
            this.bilgisayaradibilgisi.Location = new System.Drawing.Point(170, 289);
            this.bilgisayaradibilgisi.Name = "bilgisayaradibilgisi";
            this.bilgisayaradibilgisi.Padding = new System.Windows.Forms.Padding(6);
            this.bilgisayaradibilgisi.Size = new System.Drawing.Size(69, 33);
            this.bilgisayaradibilgisi.TabIndex = 23;
            this.bilgisayaradibilgisi.Text = "label1";
            this.bilgisayaradibilgisi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(162)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 430);
            this.Controls.Add(this.bilgisayaradibilgisi);
            this.Controls.Add(this.bilgisayareadilabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kurkixlabel);
            this.Controls.Add(this.sistembilgisilabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bilgisayarmodelbilgisi);
            this.Controls.Add(this.bilgisayarmodellabel);
            this.Controls.Add(this.isletimsistemibilgisi);
            this.Controls.Add(this.isletimsistemilabel);
            this.Controls.Add(this.biosbilgisi);
            this.Controls.Add(this.bioslabel);
            this.Controls.Add(this.anakartbilgisi);
            this.Controls.Add(this.anakartlabel);
            this.Controls.Add(this.islemcibilgisi);
            this.Controls.Add(this.islemcilabel);
            this.Controls.Add(this.rambilgisi);
            this.Controls.Add(this.ramlabel);
            this.Controls.Add(this.ekrankartilabel);
            this.Controls.Add(this.ekranbilgisi);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.kapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Bilgisi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kucult;
        private System.Windows.Forms.Button kapat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ekranbilgisi;
        private System.Windows.Forms.Label ekrankartilabel;
        private System.Windows.Forms.Label ramlabel;
        private System.Windows.Forms.Label rambilgisi;
        private System.Windows.Forms.Label islemcilabel;
        private System.Windows.Forms.Label islemcibilgisi;
        private System.Windows.Forms.Label anakartlabel;
        private System.Windows.Forms.Label anakartbilgisi;
        private System.Windows.Forms.Label bioslabel;
        private System.Windows.Forms.Label biosbilgisi;
        private System.Windows.Forms.Label isletimsistemilabel;
        private System.Windows.Forms.Label isletimsistemibilgisi;
        private System.Windows.Forms.Label bilgisayarmodellabel;
        private System.Windows.Forms.Label bilgisayarmodelbilgisi;
        private System.Windows.Forms.Label sistembilgisilabel;
        private System.Windows.Forms.LinkLabel kurkixlabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label bilgisayareadilabel;
        private System.Windows.Forms.Label bilgisayaradibilgisi;
    }
}

