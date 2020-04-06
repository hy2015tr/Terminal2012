namespace Terminal2012
{
    partial class frm12_BarkodTestSD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm12_BarkodTestSD));
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.pnPages = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnPage01.SuspendLayout();
            this.pnSelection.SuspendLayout();
            this.pnPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(160, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.Black;
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.txtBarkod.Location = new System.Drawing.Point(13, 14);
            this.txtBarkod.MaxLength = 10;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(141, 21);
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
            this.grdList.Location = new System.Drawing.Point(8, 52);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(222, 204);
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
            this.pnPage01.Controls.Add(this.btnClose);
            this.pnPage01.Controls.Add(this.btnClear);
            this.pnPage01.Controls.Add(this.pnSelection);
            this.pnPage01.Controls.Add(this.grdList);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 297);
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.btnAdd);
            this.pnSelection.Controls.Add(this.txtBarkod);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelection.Location = new System.Drawing.Point(0, 0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(240, 46);
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
            this.lbTitle.Text = "[3] Barkod Test (SD)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm12_BarkodTestSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.pnPages);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm12_BarkodTestSD";
            this.Text = "Barkod Test (SD)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm12_BarkodTestSD_Load);
            this.pnPage01.ResumeLayout(false);
            this.pnSelection.ResumeLayout(false);
            this.pnPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGrid grdList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnPage01;
        private System.Windows.Forms.Panel pnSelection;
        private System.Windows.Forms.Panel pnPages;
        private System.Windows.Forms.Label lbTitle;
    }
}

