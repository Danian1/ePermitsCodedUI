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
            Helper option = new Helper("Chrome", "http://epermits.alfa-xp.com/#/login", true);

            //Username
            option.InputText("loginForm_login", TestContext.DataRow["login"].ToString());

            //Password
            option.InputText("loginForm_password", TestContext.DataRow["password"].ToString());

            //Click button Login
            string login = "login-cmp > div > div > div > form > button";
            option.button(option.Text(login));

            //Select Service
            string service = "ul.services-inline-list > li:nth-child(1) p";
            option.WaitForExists(service);
            option.links(option.Text(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            option.WaitForExists(Apply);
            option.button(option.Text(Apply));

            //Service Location(Serviciul control)
            option.lookup("TeamId", 2);

            //Applicant Type(Persoana Fizica)
            option.lookup("ApplyType", 1);

            //IDNP
            option.InputText("IDNP", TestContext.DataRow["idnp"].ToString());

            ////IDNO
            //option.InputText("IDNO", TestContext.DataRow["idno"].ToString());

            //Represented by(IDNP)
            option.InputText("RepresentedIDNP", TestContext.DataRow["ridnp"].ToString());

            //I Agree
            option.clickLabel("IsTermsAndConditions-label");

            //Click Next
            string next = "div.basic-commands > button";
            option.button(option.Text(next));

            //******Individual * ****Personal Data & Address * ***********//
            Playback.Wait(1000);

            //First name
            option.InputText("ApplicantFirstName", TestContext.DataRow["Fname"].ToString());

            //Serial nr.passport
            option.InputText("Passport", TestContext.DataRow["Passport"].ToString());

            //Last name
            option.InputText("ApplicantLastName", TestContext.DataRow["Lname"].ToString());

            //Phone
            option.InputText("ApplicantPhone", TestContext.DataRow["Phone"].ToString());

            //Middle name
            option.InputText("ApplicantMiddleName", TestContext.DataRow["Mname"].ToString());

            //Email
            option.InputText("ApplicantEmail", TestContext.DataRow["Email"].ToString());

            //Birth date
            option.DateSelect("ApplicantBirthDate", 13);

            //Position
            option.InputText("ApplicantPosition", TestContext.DataRow["Position"].ToString());

            //Country(Afganistan)
            option.lookup("ApplicantAddressCountry", 1);

            //District(GAGAUZIA)
            option.lookup("ApplicantAddressDistrict", 1);

            //City(BAHMUT LOC.C.F.)
            option.lookup("ApplicantAddressCity", 1);

            //Sector(SEC.BOTANICA)
            option.lookup("ApplicantAddressSector", 1);

            //Street(bd.Constantin Negruzzi)
            option.lookup("ApplicantAddressStreet", 1);

            //house
            option.InputText("ApplicantAddressHouse", TestContext.DataRow["House"].ToString());

            //block
            option.InputText("ApplicantAddressBlock", TestContext.DataRow["Block"].ToString());

            //Floor
            option.InputText("ApplicantAddressFloor", TestContext.DataRow["Floor"].ToString());

            //Apartment
            option.InputText("ApplicantAddressApartment", TestContext.DataRow["Apartment"].ToString());

            //PostalCode
            option.InputText("ApplicantAddressPostalCode", TestContext.DataRow["PostalCode"].ToString());

            //Address Line 1
            option.InputText("ApplicantAddressLine1", TestContext.DataRow["Adrline1"].ToString());

            //Address Line 2
            option.InputText("ApplicantAddressLine2", TestContext.DataRow["Adrline2"].ToString());

            //*******Representative  Data & Address * ******//

            //Power of attorney
            option.InputText("PowerOfAttorney", TestContext.DataRow["PowerATT"].ToString());

            //First Name
            option.InputText("RepresentativeFirstName", TestContext.DataRow["repFname"].ToString());

            //Representative Email
            option.InputText("RepresentativeEmail", TestContext.DataRow["repEmail"].ToString());

            //Last name
            option.InputText("RepresentativeLastName", TestContext.DataRow["repLname"].ToString());

            //Representative Phone
            option.InputText("RepresentativePhone", TestContext.DataRow["repPhone"].ToString());

            //Representative IDNP
            option.InputText("RepresentativeIDNP", TestContext.DataRow["repIdnp"].ToString());

            //Representative Type(Administrator)
            option.Combobox("RepresentativeType", 0);

            //Country(Africa de Sud)
            option.lookup("RepresentativeAddressCountry", 2);

            //District(MUN.BALTI)
            option.lookup("RepresentativeAddressDistrict", 2);

            //City(BUCIUMENI LOC.ST.C.F.)
            option.lookup("RepresentativeAddressCity", 2);

            //Sector(SEC.BUIUCANI)
            option.lookup("RepresentativeAddressSector", 2);

            //Street(bd.Cuza - Voda)
            option.lookup("RepresentativeAddressStreet", 2);

            //house
            option.InputText("RepresentativeAddressHouse", TestContext.DataRow["repHouse"].ToString());

            //block
            option.InputText("RepresentativeAddressBlock", TestContext.DataRow["repBlock"].ToString());

            //Floor
            option.InputText("RepresentativeAddressFloor", TestContext.DataRow["repFloor"].ToString());

            //Apartment
            option.InputText("RepresentativeAddressApartment", TestContext.DataRow["repApart"].ToString());

            //Postal code
            option.InputText("RepresentativeAddressPostalCode", TestContext.DataRow["repPcode"].ToString());

            //Address Entrance
            option.InputText("RepresentativeAddressEntrance", TestContext.DataRow["AddrENT"].ToString());

            //Representative Address Line 1
            option.InputText("RepresentativeAddressLine1", TestContext.DataRow["repAdrline1"].ToString());

            //Representative Address Line 2
            option.InputText("RepresentativeAddressLine2", TestContext.DataRow["repAdrline2"].ToString());

            //Click button Next
            option.WaitForExists(next);
            option.button(option.Text(next));

            //******Input Permit Application Form************//

            //Importer
            option.InputText("Importer", TestContext.DataRow["importer"].ToString());

            //Exporter
            option.InputText("Exporter", TestContext.DataRow["exporter"].ToString());

            //Importer address
            option.InputText("ImporterAddress", TestContext.DataRow["iAddress"].ToString());

            //Exporter address
            option.InputText("ExporterAddress", TestContext.DataRow["eAddress"].ToString());

            //Importer phone
            option.InputText("ImporterPhone", TestContext.DataRow["iPhone"].ToString());

            //Exporter phone
            option.InputText("ExporterPhone", TestContext.DataRow["ePhone"].ToString());

            //Importer fax
            option.InputText("ImporterFax", TestContext.DataRow["iFax"].ToString());

            //Exporter fax
            option.InputText("ExporterFax", TestContext.DataRow["eFax"].ToString());

            //Transporter
            option.InputText("Transporter", TestContext.DataRow["Transporter"].ToString());

            //Holder
            option.InputText("Holder", TestContext.DataRow["Holder"].ToString());

            //Expeditor
            option.InputText("Expeditor", TestContext.DataRow["Expeditor"].ToString());

            //Entry customs point(Post vamal Leușeni(PVFI, rutier))
            option.lookup("EntryCustomsPoint", 1);

            //Exit customs point(Post vamal Leușeni(PVFI, rutier))
            option.lookup("ExitCustomsPoint", 1);

            //Transit route in Moldova
            option.InputText("TransitRouteMoldova", TestContext.DataRow["TRMD"].ToString());

            //Transport type(Auto)
            option.lookup("TransportType", 1);

            //Additional Info
            option.InputText("OtherApplicantInformation", TestContext.DataRow["AddInfo"].ToString());

            //Validity term requested
            option.InputText("ValidityTermRequested", TestContext.DataRow["ValTReq"].ToString());

            //Importing Country(Africa de Sud)
            option.lookup("ImportingCountry", 2);

            //Paying Country(Afganistan)
            option.lookup("PayingCountry", 1);

            //Destination Country(Albania)
            option.lookup("DestinationCountry", 3);

            //Exporting Country(Africa de Sud)
            option.lookup("ExportingCountry", 2);

            //Click button Next
            string next1 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next1);
            option.button(option.Text(next1));

            //*****Supporting Documents************//

            //Click Button Edit(4)
            option.editBtn(4);

            //Select img and open
            option.selectIMG();

            //title
            option.InputText("Title", TestContext.DataRow["Title"].ToString());

            //Click Save and Close
            string saveClose = "div.modal-footer div.basic-commands > button:nth-child(2)";
            option.WaitForExists(saveClose);
            option.button(option.Text(saveClose));

            //Click button Next
            string next2 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next2);
            option.button(option.Text(next2));

            ////Sign the document button
            //string SignDoc = "div.ng-untouched.ng-pristine.ng-invalid > button.btn.btn-primary";
            //browser.WaitForExists(SignDoc);
            //button(option.Text(SignDoc));

            //Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next3);
            option.button(option.Text(next3));

            //*********Confirm Application*************//

            //Playback.Wait(2000);
            //I Agree
            //clickLabel("1");

            //Request Delivery
            option.lookup("RequestDelivery", 1);

            //Destination Locality
            //lookup("DeliveryTeamID", 1);

            //Destination Postal Code
            //InputText("DeliveryPostalCode", TestContext.DataRow["DesPoCode"].ToString());

            //Destination Address
            //InputText("DeliveryAddress", TestContext.DataRow["DestAddress"].ToString());

            //Click Confirm
            string confirm = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(confirm);
            option.button(option.Text(confirm));

            //CaseRember
            string caseNr = "#CaseNumber";
            option.WaitForExists(caseNr);
            var caseRember = option.Value(caseNr);

            //Click Finish
            string finish = "div.basic-commands > button";
            option.WaitForExists(finish);
            option.button(option.Text(finish));

            //Click Confirm
            string confirm1 = "div.basic-commands > button";
            option.WaitForExists(confirm1);
            option.button(option.Text(confirm1));

            //**************************************//

            ////Click My Cabinet
            //string MyCab = "#main-menu > ul > div > navigator > li:nth-child(3)";
            //browser.WaitForExists(MyCab);
            //links(option.Text(MyCab));

            ////Click Submitted
            //string Submitted = "#page-content > container-view > div:nth-child(2) > div > div > div > aside > div > nav > profile-tree > div.hidden-xs > ui-tree > ul > li:nth-child(2) > div > ui-tree > ul > li:nth-child(2)";
            //browser.WaitForExists(Submitted);
            //links(option.Text(Submitted));

            //Playback.Wait(5000);
            //MessageBox.Show(caseRember, "CaseNumber of Service");


            //******* MMIP ************//

            //BrowserWindow brows = BrowserWindow.Launch("http://mmip.alfa-xp.com");

            //brows.Maximized = true;

            //InputText(brows, "UserName", TestContext.DataRow["username"].ToString());
            //InputText(brows, "Password", TestContext.DataRow["pass"].ToString());
            //string btnOK = "#loginOK";
            //button(brows, brows.Text(btnOK));


            //string linkIncTaskSS = "div.fmNavTree ul > li:nth-child(1) > ul > li:nth-child(2) > a > label";
            //string linkIncTaskD = "div.fmNavTree ul > li:nth-child(1) > ul > li:nth-child(1) > a > label";
            //string btnNext1 = "div.mwnd-body > div:nth-child(2) > div:nth-child(4) > a:nth-child(2)";
            //string btnNext2 = "div.mwnd-body > div:nth-child(2) > div:nth-child(4) > a:nth-child(3)";
            //string btnNext3 = "div.mwnd-body > div:nth-child(2) > div:nth-child(4) > a:nth-child(1)";
            //string btnClose = "div.mwnd-body > div:nth-child(2) > a";
            //string Send = "div.mwnd-body > div:nth-child(2) > div:nth-child(1) div:nth-child(3) > a";
            //string Send1 = "div.mwnd-body > div:nth-child(2) > div:nth-child(1) > div > table > tbody > tr > td > div:nth-child(3) > a:nth-child(1)";
            //string supervisor = "div.wnd-pnl > div:nth-child(3) > div > label:nth-child(6)";
            //string specialist = "div.wnd-pnl > div:nth-child(3) > div > label:nth-child(5)";
            //string director = "div.wnd-pnl > div:nth-child(3) > div > label:nth-child(2)";


            ////Supervisor
            //clickChangeRole(brows);
            //brows.WaitForExists(supervisor);
            // option.changeRole(brows, brows.Text(supervisor));


            //brows.WaitForExists(linkIncTaskSS);
            // option.choose(brows, brows.Text(linkIncTaskSS).ToString());

            // option.CaseClick(brows, caseRember);

            //brows.WaitForExists(btnNext1);
            // option.Modalbtn(brows, brows.Text(btnNext1));

            //brows.WaitForExists(btnNext2);
            // option.Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(Send);
            // option.Modalbtn(brows, brows.Text(Send));

            //Playback.Wait(1000);

            ////Specialist
            //clickChangeRole(brows);
            //brows.WaitForExists(specialist);
            //changeRole(brows, brows.Text(specialist));

            //brows.WaitForExists(linkIncTaskSS);
            //choose(brows, brows.Text(linkIncTaskSS).ToString());

            //CaseClick(brows, caseRember);

            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(Send1);
            //Modalbtn(brows, brows.Text(Send1));

            //Playback.Wait(1000);


            //CaseClick(brows, caseRember);

            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(Send);
            //Modalbtn(brows, brows.Text(Send));

            //Playback.Wait(1000);

            ////Supervisor
            //clickChangeRole(brows);
            //brows.WaitForExists(supervisor);
            //changeRole(brows, brows.Text(supervisor));

            //brows.WaitForExists(linkIncTaskSS);
            //choose(brows, brows.Text(linkIncTaskSS).ToString());

            //CaseClick(brows, caseRember);

            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));

            //txtTextarea(brows, TestContext.DataRow["txtarea1"].ToString());

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(Send1);
            //Modalbtn(brows, brows.Text(Send1));

            //Playback.Wait(1000);

            ////Director
            //clickChangeRole(brows);
            //brows.WaitForExists(director);
            //changeRole(brows, brows.Text(director));

            //brows.WaitForExists(linkIncTaskD);
            //choose(brows, brows.Text(linkIncTaskD).ToString());

            //CaseClick(brows, caseRember);

            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));

            //txtTextarea(brows, TestContext.DataRow["txtarea2"].ToString());

            //brows.WaitForExists(btnNext2);
            //Modalbtn(brows, brows.Text(btnNext2));

            //brows.WaitForExists(Send1);
            //Modalbtn(brows, brows.Text(Send1));

            //brows.WaitForExists(btnNext3);
            //Modalbtn(brows, brows.Text(btnNext3));

            //Playback.Wait(1000);
            //brows.WaitForExists(btnNext1);
            //Modalbtn(brows, brows.Text(btnNext1));
            //Playback.Wait(1000);
            //brows.WaitForExists(btnClose);
            //Modalbtn(brows, brows.Text(btnClose));

            //brows.Close();

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
