using System.Drawing.Printing;

namespace ADC
{
    public partial class Form1 : Form
    {
        private DataGridView dataGridView1;
        private Button btnPrint;
        private int currentRow = 0;
        private Image logo;

        public Form1()
        {
            InitializeComponent();

            dataGridView1 = new DataGridView
            {
                Location = new Point(20, 20),
                Size = new Size(600, 200),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            Controls.Add(dataGridView1);

            btnPrint = new Button
            {
                Text = "Print to PDF",
                Location = new Point(20, 240)
            };
            btnPrint.Click += BtnPrint_Click;
            Controls.Add(btnPrint);

            LoadData();

            // Load logo (make sure the file exists!)
            //logo = Image.FromFile("logo.png");
        }

        private void LoadData()
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");


            for (int i = 1; i <= 100; i++)
            {
                dataGridView1.Rows.Add(i, $"User {i}", $"user{i}@example.com", i, $"User {i}", $"user{i}@example.com");
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            currentRow = 0;

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            printDoc.DefaultPageSettings.Landscape = true;

            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = @"C:\Users\Public\DataGridView_Report.pdf";

            printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            int margin = 50;
            int top = margin;

            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font normalFont = new Font("Arial", 10);
            int rowHeight = 30;

            // Draw logo
            if (logo != null)
            {
                e.Graphics.DrawImage(logo, margin, top, 100, 100);
            }

            // Draw header text
            e.Graphics.DrawString("Employee Report", headerFont, Brushes.Black, margin + 120, top + 30);
            top += 120;

            // Draw column headers
            int colLeft = margin;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, normalFont, Brushes.Black, colLeft, top);
                colLeft += col.Width;
            }

            top += rowHeight;

            // Draw rows
            while (currentRow < dataGridView1.Rows.Count)
            {
                if (top + rowHeight > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }

                colLeft = margin;
                foreach (DataGridViewCell cell in dataGridView1.Rows[currentRow].Cells)
                {
                    e.Graphics.DrawString(Convert.ToString(cell.Value), normalFont, Brushes.Black, colLeft, top);
                    colLeft += cell.OwningColumn.Width;
                }

                top += rowHeight;
                currentRow++;
            }

            e.HasMorePages = false;
        }
    }
}