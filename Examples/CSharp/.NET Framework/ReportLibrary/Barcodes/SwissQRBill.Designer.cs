
namespace Telerik.Reporting.Examples.CSharp.Barcodes
{
    using System.Drawing.Printing;
    using Telerik.Reporting.Drawing;

    partial class SwissQRBill
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwissQRBill));
            Telerik.Reporting.DataColumn dataColumn1 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn2 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn3 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn4 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn5 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn6 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn7 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn8 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn9 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn10 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn11 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn12 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn13 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn14 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn15 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn16 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn17 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn18 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn19 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn20 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn21 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.DataColumn dataColumn22 = new Telerik.Reporting.DataColumn();
            Telerik.Reporting.Drawing.FormattingRule formattingRule1 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule2 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule3 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule4 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Barcodes.SwissQRCodeEncoder swissQRCodeEncoder1 = new Telerik.Reporting.Barcodes.SwissQRCodeEncoder();
            Telerik.Reporting.Drawing.FormattingRule formattingRule5 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule6 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule7 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule8 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.FormattingRule formattingRule9 = new Telerik.Reporting.Drawing.FormattingRule();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule5 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule6 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule7 = new Telerik.Reporting.Drawing.StyleRule();
            this.billData = new Telerik.Reporting.CsvDataSource();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.panelReceipt = new Telerik.Reporting.Panel();
            this.txtReceiptLabel = new Telerik.Reporting.TextBox();
            this.txtReceiptAccountLabel = new Telerik.Reporting.TextBox();
            this.txtReceiptAccount = new Telerik.Reporting.TextBox();
            this.txtReceiptCreditorName = new Telerik.Reporting.TextBox();
            this.txtReceiptCreditorStreetAndHouseNumber = new Telerik.Reporting.TextBox();
            this.txtReceiptCreditorZipCodeAndCity = new Telerik.Reporting.TextBox();
            this.panelReceiptReferenceDebtorPlaceholder = new Telerik.Reporting.Panel();
            this.panelReceiptReference = new Telerik.Reporting.Panel();
            this.txtReceiptReferenceLabel = new Telerik.Reporting.TextBox();
            this.txtReceiptReference = new Telerik.Reporting.TextBox();
            this.txtReceiptPayableByLabel = new Telerik.Reporting.TextBox();
            this.panelReceiptDebtorFields = new Telerik.Reporting.Panel();
            this.txtReceiptDebtorName = new Telerik.Reporting.TextBox();
            this.txtReceiptDebtorStreetAndHouseNumber = new Telerik.Reporting.TextBox();
            this.txtReceiptDebtorZipCodeAndCity = new Telerik.Reporting.TextBox();
            this.pictureBoxReceiptPayableByMissing = new Telerik.Reporting.PictureBox();
            this.panelReceiptCurrencyAmount = new Telerik.Reporting.Panel();
            this.txtReceiptCurrencyLabel = new Telerik.Reporting.TextBox();
            this.txtReceiptCurrency = new Telerik.Reporting.TextBox();
            this.txtReceiptAmountLabel = new Telerik.Reporting.TextBox();
            this.txtReceiptAmount = new Telerik.Reporting.TextBox();
            this.pictureBoxReceiptAmountMissing = new Telerik.Reporting.PictureBox();
            this.txtReceiptAcceptancePoint = new Telerik.Reporting.TextBox();
            this.panelPayment = new Telerik.Reporting.Panel();
            this.txtPaymentLabel = new Telerik.Reporting.TextBox();
            this.barcodeSwissQR = new Telerik.Reporting.Barcode();
            this.txtPaymentCurrencyLabel = new Telerik.Reporting.TextBox();
            this.txtPaymentCurrency = new Telerik.Reporting.TextBox();
            this.txtPaymentAmountLabel = new Telerik.Reporting.TextBox();
            this.panelPaymentAmount = new Telerik.Reporting.Panel();
            this.txtPaymentAmount = new Telerik.Reporting.TextBox();
            this.pictureBoxPaymentAmountMissing = new Telerik.Reporting.PictureBox();
            this.txtPaymentAccountLabel = new Telerik.Reporting.TextBox();
            this.txtPaymentCreditorIBAN = new Telerik.Reporting.TextBox();
            this.txtPaymentCreditorName = new Telerik.Reporting.TextBox();
            this.txtPaymentCreditorStreetAndHouseNumber = new Telerik.Reporting.TextBox();
            this.txtPaymentCreditorZipCodeAndCity = new Telerik.Reporting.TextBox();
            this.panelPaymentReference = new Telerik.Reporting.Panel();
            this.txtPaymentReferenceLabel = new Telerik.Reporting.TextBox();
            this.txtPaymentReference = new Telerik.Reporting.TextBox();
            this.panelPaymentAdditionalInformation = new Telerik.Reporting.Panel();
            this.txtPaymentAdditionalInformationLabel = new Telerik.Reporting.TextBox();
            this.txtPaymentAdditionalInfo = new Telerik.Reporting.TextBox();
            this.txtPaymentPayableByLabel = new Telerik.Reporting.TextBox();
            this.panelPaymentDebtor = new Telerik.Reporting.Panel();
            this.panelPaymentDebtorFields = new Telerik.Reporting.Panel();
            this.txtPaymentDebtorName = new Telerik.Reporting.TextBox();
            this.txtPaymentDebtorStreetAndHouseNumber = new Telerik.Reporting.TextBox();
            this.txtPaymentDebtorZipCodeAndCity = new Telerik.Reporting.TextBox();
            this.pictureBoxPaymentPayableByMissing = new Telerik.Reporting.PictureBox();
            this.pictureBoxScissors = new Telerik.Reporting.PictureBox();
            this.reportHeaderSection1 = new Telerik.Reporting.ReportHeaderSection();
            this.panelReportHeader = new Telerik.Reporting.Panel();
            this.pictureBoxReportLogo = new Telerik.Reporting.PictureBox();
            this.txtReportTitle = new Telerik.Reporting.TextBox();
            this.htmlTextBox1 = new Telerik.Reporting.HtmlTextBox();
            this.htmlTextBox2 = new Telerik.Reporting.HtmlTextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // billData
            // 
            this.billData.CalculatedFields.Add(new Telerik.Reporting.CalculatedField("FormattedReference", typeof(string), resources.GetString("billData.CalculatedFields")));
            this.billData.CalculatedFields.Add(new Telerik.Reporting.CalculatedField("HasReference", typeof(bool), "=If(IsNull(Fields.Reference, \"\") = \"\", false, true)"));
            this.billData.CalculatedFields.Add(new Telerik.Reporting.CalculatedField("HasAdditionalInformation", typeof(bool), "=If(IsNull(Fields.AdditionalInformation, \"\") = \"\", false, true)"));
            this.billData.CalculatedFields.Add(new Telerik.Reporting.CalculatedField("HasDebtor", typeof(bool), "=If(IsNull(Fields.DebtorName, \"\") = \"\", false, true)"));
            this.billData.CalculatedFields.Add(new Telerik.Reporting.CalculatedField("HasAmount", typeof(bool), "=If(CStr(IsNull(Fields.Amount, \"\")) = \"\", false, true)"));
            dataColumn1.Name = "CreditorIBAN";
            dataColumn2.Name = "CreditorIBANType";
            dataColumn3.Name = "CreditorName";
            dataColumn4.Name = "CreditorCountry";
            dataColumn5.Name = "CreditorZipCode";
            dataColumn6.Name = "CreditorCity";
            dataColumn7.Name = "CreditorStreet";
            dataColumn8.Name = "CreditorHouseNumber";
            dataColumn9.Name = "DebtorName";
            dataColumn10.Name = "DebtorCountry";
            dataColumn11.Name = "DebtorZipCode";
            dataColumn12.Name = "DebtorCity";
            dataColumn13.Name = "DebtorStreet";
            dataColumn14.Name = "DebtorHouseNumber";
            dataColumn15.Name = "Currency";
            dataColumn16.Name = "Amount";
            dataColumn16.Type = Telerik.Reporting.SimpleType.Float;
            dataColumn17.Name = "Reference";
            dataColumn18.Name = "ReferenceType";
            dataColumn19.Name = "AdditionalInformation";
            dataColumn20.Name = "AlternativeProcedure1";
            dataColumn21.Name = "AlternativeProcedure2";
            dataColumn22.Name = "StructuredBillInformation";
            this.billData.Columns.Add(dataColumn1);
            this.billData.Columns.Add(dataColumn2);
            this.billData.Columns.Add(dataColumn3);
            this.billData.Columns.Add(dataColumn4);
            this.billData.Columns.Add(dataColumn5);
            this.billData.Columns.Add(dataColumn6);
            this.billData.Columns.Add(dataColumn7);
            this.billData.Columns.Add(dataColumn8);
            this.billData.Columns.Add(dataColumn9);
            this.billData.Columns.Add(dataColumn10);
            this.billData.Columns.Add(dataColumn11);
            this.billData.Columns.Add(dataColumn12);
            this.billData.Columns.Add(dataColumn13);
            this.billData.Columns.Add(dataColumn14);
            this.billData.Columns.Add(dataColumn15);
            this.billData.Columns.Add(dataColumn16);
            this.billData.Columns.Add(dataColumn17);
            this.billData.Columns.Add(dataColumn18);
            this.billData.Columns.Add(dataColumn19);
            this.billData.Columns.Add(dataColumn20);
            this.billData.Columns.Add(dataColumn21);
            this.billData.Columns.Add(dataColumn22);
            this.billData.FieldSeparators = new char[] {
        '\t'};
            this.billData.HasHeaders = true;
            this.billData.Name = "billData";
            this.billData.RecordSeparators = new char[] {
        '\r',
        '\n'};
            this.billData.Source = resources.GetString("billData.Source");
            // 
            // detailSection1
            // 
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(10.5D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panelReceipt,
            this.panelPayment,
            this.pictureBoxScissors});
            this.detailSection1.Name = "detailSection1";
            // 
            // panelReceipt
            // 
            this.panelReceipt.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtReceiptLabel,
            this.txtReceiptAccountLabel,
            this.txtReceiptAccount,
            this.txtReceiptCreditorName,
            this.txtReceiptCreditorStreetAndHouseNumber,
            this.txtReceiptCreditorZipCodeAndCity,
            this.panelReceiptReferenceDebtorPlaceholder,
            this.panelReceiptCurrencyAmount,
            this.pictureBoxReceiptAmountMissing,
            this.txtReceiptAcceptancePoint});
            this.panelReceipt.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.panelReceipt.Name = "panelReceipt";
            this.panelReceipt.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(62D), Telerik.Reporting.Drawing.Unit.Mm(105D));
            // 
            // txtReceiptLabel
            // 
            this.txtReceiptLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.txtReceiptLabel.Name = "txtReceiptLabel";
            this.txtReceiptLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(7D));
            this.txtReceiptLabel.StyleName = "Titles";
            this.txtReceiptLabel.Value = "Receipt";
            // 
            // txtReceiptAccountLabel
            // 
            this.txtReceiptAccountLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.txtReceiptAccountLabel.Name = "txtReceiptAccountLabel";
            this.txtReceiptAccountLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptAccountLabel.StyleName = "ReceiptLabels";
            this.txtReceiptAccountLabel.Value = "Account / Payable to";
            // 
            // txtReceiptAccount
            // 
            this.txtReceiptAccount.CanGrow = false;
            this.txtReceiptAccount.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(15D));
            this.txtReceiptAccount.Name = "txtReceiptAccount";
            this.txtReceiptAccount.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptAccount.StyleName = "ReceiptDataFields";
            this.txtReceiptAccount.Value = "=Fields.CreditorIBAN";
            // 
            // txtReceiptCreditorName
            // 
            this.txtReceiptCreditorName.CanGrow = false;
            this.txtReceiptCreditorName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(18D));
            this.txtReceiptCreditorName.Name = "txtReceiptCreditorName";
            this.txtReceiptCreditorName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptCreditorName.StyleName = "ReceiptDataFields";
            this.txtReceiptCreditorName.Value = "= Fields.CreditorName";
            // 
            // txtReceiptCreditorStreetAndHouseNumber
            // 
            this.txtReceiptCreditorStreetAndHouseNumber.CanGrow = false;
            this.txtReceiptCreditorStreetAndHouseNumber.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(22D));
            this.txtReceiptCreditorStreetAndHouseNumber.Name = "txtReceiptCreditorStreetAndHouseNumber";
            this.txtReceiptCreditorStreetAndHouseNumber.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptCreditorStreetAndHouseNumber.StyleName = "ReceiptDataFields";
            this.txtReceiptCreditorStreetAndHouseNumber.Value = "= Trim(Format(\'{0} {1}\', Fields.CreditorStreet, Fields.CreditorHouseNumber))";
            // 
            // txtReceiptCreditorZipCodeAndCity
            // 
            this.txtReceiptCreditorZipCodeAndCity.CanGrow = false;
            this.txtReceiptCreditorZipCodeAndCity.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(25D));
            this.txtReceiptCreditorZipCodeAndCity.Name = "txtReceiptCreditorZipCodeAndCity";
            this.txtReceiptCreditorZipCodeAndCity.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptCreditorZipCodeAndCity.StyleName = "ReceiptDataFields";
            this.txtReceiptCreditorZipCodeAndCity.Value = "=Trim(Format(\'{0} {1}\', Fields.CreditorZipCode, Fields.CreditorCity))";
            // 
            // panelReceiptReferenceDebtorPlaceholder
            // 
            this.panelReceiptReferenceDebtorPlaceholder.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panelReceiptReference,
            this.txtReceiptPayableByLabel,
            this.panelReceiptDebtorFields,
            this.pictureBoxReceiptPayableByMissing});
            this.panelReceiptReferenceDebtorPlaceholder.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(32D));
            this.panelReceiptReferenceDebtorPlaceholder.Name = "panelReceiptReferenceDebtorPlaceholder";
            this.panelReceiptReferenceDebtorPlaceholder.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(33D));
            // 
            // panelReceiptReference
            // 
            this.panelReceiptReference.CanShrink = true;
            formattingRule1.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasReference", Telerik.Reporting.FilterOperator.Equal, "False"));
            formattingRule1.Style.Visible = false;
            this.panelReceiptReference.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule1});
            this.panelReceiptReference.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtReceiptReferenceLabel,
            this.txtReceiptReference});
            this.panelReceiptReference.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.panelReceiptReference.Name = "panelReceiptReference";
            this.panelReceiptReference.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            // 
            // txtReceiptReferenceLabel
            // 
            this.txtReceiptReferenceLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtReceiptReferenceLabel.Name = "txtReceiptReferenceLabel";
            this.txtReceiptReferenceLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptReferenceLabel.StyleName = "ReceiptLabels";
            this.txtReceiptReferenceLabel.Value = "Reference";
            // 
            // txtReceiptReference
            // 
            this.txtReceiptReference.CanGrow = false;
            this.txtReceiptReference.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptReference.Name = "txtReceiptReference";
            this.txtReceiptReference.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptReference.StyleName = "ReceiptDataFields";
            this.txtReceiptReference.Value = "= Fields.FormattedReference";
            // 
            // txtReceiptPayableByLabel
            // 
            this.txtReceiptPayableByLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.txtReceiptPayableByLabel.Name = "txtReceiptPayableByLabel";
            this.txtReceiptPayableByLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptPayableByLabel.StyleName = "ReceiptLabels";
            this.txtReceiptPayableByLabel.Value = "Payable by";
            // 
            // panelReceiptDebtorFields
            // 
            this.panelReceiptDebtorFields.CanShrink = true;
            formattingRule2.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "False"));
            formattingRule2.Style.Visible = false;
            this.panelReceiptDebtorFields.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule2});
            this.panelReceiptDebtorFields.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtReceiptDebtorName,
            this.txtReceiptDebtorStreetAndHouseNumber,
            this.txtReceiptDebtorZipCodeAndCity});
            this.panelReceiptDebtorFields.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(13D));
            this.panelReceiptDebtorFields.Name = "panelReceiptDebtorFields";
            this.panelReceiptDebtorFields.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(9D));
            // 
            // txtReceiptDebtorName
            // 
            this.txtReceiptDebtorName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtReceiptDebtorName.Name = "txtReceiptDebtorName";
            this.txtReceiptDebtorName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptDebtorName.StyleName = "ReceiptDataFields";
            this.txtReceiptDebtorName.Value = "= Fields.DebtorName";
            // 
            // txtReceiptDebtorStreetAndHouseNumber
            // 
            this.txtReceiptDebtorStreetAndHouseNumber.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptDebtorStreetAndHouseNumber.Name = "txtReceiptDebtorStreetAndHouseNumber";
            this.txtReceiptDebtorStreetAndHouseNumber.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptDebtorStreetAndHouseNumber.StyleName = "ReceiptDataFields";
            this.txtReceiptDebtorStreetAndHouseNumber.Value = "= Trim(Format(\'{0} {1}\', Fields.DebtorStreet, Fields.DebtorHouseNumber))";
            // 
            // txtReceiptDebtorZipCodeAndCity
            // 
            this.txtReceiptDebtorZipCodeAndCity.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(6D));
            this.txtReceiptDebtorZipCodeAndCity.Name = "txtReceiptDebtorZipCodeAndCity";
            this.txtReceiptDebtorZipCodeAndCity.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(57D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptDebtorZipCodeAndCity.StyleName = "ReceiptDataFields";
            this.txtReceiptDebtorZipCodeAndCity.Value = "=Trim(Format(\'{0} {1}\', Fields.DebtorZipCode, Fields.DebtorCity))";
            // 
            // pictureBoxReceiptPayableByMissing
            // 
            this.pictureBoxReceiptPayableByMissing.Bindings.Add(new Telerik.Reporting.Binding("Height", "=\'22mm\'"));
            formattingRule3.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "True"));
            formattingRule3.Style.Visible = false;
            this.pictureBoxReceiptPayableByMissing.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule3});
            this.pictureBoxReceiptPayableByMissing.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(22D));
            this.pictureBoxReceiptPayableByMissing.MimeType = "";
            this.pictureBoxReceiptPayableByMissing.Name = "pictureBoxReceiptPayableByMissing";
            this.pictureBoxReceiptPayableByMissing.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(11D));
            this.pictureBoxReceiptPayableByMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBoxReceiptPayableByMissing.Value = resources.GetString("pictureBoxReceiptPayableByMissing.Value");
            // 
            // panelReceiptCurrencyAmount
            // 
            this.panelReceiptCurrencyAmount.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtReceiptCurrencyLabel,
            this.txtReceiptCurrency,
            this.txtReceiptAmountLabel,
            this.txtReceiptAmount});
            this.panelReceiptCurrencyAmount.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(70D));
            this.panelReceiptCurrencyAmount.Name = "panelReceiptCurrencyAmount";
            this.panelReceiptCurrencyAmount.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(34D), Telerik.Reporting.Drawing.Unit.Mm(6D));
            // 
            // txtReceiptCurrencyLabel
            // 
            this.txtReceiptCurrencyLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtReceiptCurrencyLabel.Name = "txtReceiptCurrencyLabel";
            this.txtReceiptCurrencyLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptCurrencyLabel.StyleName = "ReceiptLabels";
            this.txtReceiptCurrencyLabel.Value = "Currency";
            // 
            // txtReceiptCurrency
            // 
            this.txtReceiptCurrency.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptCurrency.Name = "txtReceiptCurrency";
            this.txtReceiptCurrency.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptCurrency.StyleName = "ReceiptDataFields";
            this.txtReceiptCurrency.Value = "= Fields.Currency";
            // 
            // txtReceiptAmountLabel
            // 
            this.txtReceiptAmountLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(14D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtReceiptAmountLabel.Name = "txtReceiptAmountLabel";
            this.txtReceiptAmountLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptAmountLabel.StyleName = "ReceiptLabels";
            this.txtReceiptAmountLabel.Value = "Amount";
            // 
            // txtReceiptAmount
            // 
            this.txtReceiptAmount.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(14D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptAmount.Name = "txtReceiptAmount";
            this.txtReceiptAmount.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptAmount.StyleName = "ReceiptDataFields";
            this.txtReceiptAmount.Value = "= Replace(FormatWithCulture(\"\", \"{0:N2}\", Fields.Amount), \",\", \" \")";
            // 
            // pictureBoxReceiptAmountMissing
            // 
            formattingRule4.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasAmount", Telerik.Reporting.FilterOperator.Equal, "True"));
            formattingRule4.Style.Visible = false;
            this.pictureBoxReceiptAmountMissing.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule4});
            this.pictureBoxReceiptAmountMissing.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(31D), Telerik.Reporting.Drawing.Unit.Mm(70D));
            this.pictureBoxReceiptAmountMissing.MimeType = "";
            this.pictureBoxReceiptAmountMissing.Name = "pictureBoxReceiptAmountMissing";
            this.pictureBoxReceiptAmountMissing.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(30D), Telerik.Reporting.Drawing.Unit.Mm(10D));
            this.pictureBoxReceiptAmountMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.pictureBoxReceiptAmountMissing.Style.BackgroundColor = System.Drawing.Color.White;
            this.pictureBoxReceiptAmountMissing.Value = resources.GetString("pictureBoxReceiptAmountMissing.Value");
            // 
            // txtReceiptAcceptancePoint
            // 
            this.txtReceiptAcceptancePoint.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(38D), Telerik.Reporting.Drawing.Unit.Mm(82D));
            this.txtReceiptAcceptancePoint.Name = "txtReceiptAcceptancePoint";
            this.txtReceiptAcceptancePoint.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(24D), Telerik.Reporting.Drawing.Unit.Mm(3D));
            this.txtReceiptAcceptancePoint.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(5D);
            this.txtReceiptAcceptancePoint.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.txtReceiptAcceptancePoint.StyleName = "ReceiptLabels";
            this.txtReceiptAcceptancePoint.Value = "Acceptance point";
            // 
            // panelPayment
            // 
            this.panelPayment.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtPaymentLabel,
            this.barcodeSwissQR,
            this.txtPaymentCurrencyLabel,
            this.txtPaymentCurrency,
            this.txtPaymentAmountLabel,
            this.panelPaymentAmount,
            this.txtPaymentAccountLabel,
            this.txtPaymentCreditorIBAN,
            this.txtPaymentCreditorName,
            this.txtPaymentCreditorStreetAndHouseNumber,
            this.txtPaymentCreditorZipCodeAndCity,
            this.panelPaymentReference,
            this.panelPaymentAdditionalInformation,
            this.txtPaymentPayableByLabel,
            this.panelPaymentDebtor});
            this.panelPayment.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(62D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(148D), Telerik.Reporting.Drawing.Unit.Mm(105D));
            this.panelPayment.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Dotted;
            // 
            // txtPaymentLabel
            // 
            this.txtPaymentLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.txtPaymentLabel.Name = "txtPaymentLabel";
            this.txtPaymentLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(51D), Telerik.Reporting.Drawing.Unit.Mm(7D));
            this.txtPaymentLabel.StyleName = "Titles";
            this.txtPaymentLabel.Value = "Payment part";
            // 
            // barcodeSwissQR
            // 
            swissQRCodeEncoder1.BillData.Creditor.Address.City = "= Fields.CreditorCity";
            swissQRCodeEncoder1.BillData.Creditor.Address.Country = "=Fields.CreditorCountry";
            swissQRCodeEncoder1.BillData.Creditor.Address.HouseNumber = "= Fields.CreditorHouseNumber";
            swissQRCodeEncoder1.BillData.Creditor.Address.PostalCode = "= Fields.CreditorZipCode";
            swissQRCodeEncoder1.BillData.Creditor.Address.Street = "= Fields.CreditorStreet";
            swissQRCodeEncoder1.BillData.Creditor.IBAN = "= Fields.CreditorIBAN";
            swissQRCodeEncoder1.BillData.Creditor.Name = "= Fields.CreditorName";
            swissQRCodeEncoder1.BillData.Debtor.Address.City = "= Fields.DebtorCity";
            swissQRCodeEncoder1.BillData.Debtor.Address.Country = "= Fields.DebtorCountry";
            swissQRCodeEncoder1.BillData.Debtor.Address.HouseNumber = "= Fields.DebtorHouseNumber";
            swissQRCodeEncoder1.BillData.Debtor.Address.PostalCode = "= Fields.DebtorZipCode";
            swissQRCodeEncoder1.BillData.Debtor.Address.Street = "= Fields.DebtorStreet";
            swissQRCodeEncoder1.BillData.Debtor.Name = "= Fields.DebtorName";
            swissQRCodeEncoder1.BillData.Payment.AdditionalInfo = "= Fields.AdditionalInformation";
            swissQRCodeEncoder1.BillData.Payment.AlternativeProcedure1 = "= Fields.AlternativeProcedure1";
            swissQRCodeEncoder1.BillData.Payment.AlternativeProcedure2 = "= Fields.AlternativeProcedure2";
            swissQRCodeEncoder1.BillData.Payment.Amount = "= Fields.Amount";
            swissQRCodeEncoder1.BillData.Payment.Currency = "= Fields.Currency";
            swissQRCodeEncoder1.BillData.Payment.Reference = "= Fields.Reference";
            swissQRCodeEncoder1.BillData.Payment.ReferenceType = "= Fields.ReferenceType";
            swissQRCodeEncoder1.BillData.Payment.StructuredBillInfo = "= Fields.StructuredBillInformation";
            swissQRCodeEncoder1.ECI = Telerik.Reporting.Barcodes.QRCode.ECIMode.UTF8;
            swissQRCodeEncoder1.ErrorCorrectionLevel = Telerik.Reporting.Barcodes.QRCode.ErrorCorrectionLevel.M;
            this.barcodeSwissQR.Encoder = swissQRCodeEncoder1;
            this.barcodeSwissQR.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.barcodeSwissQR.Name = "barcodeSwissQR";
            this.barcodeSwissQR.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(56D));
            this.barcodeSwissQR.Stretch = false;
            // 
            // txtPaymentCurrencyLabel
            // 
            this.txtPaymentCurrencyLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(70D));
            this.txtPaymentCurrencyLabel.Name = "txtPaymentCurrencyLabel";
            this.txtPaymentCurrencyLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentCurrencyLabel.StyleName = "PaymentLabels";
            this.txtPaymentCurrencyLabel.Value = "Currency";
            // 
            // txtPaymentCurrency
            // 
            this.txtPaymentCurrency.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(74D));
            this.txtPaymentCurrency.Name = "txtPaymentCurrency";
            this.txtPaymentCurrency.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(14D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentCurrency.StyleName = "PaymentDataFields";
            this.txtPaymentCurrency.Value = "= Fields.Currency";
            // 
            // txtPaymentAmountLabel
            // 
            this.txtPaymentAmountLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(22D), Telerik.Reporting.Drawing.Unit.Mm(70D));
            this.txtPaymentAmountLabel.Name = "txtPaymentAmountLabel";
            this.txtPaymentAmountLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(28D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentAmountLabel.StyleName = "PaymentLabels";
            this.txtPaymentAmountLabel.Value = "Amount";
            // 
            // panelPaymentAmount
            // 
            this.panelPaymentAmount.CanShrink = true;
            this.panelPaymentAmount.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtPaymentAmount,
            this.pictureBoxPaymentAmountMissing});
            this.panelPaymentAmount.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(22D), Telerik.Reporting.Drawing.Unit.Mm(74D));
            this.panelPaymentAmount.Name = "panelPaymentAmount";
            this.panelPaymentAmount.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(34D), Telerik.Reporting.Drawing.Unit.Mm(19D));
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.CanShrink = true;
            this.txtPaymentAmount.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(28D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentAmount.StyleName = "PaymentDataFields";
            this.txtPaymentAmount.Value = "= Replace(FormatWithCulture(\"\", \"{0:N2}\", Fields.Amount), \",\", \" \")";
            // 
            // pictureBoxPaymentAmountMissing
            // 
            formattingRule5.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasAmount", Telerik.Reporting.FilterOperator.Equal, "True"));
            formattingRule5.Style.Visible = false;
            this.pictureBoxPaymentAmountMissing.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule5});
            this.pictureBoxPaymentAmountMissing.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.pictureBoxPaymentAmountMissing.MimeType = "";
            this.pictureBoxPaymentAmountMissing.Name = "pictureBoxPaymentAmountMissing";
            this.pictureBoxPaymentAmountMissing.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(34D), Telerik.Reporting.Drawing.Unit.Mm(15D));
            this.pictureBoxPaymentAmountMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.pictureBoxPaymentAmountMissing.Style.BackgroundColor = System.Drawing.Color.White;
            this.pictureBoxPaymentAmountMissing.Value = resources.GetString("pictureBoxPaymentAmountMissing.Value");
            // 
            // txtPaymentAccountLabel
            // 
            this.txtPaymentAccountLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.txtPaymentAccountLabel.Name = "txtPaymentAccountLabel";
            this.txtPaymentAccountLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentAccountLabel.StyleName = "PaymentLabels";
            this.txtPaymentAccountLabel.Value = "Account / Payable to";
            // 
            // txtPaymentCreditorIBAN
            // 
            this.txtPaymentCreditorIBAN.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(9D));
            this.txtPaymentCreditorIBAN.Name = "txtPaymentCreditorIBAN";
            this.txtPaymentCreditorIBAN.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentCreditorIBAN.StyleName = "PaymentDataFields";
            this.txtPaymentCreditorIBAN.Value = "= Fields.CreditorIBAN";
            // 
            // txtPaymentCreditorName
            // 
            this.txtPaymentCreditorName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(13D));
            this.txtPaymentCreditorName.Name = "txtPaymentCreditorName";
            this.txtPaymentCreditorName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentCreditorName.StyleName = "PaymentDataFields";
            this.txtPaymentCreditorName.Value = "= Fields.CreditorName";
            // 
            // txtPaymentCreditorStreetAndHouseNumber
            // 
            this.txtPaymentCreditorStreetAndHouseNumber.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(17D));
            this.txtPaymentCreditorStreetAndHouseNumber.Name = "txtPaymentCreditorStreetAndHouseNumber";
            this.txtPaymentCreditorStreetAndHouseNumber.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentCreditorStreetAndHouseNumber.StyleName = "PaymentDataFields";
            this.txtPaymentCreditorStreetAndHouseNumber.Value = "= Trim(Format(\'{0} {1}\', Fields.CreditorStreet, Fields.CreditorHouseNumber))";
            // 
            // txtPaymentCreditorZipCodeAndCity
            // 
            this.txtPaymentCreditorZipCodeAndCity.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(21D));
            this.txtPaymentCreditorZipCodeAndCity.Name = "txtPaymentCreditorZipCodeAndCity";
            this.txtPaymentCreditorZipCodeAndCity.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentCreditorZipCodeAndCity.StyleName = "PaymentDataFields";
            this.txtPaymentCreditorZipCodeAndCity.Value = "=Trim(Format(\'{0} {1}\', Fields.CreditorZipCode, Fields.CreditorCity))";
            // 
            // panelPaymentReference
            // 
            this.panelPaymentReference.CanShrink = true;
            formattingRule6.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasReference", Telerik.Reporting.FilterOperator.Equal, "False"));
            formattingRule6.Style.Visible = false;
            this.panelPaymentReference.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule6});
            this.panelPaymentReference.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtPaymentReferenceLabel,
            this.txtPaymentReference});
            this.panelPaymentReference.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(29D));
            this.panelPaymentReference.Name = "panelPaymentReference";
            this.panelPaymentReference.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            // 
            // txtPaymentReferenceLabel
            // 
            this.txtPaymentReferenceLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtPaymentReferenceLabel.Name = "txtPaymentReferenceLabel";
            this.txtPaymentReferenceLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentReferenceLabel.StyleName = "PaymentLabels";
            this.txtPaymentReferenceLabel.Value = "Reference";
            // 
            // txtPaymentReference
            // 
            this.txtPaymentReference.CanGrow = false;
            this.txtPaymentReference.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentReference.Name = "txtPaymentReference";
            this.txtPaymentReference.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentReference.StyleName = "PaymentDataFields";
            this.txtPaymentReference.Value = "= Fields.FormattedReference";
            // 
            // panelPaymentAdditionalInformation
            // 
            this.panelPaymentAdditionalInformation.CanShrink = true;
            formattingRule7.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasAdditionalInformation", Telerik.Reporting.FilterOperator.Equal, "False"));
            formattingRule7.Style.Visible = false;
            this.panelPaymentAdditionalInformation.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule7});
            this.panelPaymentAdditionalInformation.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtPaymentAdditionalInformationLabel,
            this.txtPaymentAdditionalInfo});
            this.panelPaymentAdditionalInformation.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(41D));
            this.panelPaymentAdditionalInformation.Name = "panelPaymentAdditionalInformation";
            this.panelPaymentAdditionalInformation.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            // 
            // txtPaymentAdditionalInformationLabel
            // 
            this.txtPaymentAdditionalInformationLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtPaymentAdditionalInformationLabel.Name = "txtPaymentAdditionalInformationLabel";
            this.txtPaymentAdditionalInformationLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentAdditionalInformationLabel.StyleName = "PaymentLabels";
            this.txtPaymentAdditionalInformationLabel.Value = "Additional information";
            // 
            // txtPaymentAdditionalInfo
            // 
            this.txtPaymentAdditionalInfo.CanGrow = false;
            this.txtPaymentAdditionalInfo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentAdditionalInfo.Name = "txtPaymentAdditionalInfo";
            this.txtPaymentAdditionalInfo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentAdditionalInfo.StyleName = "PaymentDataFields";
            this.txtPaymentAdditionalInfo.Value = "= Fields.AdditionalInformation";
            // 
            // txtPaymentPayableByLabel
            // 
            this.txtPaymentPayableByLabel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(53D));
            this.txtPaymentPayableByLabel.Name = "txtPaymentPayableByLabel";
            this.txtPaymentPayableByLabel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentPayableByLabel.StyleName = "PaymentLabels";
            this.txtPaymentPayableByLabel.Value = "Payable by";
            // 
            // panelPaymentDebtor
            // 
            this.panelPaymentDebtor.CanShrink = true;
            this.panelPaymentDebtor.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panelPaymentDebtorFields,
            this.pictureBoxPaymentPayableByMissing});
            this.panelPaymentDebtor.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(56D), Telerik.Reporting.Drawing.Unit.Mm(57D));
            this.panelPaymentDebtor.Name = "panelPaymentDebtor";
            this.panelPaymentDebtor.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(37D));
            // 
            // panelPaymentDebtorFields
            // 
            this.panelPaymentDebtorFields.CanShrink = true;
            formattingRule8.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "False"));
            formattingRule8.Style.Visible = false;
            this.panelPaymentDebtorFields.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule8});
            this.panelPaymentDebtorFields.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.txtPaymentDebtorName,
            this.txtPaymentDebtorStreetAndHouseNumber,
            this.txtPaymentDebtorZipCodeAndCity});
            this.panelPaymentDebtorFields.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.panelPaymentDebtorFields.Name = "panelPaymentDebtorFields";
            this.panelPaymentDebtorFields.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            // 
            // txtPaymentDebtorName
            // 
            this.txtPaymentDebtorName.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtPaymentDebtorName.Name = "txtPaymentDebtorName";
            this.txtPaymentDebtorName.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentDebtorName.StyleName = "PaymentDataFields";
            this.txtPaymentDebtorName.Value = "= Fields.DebtorName";
            // 
            // txtPaymentDebtorStreetAndHouseNumber
            // 
            this.txtPaymentDebtorStreetAndHouseNumber.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentDebtorStreetAndHouseNumber.Name = "txtPaymentDebtorStreetAndHouseNumber";
            this.txtPaymentDebtorStreetAndHouseNumber.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentDebtorStreetAndHouseNumber.StyleName = "PaymentDataFields";
            this.txtPaymentDebtorStreetAndHouseNumber.Value = "= Trim(Format(\'{0} {1}\', Fields.DebtorStreet, Fields.DebtorHouseNumber))";
            // 
            // txtPaymentDebtorZipCodeAndCity
            // 
            this.txtPaymentDebtorZipCodeAndCity.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(8D));
            this.txtPaymentDebtorZipCodeAndCity.Name = "txtPaymentDebtorZipCodeAndCity";
            this.txtPaymentDebtorZipCodeAndCity.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(90D), Telerik.Reporting.Drawing.Unit.Mm(4D));
            this.txtPaymentDebtorZipCodeAndCity.StyleName = "PaymentDataFields";
            this.txtPaymentDebtorZipCodeAndCity.Value = "=Trim(Format(\'{0} {1}\', Fields.DebtorZipCode, Fields.DebtorCity))";
            // 
            // pictureBoxPaymentPayableByMissing
            // 
            formattingRule9.Filters.Add(new Telerik.Reporting.Filter("= Fields.HasDebtor", Telerik.Reporting.FilterOperator.Equal, "True"));
            formattingRule9.Style.Visible = false;
            this.pictureBoxPaymentPayableByMissing.ConditionalFormatting.AddRange(new Telerik.Reporting.Drawing.FormattingRule[] {
            formattingRule9});
            this.pictureBoxPaymentPayableByMissing.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(12D));
            this.pictureBoxPaymentPayableByMissing.MimeType = "";
            this.pictureBoxPaymentPayableByMissing.Name = "pictureBoxPaymentPayableByMissing";
            this.pictureBoxPaymentPayableByMissing.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(65D), Telerik.Reporting.Drawing.Unit.Mm(25D));
            this.pictureBoxPaymentPayableByMissing.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBoxPaymentPayableByMissing.Value = resources.GetString("pictureBoxPaymentPayableByMissing.Value");
            // 
            // pictureBoxScissors
            // 
            this.pictureBoxScissors.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(59.5D), Telerik.Reporting.Drawing.Unit.Mm(90D));
            this.pictureBoxScissors.MimeType = "";
            this.pictureBoxScissors.Name = "pictureBoxScissors";
            this.pictureBoxScissors.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(5D), Telerik.Reporting.Drawing.Unit.Mm(5D));
            this.pictureBoxScissors.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBoxScissors.Value = resources.GetString("pictureBoxScissors.Value");
            // 
            // reportHeaderSection1
            // 
            this.reportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(7.6D);
            this.reportHeaderSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.panelReportHeader,
            this.htmlTextBox1,
            this.htmlTextBox2});
            this.reportHeaderSection1.Name = "reportHeaderSection1";
            this.reportHeaderSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // panelReportHeader
            // 
            this.panelReportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pictureBoxReportLogo,
            this.txtReportTitle});
            this.panelReportHeader.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.panelReportHeader.Name = "panelReportHeader";
            this.panelReportHeader.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.panelReportHeader.Style.BorderColor.Default = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelReportHeader.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // pictureBoxReportLogo
            // 
            this.pictureBoxReportLogo.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.pictureBoxReportLogo.MimeType = "";
            this.pictureBoxReportLogo.Name = "pictureBoxReportLogo";
            this.pictureBoxReportLogo.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.pictureBoxReportLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.pictureBoxReportLogo.Style.Padding.Bottom = Telerik.Reporting.Drawing.Unit.Pixel(8D);
            this.pictureBoxReportLogo.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Pixel(8D);
            this.pictureBoxReportLogo.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Pixel(8D);
            this.pictureBoxReportLogo.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Pixel(8D);
            this.pictureBoxReportLogo.Value = resources.GetString("pictureBoxReportLogo.Value");
            // 
            // txtReportTitle
            // 
            this.txtReportTitle.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(20D), Telerik.Reporting.Drawing.Unit.Mm(0D));
            this.txtReportTitle.Name = "txtReportTitle";
            this.txtReportTitle.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(190D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.txtReportTitle.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReportTitle.Style.Font.Bold = true;
            this.txtReportTitle.Style.Font.Name = "Segoe UI Semibold";
            this.txtReportTitle.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(28D);
            this.txtReportTitle.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Mm(10D);
            this.txtReportTitle.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.txtReportTitle.Value = "Swiss QR-bill";
            // 
            // htmlTextBox1
            // 
            this.htmlTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(20D));
            this.htmlTextBox1.Name = "htmlTextBox1";
            this.htmlTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210D), Telerik.Reporting.Drawing.Unit.Mm(32D));
            this.htmlTextBox1.Style.Font.Name = "Segoe UI";
            this.htmlTextBox1.Value = resources.GetString("htmlTextBox1.Value");
            // 
            // htmlTextBox2
            // 
            this.htmlTextBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Mm(0D), Telerik.Reporting.Drawing.Unit.Mm(52D));
            this.htmlTextBox2.Name = "htmlTextBox2";
            this.htmlTextBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210D), Telerik.Reporting.Drawing.Unit.Mm(24D));
            this.htmlTextBox2.Style.Font.Name = "Segoe UI";
            this.htmlTextBox2.Value = resources.GetString("htmlTextBox2.Value");
            // 
            // SwissQRBill
            // 
            this.DataSource = this.billData;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detailSection1,
            this.reportHeaderSection1});
            this.Name = "SwissQRBill";
            this.PageSettings.ContinuousPaper = false;
            this.PageSettings.Landscape = true;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.PageSettings.PaperKind = PaperKind.Custom;
            this.PageSettings.PaperSize = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(105D), Telerik.Reporting.Drawing.Unit.Mm(210D));
            this.SkipBlankPages = false;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.PictureBox)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.TextBox), "Titles")});
            styleRule3.Style.Font.Bold = true;
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.TextBox), "ReceiptLabels")});
            styleRule4.Style.Font.Bold = true;
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(6D);
            styleRule5.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.TextBox), "ReceiptDataFields")});
            styleRule5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7D);
            styleRule6.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.TextBox), "PaymentLabels")});
            styleRule6.Style.Font.Bold = true;
            styleRule6.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule7.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector(typeof(Telerik.Reporting.TextBox), "PaymentDataFields")});
            styleRule7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4,
            styleRule5,
            styleRule6,
            styleRule7});
            this.UnitOfMeasure = Telerik.Reporting.Drawing.UnitType.Mm;
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(21D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private CsvDataSource billData;
        private DetailSection detailSection1;
        private Panel panelReceipt;
        private TextBox txtReceiptLabel;
        private TextBox txtReceiptAccountLabel;
        private TextBox txtReceiptAccount;
        private TextBox txtReceiptCreditorName;
        private TextBox txtReceiptCreditorStreetAndHouseNumber;
        private TextBox txtReceiptCreditorZipCodeAndCity;
        private Panel panelReceiptReferenceDebtorPlaceholder;
        private Panel panelReceiptReference;
        private TextBox txtReceiptReferenceLabel;
        private TextBox txtReceiptReference;
        private TextBox txtReceiptPayableByLabel;
        private Panel panelReceiptDebtorFields;
        private TextBox txtReceiptDebtorName;
        private TextBox txtReceiptDebtorStreetAndHouseNumber;
        private TextBox txtReceiptDebtorZipCodeAndCity;
        private PictureBox pictureBoxReceiptPayableByMissing;
        private Panel panelReceiptCurrencyAmount;
        private TextBox txtReceiptCurrencyLabel;
        private TextBox txtReceiptCurrency;
        private TextBox txtReceiptAmountLabel;
        private TextBox txtReceiptAmount;
        private PictureBox pictureBoxReceiptAmountMissing;
        private TextBox txtReceiptAcceptancePoint;
        private Panel panelPayment;
        private TextBox txtPaymentLabel;
        private Barcode barcodeSwissQR;
        private TextBox txtPaymentCurrencyLabel;
        private TextBox txtPaymentCurrency;
        private TextBox txtPaymentAmountLabel;
        private Panel panelPaymentAmount;
        private TextBox txtPaymentAmount;
        private PictureBox pictureBoxPaymentAmountMissing;
        private TextBox txtPaymentAccountLabel;
        private TextBox txtPaymentCreditorIBAN;
        private TextBox txtPaymentCreditorName;
        private TextBox txtPaymentCreditorStreetAndHouseNumber;
        private TextBox txtPaymentCreditorZipCodeAndCity;
        private Panel panelPaymentReference;
        private TextBox txtPaymentReferenceLabel;
        private TextBox txtPaymentReference;
        private Panel panelPaymentAdditionalInformation;
        private TextBox txtPaymentAdditionalInformationLabel;
        private TextBox txtPaymentAdditionalInfo;
        private TextBox txtPaymentPayableByLabel;
        private Panel panelPaymentDebtor;
        private Panel panelPaymentDebtorFields;
        private TextBox txtPaymentDebtorName;
        private TextBox txtPaymentDebtorStreetAndHouseNumber;
        private TextBox txtPaymentDebtorZipCodeAndCity;
        private PictureBox pictureBoxPaymentPayableByMissing;
        private PictureBox pictureBoxScissors;
        private ReportHeaderSection reportHeaderSection1;
        private Panel panelReportHeader;
        private PictureBox pictureBoxReportLogo;
        private TextBox txtReportTitle;
        private HtmlTextBox htmlTextBox1;
        private HtmlTextBox htmlTextBox2;
    }
}