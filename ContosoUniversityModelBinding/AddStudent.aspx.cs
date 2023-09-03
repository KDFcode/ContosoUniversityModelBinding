using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoUniversityModelBinding.Models;

namespace ContosoUniversityModelBinding
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addStudentForm_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = new ContosoUniversityModelBinding.BLL.SchoolBL();
        }

        //public void addStudentForm_InsertItem()
        //{
        //    var item = new Student();

        //    TryUpdateModel(item);
        //    if (ModelState.IsValid)
        //    {
        //        using (SchoolContext db = new SchoolContext())
        //        {
        //            db.Students.Add(item);
        //            db.SaveChanges();
        //        }
        //    }
        //} //komentarisemo u skladu sa  https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/adding-business-logic-layer#revise-existing-pages-to-retrieve-data-from-business-logic-layer


        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Students");
        }

        protected void addStudentForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Students");
        }//treba li ovo da se komentarise takodje ili brise ili?
    }
}