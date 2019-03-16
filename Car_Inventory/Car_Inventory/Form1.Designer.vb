<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbYears = New System.Windows.Forms.ComboBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.carInventoryTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(110, 40)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(156, 22)
        Me.txtModel.TabIndex = 3
        Me.carInventoryTips.SetToolTip(Me.txtModel, "Type the model of the car here.")
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(25, 13)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(56, 17)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(25, 42)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(56, 17)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Mercedes-Benz", "BMW", "Hyundai", "Honda", "Volkswagen", "Audi"})
        Me.cmbMake.Location = New System.Drawing.Point(110, 10)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(156, 24)
        Me.cmbMake.TabIndex = 1
        Me.carInventoryTips.SetToolTip(Me.cmbMake, "Select the car's make")
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(25, 71)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(56, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYears
        '
        Me.cmbYears.FormattingEnabled = True
        Me.cmbYears.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYears.Location = New System.Drawing.Point(111, 68)
        Me.cmbYears.Name = "cmbYears"
        Me.cmbYears.Size = New System.Drawing.Size(156, 24)
        Me.cmbYears.TabIndex = 5
        Me.carInventoryTips.SetToolTip(Me.cmbYears, "Select the year for car")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(25, 100)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(56, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(111, 98)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(156, 22)
        Me.txtPrice.TabIndex = 7
        Me.carInventoryTips.SetToolTip(Me.txtPrice, "Type the price of the car here." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'lvwCars
        '
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.Location = New System.Drawing.Point(13, 163)
        Me.lvwCars.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(452, 273)
        Me.lvwCars.TabIndex = 10
        Me.carInventoryTips.SetToolTip(Me.lvwCars, "Select a car to modify.")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 40
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 30
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 80
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 50
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(13, 440)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(452, 133)
        Me.lblResult.TabIndex = 11
        Me.carInventoryTips.SetToolTip(Me.lblResult, "Success or Error message will appear here.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(183, 590)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(84, 31)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.carInventoryTips.SetToolTip(Me.btnEnter, "Click to add a car.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(282, 590)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 31)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.carInventoryTips.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(381, 590)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 31)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.carInventoryTips.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(28, 127)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(99, 30)
        Me.chkNew.TabIndex = 15
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.carInventoryTips.SetToolTip(Me.chkNew, "Check to make the car a new car.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(473, 629)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.cmbYears)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.txtModel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtModel As TextBox
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYears As ComboBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblResult As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents carInventoryTips As ToolTip
    Friend WithEvents chkNew As CheckBox
End Class
