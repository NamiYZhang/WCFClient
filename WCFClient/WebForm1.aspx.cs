using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFClient.EmployeeReference;

namespace WCFClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            EmployeeReference.EmployeeServiceClient Client = new EmployeeReference.EmployeeServiceClient();
            try
            {
                var result = Client.GetEmployeeById(-1);
            }
            catch (FaultException<ErrorData> ex)
            {
                Response.Write(ex.Detail.ErrorCode + "Oh" + ex.Detail.ErrorDescription + "Error in Finding Id");
                
            }
            

        }
    }
}