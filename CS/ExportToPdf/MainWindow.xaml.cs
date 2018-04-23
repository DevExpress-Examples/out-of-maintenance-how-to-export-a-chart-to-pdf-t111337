using System.Diagnostics;
using System.IO;
using System.Windows;
using DevExpress.Xpf.Charts;

namespace ExportToPdf {

    public partial class MainWindow : Window {
        string PDFFile = "Output.pdf";
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            PrintSizeMode sizeMode = PrintSizeMode.Stretch;
            chartControl.ExportToPdf(PDFFile, sizeMode);
            Process.Start(PDFFile);
        }
    }
}
