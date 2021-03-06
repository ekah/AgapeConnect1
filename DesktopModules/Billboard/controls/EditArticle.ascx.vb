﻿Imports DotNetNuke
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Math
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Net.Mail
Imports System.Collections.Specialized
Imports System.Linq
Imports Billboard
Imports System.Drawing.Image
Imports System.Drawing

Partial Class DesktopModules_Billboard_controls_EditArticle
    Inherits System.Web.UI.UserControl
    Private ThisUserId As Integer
    Private ThisArt As Integer


    Protected Sub btnSaveButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSaveButton.Click

        'Check for Errors
        Dim NoErrors As Boolean = True
        If String.IsNullOrEmpty(tbHeadline.Text) Then
            lblErrorLabelHeadline.Visible = True
            lblErrorStarHeadline.Visible = True
            NoErrors = False
        Else
            lblErrorLabelHeadline.Visible = False
            lblErrorStarHeadline.Visible = False
        End If
        If String.IsNullOrEmpty(tbStoryText.RichText.Text) Then
            lblErrorLabelStoryText.Visible = True
            lblErrorStarStoryText.Visible = True
            NoErrors = False
        Else
            lblErrorLabelStoryText.Visible = False
            lblErrorStarStoryText.Visible = False
        End If

        'If no errors, save the file
        If NoErrors Then
            Dim IsCurrent As Boolean = False
            Dim d As New Billboard.BillboardDataContext
            If CInt(hfArtId.Value) = -1 Then
                UpdateFile(False)
            Else
                Dim r = From c In d.Agape_Billboard_Articles Where c.BillbaordArticleId = CInt(hfArtId.Value)
                If r.Count > 0 Then
                    UpdateFile(True)
                End If
            End If
        End If

    End Sub
    Private Sub UpdateFile(ByVal Previous As Boolean)
        If Previous Then
            'Previously written article
            Try
                Dim d As New Billboard.BillboardDataContext
                Dim q = From c In d.Agape_Billboard_Articles Where c.BillbaordArticleId = CInt(hfArtId.Value)
                Dim s = From c In d.Agape_Billboard_TempPhotos Where c.UserId = CInt(hfUserId.Value)
                If q.Count > 0 Then
                    'Save the story
                    If Not (s.Count > 0 And icImageCropper1.CroppedImage Is Nothing) Then
                        Dim ThisVisible As Boolean = q.First.Visible
                        Dim ThisCurrent As Boolean = q.First.Current
                        Dim ThisSent As Boolean = q.First.Sent

                        q.First.Visible = cbVisibleCheck.Checked
                        q.First.AuthorName = tbAuthor.Text
                        q.First.Headline = tbHeadline.Text
                        q.First.StoryText = tbStoryText.RichText.Text
                        If cbVisibleCheck.Checked Then
                            q.First.StoryDate = CDate(Now())
                        End If

                        If s.Count > 0 And Not icImageCropper1.CroppedImage Is Nothing Then
                            Dim r = From c In d.Agape_Billboard_TempPhotos Select c.TempPhotoData, c.UserId Where UserId = CInt(hfUserId.Value)
                            Dim img As Byte() = r.First.TempPhotoData.ToArray
                            Dim X As Integer = icImageCropper1.CroppingRect.X
                            Dim Y As Integer = icImageCropper1.CroppingRect.Y
                            Dim IWidth As Integer = icImageCropper1.CroppingRect.Width
                            Dim IHeight As Integer = icImageCropper1.CroppingRect.Height
                            Dim ImageBytes As Byte() = Billboard.BillboardFunctions.CropImageFromCropper(img, X, Y, IWidth, IHeight)

                            Dim t = From c In d.Agape_Billboard_Photos Where c.BillboardPhotoId = q.First.BillboardPhotoId Select c
                            If t.Count > 0 Then
                                t.First.PhotoData = ImageBytes
                            End If
                        End If

                        'Current Rules
                        If cbVisibleCheck.Checked And ThisSent = False Then
                            q.First.Current = True
                        Else
                            q.First.Current = False
                        End If
                        d.SubmitChanges()
                        'CHANGE OVER TO VIEW MODE
                        OnEvent(New TheseEditArtEventArgs(q.First.BillbaordArticleId))

                    Else
                        'No Photo
                        lblSaving.Text = "You need to insert a photo to be cropped and crop it."
                        lblSaving.Visible = True
                        lblErrorPhoto.Text = "You need to insert a photo to be cropped and crop it."
                        lblErrorPhoto.Visible = True
                    End If
                Else
                    'Problem loading the previous story
                    lblSaving.Text = "There was a problem saving the article."
                    lblSaving.Visible = False
                End If
            Catch ex As Exception
                lblSaving.Text = ex.Message
                lblSaving.Visible = True
            End Try

        Else
            'Previously unwritten article
            Try
                Dim d As New Billboard.BillboardDataContext
                Dim insertArticle As New Billboard.Agape_Billboard_Article

                'Save the story
                If Not icImageCropper1.CroppedImage Is Nothing Then
                    insertArticle.Headline = tbHeadline.Text
                    insertArticle.StoryText = tbStoryText.RichText.Text
                    insertArticle.StoryDate = CDate(Now())
                    insertArticle.Author = CInt(hfUserId.Value)
                    insertArticle.AuthorName = tbAuthor.Text
                    insertArticle.Visible = cbVisibleCheck.Checked
                    insertArticle.Sent = False
                    If cbVisibleCheck.Checked Then
                        insertArticle.Current = True
                    Else
                        insertArticle.Current = False
                    End If

                    Dim r = From c In d.Agape_Billboard_TempPhotos Select c.TempPhotoData, c.UserId Where UserId = CInt(hfUserId.Value)
                    Dim img As Byte() = r.First.TempPhotoData.ToArray
                    Dim X As Integer = icImageCropper1.CroppingRect.X
                    Dim Y As Integer = icImageCropper1.CroppingRect.Y
                    Dim IWidth As Integer = icImageCropper1.CroppingRect.Width
                    Dim IHeight As Integer = icImageCropper1.CroppingRect.Height
                    Dim ImageBytes As Byte() = Billboard.BillboardFunctions.CropImageFromCropper(img, X, Y, IWidth, IHeight)
                    Dim insertPhoto As New Billboard.Agape_Billboard_Photo
                    insertPhoto.PhotoData = ImageBytes
                    d.Agape_Billboard_Photos.InsertOnSubmit(insertPhoto)
                    d.SubmitChanges()

                    insertArticle.BillboardPhotoId = insertPhoto.BillboardPhotoId
                    d.Agape_Billboard_Articles.InsertOnSubmit(insertArticle)
                    d.SubmitChanges()

                    'CHANGE OVER TO VIEW MODE
                    OnEvent(New TheseEditArtEventArgs(insertArticle.BillbaordArticleId))
                Else
                    'No Photo
                    lblSaving.Text = "You need to insert a photo to be cropped and crop it."
                    lblSaving.Visible = True
                    lblErrorPhoto.Text = "You need to insert a photo to be cropped and crop it."
                    lblErrorPhoto.Visible = True
                End If

            Catch ex As Exception
                lblSaving.Text = ex.Message
                lblSaving.Visible = True
            End Try

        End If

    End Sub
    Protected Sub btnPhoto1Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPhoto1Button.Click

        If fuFileUpload2.HasFile Then
            Dim fileExtension As String
            Dim SelectFile, thumbnail As System.Drawing.Image
            Dim FileOK As Boolean = False
            fileExtension = System.IO.Path.GetExtension(fuFileUpload2.FileName).ToLower()
            Dim allowedExtensions As String() = {".jpg", ".gif", ".png", "jpeg"}
            For i As Integer = 0 To allowedExtensions.Length - 1
                If fileExtension = allowedExtensions(i) Then
                    FileOK = True
                End If
            Next

            If FileOK Then
                Try
                    SelectFile = System.Drawing.Image.FromStream(fuFileUpload2.PostedFile.InputStream)
                    thumbnail = ResizeImage(SelectFile, 400)
                    Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
                    Dim ImageBytes As Byte()
                    Using (ms)
                        thumbnail.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        ImageBytes = ms.ToArray()
                    End Using

                    Dim d As New Billboard.BillboardDataContext
                    Dim insertTempPhoto As New Billboard.Agape_Billboard_TempPhoto
                    insertTempPhoto.UserId = hfUserId.Value
                    insertTempPhoto.TempPhotoData = ImageBytes
                    d.Agape_Billboard_TempPhotos.InsertOnSubmit(insertTempPhoto)
                    d.SubmitChanges()
                    icImageCropper1.ImageUrl = "/DesktopModules/Billboard/GetTempBillboardImage.aspx?UserId=" & hfUserId.Value & "&Size=200&Mode=2"
                    lblErrorPhoto.Text = "FileUploaded!"
                    lblErrorPhoto.Visible = True
                Catch ex As Exception
                    lblErrorPhoto.Text = "File could not be uploaded: " & ex.Message
                    lblErrorPhoto.Visible = True
                End Try
            Else
                lblErrorPhoto.Text = "Invalid file. Please select a jpg, jpeg, gif or png file."
                lblErrorPhoto.Visible = True
            End If
        Else
            lblErrorPhoto.Text = "Couldn't get file."
            lblErrorPhoto.Visible = True
        End If

        Dim t As Type = btnPhoto1Button.GetType()
        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
        sb.Append("<script language='javascript'>")
        sb.Append("closeLink();")
        sb.Append("showEditArt();")
        sb.Append("</script>")
        ScriptManager.RegisterStartupScript(btnPhoto1Button, t, "popupAdd1", sb.ToString, False)

    End Sub
    Protected Sub btnCancelButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelButton.Click
        Dim d As New Billboard.BillboardDataContext
        Dim q = From c In d.Agape_Billboard_TempPhotos Where c.UserId = CInt(hfUserId.Value)
        For Each photo In q
            d.Agape_Billboard_TempPhotos.DeleteOnSubmit(photo)
        Next
        d.SubmitChanges()

        'redirect to archive
        OnEvent(New TheseEditArtEventArgs(-3))

    End Sub
    Private Function ResizeImage(ByVal mg As Image, ByVal newSize As Integer) As Image

        Dim ratio As Double = 0D
        Dim myThumbWidth As Double = 0D
        Dim myThumbHeight As Double = 0D
        Dim bp As Bitmap

        ratio = mg.Width / mg.Height
        myThumbWidth = newSize
        myThumbHeight = newSize / ratio

        Dim thumbSize As Size = New Size(CInt(myThumbWidth), CInt(myThumbHeight))
        bp = New Bitmap(CInt(myThumbWidth), CInt(myThumbHeight))

        Dim g As Graphics = Graphics.FromImage(bp)
        g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        Dim rect As Rectangle = New Rectangle(0, 0, thumbSize.Width, thumbSize.Height)
        g.DrawImage(mg, rect, 0, 0, mg.Width, mg.Height, GraphicsUnit.Pixel)

        Return bp

    End Function
    Protected Sub DeleteButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDeleteButton.Click

        Dim d As New Billboard.BillboardDataContext
        Dim r = From c In d.Agape_Billboard_TempPhotos Where c.UserId = CInt(hfUserId.Value)
        For Each photo In r
            d.Agape_Billboard_TempPhotos.DeleteOnSubmit(photo)
        Next

        If Not CInt(hfArtId.Value) = -1 Then
            Dim q = From c In d.Agape_Billboard_Articles Where c.BillbaordArticleId = CInt(hfArtId.Value)
            If q.Count > 0 Then
                d.Agape_Billboard_Articles.DeleteAllOnSubmit(q)
                d.SubmitChanges()
            End If
        End If

        'redirect to archive
        OnEvent(New TheseEditArtEventArgs(-2))

    End Sub
    Public Sub Initialise(ByVal MyUserId As Integer, ByVal Mode As Integer, Optional ByVal ArtId As Integer = -1)
        ThisUserId = MyUserId
        hfUserId.Value = MyUserId
        hfMode.Value = Mode
        Dim d As New Billboard.BillboardDataContext
        Dim q = From c In d.Agape_Billboard_TempPhotos Where c.UserId = ThisUserId
        For Each photo In q
            d.Agape_Billboard_TempPhotos.DeleteOnSubmit(photo)
        Next
        d.SubmitChanges()

        If Not ArtId = -1 Then
            Dim r = From c In d.Agape_Billboard_Articles Where 1 = 0
            If Mode = 1 Then
                r = From c In d.Agape_Billboard_Articles Where c.BillbaordArticleId = ArtId Select c
                If r.First.AuthorName = "" Or r.First.AuthorName Is Nothing Then
                    Dim s = From c In d.Users Where c.UserID = r.First.Author
                    If s.Count > 0 Then
                        tbAuthor.Text = s.First.DisplayName
                    End If
                Else
                    tbAuthor.Text = r.First.AuthorName
                End If
            ElseIf Mode = 2 Then
                r = From c In d.Agape_Billboard_Articles Where c.BillbaordArticleId = ArtId And c.Author = MyUserId Select c
                If r.First.AuthorName = "" Or r.First.AuthorName Is Nothing Then
                    Dim s = From c In d.Users Where c.UserID = r.First.Author
                    If s.Count > 0 Then
                        tbAuthor.Text = s.First.DisplayName
                    End If
                Else
                    tbAuthor.Text = r.First.AuthorName
                End If
            End If
            If r.Count > 0 Then
                tbHeadline.Text = r.First.Headline
                tbStoryText.Text = r.First.StoryText
                cbVisibleCheck.Checked = r.First.Visible
                icImageCropper1.ImageUrl = "/DesktopModules/Billboard/GetTempBillboardImage.aspx?UserId=" & ThisUserId & "&Size=200&Mode=1&PhotoId=" & r.First.Agape_Billboard_Photo.BillboardPhotoId
            Else
                If Mode = 1 Then
                    lblErrorUpload.Text = "There was no Article found for the following ID: " & ArtId
                ElseIf Mode = 2 Then
                    lblErrorUpload.Text = "You are not authorised to edit this article."
                End If
                lblErrorUpload.Visible = True
                pnlContent.Visible = False
            End If
            ThisArt = ArtId
            hfArtId.Value = ArtId
        Else
            tbHeadline.Text = ""
            tbStoryText.RichText.Text = ""
            Dim t = From c In d.Users Where c.UserID = MyUserId Select c
            If t.Count = 1 Then
                tbAuthor.Text = t.First.DisplayName
            End If
            cbVisibleCheck.Checked = True
            icImageCropper1.ImageUrl = "/DesktopModules/Billboard/GetBillboardImage.aspx?Size=200"
            lblErrorPhoto.Visible = False
            lblErrorUpload.Visible = False
            hfArtId.Value = -1
            btnDeleteButton.Visible = False
            btnDeleteButton.Enabled = False
        End If
        If ThisUserId = -1 Then
            pnlContent.Visible = False
            lblErrorUpload.Text = "This control has not been loaded correctly."
            lblErrorUpload.Visible = True
        Else
            pnlContent.Visible = True
        End If
    End Sub
    Public Delegate Sub MyEventHandler(ByVal sender As Object, ByVal e As TheseEditArtEventArgs)
    Public Event MyEvent As MyEventHandler
    Protected Overridable Sub OnEvent(ByVal e As TheseEditArtEventArgs)
        RaiseEvent MyEvent(Me, e)
    End Sub
End Class
Public Class TheseEditArtEventArgs
    Inherits EventArgs
    Private ReadOnly DoSomething As Integer
    Public Sub New(ByVal Switch As Integer)
        Me.DoSomething = Switch
    End Sub
    Public ReadOnly Property Switch() As Integer
        Get
            Return DoSomething
        End Get
    End Property
End Class



