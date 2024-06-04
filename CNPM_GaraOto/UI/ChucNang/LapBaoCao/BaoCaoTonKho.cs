using CNPM_GaraOto.UI.DAO;
using CNPM_GaraOto.UI.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Net.Mime.MediaTypeNames;

namespace CNPM_GaraOto.UI.ChucNang.LapBaoCao
{
    public partial class BaoCaoTonKho : Form
    {
        public BaoCaoTonKho(string month, string year)
        {
            InitializeComponent();
            lbMonth.Text = month;
            lbYear.Text = year;
            LoadBaoCao();
        }
        void LoadBaoCao()
        {
            int month = Convert.ToInt32(lbMonth.Text);
            int year = Convert.ToInt32(lbYear.Text);
            dtgvBaocaotonkho.DataSource = BaoCaoTonKhoDAO.Instance.LapBaoCaoTonKho(month, year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
                saveFileDialog.Title = "Save PDF File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    try
                    {
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        pdfDoc.Open();

                        iTextSharp.text.pdf.BaseFont Vn_Helvetica = iTextSharp.text.pdf.BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", "Identity-H", iTextSharp.text.pdf.BaseFont.EMBEDDED);
                        iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(Vn_Helvetica, 12, iTextSharp.text.Font.NORMAL);

                        Paragraph title = new Paragraph("BÁO CÁO TỒN KHO THÁNG", fontNormal);
                        title.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(title);

                        int month = Convert.ToInt32(lbMonth.Text);
                        int year = Convert.ToInt32(lbYear.Text);

                        Paragraph subtitle = new Paragraph("THÁNG " + month + "/" + year, fontNormal);
                        subtitle.Alignment = Element.ALIGN_CENTER;
                        pdfDoc.Add(subtitle);

                        pdfDoc.Add(new Paragraph(" "));

                        DataTable dt = new DataTable();

                        List<BaoCaoTonKho_DTO> list = BaoCaoTonKhoDAO.Instance.LapBaoCaoTonKho(month, year);
                        dt = ConvertToDataTable(list);

                        dt.Columns.Add("STT", typeof(int));
                        dt.Columns["STT"].SetOrdinal(0);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dt.Rows[i]["STT"] = i + 1;
                        }

                        PdfPTable table = new PdfPTable(dt.Columns.Count);
                        table.WidthPercentage = 100;

                        foreach (DataColumn column in dt.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, fontNormal));
                            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                            table.AddCell(cell);
                        }

                        foreach (DataRow row in dt.Rows)
                        {
                            table.AddCell(new Phrase(row["STT"].ToString(), fontNormal));
                            foreach (DataColumn column in dt.Columns)
                            {
                                if (column.ColumnName != "STT")
                                {
                                    table.AddCell(new Phrase(row[column].ToString(), fontNormal));
                                }
                            }
                        }

                        pdfDoc.Add(table);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi in file PDF: " + ex.Message);
                    }
                    finally
                    {
                        pdfDoc.Close();
                    }
                    MessageBox.Show("In file PDF thành công");
                }
            }
        }
    }
}
