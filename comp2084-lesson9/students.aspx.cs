using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using comp2084_lesson9.Models;

namespace comp2084_lesson9
{
    public partial class students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetStudents();
        }
        //Entity Framework to bring in students list
        protected void GetStudents()
        {
            using (DefaultConnection db = new DefaultConnection())
            {
                var stu = from s in db.Students select s;
                grdStudents.DataSource = stu.ToList();
                grdStudents.DataBind();
            }
        }
    
    }
}