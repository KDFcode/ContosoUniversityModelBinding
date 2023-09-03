using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoUniversityModelBinding.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.ModelBinding;

namespace ContosoUniversityModelBinding
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void studentsGrid_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = new ContosoUniversityModelBinding.BLL.SchoolBL();
        }

        //public IQueryable<Student> studentsGrid_GetData()
        //{
        //    SchoolContext db = new SchoolContext();
        //    var query = db.Students.Include(s => s.Enrollments.Select(e => e.Course));
        //    return query;
        //}


        //nova varijanta po https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/sorting-paging-and-filtering-data
        //konkretno 'Filter records by user selection' deo
        //public IQueryable<Student> studentsGrid_GetData([Control] AcademicYear? displayYear)
        //{
        //    SchoolContext db = new SchoolContext();
        //    var query = db.Students.Include(s => s.Enrollments.Select(e => e.Course));

        //    if (displayYear != null)
        //    {
        //        query = query.Where(s => s.Year == displayYear);
        //    }

        //    return query;
        //} //komentarisemo u skladu sa  https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/adding-business-logic-layer#revise-existing-pages-to-retrieve-data-from-business-logic-layer

        // The id parameter name should match the DataKeyNames value set on the control
        //public void studentsGrid_UpdateItem(int id)
        //{
        //    ContosoUniversityModelBinding.Models.Student item = null;
        //    // Load the item here, e.g. item = MyDataLayer.Find(id);
        //    if (item == null)
        //    {
        //        // The item wasn't found
        //        ModelState.AddModelError("", String.Format("Item with id {0} was not found", id));
        //        return;
        //    }
        //    TryUpdateModel(item);
        //    if (ModelState.IsValid)
        //    {
        //        // Save changes here, e.g. MyDataLayer.SaveChanges();

        //    }
        //}

        //ovo menja ovu gornju verziju u skladu sa 'Enable updating and deleting' sekcijom odavde https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/updating-deleting-and-creating-data
        //public void studentsGrid_UpdateItem(int studentID)
        //{
        //    using (SchoolContext db = new SchoolContext())
        //    {
        //        Student item = null;
        //        item = db.Students.Find(studentID);
        //        if (item == null)
        //        {
        //            ModelState.AddModelError("",
        //              String.Format("Item with id {0} was not found", studentID));
        //            return;
        //        }

        //        TryUpdateModel(item);
        //        if (ModelState.IsValid)
        //        {
        //            db.SaveChanges();
        //        }
        //    }
        //} //komentarisemo u skladu sa  https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/adding-business-logic-layer#revise-existing-pages-to-retrieve-data-from-business-logic-layer


        //public void studentsGrid_DeleteItem(int studentID)
        //{
        //    using (SchoolContext db = new SchoolContext())
        //    {
        //        var item = new Student { StudentID = studentID };
        //        db.Entry(item).State = EntityState.Deleted;
        //        try
        //        {
        //            db.SaveChanges();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            ModelState.AddModelError("",
        //              String.Format("Item with id {0} no longer exists in the database.", studentID));
        //        }
        //    }
        //} //komentarisemo u skladu sa  https://learn.microsoft.com/en-us/aspnet/web-forms/overview/presenting-and-managing-data/model-binding/adding-business-logic-layer#revise-existing-pages-to-retrieve-data-from-business-logic-layer

    }
}