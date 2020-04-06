namespace Terminal2012
{
    partial class frm02_BarkodYuklemeMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm02_BarkodYuklemeMM));
            this.btnList = new System.Windows.Forms.Button();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.lbFisNo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdEmirList = new System.Windows.Forms.DataGrid();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.btnMalzemeAdres = new System.Windows.Forms.Button();
            this.lbRecordCount01 = new System.Windows.Forms.Label();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.pnPage02 = new System.Windows.Forms.Panel();
            this.lbRecordCount02 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbBarkod = new System.Windows.Forms.TextBox();
            this.lbOkutulanMiktar = new System.Windows.Forms.Label();
            this.tbOkutulanMiktar = new System.Windows.Forms.TextBox();
            this.grdBarkod = new System.Windows.Forms.DataGrid();
            this.lbAdet = new System.Windows.Forms.Label();
            this.tbEmirMiktari = new System.Windows.Forms.TextBox();
            this.tbMalzeme = new System.Windows.Forms.TextBox();
            this.pnPages = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnNavigation.SuspendLayout();
            this.pnPage01.SuspendLayout();
            this.pnSelection.SuspendLayout();
            this.pnPage02.SuspendLayout();
            this.pnPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Blue;
            this.btnList.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(8, 40);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 22);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtFisNo
            // 
            this.txtFisNo.BackColor = System.Drawing.Color.Black;
            this.txtFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtFisNo.ForeColor = System.Drawing.Color.Aqua;
            this.txtFisNo.Location = new System.Drawing.Point(83, 10);
            this.txtFisNo.MaxLength = 11;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(147, 21);
            this.txtFisNo.TabIndex = 0;
            this.txtFisNo.Text = "50000000004";
            this.txtFisNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFisNo_KeyUp);
            // 
            // lbFisNo
            // 
            this.lbFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbFisNo.Location = new System.Drawing.Point(13, 11);
            this.lbFisNo.Name = "lbFisNo";
            this.lbFisNo.Size = new System.Drawing.Size(64, 20);
            this.lbFisNo.Text = "Fiş No";
            this.lbFisNo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(120, 40);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 22);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Temizle";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grdEmirList
            // 
            this.grdEmirList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdEmirList.Location = new System.Drawing.Point(8, 72);
            this.grdEmirList.Name = "grdEmirList";
            this.grdEmirList.Size = new System.Drawing.Size(222, 137);
            this.grdEmirList.TabIndex = 4;
            this.grdEmirList.CurrentCellChanged += new System.EventHandler(this.grdEmirList_CurrentCellChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Green;
            this.btnPrev.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(8, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(76, 22);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<< Geri ";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Green;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(88, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 22);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Ileri >>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(170, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnNavigation
            // 
            this.pnNavigation.Controls.Add(this.btnPrev);
            this.pnNavigation.Controls.Add(this.btnClose);
            this.pnNavigation.Controls.Add(this.btnNext);
            this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnNavigation.Location = new System.Drawing.Point(0, 286);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(240, 34);
            // 
            // pnPage01
            // 
            this.pnPage01.Controls.Add(this.btnMalzemeAdres);
            this.pnPage01.Controls.Add(this.lbRecordCount01);
            this.pnPage01.Controls.Add(this.pnSelection);
            this.pnPage01.Controls.Add(this.grdEmirList);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 263);
            // 
            // btnMalzemeAdres
            // 
            this.btnMalzemeAdres.BackColor = System.Drawing.Color.Blue;
            this.btnMalzemeAdres.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMalzemeAdres.ForeColor = System.Drawing.Color.White;
            this.btnMalzemeAdres.Location = new System.Drawing.Point(8, 232);
            this.btnMalzemeAdres.Name = "btnMalzemeAdres";
            this.btnMalzemeAdres.Size = new System.Drawing.Size(222, 22);
            this.btnMalzemeAdres.TabIndex = 5;
            this.btnMalzemeAdres.Text = "Malzeme Adres Listesi";
            this.btnMalzemeAdres.Click += new System.EventHandler(this.btnMalzemeAdres_Click);
            // 
            // lbRecordCount01
            // 
            this.lbRecordCount01.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount01.Location = new System.Drawing.Point(8, 212);
            this.lbRecordCount01.Name = "lbRecordCount01";
            this.lbRecordCount01.Size = new System.Drawing.Size(222, 12);
            this.lbRecordCount01.Text = "Adet = 5";
            this.lbRecordCount01.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.lbFisNo);
            this.pnSelection.Controls.Add(this.btnClear);
            this.pnSelection.Controls.Add(this.btnList);
            this.pnSelection.Controls.Add(this.txtFisNo);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelection.Location = new System.Drawing.Point(0, 0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(240, 72);
            // 
            // pnPage02
            // 
            this.pnPage02.Controls.Add(this.lbRecordCount02);
            this.pnPage02.Controls.Add(this.btnDel);
            this.pnPage02.Controls.Add(this.btnAdd);
            this.pnPage02.Controls.Add(this.tbBarkod);
            this.pnPage02.Controls.Add(this.lbOkutulanMiktar);
            this.pnPage02.Controls.Add(this.tbOkutulanMiktar);
            this.pnPage02.Controls.Add(this.grdBarkod);
            this.pnPage02.Controls.Add(this.lbAdet);
            this.pnPage02.Controls.Add(this.tbEmirMiktari);
            this.pnPage02.Controls.Add(this.tbMalzeme);
            this.pnPage02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage02.Location = new System.Drawing.Point(0, 0);
            this.pnPage02.Name = "pnPage02";
            this.pnPage02.Size = new System.Drawing.Size(240, 263);
            // 
            // lbRecordCount02
            // 
            this.lbRecordCount02.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount02.Location = new System.Drawing.Point(8, 209);
            this.lbRecordCount02.Name = "lbRecordCount02";
            this.lbRecordCount02.Size = new System.Drawing.Size(222, 14);
            this.lbRecordCount02.Text = "Adet = 5";
            this.lbRecordCount02.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Blue;
            this.btnDel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(192, 232);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(38, 22);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "Sil";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(114, 232);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 22);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbBarkod
            // 
            this.tbBarkod.BackColor = System.Drawing.Color.Black;
            this.tbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.tbBarkod.Location = new System.Drawing.Point(8, 232);
            this.tbBarkod.MaxLength = 10;
            this.tbBarkod.Name = "tbBarkod";
            this.tbBarkod.Size = new System.Drawing.Size(100, 21);
            this.tbBarkod.TabIndex = 3;
            this.tbBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBarkod_KeyUp);
            // 
            // lbOkutulanMiktar
            // 
            this.lbOkutulanMiktar.Location = new System.Drawing.Point(13, 17);
            this.lbOkutulanMiktar.Name = "lbOkutulanMiktar";
            this.lbOkutulanMiktar.Size = new System.Drawing.Size(75, 14);
            this.lbOkutulanMiktar.Text = "Girilen Mikt.";
            this.lbOkutulanMiktar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbOkutulanMiktar
            // 
            this.tbOkutulanMiktar.BackColor = System.Drawing.Color.Black;
            this.tbOkutulanMiktar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbOkutulanMiktar.ForeColor = System.Drawing.Color.Aqua;
            this.tbOkutulanMiktar.Location = new System.Drawing.Point(91, 14);
            this.tbOkutulanMiktar.Name = "tbOkutulanMiktar";
            this.tbOkutulanMiktar.Size = new System.Drawing.Size(139, 21);
            this.tbOkutulanMiktar.TabIndex = 2;
            // 
            // grdBarkod
            // 
            this.grdBarkod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdBarkod.Location = new System.Drawing.Point(8, 91);
            this.grdBarkod.Name = "grdBarkod";
            this.grdBarkod.Size = new System.Drawing.Size(222, 115);
            this.grdBarkod.TabIndex = 29;
            this.grdBarkod.CurrentCellChanged += new System.EventHandler(this.grdBarkod_CurrentCellChanged);
            // 
            // lbAdet
            // 
            this.lbAdet.Location = new System.Drawing.Point(12, 41);
            this.lbAdet.Name = "lbAdet";
            this.lbAdet.Size = new System.Drawing.Size(75, 14);
            this.lbAdet.Text = "Emir Miktari";
            this.lbAdet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbEmirMiktari
            // 
            this.tbEmirMiktari.BackColor = System.Drawing.Color.Black;
            this.tbEmirMiktari.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbEmirMiktari.ForeColor = System.Drawing.Color.Aqua;
            this.tbEmirMiktari.Location = new System.Drawing.Point(91, 39);
            this.tbEmirMiktari.Name = "tbEmirMiktari";
            this.tbEmirMiktari.Size = new System.Drawing.Size(139, 21);
            this.tbEmirMiktari.TabIndex = 1;
            // 
            // tbMalzeme
            // 
            this.tbMalzeme.BackColor = System.Drawing.Color.Black;
            this.tbMalzeme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbMalzeme.ForeColor = System.Drawing.Color.Aqua;
            this.tbMalzeme.Location = new System.Drawing.Point(8, 64);
            this.tbMalzeme.Name = "tbMalzeme";
            this.tbMalzeme.Size = new System.Drawing.Size(222, 21);
            this.tbMalzeme.TabIndex = 0;
            // 
            // pnPages
            // 
            this.pnPages.Controls.Add(this.pnPage01);
            this.pnPages.Controls.Add(this.pnPage02);
            this.pnPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPages.Location = new System.Drawing.Point(0, 23);
            this.pnPages.Name = "pnPages";
            this.pnPages.Size = new System.Drawing.Size(240, 263);
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Navy;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(240, 23);
            this.lbTitle.Text = "[2] Barkod Yukleme (MM)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm02_BarkodYuklemeMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.pnPages);
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm02_BarkodYuklemeMM";
            this.Text = "Barkod Yukleme (MM)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm02_BarkodYuklemeMM_Load);
            this.pnNavigation.ResumeLayout(false);
            this.pnPage01.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnPage02.ResumeLayout(false);
            this.pnPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtFisNo;
        private System.Windows.Forms.Label lbFisNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGrid grdEmirList;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Panel pnPage01;
        private System.Windows.Forms.Panel pnPage02;
        private System.Windows.Forms.Label lbAdet;
        private System.Windows.Forms.TextBox tbEmirMiktari;
        private System.Windows.Forms.TextBox tbMalzeme;
        private System.Windows.Forms.DataGrid grdBarkod;
        private System.Windows.Forms.Label lbOkutulanMiktar;
        private System.Windows.Forms.TextBox tbOkutulanMiktar;
        private System.Windows.Forms.TextBox tbBarkod;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnSelection;
        private System.Windows.Forms.Panel pnPages;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbRecordCount01;
        private System.Windows.Forms.Label lbRecordCount02;
        private System.Windows.Forms.Button btnMalzemeAdres;
    }
}

