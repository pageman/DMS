using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
//../images/Header.png

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblDate.Text = "Date: "+ DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
    }


    protected void btnLogout_Click(object sender, EventArgs e)
    {
       
    }

    void RenderMenuItem(string title, string address, StringBuilder output)
    {
        //output.AppendFormat("<li><a href=\"{0}\" ", address);

        //var requestUrl = HttpContext.Current.Request.Url;        
        //if (requestUrl.Segments[requestUrl.Segments.Length - 1].Equals(address, StringComparison.OrdinalIgnoreCase)) // If the requested address is this menu item.
        //    output.Append("class=\"ActiveMenuButton\"");
        //else
        //    output.Append("class=\"MenuButton\"");

        //output.AppendFormat("><span>{0}</span></a></li>|", title);
    }

}