using AdcData;
using AdcData.Interfaces;
using AdcData.Models;
using AdcData.Repositories;
using System.Drawing.Printing;

namespace ADC
{
    public partial class MonthlyPatientCMOReports : Form
    {
        AdcDbContext _context;
        IPatientRepository _patientRepository;
        IEnumerable<PatientDiagnostic> _patientDiagnostics;
        private int currentRow = 0;

        public MonthlyPatientCMOReports()
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
            printDoc.DefaultPageSettings.Landscape = true; // Set landscape mode if needed
            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = @"C:\DiagnosticReports\MonthlyPatientCMOReports.pdf";

            printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int margin = 30;
            int top = margin;

            Font headerFont = new Font("Arial", 24, FontStyle.Bold);
            Font headerFont2 = new Font("Arial", 18);
            Font normalFont = new Font("Arial", 10);
            int defaultRowHeight = 30;

            Pen borderPen = Pens.Black;


            // Draw column headers
            int colLeft = margin;
            e.Graphics.DrawRectangle(borderPen, colLeft, top, margin + 1025, 130);
            e.Graphics.FillRectangle(Brushes.SkyBlue, colLeft + 1, top + 1, margin + 1023, 130);
            // Draw header text inside rectangle
            top += 10;
            e.Graphics.DrawString("ARUSHI DIAGNOSTIC CENTER", headerFont, Brushes.Navy, margin + 250, top);
            top += 50;
            e.Graphics.DrawString("KARMA, KARCHHANA, PRAYAGRAJ", headerFont2, Brushes.Blue, margin + 280, top);

            top += 40;
            e.Graphics.DrawString("MOB. NO. 8574917390, 8953313751", normalFont, Brushes.Blue, margin + 370, top);
            top += 30;

            // Rule section
            e.Graphics.DrawRectangle(borderPen, colLeft, top, margin + 1025, 100);
            top += 10;
            // Draw header text inside rectangle
            e.Graphics.DrawString("P.N.D.T. Monthly Report According to Section 9(B)", normalFont, Brushes.Black, margin + 50, top);
            top += 20;
            e.Graphics.DrawString("ARUSHI DIAGNOSTIC CENTER KARMA, KARCHHANA, PRAYAGRAJ", normalFont, Brushes.Black, margin + 50, top);

            top += 20;
            e.Graphics.DrawString("Registration no. U CMO/2025/708", normalFont, Brushes.Black, margin + 50, top);
            top += 20;

            e.Graphics.DrawString("Center Proprietor Name Mr. Pramod Kumar Patel", normalFont, Brushes.Black, margin + 50, top);
            top += 30;

            //e.Graphics.DrawRectangle(borderPen, colLeft, top, margin + 1025, 100);

            // Add extra column for serial number
            int headerRowHeight = defaultRowHeight;
            // Calculate max header row height based on wrapped text
            List<int> headerHeights = new List<int>();
            headerHeights.Add(defaultRowHeight); // For SR.NO.

            foreach (DataGridViewColumn col in DtvMonthlyPatientReport.Columns)
            {
                string headerText = col.HeaderText;
                int headerWidth = col.Width - 4;
                SizeF textSize = e.Graphics.MeasureString(headerText, normalFont);

                if (textSize.Width > headerWidth)
                {
                    List<string> lines = new List<string>();
                    string[] words = headerText.Split(' ');
                    string currentLine = "";
                    foreach (var word in words)
                    {
                        string testLine = string.IsNullOrEmpty(currentLine) ? word : currentLine + " " + word;
                        if (e.Graphics.MeasureString(testLine, normalFont).Width > headerWidth)
                        {
                            if (!string.IsNullOrEmpty(currentLine))
                                lines.Add(currentLine);
                            currentLine = word;
                        }
                        else
                        {
                            currentLine = testLine;
                        }
                    }
                    if (!string.IsNullOrEmpty(currentLine))
                        lines.Add(currentLine);

                    float lineHeight = e.Graphics.MeasureString("A", normalFont).Height;
                    headerHeights.Add((int)(lines.Count * lineHeight + 10));
                }
                else
                {
                    headerHeights.Add(defaultRowHeight);
                }
            }
            headerRowHeight = headerHeights.Max();

