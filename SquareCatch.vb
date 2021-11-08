'*********************************************************************************************************************
' PROGRAMME	:	Catch The Square
'  
' OUTLINE	:	This program randomly generates different colored Squares and the user has to try to catch them.
' 
' PROGRAMMER:	Mian Rafay
'
'  DATE		:	October 28, 2019
' ********************************************************************************************************************
Public Class frm1
    Dim pics(24) As PictureBox
    Dim randomBox As New Random
    Dim randBox As Integer
    Dim random As New Random
    Dim rand As Integer
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        MsgBox("Try to Catch a Square!!!")
        pics = {pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pic21, pic22, pic23, pic24, pic25}
        randBox = randomBox.Next(1, 25)
        i = randBox - 1
        pics(i).Visible = True
        For a As Integer = 0 To pics.Length - 1
            rand = random.Next(1, 7)
            colors(pics(a), rand)
        Next
    End Sub
    Private Sub pic1_MouseHover(sender As Object, e As EventArgs) Handles pic1.MouseHover, pic2.MouseHover, pic3.MouseHover, pic4.MouseHover, pic5.MouseHover, pic6.MouseHover, pic7.MouseHover, pic8.MouseHover, pic9.MouseHover, pic10.MouseHover, pic11.MouseHover, pic12.MouseHover, pic13.MouseHover, pic14.MouseHover, pic15.MouseHover, pic16.MouseHover, pic17.MouseHover, pic18.MouseHover, pic19.MouseHover, pic20.MouseHover, pic21.MouseHover, pic22.MouseHover, pic23.MouseHover, pic24.MouseHover, pic25.MouseHover
        For i As Integer = 0 To pics.Length - 1
            pics(i).Visible = False
        Next
        randBox = randomBox.Next(1, 25)
        pics(randBox - 1).Visible = True
        For a As Integer = 0 To pics.Length - 1
            rand = random.Next(1, 7)
            colors(pics(a), rand)
        Next
    End Sub
    Private Sub colors(selected As PictureBox, nums As Integer)
        Select Case nums
            Case 1
                selected.BackColor = Color.Red
            Case 2
                selected.BackColor = Color.Yellow
            Case 3
                selected.BackColor = Color.Orange
            Case 4
                selected.BackColor = Color.Blue
            Case 5
                selected.BackColor = Color.Pink
            Case 6
                selected.BackColor = Color.White
        End Select
    End Sub
End Class
