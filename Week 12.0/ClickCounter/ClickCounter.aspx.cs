using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickCounter
{
    public partial class ClickCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ButtonClicker_Click(object sender, EventArgs e)
        {
            Application[(string)Session["clickerName"]] = (int)Application[(string)Session["clickerName"]] + 1;
        }
    }
}