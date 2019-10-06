using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EvidencijaKursa
{
    public partial class Form1 : Form
    {

        MySqlConnection conn;
        string connString;
        private static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                MySqlCommand Komanda = new MySqlCommand("unesiPolaznika", conn);
                connString = "SERVER=mysql204.loopia.se; PORT =3306;DATABASE=prevodilac_co_rs;UID=user@p5779;PASSWORD=VIP212MEN";
                //conn.ConnectionString = connString;
                conn.Open();
                Komanda.CommandType = CommandType.StoredProcedure;
                Komanda.Parameters.Add(new MySqlParameter("imePolaznika", txtIme.Text));
                Komanda.Parameters.Add(new MySqlParameter("prezimePolaznika", txtPrezime.Text));
                Komanda.Parameters.Add(new MySqlParameter("emailPolaznika", txtMejl.Text));
                Komanda.Parameters.Add(new MySqlParameter("jezik", txtNazivJezika.Text));
                Komanda.Parameters.Add(new MySqlParameter("kurs", txtNazivKursa.Text));
                Komanda.Parameters.Add(new MySqlParameter("sifraPolaznika", txtSifra.Text));
                Komanda.Parameters.Add(new MySqlParameter("ocenaPolaznika", txtOcena.Text));
                Komanda.Parameters.Add(new MySqlParameter("datum", dateTimePicker1.Text));
                var result = Komanda.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Podaci su snimjeni");
            }catch(Exception ex)
            {
                MessageBox.Show("Podaci Nisu Snimljeni");
            }
        }

        private void BtnSve_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                connString = "SERVER=mysql204.loopia.se; PORT =3306;DATABASE=prevodilac_co_rs;UID=user@p5779;PASSWORD=VIP212MEN";
                //conn.ConnectionString = connString;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prevodilac_co_rs.polaznik", conn);
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "polaznik");
                dataGridView1.DataSource = ds.Tables["polaznik"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSifra_Click(object sender, EventArgs e)
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
            String randomString = "";
            for (int i = 0; i < 8; i++)
            {
                randomString += letters[random.Next(0, 35)].ToString();
            }
            txtSifra.Text = randomString;
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtIme.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPrezime.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMejl.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtNazivJezika.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNazivKursa.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSifra.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtOcena.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connString);
            connString = "SERVER=mysql204.loopia.se; PORT =3306;DATABASE=prevodilac_co_rs;UID=user@p5779;PASSWORD=VIP212MEN;";
            //conn.ConnectionString = connString;
            UTF8Encoding utf8 = new UTF8Encoding();
            conn.Open();
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            String query = "UPDATE `polaznik` SET `ime`='" + txtIme.Text + "',`prezime`='" + txtPrezime.Text + "',`email`='" + txtMejl.Text + "',`nazivJezika`='" + txtNazivJezika.Text + "' ,`nazivKursa`='" + txtNazivKursa.Text + "',`sifra`='"+txtSifra.Text+"',`ocena`='"+txtOcena.Text+ "',`datumPolaganja`='" + dateTimePicker1.Text + "'WHERE id='" + int.Parse(id) + "' "; 
             MySqlCommand komanda = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prevodilac_co_rs.polaznik", conn);
           
            DataSet ds = new DataSet();
            adapter.Fill(ds, "polaznik");
            dataGridView1.DataSource = ds.Tables["polaznik"];
            var result = komanda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Podaci su izmenjeni");
        }

        private void BtnFiltriraj_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(connString);
                connString = "SERVER=mysql204.loopia.se; PORT =3306;DATABASE=prevodilac_co_rs;UID=user@p5779;PASSWORD=VIP212MEN";
                //conn.ConnectionString = connString;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prevodilac_co_rs.polaznik WHERE datumPolaganja='"+ dateTimePicker1.Text+"'", conn);
                conn.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "polaznik");
                dataGridView1.DataSource = ds.Tables["polaznik"];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connString);
            connString = "SERVER=mysql204.loopia.se; PORT =3306;DATABASE=prevodilac_co_rs;UID=user@p5779;PASSWORD=VIP212MEN";
            //conn.ConnectionString = connString;
            conn.Open();
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            String query = "DELETE FROM prevodilac_co_rs.polaznik WHERE id='"+id+"'";
            MySqlCommand komanda = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM prevodilac_co_rs.polaznik", conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "polaznik");
            dataGridView1.DataSource = ds.Tables["polaznik"];
            var result = komanda.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Podaci su izbrisani");
        }
    }
    }

