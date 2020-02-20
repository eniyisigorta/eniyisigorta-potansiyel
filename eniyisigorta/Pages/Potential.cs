using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using Classes;

namespace Pages
{
    public partial class Potential : UserControl
    {
        private DataTableCollection tableCollection;

        public Potential()
        {
            InitializeComponent();
        }

        private void Potential_Load(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!radioBtnAnadoluSigorta.Checked)
            {
                MessageBox.Show(
                    "Lütfen içe aktarılacak dosyanın sigorta firmasını seçin.",
                    "Hata!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });

                                tableCollection = result.Tables;

                                DataTable data = tableCollection[0];
                                dataGridView.DataSource = data;

                                dataGridView.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dataGridView.Visible == false)
            {
                MessageBox.Show(
                    "Lütfen önce içeriye bir dosya aktarın.",
                    "Hata!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1
                );
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    string KIMLIK_NO;
                    string AD_UNVAN;
                    string POLICE_NO;
                    string PLAKA;
                    string ARAC_MARKA;
                    string ARAC_TIPI;
                    string ARAC_GRUP_KODU;
                    string MODEL_YILI;
                    string SIRKET_KODU;
                    string POLICE_BASLANGIC_TARIHI;
                    string POLICE_BITIS_TARIHI;
                    string UYGULANAN_KADEME;
                    string HASAR_TARIHI;
                    string TOPLAM_HASAR_TUTARI;
                    string RUCU_ORANI;
                    string URUN_TIPI;

                    try
                    {
                        KIMLIK_NO = row.Cells["KIMLIK_NO"].Value.ToString();
                        AD_UNVAN = row.Cells["AD_UNVAN"].Value.ToString();
                        POLICE_NO = row.Cells["POLICE_NO"].Value.ToString();
                        PLAKA = row.Cells["PLAKA"].Value.ToString();
                        ARAC_MARKA = row.Cells["ARAC_MARKA"].Value.ToString();
                        ARAC_TIPI = row.Cells["ARAC_TIPI"].Value.ToString();
                        ARAC_GRUP_KODU = row.Cells["ARAC_GRUP_KODU"].Value.ToString();
                        MODEL_YILI = row.Cells["MODEL_YILI"].Value.ToString();
                        SIRKET_KODU = row.Cells["SIRKET_KODU"].Value.ToString();
                        POLICE_BASLANGIC_TARIHI = row.Cells["POLICE_BASLANGIC_TARIHI"].Value.ToString();
                        POLICE_BITIS_TARIHI = row.Cells["POLICE_BITIS_TARIHI"].Value.ToString();
                        UYGULANAN_KADEME = row.Cells["UYGULANAN_KADEME"].Value.ToString();
                        HASAR_TARIHI = row.Cells["HASAR_TARIHI"].Value.ToString();
                        TOPLAM_HASAR_TUTARI = row.Cells["TOPLAM_HASAR_TUTARI"].Value.ToString();
                        RUCU_ORANI = row.Cells["RUCU_ORANI"].Value.ToString();
                        URUN_TIPI = row.Cells["URUN_TIPI"].Value.ToString();

                        
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
