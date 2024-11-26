using BLL;
using Entity;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class VistaRegistrarPrgRp : MaterialForm
    {
        Preg_Y_RespService respService;
        CategoriaServives categoriaServives;
        User usuario;
        public VistaRegistrarPrgRp(User user)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
            usuario = user;
            this.StartPosition = FormStartPosition.CenterScreen;
            respService = new Preg_Y_RespService();
            categoriaServives = new CategoriaServives();
            LLenarCombobox();
        }

        private void materialBtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaConsulPrgRp(usuario).ShowDialog();
            this.Close();
        }

        private void Btregistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpregunta.Text) && !string.IsNullOrEmpty(txtrespuesta.Text) && ValidarBox())
            {
                int id = respService.Number();
                GuardarPreguntayRespuesta(new Preg_Y_Resp(id, txtpregunta.Text, txtrespuesta.Text, boxcategoria.SelectedValue.ToString()));
                RegistrarRespuesta_Falsa(id);
                this.Hide();
                new VistaConsulPrgRp(usuario).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
        }

        #region METODOS

        private bool ValidarBox()
        {
            string[] categorias = { "MATEMATICAS", "ESPAÑOL", "BIOLOGIA" };
            if (categorias.Contains(boxcategoria.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GuardarPreguntayRespuesta(Preg_Y_Resp preg_Y_Resp)
        {
            var msg = respService.SaveData(preg_Y_Resp);
            MessageBox.Show(msg);
        }

        private void GuardarRespuestasFalsas(Respuestas_falsas respuesta)
        {
            var msg = respService.SaveRespuestas(respuesta);
            MessageBox.Show(msg);
        }

        private void RegistrarRespuesta_Falsa(int id)
        {
            if (txtrespuestaf1.Text != null)
            {
                GuardarRespuestasFalsas(new Respuestas_falsas(respService.Number_Falsa(), txtrespuestaf1.Text, boxcategoria.SelectedValue.ToString(),id));
            }
            if (txtrespuestaf2.Text != null)
            {
                GuardarRespuestasFalsas(new Respuestas_falsas(respService.Number_Falsa(), txtrespuestaf2.Text, boxcategoria.SelectedValue.ToString(), id));
            }
            if (txtrespuestaf3.Text != null)
            {
                GuardarRespuestasFalsas(new Respuestas_falsas(respService.Number_Falsa(), txtrespuestaf3.Text, boxcategoria.SelectedValue.ToString(), id));
            }
        }

        private void LLenarCombobox()
        {
            boxcategoria.DataSource = categoriaServives.GetAll();
            boxcategoria.DisplayMember = "Nombre";
            boxcategoria.ValueMember = "Id_Categoria";
        }

        #endregion
    }
}
