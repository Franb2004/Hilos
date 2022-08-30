Imports System.Threading
Public Class Form1
    Inherits System.Windows.Forms.Form

    'procedimiento Main para que la aplicación arranque desde aquí

    <STAThread()>
    Public Shared Sub Main()

        'crear 2 hilos diferentes, cada hilo se enlaza con un método para iniciar los formularios

        Dim hilo1 As New Thread(AddressOf Ventana1)

        Dim hilo2 As New Thread(AddressOf Ventana2)

        'después se arrancan los 2 hilos

        hilo1.Start()

        hilo2.Start()

    End Sub

    Public Shared Sub Ventana1()

        Application.Run(New Form1)

    End Sub

    'procedimiento que muestra el segundo formulario

    Public Shared Sub Ventana2()

        Application.Run(New Form2)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        Me.Top = 220

        Me.Left = 220

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        Me.Show()

        Dim parar As Integer

        Do While parar < 1000

            Me.Label1.Text = parar.ToString()

            parar = parar + 1

        Loop
        Form2.Show()
    End Sub

    Private Sub BotonCerrar_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Application.Exit()

    End Sub

    Private Sub BotonCerrar2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
