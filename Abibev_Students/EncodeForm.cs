using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Abibev_Students
{
    public partial class EncodeForm : Form
    {
        public EncodeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF File|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4.Rotate());
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        doc.Add(new iTextSharp.text.Paragraph(detailsBox.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }

        private void encBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string surname = surnameBox.Text;
            string course = courseBox.Text;
            if (name != "" && surname != "" && course != "")
            {
                MessagingToolkit.QRCode.Codec.QRCodeEncoder encoder = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
                encoder.QRCodeScale = 8;
                string profile = name + ";" + surname + ";" + course;
                Bitmap bmp = encoder.Encode(profile);
                qrPic.Image = bmp;
                saveQrBtn.Enabled = true;
                savePdfBtn.Enabled = true;
                this.detailsBox.Font = new System.Drawing.Font("ArialBlack", 14, FontStyle.Regular);
                detailsBox.Text += "\nName:      " + name + "\nSurname:           " + surname + "\nCourse:         " + course;
            }
            else
            {
                if (name == "")
                {
                    MessageBox.Show("Please add student's name.", "No surname added.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (surname == "")
                {
                    MessageBox.Show("Please add student's surname.", "No surname added.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (course == "")
                {
                    MessageBox.Show("Please add student's course.", "No course added.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profilePic_Click(object sender, EventArgs e)
        {

        }

        private void qrDisplay_Click(object sender, EventArgs e)
        {

        }

        private void saveQrBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image bmp = qrPic.Image;
                    bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void profileBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void detailsBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
