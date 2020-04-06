using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Terminal2012
{

    public partial class frm14_BarkodSayimSD : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        #region [---- Member Fields ----]

        // Counter
        int m_Counter = 0;

        // System 
        AlfaSys m_System = null;

        // Sayim Mode
        string m_SayimMode = null;

        // Lokasyon
        string m_MalzemeTuru = null;

        // Table List
        DataTable m_TableList = new DataTable("LIST");

        #endregion

        //-----------------------------------------------------------------------------------------------------------//

        public frm14_BarkodSayimSD(AlfaSys p_System)
        {
            // Initialize
            InitializeComponent();

            // Set System
            this.m_System = p_System;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm14_BarkodSayimSD_Load(object sender, EventArgs e)
        {
            // Create Tables
            this.Create_Table_List();

            // Depo List
            this.Get_Depo_List();

            // Sayim Mode
            this.Get_Sayim_Mode();

            // Reset DepoList
            cbDepo.SelectedIndex = -1;

            // Reset
            this.btnCancel_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Get_Sayim_Mode()
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Functions
                alfaSAP p_SAP = new alfaSAP();

                // Create Parms
                WR.ZMM005_MODE prms = new WR.ZMM005_MODE();

                // Call Function
                WR.ZMM005_MODEResponse resp = p_SAP.ZMM005_MODE(prms);

                // Error Message
                if (resp.E_SUBRC != "0") alfaMsg.Error(resp.E_MESSAGE);
                
                // Sayim Mode
                this.m_SayimMode = resp.E_MOD;

                // Check Empty
                if (this.m_SayimMode == string.Empty) this.m_SayimMode = "X";

                // Display Mode
                txtSayimModu.Text = string.Format("MODE - {0}", this.m_SayimMode);

            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Create_Table_List()
        {
            // Create Columnbs
            DataColumn col00 = new DataColumn("NO");
            DataColumn col01 = new DataColumn("BARKOD");
            DataColumn col02 = new DataColumn("DURUM");
            DataColumn col03 = new DataColumn("MESAJ"); 
            DataColumn col04 = new DataColumn("DEPO");
            DataColumn col05 = new DataColumn("DEPO_USER");
            DataColumn col06 = new DataColumn("ADRES");
            DataColumn col07 = new DataColumn("ADRES_USER");
            DataColumn col08 = new DataColumn("MLZ_ADI");
            DataColumn col09 = new DataColumn("MLZ_KODU");
            DataColumn col10 = new DataColumn("URETIMYERI");
            DataColumn col11 = new DataColumn("MLZ_TIP");
            DataColumn col12 = new DataColumn("PKTICIADT");
            DataColumn col13 = new DataColumn("TUKETILDI");
            DataColumn col14 = new DataColumn("SATILDI");
            DataColumn col15 = new DataColumn("SASNO");
            DataColumn col16 = new DataColumn("SIPNO");
            DataColumn col17 = new DataColumn("KLM");
            DataColumn col18 = new DataColumn("PARTI");
            DataColumn col19 = new DataColumn("KILO");
            DataColumn col20 = new DataColumn("DOSYA");
            DataColumn col21 = new DataColumn("OKUTMASAAT");
            DataColumn col22 = new DataColumn("OKUTMATRH");
            DataColumn col23 = new DataColumn("OKUTAN");
            
            // Add Columns
            this.m_TableList.Columns.AddRange(new DataColumn[] { col00, col01, col02, col03, col04, col05, col06, col07, col08, col09, col10, col11, col12, col13, col14, col15, col16, col17, col18, col19, col20, col21, col22, col23 });

            // Create Style
            grdList.TableStyles.Clear();
            alfaGrid.CreateTableStyle(grdList, m_TableList, "DURUM");

            // Assign Grid
            grdList.DataSource = m_TableList;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                // CursorWait
                alfaMsg.WaitCursor();

                if (pnPage03.Visible)
                {
                    // Page02
                    PageActivate(pnPage02);
                }
                else if (pnPage02.Visible)
                {
                    // Page01
                    PageActivate(pnPage01);
                }

                // Enable btnPrev
                alfaCtrl.EnableControl(btnNext, Color.Green);

                // Disable btnNext
                if (pnPage01.Visible) alfaCtrl.DisableControl(btnPrev, Color.Silver);

                // CursorDefault
                alfaMsg.DefaultCursor();

            }
            catch (Exception ex)
            {
                // Error Message
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // CursorWait
                alfaMsg.WaitCursor();

                if (pnPage01.Visible)
                {
                    // Page02
                    this.PageActivate(pnPage02);

                    // Focus
                    txtBarkod.Focus();
                }
                else if (pnPage02.Visible)
                {
                    // Page03
                    this.PageActivate(pnPage03);
                }

                // Enable btnPrev
                alfaCtrl.EnableControl(btnPrev, Color.Green);

                // Status BtnNext
                if (pnPage02.Visible && this.m_SayimMode == "1")
                {
                    alfaCtrl.DisableControl(btnNext, Color.Silver);
                }
                else if (pnPage03.Visible) alfaCtrl.DisableControl(btnNext, Color.Silver);

                // CursorDefault
                alfaMsg.DefaultCursor();

            }
            catch (Exception ex)
            {
                // Error Message
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void PageActivate( System.Windows.Forms.Panel p_Panel )
        {
            // Visible
            pnPage01.Visible = false;
            pnPage02.Visible = false;
            pnPage03.Visible = false;
            p_Panel.Visible = true;
            
            // Panel Focus
            p_Panel.Focus();

            // Text Focus
                 if (p_Panel == pnPage01) txtAdresInput.Focus();
            else if (p_Panel == pnPage02) txtBarkod.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClose_Click(object sender, EventArgs e)
        {
            if ( m_TableList.Rows.Count > 0 ) 
            {
                // Confirmation
                if ( alfaMsg.Quest("Sayım listeniz doludur. Çıkmak için emin misiniz ?") == DialogResult.No ) return;
            }

            // Close
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Get_Depo_List()
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Functions
                alfaSAP p_SAP = new alfaSAP();

                // Parameters
                WR.ZMM007_DEPO_YERI prms = new WR.ZMM007_DEPO_YERI();
                prms.I_WERKS = m_System.Werks;

                // Call Function
                WR.ZMM007_DEPO_YERIResponse resp = p_SAP.ZMM007_DEPO_YERI(prms);

                // Clear Items
                cbDepo.Items.Clear();

                // Add Items
                foreach (WR.ZMM_S_LGORT row in resp.TB_DEPO)
                {
                    cbDepo.Items.Add(new alfaDepo(row.LGORT, row.LGOBE));
                }

                // Set Lgort
                if (cbDepo.Items.Count > 0) cbDepo.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void cbDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set Depo
            if (cbDepo.SelectedIndex > -1)
            {
                this.m_System.Lgort = (cbDepo.SelectedItem as alfaDepo).DepoNo;
            }

            // BtnNext Status
            if (this.m_MalzemeTuru != null && txtAdresInput.Text.Trim().Length > 0)
                 alfaCtrl.EnableControl(btnNext, Color.Green);
            else alfaCtrl.DisableControl(btnNext, Color.Silver);

            // Focus
            this.pnPage01.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZMM005_SAYIM prms = new Terminal2012.WR.ZMM005_SAYIM();

                // Assign Params
                prms.I_DEPO = m_System.Lgort;
                prms.I_BARKOD = txtBarkod.Text;
                prms.I_ADRES = txtAdresInput.Text;
                prms.I_MOD = this.m_SayimMode;
                prms.I_MLZ_TIP = this.m_MalzemeTuru;
                prms.I_IPNBR = this.m_System.LocIP;

                // Call Service
                WR.ZMM005_SAYIMResponse resp = p_SAP.ZMM005_SAYIM(prms);

                // Assign Text Fields
                txtBrkdNo.Text = txtBarkod.Text;
                txtAdresExport.Text = resp.E_EXPORT.ADRES;
                txtMalzemeTxt.Text = resp.E_EXPORT.MLZ_ADI;
                txtMalzemeNo.Text = resp.E_EXPORT.MLZ_KODU;
                txtMalzemeTuru.Text = resp.E_EXPORT.MLZ_TIP;
                txtPaketAdet.Text = resp.E_EXPORT.PKTICIADT;
                txtTuketildi.Text = resp.E_EXPORT.TUKETILDI;
                txtSatildi.Text = resp.E_EXPORT.SATILDI;
                txtUretimYeri.Text = resp.E_EXPORT.URETIMYERI;
                txtDepoYeri.Text = resp.E_EXPORT.DEPO;
                txtSasNo.Text = resp.E_EXPORT.SASNO;
                txtMalzemeParti.Text = resp.E_EXPORT.PARTI;
                txtPaketAgirlik.Text = resp.E_EXPORT.KILO.ToString();
                txtSiparis.Text = resp.E_EXPORT.SIPNO;
                txtSipKlm.Text = resp.E_EXPORT.KALEM;

                if (this.m_SayimMode == "2") //===================================================== MODE II ==================================//
                {
                    // Create Row
                    DataRow rowNew = m_TableList.NewRow();

                    // Assign Table Fields
                    rowNew["NO"] = string.Format("{0:000}", m_TableList.Rows.Count + 1);
                    rowNew["DEPO"] = resp.E_EXPORT.DEPO;
                    rowNew["DEPO_USER"] = resp.E_EXPORT.DEPO_USER;
                    rowNew["BARKOD"] = resp.E_EXPORT.BARKOD;
                    rowNew["ADRES"] = resp.E_EXPORT.ADRES;
                    rowNew["ADRES_USER"] = resp.E_EXPORT.ADRES_USER;
                    rowNew["MLZ_ADI"] = resp.E_EXPORT.MLZ_ADI;
                    rowNew["MLZ_KODU"] = resp.E_EXPORT.MLZ_KODU;
                    rowNew["URETIMYERI"] = resp.E_EXPORT.URETIMYERI;
                    rowNew["MLZ_TIP"] = resp.E_EXPORT.MLZ_TIP;
                    rowNew["PKTICIADT"] = resp.E_EXPORT.PKTICIADT;
                    rowNew["TUKETILDI"] = resp.E_EXPORT.TUKETILDI;
                    rowNew["SATILDI"] = resp.E_EXPORT.SATILDI;
                    rowNew["SASNO"] = resp.E_EXPORT.SASNO;
                    rowNew["DOSYA"] = resp.E_EXPORT.DOSYA;
                    rowNew["OKUTMASAAT"] = resp.E_EXPORT.OKUTMASAAT;
                    rowNew["OKUTMATRH"] = resp.E_EXPORT.OKUTMATRH;
                    rowNew["OKUTAN"] = resp.E_EXPORT.OKUTAN;
                    rowNew["MESAJ"] = resp.E_MESSAGE;
                    rowNew["PARTI"] = resp.E_EXPORT.PARTI;
                    rowNew["KILO"] = resp.E_EXPORT.KILO;
                    rowNew["SIPNO"] = resp.E_EXPORT.SIPNO;
                    rowNew["KLM"] = resp.E_EXPORT.KALEM;

                    // Set Result
                    if (resp.E_SUBRC == "0") rowNew["DURUM"] = "TAMAM"; else rowNew["DURUM"] = "HATA";

                    // Hata Mesaji
                    // string StrHataMukerrer = "MÜKERRER BARKOD ...!";
                    //if (resp.E_SUBRC == "0")
                    //{
                    //    // Check Double Records
                    //    foreach (DataRow row in m_TableList.Rows)
                    //    {
                    //        if (row["BARKOD"].ToString() == txtBarkod.Text)
                    //        {
                    //            // Hata
                    //            resp.E_SUBRC = "4";

                    //            rowNew["DURUM"] = "HATA";
                    //            rowNew["MESAJ"] = StrHataMukerrer;

                    //            row["DURUM"] = "HATA";
                    //            row["MESAJ"] = StrHataMukerrer;
                    //        }
                    //    }
                    //}

                    // Add Row
                    m_TableList.Rows.Add(rowNew);

                    // Create Style
                    grdList.TableStyles.Clear();
                    alfaGrid.CreateTableStyle(grdList, m_TableList, "DURUM");

                    // Assign Grid
                    grdList.DataSource = m_TableList;

                    // BtnSave Enable
                    alfaCtrl.EnableControl(btnSave, Color.Blue);

                    // Mukerrer Kayit
                    if (resp.E_SUBRC != "0")
                    {
                        // Show Error
                        alfaMsg.Error(rowNew["MESAJ"].ToString());
                    }

                }  //=============================================================================== MODE II ==================================//

                if (resp.E_SUBRC == "0")
                {
                    // Increase Counter
                    this.m_Counter = this.m_Counter + 1;

                    // Counter
                    txtCounter.Text = string.Format("{0:000}", this.m_Counter);
                }

                // Clear Barkod
                txtBarkod.Text = string.Empty;

                // Focus
                txtBarkod.Focus();

                // Cursor
                alfaMsg.DefaultCursor();

            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }
        
        //-----------------------------------------------------------------------------------------------------------//

        private void rbALL_Click(object sender, EventArgs e)
        {
            // Lokasyon
            this.m_MalzemeTuru = (sender as RadioButton).Tag.ToString();

            // BtnNext Status
            if (this.m_MalzemeTuru != null && txtAdresInput.Text.Trim().Length > 0)
                 alfaCtrl.EnableControl(btnNext, Color.Green);
            else alfaCtrl.DisableControl(btnNext, Color.Silver);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Confirmation
            if ( sender!=null && alfaMsg.Quest("İptal etmek için emin misiniz ?") == DialogResult.No ) return;

            // Clear Texts
            txtAdresExport.Text = string.Empty;
            txtBarkod.Text = string.Empty;
            txtBrkdNo.Text = string.Empty;
            txtCounter.Text = string.Empty;
            txtAdresInput.Text = string.Empty;
            txtMalzemeTxt.Text = string.Empty;
            txtMalzemeTuru.Text = string.Empty;
            txtMalzemeNo.Text = string.Empty;
            txtPaketAdet.Text = string.Empty;
            txtTuketildi.Text = string.Empty;
            txtSatildi.Text = string.Empty;
            txtUretimYeri.Text = string.Empty;
            txtDepoYeri.Text = string.Empty;
            txtMalzemeParti.Text = string.Empty;
            txtPaketAgirlik.Text = string.Empty;
            txtSiparis.Text = string.Empty;
            txtSipKlm.Text = string.Empty;

            // Disable Buttons
            alfaCtrl.DisableControl(btnSave, Color.Silver);
            alfaCtrl.DisableControl(btnSave, Color.Silver);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);
            alfaCtrl.DisableControl(btnAdd, Color.Silver);

            // Reset Counter
            this.m_Counter = 0;

            // Table Reset
            m_TableList.Rows.Clear();

            // Page01
            this.PageActivate(pnPage01);

            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZMM005_SAYIM_RESET prms = new Terminal2012.WR.ZMM005_SAYIM_RESET();

                // Set Params
                prms.I_IPNBR = this.m_System.LocIP;

                // Call Service
                WR.ZMM005_SAYIM_RESETResponse resp = p_SAP.ZMM005_SAYIM_RESET(prms);

                // Show Error
                if (resp.E_SUBRC == "4") alfaMsg.Error(resp.E_MESSAGE);

                // Cursor
                alfaMsg.DefaultCursor();

            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtLokasyon_KeyUp(object sender, KeyEventArgs e)
        {
            // Set BtnNext
            if ( txtAdresInput.Text.Trim().Length > 0 && cbDepo.SelectedIndex > -1 && this.m_MalzemeTuru != null )
                 alfaCtrl.EnableControl(btnNext, Color.Green);
            else alfaCtrl.DisableControl(btnNext, Color.Silver);

            // Reset Counter
            this.m_Counter = 0;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtLokasyon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Force UpperCase
            if (char.IsLower(e.KeyChar))
            {
                // Get Position
                int pos = txtAdresInput.SelectionStart;

                // Inseert Upper Key
                txtAdresInput.Text = txtAdresInput.Text.Insert(pos, char.ToUpper(e.KeyChar).ToString());

                // Set Position
                txtAdresInput.SelectionStart = pos + 1;

                // Handled
                e.Handled = true;
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            // Barkod Text
            if (txtBarkod.Text.Length > 0)
                 alfaCtrl.EnableControl(btnAdd, Color.Blue);
            else alfaCtrl.DisableControl(btnAdd, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnAdd.Enabled == true) this.btnAdd_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void grdList_CurrentCellChanged(object sender, EventArgs e)
        {
            // Select Row
            grdList.Select(grdList.CurrentRowIndex);

            // Refresh
            grdList.Refresh();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Confirmation
            if (sender != null && alfaMsg.Quest("Kayıt için emin misiniz ?") == DialogResult.No) return;
            
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZMM005_SAYIM_SAVE prms = new Terminal2012.WR.ZMM005_SAYIM_SAVE();

                // Set Parameters
                prms.I_MLZ_TIP = this.m_MalzemeTuru;

                // Create List
                List<WR.ZPP_S_SAYIM> listTable = new List<WR.ZPP_S_SAYIM>();

                // Add Rows
                for (int li = 0; li < m_TableList.Rows.Count; li++)
                {
                    // Create Row
                    WR.ZPP_S_SAYIM row = new Terminal2012.WR.ZPP_S_SAYIM();

                    // Assign Row
                    row.ADRES = m_TableList.Rows[li]["ADRES"].ToString();
                    row.BARKOD = m_TableList.Rows[li]["BARKOD"].ToString();
                    row.DEPO = m_TableList.Rows[li]["DEPO"].ToString();
                    row.DEPO_USER = m_TableList.Rows[li]["DEPO_USER"].ToString();
                    row.ADRES_USER = m_TableList.Rows[li]["ADRES_USER"].ToString();
                    row.MLZ_ADI = m_TableList.Rows[li]["MLZ_ADI"].ToString();
                    row.MLZ_KODU = m_TableList.Rows[li]["MLZ_KODU"].ToString();
                    row.MLZ_TIP = m_TableList.Rows[li]["MLZ_TIP"].ToString();
                    row.PKTICIADT = m_TableList.Rows[li]["PKTICIADT"].ToString();
                    row.DOSYA = m_TableList.Rows[li]["DOSYA"].ToString();
                    row.OKUTMASAAT = m_TableList.Rows[li]["OKUTMASAAT"].ToString();
                    row.OKUTMATRH = m_TableList.Rows[li]["OKUTMATRH"].ToString();
                    row.SASNO = m_TableList.Rows[li]["SASNO"].ToString();
                    row.SATILDI = m_TableList.Rows[li]["SATILDI"].ToString();
                    row.TUKETILDI = m_TableList.Rows[li]["TUKETILDI"].ToString();
                    row.URETIMYERI = m_TableList.Rows[li]["URETIMYERI"].ToString();
                    row.OKUTAN = m_TableList.Rows[li]["OKUTAN"].ToString();
                    row.PARTI = m_TableList.Rows[li]["PARTI"].ToString();
                    row.KILO = decimal.Parse(m_TableList.Rows[li]["KILO"].ToString());
                    row.SIPNO = m_TableList.Rows[li]["SIPNO"].ToString();
                    row.KALEM = m_TableList.Rows[li]["KLM"].ToString();

                    // Add Row
                    listTable.Add(row);
                }

                // Params
                prms.T_SAYIMTERMINAL = listTable.ToArray();

                // Call Service
                WR.ZMM005_SAYIM_SAVEResponse resp = p_SAP.ZMM005_SAYIM_SAVE(prms);

                // Message
                if (resp.E_SUBRC == "0")
                {
                    // Message
                    alfaMsg.Info("Sayım kaydedilmiştir !");

                    // Reset
                    this.btnCancel_Click(null, null);
                }
                else alfaMsg.Error(resp.E_MESSAGE);

                // Cursor
                alfaMsg.DefaultCursor();

            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

    }
}