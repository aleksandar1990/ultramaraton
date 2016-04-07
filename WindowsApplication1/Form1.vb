Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop



Public Class Form1

    Dim fmScrollBarsVertical As Object
    Dim ScrollBars As Object
    Dim ScrollHeight As Object
    Dim ScrollWidth As Object
    Dim InsideWidth As Integer
    Dim InsideHeight As Integer

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.FileSystem.CreateDirectory _
        ("C:\rezultati")
        Dim file As System.IO.FileStream
        file = System.IO.File.Create("c:\rezultati\rezultati.txt")
        file = System.IO.File.Create("c:\rezultati\rez.xls")
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = "0"
        Label2.Text = "00"
        Label3.Text = "00"
        Label4.Text = "0"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Interval = 1
        Label3.Text += 1
        If Label3.Text = 64 Then
            Label2.Text += 1
            Label3.Text = 0
        End If
        If Label2.Text = 60 Then
            Label1.Text += 1
            Label2.Text = 0
            Label3.Text = 0
            Button19_Click(Button19, e)
        End If
        If Label1.Text = 60 Then
            Label4.Text += 1
            Label1.Text = 0
            Label2.Text = 0
            Label3.Text = 0
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            ListView1.Items(i).Text = i + 1.ToString

        Next

        Dim item1 As ListViewItem = New ListViewItem(i + 1.ToString)
        item1.SubItems.Add(Label4.Text)
        item1.SubItems.Add(Label1.Text)
        item1.SubItems.Add(Label2.Text)
        ListView1.Items.Add(item1)

        ListView1.EnsureVisible(ListView1.Items.Count - 1)
        ListView1.Update()

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i1 As Integer
        For i1 = 0 To ListView2.Items.Count - 1
            ListView2.Items(i1).Text = i1 + 1.ToString
        Next

        Dim item2 As ListViewItem = New ListViewItem(i1 + 1.ToString)
        item2.SubItems.Add(Label4.Text)
        item2.SubItems.Add(Label1.Text)
        item2.SubItems.Add(Label2.Text)
        ListView2.Items.Add(item2)

        ListView2.EnsureVisible(ListView2.Items.Count - 1)
        ListView2.Update()

        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i3 As Integer
        For i3 = 0 To ListView3.Items.Count - 1
            ListView3.Items(i3).Text = i3 + 1.ToString
        Next

        Dim item3 As ListViewItem = New ListViewItem(i3 + 1.ToString)
        item3.SubItems.Add(Label4.Text)
        item3.SubItems.Add(Label1.Text)
        item3.SubItems.Add(Label2.Text)
        ListView3.Items.Add(item3)

        ListView3.EnsureVisible(ListView3.Items.Count - 1)
        ListView3.Update()

        ListView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = 700

        'Me.Panel1.VerticalScroll.Visible = True
        'Me.Panel1.VerticalScroll.Enabled = True

        'Me.Panel2.VerticalScroll.Visible = True
        'Me.Panel2.VerticalScroll.Enabled = True

        'Me.Panel1.Select()
        'Me.Panel2.Select()

        Me.AutoScroll = True

        Me.ListView1.Columns.Add("KRUG")
        Me.ListView1.Columns.Add("SAT")
        Me.ListView1.Columns.Add("MIN")
        Me.ListView1.Columns.Add("SEK")

        Me.ListView1.View = View.Details

        Me.ListView2.Columns.Add("KRUG")
        Me.ListView2.Columns.Add("SAT")
        Me.ListView2.Columns.Add("MIN")
        Me.ListView2.Columns.Add("SEK")

        Me.ListView2.View = View.Details

        Me.ListView3.Columns.Add("KRUG")
        Me.ListView3.Columns.Add("SAT")
        Me.ListView3.Columns.Add("MIN")
        Me.ListView3.Columns.Add("SEK")

        Me.ListView3.View = View.Details

        Me.ListView4.Columns.Add("KRUG")
        Me.ListView4.Columns.Add("SAT")
        Me.ListView4.Columns.Add("MIN")
        Me.ListView4.Columns.Add("SEK")

        Me.ListView4.View = View.Details

        Me.ListView5.Columns.Add("KRUG")
        Me.ListView5.Columns.Add("SAT")
        Me.ListView5.Columns.Add("MIN")
        Me.ListView5.Columns.Add("SEK")

        Me.ListView5.View = View.Details

        Me.ListView6.Columns.Add("KRUG")
        Me.ListView6.Columns.Add("SAT")
        Me.ListView6.Columns.Add("MIN")
        Me.ListView6.Columns.Add("SEK")

        Me.ListView6.View = View.Details

        Me.ListView7.Columns.Add("KRUG")
        Me.ListView7.Columns.Add("SAT")
        Me.ListView7.Columns.Add("MIN")
        Me.ListView7.Columns.Add("SEK")

        Me.ListView7.View = View.Details

        Me.ListView8.Columns.Add("KRUG")
        Me.ListView8.Columns.Add("SAT")
        Me.ListView8.Columns.Add("MIN")
        Me.ListView8.Columns.Add("SEK")

        Me.ListView8.View = View.Details

        Me.ListView9.Columns.Add("KRUG")
        Me.ListView9.Columns.Add("SAT")
        Me.ListView9.Columns.Add("MIN")
        Me.ListView9.Columns.Add("SEK")

        Me.ListView9.View = View.Details

        Me.ListView10.Columns.Add("KRUG")
        Me.ListView10.Columns.Add("SAT")
        Me.ListView10.Columns.Add("MIN")
        Me.ListView10.Columns.Add("SEK")

        Me.ListView10.View = View.Details

        Me.ListView11.Columns.Add("KRUG")
        Me.ListView11.Columns.Add("SAT")
        Me.ListView11.Columns.Add("MIN")
        Me.ListView11.Columns.Add("SEK")

        Me.ListView11.View = View.Details

        Me.ListView12.Columns.Add("KRUG")
        Me.ListView12.Columns.Add("SAT")
        Me.ListView12.Columns.Add("MIN")
        Me.ListView12.Columns.Add("SEK")

        Me.ListView12.View = View.Details

        Me.ListView13.Columns.Add("KRUG")
        Me.ListView13.Columns.Add("SAT")
        Me.ListView13.Columns.Add("MIN")
        Me.ListView13.Columns.Add("SEK")

        Me.ListView13.View = View.Details

        Me.ListView14.Columns.Add("KRUG")
        Me.ListView14.Columns.Add("SAT")
        Me.ListView14.Columns.Add("MIN")
        Me.ListView14.Columns.Add("SEK")

        Me.ListView14.View = View.Details

        Me.ListView15.Columns.Add("KRUG")
        Me.ListView15.Columns.Add("SAT")
        Me.ListView15.Columns.Add("MIN")
        Me.ListView15.Columns.Add("SEK")

        Me.ListView15.View = View.Details

        Me.ListView20.Columns.Add("KRUG")
        Me.ListView20.Columns.Add("SAT")
        Me.ListView20.Columns.Add("MIN")
        Me.ListView20.Columns.Add("SEK")

        Me.ListView20.View = View.Details

        Me.ListView21.Columns.Add("KRUG")
        Me.ListView21.Columns.Add("SAT")
        Me.ListView21.Columns.Add("MIN")
        Me.ListView21.Columns.Add("SEK")

        Me.ListView21.View = View.Details

        Me.ListView22.Columns.Add("KRUG")
        Me.ListView22.Columns.Add("SAT")
        Me.ListView22.Columns.Add("MIN")
        Me.ListView22.Columns.Add("SEK")

        Me.ListView22.View = View.Details

        Me.ListView23.Columns.Add("KRUG")
        Me.ListView23.Columns.Add("SAT")
        Me.ListView23.Columns.Add("MIN")
        Me.ListView23.Columns.Add("SEK")

        Me.ListView23.View = View.Details

        Me.ListView16.Columns.Add("KRUG")
        Me.ListView16.Columns.Add("SAT")
        Me.ListView16.Columns.Add("MIN")
        Me.ListView16.Columns.Add("SEK")

        Me.ListView16.View = View.Details

        Me.ListView24.Columns.Add("KRUG")
        Me.ListView24.Columns.Add("SAT")
        Me.ListView24.Columns.Add("MIN")
        Me.ListView24.Columns.Add("SEK")

        Me.ListView24.View = View.Details

        Me.ListView17.Columns.Add("KRUG")
        Me.ListView17.Columns.Add("SAT")
        Me.ListView17.Columns.Add("MIN")
        Me.ListView17.Columns.Add("SEK")

        Me.ListView17.View = View.Details

        Me.ListView18.Columns.Add("KRUG")
        Me.ListView18.Columns.Add("SAT")
        Me.ListView18.Columns.Add("MIN")
        Me.ListView18.Columns.Add("SEK")

        Me.ListView18.View = View.Details

        Me.ListView25.Columns.Add("KRUG")
        Me.ListView25.Columns.Add("SAT")
        Me.ListView25.Columns.Add("MIN")
        Me.ListView25.Columns.Add("SEK")

        Me.ListView25.View = View.Details

        Me.ListView19.Columns.Add("KRUG")
        Me.ListView19.Columns.Add("SAT")
        Me.ListView19.Columns.Add("MIN")
        Me.ListView19.Columns.Add("SEK")

        Me.ListView19.View = View.Details

        Me.ListView26.Columns.Add("KRUG")
        Me.ListView26.Columns.Add("SAT")
        Me.ListView26.Columns.Add("MIN")
        Me.ListView26.Columns.Add("SEK")

        Me.ListView26.View = View.Details

        Me.ListView27.Columns.Add("KRUG")
        Me.ListView27.Columns.Add("SAT")
        Me.ListView27.Columns.Add("MIN")
        Me.ListView27.Columns.Add("SEK")

        Me.ListView27.View = View.Details

        Me.ListView28.Columns.Add("KRUG")
        Me.ListView28.Columns.Add("SAT")
        Me.ListView28.Columns.Add("MIN")
        Me.ListView28.Columns.Add("SEK")

        Me.ListView28.View = View.Details

        Me.ListView29.Columns.Add("KRUG")
        Me.ListView29.Columns.Add("SAT")
        Me.ListView29.Columns.Add("MIN")
        Me.ListView29.Columns.Add("SEK")

        Me.ListView29.View = View.Details

        Me.ListView30.Columns.Add("KRUG")
        Me.ListView30.Columns.Add("SAT")
        Me.ListView30.Columns.Add("MIN")
        Me.ListView30.Columns.Add("SEK")

        Me.ListView30.View = View.Details

        Me.ListView31.Columns.Add("KRUG")
        Me.ListView31.Columns.Add("SAT")
        Me.ListView31.Columns.Add("MIN")
        Me.ListView31.Columns.Add("SEK")

        Me.ListView31.View = View.Details

        Me.ListView32.Columns.Add("KRUG")
        Me.ListView32.Columns.Add("SAT")
        Me.ListView32.Columns.Add("MIN")
        Me.ListView32.Columns.Add("SEK")

        Me.ListView32.View = View.Details

        Me.ListView33.Columns.Add("KRUG")
        Me.ListView33.Columns.Add("SAT")
        Me.ListView33.Columns.Add("MIN")
        Me.ListView33.Columns.Add("SEK")

        Me.ListView33.View = View.Details

        Me.ListView34.Columns.Add("KRUG")
        Me.ListView34.Columns.Add("SAT")
        Me.ListView34.Columns.Add("MIN")
        Me.ListView34.Columns.Add("SEK")

        Me.ListView34.View = View.Details

        Me.ListView35.Columns.Add("KRUG")
        Me.ListView35.Columns.Add("SAT")
        Me.ListView35.Columns.Add("MIN")
        Me.ListView35.Columns.Add("SEK")

        Me.ListView35.View = View.Details

        Me.ListView36.Columns.Add("KRUG")
        Me.ListView36.Columns.Add("SAT")
        Me.ListView36.Columns.Add("MIN")
        Me.ListView36.Columns.Add("SEK")

        Me.ListView36.View = View.Details

        Me.ListView37.Columns.Add("KRUG")
        Me.ListView37.Columns.Add("SAT")
        Me.ListView37.Columns.Add("MIN")
        Me.ListView37.Columns.Add("SEK")

        Me.ListView37.View = View.Details

        Me.ListView38.Columns.Add("KRUG")
        Me.ListView38.Columns.Add("SAT")
        Me.ListView38.Columns.Add("MIN")
        Me.ListView38.Columns.Add("SEK")

        Me.ListView38.View = View.Details

        Me.ListView39.Columns.Add("KRUG")
        Me.ListView39.Columns.Add("SAT")
        Me.ListView39.Columns.Add("MIN")
        Me.ListView39.Columns.Add("SEK")

        Me.ListView39.View = View.Details

        Me.ListView40.Columns.Add("KRUG")
        Me.ListView40.Columns.Add("SAT")
        Me.ListView40.Columns.Add("MIN")
        Me.ListView40.Columns.Add("SEK")

        Me.ListView40.View = View.Details

        Me.ListView41.Columns.Add("KRUG")
        Me.ListView41.Columns.Add("SAT")
        Me.ListView41.Columns.Add("MIN")
        Me.ListView41.Columns.Add("SEK")

        Me.ListView41.View = View.Details

        Me.ListView42.Columns.Add("KRUG")
        Me.ListView42.Columns.Add("SAT")
        Me.ListView42.Columns.Add("MIN")
        Me.ListView42.Columns.Add("SEK")

        Me.ListView42.View = View.Details

        Me.ListView43.Columns.Add("KRUG")
        Me.ListView43.Columns.Add("SAT")
        Me.ListView43.Columns.Add("MIN")
        Me.ListView43.Columns.Add("SEK")

        Me.ListView43.View = View.Details

        Me.ListView44.Columns.Add("KRUG")
        Me.ListView44.Columns.Add("SAT")
        Me.ListView44.Columns.Add("MIN")
        Me.ListView44.Columns.Add("SEK")

        Me.ListView44.View = View.Details

        Me.ListView45.Columns.Add("KRUG")
        Me.ListView45.Columns.Add("SAT")
        Me.ListView45.Columns.Add("MIN")
        Me.ListView45.Columns.Add("SEK")

        Me.ListView45.View = View.Details

        Me.ListView46.Columns.Add("KRUG")
        Me.ListView46.Columns.Add("SAT")
        Me.ListView46.Columns.Add("MIN")
        Me.ListView46.Columns.Add("SEK")

        Me.ListView46.View = View.Details

        Me.ListView47.Columns.Add("KRUG")
        Me.ListView47.Columns.Add("SAT")
        Me.ListView47.Columns.Add("MIN")
        Me.ListView47.Columns.Add("SEK")

        Me.ListView47.View = View.Details

        Me.ListView48.Columns.Add("KRUG")
        Me.ListView48.Columns.Add("SAT")
        Me.ListView48.Columns.Add("MIN")
        Me.ListView48.Columns.Add("SEK")

        Me.ListView48.View = View.Details

        Me.ListView49.Columns.Add("KRUG")
        Me.ListView49.Columns.Add("SAT")
        Me.ListView49.Columns.Add("MIN")
        Me.ListView49.Columns.Add("SEK")

        Me.ListView49.View = View.Details

        Me.ListView50.Columns.Add("KRUG")
        Me.ListView50.Columns.Add("SAT")
        Me.ListView50.Columns.Add("MIN")
        Me.ListView50.Columns.Add("SEK")

        Me.ListView50.View = View.Details

        Me.ListView51.Columns.Add("KRUG")
        Me.ListView51.Columns.Add("SAT")
        Me.ListView51.Columns.Add("MIN")
        Me.ListView51.Columns.Add("SEK")

        Me.ListView51.View = View.Details

        Me.ListView52.Columns.Add("KRUG")
        Me.ListView52.Columns.Add("SAT")
        Me.ListView52.Columns.Add("MIN")
        Me.ListView52.Columns.Add("SEK")

        Me.ListView52.View = View.Details

        Me.ListView53.Columns.Add("KRUG")
        Me.ListView53.Columns.Add("SAT")
        Me.ListView53.Columns.Add("MIN")
        Me.ListView53.Columns.Add("SEK")

        Me.ListView53.View = View.Details

        Me.ListView54.Columns.Add("KRUG")
        Me.ListView54.Columns.Add("SAT")
        Me.ListView54.Columns.Add("MIN")
        Me.ListView54.Columns.Add("SEK")

        Me.ListView54.View = View.Details

        Me.ListView55.Columns.Add("KRUG")
        Me.ListView55.Columns.Add("SAT")
        Me.ListView55.Columns.Add("MIN")
        Me.ListView55.Columns.Add("SEK")

        Me.ListView55.View = View.Details

        Me.ListView56.Columns.Add("KRUG")
        Me.ListView56.Columns.Add("SAT")
        Me.ListView56.Columns.Add("MIN")
        Me.ListView56.Columns.Add("SEK")

        Me.ListView56.View = View.Details

        Me.ListView57.Columns.Add("KRUG")
        Me.ListView57.Columns.Add("SAT")
        Me.ListView57.Columns.Add("MIN")
        Me.ListView57.Columns.Add("SEK")

        Me.ListView57.View = View.Details

        Me.ListView58.Columns.Add("KRUG")
        Me.ListView58.Columns.Add("SAT")
        Me.ListView58.Columns.Add("MIN")
        Me.ListView58.Columns.Add("SEK")

        Me.ListView58.View = View.Details

        Me.ListView59.Columns.Add("KRUG")
        Me.ListView59.Columns.Add("SAT")
        Me.ListView59.Columns.Add("MIN")
        Me.ListView59.Columns.Add("SEK")

        Me.ListView59.View = View.Details

        Me.ListView60.Columns.Add("KRUG")
        Me.ListView60.Columns.Add("SAT")
        Me.ListView60.Columns.Add("MIN")
        Me.ListView60.Columns.Add("SEK")

        Me.ListView60.View = View.Details

        Me.ListView61.Columns.Add("KRUG")
        Me.ListView61.Columns.Add("SAT")
        Me.ListView61.Columns.Add("MIN")
        Me.ListView61.Columns.Add("SEK")

        Me.ListView61.View = View.Details

        Me.ListView62.Columns.Add("KRUG")
        Me.ListView62.Columns.Add("SAT")
        Me.ListView62.Columns.Add("MIN")
        Me.ListView62.Columns.Add("SEK")

        Me.ListView62.View = View.Details

        Me.ListView63.Columns.Add("KRUG")
        Me.ListView63.Columns.Add("SAT")
        Me.ListView63.Columns.Add("MIN")
        Me.ListView63.Columns.Add("SEK")

        Me.ListView63.View = View.Details

        Me.ListView64.Columns.Add("KRUG")
        Me.ListView64.Columns.Add("SAT")
        Me.ListView64.Columns.Add("MIN")
        Me.ListView64.Columns.Add("SEK")

        Me.ListView64.View = View.Details

        Me.ListView65.Columns.Add("KRUG")
        Me.ListView65.Columns.Add("SAT")
        Me.ListView65.Columns.Add("MIN")
        Me.ListView65.Columns.Add("SEK")

        Me.ListView65.View = View.Details

        Me.ListView66.Columns.Add("KRUG")
        Me.ListView66.Columns.Add("SAT")
        Me.ListView66.Columns.Add("MIN")
        Me.ListView66.Columns.Add("SEK")

        Me.ListView66.View = View.Details

        Me.ListView67.Columns.Add("KRUG")
        Me.ListView67.Columns.Add("SAT")
        Me.ListView67.Columns.Add("MIN")
        Me.ListView67.Columns.Add("SEK")

        Me.ListView67.View = View.Details

        Me.ListView68.Columns.Add("KRUG")
        Me.ListView68.Columns.Add("SAT")
        Me.ListView68.Columns.Add("MIN")
        Me.ListView68.Columns.Add("SEK")

        Me.ListView68.View = View.Details

        Me.ListView69.Columns.Add("KRUG")
        Me.ListView69.Columns.Add("SAT")
        Me.ListView69.Columns.Add("MIN")
        Me.ListView69.Columns.Add("SEK")

        Me.ListView69.View = View.Details

        Me.ListView70.Columns.Add("KRUG")
        Me.ListView70.Columns.Add("SAT")
        Me.ListView70.Columns.Add("MIN")
        Me.ListView70.Columns.Add("SEK")

        Me.ListView70.View = View.Details

        Me.ListView71.Columns.Add("KRUG")
        Me.ListView71.Columns.Add("SAT")
        Me.ListView71.Columns.Add("MIN")
        Me.ListView71.Columns.Add("SEK")

        Me.ListView71.View = View.Details


        Me.ListView74.Columns.Add("KRUG")
        Me.ListView74.Columns.Add("SAT")
        Me.ListView74.Columns.Add("MIN")
        Me.ListView74.Columns.Add("SEK")

        Me.ListView74.View = View.Details

        Me.ListView75.Columns.Add("KRUG")
        Me.ListView75.Columns.Add("SAT")
        Me.ListView75.Columns.Add("MIN")
        Me.ListView75.Columns.Add("SEK")

        Me.ListView75.View = View.Details

        Me.ListView76.Columns.Add("KRUG")
        Me.ListView76.Columns.Add("SAT")
        Me.ListView76.Columns.Add("MIN")
        Me.ListView76.Columns.Add("SEK")

        Me.ListView76.View = View.Details

        Me.ListView77.Columns.Add("KRUG")
        Me.ListView77.Columns.Add("SAT")
        Me.ListView77.Columns.Add("MIN")
        Me.ListView77.Columns.Add("SEK")

        Me.ListView77.View = View.Details

        Me.ListView78.Columns.Add("KRUG")
        Me.ListView78.Columns.Add("SAT")
        Me.ListView78.Columns.Add("MIN")
        Me.ListView78.Columns.Add("SEK")

        Me.ListView78.View = View.Details

        Me.ListView79.Columns.Add("KRUG")
        Me.ListView79.Columns.Add("SAT")
        Me.ListView79.Columns.Add("MIN")
        Me.ListView79.Columns.Add("SEK")

        Me.ListView79.View = View.Details

        Me.ListView80.Columns.Add("KRUG")
        Me.ListView80.Columns.Add("SAT")
        Me.ListView80.Columns.Add("MIN")
        Me.ListView80.Columns.Add("SEK")

        Me.ListView80.View = View.Details

        Me.ListView81.Columns.Add("KRUG")
        Me.ListView81.Columns.Add("SAT")
        Me.ListView81.Columns.Add("MIN")
        Me.ListView81.Columns.Add("SEK")

        Me.ListView81.View = View.Details

        Me.ListView82.Columns.Add("KRUG")
        Me.ListView82.Columns.Add("SAT")
        Me.ListView82.Columns.Add("MIN")
        Me.ListView82.Columns.Add("SEK")

        Me.ListView82.View = View.Details


    End Sub

    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i4 As Integer
        For i4 = 0 To ListView4.Items.Count - 1
            ListView4.Items(i4).Text = i4 + 1.ToString
        Next

        Dim item4 As ListViewItem = New ListViewItem(i4 + 1.ToString)
        item4.SubItems.Add(Label4.Text)
        item4.SubItems.Add(Label1.Text)
        item4.SubItems.Add(Label2.Text)
        ListView4.Items.Add(item4)

        ListView4.EnsureVisible(ListView4.Items.Count - 1)
        ListView4.Update()

        ListView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i5 As Integer
        For i5 = 0 To ListView5.Items.Count - 1
            ListView5.Items(i5).Text = i5 + 1.ToString
        Next

        Dim item5 As ListViewItem = New ListViewItem(i5 + 1.ToString)
        item5.SubItems.Add(Label4.Text)
        item5.SubItems.Add(Label1.Text)
        item5.SubItems.Add(Label2.Text)
        ListView5.Items.Add(item5)

        ListView5.EnsureVisible(ListView5.Items.Count - 1)
        ListView5.Update()

        ListView5.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i6 As Integer
        For i6 = 0 To ListView6.Items.Count - 1
            ListView6.Items(i6).Text = i6 + 1.ToString
        Next

        Dim item6 As ListViewItem = New ListViewItem(i6 + 1.ToString)
        item6.SubItems.Add(Label4.Text)
        item6.SubItems.Add(Label1.Text)
        item6.SubItems.Add(Label2.Text)
        ListView6.Items.Add(item6)

        ListView6.EnsureVisible(ListView6.Items.Count - 1)
        ListView6.Update()

        ListView6.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i7 As Integer
        For i7 = 0 To ListView7.Items.Count - 1
            ListView7.Items(i7).Text = i7 + 1.ToString
        Next

        Dim item7 As ListViewItem = New ListViewItem(i7 + 1.ToString)
        item7.SubItems.Add(Label4.Text)
        item7.SubItems.Add(Label1.Text)
        item7.SubItems.Add(Label2.Text)
        ListView7.Items.Add(item7)

        ListView7.EnsureVisible(ListView7.Items.Count - 1)
        ListView7.Update()

        ListView7.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i8 As Integer
        For i8 = 0 To ListView8.Items.Count - 1
            ListView8.Items(i8).Text = i8 + 1.ToString
        Next

        Dim item8 As ListViewItem = New ListViewItem(i8 + 1.ToString)
        item8.SubItems.Add(Label4.Text)
        item8.SubItems.Add(Label1.Text)
        item8.SubItems.Add(Label2.Text)
        ListView8.Items.Add(item8)

        ListView8.EnsureVisible(ListView8.Items.Count - 1)
        ListView8.Update()

        ListView8.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i9 As Integer
        For i9 = 0 To ListView9.Items.Count - 1
            ListView9.Items(i9).Text = i9 + 1.ToString
        Next

        Dim item9 As ListViewItem = New ListViewItem(i9 + 1.ToString)
        item9.SubItems.Add(Label4.Text)
        item9.SubItems.Add(Label1.Text)
        item9.SubItems.Add(Label2.Text)
        ListView9.Items.Add(item9)

        ListView9.EnsureVisible(ListView9.Items.Count - 1)
        ListView9.Update()

        ListView9.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i10 As Integer
        For i10 = 0 To ListView10.Items.Count - 1
            ListView10.Items(i10).Text = i10 + 1.ToString
        Next

        Dim item10 As ListViewItem = New ListViewItem(i10 + 1.ToString)
        item10.SubItems.Add(Label4.Text)
        item10.SubItems.Add(Label1.Text)
        item10.SubItems.Add(Label2.Text)
        ListView10.Items.Add(item10)

        ListView10.EnsureVisible(ListView10.Items.Count - 1)
        ListView10.Update()

        ListView10.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i11 As Integer
        For i11 = 0 To ListView11.Items.Count - 1
            ListView11.Items(i11).Text = i11 + 1.ToString
        Next

        Dim item11 As ListViewItem = New ListViewItem(i11 + 1.ToString)
        item11.SubItems.Add(Label4.Text)
        item11.SubItems.Add(Label1.Text)
        item11.SubItems.Add(Label2.Text)
        ListView11.Items.Add(item11)

        ListView11.EnsureVisible(ListView11.Items.Count - 1)
        ListView11.Update()

        ListView11.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i12 As Integer
        For i12 = 0 To ListView12.Items.Count - 1
            ListView12.Items(i12).Text = i12 + 1.ToString
        Next

        Dim item12 As ListViewItem = New ListViewItem(i12 + 1.ToString)
        item12.SubItems.Add(Label4.Text)
        item12.SubItems.Add(Label1.Text)
        item12.SubItems.Add(Label2.Text)
        ListView12.Items.Add(item12)

        ListView12.EnsureVisible(ListView12.Items.Count - 1)
        ListView12.Update()

        ListView12.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i13 As Integer
        For i13 = 0 To ListView13.Items.Count - 1
            ListView13.Items(i13).Text = i13 + 1.ToString
        Next

        Dim item13 As ListViewItem = New ListViewItem(i13 + 1.ToString)
        item13.SubItems.Add(Label4.Text)
        item13.SubItems.Add(Label1.Text)
        item13.SubItems.Add(Label2.Text)
        ListView13.Items.Add(item13)

        ListView13.EnsureVisible(ListView13.Items.Count - 1)
        ListView13.Update()

        ListView13.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i14 As Integer
        For i14 = 0 To ListView14.Items.Count - 1
            ListView14.Items(i14).Text = i14 + 1.ToString
        Next

        Dim item14 As ListViewItem = New ListViewItem(i14 + 1.ToString)
        item14.SubItems.Add(Label4.Text)
        item14.SubItems.Add(Label1.Text)
        item14.SubItems.Add(Label2.Text)
        ListView14.Items.Add(item14)

        ListView14.EnsureVisible(ListView14.Items.Count - 1)
        ListView14.Update()

        ListView14.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i15 As Integer
        For i15 = 0 To ListView15.Items.Count - 1
            ListView15.Items(i15).Text = i15 + 1.ToString
        Next

        Dim item15 As ListViewItem = New ListViewItem(i15 + 1.ToString)
        item15.SubItems.Add(Label4.Text)
        item15.SubItems.Add(Label1.Text)
        item15.SubItems.Add(Label2.Text)
        ListView15.Items.Add(item15)

        ListView15.EnsureVisible(ListView15.Items.Count - 1)
        ListView15.Update()

        ListView15.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        'SaveFileDialog1.ShowDialog()

        'Dim path As String = SaveFileDialog1.FileName

        Dim AllItems As String = ""

        Dim path As String = "C:\rezultati\rezultati.txt"
        Dim directoryPath As String = System.IO.Path.GetDirectoryName(path)


        Try
            AllItems = AllItems & "Darko Arsenijevic (2)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm = 0 To ListView1.Items.Count - 1

                AllItems = AllItems & ListView1.Items.Item(Itm).SubItems(0).Text & "        " &
                           ListView1.Items.Item(Itm).SubItems(1).Text & "  : " & ListView1.Items.Item(Itm).SubItems(2).Text &
                           "  :  " & ListView1.Items.Item(Itm).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Inot Klemenčič (4)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm1 = 0 To ListView2.Items.Count - 1

                AllItems = AllItems & ListView2.Items.Item(Itm1).SubItems(0).Text & "        " &
                           ListView2.Items.Item(Itm1).SubItems(1).Text & "  : " & ListView2.Items.Item(Itm1).SubItems(2).Text &
                           "  :  " & ListView2.Items.Item(Itm1).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dragan Pavlović (6)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm2 = 0 To ListView3.Items.Count - 1

                AllItems = AllItems & ListView3.Items.Item(Itm2).SubItems(0).Text & "        " &
                           ListView3.Items.Item(Itm2).SubItems(1).Text & "  : " & ListView3.Items.Item(Itm2).SubItems(2).Text &
                           "  :  " & ListView3.Items.Item(Itm2).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dragan Đ. Ćirić (12)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm3 = 0 To ListView4.Items.Count - 1

                AllItems = AllItems & ListView4.Items.Item(Itm3).SubItems(0).Text & "        " &
                           ListView4.Items.Item(Itm3).SubItems(1).Text & "  : " & ListView4.Items.Item(Itm3).SubItems(2).Text &
                           "  :  " & ListView4.Items.Item(Itm3).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Nenad Glusac (13)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm4 = 0 To ListView5.Items.Count - 1

                AllItems = AllItems & ListView5.Items.Item(Itm4).SubItems(0).Text & "        " &
                           ListView5.Items.Item(Itm4).SubItems(1).Text & "  : " & ListView5.Items.Item(Itm4).SubItems(2).Text &
                           "  :  " & ListView5.Items.Item(Itm4).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Miloje Jovanović Miki (15)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm5 = 0 To ListView6.Items.Count - 1

                AllItems = AllItems & ListView6.Items.Item(Itm5).SubItems(0).Text & "        " &
                           ListView6.Items.Item(Itm5).SubItems(1).Text & "  : " & ListView6.Items.Item(Itm5).SubItems(2).Text &
                           "  :  " & ListView6.Items.Item(Itm5).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dragutin Krstajić (38)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm6 = 0 To ListView7.Items.Count - 1

                AllItems = AllItems & ListView7.Items.Item(Itm6).SubItems(0).Text & "        " &
                           ListView7.Items.Item(Itm6).SubItems(1).Text & "  : " & ListView7.Items.Item(Itm6).SubItems(2).Text &
                           "  :  " & ListView7.Items.Item(Itm6).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dragan Ćirić (21)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm7 = 0 To ListView8.Items.Count - 1

                AllItems = AllItems & ListView8.Items.Item(Itm7).SubItems(0).Text & "        " &
                           ListView8.Items.Item(Itm7).SubItems(1).Text & "  : " & ListView8.Items.Item(Itm7).SubItems(2).Text &
                           "  :  " & ListView8.Items.Item(Itm7).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Elvir Rakipović (29)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm8 = 0 To ListView9.Items.Count - 1

                AllItems = AllItems & ListView9.Items.Item(Itm8).SubItems(0).Text & "        " &
                           ListView9.Items.Item(Itm8).SubItems(1).Text & "  : " & ListView9.Items.Item(Itm8).SubItems(2).Text &
                           "  :  " & ListView9.Items.Item(Itm8).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Ruždi Rakipović (30)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm9 = 0 To ListView10.Items.Count - 1

                AllItems = AllItems & ListView10.Items.Item(Itm9).SubItems(0).Text & "        " &
                           ListView10.Items.Item(Itm9).SubItems(1).Text & "  : " & ListView10.Items.Item(Itm9).SubItems(2).Text &
                           "  :  " & ListView10.Items.Item(Itm9).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Ivan Simić (32)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm10 = 0 To ListView11.Items.Count - 1

                AllItems = AllItems & ListView11.Items.Item(Itm10).SubItems(0).Text & "        " &
                           ListView11.Items.Item(Itm10).SubItems(1).Text & "  : " & ListView11.Items.Item(Itm10).SubItems(2).Text &
                           "  :  " & ListView11.Items.Item(Itm10).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Drago Boroja (33)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm11 = 0 To ListView12.Items.Count - 1

                AllItems = AllItems & ListView12.Items.Item(Itm11).SubItems(0).Text & "        " &
                           ListView12.Items.Item(Itm11).SubItems(1).Text & "  : " & ListView12.Items.Item(Itm11).SubItems(2).Text &
                           "  :  " & ListView12.Items.Item(Itm11).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Drago Knežević (42)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm12 = 0 To ListView13.Items.Count - 1

                AllItems = AllItems & ListView13.Items.Item(Itm12).SubItems(0).Text & "        " &
                           ListView13.Items.Item(Itm12).SubItems(1).Text & "  : " & ListView13.Items.Item(Itm12).SubItems(2).Text &
                           "  :  " & ListView13.Items.Item(Itm12).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Milenko Jerman (44)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm13 = 0 To ListView14.Items.Count - 1

                AllItems = AllItems & ListView14.Items.Item(Itm13).SubItems(0).Text & "        " &
                           ListView14.Items.Item(Itm13).SubItems(1).Text & "  : " & ListView14.Items.Item(Itm13).SubItems(2).Text &
                           "  :  " & ListView14.Items.Item(Itm13).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Miroslav Ranđelović (99)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm15 = 0 To ListView20.Items.Count - 1

                AllItems = AllItems & ListView20.Items.Item(Itm15).SubItems(0).Text & "        " &
                           ListView20.Items.Item(Itm15).SubItems(1).Text & "  : " & ListView20.Items.Item(Itm15).SubItems(2).Text &
                           "  :  " & ListView20.Items.Item(Itm15).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Slobodan Leontijević (56)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm16 = 0 To ListView21.Items.Count - 1

                AllItems = AllItems & ListView21.Items.Item(Itm16).SubItems(0).Text & "        " &
                           ListView21.Items.Item(Itm16).SubItems(1).Text & "  : " & ListView21.Items.Item(Itm16).SubItems(2).Text &
                           "  :  " & ListView21.Items.Item(Itm16).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Nenad Grbanović (46)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm17 = 0 To ListView22.Items.Count - 1

                AllItems = AllItems & ListView22.Items.Item(Itm17).SubItems(0).Text & "        " &
                           ListView22.Items.Item(Itm17).SubItems(1).Text & "  : " & ListView22.Items.Item(Itm17).SubItems(2).Text &
                           "  :  " & ListView22.Items.Item(Itm17).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Veljko Jevremović (48)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm18 = 0 To ListView23.Items.Count - 1

                AllItems = AllItems & ListView23.Items.Item(Itm18).SubItems(0).Text & "        " &
                           ListView23.Items.Item(Itm18).SubItems(1).Text & "  : " & ListView23.Items.Item(Itm18).SubItems(2).Text &
                           "  :  " & ListView23.Items.Item(Itm18).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Nenad Kovač (49)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm14 = 0 To ListView15.Items.Count - 1

                AllItems = AllItems & ListView15.Items.Item(Itm14).SubItems(0).Text & "        " &
                           ListView15.Items.Item(Itm14).SubItems(1).Text & "  : " & ListView15.Items.Item(Itm14).SubItems(2).Text &
                           "  :  " & ListView15.Items.Item(Itm14).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dragan Krsmanović (51)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm60 = 0 To ListView61.Items.Count - 1

                AllItems = AllItems & ListView61.Items.Item(Itm60).SubItems(0).Text & "        " &
                           ListView61.Items.Item(Itm60).SubItems(1).Text & "  : " & ListView61.Items.Item(Itm60).SubItems(2).Text &
                           "  :  " & ListView61.Items.Item(Itm60).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Saša Dimić (52)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm61 = 0 To ListView62.Items.Count - 1

                AllItems = AllItems & ListView62.Items.Item(Itm61).SubItems(0).Text & "        " &
                           ListView62.Items.Item(Itm61).SubItems(1).Text & "  : " & ListView62.Items.Item(Itm61).SubItems(2).Text &
                           "  :  " & ListView62.Items.Item(Itm61).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Saša Gacik (54)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView63.Items.Count - 1

                AllItems = AllItems & ListView63.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView63.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView63.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView63.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Branislav Cvetković (55)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView67.Items.Count - 1

                AllItems = AllItems & ListView67.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView67.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView67.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView67.Items.Item(Itm70).SubItems(3).Text & vbNewLine


            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Srđan Đurić (57)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView74.Items.Count - 1

                AllItems = AllItems & ListView74.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView74.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView74.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView74.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Staniša Milosavljević (58)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView75.Items.Count - 1

                AllItems = AllItems & ListView75.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView75.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView75.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView75.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Mile Rašković (59)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView76.Items.Count - 1

                AllItems = AllItems & ListView76.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView76.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView76.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView76.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Miljurko Đurković (16) " & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView77.Items.Count - 1

                AllItems = AllItems & ListView77.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView77.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView77.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView77.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Miloje Andrić (77)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView78.Items.Count - 1

                AllItems = AllItems & ListView78.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView78.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView78.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView78.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dražen Sarjanović (28)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView79.Items.Count - 1

                AllItems = AllItems & ListView79.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView79.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView79.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView79.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Goran Antičević (53)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm70 = 0 To ListView80.Items.Count - 1

                AllItems = AllItems & ListView80.Items.Item(Itm70).SubItems(0).Text & "        " &
                           ListView80.Items.Item(Itm70).SubItems(1).Text & "  : " & ListView80.Items.Item(Itm70).SubItems(2).Text &
                           "  :  " & ListView80.Items.Item(Itm70).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Zdravka Kneževic (23)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm19 = 0 To ListView16.Items.Count - 1

                AllItems = AllItems & ListView16.Items.Item(Itm19).SubItems(0).Text & "        " &
                           ListView16.Items.Item(Itm19).SubItems(1).Text & "  : " & ListView16.Items.Item(Itm19).SubItems(2).Text &
                           "  :  " & ListView16.Items.Item(Itm19).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Tanja Ožanić (24)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm20 = 0 To ListView24.Items.Count - 1

                AllItems = AllItems & ListView24.Items.Item(Itm20).SubItems(0).Text & "        " &
                           ListView24.Items.Item(Itm20).SubItems(1).Text & "  : " & ListView24.Items.Item(Itm20).SubItems(2).Text &
                           "  :  " & ListView24.Items.Item(Itm20).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Saša Tucaković (27)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm21 = 0 To ListView17.Items.Count - 1

                AllItems = AllItems & ListView17.Items.Item(Itm21).SubItems(0).Text & "        " &
                           ListView17.Items.Item(Itm21).SubItems(1).Text & "  : " & ListView17.Items.Item(Itm21).SubItems(2).Text &
                           "  :  " & ListView17.Items.Item(Itm21).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Karin Jerman (43)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm22 = 0 To ListView18.Items.Count - 1

                AllItems = AllItems & ListView18.Items.Item(Itm22).SubItems(0).Text & "        " &
                           ListView18.Items.Item(Itm22).SubItems(1).Text & "  : " & ListView18.Items.Item(Itm22).SubItems(2).Text &
                           "  :  " & ListView18.Items.Item(Itm22).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dragica Mitić (45)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm23 = 0 To ListView19.Items.Count - 1

                AllItems = AllItems & ListView19.Items.Item(Itm23).SubItems(0).Text & "        " &
                           ListView19.Items.Item(Itm23).SubItems(1).Text & "  : " & ListView19.Items.Item(Itm23).SubItems(2).Text &
                           "  :  " & ListView19.Items.Item(Itm23).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Marjeta Gomilsak (50)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm24 = 0 To ListView25.Items.Count - 1

                AllItems = AllItems & ListView25.Items.Item(Itm24).SubItems(0).Text & "        " &
                           ListView25.Items.Item(Itm24).SubItems(1).Text & "  : " & ListView25.Items.Item(Itm24).SubItems(2).Text &
                           "  :  " & ListView25.Items.Item(Itm24).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Sanela Janković (60)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm24 = 0 To ListView81.Items.Count - 1

                AllItems = AllItems & ListView81.Items.Item(Itm24).SubItems(0).Text & "        " &
                           ListView81.Items.Item(Itm24).SubItems(1).Text & "  : " & ListView81.Items.Item(Itm24).SubItems(2).Text &
                           "  :  " & ListView81.Items.Item(Itm24).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Vera Velimirović (62)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm24 = 0 To ListView82.Items.Count - 1

                AllItems = AllItems & ListView82.Items.Item(Itm24).SubItems(0).Text & "        " &
                           ListView82.Items.Item(Itm24).SubItems(1).Text & "  : " & ListView82.Items.Item(Itm24).SubItems(2).Text &
                           "  :  " & ListView82.Items.Item(Itm24).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Zoran Dimov (11)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm25 = 0 To ListView26.Items.Count - 1

                AllItems = AllItems & ListView26.Items.Item(Itm25).SubItems(0).Text & "        " &
                           ListView26.Items.Item(Itm25).SubItems(1).Text & "  : " & ListView26.Items.Item(Itm25).SubItems(2).Text &
                           "  :  " & ListView26.Items.Item(Itm25).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Jovica Stojanovski (69)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm26 = 0 To ListView27.Items.Count - 1

                AllItems = AllItems & ListView27.Items.Item(Itm26).SubItems(0).Text & "        " &
                           ListView27.Items.Item(Itm26).SubItems(1).Text & "  : " & ListView27.Items.Item(Itm26).SubItems(2).Text &
                           "  :  " & ListView27.Items.Item(Itm26).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Klemen Boštar (7)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm27 = 0 To ListView28.Items.Count - 1

                AllItems = AllItems & ListView28.Items.Item(Itm27).SubItems(0).Text & "        " &
                           ListView28.Items.Item(Itm27).SubItems(1).Text & "  : " & ListView28.Items.Item(Itm27).SubItems(2).Text &
                           "  :  " & ListView28.Items.Item(Itm27).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Jovica Jovanchev (9)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm28 = 0 To ListView29.Items.Count - 1

                AllItems = AllItems & ListView29.Items.Item(Itm28).SubItems(0).Text & "        " &
                           ListView29.Items.Item(Itm28).SubItems(1).Text & "  : " & ListView29.Items.Item(Itm28).SubItems(2).Text &
                           "  :  " & ListView29.Items.Item(Itm28).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Miroslav Pajić (10)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm29 = 0 To ListView30.Items.Count - 1

                AllItems = AllItems & ListView30.Items.Item(Itm29).SubItems(0).Text & "        " &
                           ListView30.Items.Item(Itm29).SubItems(1).Text & "  : " & ListView30.Items.Item(Itm29).SubItems(2).Text &
                           "  :  " & ListView30.Items.Item(Itm29).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Branislav Pavić (14)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm30 = 0 To ListView31.Items.Count - 1

                AllItems = AllItems & ListView31.Items.Item(Itm30).SubItems(0).Text & "        " &
                           ListView31.Items.Item(Itm30).SubItems(1).Text & "  : " & ListView31.Items.Item(Itm30).SubItems(2).Text &
                           "  :  " & ListView31.Items.Item(Itm30).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Miljurko Djurković (16)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm31 = 0 To ListView32.Items.Count - 1

                AllItems = AllItems & ListView32.Items.Item(Itm31).SubItems(0).Text & "        " &
                           ListView32.Items.Item(Itm31).SubItems(1).Text & "  : " & ListView32.Items.Item(Itm31).SubItems(2).Text &
                           "  :  " & ListView32.Items.Item(Itm31).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Srećko Mićić (18)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm32 = 0 To ListView33.Items.Count - 1

                AllItems = AllItems & ListView33.Items.Item(Itm32).SubItems(0).Text & "        " &
                           ListView33.Items.Item(Itm32).SubItems(1).Text & "  : " & ListView33.Items.Item(Itm32).SubItems(2).Text &
                           "  :  " & ListView33.Items.Item(Itm32).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Nenad Ivanović (20)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm33 = 0 To ListView34.Items.Count - 1

                AllItems = AllItems & ListView34.Items.Item(Itm33).SubItems(0).Text & "        " &
                           ListView34.Items.Item(Itm33).SubItems(1).Text & "  : " & ListView34.Items.Item(Itm33).SubItems(2).Text &
                           "  :  " & ListView34.Items.Item(Itm33).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Giacomino Barbacetto (25)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm34 = 0 To ListView35.Items.Count - 1

                AllItems = AllItems & ListView35.Items.Item(Itm34).SubItems(0).Text & "        " &
                           ListView35.Items.Item(Itm34).SubItems(1).Text & "  : " & ListView35.Items.Item(Itm34).SubItems(2).Text &
                           "  :  " & ListView35.Items.Item(Itm34).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Kire Naunčevski Pekmez (26)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm35 = 0 To ListView36.Items.Count - 1

                AllItems = AllItems & ListView36.Items.Item(Itm35).SubItems(0).Text & "        " &
                           ListView36.Items.Item(Itm35).SubItems(1).Text & "  : " & ListView36.Items.Item(Itm35).SubItems(2).Text &
                           "  :  " & ListView36.Items.Item(Itm35).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dancho Markovski (28)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm36 = 0 To ListView37.Items.Count - 1

                AllItems = AllItems & ListView37.Items.Item(Itm36).SubItems(0).Text & "        " &
                           ListView37.Items.Item(Itm36).SubItems(1).Text & "  : " & ListView37.Items.Item(Itm36).SubItems(2).Text &
                           "  :  " & ListView37.Items.Item(Itm36).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Saša Tubin (31)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm37 = 0 To ListView38.Items.Count - 1

                AllItems = AllItems & ListView38.Items.Item(Itm37).SubItems(0).Text & "        " &
                           ListView38.Items.Item(Itm37).SubItems(1).Text & "  : " & ListView38.Items.Item(Itm37).SubItems(2).Text &
                           "  :  " & ListView38.Items.Item(Itm37).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Viktor VITE Toleski (35)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm38 = 0 To ListView39.Items.Count - 1

                AllItems = AllItems & ListView39.Items.Item(Itm38).SubItems(0).Text & "        " &
                           ListView39.Items.Item(Itm38).SubItems(1).Text & "  : " & ListView39.Items.Item(Itm38).SubItems(2).Text &
                           "  :  " & ListView39.Items.Item(Itm38).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Semir Kasić (38)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm39 = 0 To ListView40.Items.Count - 1

                AllItems = AllItems & ListView40.Items.Item(Itm39).SubItems(0).Text & "        " &
                           ListView40.Items.Item(Itm39).SubItems(1).Text & "  : " & ListView40.Items.Item(Itm39).SubItems(2).Text &
                           "  :  " & ListView40.Items.Item(Itm39).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Branimir Stojanović (39)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm40 = 0 To ListView41.Items.Count - 1

                AllItems = AllItems & ListView41.Items.Item(Itm40).SubItems(0).Text & "        " &
                           ListView41.Items.Item(Itm40).SubItems(1).Text & "  : " & ListView41.Items.Item(Itm40).SubItems(2).Text &
                           "  :  " & ListView41.Items.Item(Itm40).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Milan Piljak (40)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm41 = 0 To ListView42.Items.Count - 1

                AllItems = AllItems & ListView42.Items.Item(Itm41).SubItems(0).Text & "        " &
                           ListView42.Items.Item(Itm41).SubItems(1).Text & "  : " & ListView42.Items.Item(Itm41).SubItems(2).Text &
                           "  :  " & ListView42.Items.Item(Itm41).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Franjo Pap (76)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm42 = 0 To ListView43.Items.Count - 1

                AllItems = AllItems & ListView43.Items.Item(Itm42).SubItems(0).Text & "        " &
                           ListView43.Items.Item(Itm42).SubItems(1).Text & "  : " & ListView43.Items.Item(Itm42).SubItems(2).Text &
                           "  :  " & ListView43.Items.Item(Itm42).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Đorđe Vučković (41)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm43 = 0 To ListView44.Items.Count - 1

                AllItems = AllItems & ListView44.Items.Item(Itm43).SubItems(0).Text & "        " &
                           ListView44.Items.Item(Itm43).SubItems(1).Text & "  : " & ListView44.Items.Item(Itm43).SubItems(2).Text &
                           "  :  " & ListView44.Items.Item(Itm43).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Albert Schmidek (98)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm44 = 0 To ListView45.Items.Count - 1

                AllItems = AllItems & ListView45.Items.Item(Itm44).SubItems(0).Text & "        " &
                           ListView45.Items.Item(Itm44).SubItems(1).Text & "  : " & ListView45.Items.Item(Itm44).SubItems(2).Text &
                           "  :  " & ListView45.Items.Item(Itm44).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Nreka Ljuljdjuraj (47)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm45 = 0 To ListView46.Items.Count - 1

                AllItems = AllItems & ListView46.Items.Item(Itm45).SubItems(0).Text & "        " &
                           ListView46.Items.Item(Itm45).SubItems(1).Text & "  : " & ListView46.Items.Item(Itm45).SubItems(2).Text &
                           "  :  " & ListView46.Items.Item(Itm45).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Ivan Šunjevarič (3)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm52 = 0 To ListView53.Items.Count - 1

                AllItems = AllItems & ListView53.Items.Item(Itm52).SubItems(0).Text & "        " &
                           ListView53.Items.Item(Itm52).SubItems(1).Text & "  : " & ListView53.Items.Item(Itm52).SubItems(2).Text &
                           "  :  " & ListView53.Items.Item(Itm52).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Takmicar1" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm55 = 0 To ListView56.Items.Count - 1

                AllItems = AllItems & ListView56.Items.Item(Itm55).SubItems(0).Text & "        " &
                           ListView56.Items.Item(Itm55).SubItems(1).Text & "  : " & ListView56.Items.Item(Itm55).SubItems(2).Text &
                           "  :  " & ListView56.Items.Item(Itm55).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Takmicar2" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm56 = 0 To ListView57.Items.Count - 1

                AllItems = AllItems & ListView57.Items.Item(Itm56).SubItems(0).Text & "        " &
                           ListView57.Items.Item(Itm56).SubItems(1).Text & "  : " & ListView57.Items.Item(Itm56).SubItems(2).Text &
                           "  :  " & ListView57.Items.Item(Itm56).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Takmicar3" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm57 = 0 To ListView58.Items.Count - 1

                AllItems = AllItems & ListView58.Items.Item(Itm57).SubItems(0).Text & "        " &
                           ListView58.Items.Item(Itm57).SubItems(1).Text & "  : " & ListView58.Items.Item(Itm57).SubItems(2).Text &
                           "  :  " & ListView58.Items.Item(Itm57).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Takmicar4" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm58 = 0 To ListView59.Items.Count - 1

                AllItems = AllItems & ListView59.Items.Item(Itm58).SubItems(0).Text & "        " &
                           ListView59.Items.Item(Itm58).SubItems(1).Text & "  : " & ListView59.Items.Item(Itm58).SubItems(2).Text &
                           "  :  " & ListView59.Items.Item(Itm58).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Takmicar5" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm59 = 0 To ListView60.Items.Count - 1

                AllItems = AllItems & ListView60.Items.Item(Itm59).SubItems(0).Text & "        " &
                           ListView60.Items.Item(Itm59).SubItems(1).Text & "  : " & ListView60.Items.Item(Itm59).SubItems(2).Text &
                           "  :  " & ListView60.Items.Item(Itm59).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Anja Samardžija (61)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm46 = 0 To ListView47.Items.Count - 1

                AllItems = AllItems & ListView47.Items.Item(Itm46).SubItems(0).Text & "        " &
                           ListView47.Items.Item(Itm46).SubItems(1).Text & "  : " & ListView47.Items.Item(Itm46).SubItems(2).Text &
                           "  :  " & ListView47.Items.Item(Itm46).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & " Ilaria Rossi (73)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm47 = 0 To ListView48.Items.Count - 1

                AllItems = AllItems & ListView48.Items.Item(Itm47).SubItems(0).Text & "        " &
                           ListView48.Items.Item(Itm47).SubItems(1).Text & "  : " & ListView48.Items.Item(Itm47).SubItems(2).Text &
                           "  :  " & ListView48.Items.Item(Itm47).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Takmicarka1" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm48 = 0 To ListView49.Items.Count - 1

                AllItems = AllItems & ListView49.Items.Item(Itm48).SubItems(0).Text & "        " &
                           ListView49.Items.Item(Itm48).SubItems(1).Text & "  : " & ListView49.Items.Item(Itm48).SubItems(2).Text &
                           "  :  " & ListView49.Items.Item(Itm48).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Takmicarka2" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm49 = 0 To ListView50.Items.Count - 1

                AllItems = AllItems & ListView50.Items.Item(Itm49).SubItems(0).Text & "        " &
                           ListView50.Items.Item(Itm49).SubItems(1).Text & "  : " & ListView50.Items.Item(Itm49).SubItems(2).Text &
                           "  :  " & ListView50.Items.Item(Itm49).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Andrea Cerar (18)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm50 = 0 To ListView51.Items.Count - 1

                AllItems = AllItems & ListView51.Items.Item(Itm50).SubItems(0).Text & "        " &
                           ListView51.Items.Item(Itm50).SubItems(1).Text & "  : " & ListView51.Items.Item(Itm50).SubItems(2).Text &
                           "  :  " & ListView51.Items.Item(Itm50).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Pavle Klemenčič (8)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm51 = 0 To ListView52.Items.Count - 1

                AllItems = AllItems & ListView52.Items.Item(Itm51).SubItems(0).Text & "        " &
                           ListView52.Items.Item(Itm51).SubItems(1).Text & "  : " & ListView52.Items.Item(Itm51).SubItems(2).Text &
                           "  :  " & ListView52.Items.Item(Itm51).SubItems(3).Text & vbNewLine
            
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Jovica Spajić (22)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm53 = 0 To ListView54.Items.Count - 1

                AllItems = AllItems & ListView54.Items.Item(Itm53).SubItems(0).Text & "        " &
                           ListView54.Items.Item(Itm53).SubItems(1).Text & "  : " & ListView54.Items.Item(Itm53).SubItems(2).Text &
                           "  :  " & ListView54.Items.Item(Itm53).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Matjaž Bukovec (1)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm54 = 0 To ListView55.Items.Count - 1

                AllItems = AllItems & ListView55.Items.Item(Itm54).SubItems(0).Text & "        " &
                           ListView55.Items.Item(Itm54).SubItems(1).Text & "  : " & ListView55.Items.Item(Itm54).SubItems(2).Text &
                           "  :  " & ListView55.Items.Item(Itm54).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dalibor Daničić (100)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm60 = 0 To ListView64.Items.Count - 1

                AllItems = AllItems & ListView64.Items.Item(Itm60).SubItems(0).Text & "        " &
                           ListView64.Items.Item(Itm60).SubItems(1).Text & "  : " & ListView64.Items.Item(Itm60).SubItems(2).Text &
                           "  :  " & ListView64.Items.Item(Itm60).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & vbNewLine & vbNewLine

            AllItems = AllItems & "Dejan Daničić (17)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm61 = 0 To ListView65.Items.Count - 1

                AllItems = AllItems & ListView65.Items.Item(Itm61).SubItems(0).Text & "        " &
                           ListView65.Items.Item(Itm61).SubItems(1).Text & "  : " & ListView65.Items.Item(Itm61).SubItems(2).Text &
                           "  :  " & ListView65.Items.Item(Itm61).SubItems(3).Text & vbNewLine
            Next

            AllItems = AllItems & "Milan Nikolić (34)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm62 = 0 To ListView66.Items.Count - 1

                AllItems = AllItems & ListView66.Items.Item(Itm62).SubItems(0).Text & "        " &
                           ListView66.Items.Item(Itm62).SubItems(1).Text & "  : " & ListView66.Items.Item(Itm62).SubItems(2).Text &
                           "  :  " & ListView66.Items.Item(Itm62).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & "BRZI (71)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm62 = 0 To ListView68.Items.Count - 1

                AllItems = AllItems & ListView68.Items.Item(Itm62).SubItems(0).Text & "        " &
                           ListView68.Items.Item(Itm62).SubItems(1).Text & "  : " & ListView68.Items.Item(Itm62).SubItems(2).Text &
                           "  :  " & ListView68.Items.Item(Itm62).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & "ŽDRALOVI (72)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm62 = 0 To ListView69.Items.Count - 1

                AllItems = AllItems & ListView69.Items.Item(Itm62).SubItems(0).Text & "        " &
                           ListView69.Items.Item(Itm62).SubItems(1).Text & "  : " & ListView69.Items.Item(Itm62).SubItems(2).Text &
                           "  :  " & ListView69.Items.Item(Itm62).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & "ZAKON (73)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm62 = 0 To ListView70.Items.Count - 1

                AllItems = AllItems & ListView70.Items.Item(Itm62).SubItems(0).Text & "        " &
                           ListView70.Items.Item(Itm62).SubItems(1).Text & "  : " & ListView70.Items.Item(Itm62).SubItems(2).Text &
                           "  :  " & ListView70.Items.Item(Itm62).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems & "PROFESIONALCI (74)" & vbNewLine & "KRUG | SAT | MIN | SEK " & vbNewLine
            For Itm62 = 0 To ListView71.Items.Count - 1

                AllItems = AllItems & ListView71.Items.Item(Itm62).SubItems(0).Text & "        " &
                           ListView71.Items.Item(Itm62).SubItems(1).Text & "  : " & ListView71.Items.Item(Itm62).SubItems(2).Text &
                           "  :  " & ListView71.Items.Item(Itm62).SubItems(3).Text & vbNewLine

            Next

            AllItems = AllItems.Trim
        Catch ex As Exception

        End Try

        Try
            If My.Computer.FileSystem.FileExists(path) Then
                My.Computer.FileSystem.DeleteFile(path)
            End If
            My.Computer.FileSystem.WriteAllText(path, AllItems, False)

        Catch ex As Exception
            MsgBox("Greska" & vbNewLine & ex.Message, MsgBoxStyle.Exclamation, "Na lokaciji C:\rezultati\ nije pronadjen fajl rezultati.txt")
        End Try

    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        If ListView1.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView1.SelectedItems(0).Remove()
        End If
        If ListView2.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView2.SelectedItems(0).Remove()
        End If
        If ListView3.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView3.SelectedItems(0).Remove()
        End If
        If ListView4.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView4.SelectedItems(0).Remove()
        End If
        If ListView4.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView4.SelectedItems(0).Remove()
        End If
        If ListView5.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView5.SelectedItems(0).Remove()
        End If
        If ListView6.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView6.SelectedItems(0).Remove()
        End If
        If ListView7.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView7.SelectedItems(0).Remove()
        End If
        If ListView8.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView8.SelectedItems(0).Remove()
        End If
        If ListView9.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView9.SelectedItems(0).Remove()
        End If
        If ListView10.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView10.SelectedItems(0).Remove()
        End If
        If ListView11.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView11.SelectedItems(0).Remove()
        End If
        If ListView12.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView12.SelectedItems(0).Remove()
        End If
        If ListView13.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView13.SelectedItems(0).Remove()
        End If
        If ListView14.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView14.SelectedItems(0).Remove()
        End If
        If ListView15.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView15.SelectedItems(0).Remove()
        End If
        If ListView20.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView20.SelectedItems(0).Remove()
        End If
        If ListView21.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView21.SelectedItems(0).Remove()
        End If
        If ListView22.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView22.SelectedItems(0).Remove()
        End If
        If ListView23.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView23.SelectedItems(0).Remove()
        End If
        If ListView16.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView16.SelectedItems(0).Remove()
        End If
        If ListView24.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView24.SelectedItems(0).Remove()
        End If
        If ListView17.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView17.SelectedItems(0).Remove()
        End If
        If ListView18.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView18.SelectedItems(0).Remove()
        End If
        If ListView19.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView19.SelectedItems(0).Remove()
        End If
        If ListView25.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView25.SelectedItems(0).Remove()
        End If
        If ListView26.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView26.SelectedItems(0).Remove()
        End If
        If ListView27.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView27.SelectedItems(0).Remove()
        End If
        If ListView28.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView28.SelectedItems(0).Remove()
        End If
        If ListView29.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView29.SelectedItems(0).Remove()
        End If
        If ListView30.SelectedItems.Count > 0 AndAlso
            MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView30.SelectedItems(0).Remove()
        End If
        If ListView31.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView31.SelectedItems(0).Remove()
        End If
        If ListView32.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView32.SelectedItems(0).Remove()
        End If
        If ListView33.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView33.SelectedItems(0).Remove()
        End If
        If ListView34.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView34.SelectedItems(0).Remove()
        End If
        If ListView35.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView35.SelectedItems(0).Remove()
        End If
        If ListView36.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView36.SelectedItems(0).Remove()
        End If
        If ListView37.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView37.SelectedItems(0).Remove()
        End If
        If ListView38.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView38.SelectedItems(0).Remove()
        End If
        If ListView39.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView39.SelectedItems(0).Remove()
        End If
        If ListView40.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView40.SelectedItems(0).Remove()
        End If
        If ListView41.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView41.SelectedItems(0).Remove()
        End If
        If ListView42.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView42.SelectedItems(0).Remove()
        End If
        If ListView43.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView43.SelectedItems(0).Remove()
        End If
        If ListView44.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView44.SelectedItems(0).Remove()
        End If
        If ListView45.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView45.SelectedItems(0).Remove()
        End If
        If ListView46.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView46.SelectedItems(0).Remove()
        End If
        If ListView47.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView47.SelectedItems(0).Remove()
        End If
        If ListView48.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView48.SelectedItems(0).Remove()
        End If
        If ListView49.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView49.SelectedItems(0).Remove()
        End If
        If ListView50.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView50.SelectedItems(0).Remove()
        End If
        If ListView51.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView51.SelectedItems(0).Remove()
        End If
        If ListView52.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView52.SelectedItems(0).Remove()
        End If
        If ListView53.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView53.SelectedItems(0).Remove()
        End If
        If ListView54.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView54.SelectedItems(0).Remove()
        End If
        If ListView55.SelectedItems.Count > 0 AndAlso
           MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView55.SelectedItems(0).Remove()
        End If
        If ListView56.SelectedItems.Count > 0 AndAlso
          MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView56.SelectedItems(0).Remove()
        End If
        If ListView57.SelectedItems.Count > 0 AndAlso
          MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView57.SelectedItems(0).Remove()
        End If
        If ListView58.SelectedItems.Count > 0 AndAlso
          MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView58.SelectedItems(0).Remove()
        End If
        If ListView59.SelectedItems.Count > 0 AndAlso
          MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView59.SelectedItems(0).Remove()
        End If
        If ListView60.SelectedItems.Count > 0 AndAlso
          MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView60.SelectedItems(0).Remove()
        End If
        If ListView61.SelectedItems.Count > 0 AndAlso
          MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView61.SelectedItems(0).Remove()
        End If
        If ListView62.SelectedItems.Count > 0 AndAlso
          MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj krug?", "Potvrdite brisanje", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            ListView62.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button21.PerformClick()
        End If
    End Sub


    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        Label8.ForeColor = Color.Blue

        If TextBox1.Text = "2" Then
            Button4_Click(Button4, e)
            Label8.Text = "Uspešno unet 2."
        ElseIf TextBox1.Text = "4" Then
            Button5_Click(Button5, e)
            Label8.Text = "Uspešno unet 4."
        ElseIf TextBox1.Text = "6" Then
            Button6_Click(Button6, e)
            Label8.Text = "Uspešno unet 6."
        ElseIf TextBox1.Text = "12" Then
            Button7_Click(Button7, e)
            Label8.Text = "Uspešno unet 12."
        ElseIf TextBox1.Text = "13" Then
            Button8_Click(Button8, e)
            Label8.Text = "Uspešno unet 13."
        ElseIf TextBox1.Text = "15" Then
            Button9_Click(Button9, e)
            Label8.Text = "Uspešno unet 15."
        ElseIf TextBox1.Text = "38" Then
            Button10_Click(Button10, e)
            Label8.Text = "Uspešno unet 38."
        ElseIf TextBox1.Text = "21" Then
            Button11_Click(Button11, e)
            Label8.Text = "Uspešno unet 21."
        ElseIf TextBox1.Text = "29" Then
            Button12_Click(Button12, e)
            Label8.Text = "Uspešno unet 29."
        ElseIf TextBox1.Text = "30" Then
            Button13_Click(Button13, e)
            Label8.Text = "Uspešno unet 30."
        ElseIf TextBox1.Text = "32" Then
            Button14_Click(Button14, e)
            Label8.Text = "Uspešno unet 32."
        ElseIf TextBox1.Text = "33" Then
            Button15_Click(Button15, e)
            Label8.Text = "Uspešno unet 33."
        ElseIf TextBox1.Text = "42" Then
            Button16_Click(Button16, e)
            Label8.Text = "Uspešno unet 42."
        ElseIf TextBox1.Text = "44" Then
            Button17_Click(Button17, e)
            Label8.Text = "Uspešno unet 44."
        ElseIf TextBox1.Text = "99" Then
            Button27_Click(Button27, e)
            Label8.Text = "Uspešno unet 99."
        ElseIf TextBox1.Text = "56" Then
            Button28_Click(Button28, e)
            Label8.Text = "Uspešno unet 56."
        ElseIf TextBox1.Text = "46" Then
            Button29_Click(Button29, e)
            Label8.Text = "Uspešno unet 46."
        ElseIf TextBox1.Text = "92" Then
            Button30_Click(Button30, e)
            Label8.Text = "Uspešno unet 92."
        ElseIf TextBox1.Text = "23" Then
            Button22_Click(Button22, e)
            Label8.Text = "Uspešno unet 23."
        ElseIf TextBox1.Text = "24" Then
            Button23_Click(Button23, e)
            Label8.Text = "Uspešno unet 24."
        ElseIf TextBox1.Text = "27" Then
            Button24_Click(Button24, e)
            Label8.Text = "Uspešno unet 27."
        ElseIf TextBox1.Text = "43" Then
            Button25_Click(Button25, e)
            Label8.Text = "Uspešno unet 43."
        ElseIf TextBox1.Text = "45" Then
            Button26_Click(Button26, e)
            Label8.Text = "Uspešno unet 45."
        ElseIf TextBox1.Text = "48" Then
            Button30_Click(Button30, e)
            Label8.Text = "Uspešno unet 48."
        ElseIf TextBox1.Text = "49" Then
            Button18_Click(Button18, e)
            Label8.Text = "Uspešno unet 49."
        ElseIf TextBox1.Text = "51" Then
            Button67_Click(Button67, e)
            Label8.Text = "Uspešno unet 51."
        ElseIf TextBox1.Text = "52" Then
            Button68_Click(Button68, e)
            Label8.Text = "Uspešno unet 52."
        ElseIf TextBox1.Text = "50" Then
            Button31_Click(Button31, e)
            Label8.Text = "Uspešno unet 50."
        ElseIf TextBox1.Text = "54" Then
            Button70_Click(Button70, e)
            Label8.Text = "Uspešno unet 54."
        ElseIf TextBox1.Text = "7" Then
            Button34_Click(Button34, e)
            Label8.Text = "Uspešno unet 7."
        ElseIf TextBox1.Text = "9" Then
            Button35_Click(Button35, e)
            Label8.Text = "Uspešno unet 9."
        ElseIf TextBox1.Text = "10" Then
            Button36_Click(Button36, e)
            Label8.Text = "Uspešno unet 10."
        ElseIf TextBox1.Text = "11" Then
            Button32_Click(Button32, e)
            Label8.Text = "Uspešno unet 11."
        ElseIf TextBox1.Text = "69" Then
            Button33_Click(Button33, e)
            Label8.Text = "Uspešno unet 69."
        ElseIf TextBox1.Text = "14" Then
            Button37_Click(Button37, e)
            Label8.Text = "Uspešno unet 14."
        ElseIf TextBox1.Text = "16" Then
            Button84_Click(Button84, e)
            Label8.Text = "Uspešno unet 16."
        ElseIf TextBox1.Text = "18" Then
            Button39_Click(Button39, e)
            Label8.Text = "Uspešno unet 18."
        ElseIf TextBox1.Text = "20" Then
            Button40_Click(Button40, e)
            Label8.Text = "Uspešno unet 20."
        ElseIf TextBox1.Text = "25" Then
            Button41_Click(Button41, e)
            Label8.Text = "Uspešno unet 25."
        ElseIf TextBox1.Text = "26" Then
            Button42_Click(Button42, e)
            Label8.Text = "Uspešno unet 26."
        ElseIf TextBox1.Text = "31" Then
            Button44_Click(Button44, e)
            Label8.Text = "Uspešno unet 31."
        ElseIf TextBox1.Text = "35" Then
            Button45_Click(Button45, e)
            Label8.Text = "Uspešno unet 35."
        ElseIf TextBox1.Text = "38" Then
            Button46_Click(Button46, e)
            Label8.Text = "Uspešno unet 38."
        ElseIf TextBox1.Text = "39" Then
            Button47_Click(Button47, e)
            Label8.Text = "Uspešno unet 39."
        ElseIf TextBox1.Text = "40" Then
            Button48_Click(Button48, e)
            Label8.Text = "Uspešno unet 40."
        ElseIf TextBox1.Text = "76" Then
            Button49_Click(Button49, e)
            Label8.Text = "Uspešno unet 76."
        ElseIf TextBox1.Text = "41" Then
            Button50_Click(Button50, e)
            Label8.Text = "Uspešno unet 41."
        ElseIf TextBox1.Text = "98" Then
            Button51_Click(Button51, e)
            Label8.Text = "Uspešno unet 98."
        ElseIf TextBox1.Text = "47" Then
            Button52_Click(Button52, e)
            Label8.Text = "Uspešno unet 47."
        ElseIf TextBox1.Text = "61" Then
            Button53_Click(Button53, e)
            Label8.Text = "Uspešno unet 61."
        ElseIf TextBox1.Text = "73" Then
            Button77_Click(Button77, e)
            Label8.Text = "Uspešno unet 73."
        ElseIf TextBox1.Text = "8" Then
            Button58_Click(Button58, e)
            Label8.Text = "Uspešno unet 8."
        ElseIf TextBox1.Text = "3" Then
            Button59_Click(Button59, e)
            Label8.Text = "Uspešno unet 3."
        ElseIf TextBox1.Text = "22" Then
            Button60_Click(Button60, e)
            Label8.Text = "Uspešno unet 22."
        ElseIf TextBox1.Text = "1" Then
            Button61_Click(Button61, e)
            Label8.Text = "Uspešno unet 1."
        ElseIf TextBox1.Text = "100" Then
            Button71_Click(Button71, e)
            Label8.Text = "Uspešno unet 100."
        ElseIf TextBox1.Text = "17" Then
            Button72_Click(Button72, e)
            Label8.Text = "Uspešno unet 17."
        ElseIf TextBox1.Text = "34" Then
            Button73_Click(Button73, e)
            Label8.Text = "Uspešno unet 34."
        ElseIf TextBox1.Text = "55" Then
            Button74_Click(Button74, e)
            Label8.Text = "Uspešno unet 55."
        ElseIf TextBox1.Text = "71" Then
            Button75_Click(Button75, e)
            Label8.Text = "Uspešno unet 71."
        ElseIf TextBox1.Text = "72" Then
            Button76_Click(Button76, e)
            Label8.Text = "Uspešno unet 72."
        ElseIf TextBox1.Text = "73" Then
            Button77_Click(Button77, e)
            Label8.Text = "Uspešno unet 73."
        ElseIf TextBox1.Text = "74" Then
            Button78_Click(Button78, e)
            Label8.Text = "Uspešno unet 74."
        ElseIf TextBox1.Text = "57" Then
            Button81_Click(Button81, e)
            Label8.Text = "Uspešno unet 57."
        ElseIf TextBox1.Text = "58" Then
            Button82_Click(Button82, e)
            Label8.Text = "Uspešno unet 58."
        ElseIf TextBox1.Text = "59" Then
            Button83_Click(Button83, e)
            Label8.Text = "Uspešno unet 59."
        ElseIf TextBox1.Text = "77" Then
            Button85_Click(Button85, e)
            Label8.Text = "Uspešno unet 77."
        ElseIf TextBox1.Text = "28" Then
            Button86_Click(Button86, e)
            Label8.Text = "Uspešno unet 28."
        ElseIf TextBox1.Text = "53" Then
            Button87_Click(Button87, e)
            Label8.Text = "Uspešno unet 53."
        ElseIf TextBox1.Text = "60" Then
            Button88_Click(Button88, e)
            Label8.Text = "Uspešno unet 60."
        ElseIf TextBox1.Text = "62" Then
            Button89_Click(Button89, e)
            Label8.Text = "Uspešno unet 62."


        Else

            Label8.ForeColor = Color.Red
            Label8.Text = "Pogrešan broj takmičara!!!"
        End If

        TextBox1.Text = ""
    End Sub
    Private Sub UserForm_Activate()
        With Me
            'This will create a vertical scrollbar
            .ScrollBars = fmScrollBarsVertical

            'Change the values of 2 as Per your requirements
            .ScrollHeight = .InsideHeight * 2
            .ScrollWidth = .InsideWidth * 9
        End With
    End Sub


    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub VScrollBar1_Scroll(sender As System.Object, e As System.Windows.Forms.ScrollEventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Function MoveWindow(intPtr As IntPtr, p2 As Integer, p3 As Integer, p4 As Integer, p5 As Integer, p6 As Boolean) As Boolean
        Throw New NotImplementedException
    End Function

    'Private Sub Panel1_MouseHover(sender As Object, e As System.EventArgs)
    '    Panel1.Focus.Equals(True)
    'End Sub


    'Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)
    '    Me.Panel1.VerticalScroll.Visible = True
    '    Me.Panel1.VerticalScroll.Enabled = True
    '    Me.Panel1.AutoScroll = True
    'End Sub


    Private Sub ListBox1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView1.Items.Count - 1
            ListView1.Items(i).Text = i + 1.ToString

        Next

        Dim item1 As ListViewItem = New ListViewItem(i + 1.ToString)
        item1.SubItems.Add(Label4.Text)
        item1.SubItems.Add(Label1.Text)
        item1.SubItems.Add(Label2.Text)
        ListView1.Items.Add(item1)

        ListView1.EnsureVisible(ListView1.Items.Count - 1)
        ListView1.Update()

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView21_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView21.SelectedIndexChanged

    End Sub

    'Private Sub Panel2_MouseHover(sender As Object, e As System.EventArgs)
    '    Panel2.Focus.Equals(True)
    'End Sub

    'Private Sub Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)
    '    Me.Panel2.VerticalScroll.Visible = True
    '    Me.Panel2.VerticalScroll.Enabled = True
    '    Me.Panel2.AutoScroll = True
    'End Sub

    Private Sub ListView20_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView20.SelectedIndexChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        'Panel1.Focus.Equals(True)
        Dim i20 As Integer
        For i20 = 0 To ListView20.Items.Count - 1
            ListView20.Items(i20).Text = i20 + 1.ToString

        Next

        Dim item20 As ListViewItem = New ListViewItem(i20 + 1.ToString)
        item20.SubItems.Add(Label4.Text)
        item20.SubItems.Add(Label1.Text)
        item20.SubItems.Add(Label2.Text)
        ListView20.Items.Add(item20)

        ListView20.EnsureVisible(ListView20.Items.Count - 1)
        ListView20.Update()

        ListView20.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView22_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView22.SelectedIndexChanged

    End Sub

    Private Sub ListView23_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView23.SelectedIndexChanged

    End Sub

    Private Sub ListView15_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView15.SelectedIndexChanged

    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView21.Items.Count - 1
            ListView21.Items(i).Text = i + 1.ToString

        Next

        Dim item21 As ListViewItem = New ListViewItem(i + 1.ToString)
        item21.SubItems.Add(Label4.Text)
        item21.SubItems.Add(Label1.Text)
        item21.SubItems.Add(Label2.Text)
        ListView21.Items.Add(item21)

        ListView21.EnsureVisible(ListView21.Items.Count - 1)
        ListView21.Update()

        ListView21.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView22.Items.Count - 1
            ListView22.Items(i).Text = i + 1.ToString

        Next

        Dim item22 As ListViewItem = New ListViewItem(i + 1.ToString)
        item22.SubItems.Add(Label4.Text)
        item22.SubItems.Add(Label1.Text)
        item22.SubItems.Add(Label2.Text)
        ListView22.Items.Add(item22)

        ListView22.EnsureVisible(ListView22.Items.Count - 1)
        ListView22.Update()

        ListView22.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView23.Items.Count - 1
            ListView23.Items(i).Text = i + 1.ToString

        Next

        Dim item23 As ListViewItem = New ListViewItem(i + 1.ToString)
        item23.SubItems.Add(Label4.Text)
        item23.SubItems.Add(Label1.Text)
        item23.SubItems.Add(Label2.Text)
        ListView23.Items.Add(item23)

        ListView23.EnsureVisible(ListView23.Items.Count - 1)
        ListView23.Update()

        ListView23.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click

        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView16.Items.Count - 1
            ListView16.Items(i).Text = i + 1.ToString

        Next

        Dim item16 As ListViewItem = New ListViewItem(i + 1.ToString)
        item16.SubItems.Add(Label4.Text)
        item16.SubItems.Add(Label1.Text)
        item16.SubItems.Add(Label2.Text)
        ListView16.Items.Add(item16)

        ListView16.EnsureVisible(ListView16.Items.Count - 1)
        ListView16.Update()

        ListView16.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView24.Items.Count - 1
            ListView24.Items(i).Text = i + 1.ToString

        Next

        Dim item24 As ListViewItem = New ListViewItem(i + 1.ToString)
        item24.SubItems.Add(Label4.Text)
        item24.SubItems.Add(Label1.Text)
        item24.SubItems.Add(Label2.Text)
        ListView24.Items.Add(item24)

        ListView24.EnsureVisible(ListView24.Items.Count - 1)
        ListView24.Update()

        ListView24.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView17.Items.Count - 1
            ListView17.Items(i).Text = i + 1.ToString

        Next

        Dim item17 As ListViewItem = New ListViewItem(i + 1.ToString)
        item17.SubItems.Add(Label4.Text)
        item17.SubItems.Add(Label1.Text)
        item17.SubItems.Add(Label2.Text)
        ListView17.Items.Add(item17)

        ListView17.EnsureVisible(ListView17.Items.Count - 1)
        ListView17.Update()

        ListView17.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView18.Items.Count - 1
            ListView18.Items(i).Text = i + 1.ToString

        Next

        Dim item18 As ListViewItem = New ListViewItem(i + 1.ToString)
        item18.SubItems.Add(Label4.Text)
        item18.SubItems.Add(Label1.Text)
        item18.SubItems.Add(Label2.Text)
        ListView18.Items.Add(item18)

        ListView18.EnsureVisible(ListView18.Items.Count - 1)
        ListView18.Update()

        ListView18.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView19.Items.Count - 1
            ListView19.Items(i).Text = i + 1.ToString

        Next

        Dim item19 As ListViewItem = New ListViewItem(i + 1.ToString)
        item19.SubItems.Add(Label4.Text)
        item19.SubItems.Add(Label1.Text)
        item19.SubItems.Add(Label2.Text)
        ListView19.Items.Add(item19)

        ListView19.EnsureVisible(ListView19.Items.Count - 1)
        ListView19.Update()

        ListView19.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        'Panel1.Focus.Equals(True)
        Dim i As Integer
        For i = 0 To ListView25.Items.Count - 1
            ListView25.Items(i).Text = i + 1.ToString

        Next

        Dim item25 As ListViewItem = New ListViewItem(i + 1.ToString)
        item25.SubItems.Add(Label4.Text)
        item25.SubItems.Add(Label1.Text)
        item25.SubItems.Add(Label2.Text)
        ListView25.Items.Add(item25)

        ListView25.EnsureVisible(ListView25.Items.Count - 1)
        ListView25.Update()

        ListView25.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button18_Click_1(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        'Panel1.Focus.Equals(True)
        Dim i15 As Integer
        For i15 = 0 To ListView15.Items.Count - 1
            ListView15.Items(i15).Text = i15 + 1.ToString
        Next

        Dim item15 As ListViewItem = New ListViewItem(i15 + 1.ToString)
        item15.SubItems.Add(Label4.Text)
        item15.SubItems.Add(Label1.Text)
        item15.SubItems.Add(Label2.Text)
        ListView15.Items.Add(item15)

        ListView15.EnsureVisible(ListView15.Items.Count - 1)
        ListView15.Update()

        ListView15.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim i1 As Integer
        For i1 = 0 To ListView2.Items.Count - 1
            ListView2.Items(i1).Text = i1 + 1.ToString
        Next

        Dim item2 As ListViewItem = New ListViewItem(i1 + 1.ToString)
        item2.SubItems.Add(Label4.Text)
        item2.SubItems.Add(Label1.Text)
        item2.SubItems.Add(Label2.Text)
        ListView2.Items.Add(item2)

        ListView2.EnsureVisible(ListView2.Items.Count - 1)
        ListView2.Update()

        ListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        'Panel1.Focus.Equals(True)
        Dim i3 As Integer
        For i3 = 0 To ListView3.Items.Count - 1
            ListView3.Items(i3).Text = i3 + 1.ToString
        Next

        Dim item3 As ListViewItem = New ListViewItem(i3 + 1.ToString)
        item3.SubItems.Add(Label4.Text)
        item3.SubItems.Add(Label1.Text)
        item3.SubItems.Add(Label2.Text)
        ListView3.Items.Add(item3)

        ListView3.EnsureVisible(ListView3.Items.Count - 1)
        ListView3.Update()

        ListView3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button7_Click_1(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        'Panel1.Focus.Equals(True)
        Dim i4 As Integer
        For i4 = 0 To ListView4.Items.Count - 1
            ListView4.Items(i4).Text = i4 + 1.ToString
        Next

        Dim item4 As ListViewItem = New ListViewItem(i4 + 1.ToString)
        item4.SubItems.Add(Label4.Text)
        item4.SubItems.Add(Label1.Text)
        item4.SubItems.Add(Label2.Text)
        ListView4.Items.Add(item4)

        ListView4.EnsureVisible(ListView4.Items.Count - 1)
        ListView4.Update()

        ListView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        'Panel1.Focus.Equals(True)
        Dim i5 As Integer
        For i5 = 0 To ListView5.Items.Count - 1
            ListView5.Items(i5).Text = i5 + 1.ToString
        Next

        Dim item5 As ListViewItem = New ListViewItem(i5 + 1.ToString)
        item5.SubItems.Add(Label4.Text)
        item5.SubItems.Add(Label1.Text)
        item5.SubItems.Add(Label2.Text)
        ListView5.Items.Add(item5)

        ListView5.EnsureVisible(ListView5.Items.Count - 1)
        ListView5.Update()

        ListView5.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button9_Click_1(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        'Panel1.Focus.Equals(True)
        Dim i6 As Integer
        For i6 = 0 To ListView6.Items.Count - 1
            ListView6.Items(i6).Text = i6 + 1.ToString
        Next

        Dim item6 As ListViewItem = New ListViewItem(i6 + 1.ToString)
        item6.SubItems.Add(Label4.Text)
        item6.SubItems.Add(Label1.Text)
        item6.SubItems.Add(Label2.Text)
        ListView6.Items.Add(item6)

        ListView6.EnsureVisible(ListView6.Items.Count - 1)
        ListView6.Update()

        ListView6.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button10_Click_1(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        'Panel1.Focus.Equals(True)
        Dim i7 As Integer
        For i7 = 0 To ListView7.Items.Count - 1
            ListView7.Items(i7).Text = i7 + 1.ToString
        Next

        Dim item7 As ListViewItem = New ListViewItem(i7 + 1.ToString)
        item7.SubItems.Add(Label4.Text)
        item7.SubItems.Add(Label1.Text)
        item7.SubItems.Add(Label2.Text)
        ListView7.Items.Add(item7)

        ListView7.EnsureVisible(ListView7.Items.Count - 1)
        ListView7.Update()

        ListView7.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button11_Click_1(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        'Panel1.Focus.Equals(True)
        Dim i8 As Integer
        For i8 = 0 To ListView8.Items.Count - 1
            ListView8.Items(i8).Text = i8 + 1.ToString
        Next

        Dim item8 As ListViewItem = New ListViewItem(i8 + 1.ToString)
        item8.SubItems.Add(Label4.Text)
        item8.SubItems.Add(Label1.Text)
        item8.SubItems.Add(Label2.Text)
        ListView8.Items.Add(item8)

        ListView8.EnsureVisible(ListView8.Items.Count - 1)
        ListView8.Update()

        ListView8.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button12_Click_1(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        'Panel1.Focus.Equals(True)
        Dim i9 As Integer
        For i9 = 0 To ListView9.Items.Count - 1
            ListView9.Items(i9).Text = i9 + 1.ToString
        Next

        Dim item9 As ListViewItem = New ListViewItem(i9 + 1.ToString)
        item9.SubItems.Add(Label4.Text)
        item9.SubItems.Add(Label1.Text)
        item9.SubItems.Add(Label2.Text)
        ListView9.Items.Add(item9)

        ListView9.EnsureVisible(ListView9.Items.Count - 1)
        ListView9.Update()

        ListView9.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button13_Click_1(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        'Panel1.Focus.Equals(True)
        Dim i10 As Integer
        For i10 = 0 To ListView10.Items.Count - 1
            ListView10.Items(i10).Text = i10 + 1.ToString
        Next

        Dim item10 As ListViewItem = New ListViewItem(i10 + 1.ToString)
        item10.SubItems.Add(Label4.Text)
        item10.SubItems.Add(Label1.Text)
        item10.SubItems.Add(Label2.Text)
        ListView10.Items.Add(item10)

        ListView10.EnsureVisible(ListView10.Items.Count - 1)
        ListView10.Update()

        ListView10.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub


    Private Sub Button14_Click_1(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        'Panel1.Focus.Equals(True)
        Dim i11 As Integer
        For i11 = 0 To ListView11.Items.Count - 1
            ListView11.Items(i11).Text = i11 + 1.ToString
        Next

        Dim item11 As ListViewItem = New ListViewItem(i11 + 1.ToString)
        item11.SubItems.Add(Label4.Text)
        item11.SubItems.Add(Label1.Text)
        item11.SubItems.Add(Label2.Text)
        ListView11.Items.Add(item11)

        ListView11.EnsureVisible(ListView11.Items.Count - 1)
        ListView11.Update()

        ListView11.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button15_Click_1(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        'Panel1.Focus.Equals(True)
        Dim i12 As Integer
        For i12 = 0 To ListView12.Items.Count - 1
            ListView12.Items(i12).Text = i12 + 1.ToString
        Next

        Dim item12 As ListViewItem = New ListViewItem(i12 + 1.ToString)
        item12.SubItems.Add(Label4.Text)
        item12.SubItems.Add(Label1.Text)
        item12.SubItems.Add(Label2.Text)
        ListView12.Items.Add(item12)

        ListView12.EnsureVisible(ListView12.Items.Count - 1)
        ListView12.Update()

        ListView12.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button16_Click_1(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        'Panel1.Focus.Equals(True)
        Dim i13 As Integer
        For i13 = 0 To ListView13.Items.Count - 1
            ListView13.Items(i13).Text = i13 + 1.ToString
        Next

        Dim item13 As ListViewItem = New ListViewItem(i13 + 1.ToString)
        item13.SubItems.Add(Label4.Text)
        item13.SubItems.Add(Label1.Text)
        item13.SubItems.Add(Label2.Text)
        ListView13.Items.Add(item13)

        ListView13.EnsureVisible(ListView13.Items.Count - 1)
        ListView13.Update()

        ListView13.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button17_Click_1(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        'Panel1.Focus.Equals(True)
        Dim i14 As Integer
        For i14 = 0 To ListView14.Items.Count - 1
            ListView14.Items(i14).Text = i14 + 1.ToString
        Next

        Dim item14 As ListViewItem = New ListViewItem(i14 + 1.ToString)
        item14.SubItems.Add(Label4.Text)
        item14.SubItems.Add(Label1.Text)
        item14.SubItems.Add(Label2.Text)
        ListView14.Items.Add(item14)

        ListView14.EnsureVisible(ListView14.Items.Count - 1)
        ListView14.Update()

        ListView14.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click

        Dim i32 As Integer
        For i32 = 0 To ListView26.Items.Count - 1
            ListView26.Items(i32).Text = i32 + 1.ToString

        Next

        Dim item32 As ListViewItem = New ListViewItem(i32 + 1.ToString)
        item32.SubItems.Add(Label4.Text)
        item32.SubItems.Add(Label1.Text)
        item32.SubItems.Add(Label2.Text)
        ListView26.Items.Add(item32)

        ListView26.EnsureVisible(ListView26.Items.Count - 1)
        ListView26.Update()

        ListView26.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        'Panel2.Focus.Equals(True)
        Dim i33 As Integer
        For i33 = 0 To ListView27.Items.Count - 1
            ListView27.Items(i33).Text = i33 + 1.ToString

        Next

        Dim item33 As ListViewItem = New ListViewItem(i33 + 1.ToString)
        item33.SubItems.Add(Label4.Text)
        item33.SubItems.Add(Label1.Text)
        item33.SubItems.Add(Label2.Text)
        ListView27.Items.Add(item33)

        ListView27.EnsureVisible(ListView27.Items.Count - 1)
        ListView27.Update()

        ListView27.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        'Panel2.Focus.Equals(True)
        Dim i34 As Integer
        For i34 = 0 To ListView28.Items.Count - 1
            ListView28.Items(i34).Text = i34 + 1.ToString

        Next

        Dim item34 As ListViewItem = New ListViewItem(i34 + 1.ToString)
        item34.SubItems.Add(Label4.Text)
        item34.SubItems.Add(Label1.Text)
        item34.SubItems.Add(Label2.Text)
        ListView28.Items.Add(item34)

        ListView28.EnsureVisible(ListView28.Items.Count - 1)
        ListView28.Update()

        ListView28.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        'Panel2.Focus.Equals(True)
        Dim i35 As Integer
        For i35 = 0 To ListView29.Items.Count - 1
            ListView29.Items(i35).Text = i35 + 1.ToString

        Next

        Dim item35 As ListViewItem = New ListViewItem(i35 + 1.ToString)
        item35.SubItems.Add(Label4.Text)
        item35.SubItems.Add(Label1.Text)
        item35.SubItems.Add(Label2.Text)
        ListView29.Items.Add(item35)

        ListView29.EnsureVisible(ListView29.Items.Count - 1)
        ListView29.Update()

        ListView29.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        'Panel2.Focus.Equals(True)
        Dim i36 As Integer
        For i36 = 0 To ListView30.Items.Count - 1
            ListView30.Items(i36).Text = i36 + 1.ToString

        Next

        Dim item36 As ListViewItem = New ListViewItem(i36 + 1.ToString)
        item36.SubItems.Add(Label4.Text)
        item36.SubItems.Add(Label1.Text)
        item36.SubItems.Add(Label2.Text)
        ListView30.Items.Add(item36)

        ListView30.EnsureVisible(ListView30.Items.Count - 1)
        ListView30.Update()

        ListView30.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        'Panel2.Focus.Equals(True)
        Dim i37 As Integer
        For i37 = 0 To ListView31.Items.Count - 1
            ListView31.Items(i37).Text = i37 + 1.ToString

        Next

        Dim item37 As ListViewItem = New ListViewItem(i37 + 1.ToString)
        item37.SubItems.Add(Label4.Text)
        item37.SubItems.Add(Label1.Text)
        item37.SubItems.Add(Label2.Text)
        ListView31.Items.Add(item37)

        ListView31.EnsureVisible(ListView31.Items.Count - 1)
        ListView31.Update()

        ListView31.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        'Panel2.Focus.Equals(True)
        Dim i38 As Integer
        For i38 = 0 To ListView32.Items.Count - 1
            ListView32.Items(i38).Text = i38 + 1.ToString

        Next

        Dim item38 As ListViewItem = New ListViewItem(i38 + 1.ToString)
        item38.SubItems.Add(Label4.Text)
        item38.SubItems.Add(Label1.Text)
        item38.SubItems.Add(Label2.Text)
        ListView32.Items.Add(item38)

        ListView32.EnsureVisible(ListView32.Items.Count - 1)
        ListView32.Update()

        ListView32.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        'Panel2.Focus.Equals(True)
        Dim i39 As Integer
        For i39 = 0 To ListView33.Items.Count - 1
            ListView33.Items(i39).Text = i39 + 1.ToString

        Next

        Dim item39 As ListViewItem = New ListViewItem(i39 + 1.ToString)
        item39.SubItems.Add(Label4.Text)
        item39.SubItems.Add(Label1.Text)
        item39.SubItems.Add(Label2.Text)
        ListView33.Items.Add(item39)

        ListView33.EnsureVisible(ListView33.Items.Count - 1)
        ListView33.Update()

        ListView33.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        'Panel2.Focus.Equals(True)
        Dim i40 As Integer
        For i40 = 0 To ListView34.Items.Count - 1
            ListView34.Items(i40).Text = i40 + 1.ToString

        Next

        Dim item40 As ListViewItem = New ListViewItem(i40 + 1.ToString)
        item40.SubItems.Add(Label4.Text)
        item40.SubItems.Add(Label1.Text)
        item40.SubItems.Add(Label2.Text)
        ListView34.Items.Add(item40)

        ListView34.EnsureVisible(ListView34.Items.Count - 1)
        ListView34.Update()

        ListView34.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        'Panel2.Focus.Equals(True)
        Dim i41 As Integer
        For i41 = 0 To ListView35.Items.Count - 1
            ListView35.Items(i41).Text = i41 + 1.ToString

        Next

        Dim item41 As ListViewItem = New ListViewItem(i41 + 1.ToString)
        item41.SubItems.Add(Label4.Text)
        item41.SubItems.Add(Label1.Text)
        item41.SubItems.Add(Label2.Text)
        ListView35.Items.Add(item41)

        ListView35.EnsureVisible(ListView35.Items.Count - 1)
        ListView35.Update()

        ListView35.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        'Panel2.Focus.Equals(True)
        Dim i42 As Integer
        For i42 = 0 To ListView36.Items.Count - 1
            ListView36.Items(i42).Text = i42 + 1.ToString

        Next

        Dim item42 As ListViewItem = New ListViewItem(i42 + 1.ToString)
        item42.SubItems.Add(Label4.Text)
        item42.SubItems.Add(Label1.Text)
        item42.SubItems.Add(Label2.Text)
        ListView36.Items.Add(item42)

        ListView36.EnsureVisible(ListView36.Items.Count - 1)
        ListView36.Update()

        ListView36.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        'Panel2.Focus.Equals(True)
        Dim i43 As Integer
        For i43 = 0 To ListView37.Items.Count - 1
            ListView37.Items(i43).Text = i43 + 1.ToString

        Next

        Dim item43 As ListViewItem = New ListViewItem(i43 + 1.ToString)
        item43.SubItems.Add(Label4.Text)
        item43.SubItems.Add(Label1.Text)
        item43.SubItems.Add(Label2.Text)
        ListView37.Items.Add(item43)

        ListView37.EnsureVisible(ListView37.Items.Count - 1)
        ListView37.Update()

        ListView37.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        'Panel2.Focus.Equals(True)
        Dim i44 As Integer
        For i44 = 0 To ListView38.Items.Count - 1
            ListView38.Items(i44).Text = i44 + 1.ToString

        Next

        Dim item44 As ListViewItem = New ListViewItem(i44 + 1.ToString)
        item44.SubItems.Add(Label4.Text)
        item44.SubItems.Add(Label1.Text)
        item44.SubItems.Add(Label2.Text)
        ListView38.Items.Add(item44)

        ListView38.EnsureVisible(ListView38.Items.Count - 1)
        ListView38.Update()

        ListView38.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        'Panel2.Focus.Equals(True)
        Dim i45 As Integer
        For i45 = 0 To ListView39.Items.Count - 1
            ListView39.Items(i45).Text = i45 + 1.ToString

        Next

        Dim item45 As ListViewItem = New ListViewItem(i45 + 1.ToString)
        item45.SubItems.Add(Label4.Text)
        item45.SubItems.Add(Label1.Text)
        item45.SubItems.Add(Label2.Text)
        ListView39.Items.Add(item45)

        ListView39.EnsureVisible(ListView39.Items.Count - 1)
        ListView39.Update()

        ListView39.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        'Panel2.Focus.Equals(True)
        Dim i46 As Integer
        For i46 = 0 To ListView40.Items.Count - 1
            ListView40.Items(i46).Text = i46 + 1.ToString

        Next

        Dim item46 As ListViewItem = New ListViewItem(i46 + 1.ToString)
        item46.SubItems.Add(Label4.Text)
        item46.SubItems.Add(Label1.Text)
        item46.SubItems.Add(Label2.Text)
        ListView40.Items.Add(item46)

        ListView40.EnsureVisible(ListView40.Items.Count - 1)
        ListView40.Update()

        ListView40.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        'Panel2.Focus.Equals(True)
        Dim i47 As Integer
        For i47 = 0 To ListView41.Items.Count - 1
            ListView41.Items(i47).Text = i47 + 1.ToString

        Next

        Dim item47 As ListViewItem = New ListViewItem(i47 + 1.ToString)
        item47.SubItems.Add(Label4.Text)
        item47.SubItems.Add(Label1.Text)
        item47.SubItems.Add(Label2.Text)
        ListView41.Items.Add(item47)

        ListView41.EnsureVisible(ListView41.Items.Count - 1)
        ListView41.Update()

        ListView41.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        'Panel2.Focus.Equals(True)
        Dim i48 As Integer
        For i48 = 0 To ListView42.Items.Count - 1
            ListView42.Items(i48).Text = i48 + 1.ToString

        Next

        Dim item48 As ListViewItem = New ListViewItem(i48 + 1.ToString)
        item48.SubItems.Add(Label4.Text)
        item48.SubItems.Add(Label1.Text)
        item48.SubItems.Add(Label2.Text)
        ListView42.Items.Add(item48)

        ListView42.EnsureVisible(ListView42.Items.Count - 1)
        ListView42.Update()

        ListView42.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        'Panel2.Focus.Equals(True)
        Dim i49 As Integer
        For i49 = 0 To ListView43.Items.Count - 1
            ListView43.Items(i49).Text = i49 + 1.ToString

        Next

        Dim item49 As ListViewItem = New ListViewItem(i49 + 1.ToString)
        item49.SubItems.Add(Label4.Text)
        item49.SubItems.Add(Label1.Text)
        item49.SubItems.Add(Label2.Text)
        ListView43.Items.Add(item49)

        ListView43.EnsureVisible(ListView43.Items.Count - 1)
        ListView43.Update()

        ListView43.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        'Panel2.Focus.Equals(True)
        Dim i50 As Integer
        For i50 = 0 To ListView44.Items.Count - 1
            ListView44.Items(i50).Text = i50 + 1.ToString

        Next

        Dim item50 As ListViewItem = New ListViewItem(i50 + 1.ToString)
        item50.SubItems.Add(Label4.Text)
        item50.SubItems.Add(Label1.Text)
        item50.SubItems.Add(Label2.Text)
        ListView44.Items.Add(item50)

        ListView44.EnsureVisible(ListView44.Items.Count - 1)
        ListView44.Update()

        ListView44.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        'Panel2.Focus.Equals(True)
        Dim i51 As Integer
        For i51 = 0 To ListView45.Items.Count - 1
            ListView45.Items(i51).Text = i51 + 1.ToString

        Next

        Dim item51 As ListViewItem = New ListViewItem(i51 + 1.ToString)
        item51.SubItems.Add(Label4.Text)
        item51.SubItems.Add(Label1.Text)
        item51.SubItems.Add(Label2.Text)
        ListView45.Items.Add(item51)

        ListView45.EnsureVisible(ListView45.Items.Count - 1)
        ListView45.Update()

        ListView45.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        'Panel2.Focus.Equals(True)
        Dim i52 As Integer
        For i52 = 0 To ListView46.Items.Count - 1
            ListView46.Items(i52).Text = i52 + 1.ToString

        Next

        Dim item52 As ListViewItem = New ListViewItem(i52 + 1.ToString)
        item52.SubItems.Add(Label4.Text)
        item52.SubItems.Add(Label1.Text)
        item52.SubItems.Add(Label2.Text)
        ListView46.Items.Add(item52)

        ListView46.EnsureVisible(ListView46.Items.Count - 1)
        ListView46.Update()

        ListView46.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        'Panel2.Focus.Equals(True)
        Dim i53 As Integer
        For i53 = 0 To ListView47.Items.Count - 1
            ListView47.Items(i53).Text = i53 + 1.ToString

        Next

        Dim item53 As ListViewItem = New ListViewItem(i53 + 1.ToString)
        item53.SubItems.Add(Label4.Text)
        item53.SubItems.Add(Label1.Text)
        item53.SubItems.Add(Label2.Text)
        ListView47.Items.Add(item53)

        ListView47.EnsureVisible(ListView47.Items.Count - 1)
        ListView47.Update()

        ListView47.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click
        'Panel2.Focus.Equals(True)
        Dim i54 As Integer
        For i54 = 0 To ListView48.Items.Count - 1
            ListView48.Items(i54).Text = i54 + 1.ToString

        Next

        Dim item54 As ListViewItem = New ListViewItem(i54 + 1.ToString)
        item54.SubItems.Add(Label4.Text)
        item54.SubItems.Add(Label1.Text)
        item54.SubItems.Add(Label2.Text)
        ListView48.Items.Add(item54)

        ListView48.EnsureVisible(ListView48.Items.Count - 1)
        ListView48.Update()

        ListView48.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        'Panel2.Focus.Equals(True)
        Dim i55 As Integer
        For i55 = 0 To ListView49.Items.Count - 1
            ListView49.Items(i55).Text = i55 + 1.ToString

        Next

        Dim item55 As ListViewItem = New ListViewItem(i55 + 1.ToString)
        item55.SubItems.Add(Label4.Text)
        item55.SubItems.Add(Label1.Text)
        item55.SubItems.Add(Label2.Text)
        ListView49.Items.Add(item55)

        ListView49.EnsureVisible(ListView49.Items.Count - 1)
        ListView49.Update()

        ListView49.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click
        'Panel2.Focus.Equals(True)
        Dim i56 As Integer
        For i56 = 0 To ListView50.Items.Count - 1
            ListView50.Items(i56).Text = i56 + 1.ToString

        Next

        Dim item56 As ListViewItem = New ListViewItem(i56 + 1.ToString)
        item56.SubItems.Add(Label4.Text)
        item56.SubItems.Add(Label1.Text)
        item56.SubItems.Add(Label2.Text)
        ListView50.Items.Add(item56)

        ListView50.EnsureVisible(ListView50.Items.Count - 1)
        ListView50.Update()

        ListView50.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        'Panel2.Focus.Equals(True)
        Dim i57 As Integer
        For i57 = 0 To ListView51.Items.Count - 1
            ListView51.Items(i57).Text = i57 + 1.ToString

        Next

        Dim item57 As ListViewItem = New ListViewItem(i57 + 1.ToString)
        item57.SubItems.Add(Label4.Text)
        item57.SubItems.Add(Label1.Text)
        item57.SubItems.Add(Label2.Text)
        ListView51.Items.Add(item57)

        ListView51.EnsureVisible(ListView51.Items.Count - 1)
        ListView51.Update()

        ListView51.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        'Panel2.Focus.Equals(True)
        Dim i58 As Integer
        For i58 = 0 To ListView52.Items.Count - 1
            ListView52.Items(i58).Text = i58 + 1.ToString

        Next

        Dim item58 As ListViewItem = New ListViewItem(i58 + 1.ToString)
        item58.SubItems.Add(Label4.Text)
        item58.SubItems.Add(Label1.Text)
        item58.SubItems.Add(Label2.Text)
        ListView52.Items.Add(item58)

        ListView52.EnsureVisible(ListView52.Items.Count - 1)
        ListView52.Update()

        ListView52.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs)
        'Panel2.Focus.Equals(True)
        Dim i59 As Integer
        For i59 = 0 To ListView53.Items.Count - 1
            ListView53.Items(i59).Text = i59 + 1.ToString

        Next

        Dim item59 As ListViewItem = New ListViewItem(i59 + 1.ToString)
        item59.SubItems.Add(Label4.Text)
        item59.SubItems.Add(Label1.Text)
        item59.SubItems.Add(Label2.Text)
        ListView53.Items.Add(item59)

        ListView53.EnsureVisible(ListView53.Items.Count - 1)
        ListView53.Update()

        ListView53.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        'Panel2.Focus.Equals(True)
        Dim i60 As Integer
        For i60 = 0 To ListView54.Items.Count - 1
            ListView54.Items(i60).Text = i60 + 1.ToString

        Next

        Dim item60 As ListViewItem = New ListViewItem(i60 + 1.ToString)
        item60.SubItems.Add(Label4.Text)
        item60.SubItems.Add(Label1.Text)
        item60.SubItems.Add(Label2.Text)
        ListView54.Items.Add(item60)

        ListView54.EnsureVisible(ListView54.Items.Count - 1)
        ListView54.Update()

        ListView54.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        'Panel2.Focus.Equals(True)
        Dim i61 As Integer
        For i61 = 0 To ListView55.Items.Count - 1
            ListView55.Items(i61).Text = i61 + 1.ToString

        Next

        Dim item61 As ListViewItem = New ListViewItem(i61 + 1.ToString)
        item61.SubItems.Add(Label4.Text)
        item61.SubItems.Add(Label1.Text)
        item61.SubItems.Add(Label2.Text)
        ListView55.Items.Add(item61)

        ListView55.EnsureVisible(ListView55.Items.Count - 1)
        ListView55.Update()

        ListView55.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView16_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView16.SelectedIndexChanged

    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        Dim i62 As Integer
        For i62 = 0 To ListView56.Items.Count - 1
            ListView56.Items(i62).Text = i62 + 1.ToString

        Next

        Dim item62 As ListViewItem = New ListViewItem(i62 + 1.ToString)
        item62.SubItems.Add(Label4.Text)
        item62.SubItems.Add(Label1.Text)
        item62.SubItems.Add(Label2.Text)
        ListView56.Items.Add(item62)

        ListView56.EnsureVisible(ListView56.Items.Count - 1)
        ListView56.Update()

        ListView56.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        Dim i63 As Integer
        For i63 = 0 To ListView57.Items.Count - 1
            ListView57.Items(i63).Text = i63 + 1.ToString

        Next

        Dim item63 As ListViewItem = New ListViewItem(i63 + 1.ToString)
        item63.SubItems.Add(Label4.Text)
        item63.SubItems.Add(Label1.Text)
        item63.SubItems.Add(Label2.Text)
        ListView57.Items.Add(item63)

        ListView57.EnsureVisible(ListView57.Items.Count - 1)
        ListView57.Update()

        ListView57.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click
        Dim i64 As Integer
        For i64 = 0 To ListView58.Items.Count - 1
            ListView58.Items(i64).Text = i64 + 1.ToString

        Next

        Dim item64 As ListViewItem = New ListViewItem(i64 + 1.ToString)
        item64.SubItems.Add(Label4.Text)
        item64.SubItems.Add(Label1.Text)
        item64.SubItems.Add(Label2.Text)
        ListView58.Items.Add(item64)

        ListView58.EnsureVisible(ListView58.Items.Count - 1)
        ListView58.Update()

        ListView58.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click
        Dim i65 As Integer
        For i65 = 0 To ListView59.Items.Count - 1
            ListView59.Items(i65).Text = i65 + 1.ToString

        Next

        Dim item65 As ListViewItem = New ListViewItem(i65 + 1.ToString)
        item65.SubItems.Add(Label4.Text)
        item65.SubItems.Add(Label1.Text)
        item65.SubItems.Add(Label2.Text)
        ListView59.Items.Add(item65)

        ListView59.EnsureVisible(ListView59.Items.Count - 1)
        ListView59.Update()

        ListView59.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        Dim i66 As Integer
        For i66 = 0 To ListView60.Items.Count - 1
            ListView60.Items(i66).Text = i66 + 1.ToString

        Next

        Dim item66 As ListViewItem = New ListViewItem(i66 + 1.ToString)
        item66.SubItems.Add(Label4.Text)
        item66.SubItems.Add(Label1.Text)
        item66.SubItems.Add(Label2.Text)
        ListView60.Items.Add(item66)

        ListView60.EnsureVisible(ListView60.Items.Count - 1)
        ListView60.Update()

        ListView60.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView42_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView42.SelectedIndexChanged

    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click
        Dim i67 As Integer
        For i67 = 0 To ListView61.Items.Count - 1
            ListView61.Items(i67).Text = i67 + 1.ToString

        Next

        Dim item67 As ListViewItem = New ListViewItem(i67 + 1.ToString)
        item67.SubItems.Add(Label4.Text)
        item67.SubItems.Add(Label1.Text)
        item67.SubItems.Add(Label2.Text)
        ListView61.Items.Add(item67)

        ListView61.EnsureVisible(ListView61.Items.Count - 1)
        ListView61.Update()

        ListView61.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button68_Click(sender As System.Object, e As System.EventArgs) Handles Button68.Click
        Dim i68 As Integer
        For i68 = 0 To ListView62.Items.Count - 1
            ListView62.Items(i68).Text = i68 + 1.ToString

        Next

        Dim item68 As ListViewItem = New ListViewItem(i68 + 1.ToString)
        item68.SubItems.Add(Label4.Text)
        item68.SubItems.Add(Label1.Text)
        item68.SubItems.Add(Label2.Text)
        ListView62.Items.Add(item68)

        ListView62.EnsureVisible(ListView62.Items.Count - 1)
        ListView62.Update()

        ListView62.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Button69_Click(sender As System.Object, e As System.EventArgs) Handles Button69.Click

        Dim xls As New Excel.Application
        Dim sheet As Excel.Worksheet
        Dim i As Integer

        ' morao sam da dodam CorruptLoad:=True jer na Win7 dolazi do System.Runtime.InteropServices.COMException (0x800A03EC)
        xls.Workbooks.Open("c:\rezultati\rez.xls")
        sheet = xls.ActiveWorkbook.Sheets(1)

        sheet.Cells(1, 1) = "MUŠKARCI - 6 SATI"

        sheet.Cells(2, 1) = "Takmičar/Competitor"
        sheet.Cells(2, 2) = "Krug/Lap"
        sheet.Cells(2, 3) = "Sat"
        sheet.Cells(2, 4) = "Min"
        sheet.Cells(2, 5) = "Sek"


        sheet.Cells(3, 1) = "Darko Arenijević (2)"
        For Each item As ListViewItem In ListView1.Items
            For i = 0 To item.SubItems.Count - 1
                sheet.Cells(3, i + 2) = item.SubItems(i).Text
            Next
        Next

        sheet.Cells(4, 1) = "Inot Klemenčič (4)"
        For Each item1 As ListViewItem In ListView2.Items
            For i = 0 To item1.SubItems.Count - 1
                sheet.Cells(4, i + 2) = item1.SubItems(i).Text
            Next
        Next

        sheet.Cells(5, 1) = "Dragan Pavlović (6)"
        For Each item2 As ListViewItem In ListView3.Items
            For i = 0 To item2.SubItems.Count - 1
                sheet.Cells(5, i + 2) = item2.SubItems(i).Text
            Next
        Next

        sheet.Cells(6, 1) = "Dragan Đ. Ćirić (12)"
        For Each item3 As ListViewItem In ListView4.Items
            For i = 0 To item3.SubItems.Count - 1
                sheet.Cells(6, i + 2) = item3.SubItems(i).Text
            Next
        Next

        sheet.Cells(7, 1) = "Nenad Glusac (13)"
        For Each item4 As ListViewItem In ListView5.Items
            For i = 0 To item4.SubItems.Count - 1
                sheet.Cells(7, i + 2) = item4.SubItems(i).Text
            Next
        Next

        sheet.Cells(8, 1) = "Miloje Jovanović Miki (15)"
        For Each item5 As ListViewItem In ListView6.Items
            For i = 0 To item5.SubItems.Count - 1
                sheet.Cells(8, i + 2) = item5.SubItems(i).Text
            Next
        Next

        sheet.Cells(9, 1) = "Dragutin Krstajić (38)"
        For Each item6 As ListViewItem In ListView7.Items
            For i = 0 To item6.SubItems.Count - 1
                sheet.Cells(9, i + 2) = item6.SubItems(i).Text
            Next
        Next

        sheet.Cells(10, 1) = "Dragan Ćirić (21)"
        For Each item7 As ListViewItem In ListView8.Items
            For i = 0 To item7.SubItems.Count - 1
                sheet.Cells(10, i + 2) = item7.SubItems(i).Text
            Next
        Next

        sheet.Cells(11, 1) = "Elvir Rakipović (29)"
        For Each item8 As ListViewItem In ListView9.Items
            For i = 0 To item8.SubItems.Count - 1
                sheet.Cells(11, i + 2) = item8.SubItems(i).Text
            Next
        Next

        sheet.Cells(12, 1) = "Ruždi Rakipović (30)"
        For Each item9 As ListViewItem In ListView10.Items
            For i = 0 To item9.SubItems.Count - 1
                sheet.Cells(12, i + 2) = item9.SubItems(i).Text
            Next
        Next

        sheet.Cells(13, 1) = "Ivan Simić (32)"
        For Each item10 As ListViewItem In ListView11.Items
            For i = 0 To item10.SubItems.Count - 1
                sheet.Cells(13, i + 2) = item10.SubItems(i).Text
            Next
        Next

        sheet.Cells(14, 1) = "Drago Boroja (33)"
        For Each item11 As ListViewItem In ListView12.Items
            For i = 0 To item11.SubItems.Count - 1
                sheet.Cells(14, i + 2) = item11.SubItems(i).Text
            Next
        Next

        sheet.Cells(15, 1) = "Drago Knežević (42)"
        For Each item12 As ListViewItem In ListView13.Items
            For i = 0 To item12.SubItems.Count - 1
                sheet.Cells(15, i + 2) = item12.SubItems(i).Text
            Next
        Next

        sheet.Cells(16, 1) = "Milenko Jerman (44)"
        For Each item13 As ListViewItem In ListView14.Items
            For i = 0 To item13.SubItems.Count - 1
                sheet.Cells(16, i + 2) = item13.SubItems(i).Text
            Next
        Next

        sheet.Cells(17, 1) = "Miroslav Ranđelović (99)"
        For Each item14 As ListViewItem In ListView20.Items
            For i = 0 To item14.SubItems.Count - 1
                sheet.Cells(17, i + 2) = item14.SubItems(i).Text
            Next
        Next

        sheet.Cells(18, 1) = "Slobodan Leontijević (56)"
        For Each item15 As ListViewItem In ListView21.Items
            For i = 0 To item15.SubItems.Count - 1
                sheet.Cells(18, i + 2) = item15.SubItems(i).Text
            Next
        Next

        sheet.Cells(19, 1) = "Nenad Grbanović (46)"
        For Each item16 As ListViewItem In ListView22.Items
            For i = 0 To item16.SubItems.Count - 1
                sheet.Cells(19, i + 2) = item16.SubItems(i).Text
            Next
        Next

        sheet.Cells(20, 1) = "Veljko Jevremović (48)"
        For Each item17 As ListViewItem In ListView23.Items
            For i = 0 To item17.SubItems.Count - 1
                sheet.Cells(20, i + 2) = item17.SubItems(i).Text
            Next
        Next

        sheet.Cells(21, 1) = "Nenad Kovač (49)"
        For Each item18 As ListViewItem In ListView15.Items
            For i = 0 To item18.SubItems.Count - 1
                sheet.Cells(21, i + 2) = item18.SubItems(i).Text
            Next
        Next

        sheet.Cells(22, 1) = "Dragan Krsmanović (51)"
        For Each item19 As ListViewItem In ListView61.Items
            For i = 0 To item19.SubItems.Count - 1
                sheet.Cells(22, i + 2) = item19.SubItems(i).Text
            Next
        Next

        sheet.Cells(23, 1) = "Saša Dimić (52)"
        For Each item20 As ListViewItem In ListView62.Items
            For i = 0 To item20.SubItems.Count - 1
                sheet.Cells(23, i + 2) = item20.SubItems(i).Text
            Next
        Next

        sheet.Cells(24, 1) = "Saša Gacik (54)"
        For Each item70 As ListViewItem In ListView63.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(24, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(25, 1) = "Branislav Cvetković (55)"
        For Each item70 As ListViewItem In ListView67.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(25, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(26, 1) = "Srđan Đurić (57)"
        For Each item70 As ListViewItem In ListView74.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(26, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(27, 1) = "Staniša Milosavljević (58)"
        For Each item70 As ListViewItem In ListView75.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(27, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(28, 1) = "Mile Rašković (59)"
        For Each item70 As ListViewItem In ListView76.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(28, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(29, 1) = "Miljurko Đurković (16)"
        For Each item70 As ListViewItem In ListView77.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(29, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(30, 1) = "Miloje Andrić (77)"
        For Each item70 As ListViewItem In ListView78.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(30, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(31, 1) = "Dražen Sarjanović (28)"
        For Each item70 As ListViewItem In ListView79.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(31, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(32, 1) = "Goran Antičević (53)"
        For Each item70 As ListViewItem In ListView80.Items
            For i = 0 To item70.SubItems.Count - 1
                sheet.Cells(32, i + 2) = item70.SubItems(i).Text
            Next
        Next

        sheet.Cells(33, 1) = "ŽENE - 6 SATI"

        sheet.Cells(34, 1) = "Takmičar/Competitor"
        sheet.Cells(34, 2) = "Krug/Lap"
        sheet.Cells(34, 3) = "Sat"
        sheet.Cells(34, 4) = "Min"
        sheet.Cells(34, 5) = "Sek"

        sheet.Cells(35, 1) = "Zdravka Kneževic (23)"
        For Each item21 As ListViewItem In ListView16.Items
            For i = 0 To item21.SubItems.Count - 1
                sheet.Cells(35, i + 2) = item21.SubItems(i).Text
            Next
        Next

        sheet.Cells(36, 1) = "Tanja Ožanić (24)"
        For Each item22 As ListViewItem In ListView24.Items
            For i = 0 To item22.SubItems.Count - 1
                sheet.Cells(36, i + 2) = item22.SubItems(i).Text
            Next
        Next

        sheet.Cells(37, 1) = "Saša Tucaković (27)"
        For Each item23 As ListViewItem In ListView17.Items
            For i = 0 To item23.SubItems.Count - 1
                sheet.Cells(37, i + 2) = item23.SubItems(i).Text
            Next
        Next

        sheet.Cells(38, 1) = "Karin Jerman (43)"
        For Each item24 As ListViewItem In ListView18.Items
            For i = 0 To item24.SubItems.Count - 1
                sheet.Cells(38, i + 2) = item24.SubItems(i).Text
            Next
        Next

        sheet.Cells(39, 1) = "Dragica Mitić (45)"
        For Each item25 As ListViewItem In ListView19.Items
            For i = 0 To item25.SubItems.Count - 1
                sheet.Cells(39, i + 2) = item25.SubItems(i).Text
            Next
        Next

        sheet.Cells(40, 1) = "Marjeta Gomilsak (50)"
        For Each item25 As ListViewItem In ListView25.Items
            For i = 0 To item25.SubItems.Count - 1
                sheet.Cells(40, i + 2) = item25.SubItems(i).Text
            Next
        Next

        sheet.Cells(41, 1) = "Sanela Janković (60)"
        For Each item25 As ListViewItem In ListView81.Items
            For i = 0 To item25.SubItems.Count - 1
                sheet.Cells(41, i + 2) = item25.SubItems(i).Text
            Next
        Next

        sheet.Cells(42, 1) = "Vera Velimirović (62)"
        For Each item25 As ListViewItem In ListView82.Items
            For i = 0 To item25.SubItems.Count - 1
                sheet.Cells(42, i + 2) = item25.SubItems(i).Text
            Next
        Next

        sheet.Cells(47, 1) = "MUŠKARCI - 12 SATI"

        sheet.Cells(48, 1) = "Takmičar/Competitor"
        sheet.Cells(48, 2) = "Krug/Lap"
        sheet.Cells(48, 3) = "Sat"
        sheet.Cells(48, 4) = "Min"
        sheet.Cells(48, 5) = "Sek"

        sheet.Cells(49, 1) = "Zoran Dimov (11)"
        For Each item26 As ListViewItem In ListView26.Items
            For i = 0 To item26.SubItems.Count - 1
                sheet.Cells(49, i + 2) = item26.SubItems(i).Text
            Next
        Next

        sheet.Cells(50, 1) = "Jovica Stojanovski  (69)"
        For Each item27 As ListViewItem In ListView27.Items
            For i = 0 To item27.SubItems.Count - 1
                sheet.Cells(50, i + 2) = item27.SubItems(i).Text
            Next
        Next

        sheet.Cells(51, 1) = "Klemen Boštar (7)"
        For Each item28 As ListViewItem In ListView28.Items
            For i = 0 To item28.SubItems.Count - 1
                sheet.Cells(51, i + 2) = item28.SubItems(i).Text
            Next
        Next

        sheet.Cells(52, 1) = "Jovica Jovanchev (9)"
        For Each item29 As ListViewItem In ListView29.Items
            For i = 0 To item29.SubItems.Count - 1
                sheet.Cells(52, i + 2) = item29.SubItems(i).Text
            Next
        Next

        sheet.Cells(53, 1) = "Miroslav Pajić (10)"
        For Each item30 As ListViewItem In ListView30.Items
            For i = 0 To item30.SubItems.Count - 1
                sheet.Cells(53, i + 2) = item30.SubItems(i).Text
            Next
        Next

        sheet.Cells(54, 1) = "Branislav Pavić (14)"
        For Each item31 As ListViewItem In ListView31.Items
            For i = 0 To item31.SubItems.Count - 1
                sheet.Cells(54, i + 2) = item31.SubItems(i).Text
            Next
        Next

        sheet.Cells(55, 1) = "Miljurko Djurković (16)"
        For Each item32 As ListViewItem In ListView32.Items
            For i = 0 To item32.SubItems.Count - 1
                sheet.Cells(55, i + 2) = item32.SubItems(i).Text
            Next
        Next

        sheet.Cells(56, 1) = "Srećko Mićić (18)"
        For Each item33 As ListViewItem In ListView33.Items
            For i = 0 To item33.SubItems.Count - 1
                sheet.Cells(56, i + 2) = item33.SubItems(i).Text
            Next
        Next

        sheet.Cells(57, 1) = "Nenad Ivanović (20)"
        For Each item34 As ListViewItem In ListView34.Items
            For i = 0 To item34.SubItems.Count - 1
                sheet.Cells(57, i + 2) = item34.SubItems(i).Text
            Next
        Next

        sheet.Cells(58, 1) = "Giacomino Barbacetto (25)"
        For Each item35 As ListViewItem In ListView35.Items
            For i = 0 To item35.SubItems.Count - 1
                sheet.Cells(58, i + 2) = item35.SubItems(i).Text
            Next
        Next

        sheet.Cells(59, 1) = "Kire Naunčevski Pekmez (26)"
        For Each item36 As ListViewItem In ListView36.Items
            For i = 0 To item36.SubItems.Count - 1
                sheet.Cells(59, i + 2) = item36.SubItems(i).Text
            Next
        Next

        sheet.Cells(60, 1) = "Dancho Markovski (28)"
        For Each item37 As ListViewItem In ListView37.Items
            For i = 0 To item37.SubItems.Count - 1
                sheet.Cells(60, i + 2) = item37.SubItems(i).Text
            Next
        Next

        sheet.Cells(61, 1) = "Saša Tubin (31)"
        For Each item38 As ListViewItem In ListView38.Items
            For i = 0 To item38.SubItems.Count - 1
                sheet.Cells(61, i + 2) = item38.SubItems(i).Text
            Next
        Next

        sheet.Cells(62, 1) = "Viktor VITE Toleski (35)"
        For Each item39 As ListViewItem In ListView39.Items
            For i = 0 To item39.SubItems.Count - 1
                sheet.Cells(62, i + 2) = item39.SubItems(i).Text
            Next
        Next

        sheet.Cells(63, 1) = "Semir Kasić (38)"
        For Each item40 As ListViewItem In ListView40.Items
            For i = 0 To item40.SubItems.Count - 1
                sheet.Cells(63, i + 2) = item40.SubItems(i).Text
            Next
        Next

        sheet.Cells(64, 1) = "Branimir Stojanović (39)"
        For Each item41 As ListViewItem In ListView41.Items
            For i = 0 To item41.SubItems.Count - 1
                sheet.Cells(64, i + 2) = item41.SubItems(i).Text
            Next
        Next

        sheet.Cells(65, 1) = "Milan Piljak (40)"
        For Each item42 As ListViewItem In ListView42.Items
            For i = 0 To item42.SubItems.Count - 1
                sheet.Cells(65, i + 2) = item42.SubItems(i).Text
            Next
        Next

        sheet.Cells(66, 1) = "Franjo Pap (76)"
        For Each item43 As ListViewItem In ListView43.Items
            For i = 0 To item43.SubItems.Count - 1
                sheet.Cells(66, i + 2) = item43.SubItems(i).Text
            Next
        Next

        sheet.Cells(67, 1) = "Đorđe Vučković (41)"
        For Each item44 As ListViewItem In ListView44.Items
            For i = 0 To item44.SubItems.Count - 1
                sheet.Cells(67, i + 2) = item44.SubItems(i).Text
            Next
        Next

        sheet.Cells(68, 1) = "Albert Schmidek (98)"
        For Each item45 As ListViewItem In ListView45.Items
            For i = 0 To item45.SubItems.Count - 1
                sheet.Cells(68, i + 2) = item45.SubItems(i).Text
            Next
        Next

        sheet.Cells(69, 1) = "Nreka Ljuljdjuraj (47)"
        For Each item46 As ListViewItem In ListView46.Items
            For i = 0 To item46.SubItems.Count - 1
                sheet.Cells(69, i + 2) = item46.SubItems(i).Text
            Next
        Next

        sheet.Cells(70, 1) = "Ivan Šunjevarič (3)"
        For Each item81 As ListViewItem In ListView53.Items
            For i = 0 To item81.SubItems.Count - 1
                sheet.Cells(70, i + 2) = item81.SubItems(i).Text
            Next
        Next

        sheet.Cells(71, 1) = "Takmicar1"
        For Each item47 As ListViewItem In ListView56.Items
            For i = 0 To item47.SubItems.Count - 1
                sheet.Cells(71, i + 2) = item47.SubItems(i).Text
            Next
        Next

        sheet.Cells(72, 1) = "Takmicar2"
        For Each item48 As ListViewItem In ListView57.Items
            For i = 0 To item48.SubItems.Count - 1
                sheet.Cells(72, i + 2) = item48.SubItems(i).Text
            Next
        Next

        sheet.Cells(73, 1) = "Takmicar3"
        For Each item49 As ListViewItem In ListView58.Items
            For i = 0 To item49.SubItems.Count - 1
                sheet.Cells(73, i + 2) = item49.SubItems(i).Text
            Next
        Next

        sheet.Cells(74, 1) = "Takmicar4"
        For Each item50 As ListViewItem In ListView59.Items
            For i = 0 To item50.SubItems.Count - 1
                sheet.Cells(74, i + 2) = item50.SubItems(i).Text
            Next
        Next

        sheet.Cells(75, 1) = "Takmicar5"
        For Each item51 As ListViewItem In ListView60.Items
            For i = 0 To item51.SubItems.Count - 1
                sheet.Cells(75, i + 2) = item51.SubItems(i).Text
            Next
        Next

        sheet.Cells(79, 1) = "ŽENE - 12 SATI"

        sheet.Cells(80, 1) = "Takmičar/Competitor"
        sheet.Cells(80, 2) = "Krug/Lap"
        sheet.Cells(80, 3) = "Sat"
        sheet.Cells(80, 4) = "Min"
        sheet.Cells(80, 5) = "Sek"

        sheet.Cells(81, 1) = "Anja Samardžija (61)"
        For Each item52 As ListViewItem In ListView47.Items
            For i = 0 To item52.SubItems.Count - 1
                sheet.Cells(81, i + 2) = item52.SubItems(i).Text
            Next
        Next

        sheet.Cells(82, 1) = "Ilaria Rossi (73)"
        For Each item53 As ListViewItem In ListView48.Items
            For i = 0 To item53.SubItems.Count - 1
                sheet.Cells(82, i + 2) = item53.SubItems(i).Text
            Next
        Next

        sheet.Cells(83, 1) = "Takmicarka1"
        For Each item54 As ListViewItem In ListView49.Items
            For i = 0 To item54.SubItems.Count - 1
                sheet.Cells(83, i + 2) = item54.SubItems(i).Text
            Next
        Next

        sheet.Cells(84, 1) = "Takmicarka2"
        For Each item55 As ListViewItem In ListView50.Items
            For i = 0 To item55.SubItems.Count - 1
                sheet.Cells(84, i + 2) = item55.SubItems(i).Text
            Next
        Next

        sheet.Cells(91, 1) = "ŽENE - 100 km"

        sheet.Cells(92, 1) = "Takmičar/Competitor"
        sheet.Cells(92, 2) = "Krug/Lap"
        sheet.Cells(92, 3) = "Sat"
        sheet.Cells(92, 4) = "Min"
        sheet.Cells(92, 5) = "Sek"

        sheet.Cells(93, 1) = "Takmicarka1"
        For Each item80 As ListViewItem In ListView51.Items
            For i = 0 To item80.SubItems.Count - 1
                sheet.Cells(93, i + 2) = item80.SubItems(i).Text
            Next
        Next

        sheet.Cells(102, 1) = "MUŠKARCI - 100 km"

        sheet.Cells(103, 1) = "Takmičar/Competitor"
        sheet.Cells(103, 2) = "Krug/Lap"
        sheet.Cells(103, 3) = "Sat"
        sheet.Cells(103, 4) = "Min"
        sheet.Cells(103, 5) = "Sek"

        sheet.Cells(104, 1) = "Pavle Klemenčič (8)"
        For Each item81 As ListViewItem In ListView52.Items
            For i = 0 To item81.SubItems.Count - 1
                sheet.Cells(104, i + 2) = item81.SubItems(i).Text
            Next
        Next

        sheet.Cells(105, 1) = "Jovica Spajić (22)"
        For Each item81 As ListViewItem In ListView54.Items
            For i = 0 To item81.SubItems.Count - 1
                sheet.Cells(105, i + 2) = item81.SubItems(i).Text
            Next
        Next

        sheet.Cells(106, 1) = "Matjaž Bukovec (1)"
        For Each item81 As ListViewItem In ListView55.Items
            For i = 0 To item81.SubItems.Count - 1
                sheet.Cells(106, i + 2) = item81.SubItems(i).Text
            Next
        Next

        sheet.Cells(107, 1) = "Dalibor Daničić (100)"
        For Each item82 As ListViewItem In ListView64.Items
            For i = 0 To item82.SubItems.Count - 1
                sheet.Cells(107, i + 2) = item82.SubItems(i).Text
            Next
        Next

        sheet.Cells(108, 1) = "Dejan Daničić (17)"
        For Each item83 As ListViewItem In ListView65.Items
            For i = 0 To item83.SubItems.Count - 1
                sheet.Cells(108, i + 2) = item83.SubItems(i).Text
            Next
        Next

        sheet.Cells(109, 1) = "Milan Nikolić (34)"
        For Each item84 As ListViewItem In ListView66.Items
            For i = 0 To item84.SubItems.Count - 1
                sheet.Cells(109, i + 2) = item84.SubItems(i).Text
            Next
        Next


        sheet.Cells(111, 1) = "Stafeta"

        sheet.Cells(112, 1) = "Takmičar/Competitor"
        sheet.Cells(112, 2) = "Krug/Lap"
        sheet.Cells(112, 3) = "Sat"
        sheet.Cells(112, 4) = "Min"
        sheet.Cells(112, 5) = "Sek"

        sheet.Cells(113, 1) = "BRZI (71)"
        For Each item84 As ListViewItem In ListView68.Items
            For i = 0 To item84.SubItems.Count - 1
                sheet.Cells(113, i + 2) = item84.SubItems(i).Text
            Next
        Next

        sheet.Cells(114, 1) = "ŽDRALOVI (72)"
        For Each item84 As ListViewItem In ListView69.Items
            For i = 0 To item84.SubItems.Count - 1
                sheet.Cells(114, i + 2) = item84.SubItems(i).Text
            Next
        Next

        sheet.Cells(115, 1) = "ZAKON (73)"
        For Each item84 As ListViewItem In ListView70.Items
            For i = 0 To item84.SubItems.Count - 1
                sheet.Cells(115, i + 2) = item84.SubItems(i).Text
            Next
        Next

        sheet.Cells(116, 1) = "PROFESIONALCI (74)"
        For Each item84 As ListViewItem In ListView71.Items
            For i = 0 To item84.SubItems.Count - 1
                sheet.Cells(116, i + 2) = item84.SubItems(i).Text
            Next
        Next

        'xls.ActiveWorkbook.Save()
        'xls.Workbooks.Close()

        'xls.ActiveWorkbook.Save()
        'xls.Workbooks.Close()
        xls.Quit()

    End Sub

    Private Sub ListView62_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView62.SelectedIndexChanged

    End Sub

    Private Sub Button70_Click(sender As System.Object, e As System.EventArgs) Handles Button70.Click
        Dim i70 As Integer
        For i70 = 0 To ListView63.Items.Count - 1
            ListView63.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView63.Items.Add(item70)

        ListView63.EnsureVisible(ListView63.Items.Count - 1)
        ListView63.Update()

        ListView63.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button71_Click(sender As System.Object, e As System.EventArgs) Handles Button71.Click
        Dim i64 As Integer
        For i64 = 0 To ListView64.Items.Count - 1
            ListView64.Items(i64).Text = i64 + 1.ToString

        Next

        Dim item64 As ListViewItem = New ListViewItem(i64 + 1.ToString)
        item64.SubItems.Add(Label4.Text)
        item64.SubItems.Add(Label1.Text)
        item64.SubItems.Add(Label2.Text)
        ListView64.Items.Add(item64)

        ListView64.EnsureVisible(ListView64.Items.Count - 1)
        ListView64.Update()

        ListView64.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button72_Click(sender As System.Object, e As System.EventArgs) Handles Button72.Click
        Dim i65 As Integer
        For i65 = 0 To ListView65.Items.Count - 1
            ListView65.Items(i65).Text = i65 + 1.ToString

        Next

        Dim item65 As ListViewItem = New ListViewItem(i65 + 1.ToString)
        item65.SubItems.Add(Label4.Text)
        item65.SubItems.Add(Label1.Text)
        item65.SubItems.Add(Label2.Text)
        ListView65.Items.Add(item65)

        ListView65.EnsureVisible(ListView65.Items.Count - 1)
        ListView65.Update()

        ListView65.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button73_Click(sender As System.Object, e As System.EventArgs) Handles Button73.Click
        Dim i66 As Integer
        For i66 = 0 To ListView66.Items.Count - 1
            ListView66.Items(i66).Text = i66 + 1.ToString

        Next

        Dim item66 As ListViewItem = New ListViewItem(i66 + 1.ToString)
        item66.SubItems.Add(Label4.Text)
        item66.SubItems.Add(Label1.Text)
        item66.SubItems.Add(Label2.Text)
        ListView66.Items.Add(item66)

        ListView66.EnsureVisible(ListView66.Items.Count - 1)
        ListView66.Update()

        ListView66.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button74_Click(sender As System.Object, e As System.EventArgs) Handles Button74.Click
        Dim i70 As Integer
        For i70 = 0 To ListView67.Items.Count - 1
            ListView67.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView67.Items.Add(item70)

        ListView67.EnsureVisible(ListView67.Items.Count - 1)
        ListView67.Update()

        ListView67.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView67_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView67.SelectedIndexChanged
        
    End Sub

    Private Sub Button75_Click(sender As System.Object, e As System.EventArgs) Handles Button75.Click
        Dim i66 As Integer
        For i66 = 0 To ListView68.Items.Count - 1
            ListView68.Items(i66).Text = i66 + 1.ToString

        Next

        Dim item66 As ListViewItem = New ListViewItem(i66 + 1.ToString)
        item66.SubItems.Add(Label4.Text)
        item66.SubItems.Add(Label1.Text)
        item66.SubItems.Add(Label2.Text)
        ListView68.Items.Add(item66)

        ListView68.EnsureVisible(ListView68.Items.Count - 1)
        ListView68.Update()

        ListView68.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button76_Click(sender As System.Object, e As System.EventArgs) Handles Button76.Click
        Dim i66 As Integer
        For i66 = 0 To ListView69.Items.Count - 1
            ListView69.Items(i66).Text = i66 + 1.ToString

        Next

        Dim item66 As ListViewItem = New ListViewItem(i66 + 1.ToString)
        item66.SubItems.Add(Label4.Text)
        item66.SubItems.Add(Label1.Text)
        item66.SubItems.Add(Label2.Text)
        ListView69.Items.Add(item66)

        ListView69.EnsureVisible(ListView69.Items.Count - 1)
        ListView69.Update()

        ListView69.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button77_Click(sender As System.Object, e As System.EventArgs) Handles Button77.Click
        Dim i66 As Integer
        For i66 = 0 To ListView70.Items.Count - 1
            ListView70.Items(i66).Text = i66 + 1.ToString

        Next

        Dim item66 As ListViewItem = New ListViewItem(i66 + 1.ToString)
        item66.SubItems.Add(Label4.Text)
        item66.SubItems.Add(Label1.Text)
        item66.SubItems.Add(Label2.Text)
        ListView70.Items.Add(item66)

        ListView70.EnsureVisible(ListView70.Items.Count - 1)
        ListView70.Update()

        ListView70.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button78_Click(sender As System.Object, e As System.EventArgs) Handles Button78.Click
        Dim i66 As Integer
        For i66 = 0 To ListView71.Items.Count - 1
            ListView71.Items(i66).Text = i66 + 1.ToString

        Next

        Dim item66 As ListViewItem = New ListViewItem(i66 + 1.ToString)
        item66.SubItems.Add(Label4.Text)
        item66.SubItems.Add(Label1.Text)
        item66.SubItems.Add(Label2.Text)
        ListView71.Items.Add(item66)

        ListView71.EnsureVisible(ListView71.Items.Count - 1)
        ListView71.Update()

        ListView71.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button79_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button80_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub ListView74_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView74.SelectedIndexChanged
        
    End Sub

    Private Sub Button81_Click(sender As System.Object, e As System.EventArgs) Handles Button81.Click
        Dim i70 As Integer
        For i70 = 0 To ListView74.Items.Count - 1
            ListView74.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView74.Items.Add(item70)

        ListView74.EnsureVisible(ListView74.Items.Count - 1)
        ListView74.Update()

        ListView74.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button82_Click(sender As System.Object, e As System.EventArgs) Handles Button82.Click
        Dim i70 As Integer
        For i70 = 0 To ListView75.Items.Count - 1
            ListView75.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView75.Items.Add(item70)

        ListView75.EnsureVisible(ListView75.Items.Count - 1)
        ListView75.Update()

        ListView75.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button83_Click(sender As System.Object, e As System.EventArgs) Handles Button83.Click
        Dim i70 As Integer
        For i70 = 0 To ListView76.Items.Count - 1
            ListView76.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView76.Items.Add(item70)

        ListView76.EnsureVisible(ListView76.Items.Count - 1)
        ListView76.Update()

        ListView76.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button84_Click(sender As System.Object, e As System.EventArgs) Handles Button84.Click
        Dim i70 As Integer
        For i70 = 0 To ListView77.Items.Count - 1
            ListView77.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView77.Items.Add(item70)

        ListView77.EnsureVisible(ListView77.Items.Count - 1)
        ListView77.Update()

        ListView77.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button85_Click(sender As System.Object, e As System.EventArgs) Handles Button85.Click
        Dim i70 As Integer
        For i70 = 0 To ListView78.Items.Count - 1
            ListView78.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView78.Items.Add(item70)

        ListView78.EnsureVisible(ListView78.Items.Count - 1)
        ListView78.Update()

        ListView78.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button86_Click(sender As System.Object, e As System.EventArgs) Handles Button86.Click
        Dim i70 As Integer
        For i70 = 0 To ListView79.Items.Count - 1
            ListView79.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView79.Items.Add(item70)

        ListView79.EnsureVisible(ListView79.Items.Count - 1)
        ListView79.Update()

        ListView79.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button87_Click(sender As System.Object, e As System.EventArgs) Handles Button87.Click
        Dim i70 As Integer
        For i70 = 0 To ListView80.Items.Count - 1
            ListView80.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView80.Items.Add(item70)

        ListView80.EnsureVisible(ListView80.Items.Count - 1)
        ListView80.Update()

        ListView80.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button88_Click(sender As System.Object, e As System.EventArgs) Handles Button88.Click
        Dim i70 As Integer
        For i70 = 0 To ListView81.Items.Count - 1
            ListView81.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView81.Items.Add(item70)

        ListView81.EnsureVisible(ListView81.Items.Count - 1)
        ListView81.Update()

        ListView81.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub Button89_Click(sender As System.Object, e As System.EventArgs) Handles Button89.Click
        Dim i70 As Integer
        For i70 = 0 To ListView82.Items.Count - 1
            ListView82.Items(i70).Text = i70 + 1.ToString

        Next

        Dim item70 As ListViewItem = New ListViewItem(i70 + 1.ToString)
        item70.SubItems.Add(Label4.Text)
        item70.SubItems.Add(Label1.Text)
        item70.SubItems.Add(Label2.Text)
        ListView82.Items.Add(item70)

        ListView82.EnsureVisible(ListView82.Items.Count - 1)
        ListView82.Update()

        ListView82.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub
End Class

