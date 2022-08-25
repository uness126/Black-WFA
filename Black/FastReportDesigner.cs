using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FastReport;
using FastReport.Design.StandardDesigner;

namespace Black
{
    public partial class FastReportDesigner : Form
    {
        DataSet FDataSet;
        public string ReportName { private get; set; }
        public string ReportPath { private get; set; }
        private DataTable ReportsTable
        {
            get { return FDataSet.Tables[0]; }
        }
        Report report;
        public FastReportDesigner()
        {
            InitializeComponent();
            report = getReport();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FDataSet = new DataSet();
            ToolbarBase standardToolbar = designerControl1.Plugins.Find("StandardToolbar") as ToolbarBase;
            standardToolbar.Items["btnStdOpen"]._IgnoreClick = true;
            report.RegisterData(FDataSet);
            designerControl1.Report = report;
            designerControl1.RefreshLayout();
        }

        private void cmdSave_CustomAction(object sender, EventArgs e)
        {
            var d = (DesignerControl)sender;
            d.Report.FileName = ReportName;
            d.Report.Save(ReportPath);
        }

        private void SaveReport(Report report, string reportName)
        {
            if (!System.IO.Directory.Exists(@"Reports"))
            {
                System.IO.Directory.CreateDirectory("Reports");
                report.Save(reportName);
            }
            else
            {
                report.Save(reportName);
            }
        }

        public void setReport(Report reprot)
        {
            this.report = reprot;
        }

        public Report getReport()
        {
            return this.report;
        }
    }
}