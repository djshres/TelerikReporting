Partial Class SwissQRBill

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SwissQRBill))
        Dim DataColumn1 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn2 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn3 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn4 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn5 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn6 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn7 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn8 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn9 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn10 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn11 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn12 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn13 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn14 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn15 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn16 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn17 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn18 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn19 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn20 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn21 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim DataColumn22 As Telerik.Reporting.DataColumn = New Telerik.Reporting.DataColumn()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule2 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule3 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule4 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim SwissQRCodeEncoder1 As Telerik.Reporting.Barcodes.SwissQRCodeEncoder = New Telerik.Reporting.Barcodes.SwissQRCodeEncoder()
        Dim FormattingRule5 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule6 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule7 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule8 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim FormattingRule9 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule2 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule3 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule4 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule5 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule6 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Dim StyleRule7 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.billData = New Telerik.Reporting.CsvDataSource()
        Me.detailSection1 = New Telerik.Reporting.DetailSection()
        Me.panelReceipt = New Telerik.Reporting.Panel()
        Me.txtReceiptLabel = New Telerik.Reporting.TextBox()
        Me.txtReceiptAccountLabel = New Telerik.Reporting.TextBox()
        Me.txtReceiptAccount = New Telerik.Reporting.TextBox()
        Me.txtReceiptCreditorName = New Telerik.Reporting.TextBox()
        Me.txtReceiptCreditorStreetAndHouseNumber = New Telerik.Reporting.TextBox()
        Me.txtReceiptCreditorZipCodeAndCity = New Telerik.Reporting.TextBox()
        Me.panelReceiptReferenceDebtorPlaceholder = New Telerik.Reporting.Panel()
        Me.panelReceiptReference = New Telerik.Reporting.Panel()
        Me.txtReceiptReferenceLabel = New Telerik.Reporting.TextBox()
        Me.txtReceiptReference = New Telerik.Reporting.TextBox()
        Me.txtReceiptPayableByLabel = New Telerik.Reporting.TextBox()
        Me.panelReceiptDebtorFields = New Telerik.Reporting.Panel()
        Me.txtReceiptDebtorName = New Telerik.Reporting.TextBox()
        Me.txtReceiptDebtorStreetAndHouseNumber = New Telerik.Reporting.TextBox()
        Me.txtReceiptDebtorZipCodeAndCity = New Telerik.Reporting.TextBox()
        Me.pictureBoxReceiptPayableByMissing = New Telerik.Reporting.PictureBox()
        Me.panelReceiptCurrencyAmount = New Telerik.Reporting.Panel()
        Me.txtReceiptCurrencyLabel = New Telerik.Reporting.TextBox()
        Me.txtReceiptCurrency = New Telerik.Reporting.TextBox()
        Me.txtReceiptAmountLabel = New Telerik.Reporting.TextBox()
        Me.txtReceiptAmount = New Telerik.Reporting.TextBox()
        Me.pictureBoxReceiptAmountMissing = New Telerik.Reporting.PictureBox()
        Me.txtReceiptAcceptancePoint = New Telerik.Reporting.TextBox()
        Me.panelPayment = New Telerik.Reporting.Panel()
        Me.txtPaymentLabel = New Telerik.Reporting.TextBox()
        Me.barcodeSwissQR = New Telerik.Reporting.Barcode()
        Me.txtPaymentCurrencyLabel = New Telerik.Reporting.TextBox()
        Me.txtPaymentCurrency = New Telerik.Reporting.TextBox()
        Me.txtPaymentAmountLabel = New Telerik.Reporting.TextBox()
        Me.panelPaymentAmount = New Telerik.Reporting.Panel()
        Me.txtPaymentAmount = New Telerik.Reporting.TextBox()
        Me.pictureBoxPaymentAmountMissing = New Telerik.Reporting.PictureBox()
        Me.txtPaymentAccountLabel = New Telerik.Reporting.TextBox()
        Me.txtPaymentCreditorIBAN = New Telerik.Reporting.TextBox()
        Me.txtPaymentCreditorName = New Telerik.Reporting.TextBox()
        Me.txtPaymentCreditorStreetAndHouseNumber = New Telerik.Reporting.TextBox()
        Me.txtPaymentCreditorZipCodeAndCity = New Telerik.Reporting.TextBox()
        Me.panelPaymentReference = New Telerik.Reporting.Panel()
        Me.txtPaymentReferenceLabel = New Telerik.Reporting.TextBox()
        Me.txtPaymentReference = New Telerik.Reporting.TextBox()
        Me.panelPaymentAdditionalInformation = New Telerik.Reporting.Panel()
        Me.txtPaymentAdditionalInformationLabel = New Telerik.Reporting.TextBox()
        Me.txtPaymentAdditionalInfo = New Telerik.Reporting.TextBox()
        Me.txtPaymentPayableByLabel = New Telerik.Reporting.TextBox()
        Me.panelPaymentDebtor = New Telerik.Reporting.Panel()
        Me.panelPaymentDebtorFields = New Telerik.Reporting.Panel()
        Me.txtPaymentDebtorName = New Telerik.Reporting.TextBox()
        Me.txtPaymentDebtorStreetAndHouseNumber = New Telerik.Reporting.TextBox()
        Me.txtPaymentDebtorZipCodeAndCity = New Telerik.Reporting.TextBox()
        Me.pictureBoxPaymentPayableByMissing = New Telerik.Reporting.PictureBox()
        Me.pictureBoxScissors = New Telerik.Reporting.PictureBox()
        Me.reportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.panelReportHeader = New Telerik.Reporting.Panel()
        Me.pictureBoxReportLogo = New Telerik.Reporting.PictureBox()
        Me.txtReportTitle = New Telerik.Reporting.TextBox()
        Me.htmlTextBox1 = New Telerik.Reporting.HtmlTextBox()
        Me.htmlTextBox2 = New Telerik.Reporting.HtmlTextBox()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'billData
        '
        Me.billData.CalculatedFields.Add(New Telerik.Reporting.CalculatedField("FormattedReference", GetType(String), resources.GetString("billData.CalculatedFields")))
        Me.billData.CalculatedFields.Add(New Telerik.Reporting.CalculatedField("HasReference", GetType(Boolean), "=If(IsNull(Fields.Reference, """") = """", false, true)"))
        Me.billData.CalculatedFields.Add(New Telerik.Reporting.CalculatedField("HasAdditionalInformation", GetType(Boolean), "=If(IsNull(Fields.AdditionalInformation, """") = """", false, true)"))
        Me.billData.CalculatedFields.Add(New Telerik.Reporting.CalculatedField("HasDebtor", GetType(Boolean), "=If(IsNull(Fields.DebtorName, """") = """", false, true)"))
        Me.billData.CalculatedFields.Add(New Telerik.Reporting.CalculatedField("HasAmount", GetType(Boolean), "=If(CStr(IsNull(Fields.Amount, """")) = """", false, true)"))
        DataColumn1.Name = "CreditorIBAN"
        DataColumn2.Name = "CreditorIBANType"
        DataColumn3.Name = "CreditorName"
        DataColumn4.Name = "CreditorCountry"
        DataColumn5.Name = "CreditorZipCode"
        DataColumn6.Name = "CreditorCity"
        DataColumn7.Name = "CreditorStreet"
        DataColumn8.Name = "CreditorHouseNumber"
        DataColumn9.Name = "DebtorName"
        DataColumn10.Name = "DebtorCountry"
        DataColumn11.Name = "DebtorZipCode"
        DataColumn12.Name = "DebtorCity"
        DataColumn13.Name = "DebtorStreet"
        DataColumn14.Name = "DebtorHouseNumber"
        DataColumn15.Name = "Currency"
        DataColumn16.Name = "Amount"
        DataColumn16.Type = Telerik.Reporting.SimpleType.Float
        DataColumn17.Name = "Reference"
        DataColumn18.Name = "ReferenceType"
        DataColumn19.Name = "AdditionalInformation"
        DataColumn20.Name = "AlternativeProcedure1"
        DataColumn21.Name = "AlternativeProcedure2"
        DataColumn22.Name = "StructuredBillInformation"
        Me.billData.Columns.Add(DataColumn1)
        Me.billData.Columns.Add(DataColumn2)
        Me.billData.Columns.Add(DataColumn3)
        Me.billData.Columns.Add(DataColumn4)
        Me.billData.Columns.Add(DataColumn5)
        Me.billData.Columns.Add(DataColumn6)
        Me.billData.Columns.Add(DataColumn7)
        Me.billData.Columns.Add(DataColumn8)
        Me.billData.Columns.Add(DataColumn9)
        Me.billData.Columns.Add(DataColumn10)
        Me.billData.Columns.Add(DataColumn11)
        Me.billData.Columns.Add(DataColumn12)
        Me.billData.Columns.Add(DataColumn13)
        Me.billData.Columns.Add(DataColumn14)
        Me.billData.Columns.Add(DataColumn15)
        Me.billData.Columns.Add(DataColumn16)
        Me.billData.Columns.Add(DataColumn17)
        Me.billData.Columns.Add(DataColumn18)
        Me.billData.Columns.Add(DataColumn19)
        Me.billData.Columns.Add(DataColumn20)
        Me.billData.Columns.Add(DataColumn21)
        Me.billData.Columns.Add(DataColumn22)
        Me.billData.FieldSeparators = New Char() {Global.Microsoft.VisualBasic.ChrW(9)}
        Me.billData.HasHeaders = True
        Me.billData.Name = "billData"
        Me.billData.RecordSeparators = New Char() {Global.Microsoft.VisualBasic.ChrW(13), Global.Microsoft.VisualBasic.ChrW(10)}
        Me.billData.Source = resources.GetString("billData.Source")
        '
        'detailSection1
        '
        Me.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(10.5R)
        Me.detailSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.panelReceipt, Me.panelPayment, Me.pictureBoxScissors})
        Me.detailSection1.Name = "detailSection1"
        '
        'panelReceipt
        '
        Me.panelReceipt.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtReceiptLabel, Me.txtReceiptAccountLabel, Me.txtReceiptAccount, Me.txtReceiptCreditorName, Me.txtReceiptCreditorStreetAndHouseNumber, Me.txtReceiptCreditorZipCodeAndCity, Me.panelReceiptReferenceDebtorPlaceholder, Me.panelReceiptCurrencyAmount, Me.pictureBoxReceiptAmountMissing, Me.txtReceiptAcceptancePoint})
        Me.panelReceipt.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.panelReceipt.Name = "panelReceipt"
        Me.panelReceipt.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(62.0R), Telerik.Reporting.Drawing.Unit.Mm(105.0R))
        '
        'txtReceiptLabel
        '
        Me.txtReceiptLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.txtReceiptLabel.Name = "txtReceiptLabel"
        Me.txtReceiptLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(7.0R))
        Me.txtReceiptLabel.StyleName = "Titles"
        Me.txtReceiptLabel.Value = "Receipt"
        '
        'txtReceiptAccountLabel
        '
        Me.txtReceiptAccountLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(12.0R))
        Me.txtReceiptAccountLabel.Name = "txtReceiptAccountLabel"
        Me.txtReceiptAccountLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptAccountLabel.StyleName = "ReceiptLabels"
        Me.txtReceiptAccountLabel.Value = "Account / Payable to"
        '
        'txtReceiptAccount
        '
        Me.txtReceiptAccount.CanGrow = False
        Me.txtReceiptAccount.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(15.0R))
        Me.txtReceiptAccount.Name = "txtReceiptAccount"
        Me.txtReceiptAccount.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptAccount.StyleName = "ReceiptDataFields"
        Me.txtReceiptAccount.Value = "=Fields.CreditorIBAN"
        '
        'txtReceiptCreditorName
        '
        Me.txtReceiptCreditorName.CanGrow = False
        Me.txtReceiptCreditorName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(18.0R))
        Me.txtReceiptCreditorName.Name = "txtReceiptCreditorName"
        Me.txtReceiptCreditorName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptCreditorName.StyleName = "ReceiptDataFields"
        Me.txtReceiptCreditorName.Value = "= Fields.CreditorName"
        '
        'txtReceiptCreditorStreetAndHouseNumber
        '
        Me.txtReceiptCreditorStreetAndHouseNumber.CanGrow = False
        Me.txtReceiptCreditorStreetAndHouseNumber.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(22.0R))
        Me.txtReceiptCreditorStreetAndHouseNumber.Name = "txtReceiptCreditorStreetAndHouseNumber"
        Me.txtReceiptCreditorStreetAndHouseNumber.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptCreditorStreetAndHouseNumber.StyleName = "ReceiptDataFields"
        Me.txtReceiptCreditorStreetAndHouseNumber.Value = "= Trim(Format('{0} {1}', Fields.CreditorStreet, Fields.CreditorHouseNumber))"
        '
        'txtReceiptCreditorZipCodeAndCity
        '
        Me.txtReceiptCreditorZipCodeAndCity.CanGrow = False
        Me.txtReceiptCreditorZipCodeAndCity.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(25.0R))
        Me.txtReceiptCreditorZipCodeAndCity.Name = "txtReceiptCreditorZipCodeAndCity"
        Me.txtReceiptCreditorZipCodeAndCity.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptCreditorZipCodeAndCity.StyleName = "ReceiptDataFields"
        Me.txtReceiptCreditorZipCodeAndCity.Value = "=Trim(Format('{0} {1}', Fields.CreditorZipCode, Fields.CreditorCity))"
        '
        'panelReceiptReferenceDebtorPlaceholder
        '
        Me.panelReceiptReferenceDebtorPlaceholder.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.panelReceiptReference, Me.txtReceiptPayableByLabel, Me.panelReceiptDebtorFields, Me.pictureBoxReceiptPayableByMissing})
        Me.panelReceiptReferenceDebtorPlaceholder.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(32.0R))
        Me.panelReceiptReferenceDebtorPlaceholder.Name = "panelReceiptReferenceDebtorPlaceholder"
        Me.panelReceiptReferenceDebtorPlaceholder.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(33.0R))
        '
        'panelReceiptReference
        '
        Me.panelReceiptReference.CanShrink = True
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasReference", Telerik.Reporting.FilterOperator.Equal, "False"))
        FormattingRule1.Style.Visible = False
        Me.panelReceiptReference.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.panelReceiptReference.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtReceiptReferenceLabel, Me.txtReceiptReference})
        Me.panelReceiptReference.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.panelReceiptReference.Name = "panelReceiptReference"
        Me.panelReceiptReference.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(10.0R))
        '
        'txtReceiptReferenceLabel
        '
        Me.txtReceiptReferenceLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtReceiptReferenceLabel.Name = "txtReceiptReferenceLabel"
        Me.txtReceiptReferenceLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptReferenceLabel.StyleName = "ReceiptLabels"
        Me.txtReceiptReferenceLabel.Value = "Reference"
        '
        'txtReceiptReference
        '
        Me.txtReceiptReference.CanGrow = False
        Me.txtReceiptReference.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptReference.Name = "txtReceiptReference"
        Me.txtReceiptReference.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptReference.StyleName = "ReceiptDataFields"
        Me.txtReceiptReference.Value = "= Fields.FormattedReference"
        '
        'txtReceiptPayableByLabel
        '
        Me.txtReceiptPayableByLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(10.0R))
        Me.txtReceiptPayableByLabel.Name = "txtReceiptPayableByLabel"
        Me.txtReceiptPayableByLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptPayableByLabel.StyleName = "ReceiptLabels"
        Me.txtReceiptPayableByLabel.Value = "Payable by"
        '
        'panelReceiptDebtorFields
        '
        Me.panelReceiptDebtorFields.CanShrink = True
        FormattingRule2.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "False"))
        FormattingRule2.Style.Visible = False
        Me.panelReceiptDebtorFields.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule2})
        Me.panelReceiptDebtorFields.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtReceiptDebtorName, Me.txtReceiptDebtorStreetAndHouseNumber, Me.txtReceiptDebtorZipCodeAndCity})
        Me.panelReceiptDebtorFields.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(13.0R))
        Me.panelReceiptDebtorFields.Name = "panelReceiptDebtorFields"
        Me.panelReceiptDebtorFields.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(9.0R))
        '
        'txtReceiptDebtorName
        '
        Me.txtReceiptDebtorName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtReceiptDebtorName.Name = "txtReceiptDebtorName"
        Me.txtReceiptDebtorName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptDebtorName.StyleName = "ReceiptDataFields"
        Me.txtReceiptDebtorName.Value = "= Fields.DebtorName"
        '
        'txtReceiptDebtorStreetAndHouseNumber
        '
        Me.txtReceiptDebtorStreetAndHouseNumber.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptDebtorStreetAndHouseNumber.Name = "txtReceiptDebtorStreetAndHouseNumber"
        Me.txtReceiptDebtorStreetAndHouseNumber.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptDebtorStreetAndHouseNumber.StyleName = "ReceiptDataFields"
        Me.txtReceiptDebtorStreetAndHouseNumber.Value = "= Trim(Format('{0} {1}', Fields.DebtorStreet, Fields.DebtorHouseNumber))"
        '
        'txtReceiptDebtorZipCodeAndCity
        '
        Me.txtReceiptDebtorZipCodeAndCity.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(6.0R))
        Me.txtReceiptDebtorZipCodeAndCity.Name = "txtReceiptDebtorZipCodeAndCity"
        Me.txtReceiptDebtorZipCodeAndCity.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptDebtorZipCodeAndCity.StyleName = "ReceiptDataFields"
        Me.txtReceiptDebtorZipCodeAndCity.Value = "=Trim(Format('{0} {1}', Fields.DebtorZipCode, Fields.DebtorCity))"
        '
        'pictureBoxReceiptPayableByMissing
        '
        Me.pictureBoxReceiptPayableByMissing.Bindings.Add(New Telerik.Reporting.Binding("Height", "='22mm'"))
        FormattingRule3.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "True"))
        FormattingRule3.Style.Visible = False
        Me.pictureBoxReceiptPayableByMissing.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule3})
        Me.pictureBoxReceiptPayableByMissing.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(22.0R))
        Me.pictureBoxReceiptPayableByMissing.MimeType = ""
        Me.pictureBoxReceiptPayableByMissing.Name = "pictureBoxReceiptPayableByMissing"
        Me.pictureBoxReceiptPayableByMissing.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(11.0R))
        Me.pictureBoxReceiptPayableByMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.pictureBoxReceiptPayableByMissing.Value = resources.GetString("pictureBoxReceiptPayableByMissing.Value")
        '
        'panelReceiptCurrencyAmount
        '
        Me.panelReceiptCurrencyAmount.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtReceiptCurrencyLabel, Me.txtReceiptCurrency, Me.txtReceiptAmountLabel, Me.txtReceiptAmount})
        Me.panelReceiptCurrencyAmount.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(70.0R))
        Me.panelReceiptCurrencyAmount.Name = "panelReceiptCurrencyAmount"
        Me.panelReceiptCurrencyAmount.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(34.0R), Telerik.Reporting.Drawing.Unit.Mm(6.0R))
        '
        'txtReceiptCurrencyLabel
        '
        Me.txtReceiptCurrencyLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtReceiptCurrencyLabel.Name = "txtReceiptCurrencyLabel"
        Me.txtReceiptCurrencyLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptCurrencyLabel.StyleName = "ReceiptLabels"
        Me.txtReceiptCurrencyLabel.Value = "Currency"
        '
        'txtReceiptCurrency
        '
        Me.txtReceiptCurrency.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptCurrency.Name = "txtReceiptCurrency"
        Me.txtReceiptCurrency.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptCurrency.StyleName = "ReceiptDataFields"
        Me.txtReceiptCurrency.Value = "= Fields.Currency"
        '
        'txtReceiptAmountLabel
        '
        Me.txtReceiptAmountLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(14.0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtReceiptAmountLabel.Name = "txtReceiptAmountLabel"
        Me.txtReceiptAmountLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptAmountLabel.StyleName = "ReceiptLabels"
        Me.txtReceiptAmountLabel.Value = "Amount"
        '
        'txtReceiptAmount
        '
        Me.txtReceiptAmount.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(14.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptAmount.Name = "txtReceiptAmount"
        Me.txtReceiptAmount.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptAmount.StyleName = "ReceiptDataFields"
        Me.txtReceiptAmount.Value = "= Replace(FormatWithCulture("""", ""{0:N2}"", Fields.Amount), "","", "" "")"
        '
        'pictureBoxReceiptAmountMissing
        '
        FormattingRule4.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasAmount", Telerik.Reporting.FilterOperator.Equal, "True"))
        FormattingRule4.Style.Visible = False
        Me.pictureBoxReceiptAmountMissing.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule4})
        Me.pictureBoxReceiptAmountMissing.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(31.0R), Telerik.Reporting.Drawing.Unit.Mm(70.0R))
        Me.pictureBoxReceiptAmountMissing.MimeType = ""
        Me.pictureBoxReceiptAmountMissing.Name = "pictureBoxReceiptAmountMissing"
        Me.pictureBoxReceiptAmountMissing.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(30.0R), Telerik.Reporting.Drawing.Unit.Mm(10.0R))
        Me.pictureBoxReceiptAmountMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.pictureBoxReceiptAmountMissing.Style.BackgroundColor = System.Drawing.Color.White
        Me.pictureBoxReceiptAmountMissing.Value = resources.GetString("pictureBoxReceiptAmountMissing.Value")
        '
        'txtReceiptAcceptancePoint
        '
        Me.txtReceiptAcceptancePoint.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(38.0R), Telerik.Reporting.Drawing.Unit.Mm(82.0R))
        Me.txtReceiptAcceptancePoint.Name = "txtReceiptAcceptancePoint"
        Me.txtReceiptAcceptancePoint.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(24.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.txtReceiptAcceptancePoint.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(5.0R)
        Me.txtReceiptAcceptancePoint.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.txtReceiptAcceptancePoint.StyleName = "ReceiptLabels"
        Me.txtReceiptAcceptancePoint.Value = "Acceptance point"
        '
        'panelPayment
        '
        Me.panelPayment.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtPaymentLabel, Me.barcodeSwissQR, Me.txtPaymentCurrencyLabel, Me.txtPaymentCurrency, Me.txtPaymentAmountLabel, Me.panelPaymentAmount, Me.txtPaymentAccountLabel, Me.txtPaymentCreditorIBAN, Me.txtPaymentCreditorName, Me.txtPaymentCreditorStreetAndHouseNumber, Me.txtPaymentCreditorZipCodeAndCity, Me.panelPaymentReference, Me.panelPaymentAdditionalInformation, Me.txtPaymentPayableByLabel, Me.panelPaymentDebtor})
        Me.panelPayment.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(62.0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.panelPayment.Name = "panelPayment"
        Me.panelPayment.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(148.0R), Telerik.Reporting.Drawing.Unit.Mm(105.0R))
        Me.panelPayment.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Dotted
        '
        'txtPaymentLabel
        '
        Me.txtPaymentLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.txtPaymentLabel.Name = "txtPaymentLabel"
        Me.txtPaymentLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(51.0R), Telerik.Reporting.Drawing.Unit.Mm(7.0R))
        Me.txtPaymentLabel.StyleName = "Titles"
        Me.txtPaymentLabel.Value = "Payment part"
        '
        'barcodeSwissQR
        '
        SwissQRCodeEncoder1.BillData.Creditor.Address.City = "= Fields.CreditorCity"
        SwissQRCodeEncoder1.BillData.Creditor.Address.Country = "=Fields.CreditorCountry"
        SwissQRCodeEncoder1.BillData.Creditor.Address.HouseNumber = "= Fields.CreditorHouseNumber"
        SwissQRCodeEncoder1.BillData.Creditor.Address.PostalCode = "= Fields.CreditorZipCode"
        SwissQRCodeEncoder1.BillData.Creditor.Address.Street = "= Fields.CreditorStreet"
        SwissQRCodeEncoder1.BillData.Creditor.IBAN = "= Fields.CreditorIBAN"
        SwissQRCodeEncoder1.BillData.Creditor.Name = "= Fields.CreditorName"
        SwissQRCodeEncoder1.BillData.Debtor.Address.City = "= Fields.DebtorCity"
        SwissQRCodeEncoder1.BillData.Debtor.Address.Country = "= Fields.DebtorCountry"
        SwissQRCodeEncoder1.BillData.Debtor.Address.HouseNumber = "= Fields.DebtorHouseNumber"
        SwissQRCodeEncoder1.BillData.Debtor.Address.PostalCode = "= Fields.DebtorZipCode"
        SwissQRCodeEncoder1.BillData.Debtor.Address.Street = "= Fields.DebtorStreet"
        SwissQRCodeEncoder1.BillData.Debtor.Name = "= Fields.DebtorName"
        SwissQRCodeEncoder1.BillData.Payment.AdditionalInfo = "= Fields.AdditionalInformation"
        SwissQRCodeEncoder1.BillData.Payment.AlternativeProcedure1 = "= Fields.AlternativeProcedure1"
        SwissQRCodeEncoder1.BillData.Payment.AlternativeProcedure2 = "= Fields.AlternativeProcedure2"
        SwissQRCodeEncoder1.BillData.Payment.Amount = "= Fields.Amount"
        SwissQRCodeEncoder1.BillData.Payment.Currency = "= Fields.Currency"
        SwissQRCodeEncoder1.BillData.Payment.Reference = "= Fields.Reference"
        SwissQRCodeEncoder1.BillData.Payment.ReferenceType = "= Fields.ReferenceType"
        SwissQRCodeEncoder1.BillData.Payment.StructuredBillInfo = "= Fields.StructuredBillInformation"
        SwissQRCodeEncoder1.ECI = Telerik.Reporting.Barcodes.QRCode.ECIMode.UTF8
        SwissQRCodeEncoder1.ErrorCorrectionLevel = Telerik.Reporting.Barcodes.QRCode.ErrorCorrectionLevel.M
        Me.barcodeSwissQR.Encoder = SwissQRCodeEncoder1
        Me.barcodeSwissQR.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Mm(12.0R))
        Me.barcodeSwissQR.Name = "barcodeSwissQR"
        Me.barcodeSwissQR.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(56.0R))
        Me.barcodeSwissQR.Stretch = False
        '
        'txtPaymentCurrencyLabel
        '
        Me.txtPaymentCurrencyLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(70.0R))
        Me.txtPaymentCurrencyLabel.Name = "txtPaymentCurrencyLabel"
        Me.txtPaymentCurrencyLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentCurrencyLabel.StyleName = "PaymentLabels"
        Me.txtPaymentCurrencyLabel.Value = "Currency"
        '
        'txtPaymentCurrency
        '
        Me.txtPaymentCurrency.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(74.0R))
        Me.txtPaymentCurrency.Name = "txtPaymentCurrency"
        Me.txtPaymentCurrency.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentCurrency.StyleName = "PaymentDataFields"
        Me.txtPaymentCurrency.Value = "= Fields.Currency"
        '
        'txtPaymentAmountLabel
        '
        Me.txtPaymentAmountLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(22.0R), Telerik.Reporting.Drawing.Unit.Mm(70.0R))
        Me.txtPaymentAmountLabel.Name = "txtPaymentAmountLabel"
        Me.txtPaymentAmountLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(28.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentAmountLabel.StyleName = "PaymentLabels"
        Me.txtPaymentAmountLabel.Value = "Amount"
        '
        'panelPaymentAmount
        '
        Me.panelPaymentAmount.CanShrink = True
        Me.panelPaymentAmount.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtPaymentAmount, Me.pictureBoxPaymentAmountMissing})
        Me.panelPaymentAmount.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(22.0R), Telerik.Reporting.Drawing.Unit.Mm(74.0R))
        Me.panelPaymentAmount.Name = "panelPaymentAmount"
        Me.panelPaymentAmount.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(34.0R), Telerik.Reporting.Drawing.Unit.Mm(19.0R))
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.CanShrink = True
        Me.txtPaymentAmount.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(28.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentAmount.StyleName = "PaymentDataFields"
        Me.txtPaymentAmount.Value = "= Replace(FormatWithCulture("""", ""{0:N2}"", Fields.Amount), "","", "" "")"
        '
        'pictureBoxPaymentAmountMissing
        '
        FormattingRule5.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasAmount", Telerik.Reporting.FilterOperator.Equal, "True"))
        FormattingRule5.Style.Visible = False
        Me.pictureBoxPaymentAmountMissing.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule5})
        Me.pictureBoxPaymentAmountMissing.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.pictureBoxPaymentAmountMissing.MimeType = ""
        Me.pictureBoxPaymentAmountMissing.Name = "pictureBoxPaymentAmountMissing"
        Me.pictureBoxPaymentAmountMissing.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(34.0R), Telerik.Reporting.Drawing.Unit.Mm(15.0R))
        Me.pictureBoxPaymentAmountMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.pictureBoxPaymentAmountMissing.Style.BackgroundColor = System.Drawing.Color.White
        Me.pictureBoxPaymentAmountMissing.Value = resources.GetString("pictureBoxPaymentAmountMissing.Value")
        '
        'txtPaymentAccountLabel
        '
        Me.txtPaymentAccountLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.txtPaymentAccountLabel.Name = "txtPaymentAccountLabel"
        Me.txtPaymentAccountLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentAccountLabel.StyleName = "PaymentLabels"
        Me.txtPaymentAccountLabel.Value = "Account / Payable to"
        '
        'txtPaymentCreditorIBAN
        '
        Me.txtPaymentCreditorIBAN.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(9.0R))
        Me.txtPaymentCreditorIBAN.Name = "txtPaymentCreditorIBAN"
        Me.txtPaymentCreditorIBAN.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentCreditorIBAN.StyleName = "PaymentDataFields"
        Me.txtPaymentCreditorIBAN.Value = "= Fields.CreditorIBAN"
        '
        'txtPaymentCreditorName
        '
        Me.txtPaymentCreditorName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(13.0R))
        Me.txtPaymentCreditorName.Name = "txtPaymentCreditorName"
        Me.txtPaymentCreditorName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentCreditorName.StyleName = "PaymentDataFields"
        Me.txtPaymentCreditorName.Value = "= Fields.CreditorName"
        '
        'txtPaymentCreditorStreetAndHouseNumber
        '
        Me.txtPaymentCreditorStreetAndHouseNumber.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(17.0R))
        Me.txtPaymentCreditorStreetAndHouseNumber.Name = "txtPaymentCreditorStreetAndHouseNumber"
        Me.txtPaymentCreditorStreetAndHouseNumber.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentCreditorStreetAndHouseNumber.StyleName = "PaymentDataFields"
        Me.txtPaymentCreditorStreetAndHouseNumber.Value = "= Trim(Format('{0} {1}', Fields.CreditorStreet, Fields.CreditorHouseNumber))"
        '
        'txtPaymentCreditorZipCodeAndCity
        '
        Me.txtPaymentCreditorZipCodeAndCity.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(21.0R))
        Me.txtPaymentCreditorZipCodeAndCity.Name = "txtPaymentCreditorZipCodeAndCity"
        Me.txtPaymentCreditorZipCodeAndCity.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentCreditorZipCodeAndCity.StyleName = "PaymentDataFields"
        Me.txtPaymentCreditorZipCodeAndCity.Value = "=Trim(Format('{0} {1}', Fields.CreditorZipCode, Fields.CreditorCity))"
        '
        'panelPaymentReference
        '
        Me.panelPaymentReference.CanShrink = True
        FormattingRule6.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasReference", Telerik.Reporting.FilterOperator.Equal, "False"))
        FormattingRule6.Style.Visible = False
        Me.panelPaymentReference.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule6})
        Me.panelPaymentReference.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtPaymentReferenceLabel, Me.txtPaymentReference})
        Me.panelPaymentReference.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(29.0R))
        Me.panelPaymentReference.Name = "panelPaymentReference"
        Me.panelPaymentReference.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(12.0R))
        '
        'txtPaymentReferenceLabel
        '
        Me.txtPaymentReferenceLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtPaymentReferenceLabel.Name = "txtPaymentReferenceLabel"
        Me.txtPaymentReferenceLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentReferenceLabel.StyleName = "PaymentLabels"
        Me.txtPaymentReferenceLabel.Value = "Reference"
        '
        'txtPaymentReference
        '
        Me.txtPaymentReference.CanGrow = False
        Me.txtPaymentReference.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentReference.Name = "txtPaymentReference"
        Me.txtPaymentReference.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentReference.StyleName = "PaymentDataFields"
        Me.txtPaymentReference.Value = "= Fields.FormattedReference"
        '
        'panelPaymentAdditionalInformation
        '
        Me.panelPaymentAdditionalInformation.CanShrink = True
        FormattingRule7.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasAdditionalInformation", Telerik.Reporting.FilterOperator.Equal, "False"))
        FormattingRule7.Style.Visible = False
        Me.panelPaymentAdditionalInformation.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule7})
        Me.panelPaymentAdditionalInformation.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtPaymentAdditionalInformationLabel, Me.txtPaymentAdditionalInfo})
        Me.panelPaymentAdditionalInformation.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(41.0R))
        Me.panelPaymentAdditionalInformation.Name = "panelPaymentAdditionalInformation"
        Me.panelPaymentAdditionalInformation.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(12.0R))
        '
        'txtPaymentAdditionalInformationLabel
        '
        Me.txtPaymentAdditionalInformationLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtPaymentAdditionalInformationLabel.Name = "txtPaymentAdditionalInformationLabel"
        Me.txtPaymentAdditionalInformationLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentAdditionalInformationLabel.StyleName = "PaymentLabels"
        Me.txtPaymentAdditionalInformationLabel.Value = "Additional information"
        '
        'txtPaymentAdditionalInfo
        '
        Me.txtPaymentAdditionalInfo.CanGrow = False
        Me.txtPaymentAdditionalInfo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentAdditionalInfo.Name = "txtPaymentAdditionalInfo"
        Me.txtPaymentAdditionalInfo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentAdditionalInfo.StyleName = "PaymentDataFields"
        Me.txtPaymentAdditionalInfo.Value = "= Fields.AdditionalInformation"
        '
        'txtPaymentPayableByLabel
        '
        Me.txtPaymentPayableByLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(53.0R))
        Me.txtPaymentPayableByLabel.Name = "txtPaymentPayableByLabel"
        Me.txtPaymentPayableByLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentPayableByLabel.StyleName = "PaymentLabels"
        Me.txtPaymentPayableByLabel.Value = "Payable by"
        '
        'panelPaymentDebtor
        '
        Me.panelPaymentDebtor.CanShrink = True
        Me.panelPaymentDebtor.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.panelPaymentDebtorFields, Me.pictureBoxPaymentPayableByMissing})
        Me.panelPaymentDebtor.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56.0R), Telerik.Reporting.Drawing.Unit.Mm(57.0R))
        Me.panelPaymentDebtor.Name = "panelPaymentDebtor"
        Me.panelPaymentDebtor.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(37.0R))
        '
        'panelPaymentDebtorFields
        '
        Me.panelPaymentDebtorFields.CanShrink = True
        FormattingRule8.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "False"))
        FormattingRule8.Style.Visible = False
        Me.panelPaymentDebtorFields.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule8})
        Me.panelPaymentDebtorFields.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.txtPaymentDebtorName, Me.txtPaymentDebtorStreetAndHouseNumber, Me.txtPaymentDebtorZipCodeAndCity})
        Me.panelPaymentDebtorFields.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.panelPaymentDebtorFields.Name = "panelPaymentDebtorFields"
        Me.panelPaymentDebtorFields.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(12.0R))
        '
        'txtPaymentDebtorName
        '
        Me.txtPaymentDebtorName.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtPaymentDebtorName.Name = "txtPaymentDebtorName"
        Me.txtPaymentDebtorName.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentDebtorName.StyleName = "PaymentDataFields"
        Me.txtPaymentDebtorName.Value = "= Fields.DebtorName"
        '
        'txtPaymentDebtorStreetAndHouseNumber
        '
        Me.txtPaymentDebtorStreetAndHouseNumber.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentDebtorStreetAndHouseNumber.Name = "txtPaymentDebtorStreetAndHouseNumber"
        Me.txtPaymentDebtorStreetAndHouseNumber.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentDebtorStreetAndHouseNumber.StyleName = "PaymentDataFields"
        Me.txtPaymentDebtorStreetAndHouseNumber.Value = "= Trim(Format('{0} {1}', Fields.DebtorStreet, Fields.DebtorHouseNumber))"
        '
        'txtPaymentDebtorZipCodeAndCity
        '
        Me.txtPaymentDebtorZipCodeAndCity.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(8.0R))
        Me.txtPaymentDebtorZipCodeAndCity.Name = "txtPaymentDebtorZipCodeAndCity"
        Me.txtPaymentDebtorZipCodeAndCity.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R))
        Me.txtPaymentDebtorZipCodeAndCity.StyleName = "PaymentDataFields"
        Me.txtPaymentDebtorZipCodeAndCity.Value = "=Trim(Format('{0} {1}', Fields.DebtorZipCode, Fields.DebtorCity))"
        '
        'pictureBoxPaymentPayableByMissing
        '
        FormattingRule9.Filters.Add(New Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "True"))
        FormattingRule9.Style.Visible = False
        Me.pictureBoxPaymentPayableByMissing.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule9})
        Me.pictureBoxPaymentPayableByMissing.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(12.0R))
        Me.pictureBoxPaymentPayableByMissing.MimeType = ""
        Me.pictureBoxPaymentPayableByMissing.Name = "pictureBoxPaymentPayableByMissing"
        Me.pictureBoxPaymentPayableByMissing.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(65.0R), Telerik.Reporting.Drawing.Unit.Mm(25.0R))
        Me.pictureBoxPaymentPayableByMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.pictureBoxPaymentPayableByMissing.Value = resources.GetString("pictureBoxPaymentPayableByMissing.Value")
        '
        'pictureBoxScissors
        '
        Me.pictureBoxScissors.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(59.5R), Telerik.Reporting.Drawing.Unit.Mm(90.0R))
        Me.pictureBoxScissors.MimeType = ""
        Me.pictureBoxScissors.Name = "pictureBoxScissors"
        Me.pictureBoxScissors.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(5.0R), Telerik.Reporting.Drawing.Unit.Mm(5.0R))
        Me.pictureBoxScissors.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.pictureBoxScissors.Value = resources.GetString("pictureBoxScissors.Value")
        '
        'reportHeaderSection1
        '
        Me.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(7.6R)
        Me.reportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.panelReportHeader, Me.htmlTextBox1, Me.htmlTextBox2})
        Me.reportHeaderSection1.Name = "reportHeaderSection1"
        Me.reportHeaderSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'panelReportHeader
        '
        Me.panelReportHeader.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pictureBoxReportLogo, Me.txtReportTitle})
        Me.panelReportHeader.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.panelReportHeader.Name = "panelReportHeader"
        Me.panelReportHeader.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R))
        Me.panelReportHeader.Style.BorderColor.Default = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelReportHeader.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        '
        'pictureBoxReportLogo
        '
        Me.pictureBoxReportLogo.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.pictureBoxReportLogo.MimeType = ""
        Me.pictureBoxReportLogo.Name = "pictureBoxReportLogo"
        Me.pictureBoxReportLogo.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R))
        Me.pictureBoxReportLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional
        Me.pictureBoxReportLogo.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.pictureBoxReportLogo.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.pictureBoxReportLogo.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.pictureBoxReportLogo.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(8.0R)
        Me.pictureBoxReportLogo.Value = resources.GetString("pictureBoxReportLogo.Value")
        '
        'txtReportTitle
        '
        Me.txtReportTitle.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(20.0R), Telerik.Reporting.Drawing.Unit.Mm(0R))
        Me.txtReportTitle.Name = "txtReportTitle"
        Me.txtReportTitle.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(190.0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R))
        Me.txtReportTitle.Style.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReportTitle.Style.Font.Bold = True
        Me.txtReportTitle.Style.Font.Name = "Segoe UI Semibold"
        Me.txtReportTitle.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(28.0R)
        Me.txtReportTitle.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(10.0R)
        Me.txtReportTitle.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.txtReportTitle.Value = "Swiss QR-bill"
        '
        'htmlTextBox1
        '
        Me.htmlTextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(20.0R))
        Me.htmlTextBox1.Name = "htmlTextBox1"
        Me.htmlTextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210.0R), Telerik.Reporting.Drawing.Unit.Mm(32.0R))
        Me.htmlTextBox1.Style.Font.Name = "Segoe UI"
        Me.htmlTextBox1.Value = resources.GetString("htmlTextBox1.Value")
        '
        'htmlTextBox2
        '
        Me.htmlTextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0R), Telerik.Reporting.Drawing.Unit.Mm(52.0R))
        Me.htmlTextBox2.Name = "htmlTextBox2"
        Me.htmlTextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210.0R), Telerik.Reporting.Drawing.Unit.Mm(24.0R))
        Me.htmlTextBox2.Style.Font.Name = "Segoe UI"
        Me.htmlTextBox2.Value = resources.GetString("htmlTextBox2.Value")
        '
        'SwissQRBill
        '
        Me.DataSource = Me.billData
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detailSection1, Me.reportHeaderSection1})
        Me.Name = "SwissQRBill"
        Me.PageSettings.ContinuousPaper = False
        Me.PageSettings.Landscape = True
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R), Telerik.Reporting.Drawing.Unit.Cm(0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(105.0R), Telerik.Reporting.Drawing.Unit.Mm(210.0R))
        Me.SkipBlankPages = False
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule2.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.PictureBox)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule3.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.TextBox), "Titles")})
        StyleRule3.Style.Font.Bold = True
        StyleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        StyleRule4.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.TextBox), "ReceiptLabels")})
        StyleRule4.Style.Font.Bold = True
        StyleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6.0R)
        StyleRule5.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.TextBox), "ReceiptDataFields")})
        StyleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        StyleRule6.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.TextBox), "PaymentLabels")})
        StyleRule6.Style.Font.Bold = True
        StyleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        StyleRule7.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.StyleSelector(GetType(Telerik.Reporting.TextBox), "PaymentDataFields")})
        StyleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1, StyleRule2, StyleRule3, StyleRule4, StyleRule5, StyleRule6, StyleRule7})
        Me.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(21.0R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents billData As Telerik.Reporting.CsvDataSource
    Friend WithEvents detailSection1 As Telerik.Reporting.DetailSection
    Friend WithEvents panelReceipt As Telerik.Reporting.Panel
    Friend WithEvents txtReceiptLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptAccountLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptAccount As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptCreditorName As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptCreditorStreetAndHouseNumber As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptCreditorZipCodeAndCity As Telerik.Reporting.TextBox
    Friend WithEvents panelReceiptReferenceDebtorPlaceholder As Telerik.Reporting.Panel
    Friend WithEvents panelReceiptReference As Telerik.Reporting.Panel
    Friend WithEvents txtReceiptReferenceLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptReference As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptPayableByLabel As Telerik.Reporting.TextBox
    Friend WithEvents panelReceiptDebtorFields As Telerik.Reporting.Panel
    Friend WithEvents txtReceiptDebtorName As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptDebtorStreetAndHouseNumber As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptDebtorZipCodeAndCity As Telerik.Reporting.TextBox
    Friend WithEvents pictureBoxReceiptPayableByMissing As Telerik.Reporting.PictureBox
    Friend WithEvents panelReceiptCurrencyAmount As Telerik.Reporting.Panel
    Friend WithEvents txtReceiptCurrencyLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptCurrency As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptAmountLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtReceiptAmount As Telerik.Reporting.TextBox
    Friend WithEvents pictureBoxReceiptAmountMissing As Telerik.Reporting.PictureBox
    Friend WithEvents txtReceiptAcceptancePoint As Telerik.Reporting.TextBox
    Friend WithEvents panelPayment As Telerik.Reporting.Panel
    Friend WithEvents txtPaymentLabel As Telerik.Reporting.TextBox
    Friend WithEvents barcodeSwissQR As Telerik.Reporting.Barcode
    Friend WithEvents txtPaymentCurrencyLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentCurrency As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentAmountLabel As Telerik.Reporting.TextBox
    Friend WithEvents panelPaymentAmount As Telerik.Reporting.Panel
    Friend WithEvents txtPaymentAmount As Telerik.Reporting.TextBox
    Friend WithEvents pictureBoxPaymentAmountMissing As Telerik.Reporting.PictureBox
    Friend WithEvents txtPaymentAccountLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentCreditorIBAN As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentCreditorName As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentCreditorStreetAndHouseNumber As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentCreditorZipCodeAndCity As Telerik.Reporting.TextBox
    Friend WithEvents panelPaymentReference As Telerik.Reporting.Panel
    Friend WithEvents txtPaymentReferenceLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentReference As Telerik.Reporting.TextBox
    Friend WithEvents panelPaymentAdditionalInformation As Telerik.Reporting.Panel
    Friend WithEvents txtPaymentAdditionalInformationLabel As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentAdditionalInfo As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentPayableByLabel As Telerik.Reporting.TextBox
    Friend WithEvents panelPaymentDebtor As Telerik.Reporting.Panel
    Friend WithEvents panelPaymentDebtorFields As Telerik.Reporting.Panel
    Friend WithEvents txtPaymentDebtorName As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentDebtorStreetAndHouseNumber As Telerik.Reporting.TextBox
    Friend WithEvents txtPaymentDebtorZipCodeAndCity As Telerik.Reporting.TextBox
    Friend WithEvents pictureBoxPaymentPayableByMissing As Telerik.Reporting.PictureBox
    Friend WithEvents pictureBoxScissors As Telerik.Reporting.PictureBox
    Friend WithEvents reportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents panelReportHeader As Telerik.Reporting.Panel
    Friend WithEvents pictureBoxReportLogo As Telerik.Reporting.PictureBox
    Friend WithEvents txtReportTitle As Telerik.Reporting.TextBox
    Friend WithEvents htmlTextBox1 As Telerik.Reporting.HtmlTextBox
    Friend WithEvents htmlTextBox2 As Telerik.Reporting.HtmlTextBox
End Class