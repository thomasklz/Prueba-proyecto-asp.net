using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion
    {
    public partial class _Default : Page
        {

        ClsCategoria ObjeCategoria = new ClsCategoria ();
        protected void Page_Load (object sender, EventArgs e)
            {
             ListaCategoria ();
            }

        protected void Button1_Click (object sender, EventArgs e)
            {
               string mensaje="";
               mensaje = ObjeCategoria.InsertarCategoria (new ClsCategoria {_Categoria =TextBox1.Text,_Descripcion =TextBox2.Text });
               Label1.Text =mensaje ;
               ListaCategoria ();
            }
        private void ListaCategoria ()
            { 
              GridView1.DataSource=ObjeCategoria.ConsultarCategoria()  ;
              GridView1.DataBind ();
              
            }
        
        }
    }