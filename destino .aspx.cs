using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20172578091_2
{
    public partial class destino : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String palabras = Request.Params.Get("Examen");
            listDestino.Items.Add(palabras);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}