using BLL;
using Entity;
using IGU;
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

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Yellow800,
                MaterialSkin.Primary.Yellow900,
                MaterialSkin.Primary.Green600,
                MaterialSkin.Accent.LightGreen200,
                MaterialSkin.TextShade.WHITE
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
                Guardar(new Preg_Y_Resp(respService.Number(), txtpregunta.Text, txtrespuesta.Text, boxcategoria.SelectedValue.ToString()));
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

        private void Guardar(Preg_Y_Resp preg_Y_Resp)
        {
            var msg = respService.SaveData(preg_Y_Resp);
            MessageBox.Show(msg);
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
