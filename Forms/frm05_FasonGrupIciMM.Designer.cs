namespace Terminal2012
{
    partial class frm05_FasonGrupIciMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm05_FasonGrupIciMM));
            this.btnList = new System.Windows.Forms.Button();
            this.tbFisNo = new System.Windows.Forms.TextBox();
            this.lbFisNo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdIndirilecekMalzemeler = new System.Windows.Forms.DataGrid();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.lbAdres = new System.Windows.Forms.Label();
            this.lbRecordCount01 = new System.Windows.Forms.Label();
            this.lbIndirilecekMalzemeler = new System.Windows.Forms.Label();
            this.tbBarkod = new System.Windows.Forms.TextBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.lbBarkod = new System.Windows.Forms.Label();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYuklemeEmri = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnPage02 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbRecordCount02 = new System.Windows.Forms.Label();
            this.grdIndirilmisMalzemeler = new System.Windows.Forms.DataGrid();
            this.lbIndirilmisMalzemeler = new System.Windows.Forms.Label();
            this.pnPages = new System.Windows.Forms.Panel();
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
            this.btnList.Location = new System.Drawing.Point(8, 67);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 22);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // tbFisNo
            // 
            this.tbFisNo.BackColor = System.Drawing.Color.Black;
            this.tbFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbFisNo.ForeColor = System.Drawing.Color.Aqua;
            this.tbFisNo.Location = new System.Drawing.Point(83, 14);
            this.tbFisNo.MaxLength = 11;
            this.tbFisNo.Name = "tbFisNo";
            this.tbFisNo.Size = new System.Drawing.Size(147, 21);
            this.tbFisNo.TabIndex = 0;
            this.tbFisNo.Text = "50000000004";
            this.tbFisNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbALL_KeyUp);
            // 
            // lbFisNo
            // 
            this.lbFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbFisNo.Location = new System.Drawing.Point(13, 15);
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
            this.btnClear.Location = new System.Drawing.Point(120, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 22);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Temizle";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grdIndirilecekMalzemeler
            // 
            this.grdIndirilecekMalzemeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdIndirilecekMalzemeler.Location = new System.Drawing.Point(8, 114);
            this.grdIndirilecekMalzemeler.Name = "grdIndirilecekMalzemeler";
            this.grdIndirilecekMalzemeler.Size = new System.Drawing.Size(222, 93);
            this.grdIndirilecekMalzemeler.TabIndex = 0;
            this.grdIndirilecekMalzemeler.CurrentCellChanged += new System.EventHandler(this.gridALL_CurrentCellChanged);
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
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.pnPage01.Controls.Add(this.tbAdres);
            this.pnPage01.Controls.Add(this.lbAdres);
            this.pnPage01.Controls.Add(this.lbRecordCount01);
            this.pnPage01.Controls.Add(this.grdIndirilecekMalzemeler);
            this.pnPage01.Controls.Add(this.lbIndirilecekMalzemeler);
            this.pnPage01.Controls.Add(this.tbBarkod);
            this.pnPage01.Controls.Add(this.btnDown);
            this.pnPage01.Controls.Add(this.lbBarkod);
            this.pnPage01.Controls.Add(this.pnSelection);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 263);
            // 
            // tbAdres
            // 
            this.tbAdres.BackColor = System.Drawing.Color.Black;
            this.tbAdres.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbAdres.ForeColor = System.Drawing.Color.Aqua;
            this.tbAdres.Location = new System.Drawing.Point(59, 212);
            this.tbAdres.MaxLength = 10;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(99, 21);
            this.tbAdres.TabIndex = 6;
            // 
            // lbAdres
            // 
            this.lbAdres.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbAdres.Location = new System.Drawing.Point(8, 214);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(50, 20);
            this.lbAdres.Text = "Adres:";
            this.lbAdres.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRecordCount01
            // 
            this.lbRecordCount01.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount01.Location = new System.Drawing.Point(163, 212);
            this.lbRecordCount01.Name = "lbRecordCount01";
            this.lbRecordCount01.Size = new System.Drawing.Size(67, 19);
            this.lbRecordCount01.Text = "Adet = 5";
            this.lbRecordCount01.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbIndirilecekMalzemeler
            // 
            this.lbIndirilecekMalzemeler.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbIndirilecekMalzemeler.Location = new System.Drawing.Point(8, 97);
            this.lbIndirilecekMalzemeler.Name = "lbIndirilecekMalzemeler";
            this.lbIndirilecekMalzemeler.Size = new System.Drawing.Size(222, 20);
            this.lbIndirilecekMalzemeler.Text = "Indirilecek Malzemeler :";
            // 
            // tbBarkod
            // 
            this.tbBarkod.BackColor = System.Drawing.Color.Black;
            this.tbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.tbBarkod.Location = new System.Drawing.Point(59, 235);
            this.tbBarkod.MaxLength = 10;
            this.tbBarkod.Name = "tbBarkod";
            this.tbBarkod.Size = new System.Drawing.Size(99, 21);
            this.tbBarkod.TabIndex = 1;
            this.tbBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBarkod_KeyUp);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Blue;
            this.btnDown.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(163, 234);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(67, 22);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Indir";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lbBarkod
            // 
            this.lbBarkod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbBarkod.Location = new System.Drawing.Point(3, 237);
            this.lbBarkod.Name = "lbBarkod";
            this.lbBarkod.Size = new System.Drawing.Size(60, 20);
            this.lbBarkod.Text = "Barkod:";
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.label1);
            this.pnSelection.Controls.Add(this.tbYuklemeEmri);
            this.pnSelection.Controls.Add(this.lbFisNo);
            this.pnSelection.Controls.Add(this.btnClear);
            this.pnSelection.Controls.Add(this.btnList);
            this.pnSelection.Controls.Add(this.tbFisNo);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelection.Location = new System.Drawing.Point(0, 0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(240, 94);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.Text = "Yükl. Emri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbYuklemeEmri
            // 
            this.tbYuklemeEmri.BackColor = System.Drawing.Color.Black;
            this.tbYuklemeEmri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbYuklemeEmri.ForeColor = System.Drawing.Color.Aqua;
            this.tbYuklemeEmri.Location = new System.Drawing.Point(82, 40);
            this.tbYuklemeEmri.MaxLength = 11;
            this.tbYuklemeEmri.Name = "tbYuklemeEmri";
            this.tbYuklemeEmri.Size = new System.Drawing.Size(147, 21);
            this.tbYuklemeEmri.TabIndex = 1;
            this.tbYuklemeEmri.Text = "10000000018";
            this.tbYuklemeEmri.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbALL_KeyUp);
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
            this.lbTitle.Text = "[5] G.İçi Fason İnd. (MM)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnPage02
            // 
            this.pnPage02.Controls.Add(this.btnDelete);
            this.pnPage02.Controls.Add(this.lbRecordCount02);
            this.pnPage02.Controls.Add(this.grdIndirilmisMalzemeler);
            this.pnPage02.Controls.Add(this.lbIndirilmisMalzemeler);
            this.pnPage02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage02.Location = new System.Drawing.Point(0, 0);
            this.pnPage02.Name = "pnPage02";
            this.pnPage02.Size = new System.Drawing.Size(240, 263);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Blue;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(170, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 22);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbRecordCount02
            // 
            this.lbRecordCount02.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount02.Location = new System.Drawing.Point(8, 244);
            this.lbRecordCount02.Name = "lbRecordCount02";
            this.lbRecordCount02.Size = new System.Drawing.Size(222, 12);
            this.lbRecordCount02.Text = "Adet = 5";
            this.lbRecordCount02.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grdIndirilmisMalzemeler
            // 
            this.grdIndirilmisMalzemeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdIndirilmisMalzemeler.Location = new System.Drawing.Point(9, 32);
            this.grdIndirilmisMalzemeler.Name = "grdIndirilmisMalzemeler";
            this.grdIndirilmisMalzemeler.Size = new System.Drawing.Size(222, 209);
            this.grdIndirilmisMalzemeler.TabIndex = 8;
            // 
            // lbIndirilmisMalzemeler
            // 
            this.lbIndirilmisMalzemeler.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbIndirilmisMalzemeler.Location = new System.Drawing.Point(9, 11);
            this.lbIndirilmisMalzemeler.Name = "lbIndirilmisMalzemeler";
            this.lbIndirilmisMalzemeler.Size = new System.Drawing.Size(164, 18);
            this.lbIndirilmisMalzemeler.Text = "Indirilmis Malzemeler :";
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
            // frm05_FasonGrupIciMM
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
            this.Name = "frm05_FasonGrupIciMM";
            this.Text = "G.İçi Fason İnd. (MM)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm05_FasonGrupIciMM_Load);
            this.pnNavigation.ResumeLayout(false);
            this.pnPage01.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnPage02.ResumeLayout(false);
            this.pnPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox tbFisNo;
        private System.Windows.Forms.Label lbFisNo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGrid grdIndirilecekMalzemeler;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Panel pnPage01;
        private System.Windows.Forms.Panel pnPage02;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnSelection;
        private System.Windows.Forms.Panel pnPages;
        private System.Windows.Forms.Label lbBarkod;
        private System.Windows.Forms.TextBox tbBarkod;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lbRecordCount01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYuklemeEmri;
        private System.Windows.Forms.Label lbIndirilecekMalzemeler;
        private System.Windows.Forms.Label lbRecordCount02;
        private System.Windows.Forms.DataGrid grdIndirilmisMalzemeler;
        private System.Windows.Forms.Label lbIndirilmisMalzemeler;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Button btnDelete;
    }
}

