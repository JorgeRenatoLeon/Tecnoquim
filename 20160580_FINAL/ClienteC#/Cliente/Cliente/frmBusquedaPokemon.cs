using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class frmBusquedaPokemon : Form
    {
        private Service.pokemon pokemonSeleccionado;
        Service.ServicioClient DBController = new Service.ServicioClient();
        public frmBusquedaPokemon()
        {
            InitializeComponent();
            dgvPokemon.AutoGenerateColumns = false;
            dgvPokemon.DataSource = DBController.listarPokemons("");
        }

        public Service.pokemon PokemonSeleccionado { get => pokemonSeleccionado; set => pokemonSeleccionado = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PokemonSeleccionado = (Service.pokemon)dgvPokemon.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPokemon.DataSource = DBController.listarPokemons(txtNombre.Text);
        }

        private void dgvPokemon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Service.pokemon pokemonFila = (Service.pokemon)dgvPokemon.Rows[e.RowIndex].DataBoundItem;
            dgvPokemon.Rows[e.RowIndex].Cells["NationalPokedexNumber"].Value = pokemonFila.nationalDexNumber;
            dgvPokemon.Rows[e.RowIndex].Cells["Nombre"].Value = pokemonFila.name;
            dgvPokemon.Rows[e.RowIndex].Cells["Tipo1"].Value = pokemonFila.type1.name;
            dgvPokemon.Rows[e.RowIndex].Cells["Tipo2"].Value = pokemonFila.type2.name;
        }
    }
}
