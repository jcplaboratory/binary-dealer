Imports System.Drawing
Imports System.Windows.Forms
Public Class TextPrint
    Inherits Printing.PrintDocument
    Private fntPrintFont As Font
    Private strText As String
    Public Sub New(ByVal Text As String)
        MyBase.New()
        strText = Text
    End Sub
    Public Property Text() As String
        Get
            Return strText
        End Get
        Set(value As String)
            strText = value
        End Set
    End Property
    Protected Overrides Sub OnBeginPrint(e As Printing.PrintEventArgs)
        MyBase.OnBeginPrint(e)
        If fntPrintFont Is Nothing Then
            fntPrintFont = New Font("Times New Roman", 12)
        End If
    End Sub
    Public Property Font() As Font
        Get
            Return fntPrintFont
        End Get
        Set(value As Font)
            fntPrintFont = value
        End Set
    End Property
    Protected Overrides Sub OnPrintPage(e As Printing.PrintPageEventArgs)
        MyBase.OnPrintPage(e)
        Static intCurrentChar As Integer
        Dim intPrintAreaHeight, intPrintAreaWidth, intMarginLeft, intMarginTop As Integer
        With MyBase.DefaultPageSettings
            intPrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
            intMarginLeft = .Margins.Left
            intMarginTop = .Margins.Top
        End With
        If MyBase.DefaultPageSettings.Landscape Then
            Dim intTemp As Integer
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If
        Dim intLineCount As Int32 = CInt(intPrintAreaHeight / Font.Height)
        Dim rectPrintingArea As New RectangleF(intMarginLeft, intMarginTop, intPrintAreaWidth, intPrintAreaHeight)
        Dim odjSF As New StringFormat(StringFormatFlags.LineLimit)
        Dim intLinesFilled, intCharsFitted As Int32
        e.Graphics.MeasureString(Mid(strText, UpgradeZeros(intCurrentChar)), Font, New SizeF(intPrintAreaWidth, intPrintAreaHeight), odjSF, intCharsFitted, intLinesFilled)
        e.Graphics.DrawString(Mid(strText, UpgradeZeros(intCurrentChar)), Font, Brushes.Black, rectPrintingArea, odjSF)
        intCurrentChar += intCharsFitted
        If intCurrentChar < strText.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            intCurrentChar = 0
        End If
    End Sub
    Public Function UpgradeZeros(ByVal Input As Integer) As Integer
        If Input = 0 Then
            Return 1
        Else
            Return Input
        End If
    End Function
End Class