            // Draw SR.NO. header
            e.Graphics.DrawString("SR.NO.", normalFont, Brushes.Black, colLeft + 2, top + 5);
            e.Graphics.DrawRectangle(borderPen, colLeft, top, 60, headerRowHeight);

            colLeft += 60;
            int colIdx = 1;
            foreach (DataGridViewColumn col in DtvMonthlyPatientReport.Columns)
            {
                string headerText = col.HeaderText;
                int headerWidth = col.Width - 4;
                SizeF textSize = e.Graphics.MeasureString(headerText, normalFont);

                if (textSize.Width > headerWidth)
                {
                    List<string> lines = new List<string>();
                    string[] words = headerText.Split(' ');
                    string currentLine = "";
                    foreach (var word in words)
                    {
                        string testLine = string.IsNullOrEmpty(currentLine) ? word : currentLine + " " + word;
                        if (e.Graphics.MeasureString(testLine, normalFont).Width > headerWidth)
                        {
                            if (!string.IsNullOrEmpty(currentLine))
                                lines.Add(currentLine);
                            currentLine = word;
                        }
                        else
                        {
                            currentLine = testLine;
                        }
                    }
                    if (!string.IsNullOrEmpty(currentLine))
                        lines.Add(currentLine);

                    float lineHeight = e.Graphics.MeasureString("A", normalFont).Height;
                    float y = top + 5;
                    foreach (var line in lines)
                    {
                        e.Graphics.DrawString(line, normalFont, Brushes.Black, colLeft + 2, y);
                        y += lineHeight;
                    }
                }
                else
                {
                    e.Graphics.DrawString(headerText, normalFont, Brushes.Black, colLeft + 2, top + 5);
                }
                e.Graphics.DrawRectangle(borderPen, colLeft, top, col.Width, headerRowHeight);
                colLeft += col.Width;
                colIdx++;
            }

            top += headerRowHeight;

