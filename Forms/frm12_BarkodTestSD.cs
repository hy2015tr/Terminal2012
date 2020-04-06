using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Collections.Generic;



namespace Terminal2012
{
    public partial class frm12_BarkodTestSD : Form
    {

        //-----------------------------------------------------------------------------------------------------------//

        // System 
        AlfaSys m_System = null;

        // DataTable
        DataTable m_Table = new DataTable("BARKOD_LIST");

        //-----------------------------------------------------------------------------------------------------------//

        public frm12_BarkodTestSD(AlfaSys p_System)
        {
            // Initialize
            InitializeComponent();

            // Set System
            this.m_System = p_System;

            // Create Table
            this.Create_Table();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm12_BarkodTestSD_Load(object sender, EventArgs e)
        {
            // Clear
            this.btnClear_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private  void Create_Table()
        {
            // Create Columns
            DataColumn colNo = new DataColumn("NO");
            DataColumn colBarkod = new DataColumn("BARKOD");
            DataColumn colDurum = new DataColumn("DURUM");

            // Add Columns
            m_Table.Columns.Add(colNo);
            m_Table.Columns.Add(colBarkod);
            m_Table.Columns.Add(colDurum);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (grdList.DataSource != null)
            {
                // Check Confirmation
                if (alfaMsg.Quest("Listeyi silmek icin emin misiniz ?") == DialogResult.No) return;
            }
            // Disable Buttons
            alfaCtrl.DisableControl(btnAdd, Color.Silver);
            alfaCtrl.DisableControl(btnClear, Color.Silver);

            // Clear Barkod
            txtBarkod.Text = string.Empty;

            // Reset Grid
            grdList.DataSource = null;

            // Clear Table
            m_Table.Rows.Clear();
            
            // Focus
            txtBarkod.Focus();
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
                WR.ZMM005_MALZEMELOKASYON_01 prms = new Terminal2012.WR.ZMM005_MALZEMELOKASYON_01();

                // Assign Params
                prms.I_BARKOD = txtBarkod.Text;
                prms.I_UNAME = this.m_System.UserId;
                prms.T_MALZEMELOKASYON = new Terminal2012.WR.ZMM_S_MALZEMELOKASYON[0]; // Table

                // Call Service
                WR.ZMM005_MALZEMELOKASYON_01Response resp = p_SAP.ZMM005_MALZEMELOKASYON_01(prms);

                // Create Table
                System.Data.DataTable p_ResultTable = alfaGrid.ToDataTable(resp.T_MALZEMELOKASYON, "T_MALZEMELOKASYON");

                // Status
                string p_Status = null;

                // Set Status
                if (p_ResultTable.Rows.Count > 0) p_Status = "TAMAM"; else p_Status = "HATA";

                // Create Row
                DataRow row = m_Table.NewRow();

                row["NO"] =  string.Format( "{0:000}", m_Table.Rows.Count + 1 );
                row["BARKOD"] = txtBarkod.Text;
                row["DURUM"] = p_Status;

                // Add Row
                m_Table.Rows.Add(row);

                // Create Style
                alfaGrid.CreateTableStyle(grdList, m_Table, "DURUM");

                // Assign to Grid
                grdList.DataSource = m_Table;

                // Select Last Item
                grdList.CurrentRowIndex = m_Table.Rows.Count - 1;
                grdList.Select(m_Table.Rows.Count - 1);
                grdList.Refresh();

                // Clear Barkod
                txtBarkod.Text = string.Empty;

                // Disable BtnAdd
                alfaCtrl.DisableControl(btnAdd, Color.Silver);

                // Enable BtnClear
                alfaCtrl.EnableControl(btnClear, Color.Blue);

                // Show Error
                if (resp.E_SUBRC == "4") alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE);

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
            // Close
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtBarkod_KeyUp(object sender, KeyEventArgs e)
        {
            // BtnEkle
            if (txtBarkod.Text.Length > 0) alfaCtrl.EnableControl (btnAdd, Color.Blue);
                                      else alfaCtrl.DisableControl(btnAdd, Color.Silver);

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnAdd.Enabled == true) btnAdd_Click(null, null);
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

    }
}