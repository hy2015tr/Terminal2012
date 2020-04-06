namespace Terminal2012
{
    partial class frm06_EmirsizYuklemeMM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm06_EmirsizYuklemeMM));
            this.btnList = new System.Windows.Forms.Button();
            this.txtFisNo = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbGirilenKilo = new System.Windows.Forms.Label();
            this.txtGirilenKilo = new System.Windows.Forms.TextBox();
            this.lbRecordCount01 = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGrid();
            this.pnSelection = new System.Windows.Forms.Panel();
            this.pnPage02 = new System.Windows.Forms.Panel();
            this.txtSipKlm = new System.Windows.Forms.TextBox();
            this.txtSiparis = new System.Windows.Forms.TextBox();
            this.txtMalzemeParti = new System.Windows.Forms.TextBox();
            this.txtPaketAgirlik = new System.Windows.Forms.TextBox();
            this.txtDepoYeri = new System.Windows.Forms.TextBox();
            this.txtSatildi = new System.Windows.Forms.TextBox();
            this.txtSasNo = new System.Windows.Forms.TextBox();
            this.lbSasNo = new System.Windows.Forms.Label();
            this.lbBarkod = new System.Windows.Forms.Label();
            this.txtBrkdNo = new System.Windows.Forms.TextBox();
            this.txtAdresExport = new System.Windows.Forms.TextBox();
            this.lbAdresExport = new System.Windows.Forms.Label();
            this.txtUretimYeri = new System.Windows.Forms.TextBox();
            this.lbUretimYeri = new System.Windows.Forms.Label();
            this.txtTuketildi = new System.Windows.Forms.TextBox();
            this.txtPaketAdet = new System.Windows.Forms.TextBox();
            this.lbTketildi = new System.Windows.Forms.Label();
            this.lbPaketAdet = new System.Windows.Forms.Label();
            this.lbMalzemeTuru = new System.Windows.Forms.Label();
            this.txtMalzemeTuru = new System.Windows.Forms.TextBox();
            this.txtMalzemeNo = new System.Windows.Forms.TextBox();
            this.lbMalzemeNo = new System.Windows.Forms.Label();
            this.txtMalzemeTxt = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.btnList.Location = new System.Drawing.Point(117, 10);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(51, 22);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtFisNo
            // 
            this.txtFisNo.BackColor = System.Drawing.Color.Black;
            this.txtFisNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtFisNo.ForeColor = System.Drawing.Color.Aqua;
            this.txtFisNo.Location = new System.Drawing.Point(9, 10);
            this.txtFisNo.MaxLength = 11;
            this.txtFisNo.Name = "txtFisNo";
            this.txtFisNo.Size = new System.Drawing.Size(104, 21);
            this.txtFisNo.TabIndex = 0;
            this.txtFisNo.Text = "50000000004";
            this.txtFisNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFisNo_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(172, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 22);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Reset";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnNext.Location = new System.Drawing.Point(90, 6);
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
            this.btnClose.Location = new System.Drawing.Point(172, 6);
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
            this.pnPage01.Controls.Add(this.btnDel);
            this.pnPage01.Controls.Add(this.lbGirilenKilo);
            this.pnPage01.Controls.Add(this.txtGirilenKilo);
            this.pnPage01.Controls.Add(this.lbRecordCount01);
            this.pnPage01.Controls.Add(this.grdList);
            this.pnPage01.Controls.Add(this.pnSelection);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 263);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Blue;
            this.btnDel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(10, 238);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(122, 22);
            this.btnDel.TabIndex = 104;
            this.btnDel.Text = "Sil";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbGirilenKilo
            // 
            this.lbGirilenKilo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbGirilenKilo.Location = new System.Drawing.Point(37, 45);
            this.lbGirilenKilo.Name = "lbGirilenKilo";
            this.lbGirilenKilo.Size = new System.Drawing.Size(74, 14);
            this.lbGirilenKilo.Text = "Girilen Kilo";
            this.lbGirilenKilo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtGirilenKilo
            // 
            this.txtGirilenKilo.BackColor = System.Drawing.Color.Black;
            this.txtGirilenKilo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtGirilenKilo.ForeColor = System.Drawing.Color.Yellow;
            this.txtGirilenKilo.Location = new System.Drawing.Point(117, 40);
            this.txtGirilenKilo.Name = "txtGirilenKilo";
            this.txtGirilenKilo.ReadOnly = true;
            this.txtGirilenKilo.Size = new System.Drawing.Size(115, 21);
            this.txtGirilenKilo.TabIndex = 103;
            // 
            // lbRecordCount01
            // 
            this.lbRecordCount01.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRecordCount01.Location = new System.Drawing.Point(138, 243);
            this.lbRecordCount01.Name = "lbRecordCount01";
            this.lbRecordCount01.Size = new System.Drawing.Size(95, 14);
            this.lbRecordCount01.Text = "Adet = 5";
            this.lbRecordCount01.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grdList
            // 
            this.grdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdList.Location = new System.Drawing.Point(10, 69);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(222, 165);
            this.grdList.TabIndex = 102;
            this.grdList.CurrentCellChanged += new System.EventHandler(this.grdList_CurrentCellChanged);
            // 
            // pnSelection
            // 
            this.pnSelection.Controls.Add(this.btnClear);
            this.pnSelection.Controls.Add(this.btnList);
            this.pnSelection.Controls.Add(this.txtFisNo);
            this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelection.Location = new System.Drawing.Point(0, 0);
            this.pnSelection.Name = "pnSelection";
            this.pnSelection.Size = new System.Drawing.Size(240, 42);
            // 
            // pnPage02
            // 
            this.pnPage02.Controls.Add(this.txtSipKlm);
            this.pnPage02.Controls.Add(this.txtSiparis);
            this.pnPage02.Controls.Add(this.txtMalzemeParti);
            this.pnPage02.Controls.Add(this.txtPaketAgirlik);
            this.pnPage02.Controls.Add(this.txtDepoYeri);
            this.pnPage02.Controls.Add(this.txtSatildi);
            this.pnPage02.Controls.Add(this.txtSasNo);
            this.pnPage02.Controls.Add(this.lbSasNo);
            this.pnPage02.Controls.Add(this.lbBarkod);
            this.pnPage02.Controls.Add(this.txtBrkdNo);
            this.pnPage02.Controls.Add(this.txtAdresExport);
            this.pnPage02.Controls.Add(this.lbAdresExport);
            this.pnPage02.Controls.Add(this.txtUretimYeri);
            this.pnPage02.Controls.Add(this.lbUretimYeri);
            this.pnPage02.Controls.Add(this.txtTuketildi);
            this.pnPage02.Controls.Add(this.txtPaketAdet);
            this.pnPage02.Controls.Add(this.lbTketildi);
            this.pnPage02.Controls.Add(this.lbPaketAdet);
            this.pnPage02.Controls.Add(this.lbMalzemeTuru);
            this.pnPage02.Controls.Add(this.txtMalzemeTuru);
            this.pnPage02.Controls.Add(this.txtMalzemeNo);
            this.pnPage02.Controls.Add(this.lbMalzemeNo);
            this.pnPage02.Controls.Add(this.txtMalzemeTxt);
            this.pnPage02.Controls.Add(this.txtBarkod);
            this.pnPage02.Controls.Add(this.btnAdd);
            this.pnPage02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage02.Location = new System.Drawing.Point(0, 0);
            this.pnPage02.Name = "pnPage02";
            this.pnPage02.Size = new System.Drawing.Size(240, 263);
            // 
            // txtSipKlm
            // 
            this.txtSipKlm.BackColor = System.Drawing.Color.Black;
            this.txtSipKlm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSipKlm.ForeColor = System.Drawing.Color.Yellow;
            this.txtSipKlm.Location = new System.Drawing.Point(166, 233);
            this.txtSipKlm.Name = "txtSipKlm";
            this.txtSipKlm.ReadOnly = true;
            this.txtSipKlm.Size = new System.Drawing.Size(66, 21);
            this.txtSipKlm.TabIndex = 136;
            // 
            // txtSiparis
            // 
            this.txtSiparis.BackColor = System.Drawing.Color.Black;
            this.txtSiparis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSiparis.ForeColor = System.Drawing.Color.Yellow;
            this.txtSiparis.Location = new System.Drawing.Point(72, 233);
            this.txtSiparis.Name = "txtSiparis";
            this.txtSiparis.ReadOnly = true;
            this.txtSiparis.Size = new System.Drawing.Size(94, 21);
            this.txtSiparis.TabIndex = 135;
            // 
            // txtMalzemeParti
            // 
            this.txtMalzemeParti.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeParti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeParti.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeParti.Location = new System.Drawing.Point(106, 128);
            this.txtMalzemeParti.Name = "txtMalzemeParti";
            this.txtMalzemeParti.ReadOnly = true;
            this.txtMalzemeParti.Size = new System.Drawing.Size(126, 21);
            this.txtMalzemeParti.TabIndex = 134;
            // 
            // txtPaketAgirlik
            // 
            this.txtPaketAgirlik.BackColor = System.Drawing.Color.Black;
            this.txtPaketAgirlik.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtPaketAgirlik.ForeColor = System.Drawing.Color.Yellow;
            this.txtPaketAgirlik.Location = new System.Drawing.Point(149, 149);
            this.txtPaketAgirlik.Name = "txtPaketAgirlik";
            this.txtPaketAgirlik.ReadOnly = true;
            this.txtPaketAgirlik.Size = new System.Drawing.Size(83, 21);
            this.txtPaketAgirlik.TabIndex = 133;
            // 
            // txtDepoYeri
            // 
            this.txtDepoYeri.BackColor = System.Drawing.Color.Black;
            this.txtDepoYeri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtDepoYeri.ForeColor = System.Drawing.Color.Yellow;
            this.txtDepoYeri.Location = new System.Drawing.Point(149, 191);
            this.txtDepoYeri.Name = "txtDepoYeri";
            this.txtDepoYeri.ReadOnly = true;
            this.txtDepoYeri.Size = new System.Drawing.Size(83, 21);
            this.txtDepoYeri.TabIndex = 132;
            // 
            // txtSatildi
            // 
            this.txtSatildi.BackColor = System.Drawing.Color.Black;
            this.txtSatildi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSatildi.ForeColor = System.Drawing.Color.Yellow;
            this.txtSatildi.Location = new System.Drawing.Point(92, 170);
            this.txtSatildi.Name = "txtSatildi";
            this.txtSatildi.ReadOnly = true;
            this.txtSatildi.Size = new System.Drawing.Size(20, 21);
            this.txtSatildi.TabIndex = 131;
            // 
            // txtSasNo
            // 
            this.txtSasNo.BackColor = System.Drawing.Color.Black;
            this.txtSasNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSasNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSasNo.Location = new System.Drawing.Point(149, 212);
            this.txtSasNo.Name = "txtSasNo";
            this.txtSasNo.ReadOnly = true;
            this.txtSasNo.Size = new System.Drawing.Size(83, 21);
            this.txtSasNo.TabIndex = 130;
            // 
            // lbSasNo
            // 
            this.lbSasNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbSasNo.Location = new System.Drawing.Point(8, 235);
            this.lbSasNo.Name = "lbSasNo";
            this.lbSasNo.Size = new System.Drawing.Size(61, 20);
            this.lbSasNo.Text = "Sip/Klm";
            // 
            // lbBarkod
            // 
            this.lbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbBarkod.Location = new System.Drawing.Point(12, 108);
            this.lbBarkod.Name = "lbBarkod";
            this.lbBarkod.Size = new System.Drawing.Size(61, 20);
            this.lbBarkod.Text = "Mlz.No";
            // 
            // txtBrkdNo
            // 
            this.txtBrkdNo.BackColor = System.Drawing.Color.Black;
            this.txtBrkdNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtBrkdNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtBrkdNo.Location = new System.Drawing.Point(112, 170);
            this.txtBrkdNo.Name = "txtBrkdNo";
            this.txtBrkdNo.ReadOnly = true;
            this.txtBrkdNo.Size = new System.Drawing.Size(120, 21);
            this.txtBrkdNo.TabIndex = 129;
            // 
            // txtAdresExport
            // 
            this.txtAdresExport.BackColor = System.Drawing.Color.Black;
            this.txtAdresExport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtAdresExport.ForeColor = System.Drawing.Color.Yellow;
            this.txtAdresExport.Location = new System.Drawing.Point(72, 212);
            this.txtAdresExport.Name = "txtAdresExport";
            this.txtAdresExport.ReadOnly = true;
            this.txtAdresExport.Size = new System.Drawing.Size(77, 21);
            this.txtAdresExport.TabIndex = 128;
            // 
            // lbAdresExport
            // 
            this.lbAdresExport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbAdresExport.Location = new System.Drawing.Point(8, 214);
            this.lbAdresExport.Name = "lbAdresExport";
            this.lbAdresExport.Size = new System.Drawing.Size(61, 20);
            this.lbAdresExport.Text = "Adr/SAS";
            // 
            // txtUretimYeri
            // 
            this.txtUretimYeri.BackColor = System.Drawing.Color.Black;
            this.txtUretimYeri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtUretimYeri.ForeColor = System.Drawing.Color.Yellow;
            this.txtUretimYeri.Location = new System.Drawing.Point(72, 191);
            this.txtUretimYeri.Name = "txtUretimYeri";
            this.txtUretimYeri.ReadOnly = true;
            this.txtUretimYeri.Size = new System.Drawing.Size(77, 21);
            this.txtUretimYeri.TabIndex = 127;
            // 
            // lbUretimYeri
            // 
            this.lbUretimYeri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbUretimYeri.Location = new System.Drawing.Point(8, 194);
            this.lbUretimYeri.Name = "lbUretimYeri";
            this.lbUretimYeri.Size = new System.Drawing.Size(61, 20);
            this.lbUretimYeri.Text = "ÜY/Depo";
            // 
            // txtTuketildi
            // 
            this.txtTuketildi.BackColor = System.Drawing.Color.Black;
            this.txtTuketildi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtTuketildi.ForeColor = System.Drawing.Color.Yellow;
            this.txtTuketildi.Location = new System.Drawing.Point(72, 170);
            this.txtTuketildi.Name = "txtTuketildi";
            this.txtTuketildi.ReadOnly = true;
            this.txtTuketildi.Size = new System.Drawing.Size(20, 21);
            this.txtTuketildi.TabIndex = 126;
            // 
            // txtPaketAdet
            // 
            this.txtPaketAdet.BackColor = System.Drawing.Color.Black;
            this.txtPaketAdet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtPaketAdet.ForeColor = System.Drawing.Color.Yellow;
            this.txtPaketAdet.Location = new System.Drawing.Point(72, 149);
            this.txtPaketAdet.Name = "txtPaketAdet";
            this.txtPaketAdet.ReadOnly = true;
            this.txtPaketAdet.Size = new System.Drawing.Size(77, 21);
            this.txtPaketAdet.TabIndex = 125;
            // 
            // lbTketildi
            // 
            this.lbTketildi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbTketildi.Location = new System.Drawing.Point(8, 174);
            this.lbTketildi.Name = "lbTketildi";
            this.lbTketildi.Size = new System.Drawing.Size(61, 20);
            this.lbTketildi.Text = "Tuk/Sat";
            // 
            // lbPaketAdet
            // 
            this.lbPaketAdet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbPaketAdet.Location = new System.Drawing.Point(8, 151);
            this.lbPaketAdet.Name = "lbPaketAdet";
            this.lbPaketAdet.Size = new System.Drawing.Size(61, 20);
            this.lbPaketAdet.Text = "Adet/Kg";
            // 
            // lbMalzemeTuru
            // 
            this.lbMalzemeTuru.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMalzemeTuru.Location = new System.Drawing.Point(8, 130);
            this.lbMalzemeTuru.Name = "lbMalzemeTuru";
            this.lbMalzemeTuru.Size = new System.Drawing.Size(63, 20);
            this.lbMalzemeTuru.Text = "Tür/Parti";
            // 
            // txtMalzemeTuru
            // 
            this.txtMalzemeTuru.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeTuru.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeTuru.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeTuru.Location = new System.Drawing.Point(72, 128);
            this.txtMalzemeTuru.Name = "txtMalzemeTuru";
            this.txtMalzemeTuru.ReadOnly = true;
            this.txtMalzemeTuru.Size = new System.Drawing.Size(34, 21);
            this.txtMalzemeTuru.TabIndex = 124;
            // 
            // txtMalzemeNo
            // 
            this.txtMalzemeNo.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeNo.Location = new System.Drawing.Point(72, 107);
            this.txtMalzemeNo.Name = "txtMalzemeNo";
            this.txtMalzemeNo.ReadOnly = true;
            this.txtMalzemeNo.Size = new System.Drawing.Size(160, 21);
            this.txtMalzemeNo.TabIndex = 123;
            // 
            // lbMalzemeNo
            // 
            this.lbMalzemeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMalzemeNo.Location = new System.Drawing.Point(10, 59);
            this.lbMalzemeNo.Name = "lbMalzemeNo";
            this.lbMalzemeNo.Size = new System.Drawing.Size(61, 20);
            this.lbMalzemeNo.Text = "Mlz Adi";
            // 
            // txtMalzemeTxt
            // 
            this.txtMalzemeTxt.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeTxt.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeTxt.Location = new System.Drawing.Point(72, 51);
            this.txtMalzemeTxt.Multiline = true;
            this.txtMalzemeTxt.Name = "txtMalzemeTxt";
            this.txtMalzemeTxt.ReadOnly = true;
            this.txtMalzemeTxt.Size = new System.Drawing.Size(160, 56);
            this.txtMalzemeTxt.TabIndex = 122;
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.Black;
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.txtBarkod.Location = new System.Drawing.Point(8, 13);
            this.txtBarkod.MaxLength = 10;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(135, 21);
            this.txtBarkod.TabIndex = 10;
            this.txtBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyUp);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(149, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 22);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.lbTitle.Text = "[6] Emirsiz Yukleme (MM)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm06_EmirsizYuklemeMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.pnPages);
            this.Controls.Add(this.pnNavigation);
            this.Controls.Add(this.lbTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm06_EmirsizYuklemeMM";
            this.Text = "Emirsiz Yukleme (MM)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm06_EmirsizYuklemeMM_Load);
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Panel pnPage01;
        private System.Windows.Forms.Panel pnPage02;
        private System.Windows.Forms.Panel pnSelection;
        private System.Windows.Forms.Panel pnPages;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lbGirilenKilo;
        private System.Windows.Forms.TextBox txtGirilenKilo;
        private System.Windows.Forms.Label lbRecordCount01;
        private System.Windows.Forms.DataGrid grdList;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSipKlm;
        private System.Windows.Forms.TextBox txtSiparis;
        private System.Windows.Forms.TextBox txtMalzemeParti;
        private System.Windows.Forms.TextBox txtPaketAgirlik;
        private System.Windows.Forms.TextBox txtDepoYeri;
        private System.Windows.Forms.TextBox txtSatildi;
        private System.Windows.Forms.TextBox txtSasNo;
        private System.Windows.Forms.Label lbSasNo;
        private System.Windows.Forms.Label lbBarkod;
        private System.Windows.Forms.TextBox txtBrkdNo;
        private System.Windows.Forms.TextBox txtAdresExport;
        private System.Windows.Forms.Label lbAdresExport;
        private System.Windows.Forms.TextBox txtUretimYeri;
        private System.Windows.Forms.Label lbUretimYeri;
        private System.Windows.Forms.TextBox txtTuketildi;
        private System.Windows.Forms.TextBox txtPaketAdet;
        private System.Windows.Forms.Label lbTketildi;
        private System.Windows.Forms.Label lbPaketAdet;
        private System.Windows.Forms.Label lbMalzemeTuru;
        private System.Windows.Forms.TextBox txtMalzemeTuru;
        private System.Windows.Forms.TextBox txtMalzemeNo;
        private System.Windows.Forms.Label lbMalzemeNo;
        private System.Windows.Forms.TextBox txtMalzemeTxt;
    }
}

