using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;

namespace DA
{
   public class Department_DA
    {
       public static List<Department_DO> GetAllDeparts()
       {
           List<Department_DO> ListDepartment = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info select u;
               var query1 = from u in dk.DepartmentType_Info 
                            select u;
               foreach (var row in query)
               {
                   Department_DO depart = new Department_DO();
                   depart._DEPARTMENTID = row.DEPARTMENTID;
                   depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var departmenttypename = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   depart._DEPARTMENTTYPENAME = departmenttypename.DEPARTMENTTYPENAME;
                   depart._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   depart._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   depart._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   ListDepartment.Add(depart);
               }
               return ListDepartment;
           }

       }//end

       public static List<DO.QuanTriHeThong.TypeDepartment_DO> GetAllDeparts1()
       {
           List<DO.QuanTriHeThong.TypeDepartment_DO> ListDepartment = new List<DO.QuanTriHeThong.TypeDepartment_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.DepartmentType_Info where u.DEPARTMENTSTATUS ==true select u;
               foreach (var row in query)
               {
                   DO.QuanTriHeThong.TypeDepartment_DO depart = new DO.QuanTriHeThong.TypeDepartment_DO();
                   depart._DEPARTMENTNAME = row.DEPARTMENTTYPENAME;
                   depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   ListDepartment.Add(depart);
               }
               return ListDepartment;
           }

       }//end



       /// <summary>
       /// Thêm phòng ban mới
       /// </summary>
       /// <param name="ID"></param>
       /// <param name="name"></param>
       /// <param name="DEPARTMENTTYPEID"></param>
       /// <param name="desscription"></param>
       /// <param name="status"></param>
       /// <returns></returns>
       public static int add(String ID, String name, String DEPARTMENTTYPEID, String desscription, bool status)
       {

           using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
           {
               Entity.Department_Info depart = new Entity.Department_Info();
               depart.DEPARTMENTID = ID;
               depart.DEPARTMENTTYPEID = DEPARTMENTTYPEID;

               depart.DEPARTMENTNAME = name;
               depart.DEPARTMENTDESCRIPTION = desscription;
               depart.DEPARTMENTSTATUS = status;
               entity.Department_Info.AddObject(depart);
               try
               {
                   int num = entity.SaveChanges();
                   return num;
               }
               catch
               {
                   return -1;
               }

           }
       }//end

       /// <summary>
       /// Chỉnh sửa phòng ban
       /// </summary>
       /// <param name="ID"></param>
       /// <param name="name"></param>
       /// <param name="DEPARTMENTTYPEID"></param>
       /// <param name="desscription"></param>
       /// <param name="status"></param>
       /// <returns></returns>
       public static int edit(String ID, String name, String DEPARTMENTTYPEID, String desscription, bool status)
       {
           using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
           {
               var depart = entity.Department_Info.Single(p => p.DEPARTMENTID == ID);
               depart.DEPARTMENTID = ID;
               depart.DEPARTMENTTYPEID = DEPARTMENTTYPEID;
               depart.DEPARTMENTNAME = name;
               depart.DEPARTMENTDESCRIPTION = desscription;
               depart.DEPARTMENTSTATUS = status;
               //entity.SaveChanges();
               try
               {
                   int num = entity.SaveChanges();
                   return num;
               }
               catch
               {
                   return -1;
               }
           }
       }//end


       /// <summary>
       /// Tìm kiếm phòng ban theo tên
       /// </summary>
       /// <param name="Search"></param>
       /// <returns></returns>
       public static List<Department_DO> SearchDepartment(string Search)
       {
           List<Department_DO> timkiem = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info where (u.DEPARTMENTNAME.Contains(Search)) select u;
               var query1 = from u in dk.DepartmentType_Info
                            select u;
               foreach (var row in query)
               {
                   Department_DO search = new Department_DO();
                   search._DEPARTMENTID = row.DEPARTMENTID;
                   search._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   search._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var cityname = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   search._DEPARTMENTTYPENAME = cityname.DEPARTMENTTYPENAME;
                   search._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   search._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   timkiem.Add(search);
               }
               return timkiem;
           }
       }//end

       /// <summary>
       /// Tìm kiếm phòng ban theo loại phòng ban
       /// </summary>
       /// <param name="Search"></param>
       /// <returns></returns>
       public static List<Department_DO> SearchDistrByDeparttype(string Search)
       {
           List<Department_DO> timkiem = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info where (u.DEPARTMENTTYPEID.Contains(Search)) select u;
               var query1 = from u in dk.DepartmentType_Info
                            select u;
               foreach (var row in query)
               {
                   Department_DO search = new Department_DO();
                   search._DEPARTMENTID = row.DEPARTMENTID;
                   search._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   search._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var departname = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   search._DEPARTMENTTYPENAME = departname.DEPARTMENTTYPENAME;
                   search._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   search._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   timkiem.Add(search);
               }
               return timkiem;
           }

       }//end


       /// <summary>
       /// Tìm kiếm phòng ban theo từ khóa và theo loại phòng ban
       /// </summary>
       /// <param name="text"></param>
       /// <param name="Search"></param>
       /// <returns></returns>
       public static List<Department_DO> SearchDepartByBoth(String text, string Search)
       {
           List<Department_DO> timkiem = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info where (u.DEPARTMENTNAME.Contains(text)) && (u.DEPARTMENTTYPEID.Contains(Search)) select u;
               var query1 = from u in dk.DepartmentType_Info
                            select u;
               foreach (var row in query)
               {
                   Department_DO search = new Department_DO();
                   search._DEPARTMENTID = row.DEPARTMENTID;
                   search._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   search._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var cityname = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   search._DEPARTMENTTYPENAME = cityname.DEPARTMENTTYPENAME;
                   search._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   search._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   timkiem.Add(search);
               }
               return timkiem;
           }

       }//end

       
    }
}//end class
