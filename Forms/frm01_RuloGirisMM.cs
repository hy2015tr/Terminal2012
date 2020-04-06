using System;
using System.Drawing;
using System.Windows.Forms;


namespace Terminal2012
{
    public partial class frm01_RuloGirisMM : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        public frm01_RuloGirisMM()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                Cursor.Current = Cursors.WaitCursor;

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Parameters
                WR.ZMM005_RULOGIRIS_01 prms = new WR.ZMM005_RULOGIRIS_01();
                prms.I_FISNO = tbFisNo.Text;
                prms.I_SEFERNO = tbSeferNo.Text;

                // Call Service
                WR.ZMM005_RULOGIRIS_01Response resp = p_SAP.ZMM005_RULOGIRIS_01(prms);

                // Create Table
                System.Data.DataTable p_Table = alfaGrid.ToDataTable(resp.T_ITEMS, "T_ITEMS");

                // Create Style
                alfaGrid.CreateTableStyle(grdList, p_Table, "DEFAULT");

                // Assign to Grid
                grdList.DataSource = p_Table;

                // Check Data
                if (resp.T_ITEMS.Length > 0)
                {
                    // Select Row
                    grdList.Select(grdList.CurrentRowIndex);
                    
                    // Enable Next
                    alfaCtrl.EnableControl(btnNext, Color.Green);

                    // RecordCount
                    lbRecordCount01.Text = "Adet = " + resp.T_ITEMS.Length.ToString();
                }
                else
                {
                    // Disable Next
                    alfaCtrl.DisableControl(btnNext, Color.Silver);

                    // RecordCount
                    lbRecordCount01.Text = "Adet = 0";
                } 

                // Cursor
                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Disable Buttons
            alfaCtrl.DisableControl(btnList, Color.Silver);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);

            // Clear Count
            lbRecordCount01.Text = string.Empty;

            // Reset Grid
            grdList.DataSource = null;
            
            // Reset TextBox
            tbFisNo.Text = string.Empty;
            tbSeferNo.Text = string.Empty;

            // Focus
            tbFisNo.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frmRuloGirisMM_Load(object sender, EventArgs e)
        {
            // Page01 
            PageActivate(pnPage01);

            // Clear
            this.btnClear_Click(null, null);
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

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.PageActivate(pnPage01);
            alfaCtrl.EnableControl(btnNext, Color.Green);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Set Controls
                this.PageActivate(pnPage02);
                alfaCtrl.EnableControl(btnPrev, Color.Green);
                alfaCtrl.DisableControl(btnNext, Color.Silver);
                
                // Fill Data
                Fill_Selected_Data();
            }
            catch (Exception ex)
            {
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Fill_Selected_Data()
        {
            // Get DataArray
            WR.ZMM_WS_RULOGIRIS[] dt = (WR.ZMM_WS_RULOGIRIS[]) grdList.DataSource;

            // Assign Values
            tbMalzeme.Text  = dt[grdList.CurrentRowIndex].TANIM;
            tbAdet.Text     = dt[grdList.CurrentRowIndex].KALANADET;
            tbMiktar.Text   = dt[grdList.CurrentRowIndex].KALANKILO;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Confirmation
            if (alfaMsg.Quest("İşlemi Kayit Etmek için Emin misiniz ?") == DialogResult.No) return;

            // Cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Get DataArray
                WR.ZMM_WS_RULOGIRIS[] dt = (WR.ZMM_WS_RULOGIRIS[])grdList.DataSource;

                // Param Main
                WR.ZMM005_RULOGIRIS_02 prmMain = new WR.ZMM005_RULOGIRIS_02();

                // Create Table
                WR.ZMMS_WS_RULOGIRIS[] dtTemp = new Terminal2012.WR.ZMMS_WS_RULOGIRIS[0];

                // Set Values
                dtTemp[0].TESKALEMNO = dt[grdList.CurrentRowIndex].TESKALEMNO;
                dtTemp[0].TESLIMATNO = dt[grdList.CurrentRowIndex].TESLIMATNO;
                dtTemp[0].BARKODNO = tbBarkodNo.Text;
                dtTemp[0].KILO = tbKilo.Text;
                dtTemp[0].DEPO = tbDepo.Text;
                dtTemp[0].MGTRH = alfaDate.GetDate(DateTime.Now);
                dtTemp[0].BARKODNO = tbBarkodNo.Text;
                dtTemp[0].BULTENNO = tbBultenNo.Text;
                dtTemp[0].HEATNO = tbHeatNo.Text;
                dtTemp[0].ILKKANTAR = tbTarti.Text;
                dtTemp[0].IRSALIYENO = tbIrsaliye.Text;

                // Set Table
                prmMain.T_INPUT = dtTemp; //new Terminal2012.WR.ZMMS_WS_RULOGIRIS[0];

                // Set Table
                prmMain.T_RETURN = new Terminal2012.WR.ZRFC_BAPIRET2_TAB[0];


                // Call Service
                WR.ZMM005_RULOGIRIS_02Response resp = p_SAP.ZMM005_RULOGIRIS_02(prmMain);

                // Cursor
                Cursor.Current = Cursors.Default;

                if (resp.T_MESSAGES[0].TYPE == "S")
                {
                    // Disable Controls
                    alfaCtrl.DisableControl(btnSave, Color.Silver);
                    alfaCtrl.DisableControl(btnPrev, Color.Silver);

                    // Show Message
                    alfaMsg.Info(resp.T_MESSAGES[0].MESSAGE);
                }

                // Show Error
                else alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE);

            }
            catch (Exception ex)
            {
                // Message
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

        private void tbALL_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnListele
            if (tbFisNo.Text.Length == 11 && tbSeferNo.Text.Length > 0 ) 
                 alfaCtrl.EnableControl (btnList, Color.Blue);
            else alfaCtrl.DisableControl(btnList, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnList.Enabled == true) btnList_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

    }
}