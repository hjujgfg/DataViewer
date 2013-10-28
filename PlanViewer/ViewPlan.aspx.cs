using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlanViewer.Models;
namespace PlanViewer
{
    public partial class ViewPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            viewPlan();
        }
        
        protected void PlansDataSource_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            
        }        
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewPlan();
        }
        private void viewPlan()
        {
            int planindex;
            try
            {
                planindex = (int)Char.GetNumericValue(DropDownList1.SelectedValue[0]);
            }
            catch (IndexOutOfRangeException)
            {
                planindex = 1;
            }
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(' index = " + planindex + "');", true);
            try
            {
                var db = new DBClassesDataContext();
                IQueryable<Plan> plans = db.Plans;
                IQueryable<Contractor> contrs = db.Contractors;
                IQueryable<Customer> custs = db.Customers;
                plans = plans.Where(p => p.ID == planindex);
                Plan[] res = plans.ToArray<Plan>();
                contrs = contrs.Where(p => p.ID == res[0].Contractor);
                Contractor[] contr = contrs.ToArray<Contractor>();
                custs = custs.Where(p => p.ID == res[0].Customer);
                Customer[] cust = custs.ToArray<Customer>();
                Table1.Rows[1].Cells[0].Text = res[0].ID.ToString();
                Table1.Rows[1].Cells[1].Text = cust[0].Name.ToString();
                Table1.Rows[1].Cells[2].Text = contr[0].Name.ToString();
                Table1.Rows[1].Cells[3].Text = res[0].Object.ToString();
                Table1.Rows[1].Cells[4].Text = res[0].WorkType.ToString();
                Table1.Rows[1].Cells[5].Text = res[0].CostName.ToString();
                Table1.Rows[1].Cells[6].Text = res[0].UnitName.ToString();
                Table1.Rows[1].Cells[7].Text = res[0].Labor.ToString();
                Table1.Rows[1].Cells[8].Text = res[0].Materials.ToString();
                Table1.Rows[1].Cells[9].Text = res[0].Mechnisms.ToString();
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "нет записи", true);
            }
        }
    }
}