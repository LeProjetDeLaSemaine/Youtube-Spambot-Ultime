Public Class Form1
    Dim Sep As Char
    Dim Nombre As Double
    Const useragent As String = "User-Agent:"
    Dim userpers As String = Nothing
    Dim factaleat As Integer
    Dim listuserprepa As System.Collections.Specialized.StringCollection
    Public useragentdictionnary As New Dictionary(Of Integer, String)
    Dim aleatuser As Integer
    Dim latencebonus As Integer = 6000


    Private Sub CommencerSpam(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If My.Settings.Avertissement = True Then
            Dialog1.ShowDialog()
            If Dialog1.DialogResult = Windows.Forms.DialogResult.OK Then
                allnavigate()
                Timer1.Start()
                Timer1.Interval = Int(ToolStripTextBox2.Text) + factaleat + 1
            End If
        Else
            allnavigate()
            Timer1.Start()
            Timer1.Interval = Int(ToolStripTextBox2.Text) + factaleat + 1
        End If
    End Sub

    Private Sub MasqueEntiers(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ToolStripTextBox2.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or e.KeyChar.Equals(Sep) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        additemsdict()
        My.Settings.Reload()
        Me.WindowState = FormWindowState.Maximized
        Sep = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        ToolStripTextBox2.Focus()
        ToolStripTextBox2.Text = 0

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        allnavigate()
        factaleat = (Rnd() * 2000) + latencebonus
        Timer1.Interval = Int(ToolStripTextBox2.Text) + factaleat
    End Sub
    Private Sub allnavigate()
        aleatuser = Int(Rnd() * 100)
        Label1.Text = useragentdictionnary(aleatuser)
        WebBrowser1.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label1.Text)
        aleatuser = Int(Rnd() * 100)
        Label2.Text = useragentdictionnary(aleatuser)
        WebBrowser2.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label2.Text)
        aleatuser = Int(Rnd() * 100)
        Label3.Text = useragentdictionnary(aleatuser)
        WebBrowser3.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label3.Text)
        aleatuser = Int(Rnd() * 100)
        Label4.Text = useragentdictionnary(aleatuser)
        WebBrowser4.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label4.Text)
        aleatuser = Int(Rnd() * 100)
        Label5.Text = useragentdictionnary(aleatuser)
        WebBrowser5.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label5.Text)
        aleatuser = Int(Rnd() * 100)
        Label6.Text = useragentdictionnary(aleatuser)
        WebBrowser6.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label6.Text)
        aleatuser = Int(Rnd() * 100)
        Label7.Text = useragentdictionnary(aleatuser)
        WebBrowser7.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label7.Text)
        aleatuser = Int(Rnd() * 100)
        Label8.Text = useragentdictionnary(aleatuser)
        WebBrowser8.Navigate(ToolStripTextBox1.Text, Nothing, Nothing, useragent + Label8.Text)
    End Sub

    Private Sub ArrêterSpam(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Timer1.Stop()
    End Sub


    Private Sub RechercherViaMoteurDeRecherche_EnL_OccurenceDuckDuckGO_L_URLQueJeNeConnaisPas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim newnavig As New Form2
        newnavig.Show()
    End Sub
    Private Sub additemsdict()
        For i As Integer = 0 To 16
            useragentdictionnary.Add(i, "Mozilla/5.0 (Windows NT 6.3; Trident/7.0; rv:11.0) like Gecko")
        Next
        For i As Integer = 17 To 50
            useragentdictionnary.Add(i, "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/27.0.1453.110 Safari/537.36")
        Next
        For i As Integer = 51 To 66
            useragentdictionnary.Add(i, "Mozilla/5.0 (Windows; U; Windows NT 6.1; fr; rv:1.9.2) Gecko/20100115 Firefox/3.6")
        Next
        For i As Integer = 67 To 74
            useragentdictionnary.Add(i, "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_5; fr-fr) AppleWebKit/525.18 (KHTML, like Gecko) Version/3.1.2 Safari/525.20.1")
        Next
        For i As Integer = 75 To 79
            useragentdictionnary.Add(i, "Mozilla/5.0 (Linux; U; Android 2.3.3; fr-fr; GT-I9100 Build/GINGERBREAD) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1")
        Next
        For i As Integer = 80 To 84
            useragentdictionnary.Add(i, "Mozilla/5.0 (iPod; U; CPU iPhone OS 2_1 like Mac OS X; fr-fr) AppleWebKit/525.18.1 (KHTML, like Gecko) Version/3.1.1 Mobile/5F137 Safari/525.20")
        Next
        For i As Integer = 85 To 86
            useragentdictionnary.Add(i, "Opera/9.25 (X11; Linux i686; U; fr-ca)")
        Next
        For i As Integer = 87 To 90
            useragentdictionnary.Add(i, "Opera/9.80 (Android 2.3.6; Linux; Opera Mobi/ADR-1207201819; U; fr) Presto/2.10.254 Version/12.00")
        Next
        useragentdictionnary.Add(91, "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)")
        useragentdictionnary.Add(92, "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)")
        useragentdictionnary.Add(93, "Mozilla/5.0 (X11; Linux x86_64; rv:19.0) Gecko/20100101 Firefox/19.0")
        useragentdictionnary.Add(94, "Mozilla/5.0 (Macintosh; U; PPC Mac OS X Mach-O; en-US; rv:1.7.12) Gecko/20050915 Firefox/1.0.7")
        useragentdictionnary.Add(95, "Mozilla/5.0 (X11; U; Linux x86_64; en-us) AppleWebKit/528.5+ (KHTML, like Gecko, Safari/528.5+) midori")
        useragentdictionnary.Add(96, "Mozilla/4.0 (compatible; Windows NT 6.1; Super Foussard Navigator/8.5.3; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)")
        useragentdictionnary.Add(97, "Mozilla/5.0 (X11; U; Linux i686; fr-FR) AppleWebKit/533.3 (KHTML, like Gecko) konqueror/4.6.80 Safari/533.3")
        useragentdictionnary.Add(98, "N-Gage QD — NokiaN-GageQD/2.0 (4.103) SymbianOS/6.1 Series60/1.2 Profile/MIDP-1.0 Configuration/CLDC-1.0")
        useragentdictionnary.Add(99, "Mozilla/5.0 (X11; U; Linux i686; en-US; rv:1.7.8) Gecko/20050511")
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        latencebonus = 8000
        MsgBox("configuration optimisée pour: connexion lente")
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        latencebonus = 4000
        MsgBox("configuration optimisée pour: connexion rapide")
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        latencebonus = 6000
        MsgBox("configuration optimisée pour: connexion normale")
    End Sub
End Class
