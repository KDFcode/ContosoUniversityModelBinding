using ContosoUniversityModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Entity;

namespace ContosoUniversityModelBinding
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void coursesGrid_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = new ContosoUniversityModelBinding.BLL.SchoolBL();
        }

        //public IQueryable<Enrollment> coursesGrid_GetData([QueryString] int? studentID)
        //{
        //    SchoolContext db = new SchoolContext();
        //    var query = db.Enrollments.Include(e => e.Course)
        //        .Where(e => e.StudentID == studentID);
        //    return query;
            //} //komentarisemo u skladu sa  https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/adding-business-logic-layer#revise-existing-pages-to-retrieve-data-from-business-logic-layer

        }
}