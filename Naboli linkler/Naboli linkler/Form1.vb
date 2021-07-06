Public Class Form1
    Dim time As Integer = 0
    Dim newpoint As New System.Drawing.Point
    Dim x, y As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        time = 0
        show()
        Timer1.Start()
        Process.Start("http://gazi-international.gazi.edu.tr/")
        Process.Start("https://www.ankara.edu.tr/kategori/duyurular/")
        Process.Start("https://yos.istanbul.edu.tr/tr/_")
        Process.Start("http://www.sis.itu.edu.tr/")
        Process.Start("https://iso.metu.edu.tr/tr")
        Process.Start("http://www.iso.hacettepe.edu.tr/duyurular.shtml")
        Process.Start("https://www.gtu.edu.tr/kategori/2916/3/display.aspx")
        Process.Start("https://yos.ege.edu.tr/")
        Process.Start("http://adaylar.boun.edu.tr/tr-TR/Sayfa/Basvuru/YurtDisindanOgrenciKabulu/Tum")
        Process.Start("https://www.sabanciuniv.edu/tr/lisans-programlarina-yurt-disindan-ogrenci-kabulu")
        Process.Start("http://www.admissions.yildiz.edu.tr/")
        Process.Start("https://oia.atauni.edu.tr/atayos/")
        Process.Start("https://muyos.marmara.edu.tr/")
        Process.Start("https://yos.istanbulc.edu.tr/tr/_")
        Process.Start("http://deyos.deu.edu.tr/tr/")
        Process.Start("https://erisco.erciyes.edu.tr/Duyuru-Detay/3102/yabanci-uyruklu-ogrenci-sinavi-(eruyos---2020)-basvurulari-basladi")
        Process.Start("https://selcuk.edu.tr/ogrenci_isleri/Ayrinti/yonergeler-4570")
        Process.Start("https://www.ktu.edu.tr/iso")
        Process.Start("https://uio.iyte.edu.tr/")
        Process.Start("http://iso.cu.edu.tr/")
        Process.Start("http://yos.firat.edu.tr/")
        Process.Start("https://oidb.ogu.edu.tr/Sayfa/Index/152/uluslararasi-ogrenci")
        Process.Start("https://studyinsau.sakarya.edu.tr/")
        Process.Start("https://yos.akdeniz.edu.tr/")
        Process.Start("https://www.anadolu.edu.tr/ogrenci-isleri/orgun-bilgi-ve-belgeler/yabanci-uyruklu-ogrenci-basvurusu")
        Process.Start("https://yos.sdu.edu.tr/")
    End Sub


    '[gazi]
    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Process.Start("http://gazi-international.gazi.edu.tr/")
        time = 0
        Label12.Visible = True
        PictureBox22.Visible = True
        Timer1.Start()
    End Sub

    '[Ankara]
    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        Process.Start("https://www.ankara.edu.tr/kategori/duyurular/")
        time = 0
        Label11.Visible = True
        PictureBox21.Visible = True
        Timer1.Start()
    End Sub

    '[İstanbul]
    Private Sub PictureBox60_Click(sender As Object, e As EventArgs) Handles PictureBox60.Click
        Process.Start("https://yos.istanbul.edu.tr/tr/_")
        time = 0
        Label30.Visible = True
        PictureBox58.Visible = True
        Timer1.Start()
    End Sub

    '[istanbul teknik]
    Private Sub PictureBox59_Click(sender As Object, e As EventArgs) Handles PictureBox59.Click
        Process.Start("http://www.sis.itu.edu.tr/")
        time = 0
        Label29.Visible = True
        PictureBox57.Visible = True
        Timer1.Start()
    End Sub

    '[orta doğu]
    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        Process.Start("https://iso.metu.edu.tr/tr")
        time = 0
        Label25.Visible = True
        PictureBox48.Visible = True
        Timer1.Start()
    End Sub

    '[hacettepe]
    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        Process.Start("http://www.iso.hacettepe.edu.tr/duyurular.shtml")
        time = 0
        Label24.Visible = True
        PictureBox47.Visible = True
        Timer1.Start()
    End Sub

    '[GEBZE TEKNIK]
    Private Sub PictureBox46_Click(sender As Object, e As EventArgs) Handles PictureBox46.Click
        Process.Start("https://www.gtu.edu.tr/kategori/2916/3/display.aspx")
        time = 0
        Label23.Visible = True
        PictureBox44.Visible = True
        Timer1.Start()
    End Sub

    '[EGE]
    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        Process.Start("https://yos.ege.edu.tr/")
        time = 0
        Label22.Visible = True
        PictureBox43.Visible = True
        Timer1.Start()
    End Sub


    '[BOĞAZİÇİ]
    Private Sub PictureBox70_Click(sender As Object, e As EventArgs) Handles PictureBox70.Click
        Process.Start("http://adaylar.boun.edu.tr/tr-TR/Sayfa/Basvuru/YurtDisindanOgrenciKabulu/Tum")
        time = 0
        Label35.Visible = True
        PictureBox68.Visible = True
        Timer1.Start()
    End Sub

    '[SABANCI]
    Private Sub PictureBox69_Click(sender As Object, e As EventArgs) Handles PictureBox69.Click
        Process.Start("https://www.sabanciuniv.edu/tr/lisans-programlarina-yurt-disindan-ogrenci-kabulu")
        time = 0
        Label34.Visible = True
        PictureBox67.Visible = True
        Timer1.Start()
    End Sub

    '[YILDIZ Teknik]
    Private Sub PictureBox80_Click(sender As Object, e As EventArgs) Handles PictureBox80.Click
        Process.Start("http://www.admissions.yildiz.edu.tr/")
        time = 0
        Label40.Visible = True
        PictureBox78.Visible = True
        Timer1.Start()
    End Sub

    '[ATATURK]
    Private Sub PictureBox79_Click(sender As Object, e As EventArgs) Handles PictureBox79.Click
        Process.Start("https://oia.atauni.edu.tr/atayos/")
        time = 0
        Label39.Visible = True
        PictureBox77.Visible = True
        Timer1.Start()
    End Sub

    '[MARMARA]
    Private Sub PictureBox90_Click(sender As Object, e As EventArgs) Handles PictureBox90.Click
        Process.Start("https://muyos.marmara.edu.tr/")
        time = 0
        Label45.Visible = True
        PictureBox88.Visible = True
        Timer1.Start()
    End Sub

    '[CERRAHPAŞA]
    Private Sub PictureBox89_Click(sender As Object, e As EventArgs) Handles PictureBox89.Click
        Process.Start("https://yos.istanbulc.edu.tr/tr/_")
        time = 0
        Label44.Visible = True
        PictureBox87.Visible = True
        Timer1.Start()
    End Sub

    '[DOKUZ EYLÜL]
    Private Sub PictureBox100_Click(sender As Object, e As EventArgs) Handles PictureBox100.Click
        Process.Start("http://deyos.deu.edu.tr/tr/")
        time = 0
        Label50.Visible = True
        PictureBox98.Visible = True
        Timer1.Start()
    End Sub

    '[ERCIYES]
    Private Sub PictureBox99_Click(sender As Object, e As EventArgs) Handles PictureBox99.Click
        Process.Start("https://erisco.erciyes.edu.tr/Duyuru-Detay/3102/yabanci-uyruklu-ogrenci-sinavi-(eruyos---2020)-basvurulari-basladi")
        time = 0
        Label49.Visible = True
        PictureBox97.Visible = True
        Timer1.Start()
    End Sub

    '[SELÇUK]
    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Process.Start("https://selcuk.edu.tr/ogrenci_isleri/Ayrinti/yonergeler-4570")
        time = 0
        Label14.Visible = True
        PictureBox26.Visible = True
        Timer1.Start()
    End Sub

    '[KARADENİZ]
    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        Process.Start("https://www.ktu.edu.tr/iso")
        time = 0
        Label13.Visible = True
        PictureBox25.Visible = True
        Timer1.Start()
    End Sub

    '[IZMİR YÜKSEK TEKNOLOJİ ENSTİTÜSÜ]
    Private Sub PictureBox38_Click(sender As Object, e As EventArgs) Handles PictureBox38.Click
        Process.Start("https://uio.iyte.edu.tr/")
        time = 0
        Label19.Visible = True
        PictureBox36.Visible = True
        Timer1.Start()
    End Sub

    '[ÇUKUROVA]
    Private Sub PictureBox37_Click(sender As Object, e As EventArgs) Handles PictureBox37.Click
        Process.Start("http://iso.cu.edu.tr/")
        time = 0
        Label18.Visible = True
        PictureBox35.Visible = True
        Timer1.Start()
    End Sub

    '[FIRAT]
    Private Sub PictureBox108_Click(sender As Object, e As EventArgs) Handles PictureBox108.Click
        Process.Start("http://yos.firat.edu.tr/")
        time = 0
        Label54.Visible = True
        PictureBox106.Visible = True
        Timer1.Start()
    End Sub

    '[ESKIŞEHER OSMANGAZİ]
    Private Sub PictureBox107_Click(sender As Object, e As EventArgs) Handles PictureBox107.Click
        Process.Start("https://oidb.ogu.edu.tr/Sayfa/Index/152/uluslararasi-ogrenci")
        time = 0
        Label53.Visible = True
        PictureBox105.Visible = True
        Timer1.Start()
    End Sub

    '[SAKARYA]
    Private Sub PictureBox118_Click(sender As Object, e As EventArgs) Handles PictureBox118.Click
        Process.Start("https://studyinsau.sakarya.edu.tr/")
        time = 0
        Label59.Visible = True
        PictureBox116.Visible = True
        Timer1.Start()
    End Sub

    '[AKDENİZ]
    Private Sub PictureBox117_Click(sender As Object, e As EventArgs) Handles PictureBox117.Click
        Process.Start("https://yos.akdeniz.edu.tr/")
        time = 0
        Label58.Visible = True
        PictureBox115.Visible = True
        Timer1.Start()
    End Sub


    '[ANADOLU]
    Private Sub PictureBox128_Click(sender As Object, e As EventArgs) Handles PictureBox128.Click
        Process.Start("https://www.anadolu.edu.tr/ogrenci-isleri/orgun-bilgi-ve-belgeler/yabanci-uyruklu-ogrenci-basvurusu")
        time = 0
        Label64.Visible = True
        PictureBox126.Visible = True
        Timer1.Start()
    End Sub

    '[SULEYMAN DEMIRAL]
    Private Sub PictureBox127_Click(sender As Object, e As EventArgs) Handles PictureBox127.Click
        Process.Start("https://yos.sdu.edu.tr/")
        time = 0
        Label63.Visible = True
        PictureBox125.Visible = True
        Timer1.Start()
    End Sub





    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
        If time = 160 Then
            hide()
            Timer1.Stop()
        End If
    End Sub

    Sub show()
        Label12.Visible = True
        Label11.Visible = True
        Label30.Visible = True
        Label29.Visible = True
        Label25.Visible = True
        Label24.Visible = True
        Label23.Visible = True
        Label22.Visible = True
        Label35.Visible = True
        Label34.Visible = True
        Label40.Visible = True
        Label39.Visible = True
        Label45.Visible = True
        Label44.Visible = True
        Label50.Visible = True
        Label49.Visible = True
        Label14.Visible = True
        Label13.Visible = True
        Label19.Visible = True
        Label18.Visible = True
        Label54.Visible = True
        Label53.Visible = True
        Label59.Visible = True
        Label58.Visible = True
        Label64.Visible = True
        Label63.Visible = True



        PictureBox22.Visible = True
        PictureBox21.Visible = True
        PictureBox58.Visible = True
        PictureBox57.Visible = True
        PictureBox48.Visible = True
        PictureBox47.Visible = True
        PictureBox44.Visible = True
        PictureBox43.Visible = True
        PictureBox68.Visible = True
        PictureBox67.Visible = True
        PictureBox78.Visible = True
        PictureBox77.Visible = True
        PictureBox88.Visible = True
        PictureBox87.Visible = True
        PictureBox98.Visible = True
        PictureBox97.Visible = True
        PictureBox26.Visible = True
        PictureBox25.Visible = True
        PictureBox36.Visible = True
        PictureBox35.Visible = True
        PictureBox106.Visible = True
        PictureBox105.Visible = True
        PictureBox116.Visible = True
        PictureBox115.Visible = True
        PictureBox126.Visible = True
        PictureBox125.Visible = True
    End Sub

    Sub hide()
        Label12.Visible = False
        Label11.Visible = False
        Label30.Visible = False
        Label29.Visible = False
        Label25.Visible = False
        Label24.Visible = False
        Label23.Visible = False
        Label22.Visible = False
        Label35.Visible = False
        Label34.Visible = False
        Label40.Visible = False
        Label39.Visible = False
        Label45.Visible = False
        Label44.Visible = False
        Label50.Visible = False
        Label49.Visible = False
        Label14.Visible = False
        Label13.Visible = False
        Label19.Visible = False
        Label18.Visible = False
        Label54.Visible = False
        Label53.Visible = False
        Label59.Visible = False
        Label58.Visible = False
        Label64.Visible = False
        Label63.Visible = False



        PictureBox22.Visible = False
        PictureBox21.Visible = False
        PictureBox58.Visible = False
        PictureBox57.Visible = False
        PictureBox48.Visible = False
        PictureBox47.Visible = False
        PictureBox44.Visible = False
        PictureBox43.Visible = False
        PictureBox68.Visible = False
        PictureBox67.Visible = False
        PictureBox78.Visible = False
        PictureBox77.Visible = False
        PictureBox88.Visible = False
        PictureBox87.Visible = False
        PictureBox98.Visible = False
        PictureBox97.Visible = False
        PictureBox26.Visible = False
        PictureBox25.Visible = False
        PictureBox36.Visible = False
        PictureBox35.Visible = False
        PictureBox106.Visible = False
        PictureBox105.Visible = False
        PictureBox116.Visible = False
        PictureBox115.Visible = False
        PictureBox126.Visible = False
        PictureBox125.Visible = False

    End Sub




    '**********Window Move Cods**********'
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint
        End If
    End Sub


    '*******Buttons cods********'
    Private Sub PictureBox11_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseClick
        Application.Exit()
    End Sub

    '*****Window size cods******'
    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub PictureBox14_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox14.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub



    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub






    'Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
    '    PictureBox1.Size = New System.Drawing.Size(125, 125)

    'End Sub

    'Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
    '    PictureBox1.Size = New System.Drawing.Size(120, 120)

    'End Sub













End Class
