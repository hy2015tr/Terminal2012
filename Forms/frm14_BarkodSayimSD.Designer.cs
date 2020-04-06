namespace Terminal2012
{
    partial class frm14_BarkodSayimSD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm14_BarkodSayimSD));
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.pnPage01 = new System.Windows.Forms.Panel();
            this.lbSayimModu = new System.Windows.Forms.Label();
            this.txtSayimModu = new System.Windows.Forms.TextBox();
            this.txtAdresInput = new System.Windows.Forms.TextBox();
            this.lbAdresInput = new System.Windows.Forms.Label();
            this.pnSystem = new System.Windows.Forms.Panel();
            this.rbRadio04 = new System.Windows.Forms.RadioButton();
            this.rbRadio03 = new System.Windows.Forms.RadioButton();
            this.rbRadio02 = new System.Windows.Forms.RadioButton();
            this.rbRadio01 = new System.Windows.Forms.RadioButton();
            this.cbDepo = new System.Windows.Forms.ComboBox();
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
            this.lbMalzemeTxt = new System.Windows.Forms.Label();
            this.lbMalzemeNo = new System.Windows.Forms.Label();
            this.txtMalzemeTxt = new System.Windows.Forms.TextBox();
            this.txtCounter = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.pnPages = new System.Windows.Forms.Panel();
            this.pnPage03 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grdList = new System.Windows.Forms.DataGrid();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnNavigation.SuspendLayout();
            this.pnPage01.SuspendLayout();
            this.pnSystem.SuspendLayout();
            this.pnPage02.SuspendLayout();
            this.pnPages.SuspendLayout();
            this.pnPage03.SuspendLayout();
            this.SuspendLayout();
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
            this.pnPage01.Controls.Add(this.lbSayimModu);
            this.pnPage01.Controls.Add(this.txtSayimModu);
            this.pnPage01.Controls.Add(this.txtAdresInput);
            this.pnPage01.Controls.Add(this.lbAdresInput);
            this.pnPage01.Controls.Add(this.pnSystem);
            this.pnPage01.Controls.Add(this.cbDepo);
            this.pnPage01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage01.Location = new System.Drawing.Point(0, 0);
            this.pnPage01.Name = "pnPage01";
            this.pnPage01.Size = new System.Drawing.Size(240, 263);
            // 
            // lbSayimModu
            // 
            this.lbSayimModu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbSayimModu.Location = new System.Drawing.Point(13, 16);
            this.lbSayimModu.Name = "lbSayimModu";
            this.lbSayimModu.Size = new System.Drawing.Size(90, 20);
            this.lbSayimModu.Text = "Sayım Modu :";
            // 
            // txtSayimModu
            // 
            this.txtSayimModu.BackColor = System.Drawing.Color.Black;
            this.txtSayimModu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSayimModu.ForeColor = System.Drawing.Color.Yellow;
            this.txtSayimModu.Location = new System.Drawing.Point(106, 15);
            this.txtSayimModu.Name = "txtSayimModu";
            this.txtSayimModu.ReadOnly = true;
            this.txtSayimModu.Size = new System.Drawing.Size(124, 21);
            this.txtSayimModu.TabIndex = 34;
            // 
            // txtAdresInput
            // 
            this.txtAdresInput.BackColor = System.Drawing.Color.Black;
            this.txtAdresInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtAdresInput.ForeColor = System.Drawing.Color.Aqua;
            this.txtAdresInput.Location = new System.Drawing.Point(61, 226);
            this.txtAdresInput.Name = "txtAdresInput";
            this.txtAdresInput.Size = new System.Drawing.Size(169, 21);
            this.txtAdresInput.TabIndex = 15;
            this.txtAdresInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLokasyon_KeyUp);
            this.txtAdresInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLokasyon_KeyPress);
            // 
            // lbAdresInput
            // 
            this.lbAdresInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbAdresInput.Location = new System.Drawing.Point(13, 227);
            this.lbAdresInput.Name = "lbAdresInput";
            this.lbAdresInput.Size = new System.Drawing.Size(49, 20);
            this.lbAdresInput.Text = "Adres :";
            // 
            // pnSystem
            // 
            this.pnSystem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnSystem.Controls.Add(this.rbRadio04);
            this.pnSystem.Controls.Add(this.rbRadio03);
            this.pnSystem.Controls.Add(this.rbRadio02);
            this.pnSystem.Controls.Add(this.rbRadio01);
            this.pnSystem.Location = new System.Drawing.Point(8, 84);
            this.pnSystem.Name = "pnSystem";
            this.pnSystem.Size = new System.Drawing.Size(222, 130);
            // 
            // rbRadio04
            // 
            this.rbRadio04.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rbRadio04.Location = new System.Drawing.Point(13, 93);
            this.rbRadio04.Name = "rbRadio04";
            this.rbRadio04.Size = new System.Drawing.Size(195, 20);
            this.rbRadio04.TabIndex = 3;
            this.rbRadio04.TabStop = false;
            this.rbRadio04.Tag = "L";
            this.rbRadio04.Text = "4 - LEVHASAC";
            this.rbRadio04.Click += new System.EventHandler(this.rbALL_Click);
            // 
            // rbRadio03
            // 
            this.rbRadio03.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rbRadio03.Location = new System.Drawing.Point(13, 67);
            this.rbRadio03.Name = "rbRadio03";
            this.rbRadio03.Size = new System.Drawing.Size(195, 20);
            this.rbRadio03.TabIndex = 2;
            this.rbRadio03.TabStop = false;
            this.rbRadio03.Tag = "M";
            this.rbRadio03.Text = "3 - BORU / PROFİL";
            this.rbRadio03.Click += new System.EventHandler(this.rbALL_Click);
            // 
            // rbRadio02
            // 
            this.rbRadio02.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rbRadio02.Location = new System.Drawing.Point(13, 41);
            this.rbRadio02.Name = "rbRadio02";
            this.rbRadio02.Size = new System.Drawing.Size(195, 20);
            this.rbRadio02.TabIndex = 1;
            this.rbRadio02.TabStop = false;
            this.rbRadio02.Tag = "D";
            this.rbRadio02.Text = "2 - DİLİNMİŞ BANT";
            this.rbRadio02.Click += new System.EventHandler(this.rbALL_Click);
            // 
            // rbRadio01
            // 
            this.rbRadio01.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.rbRadio01.Location = new System.Drawing.Point(13, 15);
            this.rbRadio01.Name = "rbRadio01";
            this.rbRadio01.Size = new System.Drawing.Size(195, 20);
            this.rbRadio01.TabIndex = 0;
            this.rbRadio01.TabStop = false;
            this.rbRadio01.Tag = "R";
            this.rbRadio01.Text = "1 - RULO";
            this.rbRadio01.Click += new System.EventHandler(this.rbALL_Click);
            // 
            // cbDepo
            // 
            this.cbDepo.BackColor = System.Drawing.Color.Black;
            this.cbDepo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbDepo.ForeColor = System.Drawing.Color.Aqua;
            this.cbDepo.Items.Add("12000");
            this.cbDepo.Items.Add("20000");
            this.cbDepo.Location = new System.Drawing.Point(8, 49);
            this.cbDepo.Name = "cbDepo";
            this.cbDepo.Size = new System.Drawing.Size(222, 24);
            this.cbDepo.TabIndex = 10;
            this.cbDepo.SelectedIndexChanged += new System.EventHandler(this.cbDepo_SelectedIndexChanged);
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
            this.pnPage02.Controls.Add(this.lbMalzemeTxt);
            this.pnPage02.Controls.Add(this.lbMalzemeNo);
            this.pnPage02.Controls.Add(this.txtMalzemeTxt);
            this.pnPage02.Controls.Add(this.txtCounter);
            this.pnPage02.Controls.Add(this.btnAdd);
            this.pnPage02.Controls.Add(this.txtBarkod);
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
            this.txtSipKlm.Location = new System.Drawing.Point(166, 241);
            this.txtSipKlm.Name = "txtSipKlm";
            this.txtSipKlm.ReadOnly = true;
            this.txtSipKlm.Size = new System.Drawing.Size(66, 21);
            this.txtSipKlm.TabIndex = 66;
            this.txtSipKlm.Text = "0001";
            // 
            // txtSiparis
            // 
            this.txtSiparis.BackColor = System.Drawing.Color.Black;
            this.txtSiparis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSiparis.ForeColor = System.Drawing.Color.Yellow;
            this.txtSiparis.Location = new System.Drawing.Point(72, 241);
            this.txtSiparis.Name = "txtSiparis";
            this.txtSiparis.ReadOnly = true;
            this.txtSiparis.Size = new System.Drawing.Size(94, 21);
            this.txtSiparis.TabIndex = 65;
            // 
            // txtMalzemeParti
            // 
            this.txtMalzemeParti.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeParti.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeParti.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeParti.Location = new System.Drawing.Point(106, 136);
            this.txtMalzemeParti.Name = "txtMalzemeParti";
            this.txtMalzemeParti.ReadOnly = true;
            this.txtMalzemeParti.Size = new System.Drawing.Size(126, 21);
            this.txtMalzemeParti.TabIndex = 64;
            // 
            // txtPaketAgirlik
            // 
            this.txtPaketAgirlik.BackColor = System.Drawing.Color.Black;
            this.txtPaketAgirlik.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtPaketAgirlik.ForeColor = System.Drawing.Color.Yellow;
            this.txtPaketAgirlik.Location = new System.Drawing.Point(149, 157);
            this.txtPaketAgirlik.Name = "txtPaketAgirlik";
            this.txtPaketAgirlik.ReadOnly = true;
            this.txtPaketAgirlik.Size = new System.Drawing.Size(83, 21);
            this.txtPaketAgirlik.TabIndex = 63;
            // 
            // txtDepoYeri
            // 
            this.txtDepoYeri.BackColor = System.Drawing.Color.Black;
            this.txtDepoYeri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtDepoYeri.ForeColor = System.Drawing.Color.Yellow;
            this.txtDepoYeri.Location = new System.Drawing.Point(149, 199);
            this.txtDepoYeri.Name = "txtDepoYeri";
            this.txtDepoYeri.ReadOnly = true;
            this.txtDepoYeri.Size = new System.Drawing.Size(83, 21);
            this.txtDepoYeri.TabIndex = 53;
            // 
            // txtSatildi
            // 
            this.txtSatildi.BackColor = System.Drawing.Color.Black;
            this.txtSatildi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSatildi.ForeColor = System.Drawing.Color.Yellow;
            this.txtSatildi.Location = new System.Drawing.Point(149, 178);
            this.txtSatildi.Name = "txtSatildi";
            this.txtSatildi.ReadOnly = true;
            this.txtSatildi.Size = new System.Drawing.Size(83, 21);
            this.txtSatildi.TabIndex = 52;
            // 
            // txtSasNo
            // 
            this.txtSasNo.BackColor = System.Drawing.Color.Black;
            this.txtSasNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtSasNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtSasNo.Location = new System.Drawing.Point(149, 220);
            this.txtSasNo.Name = "txtSasNo";
            this.txtSasNo.ReadOnly = true;
            this.txtSasNo.Size = new System.Drawing.Size(83, 21);
            this.txtSasNo.TabIndex = 42;
            // 
            // lbSasNo
            // 
            this.lbSasNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbSasNo.Location = new System.Drawing.Point(5, 242);
            this.lbSasNo.Name = "lbSasNo";
            this.lbSasNo.Size = new System.Drawing.Size(61, 20);
            this.lbSasNo.Text = "Sip/Klm";
            // 
            // lbBarkod
            // 
            this.lbBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbBarkod.Location = new System.Drawing.Point(5, 95);
            this.lbBarkod.Name = "lbBarkod";
            this.lbBarkod.Size = new System.Drawing.Size(61, 20);
            this.lbBarkod.Text = "Barkod";
            // 
            // txtBrkdNo
            // 
            this.txtBrkdNo.BackColor = System.Drawing.Color.Black;
            this.txtBrkdNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtBrkdNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtBrkdNo.Location = new System.Drawing.Point(72, 94);
            this.txtBrkdNo.Name = "txtBrkdNo";
            this.txtBrkdNo.ReadOnly = true;
            this.txtBrkdNo.Size = new System.Drawing.Size(160, 21);
            this.txtBrkdNo.TabIndex = 32;
            // 
            // txtAdresExport
            // 
            this.txtAdresExport.BackColor = System.Drawing.Color.Black;
            this.txtAdresExport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtAdresExport.ForeColor = System.Drawing.Color.Yellow;
            this.txtAdresExport.Location = new System.Drawing.Point(72, 220);
            this.txtAdresExport.Name = "txtAdresExport";
            this.txtAdresExport.ReadOnly = true;
            this.txtAdresExport.Size = new System.Drawing.Size(77, 21);
            this.txtAdresExport.TabIndex = 27;
            // 
            // lbAdresExport
            // 
            this.lbAdresExport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbAdresExport.Location = new System.Drawing.Point(5, 221);
            this.lbAdresExport.Name = "lbAdresExport";
            this.lbAdresExport.Size = new System.Drawing.Size(61, 20);
            this.lbAdresExport.Text = "Adr/SAS";
            // 
            // txtUretimYeri
            // 
            this.txtUretimYeri.BackColor = System.Drawing.Color.Black;
            this.txtUretimYeri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtUretimYeri.ForeColor = System.Drawing.Color.Yellow;
            this.txtUretimYeri.Location = new System.Drawing.Point(72, 199);
            this.txtUretimYeri.Name = "txtUretimYeri";
            this.txtUretimYeri.ReadOnly = true;
            this.txtUretimYeri.Size = new System.Drawing.Size(77, 21);
            this.txtUretimYeri.TabIndex = 24;
            // 
            // lbUretimYeri
            // 
            this.lbUretimYeri.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbUretimYeri.Location = new System.Drawing.Point(5, 201);
            this.lbUretimYeri.Name = "lbUretimYeri";
            this.lbUretimYeri.Size = new System.Drawing.Size(61, 20);
            this.lbUretimYeri.Text = "ÜY/Depo";
            // 
            // txtTuketildi
            // 
            this.txtTuketildi.BackColor = System.Drawing.Color.Black;
            this.txtTuketildi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtTuketildi.ForeColor = System.Drawing.Color.Yellow;
            this.txtTuketildi.Location = new System.Drawing.Point(72, 178);
            this.txtTuketildi.Name = "txtTuketildi";
            this.txtTuketildi.ReadOnly = true;
            this.txtTuketildi.Size = new System.Drawing.Size(77, 21);
            this.txtTuketildi.TabIndex = 22;
            // 
            // txtPaketAdet
            // 
            this.txtPaketAdet.BackColor = System.Drawing.Color.Black;
            this.txtPaketAdet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtPaketAdet.ForeColor = System.Drawing.Color.Yellow;
            this.txtPaketAdet.Location = new System.Drawing.Point(72, 157);
            this.txtPaketAdet.Name = "txtPaketAdet";
            this.txtPaketAdet.ReadOnly = true;
            this.txtPaketAdet.Size = new System.Drawing.Size(77, 21);
            this.txtPaketAdet.TabIndex = 21;
            // 
            // lbTketildi
            // 
            this.lbTketildi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbTketildi.Location = new System.Drawing.Point(5, 181);
            this.lbTketildi.Name = "lbTketildi";
            this.lbTketildi.Size = new System.Drawing.Size(61, 20);
            this.lbTketildi.Text = "Tuk/Sat";
            // 
            // lbPaketAdet
            // 
            this.lbPaketAdet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbPaketAdet.Location = new System.Drawing.Point(5, 158);
            this.lbPaketAdet.Name = "lbPaketAdet";
            this.lbPaketAdet.Size = new System.Drawing.Size(61, 20);
            this.lbPaketAdet.Text = "Adet/Kg";
            // 
            // lbMalzemeTuru
            // 
            this.lbMalzemeTuru.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMalzemeTuru.Location = new System.Drawing.Point(5, 137);
            this.lbMalzemeTuru.Name = "lbMalzemeTuru";
            this.lbMalzemeTuru.Size = new System.Drawing.Size(63, 20);
            this.lbMalzemeTuru.Text = "Tür/Parti";
            // 
            // txtMalzemeTuru
            // 
            this.txtMalzemeTuru.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeTuru.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeTuru.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeTuru.Location = new System.Drawing.Point(72, 136);
            this.txtMalzemeTuru.Name = "txtMalzemeTuru";
            this.txtMalzemeTuru.ReadOnly = true;
            this.txtMalzemeTuru.Size = new System.Drawing.Size(34, 21);
            this.txtMalzemeTuru.TabIndex = 14;
            // 
            // txtMalzemeNo
            // 
            this.txtMalzemeNo.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeNo.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeNo.Location = new System.Drawing.Point(72, 115);
            this.txtMalzemeNo.Name = "txtMalzemeNo";
            this.txtMalzemeNo.ReadOnly = true;
            this.txtMalzemeNo.Size = new System.Drawing.Size(160, 21);
            this.txtMalzemeNo.TabIndex = 13;
            // 
            // lbMalzemeTxt
            // 
            this.lbMalzemeTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMalzemeTxt.Location = new System.Drawing.Point(5, 116);
            this.lbMalzemeTxt.Name = "lbMalzemeTxt";
            this.lbMalzemeTxt.Size = new System.Drawing.Size(61, 20);
            this.lbMalzemeTxt.Text = "Mlz.No";
            // 
            // lbMalzemeNo
            // 
            this.lbMalzemeNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbMalzemeNo.Location = new System.Drawing.Point(5, 62);
            this.lbMalzemeNo.Name = "lbMalzemeNo";
            this.lbMalzemeNo.Size = new System.Drawing.Size(61, 20);
            this.lbMalzemeNo.Text = "Malzeme";
            // 
            // txtMalzemeTxt
            // 
            this.txtMalzemeTxt.BackColor = System.Drawing.Color.Black;
            this.txtMalzemeTxt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtMalzemeTxt.ForeColor = System.Drawing.Color.Yellow;
            this.txtMalzemeTxt.Location = new System.Drawing.Point(72, 49);
            this.txtMalzemeTxt.Multiline = true;
            this.txtMalzemeTxt.Name = "txtMalzemeTxt";
            this.txtMalzemeTxt.ReadOnly = true;
            this.txtMalzemeTxt.Size = new System.Drawing.Size(160, 45);
            this.txtMalzemeTxt.TabIndex = 8;
            // 
            // txtCounter
            // 
            this.txtCounter.BackColor = System.Drawing.Color.Black;
            this.txtCounter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtCounter.ForeColor = System.Drawing.Color.Lime;
            this.txtCounter.Location = new System.Drawing.Point(194, 15);
            this.txtCounter.Name = "txtCounter";
            this.txtCounter.ReadOnly = true;
            this.txtCounter.Size = new System.Drawing.Size(38, 21);
            this.txtCounter.TabIndex = 7;
            this.txtCounter.Text = "001";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(121, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 22);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.BackColor = System.Drawing.Color.Black;
            this.txtBarkod.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtBarkod.ForeColor = System.Drawing.Color.Aqua;
            this.txtBarkod.Location = new System.Drawing.Point(8, 14);
            this.txtBarkod.MaxLength = 10;
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(108, 21);
            this.txtBarkod.TabIndex = 1;
            this.txtBarkod.Text = "1234567890";
            this.txtBarkod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyUp);
            // 
            // pnPages
            // 
            this.pnPages.Controls.Add(this.pnPage02);
            this.pnPages.Controls.Add(this.pnPage03);
            this.pnPages.Controls.Add(this.pnPage01);
            this.pnPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPages.Location = new System.Drawing.Point(0, 23);
            this.pnPages.Name = "pnPages";
            this.pnPages.Size = new System.Drawing.Size(240, 263);
            // 
            // pnPage03
            // 
            this.pnPage03.Controls.Add(this.btnCancel);
            this.pnPage03.Controls.Add(this.btnSave);
            this.pnPage03.Controls.Add(this.grdList);
            this.pnPage03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPage03.Location = new System.Drawing.Point(0, 0);
            this.pnPage03.Name = "pnPage03";
            this.pnPage03.Size = new System.Drawing.Size(240, 263);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Blue;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(122, 230);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 22);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(8, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 22);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdList
            // 
            this.grdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.grdList.Location = new System.Drawing.Point(8, 14);
            this.grdList.Name = "grdList";
            this.grdList.Size = new System.Drawing.Size(222, 204);
            this.grdList.TabIndex = 4;
            this.grdList.CurrentCellChanged += new System.EventHandler(this.grdList_CurrentCellChanged);
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
            this.lbTitle.Text = "[4] Barkod Sayım (SD)";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm14_BarkodSayimSD
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
            this.Name = "frm14_BarkodSayimSD";
            this.Text = "Barkod Yukleme (SD)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm14_BarkodSayimSD_Load);
            this.pnNavigation.ResumeLayout(false);
            this.pnPage01.ResumeLayout(false);
            this.pnSystem.ResumeLayout(false);
            this.pnPage02.ResumeLayout(false);
            this.pnPages.ResumeLayout(false);
            this.pnPage03.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Panel pnPage01;
        private System.Windows.Forms.Panel pnPage02;
        private System.Windows.Forms.Panel pnPages;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAdresInput;
        private System.Windows.Forms.Panel pnSystem;
        private System.Windows.Forms.RadioButton rbRadio03;
        private System.Windows.Forms.RadioButton rbRadio02;
        private System.Windows.Forms.RadioButton rbRadio01;
        private System.Windows.Forms.ComboBox cbDepo;
        private System.Windows.Forms.TextBox txtAdresInput;
        private System.Windows.Forms.RadioButton rbRadio04;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Panel pnPage03;
        private System.Windows.Forms.DataGrid grdList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCounter;
        private System.Windows.Forms.Label lbTketildi;
        private System.Windows.Forms.Label lbPaketAdet;
        private System.Windows.Forms.Label lbMalzemeTuru;
        private System.Windows.Forms.TextBox txtMalzemeTuru;
        private System.Windows.Forms.TextBox txtMalzemeNo;
        private System.Windows.Forms.Label lbMalzemeTxt;
        private System.Windows.Forms.Label lbMalzemeNo;
        private System.Windows.Forms.TextBox txtMalzemeTxt;
        private System.Windows.Forms.TextBox txtAdresExport;
        private System.Windows.Forms.Label lbAdresExport;
        private System.Windows.Forms.TextBox txtUretimYeri;
        private System.Windows.Forms.Label lbUretimYeri;
        private System.Windows.Forms.TextBox txtTuketildi;
        private System.Windows.Forms.TextBox txtPaketAdet;
        private System.Windows.Forms.Label lbBarkod;
        private System.Windows.Forms.TextBox txtBrkdNo;
        private System.Windows.Forms.TextBox txtSasNo;
        private System.Windows.Forms.Label lbSasNo;
        private System.Windows.Forms.TextBox txtDepoYeri;
        private System.Windows.Forms.TextBox txtSatildi;
        private System.Windows.Forms.Label lbSayimModu;
        private System.Windows.Forms.TextBox txtSayimModu;
        private System.Windows.Forms.TextBox txtPaketAgirlik;
        private System.Windows.Forms.TextBox txtMalzemeParti;
        private System.Windows.Forms.TextBox txtSipKlm;
        private System.Windows.Forms.TextBox txtSiparis;
    }
}

