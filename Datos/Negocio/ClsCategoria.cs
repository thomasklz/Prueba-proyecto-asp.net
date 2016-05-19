using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


 

namespace Negocio
    {
   public class ClsCategoria
        {
         public int _IdCategoria  {get; set;}
         public string _Categoria {get; set;}
         public string _Descripcion  {get; set;}
          
         
       
         pedidosEntities ObjConexionEntity = new pedidosEntities();

         public List<ClsCategoria> ConsultarCategoria()
             {
                List<ClsCategoria> ObjListCateggoria = new List<ClsCategoria>();
                foreach (var item in ObjConexionEntity.SPListarCategoria ())
                    {
                       ObjListCateggoria.Add (new ClsCategoria { _IdCategoria = item.IdCategoria, _Categoria = item.Categoria, _Descripcion = item.Descripcion });
                    }
                return ObjListCateggoria;
             }

         public string  InsertarCategoria (ClsCategoria cate)
             { 
              string mensaje="";
              try
                  {
                    mensaje =ObjConexionEntity.SPIngresarPedido(cate._Categoria,cate._Descripcion).First().ToString();
                  }
              catch (Exception ex)
                  {
                  throw ex;
                  }
              return mensaje ;
             }

         public string ActualizarCategoria (ClsCategoria cate)
             {
             string mensaje = "";
             try
                 {
                 mensaje = ObjConexionEntity.SPActualizarPedido(cate._IdCategoria,cate._Categoria,cate._Descripcion).First ().ToString ();
                 }
             catch (Exception ex)
                 {
                 throw ex;
                 }
             return mensaje;
             }
        }
    }
