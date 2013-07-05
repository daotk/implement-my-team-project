using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace GUI.ThuNgan
{
    public partial class frm_Receipt : Form
    {
        private string ma1;
        private string b1;
        private int t1;
        public frm_Receipt(string ma, int t, string b)
        {
            ma1 = ma;
            b1 = b;
            t1 = t;
            InitializeComponent();
        }

        private void frm_Receipt_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\Dao Khau\\Documents\\Visual Studio 2010\\Projects\\Ehealth_System\\GUI\\ThuNgan\\CrystalReport.rpt");
            cryRpt.SetParameterValue("@BILLID", ma1);//truyền BillID vào
            cryRpt.SetDatabaseLogon("sa", "123456", "DAOKHAU\\SQLEXPRESS", "EHealthSystem");//ẩn message nhập username và pass
            
            cryRpt.SetParameterValue("TongTien", t1);//lấy tổng số tiền hiển thị ra receipt
            cryRpt.SetParameterValue("CompanyName", b1);//lấy tổng tiền = chữ hiển thị ra receipt

            crystalReportViewer.ReportSource = cryRpt;
            crystalReportViewer.Refresh();    
        }
    }
}
