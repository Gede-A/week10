//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace week10
//{
//    public partial class _Default : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            // Your code for handling page load events
//        }
//    }
//}
using System;
using System.Web.UI;

namespace week10
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page load logic
        }

        protected void btnSubmitTransport_Click(object sender, EventArgs e)
        {
            // Handle submit button click for transport emissions
        }

        protected void btnSubmitElectricity_Click(object sender, EventArgs e)
        {
            // Handle submit button click for electricity consumption
        }
    }
}

