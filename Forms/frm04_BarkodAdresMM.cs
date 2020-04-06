using System;
using System.Drawing;
using System.Windows.Forms;


namespace Terminal2012
{
    public partial class frm04_BarkodAdresMM : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        // System 
        AlfaSys m_System = null;

        //-----------------------------------------------------------------------------------------------------------//

        public frm04_BarkodAdresMM(AlfaSys p_System)
        {
            // Initialize
            InitializeComponent();

            // Set System
            this.m_System = p_System;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm04_BarkodAdresMM_Load(object sender, EventArgs e)
        {
            // Page01 
            PageActivate(pnPage01);

            // Clear
            this.btnClear_Click(null, null);

            // Depo List
            this.Get_Depo_List();
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
                prms.I_WERKS = this.m_System.Werks;

                // Call Function
                WR.ZMM007_DEPO_YERIResponse resp = p_SAP.ZMM007_DEPO_YERI(prms);

                // Clear Items
                cbDepo.Items.Clear();

                // Add Items
                foreach (WR.ZMM_S_LGORT row in resp.TB_DEPO)
                {
                    cbDepo.Items.Add(new alfaDepo(row.LGORT, row.LGOBE));
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

        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                Cursor.Current = Cursors.WaitCursor;

                // Create Service
                alfaSAP p_SAP = new alfaSAP();
                
                // Create Params
                WR.ZMM005_MALZEMELOKASYON_01 prms = new Terminal2012.WR.ZMM005_MALZEMELOKASYON_01();

                // Clear Barkod Text
                tbBarkod.Text = string.Empty;

                // Assign Params
                prms.I_BARKOD = lbBarkodSave.Text;
                prms.I_UNAME = this.m_System.UserId;
                prms.T_MALZEMELOKASYON = new Terminal2012.WR.ZMM_S_MALZEMELOKASYON[0]; // Table

                // Call Service
                WR.ZMM005_MALZEMELOKASYON_01Response resp = p_SAP.ZMM005_MALZEMELOKASYON_01(prms);

                // Create Table
                System.Data.DataTable p_Table = alfaGrid.ToDataTable(resp.T_MALZEMELOKASYON, "T_MALZEMELOKASYON");

                // Create Style
                alfaGrid.CreateTableStyle(grdList, p_Table, "DEFAULT");

                // Assign to Grid
                grdList.DataSource = p_Table;

                // Check Data
                if (resp.T_MALZEMELOKASYON.Length > 0)
                {
                    // Select Row
                    grdList.Select(grdList.CurrentRowIndex);

                    // Set Malzeme Text
                    txtMalzeme.Text = resp.T_MALZEMELOKASYON[0].MLZTANIM;

                    // RecordCount
                    lbRecordCount01.Text = "Adet = " + resp.T_MALZEMELOKASYON.Length.ToString();
                }
                else
                {
                    // RecordCount
                    lbRecordCount01.Text = "Adet = 0";
                }

                // Show Error
                if (resp.E_SUBRC == "4") alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE);

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
            // Reset Grid
            grdList.DataSource = null;
            
            // Reset TextBox
            tbAdres.Text = string.Empty;
            tbBarkod.Text = string.Empty;
            txtMalzeme.Text = string.Empty;
            lbBarkodSave.Text = string.Empty;

            // Focus
            tbAdres.Focus();

            // Clear Depo
            cbDepo.SelectedIndex = -1;

            // Clear Count
            lbRecordCount01.Text = string.Empty;

            // Disable Buttons
            alfaCtrl.DisableControl(btnList, Color.Silver);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);
            alfaCtrl.DisableControl(btnSave, Color.Silver);
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
            PageActivate(pnPage01);
            alfaCtrl.EnableControl (btnNext, Color.Green);
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                Cursor.Current = Cursors.WaitCursor;
                
                // Set Controls
                PageActivate(pnPage02);
                alfaCtrl.EnableControl (btnPrev, Color.Green);
                alfaCtrl.DisableControl(btnNext, Color.Silver);

                // Get Data
                Fill_Selected_Data( "L", null ); // LIST

                // Cursor
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Fill_Selected_Data( string p_Operation, string p_Barkod )
        {
            //********
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Cursor
                Cursor.Current = Cursors.WaitCursor;

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Create Params
                WR.ZMM005_MALZEMELOKASYON_02 prms = new Terminal2012.WR.ZMM005_MALZEMELOKASYON_02();

                // Assign Params
                prms.I_WERKS = this.m_System.Werks;
                prms.I_BARKOD = lbBarkodSave.Text;
                prms.I_LGPBE = tbAdres.Text;
                prms.T_MESSAGES = new Terminal2012.WR.ZMM_S_WSMESSAGES[0]; // Table

                // Assign Depo
                if (cbDepo.SelectedIndex >= 0) prms.I_LGORT = (cbDepo.SelectedItem as alfaDepo).DepoNo;
                                          else prms.I_LGORT = string.Empty;

                // Call Service
                WR.ZMM005_MALZEMELOKASYON_02Response resp = p_SAP.ZMM005_MALZEMELOKASYON_02(prms);

                // Check Result
                if (resp.E_SUBRC == "4")
                {
                    // Message
                    alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE);
                }
                else
                {
                    // Clear Barkod
                    tbBarkod.Text = string.Empty;

                    // Focus
                    tbBarkod.Focus();
                }

            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void tbALL_KeyUp(object sender, KeyEventArgs e)
        {
            // Save Barkod
            lbBarkodSave.Text = tbBarkod.Text;
            
            // BtnList
            if ( tbBarkod.Text.Length > 0 ) alfaCtrl.EnableControl (btnList, Color.Blue);
                                       else alfaCtrl.DisableControl(btnList, Color.Silver);

            // BtnSave
            if ( tbAdres.Text.Length > 0 && tbBarkod.Text.Length > 0 )
                 alfaCtrl.EnableControl (btnSave, Color.Blue);
            else alfaCtrl.DisableControl(btnSave, Color.Silver);

            // BtnSave
            if (e.KeyCode == Keys.Enter && btnSave.Enabled == true) this.btnSave_Click(null, null);

            // BtnList
            if (e.KeyCode == Keys.Enter && btnList.Enabled == true) this.btnList_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void tbAdres_TextChanged(object sender, EventArgs e)
        {
            // Force for UpperCase
            tbAdres.Text = tbAdres.Text.ToUpper();
            tbAdres.Select(tbAdres.Text.Length, 0);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void cbDepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Focus
            this.tbAdres.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//
    }
}