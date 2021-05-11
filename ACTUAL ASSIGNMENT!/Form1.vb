Imports System.IO

'this above must be imported into the program before  special code systems will be recognised 
Public Class Optionsform
    Public netprice As Double
    Dim totalprice As Double


    ' the function below is for for checking if quote file exists....

    Private Function Quotefilecheck(check As Boolean) As Boolean


        check = File.Exists("F:\quote.txt")
        If check Then

            Return True
        Else

            Return False

        End If

    End Function


    'the following will occur when form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' this part will defaultly set the quantity value in the textbox to be 1 when form loads
        TextBox1.Text = 1
        TextBox2.Text = 1
        TextBox3.Text = 1
        TextBox4.Text = 1
        TextBox5.Text = 1
        TextBox6.Text = 1
        TextBox7.Text = 1
        TextBox8.Text = 1
        TextBox9.Text = 1
        TextBox10.Text = 1
        TextBox11.Text = 1
        TextBox12.Text = 1
        TextBox13.Text = 1
        TextBox14.Text = 1




        Dim myreader As StreamReader

        Dim check As Boolean
        Dim quote As String
        'calling the quote function
        quote = Quotefilecheck(check)

        'if quotes file exists then quote will be displayed on a label when form loads, else error message will be displayed

        If quote = True Then

            myreader = File.OpenText("F:\quote.txt")
            quotedisplay.Text = myreader.ReadLine
            myreader.Close()

        ElseIf quote = False Then

            MessageBox.Show("no such file found for the quote")

        End If

        RadioButton1.Checked = CheckState.Checked

        ' this part above will cause the ECONOMY shipping option to be defaultly selected when form loads..

    End Sub



    'this purchase button subroutine will now check conditions for certain criterias.....
    Private Sub cmdpurchase_Click(sender As Object, e As EventArgs) Handles purchasebutton.Click



        Dim shipcost As Double
        'declaring data types for essential variables to calculate the price for the customers purchase

        Dim prices(5) As Double
        Dim soapnames(13) As String


        'this variable is for the quantities values gotten from the textboxes
        Dim quantities(13) As Integer


        'although this label for displaying price is not necessary, it is still essential for us to know our total..
        pricedisplay.Text = ""



        'storing the quantity values in an array 

        quantities(0) = TextBox1.Text
        quantities(1) = TextBox2.Text
        quantities(2) = TextBox3.Text
        quantities(3) = TextBox4.Text
        quantities(4) = TextBox5.Text
        quantities(5) = TextBox6.Text
        quantities(6) = TextBox7.Text
        quantities(7) = TextBox8.Text
        quantities(8) = TextBox9.Text
        quantities(9) = TextBox10.Text
        quantities(10) = TextBox11.Text
        quantities(11) = TextBox12.Text
        quantities(12) = TextBox13.Text
        quantities(13) = TextBox14.Text


        'storing prices in an array. note: there is a range of prices from 5$ to 10$ 

        prices(0) = 5.0
        prices(1) = 6.0
        prices(2) = 7.0
        prices(3) = 8.0
        prices(4) = 9.0
        prices(5) = 10.0

        'total price set to 0 as a starting value

        totalprice = 0.0


        'storing names of the soaps in an array


        soapnames(0) = CheckBox1.Text
        soapnames(1) = CheckBox2.Text
        soapnames(2) = CheckBox3.Text
        soapnames(3) = CheckBox4.Text
        soapnames(4) = CheckBox5.Text
        soapnames(5) = CheckBox6.Text
        soapnames(6) = CheckBox7.Text
        soapnames(7) = CheckBox8.Text
        soapnames(8) = CheckBox9.Text
        soapnames(9) = CheckBox10.Text
        soapnames(10) = CheckBox11.Text
        soapnames(11) = CheckBox12.Text
        soapnames(12) = CheckBox13.Text
        soapnames(13) = CheckBox14.Text






        'setting shipping cost values

        If RadioButton1.Checked = True Then

            shipcost = 4.0

        ElseIf RadioButton2.Checked = True Then

            shipcost = 12.0
        End If

        'coding for prices for the soaps 

        'each check box requires a new if statement because they are mutually exclusive..

        ' the price will be multiplied with the quantity entered in textbox for that specific checkbox with that specific price

        'total price will now be a running total...
        If CheckBox1.Checked = True Then

            totalprice = totalprice + (prices(3) * quantities(0))


        End If


        If CheckBox2.Checked = True Then

            totalprice = totalprice + (prices(1) * quantities(1))


        End If


        If CheckBox3.Checked = True Then

            totalprice = totalprice + (prices(2) * quantities(2))

        End If



        If CheckBox4.Checked = True Then

            totalprice = totalprice + (prices(0) * quantities(3))

        End If



        If CheckBox5.Checked = True Then

            totalprice = totalprice + (prices(2) * quantities(4))

        End If




        If CheckBox6.Checked = True Then

            totalprice = totalprice + (prices(1) * quantities(5))

        End If


        If CheckBox7.Checked = True Then

            totalprice = totalprice + (prices(4) * quantities(6))

        End If


        If CheckBox8.Checked = True Then

            totalprice = totalprice + (prices(4) * quantities(7))

        End If


        If CheckBox9.Checked = True Then

            totalprice = totalprice + (prices(5) * quantities(8))

        End If


        If CheckBox10.Checked = True Then

            totalprice = totalprice + (prices(0) * quantities(9))


        End If


        If CheckBox11.Checked = True Then

            totalprice = totalprice + (prices(2) * quantities(10))

        End If


        If CheckBox12.Checked = True Then

            totalprice = totalprice + (prices(1) * quantities(11))

        End If


        If CheckBox13.Checked = True Then

            totalprice = totalprice + (prices(1) * quantities(12))

        End If


        If CheckBox14.Checked = True Then

            totalprice = totalprice + (prices(2) * quantities(13))

        End If




        'introducing the new variable "net price" will help us proceed smoothly with the other "if" condidtions...
        netprice = shipcost + totalprice











        'conditioning if statements to check if prices meet a ceratin value or above to carry out certain functions


        'this if statement will just reset the price on the label to 0 if the price of the soaps is less than 10
        If totalprice < 10 Then

            netprice = 0

        End If



        'this if statement displays a messagebox if totalprice is less than 10$ which 
        If totalprice >= 10 Then


            DetailsForm.Show()

        ElseIf totalprice < 10 Then

            MsgBox("please buy for more than 10$")

        End If


        'this if statement will give 10% discount if netprice is above 100$.

        'this if statement has to be carried out first before the 50 threshold because the discount should be calculated on the total price price

        If netprice >= 100 Then


            netprice = netprice - (netprice * 0.1)

        End If

        'this if statement will subtract shipcost if netprice is greater than or equal to 50$.

        If netprice >= 50 Then

            netprice = netprice - shipcost

        End If

        'the label will display the final(netprice) after carrying out all these conditions and calculations
        'just introduced it to see if we are on the right track...
        pricedisplay.Text = pricedisplay.Text & "Price: " & "$" & netprice


        Dim OBJ As New DetailsForm
        OBJ.netprice = netprice


    End Sub

    Private Sub soapslist_Enter(sender As Object, e As EventArgs) Handles soapslist.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles shipcostselect.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub quotedisplay_Click(sender As Object, e As EventArgs) Handles quotedisplay.Click

    End Sub
End Class
