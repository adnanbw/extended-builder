// File: MainWindow.xaml.cs

using Microsoft.Reporting.WinForms;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace ExtendedReportBuilder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadReportViewer();
        }

        private void LoadReportViewer()
        {
            // Hosting the ReportViewer in a WindowsFormsHost
            var reportViewer = new ReportViewer
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local // Use local processing
            };

            windowsFormsHost.Child = reportViewer;

            // Load a sample report
            string reportPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SampleReport.rdlc");
            reportViewer.LocalReport.ReportPath = reportPath;

            // Refresh the viewer
            reportViewer.RefreshReport();
        }
    }
}
