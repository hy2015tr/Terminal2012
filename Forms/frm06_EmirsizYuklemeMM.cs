using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Terminal2012
{
    public partial class frm06_EmirsizYuklemeMM : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        #region [---- Member Fields ----]

        // System 
        AlfaSys m_System = null;
        
        // Function01 Result
        WR.ZMM005_UYSTOKNAKLI_11Response FN01Result = null;

        #endregion

        //-----------------------------------------------------------------------------------------------------------//

        public frm06_EmirsizYuklemeMM(AlfaSys p_System)
        {
            // Initialize
            InitializeComponent();

            // Set System
            this.m_System = p_System;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm06_EmirsizYuklemeMM_Load(object sender, EventArgs e)
        {
            // Page01
            this.PageActivate(pnPage01);

            // Clear
            this.btnClear_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnList_Click(object sender, EventArgs e)
        {
            if (txtFisNo.Text == string.Empty)
            {
                // Check Input
                alfaMsg.Error("Eksik Bilgi Girdiniz !"); return;
            }

            // Get List
            this.Get_Emirsiz_Yukleme_List("L", null);

            // Enable Next
            alfaCtrl.EnableControl(btnNext, Color.Green);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Get_Emirsiz_Yukleme_List( string p_Operation, string p_Barkod )
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZMM005_UYSTOKNAKLI_11 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_11();

                // Structure
                WR.ZMM_S_FISITEMS_EMIR p_line = new Terminal2012.WR.ZMM_S_FISITEMS_EMIR();
                p_line.FISNO = txtFisNo.Text;
                p_line.BARKOD = p_Barkod;

                // Set Params
                prms.I_FISITEMS = p_line;
                prms.I_OPERATION = p_Operation;
                prms.I_UNAME = this.m_System.UserId;
                prms.T_TABLE = new Terminal2012.WR.ZMM_S_UY03[0];
                prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];

                // Call Service
                FN01Result = p_SAP.ZMM005_UYSTOKNAKLI_11(prms);

                if (p_Operation=="M")
                {
                    // Assign Text Fields
                    txtBrkdNo.Text = txtBarkod.Text;
                    txtAdresExport.Text = FN01Result.E_EXPORT.ADRES;
                    txtMalzemeTxt.Text = FN01Result.E_EXPORT.MLZ_ADI;
                    txtMalzemeNo.Text = FN01Result.E_EXPORT.MLZ_KODU;
                    txtMalzemeTuru.Text = FN01Result.E_EXPORT.MLZ_TIP;
                    txtPaketAdet.Text = FN01Result.E_EXPORT.PKTICIADT;
                    txtTuketildi.Text = FN01Result.E_EXPORT.TUKETILDI;
                    txtSatildi.Text = FN01Result.E_EXPORT.SATILDI;
                    txtUretimYeri.Text = FN01Result.E_EXPORT.URETIMYERI;
                    txtDepoYeri.Text = FN01Result.E_EXPORT.DEPO;
                    txtSasNo.Text = FN01Result.E_EXPORT.SASNO;
                    txtMalzemeParti.Text = FN01Result.E_EXPORT.PARTI;
                    txtSiparis.Text = FN01Result.E_EXPORT.SIPNO;
                    txtSipKlm.Text = FN01Result.E_EXPORT.KALEM;

                    // Agirlik
                    if (FN01Result.E_EXPORT.KILO == 0)
                         txtPaketAgirlik.Text = string.Empty;
                    else txtPaketAgirlik.Text = FN01Result.E_EXPORT.KILO.ToString();
                }

                // Create Table
                System.Data.DataTable p_Table = alfaGrid.ToDataTable(FN01Result.T_TABLE, "T_TABLE");

                // Create Style
                alfaGrid.CreateTableStyle(grdList, p_Table, "DEFAULT");

                // Assign to Grid
                grdList.DataSource = p_Table;

                // Check Data
                if (FN01Result.T_TABLE.Length > 0)
                {
                    // Select Record
                    grdList.Select(0);
                    grdList.CurrentRowIndex = 0;
                    
                    // Set Text
                    lbRecordCount01.Text = "Adet = " + FN01Result.T_TABLE.Length.ToString();
                    txtGirilenKilo.Text = FN01Result.E_TOPOKUTULAN.ToString();

                    // Enable Controls
                    alfaCtrl.EnableControl(btnDel, Color.Blue);
                    alfaCtrl.EnableControl(txtBarkod, Color.Black);
                    alfaCtrl.EnableControl(txtGirilenKilo, Color.Black);
                }
                else
                {
                    // Clear Text
                    lbRecordCount01.Text = "Adet = 0";
                    txtGirilenKilo.Text = string.Empty;

                    // Disable Controls
                    alfaCtrl.DisableControl(btnDel, Color.Silver);
                    alfaCtrl.EnableControl(txtBarkod, Color.Black);
                    alfaCtrl.EnableControl(txtGirilenKilo, Color.Black);
                }

                // Show Error
                if (FN01Result.E_SUBRC == "4") alfaMsg.Error(FN01Result.T_MESSAGES[0].MESSAGE);

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
            alfaCtrl.DisableControl(btnAdd, Color.Silver);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);
            alfaCtrl.DisableControl(btnList, Color.Silver);
            alfaCtrl.DisableControl(btnDel, Color.Silver);
            alfaCtrl.DisableControl(txtBarkod, Color.Silver);
            alfaCtrl.DisableControl(txtGirilenKilo, Color.Silver);

            // Clear Record Count
            lbRecordCount01.Text = string.Empty;

            // Clear Texts
            txtAdresExport.Text = string.Empty;
            txtBarkod.Text = string.Empty;
            txtBrkdNo.Text = string.Empty;
            txtDepoYeri.Text = string.Empty;
            txtFisNo.Text = string.Empty;
            txtGirilenKilo.Text = string.Empty;
            txtMalzemeNo.Text = string.Empty;
            txtMalzemeParti.Text = string.Empty;
            txtMalzemeTuru.Text = string.Empty;
            txtMalzemeTxt.Text = string.Empty;
            txtPaketAdet.Text = string.Empty;
            txtPaketAgirlik.Text = string.Empty;
            txtSasNo.Text = string.Empty;
            txtSatildi.Text = string.Empty;
            txtSiparis.Text = string.Empty;
            txtSipKlm.Text = string.Empty;
            txtTuketildi.Text = string.Empty;
            txtUretimYeri.Text = string.Empty;

            // Reset Grid
            grdList.DataSource = null;

            // Focus
            txtFisNo.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void grdList_CurrentCellChanged(object sender, EventArgs e)
        {
            // Select Full Row
            grdList.Select(grdList.CurrentRowIndex);

            // Refresh
            grdList.Refresh();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check Input
            if (txtBarkod.Text == string.Empty) return;

            try
            {
                // Modify Barkod
                this.Get_Emirsiz_Yukleme_List("M", txtBarkod.Text);

                // Clear Input
                txtBarkod.Text = string.Empty;

                // Disable btnAdd
                alfaCtrl.DisableControl(btnAdd, Color.Silver);

                // Focus
                txtBarkod.Focus();

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
            DataTable dt = (DataTable)grdList.DataSource;

            // Check Table
            if (dt.Rows.Count == 0) return;

            try
            {
                // Get Barkod
                string p_Barkod = dt.Rows[grdList.CurrentRowIndex]["BARKOD"].ToString();

                // Delete Barkod
                this.Get_Emirsiz_Yukleme_List("D",p_Barkod);

            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void PageActivate(System.Windows.Forms.Panel p_Panel)
        {
            pnPage01.Visible = false;
            pnPage02.Visible = false;
            p_Panel.Visible = true;
            p_Panel.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtFisNo_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnListele
            if (txtFisNo.Text.Length == 11) alfaCtrl.EnableControl (btnList, Color.Blue);
                                       else alfaCtrl.DisableControl(btnList, Color.Silver); 

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnList.Enabled == true) btnList_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnAdd
            if ( txtBarkod.Text.Length > 0 ) alfaCtrl.EnableControl (btnAdd, Color.Blue);
                                        else alfaCtrl.DisableControl(btnAdd, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnAdd.Enabled == true) this.btnAdd_Click(null, null);
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

                    // Disable btnNext
                    alfaCtrl.DisableControl(btnNext, Color.Silver);

                    // Enable btnPrev
                    alfaCtrl.EnableControl(btnPrev, Color.Green);
                }

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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                // CursorWait
                alfaMsg.WaitCursor();

                if (pnPage02.Visible)
                {
                    // Page01
                    this.PageActivate(pnPage01);

                    // Disable btnPrev
                    alfaCtrl.DisableControl(btnPrev, Color.Silver);

                    // Enable btnNext
                    alfaCtrl.EnableControl(btnNext, Color.Green);
                }

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
    }
}