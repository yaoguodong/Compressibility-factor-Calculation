using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ZfactorCal
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        
        ExcelOperate Excel;
        /*
        private void Main_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            groupBox3.Visible = !groupBox3.Visible;
        }
        */
        private void inputData_Click(object sender, EventArgs e)
        {
            Excel = new ExcelOperate();
            Excel.ImpExcel();

            string[] ExSheetName = Excel.ReceiveItem();

            boxTableName.Items.Clear();
            boxTableName.DataSource = ExSheetName;
            
        }

        private void boxTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sheetName = boxTableName.SelectedItem.ToString();
            string strExcel = "SELECT * FROM [" + sheetName + "]";

            dgComposition.Columns.Clear();

            dgComposition.DataSource = Excel.ExToDGV(strExcel, sheetName);
            dgComposition.DataMember = sheetName;

            Excel.GetComposition();

        }

        private void inputDataBase_Click(object sender, EventArgs e)
        {
            DataBaseConn dbc = new DataBaseConn();
            dbc.ShowDialog();
            
        }

        private void checkAdvance_CheckedChanged(object sender, EventArgs e)
        {
            if (panel1.BorderStyle == BorderStyle.FixedSingle)
                panel1.BorderStyle = BorderStyle.None;
            else
            {
                panel1.BorderStyle = BorderStyle.FixedSingle;
            }
            groupBox1.Visible = !groupBox1.Visible;
            groupBox2.Visible = !groupBox2.Visible;
            groupBox3.Visible = !groupBox3.Visible;
        }

        private void tabData_SelectedIndexChanged(object sender, EventArgs e)
        {
                Kay.Enabled = !Kay.Enabled;
                SBV.Enabled = !SBV.Enabled;
                SSBV.Enabled = !SSBV.Enabled;
                Standing.Enabled = !Standing.Enabled;
                Sutton05.Enabled = !Sutton05.Enabled;
                Sutton85.Enabled = !Sutton85.Enabled;
            
        }

       
        /*
        private void SqlToDGV()
        {
            string connStr = "server=localhost;user=root;database=test;port=3306;password=12345zhangchenZC;";
            MySqlConnection conn = new MySqlConnection(connStr);
            string sql = "SELECT * FROM gasdata ";
            MySqlDataAdapter daGas = new MySqlDataAdapter(sql, conn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(daGas);

            DataSet dsGas = new DataSet();
            daGas.Fill(dsGas, "gasdata");
            dgComposition.DataSource = dsGas;
            dgComposition.DataMember = "gasdata";
            DataTable dtGas = dsGas.Tables["gasdata"];
            DataRow[] drGas = dtGas.Select();

            int tmp = drGas.Length;

            mf = new double[tmp];
            pC = new double[tmp];
            tC = new double[tmp];
            for (int i = 0; i < tmp; i++)
            {
                mf[i] = (double)drGas[i]["MoleFraction"];
                tC[i] = (double)drGas[i]["CTemperature"];
                pC[i] = (double)drGas[i]["CPressure"];
            }
        }*/

       
    }



    public class ExcelOperate 
    {
        public double[] mf, tC, pC;
        private string fileName = string.Empty;
        private string strConn = string.Empty;
        private DataSet dsGas;
        private DataTable dtGas;
        private DataRow[] drGas;

        public void ImpExcel()
        {
            OpenFileDialog ofdExcel = new OpenFileDialog();
            ofdExcel.Title = "Excel文件";
            ofdExcel.FileName = "";
            ofdExcel.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdExcel.Filter = "Excel文件(*.xls*)|*.xls*";
            ofdExcel.ValidateNames = true;     //文件有效性验证ValidateNames，验证用户输入是否是一个有效的Windows文件名
            ofdExcel.CheckFileExists = true;  //验证路径有效性
            ofdExcel.CheckPathExists = true; //验证文件有效性

            if (ofdExcel.ShowDialog() == DialogResult.OK)
            {
                fileName = ofdExcel.FileName;
            }

            if (fileName == "")
            {
                MessageBox.Show("没有选择Excel文件！无法进行数据导入");
                return;
            }

            strConn = GetConnectionString(fileName);

        }

        public string[] ReceiveItem()
        {
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            DataTable dtsheets = conn.GetOleDbSchemaTable(
                                         OleDbSchemaGuid.Tables
                                        , new object[] { null, null, null, "TABLE" });
            
            DataRow[] drS = dtsheets.Select();
            string[] x = new string[drS.Length];
            for (int i = 0; i < drS.Length; i++)
            {
                x[i] = drS[i]["TABLE_NAME"].ToString();
            }
            return x;
        }

        public DataSet ExToDGV(string E, string N)
        {
            OleDbDataAdapter daGas = new OleDbDataAdapter(E, strConn);
            dsGas = new DataSet("Gas");

            daGas.Fill(dsGas,N);
            dtGas = dsGas.Tables[N];
            drGas = dtGas.Select();

            return dsGas;

        }

        public void GetComposition()
        {
            int tmp = dtGas.Rows.Count;
            mf = new double[tmp];
            pC = new double[tmp];
            tC = new double[tmp];

            for (int i = 0; i < dtGas.Columns.Count; i++ )
            {
                if (dtGas.Columns[i].ColumnName.IndexOf("摩") != -1)
                {
                    for (int j = 0; j < tmp; j++)
                    {
                        mf[j] = double.Parse( drGas[j][dtGas.Columns[i].ColumnName].ToString());
                    }
                }
                else if (dtGas.Columns[i].ColumnName.IndexOf("温") != -1)
                {
                    for (int j = 0; j < tmp; j++)
                    {
                        tC[j] = double.Parse(drGas[j][dtGas.Columns[i].ColumnName].ToString());
                    }
                }
                else if (dtGas.Columns[i].ColumnName.IndexOf("压") != -1)
                {
                    for (int j = 0; j < tmp; j++)
                    {
                        pC[j] = double.Parse(drGas[j][dtGas.Columns[i].ColumnName].ToString());
                    }
                }
            }
        }

        private static string GetConnectionString(string FileName)
        {
            if (FileName.ToLower().EndsWith("xls"))
            {
                return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                    + FileName +
                    ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';Persist Security Info=False";
            }
            else //if (FileName.ToLower().EndsWith("xlsx"))

                return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                    + FileName +
                    ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';Persist Security Info=False";

        }
    }

    public class PseudoReducePro
    {
        private double ppc = 0, tpc = 0;

        public double Ppc
        {
            get;
            set;

        }
        public double Tpc { get; set; }

        public void KayMR(ref double[] mf,ref double[] pc,ref double[] tc)
        {
            for (int i = 0; i < mf.Length; i++)
            {
                ppc += mf[i] * pc[i];
                tpc += mf[i] * tc[i];
            }
        }

        public void SBVMR(ref double[] mf, ref double[] pc, ref double[] tc)
        {
            double J = 0, K = 0;

            for (int i = 0; i < mf.Length; i++)
            {
                J += (1 / 3) * (mf[i] * tc[i]) / (pc[i]);
                K += mf[i] * (Math.Pow((tc[i] / pc[i]), 0.5));
            }
            J += (2 / 3) * (Math.Pow(K, 2));

            tpc = Math.Pow(K, 2) / J;
            ppc = tpc / J;
        }

        public void SSBVMR(ref double[] mf, ref double[] pc, ref double[] tc)
        {
            double J = 0, K = 0;

            for (int i = 0; i < mf.Length; i++)
            {
                J += (1 / 3) * (mf[i] * tc[i]) / (pc[i]);
                K += mf[i] * (Math.Pow((tc[i] / pc[i]), 0.5));
            }
            J += (2 / 3) * (Math.Pow(K, 2));


        }
        
    }

    public class HY
    {
        private double pPR, tPR;

        public double Ppr { get; set; }
        public double Tpr { get; set; }

        public HY(double x, double y)
        {
            this.Ppr = x;
            this.Tpr = y;
        }
        public double ZCalcu()
        {
            double x = NewtonIter();
            return (1 + x + x * x - x * x * x) / (Math.Pow((1 - x), 3)) - (14.76 / tPR - 9.76 / (tPR * tPR) + 4.58 / (tPR * tPR * tPR)) * x
                + (90.7 / tPR - 242.2 / (tPR * tPR * tPR) + 42.4 / (tPR * tPR * tPR)) * (Math.Pow(x, (1.18 + 2.82 / tPR)));
        }
        private double NewtonIter()
        {
            double denR;
            double tmp = 5;
            double tmp1 = pPR / (tPR - 0.6903);
            if (tmp1 > 5.56)
            { denR = (0.9872791) * (Math.Pow(pPR, 0.3022868)) / (Math.Pow(10, 0.5491962 * tPR)); }
            else
            { denR = (0.9420554) * (Math.Pow(pPR, 1.071221)) / (Math.Pow(10, 0.7627628 * tPR)); }
            while (Math.Abs(denR - tmp) > 0.00001)
            {
                tmp = denR;
                denR = tmp - Func(tmp) / DeriveFunc(tmp);
            }
            return denR;
        }
        private double DeriveFunc(double x)
        {
            return (1 + 4 * x + 4 * x * x - 4 * x * x * x + x * x * x * x) / (Math.Pow((1 - x), 4)) - (29.52 / tPR - 19.52 / (tPR * tPR)
                + 9.16 / (tPR * tPR * tPR)) * x + (2.18 + 2.82 / tPR) * (90.7 / tPR - 242.2 / (tPR * tPR) + 42.4 / (tPR * tPR * tPR)) * (Math.Pow(x, (1.18 + 2.82 / tPR)));
        }
        private double Func(double x)
        {
            return (Constant() + (x + x * x + x * x * x - x * x * x * x) / (Math.Pow((1 - x), 3)) - (14.76 / tPR - 9.76 / (tPR * tPR) + 4.58 / (tPR * tPR * tPR)) * (x * x)
                + (90.7 / tPR - 242.2 / (tPR * tPR) + 42.4 / (tPR * tPR * tPR)) * (Math.Pow(x, (2.18 + 2.82 / tPR))));
        }
        private double Constant()
        {
            return (-0.06125) * (Math.Exp((-1.2) * (Math.Pow((1 - 1 / tPR), 2)))) * (pPR / tPR);
        }
    }
}

public class DAK
{
 
}
