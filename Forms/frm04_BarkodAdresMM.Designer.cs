namespace Terminal2012
{
    partial class frm04_BarkodAdresMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm04_BarkodAdresMM));
            this.btnList = new System.Windows.Forms.Button();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.lbAdres = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGrid();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.lbRecordCount01 = new System.Windows.Forms.Label();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.cbDepo = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbBarkod = new System.Windows.Forms.Label();
            this.tbBarkod = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnPage02 = new System.Windows.Forms.Panel();
            this.pnPages = new System.Windows.Forms.Panel();
            this.lbBarkodSave = new System.Windows.Forms.Label();
            this.pnNavigation.SuspendLayout();
            this.pnPage01.SuspendLayout();
            this.pnSelection.SuspendLayout();
            this.pnPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Blue;
            this.btnList.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(8, 98);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(104, 22);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Listele";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // tbAdres
            // 
            this.tbAdres.BackColor = System.Drawing.Color.Black;
            this.tbAdres.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbAdres.ForeColor = System.Drawing.Color.Aqua;
            this.tbAdres.Location = new System.Drawing.Point(60, 14);
            this.tbAdres.MaxLength = 10;
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 21);
            this.tbAdres.TabIndex = 0;
            this.tbAdres.TextChanged += new System.EventHandler(this.tbAdres_TextChanged);
            this.tbAdres.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbALL_KeyUp);
            // 
            // lbAdres
            // 
            this.lbAdres.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbAdres.Location = new System.Drawing.Point(4, 15);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(51, 20);
            this.lbAdres.Text = "Adres";
            this.lbAdres.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(120, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 22);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Temizle";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grdList
            // 
            this.grdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdList.Location = new System.Drawing.Point(8, 153);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(222, 88);
            this.grdList.TabIndex = 4;
            this.grdList.CurrentCellChanged += new System.EventHandler(this.grdList_CurrentCellChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Green;
            this.btnPrev.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(13, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(74, 22);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "<< Geri ";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Green;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(91, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(74, 22);
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
            this.pnPage01.Controls.Add(this.lbBarkodSave);
            this.pnPage01.Controls.Add(this.txtMalzeme);
            this.pnPage01.Controls.Add(this.lbRecordCount01);
            this.pnPage01.Controls.Add(this.pnSelection);
            this.pnPage01.Controls.Add(this.grdList);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 263);
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.BackColor = System.Drawing.Color.Black;
            this.txtMalzeme.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzeme.ForeColor = System.Drawing.Color.Aqua;
            this.txtMalzeme.Location = new System.Drawing.Point(8, 126);
            this.txtMalzeme.MaxLength = 10;
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(222, 21);
            this.txtMalzeme.TabIndex = 5;
            // 
            // lbRecordCount01
            // 
            this.lbRecordCount01.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount01.Location = new System.Drawing.Point(152, 244);
            this.lbRecordCount01.Name = "lbRecordCount01";
            this.lbRecordCount01.Size = new System.Drawing.Size(78, 18);
            this.lbRecordCount01.Text = "Adet = 5";
            this.lbRecordCount01.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.cbDepo);
            this.pnSelection.Controls.Add(this.btnSave);
            this.pnSelection.Controls.Add(this.lbBarkod);
            this.pnSelection.Controls.Add(this.tbBarkod);
            this.pnSelection.Controls.Add(this.lbAdres);
            this.pnSelection.Controls.Add(this.btnClear);
            this.pnSelection.Controls.Add(this.btnList);
            this.pnSelection.Controls.Add(this.tbAdres);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelection.Location = new System.Drawing.Point(0, 0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(240, 123);
            // 
            // cbDepo
            // 
            this.cbDepo.BackColor = System.Drawing.Color.Black;
            this.cbDepo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbDepo.ForeColor = System.Drawing.Color.Aqua;
            this.cbDepo.Items.Add("12000");
            this.cbDepo.Items.Add("20000");
            this.cbDepo.Location = new System.Drawing.Point(8, 67);
            this.cbDepo.Name = "cbDepo";
            this.cbDepo.Size = new System.Drawing.Size(222, 24);
            this.cbDepo.TabIndex = 10;
            this.cbDepo.SelectedIndexChanged += new System.EventHandler(this.cbDepo_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(166, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbBarkod
            // 
            this.lbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbBarkod.Location = new System.Drawing.Point(5, 42);
            this.lbBarkod.Name = "lbBarkod";
            this.lbBarkod.Size = new System.Drawing.Size(50, 20);
            this.lbBarkod.Text = "Barkod";
            this.lbBarkod.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbBarkod
            // 
            this.tbBarkod.BackColor = System.Drawing.Color.Black;
            this.tbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.tbBarkod.Location = new System.Drawing.Point(60, 41);
            this.tbBarkod.MaxLength = 10;
            this.tbBarkod.Name = "tbBarkod";
            this.tbBarkod.Size = new System.Drawing.Size(100, 21);
            this.tbBarkod.TabIndex = 1;
            this.tbBarkod.Text = "5012000173";
            this.tbBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbALL_KeyUp);
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
            this.lbTitle.Text = "[4] Barkod Adres (MM)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnPage02
            // 
            this.pnPage02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage02.Location = new System.Drawing.Point(0, 0);
            this.pnPage02.Name = "pnPage02";
            this.pnPage02.Size = new System.Drawing.Size(240, 263);
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
            // lbBarkodSave
            // 
            this.lbBarkodSave.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbBarkodSave.Location = new System.Drawing.Point(9, 242);
            this.lbBarkodSave.Name = "lbBarkodSave";
            this.lbBarkodSave.Size = new System.Drawing.Size(128, 18);
            this.lbBarkodSave.Text = "Barkod";
            // 
            // frm04_BarkodAdresMM
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
            this.Name = "frm04_BarkodAdresMM";
            this.Text = "Barkod Adres (MM)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm04_BarkodAdresMM_Load);
            this.pnNavigation.ResumeLayout(false);
            this.pnPage01.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGrid grdList;
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
        private System.Windows.Forms.Label lbRecordCount01;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbDepo;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.Label lbBarkodSave;
    }
}

