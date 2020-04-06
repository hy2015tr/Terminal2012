namespace Terminal2012
{
    partial class frm03_BarkodIndirmeMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm03_BarkodIndirmeMM));
            this.btnList = new System.Windows.Forms.Button();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.lbFisNo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdIndirilecekMalzemeler = new System.Windows.Forms.DataGrid();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.btnAdres = new System.Windows.Forms.Button();
            this.lbRecordCount01 = new System.Windows.Forms.Label();
            this.lbIndirilecekMalzemeler = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnIndir = new System.Windows.Forms.Button();
            this.lbBarkod = new System.Windows.Forms.Label();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.lbAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnPage02 = new System.Windows.Forms.Panel();
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
            this.btnList.Location = new System.Drawing.Point(8, 66);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 22);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtFisNo
            // 
            this.txtFisNo.BackColor = System.Drawing.Color.Black;
            this.txtFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtFisNo.ForeColor = System.Drawing.Color.Aqua;
            this.txtFisNo.Location = new System.Drawing.Point(88, 12);
            this.txtFisNo.MaxLength = 11;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(142, 21);
            this.txtFisNo.TabIndex = 0;
            this.txtFisNo.Text = "50000000004";
            this.txtFisNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbALL_KeyUp);
            // 
            // lbFisNo
            // 
            this.lbFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbFisNo.Location = new System.Drawing.Point(38, 12);
            this.lbFisNo.Name = "lbFisNo";
            this.lbFisNo.Size = new System.Drawing.Size(44, 20);
            this.lbFisNo.Text = "Fiş No";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(120, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 22);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Temizle";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grdIndirilecekMalzemeler
            // 
            this.grdIndirilecekMalzemeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdIndirilecekMalzemeler.Location = new System.Drawing.Point(8, 108);
            this.grdIndirilecekMalzemeler.Name = "grdIndirilecekMalzemeler";
            this.grdIndirilecekMalzemeler.Size = new System.Drawing.Size(222, 102);
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
            this.pnPage01.Controls.Add(this.btnAdres);
            this.pnPage01.Controls.Add(this.lbRecordCount01);
            this.pnPage01.Controls.Add(this.grdIndirilecekMalzemeler);
            this.pnPage01.Controls.Add(this.lbIndirilecekMalzemeler);
            this.pnPage01.Controls.Add(this.txtBarkod);
            this.pnPage01.Controls.Add(this.btnIndir);
            this.pnPage01.Controls.Add(this.lbBarkod);
            this.pnPage01.Controls.Add(this.pnSelection);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 263);
            // 
            // btnAdres
            // 
            this.btnAdres.BackColor = System.Drawing.Color.Blue;
            this.btnAdres.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdres.ForeColor = System.Drawing.Color.White;
            this.btnAdres.Location = new System.Drawing.Point(174, 232);
            this.btnAdres.Name = "btnAdres";
            this.btnAdres.Size = new System.Drawing.Size(56, 22);
            this.btnAdres.TabIndex = 3;
            this.btnAdres.Text = "Adres";
            this.btnAdres.Click += new System.EventHandler(this.btnAdres_Click);
            // 
            // lbRecordCount01
            // 
            this.lbRecordCount01.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount01.Location = new System.Drawing.Point(113, 211);
            this.lbRecordCount01.Name = "lbRecordCount01";
            this.lbRecordCount01.Size = new System.Drawing.Size(117, 18);
            this.lbRecordCount01.Text = "Adet = 5";
            this.lbRecordCount01.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbIndirilecekMalzemeler
            // 
            this.lbIndirilecekMalzemeler.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbIndirilecekMalzemeler.Location = new System.Drawing.Point(8, 92);
            this.lbIndirilecekMalzemeler.Name = "lbIndirilecekMalzemeler";
            this.lbIndirilecekMalzemeler.Size = new System.Drawing.Size(222, 13);
            this.lbIndirilecekMalzemeler.Text = "Indirilecek Malzemeler :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.Black;
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.txtBarkod.Location = new System.Drawing.Point(8, 232);
            this.txtBarkod.MaxLength = 10;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 21);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyUp);
            // 
            // btnIndir
            // 
            this.btnIndir.BackColor = System.Drawing.Color.Blue;
            this.btnIndir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnIndir.ForeColor = System.Drawing.Color.White;
            this.btnIndir.Location = new System.Drawing.Point(113, 232);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(56, 22);
            this.btnIndir.TabIndex = 2;
            this.btnIndir.Text = "Indir";
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // lbBarkod
            // 
            this.lbBarkod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbBarkod.Location = new System.Drawing.Point(8, 213);
            this.lbBarkod.Name = "lbBarkod";
            this.lbBarkod.Size = new System.Drawing.Size(60, 20);
            this.lbBarkod.Text = "Barkod:";
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.lbAdres);
            this.pnSelection.Controls.Add(this.txtAdres);
            this.pnSelection.Controls.Add(this.lbFisNo);
            this.pnSelection.Controls.Add(this.btnClear);
            this.pnSelection.Controls.Add(this.btnList);
            this.pnSelection.Controls.Add(this.txtFisNo);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelection.Location = new System.Drawing.Point(0, 0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(240, 91);
            // 
            // lbAdres
            // 
            this.lbAdres.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbAdres.Location = new System.Drawing.Point(38, 40);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(44, 20);
            this.lbAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.Black;
            this.txtAdres.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtAdres.ForeColor = System.Drawing.Color.Aqua;
            this.txtAdres.Location = new System.Drawing.Point(88, 39);
            this.txtAdres.MaxLength = 10;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(142, 21);
            this.txtAdres.TabIndex = 1;
            this.txtAdres.TextChanged += new System.EventHandler(this.tbAdres_TextChanged);
            this.txtAdres.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbALL_KeyUp);
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
            this.lbTitle.Text = "[3] Barkod Indirme (MM)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnPage02
            // 
            this.pnPage02.Controls.Add(this.lbRecordCount02);
            this.pnPage02.Controls.Add(this.grdIndirilmisMalzemeler);
            this.pnPage02.Controls.Add(this.lbIndirilmisMalzemeler);
            this.pnPage02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage02.Location = new System.Drawing.Point(0, 0);
            this.pnPage02.Name = "pnPage02";
            this.pnPage02.Size = new System.Drawing.Size(240, 263);
            // 
            // lbRecordCount02
            // 
            this.lbRecordCount02.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount02.Location = new System.Drawing.Point(8, 242);
            this.lbRecordCount02.Name = "lbRecordCount02";
            this.lbRecordCount02.Size = new System.Drawing.Size(222, 12);
            this.lbRecordCount02.Text = "Adet = 5";
            this.lbRecordCount02.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grdIndirilmisMalzemeler
            // 
            this.grdIndirilmisMalzemeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdIndirilmisMalzemeler.Location = new System.Drawing.Point(8, 28);
            this.grdIndirilmisMalzemeler.Name = "grdIndirilmisMalzemeler";
            this.grdIndirilmisMalzemeler.Size = new System.Drawing.Size(222, 211);
            this.grdIndirilmisMalzemeler.TabIndex = 5;
            this.grdIndirilmisMalzemeler.CurrentCellChanged += new System.EventHandler(this.gridALL_CurrentCellChanged);
            // 
            // lbIndirilmisMalzemeler
            // 
            this.lbIndirilmisMalzemeler.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbIndirilmisMalzemeler.Location = new System.Drawing.Point(8, 6);
            this.lbIndirilmisMalzemeler.Name = "lbIndirilmisMalzemeler";
            this.lbIndirilmisMalzemeler.Size = new System.Drawing.Size(222, 19);
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
            // frm03_BarkodIndirmeMM
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
            this.Name = "frm03_BarkodIndirmeMM";
            this.Text = "Barkod Indirme (MM)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm03_BarkodIndirmeMM_Load);
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
        private System.Windows.Forms.Label lbIndirilmisMalzemeler;
        private System.Windows.Forms.DataGrid grdIndirilmisMalzemeler;
        private System.Windows.Forms.Label lbBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Label lbIndirilecekMalzemeler;
        private System.Windows.Forms.Label lbRecordCount02;
        private System.Windows.Forms.Label lbRecordCount01;
        private System.Windows.Forms.Button btnAdres;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.TextBox txtAdres;
    }
}

