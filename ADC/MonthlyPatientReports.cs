using AdcData;
using AdcData.Interfaces;
using AdcData.Models;
using AdcData.Repositories;
using System.Drawing.Printing;

namespace ADC
{
    public partial class MonthlyPatientReports : Form
    {
        AdcDbContext _context;
        IPatientRepository _patientRepository;
        IEnumerable<PatientDiagnostic> _patientDiagnostics;
        private int currentRow = 0;

        public MonthlyPatientReports()
        {
            InitializeComponent();

            _context = new AdcDbContext();
            _patientRepository = new PatientRepository(_context);

            DtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DtpEndDate.Value = DateTime.Now;
        }

       

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (DtvMonthlyPatientReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to print. Please search for patient diagnostics first.");
                return;
            }

            currentRow = 0;

            // Create a PrintDocument object
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            // Set the printer to "Microsoft Print to PDF" and output file
            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = @"C:\DiagnosticReports\MonthlyPatientReports.pdf";

            printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int margin = 30;
            int top = margin;

            Font headerFont = new Font("Arial", 24, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            int rowHeight = 30;

            // Draw header text
            e.Graphics.DrawString("ARUSHI DIAGNOSTIC CENTER", headerFont, Brushes.Black, margin + 150, top + 30);
            top += 80;
            e.Graphics.DrawString("KARMA, KARCHHANA, PRAYAGRAJ  MO. NO. 8953313751", normalFont, Brushes.Black, margin + 230, top);

            top += 50;

            // Draw column headers
            int colLeft = margin;
            Pen borderPen = Pens.Black;

            // Add extra column for serial number
            e.Graphics.DrawString("SR.NO.", normalFont, Brushes.Black, colLeft + 2, top + 5);
            e.Graphics.DrawRectangle(borderPen, colLeft, top, 60, rowHeight);

            colLeft += 60;
            foreach (DataGridViewColumn col in DtvMonthlyPatientReport.Columns)
            {
                // Draw header text
                e.Graphics.DrawString(col.HeaderText, normalFont, Brushes.Black, colLeft + 2, top + 5);
                // Draw header cell border
                e.Graphics.DrawRectangle(borderPen, colLeft, top, col.Width, rowHeight);
                colLeft += col.Width;
            }

            top += rowHeight;

            // Draw rows
            while (currentRow < DtvMonthlyPatientReport.Rows.Count-1)
            {
                if (top + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                colLeft = margin;

                // Add extra column for serial number
                e.Graphics.DrawString((currentRow+1).ToString(), normalFont, Brushes.Black, colLeft + 2, top + 5);
                e.Graphics.DrawRectangle(borderPen, colLeft, top, 60, rowHeight);

                colLeft += 60;

                foreach (DataGridViewCell cell in DtvMonthlyPatientReport.Rows[currentRow].Cells)
                {
                    // Draw cell text
                    e.Graphics.DrawString(Convert.ToString(cell.Value), normalFont, Brushes.Black, colLeft + 2, top + 5);
                    // Draw cell border
                    e.Graphics.DrawRectangle(borderPen, colLeft, top, cell.OwningColumn.Width, rowHeight);
                    colLeft += cell.OwningColumn.Width;
                }

                top += rowHeight;
                currentRow++;
            }

            e.HasMorePages = false;

            MessageBox.Show("Printing completed successfully.", "Print Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = DtpStartDate.Value.Date;
            DateTime endDate = DtpEndDate.Value.Date;
            string doctorName = string.IsNullOrWhiteSpace(TxtDoctor.Text)? null : TxtDoctor.Text;
            _patientDiagnostics = _patientRepository.GetPatientDiagnostic(startDate,endDate.Date.AddDays(1),doctorName);

            if (_patientDiagnostics != null)
            {
                BtnPrint.Enabled = _patientDiagnostics.Any();
                DtvMonthlyPatientReport.Rows.Clear();

                foreach (var patientDiagnostic in _patientDiagnostics)
                {
                    DtvMonthlyPatientReport.Rows.Add(
                        patientDiagnostic.Diagnostic.DiagnosticDate.ToString("dd/MM/yyyy"),
                        patientDiagnostic.Diagnostic.ReferredBy,
                        patientDiagnostic.Patient.Name,
                        patientDiagnostic.Diagnostic.DiagnosticCategory,
                        patientDiagnostic.Diagnostic.Amount
                    );
                }
            }
            else
            {
                BtnPrint.Enabled = false;
            }

            
            DtvMonthlyPatientReport.Columns["DiagnosticDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DtvMonthlyPatientReport.Columns["DiagnosticDate"].Width = 100;

            DtvMonthlyPatientReport.Columns["Amount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DtvMonthlyPatientReport.Columns["Amount"].Width = 100;

        }
    }
}