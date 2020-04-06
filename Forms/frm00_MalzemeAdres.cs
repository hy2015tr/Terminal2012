using System;
using System.Drawing;
using System.Windows.Forms;


namespace Terminal2012
{
    public partial class frm00_MalzemeAdres : Form
    {
        //-----------------------------------------------------------------------------------------------------------//

        // System 
        AlfaSys m_System = null;

        //-----------------------------------------------------------------------------------------------------------//

        public frm00_MalzemeAdres( AlfaSys p_System, string p_Malzeme, string p_Vbeln, string p_Posnr, string p_Barkod )
        {
            // Initialize
            InitializeComponent();

            // Assign Value
            tbMlzNo.Text = p_Malzeme;
            tbVbeln.Text = p_Vbeln;
            tbPosnr.Text = p_Posnr;
            tbBarkod.Text = p_Barkod;

            // Assign System
            this.m_System = p_System;
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void frm00_MalzemeAdres_Load(object sender, EventArgs e)
        {
            //Get List
            this.Get_MalzemeAdres_List();

            // Focus
            tbMlzNo.Focus();
            tbMlzNo.Select(0, 0);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void Get_MalzemeAdres_List()
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Create Service
                alfaSAP p_SAP = new alfaSAP();

                // Parameters
                WR.ZMM005_MALZEMELOKASYON_01 prms = new Terminal2012.WR.ZMM005_MALZEMELOKASYON_01();
                
                prms.I_BARKOD = "";
                prms.I_MATNR = tbMlzNo.Text;
                prms.I_UNAME = this.m_System.UserId;
                prms.I_VBELN = tbVbeln.Text;
                prms.I_POSNR = tbPosnr.Text;

                prms.T_MALZEMELOKASYON = new Terminal2012.WR.ZMM_S_MALZEMELOKASYON[0];

                // Call Service
                WR.ZMM005_MALZEMELOKASYON_01Response resp = p_SAP.ZMM005_MALZEMELOKASYON_01(prms);

                // Grid
                grdList.DataSource = resp.T_MALZEMELOKASYON;

                // Check Data
                if (resp.T_MALZEMELOKASYON.Length > 0)
                {
                    // Malzeme Adi
                    tbMlzAdi.Text = resp.T_MALZEMELOKASYON[0].MLZTANIM;

                    // Select Row
                    grdList.Select(grdList.CurrentRowIndex);

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
                alfaMsg.DefaultCursor();
            }
            catch (Exception ex)
            {
                // Error
                alfaMsg.Error(ex.Message);
            }
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void grdList_CurrentCellChanged(object sender, EventArgs e)
        {
            // Select Full Row
            grdList.Select(grdList.CurrentRowIndex);
        }

        //-----------------------------------------------------------------------------------------------------------//

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------------------------------------------------------------------------------------------//
    }
}