Imports System.IO
Public Class Form1

    Const RepertoireALister As String = "."

    Private Sub BT_Browse_Click(sender As Object, e As EventArgs) Handles BT_Browse.Click
        'Declaration d'une boite de dialogue
        Dim FD As FolderBrowserDialog

        'Creation d'une nouvelle boite de dialogue
        FD = New FolderBrowserDialog

        'Descriptif et fichier source
        FD.Description = "Select MIBand4 Extracted Folder"
        FD.RootFolder = Environment.SpecialFolder.DesktopDirectory        'Affichage de la boite de dialogue
        FD.ShowDialog()

        'Affichage du dossier selectionner
        Me.TXT_FolderPath.Text = FD.SelectedPath

        Dim di As New IO.DirectoryInfo(TXT_FolderPath.Text)
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.json")
        Dim fi As IO.FileInfo

        For Each fi In aryFi
            Me.TXT_JSON.Text = fi.Name
        Next

    End Sub


    Private Sub BT_READJSON_Click(sender As Object, e As EventArgs) Handles BT_READJSON.Click
        Dim directory As New IO.DirectoryInfo(Me.TXT_FolderPath.Text)
        Dim gauche As String
        Dim debut As String
        Me.ListBox1.Items.Clear()

        If directory.Exists Then
            Dim pngFiles() As IO.FileInfo = directory.GetFiles("*.png")
            For Each pngfile As IO.FileInfo In pngFiles
                gauche = pngfile.Name
                debut = gauche.Substring(0, 1)
                If debut = "0" Then
                    Me.ListBox1.Items.Add(pngfile.Name)
                End If
            Next
        End If
    End Sub

    Private Sub BT_LOADIMAGES_Click(sender As Object, e As EventArgs) Handles BT_LOADIMAGES.Click
        Dim fullchemin As String
        Dim valeur As String

        For i = 0 To ListBox1.Items.Count - 1

            valeur = ListBox1.Items(i)
            fullchemin = TXT_FolderPath.Text & "\" & valeur

            If valeur = "0000.png" Then Me.PictureBox0.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox0.Height, PictureBox0.Width)
            If valeur = "0001.png" Then Me.PictureBox1.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox1.Height, PictureBox1.Width)
            If valeur = "0002.png" Then Me.PictureBox2.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox2.Height, PictureBox2.Width)
            If valeur = "0003.png" Then Me.PictureBox3.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox3.Height, PictureBox3.Width)
            If valeur = "0004.png" Then Me.PictureBox4.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox4.Height, PictureBox4.Width)
            If valeur = "0005.png" Then Me.PictureBox5.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox5.Height, PictureBox5.Width)
            If valeur = "0006.png" Then Me.PictureBox6.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox6.Height, PictureBox6.Width)
            If valeur = "0007.png" Then Me.PictureBox7.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox7.Height, PictureBox7.Width)
            If valeur = "0008.png" Then Me.PictureBox8.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox8.Height, PictureBox8.Width)
            If valeur = "0009.png" Then Me.PictureBox9.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox9.Height, PictureBox9.Width)
            If valeur = "0010.png" Then Me.PictureBox10.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox10.Height, PictureBox10.Width)
            If valeur = "0011.png" Then Me.PictureBox11.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox11.Height, PictureBox11.Width)
            If valeur = "0012.png" Then Me.PictureBox12.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox12.Height, PictureBox12.Width)
            If valeur = "0013.png" Then Me.PictureBox13.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox13.Height, PictureBox13.Width)
            If valeur = "0014.png" Then Me.PictureBox14.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox14.Height, PictureBox14.Width)
            If valeur = "0015.png" Then Me.PictureBox15.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox15.Height, PictureBox15.Width)
            If valeur = "0016.png" Then Me.PictureBox16.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox16.Height, PictureBox16.Width)
            If valeur = "0017.png" Then Me.PictureBox17.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox17.Height, PictureBox17.Width)
            If valeur = "0018.png" Then Me.PictureBox18.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox18.Height, PictureBox18.Width)
            If valeur = "0019.png" Then Me.PictureBox19.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox19.Height, PictureBox19.Width)
            If valeur = "0020.png" Then Me.PictureBox20.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox20.Height, PictureBox20.Width)
            If valeur = "0021.png" Then Me.PictureBox21.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox21.Height, PictureBox21.Width)
            If valeur = "0022.png" Then Me.PictureBox22.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox22.Height, PictureBox22.Width)
            If valeur = "0023.png" Then Me.PictureBox23.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox23.Height, PictureBox23.Width)
            If valeur = "0024.png" Then Me.PictureBox24.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox24.Height, PictureBox24.Width)
            If valeur = "0025.png" Then Me.PictureBox25.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox25.Height, PictureBox25.Width)
            If valeur = "0026.png" Then Me.PictureBox26.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox26.Height, PictureBox26.Width)
            If valeur = "0027.png" Then Me.PictureBox27.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox27.Height, PictureBox27.Width)
            If valeur = "0028.png" Then Me.PictureBox28.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox28.Height, PictureBox28.Width)
            If valeur = "0029.png" Then Me.PictureBox29.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox29.Height, PictureBox29.Width)
            If valeur = "0030.png" Then Me.PictureBox30.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox30.Height, PictureBox30.Width)
            If valeur = "0031.png" Then Me.PictureBox31.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox31.Height, PictureBox31.Width)
            If valeur = "0032.png" Then Me.PictureBox32.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox32.Height, PictureBox32.Width)
            If valeur = "0033.png" Then Me.PictureBox33.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox33.Height, PictureBox33.Width)
            If valeur = "0034.png" Then Me.PictureBox34.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox34.Height, PictureBox34.Width)
            If valeur = "0035.png" Then Me.PictureBox35.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox35.Height, PictureBox35.Width)
            If valeur = "0036.png" Then Me.PictureBox36.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox36.Height, PictureBox36.Width)
            If valeur = "0037.png" Then Me.PictureBox37.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox37.Height, PictureBox37.Width)
            If valeur = "0038.png" Then Me.PictureBox38.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox38.Height, PictureBox38.Width)
            If valeur = "0039.png" Then Me.PictureBox39.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox39.Height, PictureBox39.Width)
            If valeur = "0040.png" Then Me.PictureBox40.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox40.Height, PictureBox40.Width)
            If valeur = "0041.png" Then Me.PictureBox41.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox41.Height, PictureBox41.Width)
            If valeur = "0042.png" Then Me.PictureBox42.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox42.Height, PictureBox42.Width)
            If valeur = "0043.png" Then Me.PictureBox43.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox43.Height, PictureBox43.Width)
            If valeur = "0044.png" Then Me.PictureBox44.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox44.Height, PictureBox44.Width)
            If valeur = "0045.png" Then Me.PictureBox45.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox45.Height, PictureBox45.Width)
            If valeur = "0046.png" Then Me.PictureBox46.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox46.Height, PictureBox46.Width)
            If valeur = "0047.png" Then Me.PictureBox47.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox47.Height, PictureBox47.Width)
            If valeur = "0048.png" Then Me.PictureBox48.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox48.Height, PictureBox48.Width)
            If valeur = "0049.png" Then Me.PictureBox49.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox49.Height, PictureBox49.Width)
            If valeur = "0050.png" Then Me.PictureBox50.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox50.Height, PictureBox50.Width)
            If valeur = "0051.png" Then Me.PictureBox51.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox51.Height, PictureBox51.Width)
            If valeur = "0052.png" Then Me.PictureBox52.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox52.Height, PictureBox52.Width)
            If valeur = "0053.png" Then Me.PictureBox53.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox53.Height, PictureBox53.Width)
            If valeur = "0054.png" Then Me.PictureBox54.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox54.Height, PictureBox54.Width)
            If valeur = "0055.png" Then Me.PictureBox55.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox55.Height, PictureBox55.Width)
            If valeur = "0056.png" Then Me.PictureBox56.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox56.Height, PictureBox56.Width)
            If valeur = "0057.png" Then Me.PictureBox57.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox57.Height, PictureBox57.Width)
            If valeur = "0058.png" Then Me.PictureBox58.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox58.Height, PictureBox58.Width)
            If valeur = "0059.png" Then Me.PictureBox59.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox59.Height, PictureBox59.Width)
            If valeur = "0060.png" Then Me.PictureBox60.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox60.Height, PictureBox60.Width)
            If valeur = "0061.png" Then Me.PictureBox61.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox61.Height, PictureBox61.Width)
            If valeur = "0062.png" Then Me.PictureBox62.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox62.Height, PictureBox62.Width)
            If valeur = "0063.png" Then Me.PictureBox63.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox63.Height, PictureBox63.Width)
            If valeur = "0064.png" Then Me.PictureBox64.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox64.Height, PictureBox64.Width)
            If valeur = "0065.png" Then Me.PictureBox65.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox65.Height, PictureBox65.Width)
            If valeur = "0066.png" Then Me.PictureBox66.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox66.Height, PictureBox66.Width)
            If valeur = "0067.png" Then Me.PictureBox67.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox67.Height, PictureBox67.Width)
            If valeur = "0068.png" Then Me.PictureBox68.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox68.Height, PictureBox68.Width)
            If valeur = "0069.png" Then Me.PictureBox69.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox69.Height, PictureBox69.Width)
            If valeur = "0070.png" Then Me.PictureBox70.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox70.Height, PictureBox70.Width)
            If valeur = "0071.png" Then Me.PictureBox71.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox71.Height, PictureBox71.Width)
            If valeur = "0072.png" Then Me.PictureBox72.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox72.Height, PictureBox72.Width)
            If valeur = "0073.png" Then Me.PictureBox73.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox73.Height, PictureBox73.Width)
            If valeur = "0074.png" Then Me.PictureBox74.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox74.Height, PictureBox74.Width)
            If valeur = "0075.png" Then Me.PictureBox75.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox75.Height, PictureBox75.Width)
            If valeur = "0076.png" Then Me.PictureBox76.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox76.Height, PictureBox76.Width)
            If valeur = "0077.png" Then Me.PictureBox77.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox77.Height, PictureBox77.Width)
            If valeur = "0078.png" Then Me.PictureBox78.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox78.Height, PictureBox78.Width)
            If valeur = "0079.png" Then Me.PictureBox79.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox79.Height, PictureBox79.Width)
            If valeur = "0080.png" Then Me.PictureBox80.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox80.Height, PictureBox80.Width)
            If valeur = "0081.png" Then Me.PictureBox81.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox81.Height, PictureBox81.Width)
            If valeur = "0082.png" Then Me.PictureBox82.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox82.Height, PictureBox82.Width)
            If valeur = "0083.png" Then Me.PictureBox83.Image = ScaleImage(Image.FromFile(fullchemin), PictureBox83.Height, PictureBox83.Width)


        Next

    End Sub

    Function ScaleImage(ByVal OldImage As Image, ByVal TargetHeight As Integer, ByVal TargetWidth As Integer) As System.Drawing.Image

        Dim NewHeight As Integer = TargetHeight
        Dim NewWidth As Integer = NewHeight / OldImage.Height * OldImage.Width

        If NewWidth > TargetWidth Then
            NewWidth = TargetWidth
            NewHeight = NewWidth / OldImage.Width * OldImage.Height
        End If

        Return New Bitmap(OldImage, NewWidth, NewHeight)

    End Function


End Class





'Private Sub RechercherJson()
'Dim request As HttpWebRequest
'Dim response As HttpWebResponse = Nothing
'Dim reader As StreamReader
'
'request = DirectCast(WebRequest.Create("https://url.to.my.json"), HttpWebRequest)
'response = DirectCast(request.GetResponse(), HttpWebResponse)
'reader = New StreamReader(response.GetResponseStream())
'
'Dm rawresp As String
'rawresp = reader.ReadToEnd()
'
'
'textbox2.text = JObject.Parse(rawresp)("id")
'End Sub

