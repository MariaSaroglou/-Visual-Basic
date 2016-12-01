Imports Awesomium.Core

Public Class tab2
    Private Sub tab2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebControl1.Source = New Uri(My.Settings.Homepage)
    End Sub



    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebControl1.Source = New Uri(My.Settings.Homepage)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = ("http://" + TextBox1.Text)

            End Try
        Else : WebControl1.Source = New Uri("https://www.google.gr/search?q=" & TextBox1.Text)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebControl1.Reload(ignoreCache:=True)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)

                End Try
            Else : WebControl1.Source = New Uri("https://www.google.gr/search?q=" & TextBox1.Text)

            End If
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As Awesomium.Core.ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString
    End Sub

    Private Sub TheProgrammerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TheProgrammerToolStripMenuItem1.Click
        MessageBox.Show("Τα σκωτεινά φώτα εξέπεμπαν έντονη θερμότητα μέσα στο θάλαμο των αρχείων.Αυτός εδώ ήταν πολύ μικρότερος από τον προηγούμενο τον οποίο είχε βρει ο Λάνγκτον.Λιγότερος αέρας.Λιγότερος χρόνος.Ευχόταν να μην έχει ξεχάσει να ζητήσει από τον Ολιβέτης να θέσει το σύστημα ανανέωσης του οξυγόνου.", "The Programer")
    End Sub

    Private Sub TheBrowserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TheBrowserToolStripMenuItem1.Click
        MessageBox.Show("Ο Λάνγκτον εντόπισε γρήγορα το τμήμα των περιουσιακών στοιχείων που αφορούσε τα έργα τέχνης.Ήταν αδύνατο να περάσει απαρατήρητο.Οι κατάλογοι γέμιζαν οχτώ ολόκληρες βιβλιοθήκες που η καθολική εκκλησία είχε στην κατοχή της εκατομμύρια κομμάτια σε ολόκληρο τον κόσμο.Ο Λάνγκτον έψαξε στα ράφια αναζητώντας τον Γιαν Λορέντζο Μπερνίνι.Άρχισε την έρευνά του από την μέση της πρώτης βιβλιοθήκης από εκεί περίπου οπου υπέθετε ότι θα άρχιζε το λατινικό γράμμα Βήτα.", "The Browser")
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTabToolStripMenuItem.Click
        If My.Settings.newtab = 1 Then
            Dim tab2 As New TabPage
            Dim newtab As New tab2
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab2.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab2)
            Form1.TabControl1.SelectedTab = tab2
        End If
        If My.Settings.newtab = 2 Then
            Dim tab2 As New TabPage
            Dim newtab As New tab2
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab2.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab2)

        End If
    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        If Form1.TabControl1.TabCount = 1 Then
            Dim tab2 As New TabPage
            Dim newtab As New tab2
            newtab.Show()
            newtab.Dock = DockStyle.Fill
            newtab.TopLevel = False
            tab2.Controls.Add(newtab)
            Form1.TabControl1.TabPages.Add(tab2)
            Form1.TabControl1.SelectedTab = tab2
            Form1.TabControl1.SelectedTab.Dispose()
        Else Form1.TabControl1.SelectedTab.Dispose()
        End If
    End Sub
End Class