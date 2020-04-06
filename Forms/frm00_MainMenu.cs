using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Terminal2012
{
    public partial class frm00_MainMenu : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        #region [---- Member Fields ----]

        // Set Session Info
        AlfaSys m_System = new AlfaSys();

        #endregion

        //-----------------------------------------------------------------------------------------------------------//

        public frm00_MainMenu()
        {
            // Initialize
            InitializeComponent();

            // SAP Links
            this.Set_SAP_Links();

            // Enabled Prod
            rbSAP100_PROD.Enabled = true;

            // Disable Tests
            rbSAP200_TEST.Enabled = false;
            rbSAP100_QA.Enabled = false;

            // Set Default
            rbSAP100_PROD.Checked = true;

            // Set Default
            this.radioButtonAll_Click(null, null);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Set_SAP_Links()
        {
            // SAP100 / PROD
            rbSAP100_PROD.Tag = "http://ycbrprd.yucelborugrup.local:8000/sap/bc/srt/rfc/sap/zmm_ws_terminal_functions/100/service_terminal_functions/binding_terminal_functions";

            // SAP200 / TEST
            rbSAP200_TEST.Tag = "http://ycbrdev01.yucelborugrup.local:8000/sap/bc/srt/rfc/sap/zmm_ws_terminal_functions/200/service_terminal_functions/binding_terminal_functions";

            // SAP100 / QA
            rbSAP100_QA.Tag = "http://ycbrqa01.yucelborugrup.local:8000/sap/bc/srt/rfc/sap/zmm_ws_terminal_functions/100/service_terminal_functions/binding_terminal_functions";
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void radioButtonAll_Click(object sender, EventArgs e)
        {
            if (rbSAP100_PROD.Checked)
            {
                // SAP Client 100 / PROD
                alfaSAP.Target = rbSAP100_PROD.Tag.ToString();

                // Set MainMenu
                lbMainMenu.Text = rbSAP100_PROD.Text;
            }

            else if (rbSAP200_TEST.Checked)
            {
                // SAP Client 200 / TEST
                alfaSAP.Target = rbSAP200_TEST.Tag.ToString();

                // Set MainMenu
                lbMainMenu.Text = rbSAP200_TEST.Text;
            }

            else if (rbSAP100_QA.Checked)
            {
                // SAP Client 300 // TEST
                alfaSAP.Target = rbSAP100_QA.Tag.ToString();

                // Set MainMenu
                lbMainMenu.Text = rbSAP100_QA.Text;
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            // Close
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            // Get Version
            lbVersion.Text = "v" + alfaVer.GetAppVersion();

            // Login
            pnLogin.BringToFront();

            // Clear
            this.btnClear_Click(null, null);

            // Focus
            txtUser.Focus();
            txtUser.Select(0, 0);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnRuloGirisMM_Click(object sender, EventArgs e)
        {
            // Create Form
            frm01_RuloGirisMM frm = new frm01_RuloGirisMM();

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnBarkodYuklemeMM_Click(object sender, EventArgs e)
        {
            // Create Form
            frm02_BarkodYuklemeMM frm = new frm02_BarkodYuklemeMM(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnBarkodIndirmeMM_Click(object sender, EventArgs e)
        {
            // Create Form
            frm03_BarkodIndirmeMM frm = new frm03_BarkodIndirmeMM(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnBarkodAdresMM_Click(object sender, EventArgs e)
        {
            // Create Form
            frm04_BarkodAdresMM frm = new frm04_BarkodAdresMM(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnFason01MM_Click(object sender, EventArgs e)
        {
            // Create Form
            frm05_FasonGrupIciMM frm = new frm05_FasonGrupIciMM();

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnEmirsizYuklemeMM_Click(object sender, EventArgs e)
        {
            // Create Form
            frm06_EmirsizYuklemeMM frm = new frm06_EmirsizYuklemeMM(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // WaitCursor
                alfaMsg.WaitCursor();

                // Focus
                btnLogin.Focus();

                // UserName
                alfaSAP.User = txtUser.Text;

                // Password
                alfaSAP.Pass = txtPass.Text;

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Login
                if (this.Login_Operation_v2(p_SAP) == false) return;

                // Main Menu
                this.Activate_Menu(pnMenuMain);

                // Set UserName
                this.m_System.UserId = txtUser.Text;

                // Set Werks
                this.m_System.Werks = this.m_System.GetWerks();

                // Terminal Ops
                this.Terminal_Operation(p_SAP);

                // DefaultCursor
                alfaMsg.DefaultCursor();
            }
            catch(Exception ex)
            {
                // Error Message
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Activate_Menu(Panel p_Menu)
        {
            // Hide All Menus
            pnLogin.Visible = false;
            pnMenuMain.Visible = false;
            pnMenuMM.Visible = false;
            pnMenuSD.Visible = false;

            // Show Menu
            p_Menu.Visible = true;

        }

        //-----------------------------------------------------------------------------------------------------------//

        private Boolean Login_Operation_v1(alfaSAP p_SAP)
        {
            // Parameters
            WR.ZMM005_TERMINAL_GIRIS prmLogin = new Terminal2012.WR.ZMM005_TERMINAL_GIRIS();
            prmLogin.I_USERNAME = txtUser.Text;
            prmLogin.I_PASSWORD = txtPass.Text;

            // Call Service
            WR.ZMM005_TERMINAL_GIRISResponse respLogin = p_SAP.ZMM005_TERMINAL_GIRIS(prmLogin);

            // Check Result
            if (respLogin.E_RESULT != "OK")
            {
                // Error Message
                alfaMsg.Error(respLogin.E_RESULT); return false;
            }
            else return true;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private Boolean Login_Operation_v2(alfaSAP p_SAP)
        { 
            // Parameters
            WR.ZMM005_TERMINAL_GIRIS prmLogin = new Terminal2012.WR.ZMM005_TERMINAL_GIRIS();
            prmLogin.I_USERNAME = txtUser.Text;
            prmLogin.I_PASSWORD = txtPass.Text;

            // Call Service
            WR.ZMM005_TERMINAL_GIRISResponse respLogin = p_SAP.ZMM005_TERMINAL_GIRIS(prmLogin);

            // Check Result
            if (respLogin.E_RESULT != "OK")
            {
                // Error Message
                alfaMsg.Error(respLogin.E_RESULT); return false;
            }
            else return true;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Terminal_Operation(alfaSAP p_SAP)
        {
            // Terminal
            WR.ZMM_T_TERMINAL ls_terminal = new Terminal2012.WR.ZMM_T_TERMINAL();

            // Assign Values
            ls_terminal.TRM_NAME    = this.m_System.Name;
            ls_terminal.TRM_ACTIVE  = this.m_System.Active;
            ls_terminal.TRM_LOCIP   = this.m_System.LocIP;
            ls_terminal.TRM_OSVER   = this.m_System.OsVer;
            ls_terminal.TRM_APPNAME = this.m_System.AppName;
            ls_terminal.TRM_NETVER  = this.m_System.NetVer;
            ls_terminal.TRM_APPVER  = this.m_System.AppVer;
            ls_terminal.LOGIN_USER  = this.m_System.UserId;
            ls_terminal.LOGIN_DATE  = this.m_System.Date;
            ls_terminal.LOGIN_TIME  = this.m_System.Time;

            // Parameters
            WR.ZMM005_TERMINAL_BAKIM prmTerminal = new Terminal2012.WR.ZMM005_TERMINAL_BAKIM();
            prmTerminal.P_TERMINAL    = ls_terminal;
            prmTerminal.P_REQDOWNLOAD = "N";

            // Call Service
            WR.ZMM005_TERMINAL_BAKIMResponse resp = p_SAP.ZMM005_TERMINAL_BAKIM(prmTerminal);

            // Message
            if (resp.P_MESSAGE!=string.Empty) alfaMsg.Error(resp.P_MESSAGE);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnMenuMM_Click(object sender, EventArgs e)
        {
            // MM Menu
            pnMenuMM.BringToFront();
            this.Activate_Menu(pnMenuMM);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnMenuSD_Click(object sender, EventArgs e)
        {
            // SD Menu
            pnMenuSD.BringToFront();
            this.Activate_Menu(pnMenuSD);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnCloseMM_Click(object sender, EventArgs e)
        {
            // Return MainMenu
            this.Activate_Menu(pnMenuMain);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnCloseSD_Click(object sender, EventArgs e)
        {
            // Return MainMenu
            this.Activate_Menu(pnMenuMain);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnCloseMain_Click(object sender, EventArgs e)
        {
            // Clear
            this.btnClear_Click(null, null);

            // Set UserName
            txtUser.Text = m_System.UserId;

            // Return Login
            this.Activate_Menu(pnLogin);

            // Focus
            txtPass.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Disable btnLogin
            alfaCtrl.DisableControl(btnLogin, Color.Silver);

            // Clear Inputs
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;

            // Hide Menus
            pnMenuMain.Visible = false;
            pnMenuMM.Visible = false;
            pnMenuSD.Visible = false;

            // Reload Settings
            this.radioButtonAll_Click(null, null);

            // Focus
            txtUser.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtALL_KeyUp(object sender, KeyEventArgs e)
        {
            if ((txtUser.Text != string.Empty) && (txtPass.Text != string.Empty))
            {
                alfaCtrl.EnableControl(btnLogin, Color.Green);
            }
            else
            {
                alfaCtrl.DisableControl(btnLogin, Color.Silver);
            }

            // Enter Press
            if (e.KeyCode == Keys.Enter && btnLogin.Enabled == true)
            {
                this.btnLogin_Click(null, null);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnBarkodYuklemeSD_Click(object sender, EventArgs e)
        {
            // Create Form
            frm11_BarkodYuklemeSD frm = new frm11_BarkodYuklemeSD(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnBarkodTestSD_Click(object sender, EventArgs e)
        {
            // Create Form
            frm12_BarkodTestSD frm = new frm12_BarkodTestSD(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnBarkodSayimSD_Click(object sender, EventArgs e)
        {
            // Create Form
            frm14_BarkodSayimSD frm = new frm14_BarkodSayimSD(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnBarkoKontrolSD_Click(object sender, EventArgs e)
        {
            // Create Form
            frm13_BarkodKontrolSD frm = new frm13_BarkodKontrolSD(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm00_MainMenu_KeyUp(object sender, KeyEventArgs e)
        {
            if (pnMenuMM.Visible == true)
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) this.btnRuloGirisMM_Click(null, null);
                if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2) this.btnBarkodYuklemeMM_Click(null, null);
                if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3) this.btnBarkodIndirmeMM_Click(null, null);
                if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4) this.btnBarkodAdresMM_Click(null, null);
                if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5) this.btnFason01MM_Click(null, null);
                if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6) this.btnEmirsizYuklemeMM_Click(null, null);
            }

            else if (pnMenuSD.Visible == true)
            {
                if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1) btnBarkodYuklemeSD_Click(null, null);
                if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad1) btnGemiYuklemeSD_Click(null, null);
                if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad2) btnBarkoKontrolSD_Click(null, null);
                if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad3) btnBarkodTestSD_Click(null, null);
                if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad4) btnBarkodSayimSD_Click(null, null);
            }

            else if (pnLogin.Visible == true)
            {
                if (e.Control && e.KeyCode == Keys.T)    
                {
                    // Enable Test/QA Client
                    rbSAP200_TEST.Enabled = true;
                    rbSAP100_QA.Enabled = true;

                    // Select Test Client
                    rbSAP200_TEST.Checked = true;

                    // Click RadioButton
                    this.radioButtonAll_Click(null, null);
                }
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Force UpperCase
            if (char.IsLower(e.KeyChar))
            {
                // Get Position
                int pos = txtUser.SelectionStart;

                // Inseert Upper Key
                txtUser.Text = txtUser.Text.Insert(pos, char.ToUpper(e.KeyChar).ToString());

                // Set Position
                txtUser.SelectionStart = pos + 1;

                // Handled
                e.Handled = true;
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnGemiYuklemeSD_Click(object sender, EventArgs e)
        {
            // Create Form
            frm15_GemiYuklemeSD frm = new frm15_GemiYuklemeSD(this.m_System);

            // Set WindowsState
            alfaTerm.SetWindowsState(frm);

            // Show
            frm.Show();
        }

        //-----------------------------------------------------------------------------------------------------------//
    }

}