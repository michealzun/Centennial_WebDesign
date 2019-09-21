﻿//yueyang(micheal) sun 300933625
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Clubs : System.Web.UI.Page
{
    protected void Page_PreInit(object sender, EventArgs e)
    {
        HttpCookie theme = Request.Cookies["theme"];
        if (theme == null)
        {
            Page.Theme = "Dark";
        }
        else { Page.Theme = theme.Value; }
    }

    protected void ClubItemCommand(object o, DataListCommandEventArgs e)
    {
        if (e.CommandName == "ViewDetail")
        {
            Session["SelectedClub"] = e.CommandArgument;
            Response.Redirect("ClubDetails.aspx");
        }
    }
}
//yueyang(micheal) sun 300933625