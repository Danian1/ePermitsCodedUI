using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using CodedUI.jQueryExtensions;
using System.IO;
using System.Windows.Forms;
using System;
using TestareManual.Properties;
using System.Drawing;

namespace TestareManual
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class Permits40
    {
        public Permits40()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataEpermits.csv", "DataEpermits#csv", DataAccessMethod.Sequential),
        DeploymentItem("DataEpermits.csv")]
        [TestMethod]
        public void Permit40()
        {
            Helper option = new Helper("Chrome", "http://epermits.alfa-xp.com/#/login", true, TestContext);

            // Username
            option.InputText("loginForm_login", option.metadata("login"));

            // Password
            option.InputText("loginForm_password", option.metadata("password"));

            // Click button Login
            string login = "login-cmp > div > div > div > form > button";
            option.button(option.Text(login));


            string page3 = "ul.ngx-pagination > li:nth-child(4) > a";
            option.WaitForExists(page3);
            option.Modalbtn(option.Text(page3));

            // Select Service
            string service = "ul.services-inline-list > li:nth-child(11) p";
            option.WaitForExists(service);
            option.links(option.Text(service));

            // Click button Apply
            string Apply = "div.access-service > button";
            option.WaitForExists(Apply);
            option.button(option.Text(Apply));



            // Service Location(Serviciul control)
            option.lookup("TeamId", 2);

            // Applicant Type(Persoana Fizica)
            option.lookup("ApplyType", 1);

            // IDNP
            option.InputText("IDNP", option.metadata("idnp"));

            // IDNO
            option.InputText("IDNO", option.metadata("idno"));

            // Represented by(IDNP)
            option.InputText("RepresentedIDNP", option.metadata("ridnp"));

            // I Agree
            option.clickLabel("IsTermsAndConditions-label");

            // Click Next
            string next = "div.basic-commands > button";
            option.button(option.Text(next));


            // First name
            option.InputText("ApplicantFirstName", option.metadata("Fname"));

            // Serial nr.passport
            option.InputText("Passport", option.metadata("Passport"));

            // Last name
            option.InputText("ApplicantLastName", option.metadata("Lname"));

            // Phone
            option.InputText("ApplicantPhone", option.metadata("Phone"));

            // Middle name
            option.InputText("ApplicantMiddleName", option.metadata("Mname"));

            // Email
            option.InputText("ApplicantEmail", option.metadata("Email"));

            // Birth date
            option.DateSelect("ApplicantBirthDate", 13);

            // Position
            option.InputText("ApplicantPosition", option.metadata("Position"));

            // Country(Afganistan)
            option.lookup("ApplicantAddressCountry", 1);

            // District(GAGAUZIA)
            option.lookup("ApplicantAddressDistrict", 1);

            // City(BAHMUT LOC.C.F.)
            option.lookup("ApplicantAddressCity", 1);

            // Sector(SEC.BOTANICA)
            option.lookup("ApplicantAddressSector", 1);

            // Street(bd.Constantin Negruzzi)
            option.lookup("ApplicantAddressStreet", 1);

            // house
            option.InputText("ApplicantAddressHouse", option.metadata("House"));

            // block
            option.InputText("ApplicantAddressBlock", option.metadata("Block"));

            // Floor
            option.InputText("ApplicantAddressFloor", option.metadata("Floor"));

            // Apartment
            option.InputText("ApplicantAddressApartment", option.metadata("Apartment"));

            // PostalCode
            option.InputText("ApplicantAddressPostalCode", option.metadata("PostalCode"));

            // Address Line 1 
            option.InputText("ApplicantAddressLine1", option.metadata("Adrline1"));

            // Address Line 2 
            option.InputText("ApplicantAddressLine2", option.metadata("Adrline2"));


            // Power of attorney 
            option.InputText("PowerOfAttorney", option.metadata("PowerATT"));

            // First Name
            option.InputText("RepresentativeFirstName", option.metadata("repFname"));

            // Representative Email
            option.InputText("RepresentativeEmail", option.metadata("repEmail"));

            // Last name
            option.InputText("RepresentativeLastName", option.metadata("repLname"));

            // Representative Phone 
            option.InputText("RepresentativePhone", option.metadata("repPhone"));

            // Representative IDNP
            option.InputText("RepresentativeIDNP", option.metadata("repIdnp"));

            // Representative Type(Administrator)
            option.Combobox("RepresentativeType", 0);

            // Country(Africa de Sud)
            option.lookup("RepresentativeAddressCountry", 2);

            // District(MUN.BALTI)
            option.lookup("RepresentativeAddressDistrict", 2);

            // City(BUCIUMENI LOC.ST.C.F.)
            option.lookup("RepresentativeAddressCity", 2);

            // Sector(SEC.BUIUCANI)
            option.lookup("RepresentativeAddressSector", 2);

            // Street(bd. Cuza-Voda)
            option.lookup("RepresentativeAddressStreet", 2);

            // house
            option.InputText("RepresentativeAddressHouse", option.metadata("repHouse"));

            // block
            option.InputText("RepresentativeAddressBlock", option.metadata("repBlock"));

            // Floor
            option.InputText("RepresentativeAddressFloor", option.metadata("repFloor"));

            // Apartment
            option.InputText("RepresentativeAddressApartment", option.metadata("repApart"));

            // Postal code 
            option.InputText("RepresentativeAddressPostalCode", option.metadata("repPcode"));

            // Address Entrance 
            option.InputText("RepresentativeAddressEntrance", option.metadata("AddrENT"));

            // Representative Address Line 1 
            option.InputText("RepresentativeAddressLine1", option.metadata("repAdrline1"));

            // Representative Address Line 2  
            option.InputText("RepresentativeAddressLine2", option.metadata("repAdrline2"));

            // Click button Next
            option.WaitForExists(next);
            option.button(option.Text(next));



            // Exporter
            option.InputText("Exporter", option.metadata("exporter"));

            // Exporter Reg. Date
            option.DateSelect("RegDateExporter", 4);

            // Exporter address 
            option.InputText("ExporterAddress", option.metadata("eAddress"));

            // Exporter Reg. No. 
            option.InputText("RegNumberExporter", option.metadata("regNrExp"));

            // Exporter phone
            option.InputText("ExporterPhone", option.metadata("ePhone"));

            // Registration Com. No.
            option.InputText("RegNumberCom", option.metadata("regNrCom"));

            // Exporter fax
            option.InputText("ExporterFax", option.metadata("eFax"));

            // Registration date at MEI
            option.DateSelect("RegDateME", 23);

            // Supplier 
            option.InputText("Supplier", option.metadata("supplier"));

            // External partner  
            option.InputText("ExternalPartner", option.metadata("ExPartner"));

            // Requested validity term, days 
            option.InputText("ValidityTermRequested", option.metadata("ValTReq"));

            // Entry customs point(Post vamal Leușeni (PVFI, rutier)) 
            option.lookup("ExitCustomsPoint", 1);

            // Additional Info
            option.InputText("OtherApplicantInformation", option.metadata("Other"));

            // Bank name
            option.InputText("BankName", option.metadata("BankName"));

            // Bank account number (IBAN)
            option.InputText("BankAccountNumber", option.metadata("BankAccNr"));

            // Bank code
            option.InputText("BankCode", option.metadata("BankCode"));

            // Paying Country(Afganistan)
            option.lookup("PayingCountry", 1);

            // Importing Country(Africa de Sud)
            option.lookup("ImportingCountry", 2);

            // Destination Country(Albania)
            option.lookup("DestinationCountry", 3);

            // Delivery conditions
            option.InputText("DeliveryConditions", option.metadata("DCondit"));

            // Conditions of payment
            option.InputText("PaymentConditions", option.metadata("PaymentCond"));

            // Payment currency
            option.lookup("PaymentCurrency", 1);

            // Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            option.WaitForExists(addProduct);
            option.button(option.Text(addProduct));

            // Quantity
            option.InputText("Quantity", option.metadata("Quantify"));

            // Control list number(Reactori nucleari)
            option.lookup("ControlListNumber", 1);

            // Product Name
            option.InputText("CommercialName", option.metadata("CommName"));

            // QuantityUnits(mie l)
            option.lookup("QuantityUnits", 2);

            // Code(ex.170199)
            option.lookup("Code", 2);

            // Value CIF
            option.InputText("ValueCIF", option.metadata("ValueCIF"));

            string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            option.WaitForExists(saveCl);
            option.button(option.Text(saveCl));

            // Click button Next
            string next1 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next1);
            option.button(option.Text(next1));


            // Click Button Edit(4)
            option.editBtn(4);

            // Select img and open
            option.selectIMG();

            // Title
            option.InputText("Title", option.metadata("Title"));

            // Click Save and Close
            string saveClose = "div.modal-footer div.basic-commands > button:nth-child(2)";
            option.WaitForExists(saveClose);
            option.button(option.Text(saveClose));



            // Click button Next
            string next2 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next2);
            option.button(option.Text(next2));

            // Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next3);
            option.button(option.Text(next3));


            // Request Delivery 
            option.lookup("RequestDelivery", 1);

            // Click Confirm
            string confirm = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(confirm);
            option.button(option.Text(confirm));


            // CaseRember
            string caseNr = "#CaseNumber";
            option.WaitForExists(caseNr);
            var caseRember = option.Value(caseNr);

            // Click Finish
            string finish = "div.basic-commands > button";
            option.WaitForExists(finish);
            option.button(option.Text(finish));


            // Click Confirm
            string confirm1 = "div.basic-commands > button";
            option.WaitForExists(confirm1);
            option.button(option.Text(confirm1));




        }

        #region Additional test attributes

        //  You can use the following additional attributes as you write your tests:

        // // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize()
        // {        
        //     //  To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        // }

        // // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup()
        // {        
        //     //  To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        // }

        #endregion

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
