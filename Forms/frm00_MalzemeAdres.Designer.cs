namespace Terminal2012
{
    partial class frm00_MalzemeAdres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm00_MalzemeAdres));
            this.tbMlzNo = new System.Windows.Forms.TextBox();
            this.lbMlzNo = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.lbRecordCount01 = new System.Windows.Forms.Label();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.lbMlzAdi = new System.Windows.Forms.Label();
            this.tbMlzAdi = new System.Windows.Forms.TextBox();
            this.lbBarkod = new System.Windows.Forms.Label();
            this.tbBarkod = new System.Windows.Forms.TextBox();
            this.tbPosnr = new System.Windows.Forms.TextBox();
            this.lbBelge = new System.Windows.Forms.Label();
            this.tbVbeln = new System.Windows.Forms.TextBox();
            this.pnPages = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnNavigation.SuspendLayout();
            this.pnPage01.SuspendLayout();
            this.pnSelection.SuspendLayout();
            this.pnPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMlzNo
            // 
            this.tbMlzNo.BackColor = System.Drawing.Color.Black;
            this.tbMlzNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbMlzNo.ForeColor = System.Drawing.Color.Aqua;
            this.tbMlzNo.Location = new System.Drawing.Point(63, 13);
            this.tbMlzNo.Name = "tbMlzNo";
            this.tbMlzNo.Size = new System.Drawing.Size(167, 21);
            this.tbMlzNo.TabIndex = 0;
            // 
            // lbMlzNo
            // 
            this.lbMlzNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMlzNo.Location = new System.Drawing.Point(8, 13);
            this.lbMlzNo.Name = "lbMlzNo";
            this.lbMlzNo.Size = new System.Drawing.Size(47, 14);
            this.lbMlzNo.Text = "Mlz.No";
            // 
            // grdList
            // 
            this.grdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdList.Location = new System.Drawing.Point(8, 124);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(222, 121);
            this.grdList.TabIndex = 4;
            this.grdList.CurrentCellChanged += new System.EventHandler(this.grdList_CurrentCellChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(8, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(222, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnNavigation
            // 
            this.pnNavigation.Controls.Add(this.btnClose);
            this.pnNavigation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnNavigation.Location = new System.Drawing.Point(0, 286);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(240, 34);
            // 
            // pnPage01
            // 
            this.pnPage01.Controls.Add(this.lbRecordCount01);
            this.pnPage01.Controls.Add(this.pnSelection);
            this.pnPage01.Controls.Add(this.grdList);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 263);
            // 
            // lbRecordCount01
            // 
            this.lbRecordCount01.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount01.Location = new System.Drawing.Point(142, 245);
            this.lbRecordCount01.Name = "lbRecordCount01";
            this.lbRecordCount01.Size = new System.Drawing.Size(88, 12);
            this.lbRecordCount01.Text = "Adet = 5";
            this.lbRecordCount01.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.lbMlzAdi);
            this.pnSelection.Controls.Add(this.tbMlzAdi);
            this.pnSelection.Controls.Add(this.lbBarkod);
            this.pnSelection.Controls.Add(this.tbBarkod);
            this.pnSelection.Controls.Add(this.tbPosnr);
            this.pnSelection.Controls.Add(this.lbBelge);
            this.pnSelection.Controls.Add(this.tbVbeln);
            this.pnSelection.Controls.Add(this.lbMlzNo);
            this.pnSelection.Controls.Add(this.tbMlzNo);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelection.Location = new System.Drawing.Point(0, 0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(240, 124);
            // 
            // lbMlzAdi
            // 
            this.lbMlzAdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMlzAdi.Location = new System.Drawing.Point(9, 85);
            this.lbMlzAdi.Name = "lbMlzAdi";
            this.lbMlzAdi.Size = new System.Drawing.Size(51, 17);
            this.lbMlzAdi.Text = "Mlz.Adı";
            // 
            // tbMlzAdi
            // 
            this.tbMlzAdi.BackColor = System.Drawing.Color.Black;
            this.tbMlzAdi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbMlzAdi.ForeColor = System.Drawing.Color.Aqua;
            this.tbMlzAdi.Location = new System.Drawing.Point(63, 76);
            this.tbMlzAdi.Multiline = true;
            this.tbMlzAdi.Name = "tbMlzAdi";
            this.tbMlzAdi.Size = new System.Drawing.Size(167, 40);
            this.tbMlzAdi.TabIndex = 12;
            // 
            // lbBarkod
            // 
            this.lbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbBarkod.Location = new System.Drawing.Point(8, 62);
            this.lbBarkod.Name = "lbBarkod";
            this.lbBarkod.Size = new System.Drawing.Size(52, 14);
            this.lbBarkod.Text = "Barkod";
            // 
            // tbBarkod
            // 
            this.tbBarkod.BackColor = System.Drawing.Color.Black;
            this.tbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.tbBarkod.Location = new System.Drawing.Point(63, 55);
            this.tbBarkod.Name = "tbBarkod";
            this.tbBarkod.Size = new System.Drawing.Size(167, 21);
            this.tbBarkod.TabIndex = 8;
            // 
            // tbPosnr
            // 
            this.tbPosnr.BackColor = System.Drawing.Color.Black;
            this.tbPosnr.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbPosnr.ForeColor = System.Drawing.Color.Aqua;
            this.tbPosnr.Location = new System.Drawing.Point(157, 34);
            this.tbPosnr.Name = "tbPosnr";
            this.tbPosnr.Size = new System.Drawing.Size(73, 21);
            this.tbPosnr.TabIndex = 5;
            // 
            // lbBelge
            // 
            this.lbBelge.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbBelge.Location = new System.Drawing.Point(6, 34);
            this.lbBelge.Name = "lbBelge";
            this.lbBelge.Size = new System.Drawing.Size(56, 14);
            this.lbBelge.Text = "Blg/Klm";
            // 
            // tbVbeln
            // 
            this.tbVbeln.BackColor = System.Drawing.Color.Black;
            this.tbVbeln.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.tbVbeln.ForeColor = System.Drawing.Color.Aqua;
            this.tbVbeln.Location = new System.Drawing.Point(63, 34);
            this.tbVbeln.Name = "tbVbeln";
            this.tbVbeln.Size = new System.Drawing.Size(94, 21);
            this.tbVbeln.TabIndex = 2;
            // 
            // pnPages
            // 
            this.pnPages.Controls.Add(this.pnPage01);
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
            this.lbTitle.Text = "Malzeme Adres";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm00_MalzemeAdres
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
            this.Name = "frm00_MalzemeAdres";
            this.Text = "Malzeme Adres";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm00_MalzemeAdres_Load);
            this.pnNavigation.ResumeLayout(false);
            this.pnPage01.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMlzNo;
        private System.Windows.Forms.Label lbMlzNo;
        private System.Windows.Forms.DataGrid grdList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Panel pnPage01;
        private System.Windows.Forms.Panel pnSelection;
        private System.Windows.Forms.Panel pnPages;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbRecordCount01;
        private System.Windows.Forms.TextBox tbPosnr;
        private System.Windows.Forms.Label lbBelge;
        private System.Windows.Forms.TextBox tbVbeln;
        private System.Windows.Forms.Label lbBarkod;
        private System.Windows.Forms.TextBox tbBarkod;
        private System.Windows.Forms.Label lbMlzAdi;
        private System.Windows.Forms.TextBox tbMlzAdi;
    }
}

