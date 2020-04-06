using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Terminal2012
{
    public partial class frm03_BarkodIndirmeMM : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        #region [---- Member Fields ----]

        // System 
        AlfaSys m_System = null;

        // Function01 Result
        WR.ZMM005_UYSTOKNAKLI_05Response FN05Result01 = null;
        WR.ZMM005_UYSTOKNAKLI_05Response FN05Result02 = null;

        #endregion

        //-----------------------------------------------------------------------------------------------------------//

        public frm03_BarkodIndirmeMM(AlfaSys p_System)
        {
            // Initialize
            InitializeComponent();

            // Set System
            this.m_System = p_System;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm03_BarkodIndirmeMM_Load(object sender, EventArgs e)
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
            if ( this.Check_FisKayitDurumu() == true ) this.Get_Indirilecek_Malzemeler();
        }
        
        //-----------------------------------------------------------------------------------------------------------//

        private bool Check_FisKayitDurumu()
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                WR.ZMM005_FISKAYITDURUMU prms = new Terminal2012.WR.ZMM005_FISKAYITDURUMU();
                prms.I_FISNO = txtFisNo.Text;
                prms.I_LOKASYON = "T";
                prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];

                // Call Service
                WR.ZMM005_FISKAYITDURUMUResponse resp = p_SAP.ZMM005_FISKAYITDURUMU(prms);

                // Show Error
                if (resp.E_SUBRC == 4)
                {
                    alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE); return false;
                }

                // Cursor
                alfaMsg.DefaultCursor();

                // Return
                return true;
            
            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);

                // Return
                return false;
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Get_Indirilecek_Malzemeler()
        {
            try
            {
                // Cursor
                Cursor.Current = Cursors.WaitCursor;

                // Create Service
                alfaSAP p_SAP = new alfaSAP();
                
                // Parameters
                WR.ZMM005_UYSTOKNAKLI_05 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_05();
                prms.IV_MODE = " ";
                prms.IV_FISNO = txtFisNo.Text;
                prms.T_FISITEMS_EMIR = new Terminal2012.WR.ZMM_S_UY03[0];

                // Call Service
                FN05Result01 = p_SAP.ZMM005_UYSTOKNAKLI_05(prms);

                // Create Table
                System.Data.DataTable p_Table = alfaGrid.ToDataTable(FN05Result01.T_FISITEMS_EMIR, "T_FISITEMS_EMIR");

                // Create Style
                alfaGrid.CreateTableStyle(grdIndirilecekMalzemeler, p_Table, "DEFAULT");

                // Assign to Grid
                grdIndirilecekMalzemeler.DataSource = p_Table;

                // Check Data
                if (FN05Result01.T_FISITEMS_EMIR.Length > 0)
                {
                    // Select FirstRow
                    grdIndirilecekMalzemeler.Select(0);
                    grdIndirilecekMalzemeler.CurrentRowIndex = 0;

                    // Set Controls
                    alfaCtrl.EnableControl(btnNext, Color.Green);
                    alfaCtrl.EnableControl(btnAdres, Color.Blue);
                    alfaCtrl.EnableControl(btnIndir, Color.Blue);
                    alfaCtrl.EnableControl(txtBarkod, Color.Black);

                    // Focus
                    txtBarkod.Focus();

                    // RecordCount
                    lbRecordCount01.Text = "Adet = " + FN05Result01.T_FISITEMS_EMIR.Length.ToString();
                }
                else
                {
                    // Set Controls
                    alfaCtrl.EnableControl(btnNext, Color.Green);
                    alfaCtrl.DisableControl(btnAdres, Color.Silver);
                    alfaCtrl.DisableControl(txtBarkod, Color.Silver);
                    alfaCtrl.DisableControl(btnIndir, Color.Silver);

                    // RecordCount
                    lbRecordCount01.Text = "Adet = 0";
                }

                // Show Error
                if (FN05Result01.E_SUBRC == "4") alfaMsg.Error(FN05Result01.T_MESSAGES[0].MESSAGE);

                // Cursor
                Cursor.Current = Cursors.Default;
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
            // Reset Grids
            grdIndirilmisMalzemeler.DataSource = null;
            grdIndirilecekMalzemeler.DataSource = null;
            
            // Reset TextBox
            txtFisNo.Text = string.Empty;
            txtBarkod.Text = string.Empty;

            // Focus
            txtFisNo.Focus();

            // Clear Counts
            lbRecordCount01.Text = string.Empty;
            lbRecordCount02.Text = string.Empty;

            //Disable Buttons
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);
            alfaCtrl.DisableControl(btnIndir, Color.Silver);
            alfaCtrl.DisableControl(txtBarkod, Color.Silver);
            alfaCtrl.DisableControl(btnList, Color.Silver);
            alfaCtrl.DisableControl(btnAdres, Color.Silver);
        }


        //-----------------------------------------------------------------------------------------------------------//

        private void gridALL_CurrentCellChanged(object sender, EventArgs e)
        {
            // Get Grid
            DataGrid grd = (sender as DataGrid);

            // Select Row
            grd.Select(grd.CurrentRowIndex);

            // Refresh
            grd.Refresh();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PageActivate(pnPage01);
            alfaCtrl.EnableControl(btnNext, Color.Green);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                Cursor.Current = Cursors.WaitCursor;
                
                PageActivate(pnPage02);
                alfaCtrl.EnableControl(btnPrev, Color.Green);
                alfaCtrl.DisableControl(btnNext, Color.Silver);
                Get_Indirilmis_Malzemeler();

                // Cursor
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Get_Indirilmis_Malzemeler()
        {
            try
            {
                // Cursor
                Cursor.Current = Cursors.WaitCursor;

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Parameters
                WR.ZMM005_UYSTOKNAKLI_05 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_05();
                prms.IV_MODE = "X";
                prms.IV_FISNO = txtFisNo.Text;
                prms.T_FISITEMS_EMIR = new Terminal2012.WR.ZMM_S_UY03[0];

                // Call Service
                FN05Result02 = p_SAP.ZMM005_UYSTOKNAKLI_05(prms);

                // Grid
                grdIndirilmisMalzemeler.DataSource = FN05Result02.T_FISITEMS_EMIR;

                // Check Data
                if (FN05Result02.T_FISITEMS_EMIR.Length > 0)
                {
                    // Select Row
                    grdIndirilmisMalzemeler.Select(grdIndirilmisMalzemeler.CurrentRowIndex);
                    
                    // RecordCount
                    lbRecordCount02.Text = "Adet = " + FN05Result02.T_FISITEMS_EMIR.Length.ToString();
                }
                else
                {
                    // RecordCount
                    lbRecordCount02.Text = "Adet = 0";
                }

                // Show Error
                if (FN05Result02.E_SUBRC == "4") alfaMsg.Error(FN05Result02.T_MESSAGES[0].MESSAGE);

                // Cursor
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
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

        private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            // Enter Press
            if (e.KeyCode == Keys.Enter && btnIndir.Enabled == true) btnIndir_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnIndir_Click(object sender, EventArgs e)
        {
            // Get Barkod Line
            WR.ZMM_S_UY03 p_BarkodLine = Find_Barkod_Line(txtBarkod.Text);

            // Check Barkod
            if (p_BarkodLine == null)
            {
                alfaMsg.Error("Yanlış Barkod Girdiniz !"); return;
            }

            // Create Service
            alfaSAP p_SAP = new alfaSAP();
            
            // Parameters
            WR.ZMM005_UYSTOKNAKLI_06 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_06();

            prms.I_FISNO = txtFisNo.Text;
            prms.I_BARKOD = txtBarkod.Text;
            prms.I_LGPBE = txtAdres.Text;
            prms.IS_OKUTULAN = p_BarkodLine;
            prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];

            // Call Service
            WR.ZMM005_UYSTOKNAKLI_06Response resp = p_SAP.ZMM005_UYSTOKNAKLI_06(prms);

            // Show Result
            if (resp.E_SUBRC == "4") alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE);
            else
            {   
                // Clear
                txtBarkod.Text = string.Empty;
                
                // Get List
                this.Get_Indirilecek_Malzemeler();
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private WR.ZMM_S_UY03 Find_Barkod_Line(string p_Barkod)
        {
            // Get Table
            WR.ZMM_S_UY03[] dtTable = FN05Result01.T_FISITEMS_EMIR;

            for (int li = 0; li < dtTable.Length; li++)
            {
                // Return Barkod Index
                if (dtTable[li].BARKOD == p_Barkod) return dtTable[li];
            }

            // Null
            return null;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnAdres_Click(object sender, EventArgs e)
        {
            // Get Table01
            WR.ZMM_S_UY03[] dt = FN05Result01.T_FISITEMS_EMIR;

            // Assign Values
            string p_MalzemeNo = dt[grdIndirilecekMalzemeler.CurrentRowIndex].MALZEME;
            string p_Vbeln = dt[grdIndirilecekMalzemeler.CurrentRowIndex].SATISBEL;
            string p_Posnr = dt[grdIndirilecekMalzemeler.CurrentRowIndex].SATISKALEM;
            string p_Barkod = dt[grdIndirilecekMalzemeler.CurrentRowIndex].BARKOD;

            // Create Form
            frm00_MalzemeAdres frm = new frm00_MalzemeAdres(this.m_System, p_MalzemeNo, p_Vbeln, p_Posnr, p_Barkod);


            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show Form
            frm.ShowDialog();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void tbAdres_TextChanged(object sender, EventArgs e)
        {
            // Force for UpperCase
            txtAdres.Text = txtAdres.Text.ToUpper();
            txtAdres.Select(txtAdres.Text.Length, 0);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void tbALL_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnList
            if (txtFisNo.Text.Length == 11) alfaCtrl.EnableControl(btnList, Color.Blue);
                                       else alfaCtrl.DisableControl(btnList, Color.Silver);

            // Enter
            if (e.KeyCode == Keys.Enter && btnList.Enabled == true) this.btnList_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//
    }
}