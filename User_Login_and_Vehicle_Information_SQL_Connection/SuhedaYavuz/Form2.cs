using Microsoft.SqlServer;
using System.Data;
using System.Data.SqlClient;
using System;

namespace SuhedaYavuz
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=AracFabrikasi;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public Form2()
        {
            InitializeComponent();
        }

        // Verileri listeleyen metod

        public void Listele()
        {
            using (connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM AracBilgileri";
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Listele();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView hücresine tıklandığında ilgili verileri TextBox'lara aktaran metod

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtaracid.Text = row.Cells["Arac_ID"].Value.ToString();
            txtaracturu.Text = row.Cells["Arac_Turu"].Value.ToString();
            txtaracmarkasi.Text = row.Cells["Arac_Markasi"].Value.ToString();
            txtaracmodeli.Text = row.Cells["Arac_Modeli"].Value.ToString();
            txtaracuretimbaslangictarihi.Text = row.Cells["Arac_Uretim_Baslangic_Tarihi"].Value.ToString();
            txtaracuretimbitistarihi.Text = row.Cells["Arac_Uretim_Bitis_Tarihi"].Value.ToString();
            txtaracmaliyettutari.Text = row.Cells["Arac_Maliyet_Tutari"].Value.ToString();
            txtaracsatisdurumu.Text = row.Cells["Arac_Satis_Durumu"].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kaydet butonuna tıklandığında yeni bir araç kaydeden metod

            using (connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO AracBilgileri(Arac_ID, Arac_Turu, Arac_Markasi, Arac_Modeli, Arac_Uretim_Baslangic_Tarihi, Arac_Uretim_Bitis_Tarihi, Arac_Maliyet_Tutari, Arac_Satis_Durumu) " +
                               "VALUES (@Arac_ID, @Arac_Turu, @Arac_Markasi, @Arac_Modeli, @Arac_Uretim_Baslangic_Tarihi, @Arac_Uretim_Bitis_Tarihi, @Arac_Maliyet_Tutari, @Arac_Satis_Durumu)";

                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Arac_ID", txtaracid.Text);
                command.Parameters.AddWithValue("@Arac_Turu", txtaracturu.Text);
                command.Parameters.AddWithValue("@Arac_Markasi", txtaracmarkasi.Text);
                command.Parameters.AddWithValue("@Arac_Modeli", txtaracmodeli.Text);
                command.Parameters.AddWithValue("@Arac_Uretim_Baslangic_Tarihi", txtaracuretimbaslangictarihi.Text);
                command.Parameters.AddWithValue("@Arac_Uretim_Bitis_Tarihi", txtaracuretimbitistarihi.Text);
                command.Parameters.AddWithValue("@Arac_Maliyet_Tutari", txtaracmaliyettutari.Text);
                command.Parameters.AddWithValue("@Arac_Satis_Durumu", txtaracsatisdurumu.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }

            Listele();

            // Yeni aracı en altta listelemek için DataGridView'ın en altına kaydırma
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {
            // Düzenle butonuna tıklandığında seçili aracı güncelleyen metod

            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE AracBilgileri SET Arac_Turu = @Arac_Turu, Arac_Markasi = @Arac_Markasi, Arac_Modeli = @Arac_Modeli, " +
                                   "Arac_Uretim_Baslangic_Tarihi = @Arac_Uretim_Baslangic_Tarihi, Arac_Uretim_Bitis_Tarihi = @Arac_Uretim_Bitis_Tarihi, " +
                                   "Arac_Maliyet_Tutari = @Arac_Maliyet_Tutari, Arac_Satis_Durumu = @Arac_Satis_Durumu " +
                                   "WHERE Arac_ID = @Arac_ID";

                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Arac_ID", txtaracid.Text);
                    command.Parameters.AddWithValue("@Arac_Turu", txtaracturu.Text);
                    command.Parameters.AddWithValue("@Arac_Markasi", txtaracmarkasi.Text);
                    command.Parameters.AddWithValue("@Arac_Modeli", txtaracmodeli.Text);
                    command.Parameters.AddWithValue("@Arac_Uretim_Baslangic_Tarihi", txtaracuretimbaslangictarihi.Text);
                    command.Parameters.AddWithValue("@Arac_Uretim_Bitis_Tarihi", txtaracuretimbitistarihi.Text);
                    command.Parameters.AddWithValue("@Arac_Maliyet_Tutari", txtaracmaliyettutari.Text);
                    command.Parameters.AddWithValue("@Arac_Satis_Durumu", txtaracsatisdurumu.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                Listele();

                // Düzenlenen verileri form üzerinde güncelleme
                int rowIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows[rowIndex].Cells["Arac_Turu"].Value = txtaracturu.Text;
                dataGridView1.Rows[rowIndex].Cells["Arac_Markasi"].Value = txtaracmarkasi.Text;
                dataGridView1.Rows[rowIndex].Cells["Arac_Modeli"].Value = txtaracmodeli.Text;
                dataGridView1.Rows[rowIndex].Cells["Arac_Uretim_Baslangic_Tarihi"].Value = txtaracuretimbaslangictarihi.Text;
                dataGridView1.Rows[rowIndex].Cells["Arac_Uretim_Bitis_Tarihi"].Value = txtaracuretimbitistarihi.Text;
                dataGridView1.Rows[rowIndex].Cells["Arac_Maliyet_Tutari"].Value = txtaracmaliyettutari.Text;
                dataGridView1.Rows[rowIndex].Cells["Arac_Satis_Durumu"].Value = txtaracsatisdurumu.Text;
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Sil butonuna tıklandığında seçili aracı silen metod

            DialogResult result = MessageBox.Show("Seçili satırı silmek istediğinizden emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    using (connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM AracBilgileri WHERE Arac_ID = @Arac_ID";

                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Arac_ID", selectedRow.Cells["Arac_ID"].Value.ToString());

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    Listele();
                    MessageBox.Show("Seçili satır başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            // Görüntüle butonuna tıklandığında seçili aracın bilgilerini gösteren metod

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string aracID = selectedRow.Cells["Arac_ID"].Value.ToString();
                string aracTuru = selectedRow.Cells["Arac_Turu"].Value.ToString();
                string aracMarkasi = selectedRow.Cells["Arac_Markasi"].Value.ToString();
                string aracModeli = selectedRow.Cells["Arac_Modeli"].Value.ToString();
                string uretimBaslangicTarihi = selectedRow.Cells["Arac_Uretim_Baslangic_Tarihi"].Value.ToString();
                string uretimBitisTarihi = selectedRow.Cells["Arac_Uretim_Bitis_Tarihi"].Value.ToString();
                string maliyetTutari = selectedRow.Cells["Arac_Maliyet_Tutari"].Value.ToString();
                string satisDurumu = selectedRow.Cells["Arac_Satis_Durumu"].Value.ToString();

                string message = "Arac ID: " + aracID + "\n"
                                 + "Arac Türü: " + aracTuru + "\n"
                                 + "Arac Markası: " + aracMarkasi + "\n"
                                 + "Arac Modeli: " + aracModeli + "\n"
                                 + "Üretim Başlangıç Tarihi: " + uretimBaslangicTarihi + "\n"
                                 + "Üretim Bitiş Tarihi: " + uretimBitisTarihi + "\n"
                                 + "Maliyet Tutarı: " + maliyetTutari + "\n"
                                 + "Satış Durumu: " + satisDurumu;

                MessageBox.Show(message, "Seçili Arac Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
