using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;



namespace Terminal2012
{

    #region //-----------alfaMsg-------------//

    public class alfaMsg
    {
        //---------------------------------------------------------------------------------//

        public static void WaitCursor()
        {
            // Wait Cursor
            Cursor.Current = Cursors.WaitCursor;
        }

        //---------------------------------------------------------------------------------//

        public static void DefaultCursor()
        {
            // Wait Cursor
            Cursor.Current = Cursors.Default;
        }

        //---------------------------------------------------------------------------------//

        public static DialogResult Quest(string strMessage)
        {
            // Cursor
            Cursor.Current = Cursors.Default;

            // Show Message
            return MessageBox.Show(strMessage, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        //---------------------------------------------------------------------------------//

        public static DialogResult Error(string strMessage)
        {
            // Cursor
            Cursor.Current = Cursors.Default;

            // Show Message
            return MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
        }

        //---------------------------------------------------------------------------------//

        public static DialogResult Info(string strMessage)
        {
            // Cursor
            Cursor.Current = Cursors.Default;

            // Show Message
            return MessageBox.Show(strMessage, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
        }

        //---------------------------------------------------------------------------------//
    }

    #endregion


    #region //-----------alfaDate------------//

    public class alfaDate
    {
        //---------------------------------------------------------------------------------//

        public static string GetDate(DateTime p_DateTime)
        {
            // Get Values
            string yrs = p_DateTime.Year.ToString("0000");
            string mon = p_DateTime.Month.ToString("00");
            string day = p_DateTime.Day.ToString("00");

            // Return
            return yrs + mon + day;
        }

        //---------------------------------------------------------------------------------//

        public static string GetTime(DateTime p_DateTime)
        {
            // Get Values
            string hrs = p_DateTime.Hour.ToString("00");
            string min = p_DateTime.Minute.ToString("00");
            string sec = p_DateTime.Second.ToString("00");

            // Return
            return hrs + min + sec;
        }

        //---------------------------------------------------------------------------------//

        public static int GetTotalSecs(DateTime p_DateTime)
        {
            // Get Values
            int sec_hrs = p_DateTime.Hour * 60 * 60;
            int sec_min = p_DateTime.Minute * 60;
            int sec_sec = p_DateTime.Second * 1;

            // Return
            return sec_hrs + sec_min + sec_sec;
        }

        //---------------------------------------------------------------------------------//

    }

    #endregion


    #region //-----------alfaVer-------------//

    public class alfaVer
    {
        //---------------------------------------------------------------------------------//

        public static string GetAppVersion()
        {
            // Get Versions
            int verMajor = Assembly.GetExecutingAssembly().GetName().Version.Major;
            int verMinor = Assembly.GetExecutingAssembly().GetName().Version.Minor;
            int verBuild = Assembly.GetExecutingAssembly().GetName().Version.Build;
            int verRevis = Assembly.GetExecutingAssembly().GetName().Version.Revision;

            // Return
            return verMajor + "." + verMinor + "." + verBuild;
        }

        //---------------------------------------------------------------------------------//
    }

    #endregion


    #region //-----------AlfaSys-------------//


    public class AlfaSys
    {
        //---------------------------------------------------------------------------------//
        
        public string Name;
        public string LocIP;
        public string Active;
        public string OsVer;
        public string AppName;
        public string AppVer;
        public string NetVer;
        public string UserId;
        public string Date;
        public string Time;
        public string Werks;
        public string Lgort;

        //---------------------------------------------------------------------------------//

        public AlfaSys()
        {
            // Get HostName
            this.Name = System.Net.Dns.GetHostName();

            // Get IP Adress List
            System.Net.IPAddress[] ListIP = System.Net.Dns.GetHostEntry(this.Name).AddressList;

            // Get Local IP
            foreach ( System.Net.IPAddress ip in ListIP)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork )
                {
                    this.LocIP = ip.ToString();
                }
            }

            // Get Operating System Version
            this.OsVer = System.Environment.OSVersion.ToString();

            // Get Status
            this.Active = "Y";

            // Get Application Name
            this.AppName = "TERMINAL2012";

            // Get Application Version
            this.AppVer = alfaVer.GetAppVersion();

            // Get Net Framework Version
            this.NetVer = System.Environment.Version.ToString();

            // Get UserName
            this.UserId = null;

            // GetDT
            DateTime dtNow = DateTime.Now;

            // Get Date
            this.Date = alfaDate.GetDate(dtNow);

            // Get Time
            this.Time = alfaDate.GetTime(dtNow);

            // Get Werks
            this.Werks = null;
        }

        //---------------------------------------------------------------------------------//

        public string GetWerks()
        {
            try
            {
                // Cursor
                alfaMsg.WaitCursor();

                // Functions
                alfaSAP p_SAP = new alfaSAP();

                // Parameters
                WR.ZMM007_GET_WERKS prms = new WR.ZMM007_GET_WERKS();

                // Call Service
                WR.ZMM007_GET_WERKSResponse resp = p_SAP.ZMM007_GET_WERKS(prms);

                if (resp.E_SUBRC == "00")
                {
                    // Return
                    return resp.E_WERKS;
                }
                else
                {
                    // Error
                    alfaMsg.Error(resp.E_MESSAGE.MESSAGE);

                    // Return
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Error
                MessageBox.Show(ex.Message);

                // Return
                return null;
            }
        }

        //---------------------------------------------------------------------------------//
    }

    #endregion


    #region //-----------alfaCtrl------------//

    public class alfaCtrl
    {
        //---------------------------------------------------------------------------------//

        public static void EnableControl(Control p_Control, Color p_Color)
        {
            p_Control.Enabled = true;
            p_Control.BackColor = p_Color;
        }

        //---------------------------------------------------------------------------------//

        public static void DisableControl(Control p_Control, Color p_Color)
        {
            p_Control.Enabled = false;
            p_Control.BackColor = p_Color;
        }

        //---------------------------------------------------------------------------------//
    }

    #endregion


    #region //-----------alfaTerm------------//

    public class alfaTerm
    {
        //---------------------------------------------------------------------------------//

        private static bool IsWindowsCE()
        {
            // Check for Windows CE
            if (System.Environment.OSVersion.ToString().IndexOf("Windows CE") > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //---------------------------------------------------------------------------------//

        public static void SetWindowsState( Form p_Form )
        {
            if ( IsWindowsCE() == true )
            {
                // Maximized
                p_Form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Normal
                p_Form.WindowState = FormWindowState.Normal;
            }
        }

        //---------------------------------------------------------------------------------//
    }

    #endregion


    #region //-----------alfaSAP-------------//

    public class alfaSAP : WR.service_terminal_functions
    {
        //---------------------------------------------------------------------------------//

        // Target SAP
        public static string Target = null;

        // UserName
        public static string User = null;

        // Password
        public static string Pass = null;

        //---------------------------------------------------------------------------------//

        public alfaSAP()
        {
            // Set Target
            this.Url = alfaSAP.Target;

            // Set Credentials
            this.Credentials = new System.Net.NetworkCredential(User, Pass);
        }

        //---------------------------------------------------------------------------------//

        protected override System.Net.WebRequest GetWebRequest(Uri uri)
        {
            // ERROR ---> System.Net.WebException: The request was aborted: The request was canceled
            System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)base.GetWebRequest(uri);
            webRequest.KeepAlive = false;

            return webRequest;
        }

        //---------------------------------------------------------------------------------//

        //protected override void Dispose(bool disposing)
        //{
        //    base.Dispose(disposing);
        //}

        //---------------------------------------------------------------------------------//

    }

    #endregion


    #region //-----------alfaDepo------------//

    public class alfaDepo
    {
        // Fields
        public string DepoNo;
        public string DepoName;

        // Constructor
        public alfaDepo(string p_DepoNo, string p_DepoName)
        {
            this.DepoNo = p_DepoNo;
            this.DepoName = p_DepoName;
        }

        // Override Method
        public override string ToString() { return this.DepoNo + "-" + this.DepoName; }
    }

    #endregion  


    #region //-----------alfaGrid------------//

    public class alfaGrid
    {
        //===============================================================================================================//

        public static void CreateTableStyle(DataGrid p_Grid, DataTable p_Table, string p_Field)
        {
            // Clear
            p_Grid.TableStyles.Clear();

            // Create TableStyle
            DataGridTableStyle tableStyle = new DataGridTableStyle();

            // MappingName
            tableStyle.MappingName = p_Table.TableName;

            foreach (DataColumn colTable in p_Table.Columns)
            {
                // Create Column Style
                DataGridTextBoxColumn colStyle = null;

                switch (p_Field)
                {
                    case "DEFAULT" : colStyle = new AlfaColumnDefault(p_Grid, p_Table); break;
                    case "TEORIK2" : colStyle = new AlfaColumnCheckZero(p_Grid, p_Table, p_Field); break;
                    case "KALAN"   : colStyle = new AlfaColumnCheckZero(p_Grid, p_Table, p_Field); break;
                    case "DURUM"   : colStyle = new AlfaColumnCheckStat(p_Grid, p_Table, p_Field); break;
                    case "BARKOD"  : colStyle = new AlfaColumnCheckBark(p_Grid, p_Table, p_Field); break;
                }

                // Assign Values
                colStyle.Width = GetMaxColumnLength(p_Grid, p_Table, colTable.ColumnName);
                colStyle.MappingName = colTable.ColumnName;
                colStyle.HeaderText = colTable.ColumnName;

                // Add ColStyle
                tableStyle.GridColumnStyles.Add(colStyle);
            }
            
            // Add TableStyle
            p_Grid.TableStyles.Add(tableStyle);
        }

        //===============================================================================================================//

        private static int GetMaxColumnLength(DataGrid p_Grid, DataTable p_Table, string p_Col)
        {
            // Create Graphics
            Graphics grp = p_Grid.CreateGraphics();

            // Set Initial Width
            int p_MaxLength = (int) grp.MeasureString(p_Col, p_Grid.Font).Width;

            foreach ( DataRow row in p_Table.Rows)
            {
                // Get Length
                int len = (int) grp.MeasureString(row[p_Col].ToString(), p_Grid.Font).Width;
                    
                // Set MaxValue
                if (len >= p_MaxLength) p_MaxLength = len;
            }

            return p_MaxLength + 20;
        }

        //===============================================================================================================//

        public static DataTable ToDataTable<T>( IList<T> data, string p_TableName )
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            
            DataTable table = new DataTable();

            table.TableName = p_TableName;
            
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }

            return table;
        }

        //===============================================================================================================//

        public class AlfaColumnDefault : DataGridTextBoxColumn
        {
            //---------------------------------------------------------------------------//

            private DataGrid m_Grid = null;
            private DataTable m_Table = null;

            //---------------------------------------------------------------------------//

            public AlfaColumnDefault(DataGrid p_Grid, DataTable p_Table)
            {
                // Set Grid
                this.m_Grid = p_Grid;

                // Set Table
                this.m_Table = p_Table;
            }

            //---------------------------------------------------------------------------//

            protected override void Paint(Graphics g, Rectangle Bounds, CurrencyManager Source, int RowNum, Brush BackBrush, Brush ForeBrush, bool AlignToRight)
            {
                Brush m_BackBrush = new SolidBrush(Color.White);
                Brush m_ForeBrush = new SolidBrush(Color.Black);

                // Selected Row
                if (m_Grid.CurrentRowIndex == RowNum)
                {
                    m_BackBrush = new SolidBrush(Color.Blue);
                    m_ForeBrush = new SolidBrush(Color.White);
                }
                else
                {
                    // Regular Row
                    m_BackBrush = new SolidBrush(Color.White);
                    m_ForeBrush = new SolidBrush(Color.Black);
                }

                // Call Base Function
                base.Paint(g, Bounds, Source, RowNum, m_BackBrush, m_ForeBrush, AlignToRight);
            }

            //---------------------------------------------------------------------------//

        }

        //===============================================================================================================//

        public class AlfaColumnCheckZero : DataGridTextBoxColumn
        {
            //---------------------------------------------------------------------------//

            private DataGrid m_Grid = null;
            private DataTable m_Table = null;
            private string m_Field = null;

            //---------------------------------------------------------------------------//

            public AlfaColumnCheckZero(DataGrid p_Grid, DataTable p_Table, string p_Field)
            {
                // Set Grid
                this.m_Grid = p_Grid;

                // Set Table
                this.m_Table = p_Table;

                // Set Field
                this.m_Field = p_Field;
            }

            //---------------------------------------------------------------------------//

            protected override void Paint(Graphics g, Rectangle Bounds, CurrencyManager Source, int RowNum, Brush BackBrush, Brush ForeBrush, bool AlignToRight)
            {
                Brush m_BackBrush = new SolidBrush(Color.White);
                Brush m_ForeBrush = new SolidBrush(Color.Black);

                // Decimal Value
                int fValue = 1;

                try 
	            {	        
                    // Get Value
                    if (m_Table != null)
                    {
                        if (m_Table.Columns.Contains(m_Field))
                        {
                            fValue = System.Convert.ToInt32(m_Table.Rows[RowNum][m_Field]);
                        }
                    }
	            }
	            catch
	            {
                    // Error
                    fValue = 1;
	            }

                // Check KALAN
                if (fValue == 0)
                {
                    m_BackBrush = new SolidBrush(Color.Green);
                    m_ForeBrush = new SolidBrush(Color.White);
                }
                else
                {
                    // Selected Row
                    if (m_Grid.CurrentRowIndex == RowNum)
                    {
                        m_BackBrush = new SolidBrush(Color.Blue);
                        m_ForeBrush = new SolidBrush(Color.White);
                    }
                    else
                    {
                        // Regular Row
                        m_BackBrush = new SolidBrush(Color.White);
                        m_ForeBrush = new SolidBrush(Color.Black);
                    }
                }

                // Call Base Function
                base.Paint(g, Bounds, Source, RowNum, m_BackBrush, m_ForeBrush, AlignToRight);
            }

            //---------------------------------------------------------------------------//
        
        }

        //===============================================================================================================//

        public class AlfaColumnCheckStat : DataGridTextBoxColumn
        {
            //---------------------------------------------------------------------------//

            private DataGrid m_Grid = null;
            private DataTable m_Table = null;
            private string m_Field = null;

            //---------------------------------------------------------------------------//

            public AlfaColumnCheckStat(DataGrid p_Grid, DataTable p_Table, string p_Field)
            {
                // Set Grid
                this.m_Grid = p_Grid;

                // Set Table
                this.m_Table = p_Table;

                // Set Field
                m_Field = p_Field;
            }

            //---------------------------------------------------------------------------//

            protected override void Paint(Graphics g, Rectangle Bounds, CurrencyManager Source, int RowNum, Brush BackBrush, Brush ForeBrush, bool AlignToRight)
            {
                // Define Brush
                Brush m_BackBrush = new SolidBrush(Color.White);
                Brush m_ForeBrush = new SolidBrush(Color.Black);

                // Field Value
                string fValue = null;

                try
                {
                    if (m_Table != null && m_Table.Columns.Contains(m_Field))
                    {
                        // Get Value
                        fValue = m_Table.Rows[RowNum][m_Field].ToString();
                    }
                }
                catch
                {
                    fValue = null;
                }


                // PASS Value
                if (fValue == "TAMAM")
                {
                    m_BackBrush = new SolidBrush(Color.Green);
                    m_ForeBrush = new SolidBrush(Color.White);
                }
                // FAIL Value
                else if (fValue == "HATA")
                {
                    m_BackBrush = new SolidBrush(Color.Red);
                    m_ForeBrush = new SolidBrush(Color.White);
                }

                // Call Base Function
                base.Paint(g, Bounds, Source, RowNum, m_BackBrush, m_ForeBrush, AlignToRight);
            }

            //---------------------------------------------------------------------------//

        }

        //===============================================================================================================//

        public class AlfaColumnCheckBark : DataGridTextBoxColumn
        {
            //---------------------------------------------------------------------------//

            private DataGrid m_Grid = null;
            private DataTable m_Table = null;
            private string m_Field = null;

            //---------------------------------------------------------------------------//

            public AlfaColumnCheckBark(DataGrid p_Grid, DataTable p_Table, string p_Field)
            {
                // Set Grid
                this.m_Grid = p_Grid;

                // Set Table
                this.m_Table = p_Table;

                // Set Field
                m_Field = p_Field;
            }

            //---------------------------------------------------------------------------//

            protected override void Paint(Graphics g, Rectangle Bounds, CurrencyManager Source, int RowNum, Brush BackBrush, Brush ForeBrush, bool AlignToRight)
            {
                // Define Brush
                Brush m_BackBrush = new SolidBrush(Color.White);
                Brush m_ForeBrush = new SolidBrush(Color.Black);

                // Field Values
                string fValue1 = null;
                string fValue2 = null;

                try
                {
                    // Get Values
                    fValue1 = m_Table.Rows[RowNum]["BARKON"].ToString();
                    fValue2 = m_Table.Rows[RowNum]["BARYUK"].ToString();
                }
                catch
                {
                    fValue1 = null;
                    fValue2 = null;
                }


                // PASS Value
                if (fValue1 == "X" || fValue2 == "X")
                {
                    m_BackBrush = new SolidBrush(Color.Red);
                    m_ForeBrush = new SolidBrush(Color.White);
                }
                // FAIL Value
                else
                {
                    m_BackBrush = new SolidBrush(Color.Green);
                    m_ForeBrush = new SolidBrush(Color.White);
                }

                // Call Base Function
                base.Paint(g, Bounds, Source, RowNum, m_BackBrush, m_ForeBrush, AlignToRight);
            }

            //---------------------------------------------------------------------------//

        }

        //===============================================================================================================//

    }

    #endregion  
    
}

