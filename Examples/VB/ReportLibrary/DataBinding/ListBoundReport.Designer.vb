
Imports Telerik.Reporting

Partial Class ListBoundReport

#Region "Component Designer generated code"
    ''' <summary>
    ''' Required method for Telerik Reporting designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule3 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule4 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule5 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.reportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.textBox5 = New Telerik.Reporting.TextBox()
        Me.textBox6 = New Telerik.Reporting.TextBox()
        Me.shape5 = New Telerik.Reporting.Shape()
        Me.list1 = New Telerik.Reporting.List()
        Me.panel1 = New Telerik.Reporting.Panel()
        Me.panel2 = New Telerik.Reporting.Panel()
        Me.txtModel = New Telerik.Reporting.TextBox()
        Me.textBox1 = New Telerik.Reporting.TextBox()
        Me.txtProductNameLabel = New Telerik.Reporting.TextBox()
        Me.txtYearLabel = New Telerik.Reporting.TextBox()
        Me.txtManufacturer = New Telerik.Reporting.TextBox()
        Me.txtYear = New Telerik.Reporting.TextBox()
        Me.panelColorsInStock = New Telerik.Reporting.Panel()
        Me.shape1 = New Telerik.Reporting.Shape()
        Me.shape2 = New Telerik.Reporting.Shape()
        Me.shape3 = New Telerik.Reporting.Shape()
        Me.shape4 = New Telerik.Reporting.Shape()
        Me.txtColorsInStock = New Telerik.Reporting.TextBox()
        Me.pictureBox1 = New Telerik.Reporting.PictureBox()
        Me.objectDataSource1 = New Telerik.Reporting.ObjectDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1.9R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.list1})
        Me.detail.Name = "detail"
        '
        'reportHeaderSection1
        '
        Me.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.2R)
        Me.reportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.textBox5, Me.textBox6, Me.shape5})
        Me.reportHeaderSection1.Name = "reportHeaderSection1"
        '
        'textBox5
        '
        Me.textBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.textBox5.Style.BorderColor.Default = System.Drawing.Color.Black
        Me.textBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(34.0R)
        Me.textBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.textBox5.Value = "Dealer Inc."
        '
        'textBox6
        '
        Me.textBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.8R))
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Inch(0.317R))
        Me.textBox6.Style.BorderColor.Default = System.Drawing.Color.Black
        Me.textBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.textBox6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.textBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.textBox6.Value = "Performance cars in stock"
        '
        'shape5
        '
        Me.shape5.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Left Or Telerik.Reporting.AnchoringStyles.Right), Telerik.Reporting.AnchoringStyles)
        Me.shape5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.6R))
        Me.shape5.Name = "shape5"
        Me.shape5.ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
        Me.shape5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(8.1R), Telerik.Reporting.Drawing.Unit.Point(3.75R))
        Me.shape5.Stretch = True
        Me.shape5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.shape5.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.shape5.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(3.0R)
        Me.shape5.Style.Color = System.Drawing.Color.Transparent
        '
        'list1
        '
        Me.list1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(20.574R)))
        Me.list1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(1.8R)))
        Me.list1.Body.SetCellContent(0, 0, Me.panel1)
        TableGroup1.Name = "ColumnGroup1"
        Me.list1.ColumnGroups.Add(TableGroup1)
        Me.list1.DataSource = Me.objectDataSource1
        Me.list1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.panel1})
        Me.list1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0.127R))
        Me.list1.Name = "list1"
        TableGroup3.Name = "Group1"
        TableGroup2.ChildGroups.Add(TableGroup3)
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(""))
        TableGroup2.Name = "RowGroup1"
        Me.list1.RowGroups.Add(TableGroup2)
        Me.list1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.574R), Telerik.Reporting.Drawing.Unit.Inch(1.8R))
        '
        'panel1
        '
        Me.panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.panel2})
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.574R), Telerik.Reporting.Drawing.Unit.Inch(1.8R))
        Me.panel1.StyleName = ""
        '
        'panel2
        '
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("=RowNumber() % 2", Telerik.Reporting.FilterOperator.Equal, "=0"))
        FormattingRule1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.panel2.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtModel, Me.textBox1, Me.txtProductNameLabel, Me.txtYearLabel, Me.txtManufacturer, Me.txtYear, Me.panelColorsInStock, Me.txtColorsInStock, Me.pictureBox1})
        Me.panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.574R), Telerik.Reporting.Drawing.Unit.Cm(4.318R))
        Me.panel2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(235, Byte), Integer))
        '
        'txtModel
        '
        Me.txtModel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.518R))
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtModel.Value = "=Fields.Model"
        '
        'textBox1
        '
        Me.textBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.156R), Telerik.Reporting.Drawing.Unit.Inch(0.115R))
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.344R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.textBox1.Value = "Manufacturer:"
        '
        'txtProductNameLabel
        '
        Me.txtProductNameLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.156R), Telerik.Reporting.Drawing.Unit.Inch(0.518R))
        Me.txtProductNameLabel.Name = "txtProductNameLabel"
        Me.txtProductNameLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.344R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtProductNameLabel.Value = "Model:"
        '
        'txtYearLabel
        '
        Me.txtYearLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.156R), Telerik.Reporting.Drawing.Unit.Inch(0.939R))
        Me.txtYearLabel.Name = "txtYearLabel"
        Me.txtYearLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.344R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtYearLabel.Style.Font.Bold = False
        Me.txtYearLabel.Value = "Year:"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.115R))
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtManufacturer.Value = "=Fields.Manufacturer"
        '
        'txtYear
        '
        Me.txtYear.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(0.939R))
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtYear.Value = "=Fields.Year"
        '
        'panelColorsInStock
        '
        Me.panelColorsInStock.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.shape1, Me.shape2, Me.shape3, Me.shape4})
        Me.panelColorsInStock.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.8R), Telerik.Reporting.Drawing.Unit.Inch(1.31R))
        Me.panelColorsInStock.Name = "panelColorsInStock"
        Me.panelColorsInStock.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.209R), Telerik.Reporting.Drawing.Unit.Inch(0.261R))
        '
        'shape1
        '
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("=Fields.AvailableColor.Contains('Red')", Telerik.Reporting.FilterOperator.NotEqual, "=True"))
        FormattingRule2.Style.Visible = False
        Me.shape1.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.shape1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.344R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.shape1.Name = "shape1"
        Me.shape1.ShapeType = New Telerik.Reporting.Drawing.Shapes.EllipseShape(0R)
        Me.shape1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.shape1.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.shape1.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.shape1.Style.Color = System.Drawing.Color.Transparent
        Me.shape1.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid
        Me.shape1.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        '
        'shape2
        '
        FormattingRule3.Filters.Add(New Telerik.Reporting.Filter("= Fields.AvailableColor.Contains(""Orange"")", Telerik.Reporting.FilterOperator.NotEqual, "= True"))
        FormattingRule3.Style.Visible = False
        Me.shape2.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule3})
        Me.shape2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.95R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.shape2.Name = "shape2"
        Me.shape2.ShapeType = New Telerik.Reporting.Drawing.Shapes.EllipseShape(0R)
        Me.shape2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.shape2.Style.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.shape2.Style.Color = System.Drawing.Color.Transparent
        '
        'shape3
        '
        FormattingRule4.Filters.Add(New Telerik.Reporting.Filter("= Fields.AvailableColor.Contains(""Black"")", Telerik.Reporting.FilterOperator.NotEqual, "= True"))
        FormattingRule4.Style.Visible = False
        Me.shape3.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule4})
        Me.shape3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.shape3.Name = "shape3"
        Me.shape3.ShapeType = New Telerik.Reporting.Drawing.Shapes.EllipseShape(0R)
        Me.shape3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.shape3.Style.BackgroundColor = System.Drawing.Color.Black
        Me.shape3.Style.Color = System.Drawing.Color.Transparent
        '
        'shape4
        '
        FormattingRule5.Filters.Add(New Telerik.Reporting.Filter("= Fields.AvailableColor.Contains(""White"")", Telerik.Reporting.FilterOperator.NotEqual, "= True"))
        FormattingRule5.Style.Visible = False
        Me.shape4.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule5})
        Me.shape4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.65R), Telerik.Reporting.Drawing.Unit.Inch(0.05R))
        Me.shape4.Name = "shape4"
        Me.shape4.ShapeType = New Telerik.Reporting.Drawing.Shapes.EllipseShape(0R)
        Me.shape4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R))
        Me.shape4.Style.BackgroundColor = System.Drawing.Color.White
        Me.shape4.Style.Color = System.Drawing.Color.Transparent
        '
        'txtColorsInStock
        '
        Me.txtColorsInStock.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.156R), Telerik.Reporting.Drawing.Unit.Inch(1.339R))
        Me.txtColorsInStock.Name = "txtColorsInStock"
        Me.txtColorsInStock.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.344R), Telerik.Reporting.Drawing.Unit.Inch(0.25R))
        Me.txtColorsInStock.Value = "Colors in Stock:"
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchoring = CType((Telerik.Reporting.AnchoringStyles.Top Or Telerik.Reporting.AnchoringStyles.Bottom), Telerik.Reporting.AnchoringStyles)
        Me.pictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.pictureBox1.MimeType = ""
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6R), Telerik.Reporting.Drawing.Unit.Cm(4.318R))
        Me.pictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.pictureBox1.Value = "=Fields.ImageUrl"
        '
        'objectDataSource1
        '
        Me.objectDataSource1.DataSource = GetType(Cars)
        Me.objectDataSource1.Name = "objectDataSource1"
        '
        'ListBoundReport
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.reportHeaderSection1})
        Me.Name = "ListBoundReport"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.2R), Telerik.Reporting.Drawing.Unit.Inch(0.3R), Telerik.Reporting.Drawing.Unit.Inch(0.4R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        Me.Style.BackgroundColor = System.Drawing.Color.White
        Me.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector("Header")})
        StyleRule1.Style.Font.Bold = True
        StyleRule1.Style.Font.Name = "Segoe UI Light"
        StyleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(25.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule2.Style.Font.Name = "Segoe UI Light"
        StyleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(13.0R)
        StyleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(8.1R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
#End Region

    Private detail As DetailSection
    Private objectDataSource1 As ObjectDataSource
    Private reportHeaderSection1 As ReportHeaderSection
    Private textBox5 As TextBox
    Private textBox6 As TextBox
    Private shape5 As Shape
    Friend WithEvents list1 As List
    Friend WithEvents panel1 As Panel
    Friend WithEvents panel2 As Panel
    Friend WithEvents txtModel As TextBox
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents txtProductNameLabel As TextBox
    Friend WithEvents txtYearLabel As TextBox
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents panelColorsInStock As Panel
    Friend WithEvents shape1 As Shape
    Friend WithEvents shape2 As Shape
    Friend WithEvents shape3 As Shape
    Friend WithEvents shape4 As Shape
    Friend WithEvents txtColorsInStock As TextBox
    Friend WithEvents pictureBox1 As PictureBox

End Class