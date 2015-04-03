using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;

namespace WebApplication1
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            Cal cal = new Cal();
            int inputUSD = 0;
            Cal.CurrencySelect inputSelect = (Cal.CurrencySelect)Enum.Parse(typeof(Cal.CurrencySelect), select.SelectedValue, false);

            int.TryParse(txtUSD.Text, out inputUSD);
            if (inputUSD > 0)
            {
                result.Text = cal.GetResult(inputUSD, inputSelect).ToString();
            }
        }
    }
}