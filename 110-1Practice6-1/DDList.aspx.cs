using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice6_1 {
    public partial class DDList : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (IsPostBack == false)
            {
                ListItem O_Li = new ListItem("北區", "北區");
                ddl_Area.Items.Add(O_Li);

                O_Li = new ListItem("中區", "中區");
                ddl_Area.Items.Add(O_Li);

                O_Li = new ListItem("基隆", "基隆");
                ddl_Place.Items.Add(O_Li);

                O_Li = new ListItem("台北", "台北");
                ddl_Place.Items.Add(O_Li);

                O_Li = new ListItem("新北", "新北");
                ddl_Place.Items.Add(O_Li);
            }
            

        }

        protected void ddl_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddl_Place.Items.Clear();
            ListItem O_Li;
            if (ddl_Area.SelectedValue == "北區")
            {
                O_Li = new ListItem("基隆", "基隆");
                ddl_Place.Items.Add(O_Li);

                O_Li = new ListItem("台北", "台北");
                ddl_Place.Items.Add(O_Li);

                O_Li = new ListItem("新北", "新北");
                ddl_Place.Items.Add(O_Li);
            }
            else
            {
                O_Li = new ListItem("苗栗", "苗栗");
                ddl_Place.Items.Add(O_Li);

                O_Li = new ListItem("台中", "台中");
                ddl_Place.Items.Add(O_Li);

                O_Li = new ListItem("南投", "南頭");
                ddl_Place.Items.Add(O_Li);
            }
        }
    }
}