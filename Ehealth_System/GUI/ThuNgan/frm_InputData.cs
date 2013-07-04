using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DO.ThuNgan;
using BL.ThuNgan;
namespace GUI.ThuNgan
{
    public partial class frm_InputData : Form
    {
        public frm_InputData()
        {
            InitializeComponent();
        }

        private void frm_InputData_Load(object sender, EventArgs e)
        {
            txt_TongTien.Text = tongtien.ToString(); ;
            LoadDSServiceType();
            cbo_NhomDichVu.Text = "";
        }
        private int tongtien = 0;
        private void LoadTongTien() {
            txt_TongTien.Text = tongtien.ToString(); ;
        }
        private void LoadDSServiceType()
        {
            cbo_NhomDichVu.DataSource = BL.ThuNgan.TypistBL.LoadDSServiceType();
            cbo_NhomDichVu.DisplayMember = "servicetypename";
            cbo_NhomDichVu.ValueMember = "servicetypeid";
            //List<TypistDO> dsServiceType = BL.Thu_Ngan.TypistBL.LoadDSServiceType();
            //for (int i = 0; i < dsServiceType.Count; i++)
            //{
               
            //    cbo_NhomDichVu.Items.Add(dsServiceType[i].servicetypename.ToString());
            //}
        }

        private void LoadDSService()
        {
            List<TypistDO> dsService = BL.ThuNgan.TypistBL.LoadDSService(cbo_NhomDichVu.Text);
            for (int i = 0; i < dsService.Count; i++)
            {
                cbo_DichVu.Items.Add(dsService[i].servicename_.ToString());
            }
        }
       

