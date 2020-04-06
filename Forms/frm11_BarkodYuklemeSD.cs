using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;


namespace Terminal2012
{
    public partial class frm11_BarkodYuklemeSD : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        #region [---- Member Fields ----]

        // SelectedItem
        int m_SelectedItem = 0;

        // System 
        AlfaSys m_System = null;

        // Function01 Result
        WR.ZSD_F_TERMINAL_YUKLEME_01Response FN01Result = null;

        #endregion

        //-----------------------------------------------------------------------------------------------------------//

        public frm11_BarkodYuklemeSD(AlfaSys p_System)
        {
            // Initialize
            InitializeComponent();

            // Set System
            this.m_System = p_System;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm02_BarkodYuklemeMM_Load(object sender, EventArgs e)
        {
            // Page01
            this.PageActivate(pnPage01);

            // Clear
            this.btnClear_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnList_Click(object sender, EventArgs e)
        {
            if (tbFisNo.Text == string.Empty)
            {
                // Check Input
                alfaMsg.Error("Eksik Bilgi Girdiniz !"); return;
            }

            // Focus
            this.btnList.Focus();

            // Get List
            this.Get_EmirList(0);
        }
        
        //-----------------------------------------------------------------------------------------------------------//

        private void Get_EmirList( int p_RowIndex )
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Parameters
                WR.ZSD_F_TERMINAL_YUKLEME_01 prms = new Terminal2012.WR.ZSD_F_TERMINAL_YUKLEME_01();
                prms.I_FISNO = tbFisNo.Text;
                prms.I_KONSI = string.Empty; 
                prms.ET_YE_LIST = new Terminal2012.WR.ZSD_S_YE_LIST[0];

                // Call Service
                FN01Result = p_SAP.ZSD_F_TERMINAL_YUKLEME_01(prms);

                // Create Table
                DataTable p_Table = alfaGrid.ToDataTable(FN01Result.ET_YE_LIST, "ET_YE_LIST");

                // Create Style
                alfaGrid.CreateTableStyle(grdEmirList, p_Table, "KALAN");

                // Assign to Grid
                grdEmirList.DataSource = p_Table;

                // Check Data
                if (FN01Result.ET_YE_LIST.Length > 0)
                {
                    // Focus
                    grdEmirList.Focus();

                    // Disable FisNo
                    tbFisNo.Enabled = false;

                    // Total KG
                    lbTotal_v1.Text = String.Format("Y.Tonaj = {0:0,0}", FN01Result.E_TOTKG);
                    lbTotal_v2.Text = String.Format("Y.Tonaj = {0:0,0}", FN01Result.E_TOTKG);

                    // Paket 
                    lbPaket.Text = String.Format("Y.Paket = {0:0}", FN01Result.E_TOTPK);

                    // Select Record
                    this.m_SelectedItem = p_RowIndex;
                    grdEmirList.Select(p_RowIndex);
                    grdEmirList.CurrentRowIndex = p_RowIndex;
                    
                    // RecordCount
                    lbRecordCount01.Text = "Adet = " + FN01Result.ET_YE_LIST.Length.ToString();

                    if (pnPage01.Visible == true)
                    {
                        alfaCtrl.EnableControl(btnNext, Color.Green);
                        alfaCtrl.EnableControl(btnMalzemeAdres, Color.Navy);
                    }
                }
                else
                {
                    // Empty List
                    this.m_SelectedItem = p_RowIndex;
                    alfaCtrl.DisableControl(btnNext, Color.Silver);
                    alfaCtrl.DisableControl(btnMalzemeAdres, Color.Silver);
                    lbRecordCount01.Text = "Adet = 0";
                }

                // Show Error
                if (FN01Result.E_SUBRC == "4") alfaMsg.Error(FN01Result.E_HATA);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Disable Buttons
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);
            alfaCtrl.DisableControl(btnList, Color.Silver);
            alfaCtrl.DisableControl(btnMalzemeAdres, Color.Silver);

            // Enable FisNo
            tbFisNo.Enabled = true;

            // Clear Texts
            lbRecordCount01.Text = string.Empty;
            lbTotal_v1.Text = string.Empty;
            lbTotal_v2.Text = string.Empty;
            lbPaket.Text = string.Empty;

            // Reset Grid
            grdEmirList.DataSource = null;
            
            // Reset TextBox
            tbFisNo.Text = string.Empty;

            // Clear Selected
            m_SelectedItem = -1;

            // Focus
            tbFisNo.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void grdEmirList_CurrentCellChanged(object sender, EventArgs e)
        {
            // Select Full Row
            grdEmirList.Select(grdEmirList.CurrentRowIndex);

            // SelectedItem
            m_SelectedItem = grdEmirList.CurrentRowIndex;

            // Refresh
            grdEmirList.Refresh();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void grdBarkod_CurrentCellChanged(object sender, EventArgs e)
        {
            // Select Full Row
            grdBarkod.Select(grdBarkod.CurrentRowIndex);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Components
            PageActivate(pnPage01);
            alfaCtrl.EnableControl(btnNext, Color.Green);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);

            // Focus
            grdEmirList.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // CursorWait
                alfaMsg.WaitCursor();
                
                // Set Controls
                PageActivate(pnPage02);
                alfaCtrl.EnableControl(btnPrev, Color.Green);
                alfaCtrl.DisableControl(btnNext, Color.Silver);

                // Fill Data
                this.Fill_Selected_Data( "L", null ); // LIST

                // CursorDefault
                alfaMsg.DefaultCursor();

                // Focus
                tbBarkod.Focus();

            }
            catch (Exception ex)
            {
                // Error Message
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Fill_Selected_Data( string p_Operation, string p_Barkod )
        {
            // Get Table01
            WR.ZSD_S_YE_LIST[] dt = FN01Result.ET_YE_LIST;

            // Assign Values
            tbMusteri.Text    = dt[m_SelectedItem].MUSTERI;
            tbPlakaNo.Text    = dt[m_SelectedItem].PLAKA;
            tbMalzeme.Text    = dt[m_SelectedItem].ACIKLAMA;
            tbYuklenecek.Text = dt[m_SelectedItem].MIKTAR.ToString();
            tbYuklenen.Text   = dt[m_SelectedItem].TOTAL.ToString();

            // Clear Barkod
            tbBarkod.Text = string.Empty;

            // Create Service
            alfaSAP p_SAP = new alfaSAP();

            // Set Barkod
            dt[m_SelectedItem].BARKOD = p_Barkod;

            // Create Params
            WR.ZSD_F_TERMINAL_YUKLEME_02 prms = new Terminal2012.WR.ZSD_F_TERMINAL_YUKLEME_02();
            
            // Set Params
            prms.ET_YE_DET = new Terminal2012.WR.ZSD_S_TARTIM_DET_TRM[0];
            prms.I_UNAME = this.m_System.UserId;
            prms.I_YE_LIST = dt[m_SelectedItem];
            prms.I_OPERATION = p_Operation;
            
            // Call Service
            WR.ZSD_F_TERMINAL_YUKLEME_02Response resp = p_SAP.ZSD_F_TERMINAL_YUKLEME_02(prms);

            // Result
            grdBarkod.DataSource = resp.ET_YE_DET;

            if (resp.ET_YE_DET.Length > 0)
            {
                // Set Controls
                alfaCtrl.EnableControl(btnDel, Color.Blue);

                // Select Row
                grdBarkod.Select(grdBarkod.CurrentRowIndex);

                // RecordCount
                lbRecordCount02.Text = "Adet = " + resp.ET_YE_DET.Length.ToString();
            }
            else
            {
                // Set Controls
                alfaCtrl.DisableControl(btnDel, Color.Silver);

                // RecordCount
                lbRecordCount02.Text = "Adet = 0";
            }

            // Show Error
            if (resp.E_SUBRC == "4") alfaMsg.Error(resp.E_HATA);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check Input
            if (tbBarkod.Text == string.Empty) return;

            try
            {
                // Modify Barkod
                this.Fill_Selected_Data("M", tbBarkod.Text);

                // Clear Input
                tbBarkod.Text = string.Empty;

                // Refresh
                this.Get_Okutulan_Miktar();

            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Get Table
            WR.ZSD_S_TARTIM_DET_TRM[] dt = (WR.ZSD_S_TARTIM_DET_TRM[])grdBarkod.DataSource;

            // Check Table
            if (dt.Length == 0) return;

            try
            {
                // Get Barkod
                string p_Barkod = dt[grdBarkod.CurrentRowIndex].BARKOD;

                // Delete Barkod
                Fill_Selected_Data("D", p_Barkod);

                // Refresh
                Get_Okutulan_Miktar();
            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Get_Okutulan_Miktar()
        {
            // EmirList
            Get_EmirList(m_SelectedItem);

            // Get Table01
            WR.ZSD_S_YE_LIST[] dt = FN01Result.ET_YE_LIST;

            // Get Miktar
            tbYuklenen.Text = dt[m_SelectedItem].TOTAL.ToString();

            // Focus
            tbBarkod.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void PageActivate( System.Windows.Forms.Panel p_Panel )
        {
            pnPage01.Visible = false;
            pnPage02.Visible = false;
            p_Panel.Visible = true;
            p_Panel.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void tbBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            // Enter Press
            if (e.KeyCode == Keys.Enter && btnAdd.Enabled == true) btnAdd_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnMalzemeAdres_Click(object sender, EventArgs e)
        {
            // Get Table01
            WR.ZSD_S_YE_LIST[] dt = FN01Result.ET_YE_LIST;

            // Assign Values
            string p_MalzemeNo = dt[m_SelectedItem].MALZEME;
            string p_Vbeln = dt[m_SelectedItem].SIPARIS;
            string p_Posnr = dt[m_SelectedItem].KALEM;
            string p_Barkod = dt[m_SelectedItem].MALZEME;

            // Create Form
            frm00_MalzemeAdres frm = new frm00_MalzemeAdres(this.m_System, p_MalzemeNo, p_Vbeln, p_Posnr, p_Barkod);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show Form
            frm.ShowDialog();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void tbFisNo_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnListele
            if (tbFisNo.Text.Length == 11) alfaCtrl.EnableControl (btnList, Color.Blue);
                                      else alfaCtrl.DisableControl(btnList, Color.Silver); 

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnList.Enabled == true) btnList_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

    }
}