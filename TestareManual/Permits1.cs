using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace TestareManual
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class Permits1
    {
        public Permits1()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataEpermits.csv", "DataEpermits#csv", DataAccessMethod.Sequential),
         DeploymentItem("DataEpermits.csv")]
        [TestMethod]
        public void Permit1()
        {
            Helper option = new Helper("Chrome", "http://epermits.alfa-xp.com/#/login", true, TestContext);

            //  Username
            option.InputText("loginForm_login", option.metadata("login"));

            //  Password
            option.InputText("loginForm_password", option.metadata("password"));

            //  Click button Login
            string login = "login-cmp > div > div > div > form > button";
            option.button(option.Text(login));

            //  Select Service
            string service = "ul.services-inline-list > li:nth-child(1) p";
            option.WaitForExists(service);
            option.links(option.Text(service));

            //  Click button Apply
            string Apply = "div.access-service > button";
            option.WaitForExists(Apply);
            option.button(option.Text(Apply));


            //  Service Location(Serviciul control)
            option.lookup("TeamId", 2);

            //  Applicant Type(Persoana Fizica)
            option.lookup("ApplyType", 1);

            //  IDNP
            option.InputText("IDNP", option.metadata("idnp"));

            //  IDNO
            option.InputText("IDNO", option.metadata("idno"));

            //  Represented by(IDNP)
            option.InputText("RepresentedIDNP", option.metadata("ridnp"));

            //  I Agree
            option.clickLabel("IsTermsAndConditions-label");

            //  Click Next
            string next = "div.basic-commands > button";
            option.button(option.Text(next));




            //  First name
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

            // Street(bd.Cuza - Voda)
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




            // Importer
            option.InputText("Importer", option.metadata("importer"));

            // Exporter
            option.InputText("Exporter", option.metadata("exporter"));

            // Importer address
            option.InputText("ImporterAddress", option.metadata("iAddress"));

            // Exporter address
            option.InputText("ExporterAddress", option.metadata("eAddress"));

            // Importer phone
            option.InputText("ImporterPhone", option.metadata("iPhone"));

            // Exporter phone
            option.InputText("ExporterPhone", option.metadata("ePhone"));

            // Importer fax
            option.InputText("ImporterFax", option.metadata("iFax"));

            // Exporter fax
            option.InputText("ExporterFax", option.metadata("eFax"));

            // Transporter
            option.InputText("Transporter", option.metadata("Transporter"));

            // Holder
            option.InputText("Holder", option.metadata("Holder"));

            // Expeditor
            option.InputText("Expeditor", option.metadata("Expeditor"));

            // Entry customs point(Post vamal Leușeni(PVFI, rutier))
            option.lookup("EntryCustomsPoint", 1);

            // Exit customs point(Post vamal Leușeni(PVFI, rutier))
            option.lookup("ExitCustomsPoint", 1);

            // Transit route in Moldova
            option.InputText("TransitRouteMoldova", option.metadata("TRMD"));

            // Transport type(Auto)
            option.lookup("TransportType", 1);

            // Additional Info
            option.InputText("OtherApplicantInformation", option.metadata("AddInfo"));

            // Validity term requested
            option.InputText("ValidityTermRequested", option.metadata("ValTReq"));

            // Importing Country(Africa de Sud)
            option.lookup("ImportingCountry", 2);

            // Paying Country(Afganistan)
            option.lookup("PayingCountry", 1);

            // Destination Country(Albania)
            option.lookup("DestinationCountry", 3);

            // Exporting Country(Africa de Sud)
            option.lookup("ExportingCountry", 2);



            //// Click Add Product
            // string addProduct = "div.panel-header.grid-header button";
            // option.WaitForExists(addProduct);
            // option.button(option.Text(addProduct));

            //// Quantity
            // option.InputText("Quantity", option.metadata("Quantify"));

            //// Control list number(Reactori nucleari)
            // option.lookup("ControlListNumber", 1);

            //// Product Name
            // option.InputText("CommercialName", option.metadata("CommName"));

            //// QuantityUnits(mie l)
            // option.lookup("QuantityUnits", 2);

            //// Code(ex.170199)
            // option.lookup("Code", 2);

            //// Value CIF
            // option.InputText("ValueCIF", option.metadata("ValueCIF"));

            // string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            // option.WaitForExists(saveCl);
            // option.button(option.Text(saveCl));


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

            // Sign the document button
            // string SignDoc = "div.ng-untouched.ng-pristine.ng-invalid > button.btn.btn-primary";
            // mmiper.WaitForExists(SignDoc);
            // button(option.Text(SignDoc));



            // Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next3);
            option.button(option.Text(next3));



            // I Agree
            // clickLabel("1");

            // Request Delivery
            option.lookup("RequestDelivery", 1);

            // Destination Locality
            // lookup("DeliveryTeamID", 1);

            // Destination Postal Code
            // InputText("DeliveryPostalCode", option.metadata("DesPoCode"));

            // Destination Address
            // InputText("DeliveryAddress", option.metadata("DestAddress"));

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



            // Click My Cabinet
            // string MyCab = "#main-menu > ul > div > navigator > li:nth-child(3)";
            // mmiper.WaitForExists(MyCab);
            // links(option.Text(MyCab));

            // Click Submitted
            // string Submitted = "#page-content > container-view > div:nth-child(2) > div > div > div > aside > div > nav > profile-tree > div.hidden-xs > ui-tree > ul > li:nth-child(2) > div > ui-tree > ul > li:nth-child(2)";
            // mmiper.WaitForExists(Submitted);
            // links(option.Text(Submitted));

            // MessageBox.Show(caseRember, "CaseNumber of Service");


            // MMIP 
            // Helper mmip = new Helper("Chrome", "http:// mmip.alfa-xp.com", true);

            // mmip.InputText("UserName", option.metadata("username"));
            // mmip.InputText("Password", option.metadata("pass"));
            // string btnOK = "#loginOK";
            // mmip.button(mmip.Text(btnOK));


            // string linkIncTaskSS = "div.fmNavTree ul > li:nth-child(1) > ul > li:nth-child(2) > a > label";
            // string linkIncTaskD = "div.fmNavTree ul > li:nth-child(1) > ul > li:nth-child(1) > a > label";
            // string btnNext1 = "div.mwnd-body > div:nth-child(2) > div:nth-child(4) > a:nth-child(2)";
            // string btnNext2 = "div.mwnd-body > div:nth-child(2) > div:nth-child(4) > a:nth-child(3)";
            // string btnNext3 = "div.mwnd-body > div:nth-child(2) > div:nth-child(4) > a:nth-child(1)";
            // string btnClose = "div.mwnd-body > div:nth-child(2) > a";
            // string Send = "div.mwnd-body > div:nth-child(2) > div:nth-child(1) div:nth-child(3) > a";
            // string Send1 = "div.mwnd-body > div:nth-child(2) > div:nth-child(1) > div > table > tbody > tr > td > div:nth-child(3) > a:nth-child(1)";
            // string supervisor = "div.wnd-pnl > div:nth-child(3) > div > label:nth-child(6)";
            // string specialist = "div.wnd-pnl > div:nth-child(3) > div > label:nth-child(5)";
            // string director = "div.wnd-pnl > div:nth-child(3) > div > label:nth-child(2)";


            // // Supervisor
            // mmip.clickChangeRole();
            // mmip.WaitForExists(supervisor);
            // mmip.changeRole(mmip.Text(supervisor));

            // mmip.WaitForExists(linkIncTaskSS);
            // mmip.choose(mmip.Text(linkIncTaskSS));

            // mmip.CaseClick(caseRember);

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn(mmip.Text(btnNext1));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn(mmip.Text(btnNext2));

            // mmip.WaitForExists(Send);
            // mmip.Modalbtn(mmip.Text(Send));

            // // Specialist
            // mmip.clickChangeRole();
            // mmip.WaitForExists(specialist);
            // mmip.changeRole(mmip.Text(specialist));

            // mmip.WaitForExists(linkIncTaskSS);
            // mmip.choose(mmip.Text(linkIncTaskSS));

            // mmip.CaseClick(caseRember);

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn(mmip.Text(btnNext1));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(Send1);
            // mmip.Modalbtn( mmip.Text(Send1));


            // mmip.CaseClick(caseRember);

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn( mmip.Text(btnNext1));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn( mmip.Text(btnNext1));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(Send);
            // mmip.Modalbtn( mmip.Text(Send));

            // // Supervisor
            // mmip.clickChangeRole();
            // mmip.WaitForExists(supervisor);
            // mmip.changeRole( mmip.Text(supervisor));

            // mmip.WaitForExists(linkIncTaskSS);
            // mmip.choose( mmip.Text(linkIncTaskSS));

            // mmip.CaseClick(caseRember);

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn( mmip.Text(btnNext1));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn( mmip.Text(btnNext1));

            // mmip.txtTextarea( option.metadata("txtarea1"));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(Send1);
            // mmip.Modalbtn( mmip.Text(Send1));

            // // Director
            // mmip.clickChangeRole();
            // mmip.WaitForExists(director);
            // mmip.changeRole( mmip.Text(director));

            // mmip.WaitForExists(linkIncTaskD);
            // mmip.choose( mmip.Text(linkIncTaskD));

            // mmip.CaseClick(caseRember);

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn( mmip.Text(btnNext1));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn( mmip.Text(btnNext1));

            // mmip.txtTextarea( option.metadata("txtarea2"));

            // mmip.WaitForExists(btnNext2);
            // mmip.Modalbtn( mmip.Text(btnNext2));

            // mmip.WaitForExists(Send1);
            // mmip.Modalbtn( mmip.Text(Send1));

            // mmip.WaitForExists(btnNext3);
            // mmip.Modalbtn( mmip.Text(btnNext3));

            // mmip.WaitForExists(btnNext1);
            // mmip.Modalbtn( mmip.Text(btnNext1));

            // mmip.WaitForExists(btnClose);
            // mmip.Modalbtn( mmip.Text(btnClose));


        }

        #region Additional test attributes

        //  You can use the following additional attributes as you write your tests:

        // // Use TestInitialize to run code before running each test 
        // (TestInitialize())
        // public void MyTestInitialize()
        // {        
        //     //  To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        // }

        // // Use TestCleanup to run code after each test has run
        // (TestCleanup())
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
