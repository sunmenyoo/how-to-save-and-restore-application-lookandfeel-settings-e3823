Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsApplication1
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            DevExpress.UserSkins.BonusSkins.Register()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New RibbonForm1())
        End Sub
    End Class
End Namespace