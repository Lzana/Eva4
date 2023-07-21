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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private ILecturaDal lecturaDal = new LecturaDAlObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                List<Lectura> lectura = lecturaDal.ObtenerLecturas();
                this.tipobl.DataSource = tipoMedidores;
                this.tipobl.DataTextField = "Nombre";
                this.tipobl.DataValueField = "Codigo";
                this.tipobl.DataBind();
            }

        }
    }
}