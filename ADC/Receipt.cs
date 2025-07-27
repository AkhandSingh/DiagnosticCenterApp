using AdcData;
using AdcData.Interfaces;
using AdcData.Models;
using AdcData.Repositories;
using System.Drawing.Printing;

namespace ADC
{
    public partial class Receipt : Form
    {
        AdcDbContext _context;
        IPatientRepository _patientRepository;
        PatientDiagnostic _patientDiagnostic;

        public Receipt()
        {
            InitializeComponent();
            _context = new AdcDbContext();
            _patientRepository = new PatientRepository(_context);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            try
            {   
                if (_patientDiagnostic == null)
                {
                    MessageBox.Show("Please search for a patient first before printing.");
                    return;
                }

                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += PrintDoc_PrintPage;

                printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printDoc.PrinterSettings.PrintToFile = true;
                printDoc.PrinterSettings.PrintFileName = @"C:\DiagnosticReports\receipt.pdf";

                printDoc.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing: {ex.Message}");
            }
           
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var patientDiagnostic = _patientDiagnostic;
            int margin = 50;
            int top = margin;

            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            int rowHeight = 40;

            // Draw header text
            e.Graphics.DrawString("ARUSHI DIAGNOSTIC CENTER", headerFont, Brushes.Black, margin + 200, top + 30);
            top += 70;
            int colLeft = margin;
            e.Graphics.DrawString("KARMA, KARCHHANA, PRAYAGRAJ", normalFont, Brushes.Black, margin + 250, top);

            top += rowHeight;
            e.Graphics.DrawString("MO. 8574917390, 8953313751", normalFont, Brushes.Black, margin + 270, top);

            if (patientDiagnostic != null && patientDiagnostic.Patient != null)
            {
                top += rowHeight * 2;
                e.Graphics.DrawString($"PATIENT NAME: {patientDiagnostic.Patient.Name}", normalFont, Brushes.Black, margin, top);
                e.Graphics.DrawString($"MOBILE NUMBER: {patientDiagnostic.Patient.MobileNumber}", normalFont, Brushes.Black, margin + 250, top);
                e.Graphics.DrawString($"AGE: {patientDiagnostic.Patient.Age}", normalFont, Brushes.Black, margin + 500, top);
                e.Graphics.DrawString($"SEX: {patientDiagnostic.Patient.Sex}", normalFont, Brushes.Black, margin + 600, top);
            }

            if (patientDiagnostic != null && patientDiagnostic.Diagnostic != null)
            {
                string diagnosticCategory = patientDiagnostic.Diagnostic.DiagnosticCategory;
                string diagnosticSubCategory = patientDiagnostic.Diagnostic.DiagnosticSubCategory;

                top += rowHeight;
                e.Graphics.DrawString($"ADV BY DR.: {patientDiagnostic.Diagnostic.ReferredBy}", normalFont, Brushes.Black, margin, top);
                e.Graphics.DrawString($"PT ADD: {patientDiagnostic.Patient?.Address ?? string.Empty}", normalFont, Brushes.Black, margin + 250, top);

                top += rowHeight;

                // Draw XRAY checkbox
                int checkBoxX = margin + 300;
                int checkBoxY = top;
                int checkBoxSize = 14;
                
                // Draw label
                e.Graphics.DrawString("XRAY:", normalFont, Brushes.Black, margin + 250, checkBoxY - 2);

                // Draw checkbox rectangle
                e.Graphics.DrawRectangle(Pens.Black, checkBoxX, checkBoxY, checkBoxSize, checkBoxSize);

                // If diagnosticCategory is XRAY, draw tick
                if (diagnosticCategory == "XRAY")
                {
                    // Draw a tick mark inside the checkbox
                    Pen tickPen = new Pen(Color.Black, 2);
                    e.Graphics.DrawLine(tickPen, checkBoxX + 3, checkBoxY + checkBoxSize / 2, checkBoxX + checkBoxSize / 2, checkBoxY + checkBoxSize - 3);
                    e.Graphics.DrawLine(tickPen, checkBoxX + checkBoxSize / 2, checkBoxY + checkBoxSize - 3, checkBoxX + checkBoxSize - 3, checkBoxY + 3);
                    tickPen.Dispose();
                }

                // USG and ECG as before
                e.Graphics.DrawString($"USG: {(diagnosticCategory == "USG" ? diagnosticSubCategory : string.Empty)}", normalFont, Brushes.Black, margin, top);
                e.Graphics.DrawString($"E.C.G.: {(diagnosticCategory == "ECG" ? "E.C.G" : string.Empty)}", normalFont, Brushes.Black, margin + 500, top);

                top += rowHeight;
                e.Graphics.DrawString($"AMOUNT: {patientDiagnostic.Diagnostic.Amount}", normalFont, Brushes.Black, margin, top);
                e.Graphics.DrawString($"MANAGER: {patientDiagnostic.Diagnostic.Manager}", normalFont, Brushes.Black, margin + 250, top);
            }

            e.HasMorePages = false;

            MessageBox.Show("Printing completed successfully.", "Print Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            ClearLabes();
        }

        private void ClearLabes()
        {
            LblAge.Text = string.Empty;
            LblAmount.Text = string.Empty;
            LblDignosticDate.Text = string.Empty;
            LblEcg.Text = string.Empty;
            LblManager.Text = string.Empty;
            LblMobileNum.Text = string.Empty;
            LblPtAddress.Text = string.Empty;
            LblPtName.Text = string.Empty;
            LblReferredBy.Text = string.Empty;
            LblSex.Text = string.Empty;
            LblUsg.Text = string.Empty;
            LblXray.Text = string.Empty;
        }

        private void BtnSearchByMob_Click(object sender, EventArgs e)
        {
            long mobileNumber;
            long.TryParse(TxtMobileNumber.Text, out mobileNumber);
            _patientDiagnostic = _patientRepository.GetPatientDiagnosticByMobileBumber(mobileNumber);

            if (_patientDiagnostic != null && _patientDiagnostic.Patient != null)
            {       
                LblPtName.Text = _patientDiagnostic.Patient.Name;
                LblMobileNum.Text = _patientDiagnostic.Patient.MobileNumber.ToString();
                LblAge.Text = _patientDiagnostic.Patient.Age.ToString();
                LblSex.Text = _patientDiagnostic.Patient.Sex;
                LblPtAddress.Text = _patientDiagnostic.Patient.Address;

                if (_patientDiagnostic.Diagnostic != null)
                {
                    LblDignosticDate.Text = _patientDiagnostic.Diagnostic.DiagnosticDate.ToString("dd/MM/yyyy");
                    LblReferredBy.Text = _patientDiagnostic.Diagnostic.ReferredBy;
                    LblUsg.Text = _patientDiagnostic.Diagnostic.DiagnosticCategory == "USG" ? _patientDiagnostic.Diagnostic.DiagnosticSubCategory : string.Empty;
                    LblXray.Text = _patientDiagnostic.Diagnostic.DiagnosticCategory == "XRAY" ? "XRAY" : string.Empty;
                    LblEcg.Text = _patientDiagnostic.Diagnostic.DiagnosticCategory == "ECG" ? "E.C.G." : string.Empty;
                    LblAmount.Text = _patientDiagnostic.Diagnostic.Amount.ToString();
                    LblManager.Text = _patientDiagnostic.Diagnostic.Manager;
                }

                BtnPrint.Enabled = true;
            }
            else
            {
                BtnPrint.Enabled = false;
                MessageBox.Show("No patient found with the provided mobile number.");
                ClearLabes();
            }
        }
    }
}
