using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Practica04_Login
{
    public partial class pokedex : Form
    {
        private PokedexConexion PokeConexion;
        private PictureBox[] pokemonPictureBoxes;

        public pokedex()
        {
            InitializeComponent();
            PokeConexion = new PokedexConexion();
            InitializePokemonPictureBoxes();
        }

        private void InitializePokemonPictureBoxes()
        {
            // Assuming the PictureBoxes are in a Panel and named systematically
            // Adjust this based on your actual panel and PictureBox naming
            pokemonPictureBoxes = new PictureBox[50];
            for (int i = 0; i < 50; i++)
            {
                // Find the PictureBox with a systematic name, e.g., "pictureBox1", "pictureBox2", etc.
                pokemonPictureBoxes[i] = (PictureBox)this.Controls.Find($"pictureBox{i + 1}", true)[0];

                // Add click event to each PictureBox
                pokemonPictureBoxes[i].Click += PokemonPictureBox_Click;
            }
        }

        private void PokemonPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = (PictureBox)sender;
            string pokemonName = GetPokemonNameFromPictureBox(clickedPictureBox);

            if (!string.IsNullOrEmpty(pokemonName))
            {
                UpdatePokemonDetails(pokemonName);
            }
        }

        private string GetPokemonNameFromPictureBox(PictureBox pictureBox)
        {
            // You'll need to map the PictureBox to the corresponding Pokemon name
            // This is a placeholder method - you'll need to implement the actual mapping
            // For example, you might have a dictionary or a method to determine the name
            switch (pictureBox.Name)
            {
                case "pictureBox1": return "Bulbasaur";
                case "pictureBox2": return "Ivysaur";
                case "pictureBox3": return "Venusaur";
                case "pictureBox4": return "Charmander";
                case "pictureBox5": return "Charmeleon";
                case "pictureBox6": return "Charizard";
                case "pictureBox7": return "Squirtle";
                case "pictureBox8": return "Wartortle";
                case "pictureBox9": return "Blastoise";
                case "pictureBox10": return "Caterpie";
                case "pictureBox11": return "Weedle";
                case "pictureBox12": return "Butterfree";
                case "pictureBox13": return "Metapod";
                case "pictureBox14": return "Kakuna";
                case "pictureBox15": return "Beedrill";
                case "pictureBox16": return "Pidgey";
                case "pictureBox17": return "Pidgeotto";
                case "pictureBox18": return "Pidgeot";
                case "pictureBox19": return "Rattata";
                case "pictureBox20": return "Raticate";
                case "pictureBox21": return "Spearow";
                case "pictureBox22": return "Fearow";
                case "pictureBox23": return "Ekans";
                case "pictureBox24": return "Arbok";
                case "pictureBox25": return "Pikachu";
                case "pictureBox26": return "Raichu";
                case "pictureBox27": return "Sandshrew";
                case "pictureBox28": return "Sandslash";
                case "pictureBox29": return "Nidoran♀";
                case "pictureBox30": return "Nidorina";
                case "pictureBox31": return "Nidoqueen";
                case "pictureBox32": return "Nidoran♂";
                case "pictureBox33": return "Nidorino";
                case "pictureBox34": return "Nidoking";
                case "pictureBox35": return "Clefairy";
                case "pictureBox36": return "Clefable";
                case "pictureBox37": return "Vulpix";
                case "pictureBox38": return "Ninetales";
                case "pictureBox39": return "Jigglypuff";
                case "pictureBox40": return "Wigglytuff";
                case "pictureBox41": return "Zubat";
                case "pictureBox42": return "Golbat";
                case "pictureBox43": return "Oddish";
                case "pictureBox44": return "Gloom";
                case "pictureBox45": return "Vileplume";
                case "pictureBox46": return "Paras";
                case "pictureBox47": return "Parasect";
                case "pictureBox48": return "Venonat";
                case "pictureBox49": return "Venomoth";
                case "pictureBox50": return "Diglett";
                // Add more mappings for all 50 Pokemon
                default: return null;
            }
        }

        private Dictionary<string, Color> GetTypeColors()
        {
            return new Dictionary<string, Color>(StringComparer.OrdinalIgnoreCase)
    {
        { "Volador", Color.LightSkyBlue },
        { "Veneno", Color.MediumPurple },
        { "Tierra", Color.SaddleBrown },
        { "Planta", Color.LimeGreen },
        { "Normal", Color.LightGray },
        { "Hada", Color.Pink },
        { "Fuego", Color.Orange },
        { "Electrico", Color.Gold },
        { "Bicho", Color.DarkOliveGreen },
        { "Agua", Color.DeepSkyBlue },
        { "Roca", Color.SandyBrown },
        { "Psiquico", Color.HotPink },
        { "Hielo", Color.LightCyan },
        { "Dragon", Color.MediumPurple },
        { "Fantasma", Color.MidnightBlue },
        { "Lucha", Color.Chocolate },
        { "Acero", Color.Silver }
    };
        }

        private void UpdatePokemonTypes(string pokemonName)
        {
            try
            {
                var typeColors = GetTypeColors();

                using (MySqlConnection connection = PokeConexion.getConexion())
                {
                    string query = @"
                SELECT t.TipoNombre
                FROM pokemon_tipos t
                WHERE t.PokemonNombre = @PokemonName";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PokemonName", pokemonName);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Reset type pictureboxes
                            pbTipoPokemon.Image = null;
                            pbTipoPokemon2.Image = null;
                            pbTipoPokemon.BackColor = Color.Transparent;
                            pbTipoPokemon2.BackColor = Color.Transparent;

                            List<string> tipos = new List<string>();
                            while (reader.Read())
                            {
                                tipos.Add(reader["TipoNombre"].ToString());
                            }

                            // Update type images and backgrounds
                            if (tipos.Count > 0)
                            {
                                pbTipoPokemon.Image = GetTypeImage(tipos[0]);
                                if (typeColors.TryGetValue(tipos[0], out Color color1))
                                {
                                    pbTipoPokemon.BackColor = color1;
                                }
                            }
                            if (tipos.Count > 1)
                            {
                                pbTipoPokemon2.Image = GetTypeImage(tipos[1]);
                                if (typeColors.TryGetValue(tipos[1], out Color color2))
                                {
                                    pbTipoPokemon2.BackColor = color2;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recuperando tipos del Pokemon: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image GetTypeImage(string typeName)
        {
            try
            {
                // Usar Path.Combine para rutas de archivos multiplataforma
                string imagePath = Path.Combine(Application.StartupPath, "Resources", $"{typeName.ToLower()}.png");

                if (File.Exists(imagePath))
                {
                    // Cargar la imagen usando FileStream para evitar bloqueos
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        return Image.FromStream(fs);
                    }
                }
                else
                {
                    MessageBox.Show($"Imagen de tipo no encontrada: {imagePath}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando imagen de tipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void UpdatePokemonDetails(string pokemonName)
        {
            try
            {
                // Cada vez que entras a este bloque, se crea y abre una nueva conexión
                using (MySqlConnection connection = PokeConexion.getConexion())
                {
                    string query = @"
                SELECT p.ID, p.Nombre, p.Descripcion, p.Altura, p.Peso, 
                       GROUP_CONCAT(DISTINCT t.TipoNombre) AS Tipos,
                       GROUP_CONCAT(DISTINCT 
                           CASE WHEN ph.EsOculta = 0 THEN ph.HabilidadNombre 
                                WHEN ph.EsOculta = 1 THEN CONCAT(ph.HabilidadNombre, ' (Oculta)')
                           END) AS Habilidades
                FROM pokemon p
                LEFT JOIN pokemon_tipos t ON p.Nombre = t.PokemonNombre
                LEFT JOIN pokemon_habilidades ph ON p.Nombre = ph.PokemonNombre
                WHERE p.Nombre = @PokemonName
                GROUP BY p.ID, p.Nombre, p.Altura, p.Peso";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PokemonName", pokemonName);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Update labels
                                lblNum.Text = reader["ID"].ToString() ?? "---";
                                lblNombre.Text = reader["Nombre"].ToString() ?? "---";
                                lblDescripcion.Text = reader["Descripcion"].ToString() ?? "---";
                                lblAltura.Text = reader["Altura"].ToString() ?? "---";
                                lblPeso.Text = reader["Peso"].ToString() ?? "---";

                                // Types
                                string[] tipos = (reader["Tipos"] as string ?? "---").Split(',');
                                lblTipo1.Text = tipos.Length > 0 ? tipos[0] : "---";
                                lblTipo2.Text = tipos.Length > 1 ? tipos[1] : "---";

                                // Abilities
                                string[] habilidades = (reader["Habilidades"] as string ?? "---").Split(',');
                                lblHabilidad.Text = habilidades.Length > 2 ? habilidades[2] : "---";
                                lblHabilidad2.Text = habilidades.Length > 1 ? habilidades[1] : "---";
                                lblHabilidadOculta.Text = habilidades.Length > 0 ? habilidades[0] : "---";

                                // Update image
                                pbImagenGrande.Image = GetPokemonImage(pokemonName);
                                pbImagenGrande.Visible = true;

                                // Update type images
                                UpdatePokemonTypes(pokemonName);
                            }
                        }
                    }
                } // Aquí se cierra la conexión automáticamente al salir del using
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recuperando detalles del Pokemon: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Image GetPokemonImage(string pokemonName)
        {
            try
            {
                // Usar Path.Combine para rutas de archivos multiplataforma
                string imagePath = Path.Combine(Application.StartupPath, "Resources", $"{pokemonName.ToLower()}.png");

                if (File.Exists(imagePath))
                {
                    // Cargar la imagen usando FileStream para evitar bloqueos
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        return Image.FromStream(fs);
                    }
                }
                else
                {
                    MessageBox.Show($"Imagen no encontrada: {imagePath}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}