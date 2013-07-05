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
        private void LoadTongTien()
        {
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
            if (e.KeyCode == Keys.Enter)
            {
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
                catch
                {
                    MessageBox.Show("Bệnh nhân không tồn tại");
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
            else
            {
                MessageBox.Show("Bạn phải chọn đầy đủ dịch vụ và loại dịch vụ");
            }
        }
        private bool CheckInfoTypist()
        {
            bool test = true;
            if (cbo_NhomDichVu.Text == "" || cbo_DichVu.Text == "")
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
        private string[] arr;
        private int lengArr;
        private int numberhoadon = 1;
        private int numberchitiethoadon = 1;
        string b = "";
        private bool CheckMaBenhNhan(string mabenhnhan)
        {
            List<PatientDO> xyz = BL.ThuNgan.TypistBL.LoadDSMaBenhNhan();
            bool test = false;
            for (int i = 0; i < xyz.Count; i++)
            {
                if (mabenhnhan.Equals(xyz[i].patientid_))
                {
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
            else
            {
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
                            string ma = "";
                            //Create Bill
                            BL.ThuNgan.TypistBL.CreateBill(BL.ThuNgan.TypistBL.LoadIDLoaidichvu(arr[abc].ToString(), loadmaloaidichvu), txt_MaBenhNhan.Text, "AD001", "1",
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
                                    ma = BL.ThuNgan.TypistBL.LoadIDBill(grd_DichVu.Rows[count].Cells[1].Value.ToString(), loadmahoadon);
                                }
                            }

                            b = So_chu(tongchiphidichvu);//chuyển tổng tiền số thành chữ
                            //-------------------in biên lai-------------------------

                            frm_Receipt rep = new frm_Receipt(ma, tongchiphidichvu, b);
                            rep.Show();
                            BL.ThuNgan.TypistBL.capnhatongtien(BL.ThuNgan.TypistBL.LoadIDBill(arr[abc].ToString(), loadmahoadon), tongchiphidichvu.ToString());

                            //-------------------kết thúc hàm in---------------------

                            tongchiphidichvu = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã bệnh nhân không tồn tại");
                }
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
            catch
            {

            }
        }

        //----------------Code chuyển số thành chữ dùng để chuyển tổng tiền thành chữ số để in ra biên lai---------
        private static string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;
                case "1":
                    result = "một";
                    break;
                case "2":
                    result = "hai";
                    break;
                case "3":
                    result = "ba";
                    break;
                case "4":
                    result = "bốn";
                    break;
                case "5":
                    result = "năm";
                    break;
                case "6":
                    result = "sáu";
                    break;
                case "7":
                    result = "bảy";
                    break;
                case "8":
                    result = "tám";
                    break;
                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        private static string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }

        private static string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";

            }


            return Ktach;

        }

        public static string So_chu(int gNum)
        {
            if (gNum == 0)
                return "Không đồng";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(Convert.ToDouble(gNum), 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            // Dau [+ , - ]
            if (gNum < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod 
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim() + " đồng chẵn.";

            return lso_chu.ToString().Trim();
        }
        //----------------Kết thúc code chuyển số thành chữ dùng trong in biên lai
    }
}
