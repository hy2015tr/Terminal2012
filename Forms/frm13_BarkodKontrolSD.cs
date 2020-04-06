using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;



namespace Terminal2012
{
    public partial class frm13_BarkodKontrolSD : Form
    {

        //-----------------------------------------------------------------------------------------------------------//

        AlfaSys m_System = null;

        //-----------------------------------------------------------------------------------------------------------//

        public frm13_BarkodKontrolSD(AlfaSys p_System)
        {
            // Initialize
            InitializeComponent();

            // Set System
            this.m_System = p_System;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm13_BarkodKontrolSD_Load(object sender, EventArgs e)
        {
            // Clear
            this.btnClear_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Log
            this.Save_Log();
            
            // Disable Controls
            alfaCtrl.DisableControl(btnBarkod, Color.Silver);
            alfaCtrl.DisableControl(txtBarkod, Color.Silver);
            alfaCtrl.DisableControl(btnClear, Color.Silver);

            // Enable Controls
            alfaCtrl.EnableControl(txtFisNo, Color.Black);

            // Clear Texts
            txtBarkod.Text = string.Empty;
            txtFisNo.Text = string.Empty;

            // Reset Grid
            grdList.DataSource = null;

            // Focus
            txtFisNo.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Save_Log()
        {
            // Get Table
            DataTable p_Table = (DataTable)grdList.DataSource;

            // Check for Empty
            if (p_Table == null || p_Table.Rows == null || p_Table.Rows.Count == 0) return;

            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZSD_F_BAR_KONTROL prms = new Terminal2012.WR.ZSD_F_BAR_KONTROL();

                // Create SapList
                List<WR.ZSD_S_BAR_LIST> sapList = new List<Terminal2012.WR.ZSD_S_BAR_LIST>();

                for (int li = 0; li < p_Table.Rows.Count; li++)
                {
                    // Create Line
                    WR.ZSD_S_BAR_LIST line = new Terminal2012.WR.ZSD_S_BAR_LIST();
                    line.BARKON = p_Table.Rows[li]["BARKON"].ToString();
                    line.BARYUK = p_Table.Rows[li]["BARYUK"].ToString();

                    // Add List
                    sapList.Add(line);
                }

                // Assign Params
                prms.I_OPERATION = "S";
                prms.I_FISNO = txtFisNo.Text;
                prms.ET_BAR_LIST = sapList.ToArray();

                // Call Service
                WR.ZSD_F_BAR_KONTROLResponse resp = p_SAP.ZSD_F_BAR_KONTROL(prms);

                // Error Message
                if (resp.E_SUBRC != "0") alfaMsg.Error(resp.E_HATA);

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

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Get DataTable
                DataTable p_Table = (DataTable)grdList.DataSource;

                Boolean IsFound = false;

                // Search for Barkod

                for (int li = 0; li < p_Table.Rows.Count; li++)
			    {
                    if ( p_Table.Rows[li]["BARYUK"].ToString() == txtBarkod.Text )
                    {
                        // Found
                        p_Table.Rows[li]["BARKON"] = p_Table.Rows[li]["BARYUK"];

                        // Select New Record
                        grdList.CurrentRowIndex = li;
                        grdList.Select(li);

                        // Flag
                        IsFound = true;

                        // Exit
                        continue;
                    }
                }

                if (!IsFound) // Not Found
                {
                    // Create Row
                    DataRow rowNew = p_Table.NewRow();

                    // Assign Row
                    rowNew["BARYUK"] = "X";
                    rowNew["BARKON"] = txtBarkod.Text;

                    // Add Row
                    p_Table.Rows.Add(rowNew);

                    // Select New Record
                    grdList.CurrentRowIndex = p_Table.Rows.Count-1;
                    grdList.Select(grdList.CurrentRowIndex);
                }

                // Clear Barkod
                txtBarkod.Text = string.Empty;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Log
            this.Save_Log();
            
            // Close
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtFisNo_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnEkle
            if (txtFisNo.Text.Length > 0)  alfaCtrl.EnableControl (btnFisNo, Color.Blue);
                                      else alfaCtrl.DisableControl(btnFisNo, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnFisNo.Enabled == true) btnFisNo_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnEkle
            if (txtBarkod.Text.Length > 0) alfaCtrl.EnableControl(btnBarkod, Color.Blue);
                                      else alfaCtrl.DisableControl(btnBarkod, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnBarkod.Enabled == true) btnBarkod_Click(null, null);

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

        private void btnFisNo_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZSD_F_BAR_KONTROL prms = new Terminal2012.WR.ZSD_F_BAR_KONTROL();

                // Assign Params
                prms.I_OPERATION = "L";
                prms.I_FISNO = txtFisNo.Text;
                prms.ET_BAR_LIST =  new Terminal2012.WR.ZSD_S_BAR_LIST[0]; // Table

                // Call Service
                WR.ZSD_F_BAR_KONTROLResponse resp = p_SAP.ZSD_F_BAR_KONTROL(prms);

                if (resp.E_SUBRC == "4")
                {
                    // Error
                    alfaMsg.Error(resp.E_HATA);

                    // Clear
                    txtBarkod.Text = string.Empty;
                        
                    // Return
                    return;
                }

                // Create Table
                System.Data.DataTable p_ResultTable = alfaGrid.ToDataTable(resp.ET_BAR_LIST, "ET_BAR_LIST");

                // Add Index Column
                p_ResultTable.Columns.Add(new DataColumn("NO"));

                for (int li = 0; li < p_ResultTable.Rows.Count; li++)
                {
                    // Assign Index Column
                    p_ResultTable.Rows[li]["NO"] = string.Format("{0:000}", li + 1);
                }

                // Create Style
                alfaGrid.CreateTableStyle(grdList, p_ResultTable, "BARKOD");
                
                // Assign to Grid
                grdList.DataSource = p_ResultTable;

                if (p_ResultTable.Rows.Count > 0)
                {
                    // Enable Controls
                    alfaCtrl.EnableControl(btnClear, Color.Blue);
                    alfaCtrl.EnableControl(txtBarkod, Color.Black);

                    // Disable Controls
                    alfaCtrl.DisableControl(btnFisNo, Color.Silver);
                    alfaCtrl.DisableControl(txtFisNo, Color.Silver);
                }
                else
                {
                    // Disable Controls
                    alfaCtrl.DisableControl(btnClear, Color.Silver);
                    alfaCtrl.DisableControl(btnBarkod, Color.Silver);
                    alfaCtrl.DisableControl(txtBarkod, Color.Silver);
                }

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