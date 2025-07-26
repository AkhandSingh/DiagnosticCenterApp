using AdcData;
using AdcData.Interfaces;
using AdcData.Repositories;
using System.Drawing.Printing;

namespace ADC
{
    public partial class Receipt : Form
    {
        AdcDbContext _context;
        IPatientRepository _patientRepository;
        IDiagnosticRepository _diagnosticRepository;


        public Receipt()
        {
            InitializeComponent();
            _context = new AdcDbContext();
            _patientRepository = new PatientRepository(_context);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = @"C:\Users\Public\receipt.pdf";

            printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            var patientDiagnostic = _patientRepository.GetPatientDiagnosticByMobileBumber(9560971335);
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
                e.Graphics.DrawString($"USG: {(diagnosticCategory == "USG" ? diagnosticSubCategory : string.Empty)}", normalFont, Brushes.Black, margin, top);
                e.Graphics.DrawString($"COLOR DOPPLER: ", normalFont, Brushes.Black, margin + 250, top);

                top += rowHeight;
                e.Graphics.DrawString($"XRAY: {(diagnosticCategory == "XRAY" ? diagnosticSubCategory : string.Empty)}", normalFont, Brushes.Black, margin, top);
                e.Graphics.DrawString($"E.C.G.: {(diagnosticCategory == "ECG" ? diagnosticSubCategory : string.Empty)}", normalFont, Brushes.Black, margin + 250, top);

                top += rowHeight;
                e.Graphics.DrawString($"AMOUNT: {patientDiagnostic.Diagnostic.Amount}", normalFont, Brushes.Black, margin, top);
                e.Graphics.DrawString($"MANAGER: {patientDiagnostic.Diagnostic.Manager}", normalFont, Brushes.Black, margin + 250, top);
            }

            e.HasMorePages = false;
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }

        private void ClearLabes()
        {
            foreach (Control control in Controls)
            {
                if (control is Label label)
                {
                    label.Text = string.Empty;
                }
            }
        }
    }
}
