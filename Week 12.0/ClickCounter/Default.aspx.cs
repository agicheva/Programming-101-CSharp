using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClickCounter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Session["clickerName"] = TextBoxForName.Text;
            int numberOfClicks;
            if (Application[TextBoxForName.Text] == null)
            {
                numberOfClicks = 0;
            }

            else
            {
                numberOfClicks = (int)Application[TextBoxForName.Text];
            }
            Application[TextBoxForName.Text] = numberOfClicks;
            Response.Redirect("ClickCounter.aspx");
        }
    }
}