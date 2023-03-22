

Imports System.IO

Public Class DetailsForm
    Public Property netprice As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'the color of the button for print reciept will be gray when form 2 loads up
        Dim B As Color

        B = Color.DimGray
        'Print reciept button will be disabled when form 2 loads up
        cmdprint.Enabled = False
        cmdprint.BackColor = B

    End Sub


    'functions to store variables, they will return the value of the variables which will be gotten from
    'the textboxes
    'we need to create a function for each variable because we will have to use each variable to be conditioned differently...

    Private Function Store1(name As String) As String
        name = nameinput.Text

        Return name

    End Function

    Private Function Store2(houseno As String) As String
        houseno = housenoinput.Text

        Return houseno

    End Function

    Private Function Store3(streetname As String) As String
        streetname = streetnameinput.Text

        Return streetname

    End Function
    Private Function Store4(town_city As String) As String
        town_city = towninput.Text

        Return town_city

    End Function
    Private Function Store5(postcode As String) As String
        postcode = postcodeinput.Text

        Return postcode

    End Function
    Private Function Store6(creditcardno As String) As String
        creditcardno = creditcardnoinput.Text

        Return creditcardno

    End Function



    'the button for doing the validation check
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles valcheck.Click
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label12.Text = ""
        Label13.Text = ""
        Label14.Text = ""

        'passing parameters 

        Dim name As String
        Dim houseno As String
        Dim streetname As String
        Dim town_city As String
        Dim postcode As String
        Dim creditcardno As String

        'decalring variables for calling the functions that store each of the details from the textboxes
        'var means variable

        Dim var1 As String
        Dim var2 As String
        Dim var3 As String
        Dim var4 As String
        Dim var5 As String
        Dim var6 As String





        'calling the functions now and giving them a variable to be stored in 

        var1 = Store1(name)
        var2 = Store2(houseno)
        var3 = Store3(streetname)
        var4 = Store4(town_city)
        var5 = Store5(postcode)
        var6 = Store6(creditcardno)

        'using those variables to do validation checks

        'here we are just validating to make sure no field is empty, if a field is empty, then a label next to the field will 
        'display a message

        If var1.Length = 0 Then
            Label9.Text = Label9.Text & "please enter your name"
        End If

        If var2.Length = 0 Then
            Label10.Text = Label10.Text & "please enter your house number"
        End If

        If var3.Length = 0 Then
            Label11.Text = Label11.Text & "please enter your streetname"
        End If

        If var4.Length = 0 Then
            Label12.Text = Label12.Text & "please enter your town or city"

        End If

        If var5.Length = 0 Then
            Label13.Text = Label13.Text & "please enter your postcode"


        End If

        If var6.Length = 0 Then
            Label14.Text = Label14.Text & "please enter credit card number"

        End If


        'length validation for the credit card number 

        If var6.Length <> 16 Then

            MsgBox("credit card number should be 16 digits and numeric")


        End If

        'this part is for making sure no spaces exist between credit card digits...

        If InStr(var6, " ") > 0 Then

            MsgBox("please enter credit card with no spaces in between")

        End If


        'length Validation for the postcode 
        'i have said less than 6 because the postcode field limit is only 7 characters so if a person enters less than 6 then this message 
        'will show up otherwise if it is six or 7 then this message ownt show up

        If var5.Length < 6 Then


            MsgBox("postcode should be 6 or 7 characters long and numeric")



        End If

        'length validation for the town name 

        If var4.Length > 25 Then

            MsgBox("please enter town name which is under 25 but atleast over 2 characters")

        End If

        If var4.Length < 2 Then

            MsgBox("please enter town name which is under 25 but atleast over 2 characters")

        End If



        'creating a label to display a command 

        'this label is invisible but becomes visible just on top of the print button once all data is correctly submitted...

        Label15.Text = ""


        ' this label will display the following after the following data validation check is true 


        If (var1.Length > 0) And (var2.Length > 0) And (var3.Length > 0) And (var4.Length > 2) And (var5.Length >= 6) And (var6.Length = 16) = True Then


            Label15.Text = Label15.Text & "Please press the button below to print your reciept"

        Else Label5.Text = ""


        End If


        'just changing the backcolor when it is enabled to make it look clear for the user to press it 
        Dim C As Color
        Dim b As Color


        b = Color.Black
        C = Color.Chartreuse
        'If the label displays a command to press the print recciept button, then print reciept button will be enabled else if theres no command then 
        'button will be disabled

        If Label15.Text = "Please press the button below to print your reciept" Then

            cmdprint.Enabled = True
            cmdprint.BackColor = C

        ElseIf Label15.Text = "" Then

            cmdprint.Enabled = False
            cmdprint.BackColor = b

        End If







    End Sub

    'coding for the button for printing the reciept now . 
    'It will take the name from the name field and display it on the reciept textfile
    'it will also take the total cost of the order (netprice) and display it on the text file..
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdprint.Click

        ' this part is for ensuring postcode is entered and is compulsory and reciept cant be printed without it.
        Dim postcode As String
        Dim var5 As String

        var5 = Store5(postcode)

        If var5.Length = 0 Then
            MsgBox("please enter postcode, it cannot be null")
        End If

        Dim mywriter As StreamWriter


        mywriter = File.CreateText("F:\Reciept.txt")
        mywriter.WriteLine("SPLENDID SOAPS")
        mywriter.WriteLine(DateString)
        mywriter.WriteLine("")
        mywriter.WriteLine("customer name: " & nameinput.Text)
        mywriter.WriteLine("Total cost of order: " & "$" & Optionsform.netprice.ToString())
        mywriter.WriteLine("Thank you very much for shopping with us")

        mywriter.Close()

        MsgBox("reciept created successfully, please access it on the cd drive F: named by reciept.txt")
        Exit Sub




    End Sub




    'this part if for telling the program to only accept numbers in the creditcard field 

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles creditcardnoinput.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True


            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub

    ' this part is also for telling the postcode field to accept numbers only.

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles postcodeinput.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True

            MessageBox.Show("This field will accept numbers only")

        End If
    End Sub


End Class