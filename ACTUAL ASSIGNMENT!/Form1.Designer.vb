<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Optionsform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Optionsform))
        Me.title = New System.Windows.Forms.Label()
        Me.guide = New System.Windows.Forms.Label()
        Me.guide2 = New System.Windows.Forms.Label()
        Me.shipcostselect = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.purchasebutton = New System.Windows.Forms.Button()
        Me.pricedisplay = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.soapslist = New System.Windows.Forms.GroupBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.quotedisplay = New System.Windows.Forms.Label()
        Me.shipcostselect.SuspendLayout()
        Me.soapslist.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.title.Location = New System.Drawing.Point(326, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(305, 36)
        Me.title.TabIndex = 0
        Me.title.Text = "SPLENDID SOAPS"
        '
        'guide
        '
        Me.guide.AutoSize = True
        Me.guide.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guide.Location = New System.Drawing.Point(12, 77)
        Me.guide.Name = "guide"
        Me.guide.Size = New System.Drawing.Size(426, 34)
        Me.guide.TabIndex = 1
        Me.guide.Text = "Please choose any soap(s) from the following list:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Also enter the quantity in th" &
    "e textbox"
        '
        'guide2
        '
        Me.guide2.AutoSize = True
        Me.guide2.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guide2.Location = New System.Drawing.Point(529, 77)
        Me.guide2.Name = "guide2"
        Me.guide2.Size = New System.Drawing.Size(289, 17)
        Me.guide2.TabIndex = 3
        Me.guide2.Text = "Please choose your shipping cost:"
        '
        'shipcostselect
        '
        Me.shipcostselect.BackColor = System.Drawing.Color.Aqua
        Me.shipcostselect.Controls.Add(Me.RadioButton2)
        Me.shipcostselect.Controls.Add(Me.RadioButton1)
        Me.shipcostselect.Font = New System.Drawing.Font("Stencil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shipcostselect.ForeColor = System.Drawing.Color.Maroon
        Me.shipcostselect.Location = New System.Drawing.Point(532, 114)
        Me.shipcostselect.Name = "shipcostselect"
        Me.shipcostselect.Size = New System.Drawing.Size(286, 96)
        Me.shipcostselect.TabIndex = 4
        Me.shipcostselect.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(18, 55)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(169, 22)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "NEXT DAY   ($12.00)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(160, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ECONOMY   ($4.00)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'purchasebutton
        '
        Me.purchasebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.purchasebutton.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasebutton.ForeColor = System.Drawing.Color.Purple
        Me.purchasebutton.Location = New System.Drawing.Point(544, 545)
        Me.purchasebutton.Name = "purchasebutton"
        Me.purchasebutton.Size = New System.Drawing.Size(203, 64)
        Me.purchasebutton.TabIndex = 5
        Me.purchasebutton.Text = "Purchase"
        Me.purchasebutton.UseVisualStyleBackColor = False
        '
        'pricedisplay
        '
        Me.pricedisplay.AutoSize = True
        Me.pricedisplay.BackColor = System.Drawing.Color.Aqua
        Me.pricedisplay.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricedisplay.ForeColor = System.Drawing.Color.Red
        Me.pricedisplay.Location = New System.Drawing.Point(502, 268)
        Me.pricedisplay.Name = "pricedisplay"
        Me.pricedisplay.Size = New System.Drawing.Size(292, 40)
        Me.pricedisplay.TabIndex = 6
        Me.pricedisplay.Text = "Total price for your choices" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " will be displayed here "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(16, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(197, 21)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Milk and honey   -    $8.00"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(16, 55)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(237, 21)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Almond and Oatmeal    -    $6.00"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(16, 87)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(241, 21)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Lavender and Oatmeal   -   $7.00"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(16, 121)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(196, 21)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "Cherry Blossom -    $5.00"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(16, 154)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(230, 21)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "Tea and lemongrass    -    $7.00"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(16, 187)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(172, 21)
        Me.CheckBox6.TabIndex = 5
        Me.CheckBox6.Text = "Poppy seed    -     $6.00"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(16, 223)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(153, 21)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "Aloe vera   -    $9.00"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(16, 257)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(291, 21)
        Me.CheckBox8.TabIndex = 7
        Me.CheckBox8.Text = "Cinnnamon and cocoa butter  -  $ 9.00"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(16, 290)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(227, 21)
        Me.CheckBox9.TabIndex = 8
        Me.CheckBox9.Text = "Lemon shea butter   -    $10.00"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(16, 324)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(176, 21)
        Me.CheckBox10.TabIndex = 9
        Me.CheckBox10.Text = "Wildflower   -    $5.00"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(16, 360)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(168, 21)
        Me.CheckBox11.TabIndex = 10
        Me.CheckBox11.Text = "Lemon balm   -    $7.00"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(16, 397)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(276, 21)
        Me.CheckBox12.TabIndex = 11
        Me.CheckBox12.Text = "Rosemary and peppermint    -    $6.00"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Location = New System.Drawing.Point(16, 431)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(248, 21)
        Me.CheckBox13.TabIndex = 12
        Me.CheckBox13.Text = "Lemongrass and ginger   -   $6.00"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(16, 466)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(220, 21)
        Me.CheckBox14.TabIndex = 13
        Me.CheckBox14.Text = "Orange and vanilla   -   $7.00"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'soapslist
        '
        Me.soapslist.BackColor = System.Drawing.Color.Aqua
        Me.soapslist.Controls.Add(Me.TextBox14)
        Me.soapslist.Controls.Add(Me.TextBox13)
        Me.soapslist.Controls.Add(Me.TextBox12)
        Me.soapslist.Controls.Add(Me.TextBox11)
        Me.soapslist.Controls.Add(Me.TextBox10)
        Me.soapslist.Controls.Add(Me.TextBox9)
        Me.soapslist.Controls.Add(Me.TextBox8)
        Me.soapslist.Controls.Add(Me.TextBox7)
        Me.soapslist.Controls.Add(Me.TextBox6)
        Me.soapslist.Controls.Add(Me.TextBox5)
        Me.soapslist.Controls.Add(Me.TextBox4)
        Me.soapslist.Controls.Add(Me.TextBox3)
        Me.soapslist.Controls.Add(Me.TextBox2)
        Me.soapslist.Controls.Add(Me.TextBox1)
        Me.soapslist.Controls.Add(Me.CheckBox14)
        Me.soapslist.Controls.Add(Me.CheckBox13)
        Me.soapslist.Controls.Add(Me.CheckBox12)
        Me.soapslist.Controls.Add(Me.CheckBox11)
        Me.soapslist.Controls.Add(Me.CheckBox10)
        Me.soapslist.Controls.Add(Me.CheckBox9)
        Me.soapslist.Controls.Add(Me.CheckBox8)
        Me.soapslist.Controls.Add(Me.CheckBox7)
        Me.soapslist.Controls.Add(Me.CheckBox6)
        Me.soapslist.Controls.Add(Me.CheckBox5)
        Me.soapslist.Controls.Add(Me.CheckBox4)
        Me.soapslist.Controls.Add(Me.CheckBox3)
        Me.soapslist.Controls.Add(Me.CheckBox2)
        Me.soapslist.Controls.Add(Me.CheckBox1)
        Me.soapslist.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.soapslist.ForeColor = System.Drawing.Color.Maroon
        Me.soapslist.Location = New System.Drawing.Point(15, 114)
        Me.soapslist.Name = "soapslist"
        Me.soapslist.Size = New System.Drawing.Size(476, 506)
        Me.soapslist.TabIndex = 2
        Me.soapslist.TabStop = False
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(306, 466)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(127, 24)
        Me.TextBox14.TabIndex = 27
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(306, 431)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(127, 24)
        Me.TextBox13.TabIndex = 26
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(306, 397)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(127, 24)
        Me.TextBox12.TabIndex = 25
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(306, 360)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(127, 24)
        Me.TextBox11.TabIndex = 24
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(306, 324)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(127, 24)
        Me.TextBox10.TabIndex = 23
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(306, 290)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(127, 24)
        Me.TextBox9.TabIndex = 22
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(306, 257)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(127, 24)
        Me.TextBox8.TabIndex = 21
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(306, 223)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(127, 24)
        Me.TextBox7.TabIndex = 20
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(306, 187)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(127, 24)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(306, 154)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(127, 24)
        Me.TextBox5.TabIndex = 18
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(306, 121)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(127, 24)
        Me.TextBox4.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(306, 87)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 24)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(306, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 24)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(306, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 24)
        Me.TextBox1.TabIndex = 14
        '
        'quotedisplay
        '
        Me.quotedisplay.AutoSize = True
        Me.quotedisplay.BackColor = System.Drawing.Color.Aqua
        Me.quotedisplay.Font = New System.Drawing.Font("MV Boli", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quotedisplay.ForeColor = System.Drawing.Color.Black
        Me.quotedisplay.Location = New System.Drawing.Point(502, 370)
        Me.quotedisplay.Name = "quotedisplay"
        Me.quotedisplay.Size = New System.Drawing.Size(194, 40)
        Me.quotedisplay.TabIndex = 7
        Me.quotedisplay.Text = "Inspirational quote" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " will be displayed here "
        '
        'Optionsform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(923, 699)
        Me.Controls.Add(Me.quotedisplay)
        Me.Controls.Add(Me.pricedisplay)
        Me.Controls.Add(Me.purchasebutton)
        Me.Controls.Add(Me.shipcostselect)
        Me.Controls.Add(Me.guide2)
        Me.Controls.Add(Me.soapslist)
        Me.Controls.Add(Me.guide)
        Me.Controls.Add(Me.title)
        Me.Name = "Optionsform"
        Me.shipcostselect.ResumeLayout(False)
        Me.shipcostselect.PerformLayout()
        Me.soapslist.ResumeLayout(False)
        Me.soapslist.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents guide As Label
    Friend WithEvents guide2 As Label
    Friend WithEvents shipcostselect As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents purchasebutton As Button
    Friend WithEvents pricedisplay As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents soapslist As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents quotedisplay As Label
End Class
