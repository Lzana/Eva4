using M.InteligenteModel.DAL;
using M.InteligenteModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace M.Inteligente
{
    public partial class VerMedidores : System.Web.UI.Page { 

        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
   
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                cargagrilla();
            }

        }

        protected void cargagrilla()
        {
            List<Medidores> medidores = medidoresDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }

        

    }
}