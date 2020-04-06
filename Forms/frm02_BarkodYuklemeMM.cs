using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Terminal2012
{
    public partial class frm02_BarkodYuklemeMM : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        #region [---- Member Fields ----]

        // SelectedItem
        int m_SelectedItem = 0;

        // System 
        AlfaSys m_System = null;

        // Function01 Result
        WR.ZMM005_UYSTOKNAKLI_01Response FN01Result = null;

        #endregion

        //-----------------------------------------------------------------------------------------------------------//

        public frm02_BarkodYuklemeMM(AlfaSys p_System)
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
            if (txtFisNo.Text == string.Empty)
            {
                // Check Input
                alfaMsg.Error("Eksik Bilgi Girdiniz !"); return;
            }

            // Get List
            if ( this.Check_FisKayitDurumu() == true ) this.Get_EmirList(0);
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

        private void Get_EmirList( int p_RowIndex)
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Functions
                alfaSAP p_SAP = new alfaSAP();

                // Parameters
                WR.ZMM005_UYSTOKNAKLI_01 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_01();
                prms.IV_FISNO = txtFisNo.Text;
                prms.T_FISITEMS_EMIR = new Terminal2012.WR.ZMM_S_FISITEMS_EMIR_T[0];

                // Call Service
                FN01Result = p_SAP.ZMM005_UYSTOKNAKLI_01(prms);

                // Create Table
                DataTable p_Table = alfaGrid.ToDataTable(FN01Result.T_FISITEMS_EMIR, "T_FISITEMS_EMIR");

                // Create Style
                alfaGrid.CreateTableStyle(grdEmirList, p_Table, "TEORIK2");

                // Assign to Grid
                grdEmirList.DataSource = p_Table;

                // Set First Column Width
                grdEmirList.TableStyles[0].GridColumnStyles[0].Width = 125;

                // Check Data
                if (FN01Result.T_FISITEMS_EMIR.Length > 0)
                {
                    // Select Record
                    this.m_SelectedItem = p_RowIndex;
                    grdEmirList.Select(p_RowIndex);
                    grdEmirList.CurrentRowIndex = p_RowIndex;
                    
                    // RecordCount
                    lbRecordCount01.Text = "Adet = " + FN01Result.T_FISITEMS_EMIR.Length.ToString();

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
            alfaCtrl.DisableControl(btnPrev, Color.Silver);
            alfaCtrl.DisableControl(btnNext, Color.Silver);
            alfaCtrl.DisableControl(btnList, Color.Silver);
            alfaCtrl.DisableControl(btnMalzemeAdres, Color.Silver);

            // Clear Count
            lbRecordCount01.Text = string.Empty;

            // Reset Grid
            grdEmirList.DataSource = null;
            
            // Reset TextBox
            txtFisNo.Text = string.Empty;

            // Clear Selected
            m_SelectedItem = -1;

            // Focus
            txtFisNo.Focus();
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
                alfaCtrl.EnableControl(btnPrev, Color.Green);
                alfaCtrl.DisableControl(btnNext, Color.Silver);

                // Fill Data
                Fill_Selected_Data( "L", null ); // LIST

                // Cursor
                Cursor.Current = Cursors.Default;
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
            WR.ZMM_S_FISITEMS_EMIR_T[] dt = FN01Result.T_FISITEMS_EMIR;

            // Assign Values
            tbMalzeme.Text        = dt[m_SelectedItem].MLZTANIM;
            tbEmirMiktari.Text    = dt[m_SelectedItem].EMIRMIKTARI.ToString();
            tbOkutulanMiktar.Text = dt[m_SelectedItem].MIKTAR.ToString();
            tbBarkod.Text         = string.Empty;

            // Create Service
            alfaSAP p_SAP = new alfaSAP();

            // Structure
            WR.ZMM_S_FISITEMS_EMIR p_line = new Terminal2012.WR.ZMM_S_FISITEMS_EMIR();
            p_line.BARKOD = p_Barkod;
            p_line.EBELN = dt[m_SelectedItem].SASNO;
            p_line.EBELP = dt[m_SelectedItem].SASKALEM;
            p_line.FISNO = dt[m_SelectedItem].FISNO;
            p_line.MEINS = dt[m_SelectedItem].OB;
            p_line.TANIM = dt[m_SelectedItem].MLZTANIM;
            p_line.ZZEMIRMIKTAR = dt[m_SelectedItem].EMIRMIKTARI;
            p_line.MENGE = dt[m_SelectedItem].MIKTAR;
            p_line.MATNR = dt[m_SelectedItem].MALZEMENO;
            p_line.TEORIK1 = dt[m_SelectedItem].TEORIK1;
            p_line.TEORIK2 = dt[m_SelectedItem].TEORIK2;
            p_line.VBELN = dt[m_SelectedItem].SATISBEL;
            p_line.POSNR = dt[m_SelectedItem].SATISKALEM;
            p_line.ZZIRSALIYENO = dt[m_SelectedItem].IRSALIYENO;
            p_line.FISNO = dt[m_SelectedItem].FISNO;
            p_line.ZZKAYITZAMANI = dt[m_SelectedItem].KAYITZAMANI;

            // Parameters
            WR.ZMM005_UYSTOKNAKLI_03 prms = new Terminal2012.WR.ZMM005_UYSTOKNAKLI_03();
            prms.T_MESSAGES  = new Terminal2012.WR.ZMM_S_WSMESSAGES[0];
            prms.T_TABLE     = new Terminal2012.WR.ZMM_S_UY03[0];
            prms.I_UNAME     = this.m_System.UserId;
            prms.I_OPERATION = p_Operation;
            prms.I_FISITEMS  = p_line;

            // Call Service
            WR.ZMM005_UYSTOKNAKLI_03Response resp = p_SAP.ZMM005_UYSTOKNAKLI_03(prms);

            // Result
            grdBarkod.DataSource = resp.T_TABLE;

            if (resp.T_TABLE.Length > 0)
            {
                // Set Controls
                alfaCtrl.EnableControl(btnDel, Color.Blue);

                // Select Row
                grdBarkod.Select(grdBarkod.CurrentRowIndex);

                // RecordCount
                lbRecordCount02.Text = "Adet = " + resp.T_TABLE.Length.ToString();

                // Focus
                tbBarkod.Focus();
            }
            else
            {
                // Set Controls
                alfaCtrl.DisableControl(btnDel, Color.Silver);

                // RecordCount
                lbRecordCount02.Text = "Adet = 0";
            }

            // Show Error
            if (resp.E_SUBRC == "4") alfaMsg.Error(resp.T_MESSAGES[0].MESSAGE);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check Input
            if (tbBarkod.Text == string.Empty) return;

            try
            {
                // Modify Barkod
                Fill_Selected_Data("M", tbBarkod.Text);

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
            WR.ZMM_S_UY03[] dt = (WR.ZMM_S_UY03[])grdBarkod.DataSource;

            // Check Table
            if (dt.Length == 0) return;

            try
            {
                // Get Barkod
                string p_Barkod = dt[grdBarkod.CurrentRowIndex].BARKOD;

                // Delete Barkod
                this.Fill_Selected_Data("D", p_Barkod);

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

        private void Get_Okutulan_Miktar()
        {
            // EmirList
            Get_EmirList(m_SelectedItem);

            // Get Table01
            WR.ZMM_S_FISITEMS_EMIR_T[] dt = FN01Result.T_FISITEMS_EMIR;

            // Get Miktar
            tbOkutulanMiktar.Text = dt[m_SelectedItem].MIKTAR.ToString();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClose_Click(object sender, EventArgs e)
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
            WR.ZMM_S_FISITEMS_EMIR_T[] dt = FN01Result.T_FISITEMS_EMIR;

            // Assign Values
            string p_MalzemeNo = dt[m_SelectedItem].MALZEMENO;
            string p_Vbeln = dt[m_SelectedItem].SATISBEL;
            string p_Posnr = dt[m_SelectedItem].SATISKALEM;
            string p_Barkod = dt[m_SelectedItem].BARKODNO;

            // Create Form
            frm00_MalzemeAdres frm = new frm00_MalzemeAdres(this.m_System, p_MalzemeNo, p_Vbeln, p_Posnr, p_Barkod);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show Form
            frm.ShowDialog();
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
    }
}