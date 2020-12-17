using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20172578091_2
{
    public partial class Examen : System.Web.UI.Page
    {
        public static String palabras;        
        public static String ordenar;
        public static int tamanio = 0, pos = 0;
        public static String palabras2;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void chbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        protected void listFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnOrigen_Click(object sender, EventArgs e)
        {
            //listFiltro.SelectionMode = ListSelectionMode.Multiple;
            listFiltro.Items.Clear();


            /* String palabras;
             String ordenar;
             int tamanio = 0, pos = 0;
             String palabras2;
            */
            /*String[] invertido = oracioninvertida.Split(' ');


            Array.Sort(invertido);*/


            foreach (ListItem dato in chbPaises.Items)
            {
                palabras = dato.ToString();
                if (dato.Selected)
                {
                    tamanio = palabras.Length;
                    if (palabras.ToLower().Contains('r') || palabras.ToLower().Contains('R'))
                    {

                    }
                    else
                    {
                        palabras2 = new string(palabras.Reverse().ToArray());
                        listFiltro.Items.Add(palabras2);
                    }

                   /* pos = tamanio - 2;
                    if (palabras.ToLower().Contains("en") || palabras.ToLower().Contains("EN"))
                    {
                        listFiltro.Items.Add(palabras);

                        //<>
                    }
                    if (tamanio > 1 && palabras[pos] == 'i' && palabras[pos + 1] == 'a')
                    {
                        listFiltro.Items.Add(palabras);
                    }*/


                }

            }
        }

        protected void btnDestino_Click(object sender, EventArgs e)
        {
            //   Response.Redirect("destino.aspx?pamaretro"+)


            //listFiltro.SelectionMode = ListSelectionMode.Multiple;
            listFiltro.Items.Clear();


            /* String palabras;
             String ordenar;
             int tamanio = 0, pos = 0;
             String palabras2;
            */
            /*String[] invertido = oracioninvertida.Split(' ');


            Array.Sort(invertido);*/


            foreach (ListItem dato in chbPaises.Items)
            {
                palabras = dato.ToString();
                if (dato.Selected)
                {
                    tamanio = palabras.Length;
                    /*if (palabras.ToLower().Contains('r') || palabras.ToLower().Contains('R'))
                    {

                    }
                    else
                    {
                        palabras2 = new string(palabras.Reverse().ToArray());
                        listFiltro.Items.Add(palabras2);
                    }*/

                     pos = tamanio - 2;
                     if (palabras.ToLower().Contains("en") || palabras.ToLower().Contains("EN"))
                     {
                        Response.Redirect("Destino.aspx?Examen=" + palabras);
                        //listFiltro.Items.Add(palabras);

                         //<>
                     }
                     if (tamanio > 1 && palabras[pos] == 'i' && palabras[pos + 1] == 'a')
                     {
                        Response.Redirect("Destino.aspx?Examen=" + palabras);
                        //listFiltro.Items.Add(palabras);
                     } 


                }

            }            
        }
    }
}