Imports System.Diagnostics
Imports System.IO
Imports System.Windows
Imports DevExpress.Xpf.Charts

Namespace ExportToPdf

	Partial Public Class MainWindow
		Inherits Window

		Private PDFFile As String = "Output.pdf"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim sizeMode As PrintSizeMode = PrintSizeMode.Stretch
			chartControl.ExportToPdf(PDFFile, sizeMode)
			Process.Start(PDFFile)
		End Sub
	End Class
End Namespace
