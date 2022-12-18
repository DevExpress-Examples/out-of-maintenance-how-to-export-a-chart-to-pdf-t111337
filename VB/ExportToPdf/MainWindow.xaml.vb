Imports System.Diagnostics
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace ExportToPdf

    Public Partial Class MainWindow
        Inherits Window

        Private PDFFile As String = "Output.pdf"

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim sizeMode As PrintSizeMode = PrintSizeMode.Stretch
            Me.chartControl.ExportToPdf(PDFFile, sizeMode)
            Call Process.Start(PDFFile)
        End Sub
    End Class
End Namespace
