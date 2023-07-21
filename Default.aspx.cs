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
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALObjetos();
        private ItipoMedidoresDAL tipoMedidoresDAL = new tipoMedidoresDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<TipoMedidores> tipoMedidores = tipoMedidoresDAL.ObtenerTipoMedidores();
                this.tipobl.DataSource = tipoMedidores;
                this.tipobl.DataTextField = "Nombre";
                this.tipobl.DataValueField = "Codigo";
                this.tipobl.DataBind();
            }

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
         
            string serie = this.serietxt.Text.Trim();
          
            string tipoValor = this.tipobl.SelectedValue;
       
            string tipoTexto = this.tipobl.SelectedItem.Text;

           

            List<TipoMedidores> tipoMedidores = tipoMedidoresDAL.ObtenerTipoMedidores();
            TipoMedidores tipoMedidor = tipoMedidores.Find(b => b.Codigo == this.tipobl.SelectedItem.Value);

            Medidores medidores = new Medidores()
            {
                Serie = Convert.ToInt32(serie),
                Tipo = tipoMedidor.Nombre
            };

        
            medidoresDAL.AgregarMedidor(medidores);
           
            this.mensajesLbl.Text = "medidore Ingresado";
            Response.Redirect("VerMedidores.aspx");
        }

        protected void tipobl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}