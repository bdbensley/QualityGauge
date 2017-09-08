'Demo that shows ZPL with Visual Basic.net
'Zebra Tech Support
'2/2004
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles
Imports System
Imports System.ComponentModel
Public Class Form3
    Inherits System.Windows.Forms.Form
    Public Const GENERIC_WRITE = &H40000000
    Public Const OPEN_EXISTING = 3
    Public Const FILE_SHARE_WRITE = &H2

    Dim LPTPORT As String
    Dim hPort As Integer

    Public Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" ( _
    ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, _
    ByVal dwShareMode As Integer, _
    <MarshalAs(UnmanagedType.Struct)> ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES, _
    ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, _
    ByVal hTemplateFile As Integer) As Integer



    Public Declare Function CloseHandle Lib "kernel32" Alias "CloseHandle" (ByVal hObject As Integer) As Integer
    Dim retval As Integer
    <StructLayout(LayoutKind.Sequential)> Public Structure SECURITY_ATTRIBUTES
        Private nLength As Integer
        Private lpSecurityDescriptor As Integer
        Private bInheritHandle As Integer
    End Structure

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    ' Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer. 
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "PRINT"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(48, 96)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(136, 80)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = "Simple Demo that prints ""Zebra Tech Support"""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Zebra Tech Support"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Texxxt As String
        Dim SA As SECURITY_ATTRIBUTES
        Dim outFile As FileStream, hPortP As IntPtr

        LPTPORT = "172.18.129.8" '"LPT1"
        Texxxt = Me.RichTextBox1.Text
        hPort = CreateFile(LPTPORT, GENERIC_WRITE, FILE_SHARE_WRITE, SA, OPEN_EXISTING, 0, 0)
        hPortP = New IntPtr(hPort) 'convert Integer to IntPtr
        Dim handleValue = New SafeFileHandle(hPortP, True)
        outFile = New FileStream(handleValue, FileAccess.Write) 'FileStream(hPortP, FileAccess.Write, False) 'Create FileStream using Handle

        Dim fileWriter As New StreamWriter(outFile)



        fileWriter.Write("^XA^FO50,50^A030,30^FD ZEBRA^FS")
        fileWriter.Write(Chr(34))
        fileWriter.Write("^FO50,100^A030,30^FD TECH SUPPORT^FS^XZ")
        fileWriter.Write(Chr(13))
        fileWriter.Write(Chr(10))

        fileWriter.Flush()
        fileWriter.Close()
        outFile.Close()

        retval = CloseHandle(hPort)
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