        private void txt_MaBenhNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                try
                {
                    List<PatientDO> patientinfo = BL.ThuNgan.TypistBL.LoadPatientInfo(txt_MaBenhNhan.Text);
                    txt_TenBenhNhan.Text = patientinfo[0].patientname_.ToString();
                    if (patientinfo[0].gender_.ToString() == "1")
                    {
                        txt_GioiTinh.Text = "Nam";
                    }
                    else
                    {
                        if (patientinfo[0].gender_.ToString() == "2")
                        {
                            txt_GioiTinh.Text = "Nữ";
                        }
                        else
                        {
                            txt_GioiTinh.Text = "Other";
                        }

                    }

                    txt_Tuoi.Text = patientinfo[0].age_.ToString();
                    txt_DiaChi.Text = patientinfo[0].address_.ToString();
                    txt_SDT.Text = patientinfo[0].phone_.ToString();

                }
                catch { MessageBox.Show("Bệnh nhân không tồn tại");
                txt_TenBenhNhan.Text = "";
                txt_GioiTinh.Text = "";
                txt_Tuoi.Text = "";
                txt_DiaChi.Text = "";
                txt_SDT.Text = "";
                }
                
            }
        }

        private void txt_SDT_Click(object sender, EventArgs e)
        {

        }

        private int i = 0;
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (CheckInfoTypist())
            {
                List<CostDO> abc = BL.ThuNgan.TypistBL.LoadServiceCost(cbo_DichVu.SelectedValue.ToString());
                DataGridViewRow row = new DataGridViewRow();
                grd_DichVu.Rows.Add(row);
                grd_DichVu.Rows[i].Cells[1].Value = cbo_NhomDichVu.Text;
                grd_DichVu.Rows[i].Cells[2].Value = cbo_DichVu.Text;
                grd_DichVu.Rows[i].Cells[3].Value = abc[0].servicecost_.ToString();
                grd_DichVu.Rows[i].Cells[4].Value = abc[0].servicecost_.ToString();
                tongtien = tongtien + Int32.Parse(abc[0].servicecost_.ToString());
                LoadTongTien();
                i++;

            }
            else {
                MessageBox.Show("Bạn phải chọn đầy đủ dịch vụ và loại dịch vụ");
            }
        }
        private bool CheckInfoTypist(){
            bool test = true;
            if (cbo_NhomDichVu.Text == "" || cbo_DichVu.Text == "" )
            {
                test = false;
            }
            return test;
        }

        private void cbo_NhomDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cbo_NhomDichVu.SelectedValue.ToString();
            cbo_DichVu.Text = "";
            cbo_DichVu.DataSource = BL.ThuNgan.TypistBL.LoadDSService(id);
            cbo_DichVu.DisplayMember = "servicename_";
            cbo_DichVu.ValueMember = "serviceid_";
            cbo_DichVu.Text = "";
        }
        private string loadmaloaidichvu;
        private string loadmahoadon;
        private string madichvu;
        private string[] arr ;
        private int lengArr ;
        private int numberhoadon = 1;
        private int numberchitiethoadon = 1;
        private bool CheckMaBenhNhan(string mabenhnhan) {
            List<PatientDO> xyz = BL.ThuNgan.TypistBL.LoadDSMaBenhNhan();
            bool test = false;
            for (int i = 0; i < xyz.Count; i++) {
                if (mabenhnhan.Equals(xyz[i].patientid_)) {
                    test = true;
                }
            }
            return test;
        }
        private void btn_In_Click(object sender, EventArgs e)
        {
            if (txt_MaBenhNhan.Text == "" || txt_MaBenhNhan.Text == null)
            {
                MessageBox.Show("Bạn phải nhập mã bệnh nhân");
            }
            else {
                if (CheckMaBenhNhan(txt_MaBenhNhan.Text))
                {
                    if (i == 0)
                    {
                        MessageBox.Show("Bạn phải chọn loại dịch vụ và dịch vụ");
                    }
                    else
                    {
                        arr = new string[i];
                        lengArr = 1;
                        arr[0] = grd_DichVu.Rows[0].Cells[1].Value.ToString();

                        for (int count = 1; count < i; count++)
                        {
                            bool test = true;
                            for (int b = 0; b < lengArr; b++)
                            {

                                if (grd_DichVu.Rows[count].Cells[1].Value.ToString().Equals(arr[b]))
                                {
                                    test = false;
                                }
                            }
                            if (test)
                            {
                                arr[lengArr] = grd_DichVu.Rows[count].Cells[1].Value.ToString();
                                lengArr++;
                            }
                        }
                        // BL.Thu_Ngan.TypistBL.CreateBill("AC", "A130000001", "AD001", "D1", "200000", false, arr[0].ToString());


                        for (int abc = 0; abc < lengArr; abc++)
                        {
                            //Create Bill
                            BL.ThuNgan.TypistBL.CreateBill(BL.ThuNgan.TypistBL.LoadIDLoaidichvu(arr[abc].ToString(), loadmaloaidichvu), txt_MaBenhNhan.Text, "AD001", "D1",
                                "200000", false, arr[abc].ToString());

                            //Create Detail Bill
                            int tongchiphidichvu = 0;
                            for (int count = 0; count < i; count++)
                            {
                                if (arr[abc].ToString() == grd_DichVu.Rows[count].Cells[1].Value.ToString())
                                {

                                    BL.ThuNgan.TypistBL.CreateDetailBill(BL.ThuNgan.TypistBL.LoadIDdichvu(grd_DichVu.Rows[count].Cells[2].Value.ToString(), madichvu), grd_DichVu.Rows[count].Cells[3].Value.ToString(),
                                        BL.ThuNgan.TypistBL.LoadIDBill(grd_DichVu.Rows[count].Cells[1].Value.ToString(), loadmahoadon));
                                    tongchiphidichvu = tongchiphidichvu + Int32.Parse(grd_DichVu.Rows[count].Cells[3].Value.ToString());
                                    
                                }
                             }
                            BL.ThuNgan.TypistBL.capnhatongtien(BL.ThuNgan.TypistBL.LoadIDBill(arr[abc].ToString(), loadmahoadon), tongchiphidichvu.ToString());
                            
                            tongchiphidichvu = 0;

                        }


                        MessageBox.Show("In hóa đơn thành công");

                    }
                }
                else {
                    MessageBox.Show("Mã bệnh nhân không tồn tại");
                }
//--------------------------------------------------------------------
                //Chau continous
                
            }
            
        }
       // delete row
        private void grd_DichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            //    string ID = grd_DichVu.CurrentRow.Cells[0].Value.ToString();
                if (e.ColumnIndex == 5)
                {
                    tongtien = tongtien - Int32.Parse(this.grd_DichVu.CurrentRow.Cells[4].Value.ToString());
                    
                    grd_DichVu.Rows.RemoveAt(this.grd_DichVu.SelectedRows[0].Index);
                    i--;
                    LoadTongTien();
                    MessageBox.Show("Xóa thành công");
                  //  MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
                }
            }
            catch { 
            
            }
            
        }

        private void lbl_GioiTinh_Click(object sender, EventArgs e)
        {

        }

    }
}
