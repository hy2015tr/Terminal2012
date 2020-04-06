using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Terminal2012
{
    public partial class frm05_FasonGrupIciMM : Form
    {

        //-----------------------------------------------------------------------------------------------------------//

        #region [---- Member Fields ----]

        // Space
        string m_SPACE = " ";

        // Function01 Result
        WR.ZMM005_UYSTOKNAKLI_09Response Result01 = null;
        WR.ZMM005_UYSTOKNAKLI_09Response Result02 = null;

        #endregion

        //-----------------------------------------------------------------------------------------------------------//

        public frm05_FasonGrupIciMM()
        {
            InitializeComponent();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm05_FasonGrupIciMM_Load(object sender, EventArgs e)
        {
            // Page01 
            PageActivate(pnPage01);

            //Clear
            btnClear_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnList_Click(object sender, EventArgs e)
        {
            if (tbFisNo.Text == string.Empty && tbYuklemeEmri.Text == string.Empty)
            {
                // Check Input
                alfaMsg.Error("Eksik Bilgi Girdiniz !"); return;
            }

                 // Get List
            else this.Get_Indirilecek_Malzemeler();
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
                
                // Create Parameters
                WR.ZMM005_UYSTOKNAKLI_09 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_09();

                // Set Parameters
                prms.I_MODE = m_SPACE;
                prms.I_OPERATION = "L";
                prms.I_LGPBE = string.Empty;
                prms.I_FISNO = tbFisNo.Text;
                prms.I_YUKEMRNO = tbYuklemeEmri.Text;
                prms.I_ITEM = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS();
                prms.T_ITEMS = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS[0];
                prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];

                // Call Service
                Result01 = p_SAP.ZMM005_UYSTOKNAKLI_09(prms);

                // Create Table
                System.Data.DataTable p_Table = alfaGrid.ToDataTable(Result01.T_ITEMS, "T_ITEMS");

                // Create Style
                alfaGrid.CreateTableStyle(grdIndirilecekMalzemeler, p_Table, "DEFAULT");

                // Assign to Grid
                grdIndirilecekMalzemeler.DataSource = p_Table;

                // Disable BtnDown
                alfaCtrl.DisableControl(btnDown, Color.Silver);

                // Check Data
                if (Result01.T_ITEMS.Length > 0)
                {
                    // Select Row
                    grdIndirilecekMalzemeler.Select(grdIndirilecekMalzemeler.CurrentRowIndex);
                    
                    // Set Controls
                    alfaCtrl.EnableControl(btnNext, Color.Green);
                    alfaCtrl.EnableControl(tbBarkod, Color.Black);
                    alfaCtrl.EnableControl(tbAdres, Color.Black);

                    // RecordCount
                    lbRecordCount01.Text = "Adet = " + Result01.T_ITEMS.Length.ToString();
                }
                else
                {
                    // Set Controls
                    alfaCtrl.EnableControl(btnNext, Color.Green);
                    alfaCtrl.DisableControl(tbBarkod, Color.Silver);
                    alfaCtrl.DisableControl(tbAdres, Color.Silver);

                    // RecordCount
                    lbRecordCount01.Text = "Adet = 0";
                }

                // Show Error
                if (Result01.E_SUBRC == "4") alfaMsg.Error(Result01.T_MESSAGES[0].MESSAGE);

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
            tbFisNo.Text = string.Empty;
            tbBarkod.Text = string.Empty;
            tbYuklemeEmri.Text = string.Empty;

            // Clear Counts
            lbRecordCount01.Text = string.Empty;
            lbRecordCount02.Text = string.Empty;

            //Disable Buttons
            alfaCtrl.DisableControl(btnList, Color.Silver);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);
            alfaCtrl.DisableControl(btnDown, Color.Silver);
            alfaCtrl.DisableControl(tbBarkod, Color.Silver);
            alfaCtrl.DisableControl(tbAdres, Color.Silver);

            // Focus   
            tbFisNo.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void gridALL_CurrentCellChanged(object sender, EventArgs e)
        {
            // Get Grid
            DataGrid grd = (sender as DataGrid);

            // Select Full Row
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
                this.Get_Indirilmis_Malzemeler();

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

                // Create Parameters
                WR.ZMM005_UYSTOKNAKLI_09 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_09();

                // Set Parameters
                prms.I_MODE = "X";
                prms.I_OPERATION = "L";
                prms.I_FISNO = tbFisNo.Text;
                prms.I_LGPBE = tbAdres.Text;
                prms.I_YUKEMRNO = tbYuklemeEmri.Text;
                prms.I_ITEM = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS();
                prms.T_ITEMS = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS[0];
                prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];

                // Call Service
                Result02 = p_SAP.ZMM005_UYSTOKNAKLI_09(prms);

                // Create Table
                DataTable p_Table = alfaGrid.ToDataTable(Result02.T_ITEMS, "T_ITEMS");

                // Create Style
                alfaGrid.CreateTableStyle(grdIndirilmisMalzemeler, p_Table, "DEFAULT");

                // Assign to Grid
                grdIndirilmisMalzemeler.DataSource = p_Table;

                // Check Data
                if (Result02.T_ITEMS.Length > 0)
                {
                    // Select Row
                    grdIndirilmisMalzemeler.Select(grdIndirilmisMalzemeler.CurrentRowIndex);

                    // RecordCount
                    lbRecordCount02.Text = "Adet = " + Result02.T_ITEMS.Length.ToString();
                }
                else
                {
                    // RecordCount
                    lbRecordCount02.Text = "Adet = 0";
                }

                // Show Error
                if (Result02.E_SUBRC == "4") alfaMsg.Error(Result02.T_MESSAGES[0].MESSAGE);

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

        private void tbBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnList
            if (tbBarkod.Text.Length > 0 ) alfaCtrl.EnableControl (btnDown, Color.Blue);
                                      else alfaCtrl.DisableControl(btnDown, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnDown.Enabled == true) btnDown_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void tbALL_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnList
            if (tbFisNo.Text.Length == 11 && tbYuklemeEmri.Text.Length == 11 ) 
                 alfaCtrl.EnableControl (btnList, Color.Blue);
            else alfaCtrl.DisableControl(btnList, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnList.Enabled == true) btnList_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnDown_Click(object sender, EventArgs e)
        {
            // Get Barkod Line
            WR.ZMM_S_TARTIMDET_ITEMS p_BarkodLine = this.Find_Barkod_Line(tbBarkod.Text);

            // Check Barkod
            if (p_BarkodLine == null)
            {
                alfaMsg.Error("Yanlış Barkod Girdiniz !"); return;
            }

            // Create Service
            alfaSAP p_SAP = new alfaSAP();
            
            // Parameters
            WR.ZMM005_UYSTOKNAKLI_09 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_09();

            // Set Parameters
            prms.I_MODE = m_SPACE;
            prms.I_OPERATION = "M";
            prms.I_ITEM = p_BarkodLine;
            prms.I_FISNO = tbFisNo.Text;
            prms.I_LGPBE = tbAdres.Text;
            prms.I_YUKEMRNO = tbYuklemeEmri.Text;
            prms.T_ITEMS = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS[0];
            prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];
            
            // Call Service
            WR.ZMM005_UYSTOKNAKLI_09Response resp = p_SAP.ZMM005_UYSTOKNAKLI_09(prms);

            // Show Result
            if (resp.E_SUBRC == "4") alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE);
            else
            {   
                // Clear
                tbBarkod.Text = string.Empty;
                
                // Get List
                this.Get_Indirilecek_Malzemeler();
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private WR.ZMM_S_TARTIMDET_ITEMS Find_Barkod_Line(string p_Barkod)
        {
            // Get Table
            WR.ZMM_S_TARTIMDET_ITEMS[] dtTable = Result01.T_ITEMS;

            for (int li = 0; li < dtTable.Length; li++)
            {
                // Return Barkod Index
                if (dtTable[li].BARKOD == p_Barkod) return dtTable[li];
            }

            // Check Empty
            if (string.IsNullOrEmpty(tbYuklemeEmri.Text)) return null;

            // Check for SEFER
            else if (tbYuklemeEmri.Text[0] == '0')
            {
                // Create Line
                WR.ZMM_S_TARTIMDET_ITEMS p_Line = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS();

                // Set Barkod
                p_Line.BARKOD = p_Barkod;

                // Return
                return p_Line;
            }

            // Null
            else return null;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZMM005_UYSTOKNAKLI_09 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_09();

                // Set Params
                prms.I_MODE = m_SPACE;
                prms.I_OPERATION = "D";
                prms.I_FISNO = tbFisNo.Text;
                prms.I_LGPBE = tbAdres.Text;
                prms.I_YUKEMRNO = tbYuklemeEmri.Text;
                prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];
                prms.T_ITEMS = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS[0];

                // Create Line
                WR.ZMM_S_TARTIMDET_ITEMS line = new Terminal2012.WR.ZMM_S_TARTIMDET_ITEMS();

                // Get Table
                DataTable p_Table = (DataTable)grdIndirilmisMalzemeler.DataSource;

                // Get Row
                DataRow row = p_Table.Rows[grdIndirilmisMalzemeler.CurrentRowIndex];

                // Assign Line
                line.BARKOD = row["BARKOD"].ToString();
                line.KG = decimal.Parse(row["KG"].ToString());
                line.MIKTAR = decimal.Parse(row["MIKTAR"].ToString());
                line.OB = row["OB"].ToString();
                line.PARTI = row["PARTI"].ToString();
                line.SIP_KLM = row["SIP_KLM"].ToString();
                line.SIP_NO = row["SIP_NO"].ToString();
                line.STOK_NO = row["STOK_NO"].ToString();
                line.TANIM = row["TANIM"].ToString();

                // Set Line
                prms.I_ITEM = line;
                prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];

                // Call Service
                WR.ZMM005_UYSTOKNAKLI_09Response resp = p_SAP.ZMM005_UYSTOKNAKLI_09(prms);

                // Show Error
                if (resp.E_SUBRC == "4") alfaMsg.Error(Result01.T_MESSAGES[0].MESSAGE);

                // Referesh Data
                this.Get_Indirilecek_Malzemeler();
                this.Get_Indirilmis_Malzemeler();

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