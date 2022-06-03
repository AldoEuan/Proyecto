using System;
using System.Drawing;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Proyecto_TAP.Model;
using System.Collections.Generic;

namespace Proyecto_TAP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "4YnhWJt85ZSs7tMBAIQI6jcFcSUKxCy6la4sPI90",
            BasePath = "https://consultas-af1bb-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private async void GetListCites()
        {
            FirebaseResponse res = await client.GetAsync("Citas/");
            Dictionary<string, Cita> data = res.ResultAs<Dictionary<string, Cita>>();

            foreach (var item in data)
            {
                Console.WriteLine(item.Value.Nombre);
                dataGridViewtabla.Rows.Add(
                    item.Value.Turno,
                    item.Value.Nombre,
                    item.Value.Edad,
                    item.Value.Telefono,
                    item.Value.Hora,
                    item.Value.Fecha
                );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
                GetListCites();
            }
            catch
            {
                MessageBox.Show("there was problem in the internet.");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            var ct = new Cita()
            {
                Turno = text_turno.Text,
                Nombre = text_nombre.Text,
                Edad = text_edad.Text,
                Telefono = text_telefono.Text,
                Hora = text_hora.Text,
                Fecha = text_fecha.Text
            };

            FirebaseResponse res = client.Update("Citas/" + ct.Turno, ct);
            MessageBox.Show("Datos Actualizados");
            dataGridViewtabla.DataSource = null;
            dataGridViewtabla.Rows.Clear();
            GetListCites();
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            Cita ct = new Cita()
            {
                Turno = text_turno.Text,
                Nombre = text_nombre.Text,
                Edad = text_edad.Text,
                Telefono = text_telefono.Text,
                Hora = text_hora.Text,
                Fecha = text_fecha.Text
            };

            FirebaseResponse res = client.Set("Citas/"+ct.Turno, ct);
            
            MessageBox.Show("Datos Guardados");

            dataGridViewtabla.DataSource = null;
            dataGridViewtabla.Rows.Clear();
            GetListCites();
            cleanTextBox();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = client.Delete("Citas/" + text_turno.Text);
            MessageBox.Show("Turno Borrado");
            dataGridViewtabla.DataSource = null;
            dataGridViewtabla.Rows.Clear();
            GetListCites();
            cleanTextBox();
        }

        private void dataGridViewtabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string turno = (string)dataGridViewtabla.SelectedRows[0].Cells[0].Value;
                string nombre = (string)dataGridViewtabla.SelectedRows[0].Cells[1].Value;
                string edad = (string)dataGridViewtabla.SelectedRows[0].Cells[2].Value;
                string telefono = (string)dataGridViewtabla.SelectedRows[0].Cells[3].Value;
                string hora = (string)dataGridViewtabla.SelectedRows[0].Cells[4].Value;
                string fecha = (string)dataGridViewtabla.SelectedRows[0].Cells[5].Value;

                setDataTextBox(turno, nombre, edad, telefono, hora, fecha);
            }
            catch (Exception)
            {
                return;
            }
        }

        void setDataTextBox (string turno, string nombre, string edad, string telefono, string hora, string fecha)
        {
            text_turno.Text = turno;
            text_nombre.Text = nombre;
            text_edad.Text = edad;
            text_telefono.Text = telefono;
            text_hora.Text = hora;
            text_fecha.Text = fecha;
        }

        void cleanTextBox ()
        {
            text_turno.Text = "";
            text_nombre.Text = "";
            text_edad.Text = "";
            text_telefono.Text = "";
            text_hora.Text = "";
            text_fecha.Text = "";
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            cleanTextBox();
        }
    }
}
