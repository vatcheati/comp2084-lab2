using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using comp2084_lesson9.Models;

namespace comp2084_lesson9
{
    public partial class student_details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if we have ID look up record
                if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
                {
                    GetStudents();
                }
            }
        }
        protected void GetStudents()
        {
            //look up the selected student
            using (DefaultConnection db = new DefaultConnection())
            {
                Int32 StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);

                Student stu = (from s in db.Students
                                  where s.StudentID == StudentID
                                  select s).FirstOrDefault();

                txtLast.Text = stu.LastName;
                txtFirst.Text = stu.FirstMidName;
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
  //connect
            using (DefaultConnection db = new DefaultConnection())
            {
                //creating new student
                Student stu = new Student();
                Int32 StudentID = 0;
                //check for a url
                if (!String.IsNullOrEmpty(Request.QueryString["StudentID"]))
                {
                    //get the id
                     StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);

                    //look up student
                    stu = (from s in db.Students
                           where s.StudentID == StudentID
                           select s).FirstOrDefault();
                }

                //properties for new students
                stu.LastName = txtLast.Text;
                stu.FirstMidName = txtFirst.Text;
                stu.EnrollmentDate = Convert.ToDateTime(txtEnroll.Text);
                if (StudentID == 0)
                {
                    db.Students.Add(stu);
                }

                //save new students
                db.SaveChanges();
                //send back to student page
                Response.Redirect("Students.aspx");
            }
        }
    }
}