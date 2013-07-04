using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA.ThuNgan
{
    public class Desk_DA
    {
        public static List<DO.ThuNgan.Desk_DO> GetAllDesk()
        {
            List<DO.ThuNgan.Desk_DO> ListDesk = new List<DO.ThuNgan.Desk_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DeskCashiers where u.DESKSTATUS==true select u;
                foreach (var row in query)
                {
                    DO.ThuNgan.Desk_DO desk = new DO.ThuNgan.Desk_DO();
                    desk._DESKID = row.DESKID;
                    desk._DESKNAME = row.DESKNAME;
                    desk._DEPARTMENTID = row.DEPARTMENTID;
                    desk._DEPARTMENTNAME = row.Department_Info.DEPARTMENTNAME;
                    desk._CASHIER = row.CASHIER;
                    desk._TYPIST = row.TYPIST;
                    desk._DESKSTATUS = row.DESKSTATUS;
                    ListDesk.Add(desk);
                }
                return ListDesk;
            }
        }

        public static List<DO.ThuNgan.Desk_DO> GetDesk(string tenban)
        {
            List<DO.ThuNgan.Desk_DO> ListDesk = new List<DO.ThuNgan.Desk_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DeskCashiers where u.DESKNAME == tenban select u;
                foreach (var row in query)
                {
                    DO.ThuNgan.Desk_DO desk = new DO.ThuNgan.Desk_DO();
                    desk._DESKID = row.DESKID;
                    desk._DESKNAME = row.DESKNAME;
                    desk._DEPARTMENTID = row.DEPARTMENTID;
                    desk._DEPARTMENTNAME = row.Department_Info.DEPARTMENTNAME;
                    desk._CASHIER = row.CASHIER;
                    desk._TYPIST = row.TYPIST;
                    desk._DESKSTATUS = row.DESKSTATUS;
                    ListDesk.Add(desk);
                }
                return ListDesk;
            }
        }

        public static void UpdateCashierInfo(string DESKNAME, bool check)
        {

            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.DeskCashiers
                             where u.DESKNAME == DESKNAME
                             select u).First();
                query.CASHIER = check;
                dk.SaveChanges();
            }
        }
        public static void UpdateTypistInfo(string DESKNAME, bool check)
        {

            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.DeskCashiers
                             where u.DESKNAME == DESKNAME
                             select u).First();
                query.TYPIST = check;
                dk.SaveChanges();
            }
        }
        
    }
}
