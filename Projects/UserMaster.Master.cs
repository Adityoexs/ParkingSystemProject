﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartParkingSystemProject.Projects
{
    public partial class UserMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnParking_Click(object sender,EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}