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
    public class Permits7
    {
        public Permits7()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataEpermits.csv", "DataEpermits#csv", DataAccessMethod.Sequential),
         DeploymentItem("DataEpermits.csv")]
        [TestMethod]
        public void Permit7()
        {
            Helper option = new Helper("Chrome", "http://epermits.alfa-xp.com/#/login", true, TestContext);

            // Username
            option.InputText("loginForm_login", option.metadata("login"));

            // Password
            option.InputText("loginForm_password", option.metadata("password"));

            // Click button Login
            string login = "login-cmp > div > div > div > form > button";
            option.button(option.Text(login));


            // Select Service
            string service = "ul.services-inline-list > li:nth-child(7) p";
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



            // Authorization number
            option.InputText("AuthorizationNumber", option.metadata("AuthNR"));

            // Authorization date
            option.DateSelect("AuthorizationDate", 13);

            // Period of export from
            option.DateSelect("PeriodExportFrom", 13);

            // Period of export to
            option.DateSelect("PeriodExportTo", 13);

            // Destination Company
            option.InputText("DestinationCompany", option.metadata("DestCompany"));

            // Number of Authorization for transportation
            option.InputText("NumberAuthTransportation", option.metadata("NrAuthTR"));

            // Destination Country
            option.lookup("DestinationCountry", 2);

            // Date of Authorization for transportation
            option.DateSelect("DateAuthTransportation", 23);

            // Customs point
            option.InputText("CustomsPoint", option.metadata("CsPoint"));

            // Chief of commercial unit
            option.InputText("CheifCommercialUnit", option.metadata("ChComUnit"));

            // Route
            option.InputText("Route", option.metadata("Route"));

            // Notes
            option.InputText("Notes", option.metadata("Notes"));

            // Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            option.WaitForExists(addProduct);
            option.button(option.Text(addProduct));



            // Product Name
            option.InputText("CommercialName", option.metadata("CommName"));

            // Package Name
            option.InputText("PackageName", option.metadata("PackageName"));

            // Quantity
            option.InputText("Quantity", option.metadata("Quantify"));

            // QuantityUnits
            option.lookup("QuantityUnits", 2);

            // ExportedBy
            option.InputText("ExportedBy", option.metadata("ExportBy"));

            // ProducedBy
            option.InputText("ProducedBy", option.metadata("ProdBy"));

            string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            option.WaitForExists(saveCl);
            option.button(option.Text(saveCl));



            // Click button Next
            string next1 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next1);
            option.button(option.Text(next1));

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


            // Click Next
            string Next4 = "div.process-buttons.pull-right > div > button.btn.btn-default.process-button.btn-primary";
            option.WaitForExists(Next4);
            option.button(option.Text(Next4));


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
