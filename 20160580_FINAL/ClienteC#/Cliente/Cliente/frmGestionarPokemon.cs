using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmGestionarPokemon : Form
    {
        private String ruta;
        private Service.pokemon pokemon;
        private Service.levelUpMove movimiento;
        private BindingList<Service.levelUpMove> moves;
        private Estado estadoObjeto;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmGestionarPokemon()
        {
            InitializeComponent();
            dgvLevelUpMoves.AutoGenerateColumns = false;
            cboTipo1.DataSource = DBController.listarTodosTipos();
            cboTipo1.DisplayMember = "name";
            cboTipo2.DataSource = DBController.listarTodosTipos();
            cboTipo2.DisplayMember = "name";
            pokemon = new Service.pokemon();
            movimiento = new Service.levelUpMove();
            moves = new BindingList<Service.levelUpMove>();
            estadoComponentes(Estado.Inicial);
            limpiarComponentes();
        }

        public void estadoComponentes(Estado estado)
        {
            switch (estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtNro.Enabled = false;
                    txtNombre.Enabled = false;
                    cboTipo1.Enabled = false;
                    cboTipo2.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPeso.Enabled = false;
                    txtAltura.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnRemover.Enabled = false;
                    dgvLevelUpMoves.Enabled = false;
                    lblNro.Enabled = false;
                    lblNombre.Enabled = false;
                    lblPeso.Enabled = false;
                    lblAltura.Enabled = false;
                    lblKg.Enabled = false;
                    lblMetros.Enabled = false;
                    lblDescripcion.Enabled = false;
                    lblLevelUpMoves.Enabled = false;
                    lblTipo1.Enabled = false;
                    lblTipo2.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNro.Enabled = true;
                    txtNombre.Enabled = true;
                    cboTipo1.Enabled = true;
                    cboTipo2.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtPeso.Enabled = true;
                    txtAltura.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    btnAgregar.Enabled = true;
                    btnRemover.Enabled = true;
                    dgvLevelUpMoves.Enabled = true;
                    lblNro.Enabled = true;
                    lblNombre.Enabled = true;
                    lblPeso.Enabled = true;
                    lblAltura.Enabled = true;
                    lblKg.Enabled = true;
                    lblMetros.Enabled = true;
                    lblDescripcion.Enabled = true;
                    lblLevelUpMoves.Enabled = true;
                    lblTipo1.Enabled = true;
                    lblTipo2.Enabled = true;
                    break;
                case Estado.Modificar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtNro.Enabled = false;
                    txtNombre.Enabled = false;
                    cboTipo1.Enabled = false;
                    cboTipo2.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtPeso.Enabled = false;
                    txtAltura.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnRemover.Enabled = false;
                    dgvLevelUpMoves.Enabled = false;
                    lblNro.Enabled = false;
                    lblNombre.Enabled = false;
                    lblPeso.Enabled = false;
                    lblAltura.Enabled = false;
                    lblKg.Enabled = false;
                    lblMetros.Enabled = false;
                    lblDescripcion.Enabled = false;
                    lblLevelUpMoves.Enabled = false;
                    lblTipo1.Enabled = false;
                    lblTipo2.Enabled = false;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPokemon formBusquedaPokemon = new frmBusquedaPokemon();
            if (DialogResult.OK == formBusquedaPokemon.ShowDialog())
            {
                pokemon = formBusquedaPokemon.PokemonSeleccionado;
                txtNro.Text = pokemon.nationalDexNumber;
                txtNombre.Text = pokemon.name;
                cboTipo1.SelectedIndex = cboTipo1.FindStringExact(pokemon.type1.name.ToString());
                cboTipo2.SelectedIndex = cboTipo1.FindStringExact(pokemon.type2.name.ToString());
                MemoryStream ms1 = new MemoryStream(pokemon.photo);
                pbFoto.Image = new Bitmap(ms1);
                txtDescripcion.Text = pokemon.description;
                txtPeso.Text = pokemon.weight.ToString();
                txtAltura.Text = pokemon.height.ToString();
                moves = new BindingList<Service.levelUpMove>(pokemon.levelUpMoves);
                dgvLevelUpMoves.DataSource = pokemon.levelUpMoves;
                estadoComponentes(Estado.Modificar);
            }
        }

        public void limpiarComponentes()
        {
            ruta = null;
            txtNro.Text = "";
            txtNombre.Text = "";
            txtAltura.Text = "";
            txtDescripcion.Text = "";
            txtPeso.Text = "";
            pbFoto.Image = null;
            cboTipo1.SelectedIndex = -1;
            cboTipo2.SelectedIndex = -1;
            pbFoto.Image = null;
            dgvLevelUpMoves.DataSource = null;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estadoObjeto = Estado.Nuevo;
            limpiarComponentes();
            estadoComponentes(Estado.Nuevo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void lblNationalPokedex_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmRegistrarMovimiento formRegistrarMovimiento = new frmRegistrarMovimiento();
            if(formRegistrarMovimiento.ShowDialog() == DialogResult.OK)
            {
                movimiento = formRegistrarMovimiento.MovimientoSeleccionado;
                BindingList<Service.levelUpMove> lineasAd = new BindingList<Service.levelUpMove>();
                foreach (Service.levelUpMove item in moves)
                {
                    lineasAd.Add(item);
                }
                lineasAd.Add(movimiento);
                moves = lineasAd;
                pokemon.levelUpMoves = moves.ToArray();
                dgvLevelUpMoves.DataSource = moves;
            }
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dialogoBusqArchivo.ShowDialog() == DialogResult.OK)
                {
                    ruta = dialogoBusqArchivo.FileName;
                    pbFoto.Image = Image.FromFile(ruta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            pokemon.photo = br.ReadBytes((int)fs.Length);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            pokemon.nationalDexNumber = txtNro.Text;
            pokemon.name = txtNombre.Text;
            pokemon.type1 = (Service.type)cboTipo1.SelectedValue;
            pokemon.type2 = (Service.type)cboTipo2.SelectedValue;
            pokemon.description = txtDescripcion.Text;
            pokemon.height = double.Parse(txtAltura.Text);
            pokemon.weight = double.Parse(txtPeso.Text);
            if (estadoObjeto == Estado.Nuevo)
            {
                DBController.insertarPokemon(pokemon);
                MessageBox.Show("Se ha registrado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (estadoObjeto == Estado.Modificar)
            {
                DBController.modificarPokemon(pokemon);
                MessageBox.Show("Se ha modificado con exito", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            estadoComponentes(Estado.Inicial);
            limpiarComponentes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            estadoObjeto = Estado.Modificar;
            estadoComponentes(Estado.Nuevo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Mensaje de Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DBController.eliminarPokemon(pokemon.idPokemon);
                MessageBox.Show("El registro ha sido eliminado.", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarComponentes();
            estadoComponentes(Estado.Inicial);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string str = dgvLevelUpMoves.Rows[dgvLevelUpMoves.SelectedRows[0].Index].Cells[1].Value.ToString();

            BindingList<Service.levelUpMove> lineasElim = new BindingList<Service.levelUpMove>();
            foreach (Service.levelUpMove item in moves)
            {
                if (item.moveName != str) lineasElim.Add(item);
            }
            moves = lineasElim;
            pokemon.levelUpMoves = lineasElim.ToArray();
            dgvLevelUpMoves.DataSource = moves;
        }

        private void cboTipo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service.type tipoSelec = (Service.type)cboTipo1.SelectedValue;
            if (tipoSelec == null) return;
            Color c = Color.FromArgb(tipoSelec.redValue,tipoSelec.greenValue,tipoSelec.blueValue);
            panelTipo1.BackColor = c;
        }

        private void cboTipo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Service.type tipoSelec = (Service.type)cboTipo2.SelectedValue;
            if (tipoSelec == null) return;
            Color c = Color.FromArgb(tipoSelec.redValue, tipoSelec.greenValue, tipoSelec.blueValue);
            panelTipo2.BackColor = c;
        }

        private void dgvPokemon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.levelUpMove pokemonFila = (Service.levelUpMove)dgvLevelUpMoves.Rows[e.RowIndex].DataBoundItem;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["LV"].Value = pokemonFila.levelOfLearning;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["NOMBRE"].Value = pokemonFila.moveName;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["TIPO"].Value = pokemonFila.type.name;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["CAT"].Value = pokemonFila.kind.movementKind;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["POW"].Value = pokemonFila.power;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["ACC"].Value = pokemonFila.accuracy;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["PP"].Value = pokemonFila.powerPoint;
            dgvLevelUpMoves.Rows[e.RowIndex].Cells["RANGO"].Value = pokemonFila.range.movementRange;
        }
    }
}
