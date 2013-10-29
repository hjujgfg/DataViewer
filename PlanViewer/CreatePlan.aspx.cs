﻿using System;
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
            if (workObject.Text == "" || typeOfWork.Text == "" || nameOfCost.Text == ""
                || measure.Text == "" || labour.Text == "" || materials.Text == "" || mechanisms.Text == "" ||
                contractor.Text == "" || customer.Text == "")
            {
                Alert.Show("Пожалуйста заполните все поля");
                return;
            }
            var db = new DBClassesDataContext();            
            Plan p = new Plan {  Status = 3, Object = workObject.Text, WorkType = typeOfWork.Text, 
                CostName = nameOfCost.Text, UnitName = measure.Text, Labor = labour.Text, 
                Materials = materials.Text, Mechnisms = mechanisms.Text,
            };
            
            db.Plans.InsertOnSubmit(p);
            try 
            { 
                db.SubmitChanges();
                Alert.Show("Запись успешно добавлена");
            }
            catch 
            { 
                ClientScript.RegisterStartupScript(this.GetType(), "Ошибка", "нет записи", true); 
            }
            
        }
    }
    public static class Alert
    {

    /// <summary>
    /// Shows a client-side JavaScript alert in the browser.
    /// </summary>
    /// <param name="message">The message to appear in the alert.</param>
    public static void Show(string message)
    {
       // Cleans the message to allow single quotation marks
       string cleanMessage = message.Replace("'", "\\'");
       string script ="<script type=\"text/javascript\">alert('"+ cleanMessage +"');</script>";

       // Gets the executing web page
       Page page = HttpContext.Current.CurrentHandler as Page;

       // Checks if the handler is a Page and that the script isn't allready on the Page
       if (page !=null && !page.ClientScript.IsClientScriptBlockRegistered("alert"))
       {
          page.ClientScript.RegisterClientScriptBlock(typeof(Alert), "alert", script);
       }
    }    
}
}