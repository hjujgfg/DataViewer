using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlanViewer.Models;
namespace PlanViewer
{
    public partial class createPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            
            var db = new DBClassesDataContext();
            
            Plan p = new Plan { ID = 2, Status = 3, Object = workObject.Text, WorkType = typeOfWork.Text, UnitName = nameOfCost.Text, Labor = labour.Text, Materials = materials.Text, Mechnisms = mechanisms.Text };
            
            db.Plans.InsertOnSubmit(p);
            try 
            { 
                db.SubmitChanges(); 
            }
            catch 
            { 
                ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "нет записи", true); 
            }
            // workObject.Text
            // typeOfWork.Text
            // nameOfCost.Text
            //measure.Text
            // labour.Text
            // materials.Text
        }
    }
}