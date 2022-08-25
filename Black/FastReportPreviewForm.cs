using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;
using FastReport.Utils;
using FastReport.Export.Pdf;
using FastReport.Export.OoXML;
using FastReport.Export.Html;
using FastReport.Export.Text;
using FastReport.Export.Xml;
using FastReport.Design;

namespace Black
{
    public partial class FastReportPreviewForm : BaseForm
    {
        public Report FReport = new Report();
        public DataSet FDataSet { get; set; }
        public string reportName { get; set; }
        public string[] ParamName;
        public object[] Value;

        public int TypeInvoiceForm { get; set; }
        public int PrintCount { get; set; }

        public bool IsPrinting;

        public FastReportPreviewForm()
        {
            InitializeComponent();
        }

        private void FastReportPreviewForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                IsPrinting = false;
                FReport.Preview = previewControl1;

                FReport.Preview.UIStyle = UIStyle.Office2007Blue;
                if (FReport.FileName == string.Empty && reportName != null)
                    FReport.Load(reportName);
                SetParameter(ParamName, Value);
                FReport.RegisterData(FDataSet);
                if (FReport.Prepare())
                    FReport.ShowPrepared();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ResetForm()
        {
            FReport = new Report();
            if (FDataSet != null)
                FDataSet.Clear();
            reportName = string.Empty;
            if (ParamName != null)
                Array.Clear(ParamName, 0, ParamName.Length);
            if (Value != null)
                Array.Clear(Value, 0, Value.Length);
            TypeInvoiceForm = 0;
            PrintCount = 1;
        }

        public void SetParameter(string[] paramname, object[] value)
        {
            try
            {
                if (paramname != null && value != null)
                    for (int i = 0; i < paramname.Length; i++)
                    {
                        FReport.SetParameterValue(paramname[i], value[i]);
                    }
            }
            catch (Exception ex)
            {
                ex.WriteLOG();
            }
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {
            FReport.Prepare();
            FReport.PrintSettings.ShowDialog = false;
            if (TypeInvoiceForm == 7)
                FReport.PrintSettings.Copies = PrintCount;
            FReport.Print();
            IsPrinting = true;
        }

        private void BTN_PRINT_SETTING_Click(object sender, EventArgs e)
        {
            FReport.Prepare();
            FReport.PrintSettings.ShowDialog = true;
            FReport.Print();
            if (FReport.IsPrinting)
                IsPrinting = true;
        }

        private void BTN_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                //FReport.Prepare();
                FastReportDesigner fastReportDesigner = new FastReportDesigner();
                fastReportDesigner.setReport(FReport);
                fastReportDesigner.ReportName = FReport.FileName;
                fastReportDesigner.ReportPath = reportName;
                fastReportDesigner.Show();
                fastReportDesigner.BringToFront();
            }
            catch (Exception)
            { }
        }

        private void previewControl1_PageChanged(object sender, EventArgs e)
        {
            TXT_PAGE_NUMBER.Text = previewControl1.PageCount + " / " + previewControl1.PageNo;
        }

        private void BTN_ZOOM_IN_Click(object sender, EventArgs e)
        {
            previewControl1.ZoomIn();
        }

        private void BTN_ZOOM_OUT_Click(object sender, EventArgs e)
        {
            previewControl1.ZoomOut();
        }

        private void BTN_END_PAGE_Click(object sender, EventArgs e)
        {
            previewControl1.Last();
        }

        private void BTN_FIRST_PAGE_Click(object sender, EventArgs e)
        {
            previewControl1.First();
        }

        private void BTN_NEXT_Click(object sender, EventArgs e)
        {
            previewControl1.Next();
        }

        private void BTN_PRIOR_Click(object sender, EventArgs e)
        {
            previewControl1.Prior();
        }

        private void BTN_EXPORT_PDF_Click(object sender, EventArgs e)
        {
            FReport.Prepare();
            PDFExport pdf = new PDFExport();
            exportSaveDialog.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            exportSaveDialog.FileName = "agreement";
            if (exportSaveDialog.ShowDialog() == DialogResult.OK)
            {
                FReport.Export(pdf, exportSaveDialog.FileName);
                IsPrinting = true;
            }
        }

        private void BTN_EXPORT_EXCEL_Click(object sender, EventArgs e)
        {
            FReport.Prepare();
            Excel2007Export exel = new Excel2007Export();
            exportSaveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (exportSaveDialog.ShowDialog() == DialogResult.OK)
            {
                FReport.Export(exel, exportSaveDialog.FileName);
            }
        }

        private void BTN_EXPORT_HTML_Click(object sender, EventArgs e)
        {
            FReport.Prepare();
            HTMLExport html = new HTMLExport();
            exportSaveDialog.Filter = "Html files (*.html)|*.html|All files (*.*)|*.*";
            if (exportSaveDialog.ShowDialog() == DialogResult.OK)
            {
                FReport.Export(html, exportSaveDialog.FileName);
            }
        }

        private void BTN_EXPORT_TEXT_Click(object sender, EventArgs e)
        {
            FReport.Prepare();
            TextExport txt = new TextExport();
            exportSaveDialog.Filter = "Txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (exportSaveDialog.ShowDialog() == DialogResult.OK)
            {
                FReport.Export(txt, exportSaveDialog.FileName);
            }
        }

        //private void BTN_EXPORT_XML_Click(object sender, EventArgs e)
        //{
        //    FReport.Prepare();
        //    XMLExport xml = new XMLExport();
        //    exportSaveDialog.Filter = "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
        //    if (exportSaveDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        FReport.Export(xml, exportSaveDialog.FileName);
        //    }
        //}

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            ResetForm();
            this.Close();
        }
    }
}