            // Draw rows
            while (currentRow < DtvMonthlyPatientReport.Rows.Count)
            {
                colLeft = margin;

                // Calculate row height based on cell content
                int rowHeight = defaultRowHeight;
                List<int> cellHeights = new List<int>();
                cellHeights.Add(defaultRowHeight); // For SR.NO.

                foreach (DataGridViewCell cell in DtvMonthlyPatientReport.Rows[currentRow].Cells)
                {
                    string cellText = Convert.ToString(cell.Value);
                    int cellWidth = cell.OwningColumn.Width - 4;
                    SizeF cellTextSize = e.Graphics.MeasureString(cellText, normalFont);

                    if (cellTextSize.Width > cellWidth)
                    {
                        List<string> lines = new List<string>();
                        string[] words = cellText.Split(' ');
                        string currentLine = "";
                        foreach (var word in words)
                        {
                            string testLine = string.IsNullOrEmpty(currentLine) ? word : currentLine + " " + word;
                            if (e.Graphics.MeasureString(testLine, normalFont).Width > cellWidth)
                            {
                                if (!string.IsNullOrEmpty(currentLine))
                                    lines.Add(currentLine);
                                currentLine = word;
                            }
                            else
                            {
                                currentLine = testLine;
                            }
                        }
                        if (!string.IsNullOrEmpty(currentLine))
                            lines.Add(currentLine);

                        float lineHeight = e.Graphics.MeasureString("A", normalFont).Height;
                        cellHeights.Add((int)(lines.Count * lineHeight + 10));
                    }
                    else
                    {
                        cellHeights.Add(defaultRowHeight);
                    }
                }
                rowHeight = cellHeights.Max();

                if (top + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                // Draw SR.NO. cell
                e.Graphics.DrawString((currentRow + 1).ToString(), normalFont, Brushes.Black, colLeft + 2, top + 5);
                e.Graphics.DrawRectangle(borderPen, colLeft, top, 60, rowHeight);

                colLeft += 60;
                int cellIdx = 1;
                foreach (DataGridViewCell cell in DtvMonthlyPatientReport.Rows[currentRow].Cells)
                {
                    string cellText = Convert.ToString(cell.Value);
                    int cellWidth = cell.OwningColumn.Width - 4;
                    SizeF cellTextSize = e.Graphics.MeasureString(cellText, normalFont);

                    if (cellTextSize.Width > cellWidth)
                    {
                        List<string> lines = new List<string>();
                        string[] words = cellText.Split(' ');
                        string currentLine = "";
                        foreach (var word in words)
                        {
                            string testLine = string.IsNullOrEmpty(currentLine) ? word : currentLine + " " + word;
                            if (e.Graphics.MeasureString(testLine, normalFont).Width > cellWidth)
                            {
                                if (!string.IsNullOrEmpty(currentLine))
                                    lines.Add(currentLine);
                                currentLine = word;
                            }
                            else
                            {
                                currentLine = testLine;
                            }
                        }
                        if (!string.IsNullOrEmpty(currentLine))
                            lines.Add(currentLine);

                        float lineHeight = e.Graphics.MeasureString("A", normalFont).Height;
                        float y = top + 5;
                        foreach (var line in lines)
                        {
                            e.Graphics.DrawString(line, normalFont, Brushes.Black, colLeft + 2, y);
                            y += lineHeight;
                        }
                    }
                    else
                    {
                        e.Graphics.DrawString(cellText, normalFont, Brushes.Black, colLeft + 2, top + 5);
                    }
                    e.Graphics.DrawRectangle(borderPen, colLeft, top, cell.OwningColumn.Width, rowHeight);
                    colLeft += cell.OwningColumn.Width;
                    cellIdx++;
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
            _patientDiagnostics = _patientRepository.GetPatientDiagnostic(startDate,endDate.Date.AddDays(1), isPregnency: true);

            if (_patientDiagnostics != null)
            {
                BtnPrint.Enabled = _patientDiagnostics.Any();
                DtvMonthlyPatientReport.Rows.Clear();

                foreach (var patientDiagnostic in _patientDiagnostics)
                {
                    DtvMonthlyPatientReport.Rows.Add(
                        patientDiagnostic.Diagnostic.DiagnosticDate.ToString("dd/MM/yyyy"),
                        patientDiagnostic.Patient.Name,
                        patientDiagnostic.Patient.Age,
                        patientDiagnostic.Patient.Gaurdian,
                        patientDiagnostic.Patient.Address,
                        patientDiagnostic.Diagnostic.LengthOfPregnency,
                        patientDiagnostic.Diagnostic.Indication,
                        string.IsNullOrWhiteSpace(patientDiagnostic.Diagnostic.ChildrenWithSex) ? "NILL": patientDiagnostic.Diagnostic.ChildrenWithSex,
                        patientDiagnostic.Diagnostic.Sonologist
                    );
                }
            }
            else
            {
                BtnPrint.Enabled = false;
            }

            
            DtvMonthlyPatientReport.Columns["DiagnosticDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DtvMonthlyPatientReport.Columns["DiagnosticDate"].Width = 80;
            DtvMonthlyPatientReport.Columns["Age"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DtvMonthlyPatientReport.Columns["Age"].Width = 30;
            DtvMonthlyPatientReport.Columns["LengthOfPregnency"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DtvMonthlyPatientReport.Columns["LengthOfPregnency"].Width = 70;
            DtvMonthlyPatientReport.Columns["Indication"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DtvMonthlyPatientReport.Columns["Indication"].Width = 65;
            DtvMonthlyPatientReport.Columns["ChildrenWithSex"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DtvMonthlyPatientReport.Columns["ChildrenWithSex"].Width = 80;

        }
    }
}