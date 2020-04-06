namespace Terminal2012
{
    partial class frm13_BarkodKontrolSD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm13_BarkodKontrolSD));
            this.btnBarkod = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.btnFisNo = new System.Windows.Forms.Button();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.pnPages = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnPage01.SuspendLayout();
            this.pnPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBarkod
            // 
            this.btnBarkod.BackColor = System.Drawing.Color.Blue;
            this.btnBarkod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBarkod.ForeColor = System.Drawing.Color.White;
            this.btnBarkod.Location = new System.Drawing.Point(154, 225);
            this.btnBarkod.Name = "btnBarkod";
            this.btnBarkod.Size = new System.Drawing.Size(76, 22);
            this.btnBarkod.TabIndex = 1;
            this.btnBarkod.Text = "Barkod";
            this.btnBarkod.Click += new System.EventHandler(this.btnBarkod_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.Black;
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.txtBarkod.Location = new System.Drawing.Point(8, 225);
            this.txtBarkod.MaxLength = 10;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(140, 21);
            this.txtBarkod.TabIndex = 0;
            this.txtBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(8, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 22);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Temizle";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grdList
            // 
            this.grdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdList.Location = new System.Drawing.Point(8, 51);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(222, 156);
            this.grdList.TabIndex = 0;
            this.grdList.CurrentCellChanged += new System.EventHandler(this.grdList_CurrentCellChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(122, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Kapat";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnPage01
            // 
            this.pnPage01.Controls.Add(this.btnFisNo);
            this.pnPage01.Controls.Add(this.txtFisNo);
            this.pnPage01.Controls.Add(this.btnBarkod);
            this.pnPage01.Controls.Add(this.btnClose);
            this.pnPage01.Controls.Add(this.txtBarkod);
            this.pnPage01.Controls.Add(this.btnClear);
            this.pnPage01.Controls.Add(this.grdList);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 297);
            // 
            // btnFisNo
            // 
            this.btnFisNo.BackColor = System.Drawing.Color.Blue;
            this.btnFisNo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnFisNo.ForeColor = System.Drawing.Color.White;
            this.btnFisNo.Location = new System.Drawing.Point(154, 14);
            this.btnFisNo.Name = "btnFisNo";
            this.btnFisNo.Size = new System.Drawing.Size(76, 22);
            this.btnFisNo.TabIndex = 4;
            this.btnFisNo.Text = "FisNo";
            this.btnFisNo.Click += new System.EventHandler(this.btnFisNo_Click);
            // 
            // txtFisNo
            // 
            this.txtFisNo.BackColor = System.Drawing.Color.Black;
            this.txtFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtFisNo.ForeColor = System.Drawing.Color.Aqua;
            this.txtFisNo.Location = new System.Drawing.Point(8, 14);
            this.txtFisNo.MaxLength = 11;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(140, 21);
            this.txtFisNo.TabIndex = 3;
            this.txtFisNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFisNo_KeyUp);
            // 
            // pnPages
            // 
            this.pnPages.Controls.Add(this.pnPage01);
            this.pnPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPages.Location = new System.Drawing.Point(0, 23);
            this.pnPages.Name = "pnPages";
            this.pnPages.Size = new System.Drawing.Size(240, 297);
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
            this.lbTitle.Text = "[2] Barkod Kontrol (SD)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm13_BarkodKontrolSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.pnPages);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm13_BarkodKontrolSD";
            this.Text = "Barkod Test (SD)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm13_BarkodKontrolSD_Load);
            this.pnPage01.ResumeLayout(false);
            this.pnPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGrid grdList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnPage01;
        private System.Windows.Forms.Panel pnPages;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnFisNo;
        private System.Windows.Forms.TextBox txtFisNo;
    }
}

