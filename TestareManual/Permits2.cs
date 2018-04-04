using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using CodedUI.jQueryExtensions;

namespace TestareManual
{
    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class Permits2
    {
        public Permits2()
        {
            
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataEpermits.csv", "DataEpermits#csv", DataAccessMethod.Sequential),
         DeploymentItem("DataEpermits.csv"),
         TestMethod]
        public void Permit2()
        {
            Helper option = new Helper("Chrome", "http://epermits.alfa-xp.com/#/login", true);

            //Username
            option.InputText( "loginForm_login", TestContext.DataRow["login"].ToString());

            //Password
            option.InputText( "loginForm_password", TestContext.DataRow["password"].ToString());

            //Click button Login
            string login = "login-cmp > div > div > div > form > button";
            option.button( option.Text(login));

            //Select Service
            string service = "ul.services-inline-list > li:nth-child(2) p";
            option.WaitForExists(service);
            option.links( option.Text(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            option.WaitForExists(Apply);
             option.button( option.Text(Apply));

            //Service Location(Serviciul control)
            option.lookup( "TeamId", 2);

            //Applicant Type(Persoana Fizica)
            option.lookup( "ApplyType", 1);

            //IDNP
            option.InputText( "IDNP", TestContext.DataRow["idnp"].ToString());

            ////IDNO
            //option.InputText( "IDNO", TestContext.DataRow["idno"].ToString());

            //Represented by(IDNP)
            option.InputText( "RepresentedIDNP", TestContext.DataRow["ridnp"].ToString());

            //I Agree
            option.clickLabel( "IsTermsAndConditions-label");

            //Click Next
            string next = "div.basic-commands > button";
            option.button( option.Text(next));

            //******Individual*****Personal Data&Address************//

            //First name
            option.InputText( "ApplicantFirstName", TestContext.DataRow["Fname"].ToString());

            //Serial nr.passport
            option.InputText( "Passport", TestContext.DataRow["Passport"].ToString());

            //Last name
            option.InputText( "ApplicantLastName", TestContext.DataRow["Lname"].ToString());

            //Phone
            option.InputText( "ApplicantPhone", TestContext.DataRow["Phone"].ToString());

            //Middle name
            option.InputText( "ApplicantMiddleName", TestContext.DataRow["Mname"].ToString());

            //Email
            option.InputText( "ApplicantEmail", TestContext.DataRow["Email"].ToString());

            //Birth date
            option.DateSelect( "ApplicantBirthDate", 13);

            //Position
            option.InputText( "ApplicantPosition", TestContext.DataRow["Position"].ToString());

            //Country(Afganistan)
            option.lookup( "ApplicantAddressCountry", 1);

            //District(GAGAUZIA)
            option.lookup( "ApplicantAddressDistrict", 1);

            //City(BAHMUT LOC.C.F.)
            option.lookup( "ApplicantAddressCity", 1);

            //Sector(SEC.BOTANICA)
            option.lookup( "ApplicantAddressSector", 1);

            //Street(bd.Constantin Negruzzi)
            option.lookup( "ApplicantAddressStreet", 1);

            //house
            option.InputText( "ApplicantAddressHouse", TestContext.DataRow["House"].ToString());

            //block
            option.InputText( "ApplicantAddressBlock", TestContext.DataRow["Block"].ToString());

            //Floor
            option.InputText( "ApplicantAddressFloor", TestContext.DataRow["Floor"].ToString());

            //Apartment
            option.InputText( "ApplicantAddressApartment", TestContext.DataRow["Apartment"].ToString());

            //PostalCode
            option.InputText( "ApplicantAddressPostalCode", TestContext.DataRow["PostalCode"].ToString());

            //Address Line 1 
            option.InputText( "ApplicantAddressLine1", TestContext.DataRow["Adrline1"].ToString());

            //Address Line 2 
            option.InputText( "ApplicantAddressLine2", TestContext.DataRow["Adrline2"].ToString());

            //*******Representative  Data&Address*******//

            //Power of attorney 
            option.InputText( "PowerOfAttorney", TestContext.DataRow["PowerATT"].ToString());

            //First Name
            option.InputText( "RepresentativeFirstName", TestContext.DataRow["repFname"].ToString());

            //Representative Email
            option.InputText( "RepresentativeEmail", TestContext.DataRow["repEmail"].ToString());

            //Last name
            option.InputText( "RepresentativeLastName", TestContext.DataRow["repLname"].ToString());

            //Representative Phone 
            option.InputText( "RepresentativePhone", TestContext.DataRow["repPhone"].ToString());

            //Representative IDNP
            option.InputText( "RepresentativeIDNP", TestContext.DataRow["repIdnp"].ToString());

            //Representative Type(Administrator)
            option.Combobox( "RepresentativeType", 0);

            //Country(Africa de Sud)
            option.lookup( "RepresentativeAddressCountry", 2);

            //District(MUN.BALTI)
            option.lookup( "RepresentativeAddressDistrict", 2);

            //City(BUCIUMENI LOC.ST.C.F.)
            option.lookup( "RepresentativeAddressCity", 2);

            //Sector(SEC.BUIUCANI)
            option.lookup( "RepresentativeAddressSector", 2);

            //Street(bd. Cuza-Voda)
            option.lookup( "RepresentativeAddressStreet", 2);

            //house
            option.InputText( "RepresentativeAddressHouse", TestContext.DataRow["repHouse"].ToString());

            //block
            option.InputText( "RepresentativeAddressBlock", TestContext.DataRow["repBlock"].ToString());

            //Floor
            option.InputText( "RepresentativeAddressFloor", TestContext.DataRow["repFloor"].ToString());

            //Apartment
            option.InputText( "RepresentativeAddressApartment", TestContext.DataRow["repApart"].ToString());

            //Postal code 
            option.InputText( "RepresentativeAddressPostalCode", TestContext.DataRow["repPcode"].ToString());

            //Address Entrance 
            option.InputText( "RepresentativeAddressEntrance", TestContext.DataRow["AddrENT"].ToString());

            //Representative Address Line 1 
            option.InputText( "RepresentativeAddressLine1", TestContext.DataRow["repAdrline1"].ToString());

            //Representative Address Line 2  
            option.InputText( "RepresentativeAddressLine2", TestContext.DataRow["repAdrline2"].ToString());

            //Click button Next
            option.WaitForExists(next);
            option.button( option.Text(next));

            //******Input Permit Application Form************//

            //Importer
            option.InputText( "Importer", TestContext.DataRow["importer"].ToString());

            //Importer fax
            option.InputText( "ImporterFax", TestContext.DataRow["iFax"].ToString());

            //Importer address 
            option.InputText( "ImporterAddress", TestContext.DataRow["iAddress"].ToString());

            //Importer phone 
            option.InputText( "ImporterPhone", TestContext.DataRow["iPhone"].ToString());

            //Destination Company
            option.InputText( "DestinationCompany", TestContext.DataRow["DCompany"].ToString());

            //Destination Address
            option.InputText( "DestinationAddress", TestContext.DataRow["DAddress"].ToString());

            //Delivery conditions
            option.InputText( "DeliveryConditions", TestContext.DataRow["DCondit"].ToString());

            //Supplier 
            option.InputText( "Supplier", TestContext.DataRow["supplier"].ToString());

            //Entry customs point(Post vamal Leușeni (PVFI, rutier)) 
            option.lookup( "ExitCustomsPoint", 1);

            //External partner  
            option.InputText( "ExternalPartner", TestContext.DataRow["ExPartner"].ToString());

            //Requested validity term, days 
            option.InputText( "ValidityTermRequested", TestContext.DataRow["ValTReq"].ToString());

            //Additional Info
            option.InputText( "OtherApplicantInformation", TestContext.DataRow["Other"].ToString());


            //Registration number at exporter
            option.InputText( "RegNumberExporter", TestContext.DataRow["regNrExp"].ToString());

            //Registration date at exporter 
            option.DateSelect( "RegDateExporter", 13);

            //Registration number at MEI
            option.InputText( "RegNumberME", TestContext.DataRow["RegNrMEI"].ToString());

            //Registration date at MEI
            option.DateSelect( "RegDateME", 23);

            //Bank name
            option.InputText( "BankName", TestContext.DataRow["BankName"].ToString());

            //Bank code
            option.InputText( "BankCode", TestContext.DataRow["BankCode"].ToString());

            //Bank account number (IBAN)
            option.InputText( "BankAccountNumber", TestContext.DataRow["BankAccNr"].ToString());

            //Conditions of payment
            option.InputText( "PaymentConditions", TestContext.DataRow["PaymentCond"].ToString());

            //Payment currency
            option.lookup("PaymentCurrency", 1);

            //Exporting Country(Africa de Sud)
            option.lookup("ExportingCountry", 2);

            //Paying Country(Afganistan)
            option.lookup("PayingCountry", 1);

            //Destination Country(Albania)
            option.lookup("DestinationCountry", 3);

            //Origin country(Africa de Sud)
            option.lookup("OriginCountry", 2);


            //Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            option.WaitForExists(addProduct);
            option.button(option.Text(addProduct));

            //Quantity
            option.InputText("Quantity", TestContext.DataRow["Quantify"].ToString());

            //Control list number(Reactori nucleari)
            option.lookup("ControlListNumber", 1);

            //Product Name
            option.InputText("CommercialName", TestContext.DataRow["CommName"].ToString());

            //QuantityUnits(mie l)
            option.lookup("QuantityUnits", 2);

            //Code(ex.170199)
            option.lookup("Code", 2);

            //Value CIF
            option.InputText("ValueCIF", TestContext.DataRow["ValueCIF"].ToString());

            string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            option.WaitForExists(saveCl);
            option.button(option.Text(saveCl));

            Playback.Wait(1000);

            //Click button Next
            string next1 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next1);
            option.button( option.Text(next1));

            //*****Supporting Documents************//

            ////Click Button Edit(4)
            //option.editBtn( 4);

            ////Select img and open
            //option.selectIMG();

            ////title
            //option.InputText( "Title", TestContext.DataRow["Title"].ToString());

            ////Click Save and Close
            //string saveClose = "div.modal-footer div.basic-commands > button:nth-child(2)";
            //option.WaitForExists(saveClose);
            //option.button( option.Text(saveClose));


            //Click button Next
            string next2 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next2);
            option.button( option.Text(next2));

            //Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next3);
            option.button( option.Text(next3));

            //*********Confirm Application*************//

            Playback.Wait(2000);

            //Request Delivery 
            option.lookup( "RequestDelivery", 1);

            //Click Confirm
            string confirm = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(confirm);
            option.button( option.Text(confirm));

            //CaseRember
            string caseNr = "#CaseNumber";
            option.WaitForExists(caseNr);
            var caseRember = option.Value(caseNr);

            //Click Finish
            string finish = "div.basic-commands > button";
            option.WaitForExists(finish);
            option.button( option.Text(finish));

            //click Confirm
            string confirm1 = "div.basic-commands > button";
            option.WaitForExists(confirm1);
            option.button( option.Text(confirm1));

            //**************************************//


        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
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
