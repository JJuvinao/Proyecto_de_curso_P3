using BLL;
using Entity;
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
    public partial class VistaConsulPrgRp : MaterialForm
    {

        Preg_Y_RespService respService;
        User usuario;
        CategoriaServives categoriaServives;

        public VistaConsulPrgRp(User user)
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
            this.StartPosition = FormStartPosition.CenterScreen;
            tablapreyres.ForeColor = Color.Black;
            respService = new Preg_Y_RespService();
            categoriaServives = new CategoriaServives();
            usuario = user;
            Mostar();
            tablapreyres.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tablapreyres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tablapreyres.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void materialBtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaUserPersonajes(usuario).ShowDialog();
            this.Close();
        }

        private void materialBtnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new VistaRegistrarPrgRp(usuario).ShowDialog();
            this.Close();
        }

        private void materialBtnCategoria_Click(object sender, EventArgs e)
        {
            string opc_cate = VistaOpcines();
            if (opc_cate != null)
            {
                MostarByCategoria(opc_cate);
            }
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if(tablapreyres.CurrentRow != null)
            {
                DataGridViewRow filaSeleccionada = tablapreyres.CurrentRow;
                int id = int.Parse(filaSeleccionada.Cells[0].Value.ToString());
                Buscar(id);
                Mostar();
            }
        }


        #region METODOS

        private void Mostar()
        {
            tablapreyres.DataSource = respService.Gettabla();
        }

        private void MostarByCategoria(string id_cate)
        {
            tablapreyres.DataSource = respService.GettablaCategoria(id_cate);
        }

        private void Buscar(int id)
        {
            string msg = respService.Delete(id);
            MessageBox.Show(msg);
        }

        private string VistaOpcines()
        {
            Form form = new Form
            {
                Text = "Selecciona una opción",
                Width = 300,
                Height = 100
            };
            form.StartPosition = FormStartPosition.CenterScreen;

            ComboBox boxcategoria = new ComboBox { Dock = DockStyle.Top };
            boxcategoria.DataSource = categoriaServives.GetAll();
            boxcategoria.DisplayMember = "Nombre";
            boxcategoria.ValueMember = "Id_Categoria";


            Button btAceptar = new Button
            {
                Text = "Aceptar",
                Dock = DockStyle.Bottom,
                DialogResult = DialogResult.OK
            };

            form.Controls.Add(boxcategoria);
            form.Controls.Add(btAceptar);

            if (form.ShowDialog() == DialogResult.OK)
            {
                return boxcategoria.SelectedValue.ToString();
            }

            return null;
        }

        #endregion
    }
}
