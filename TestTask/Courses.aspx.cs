using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestTask.Models;
using System.Web.ModelBinding;
using System.Data.Entity;

public partial class Courses : System.Web.UI.Page
{

    public IQueryable<Enrollment> coursesGrid_GetData([QueryString] int? studentID)
    {
        SchoolContext db = new SchoolContext();
        var query = db.Enrollments.Include(e => e.Course)
            .Where(e => e.StudentID == studentID);
        return query;
    }
}
