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
            Options option = new Options();

            BrowserWindow.CurrentBrowser = "Chrome";
            BrowserWindow browser = BrowserWindow.Launch("http://epermits.alfa-xp.com/#/login");
            browser.Maximized = true;

            //Username
            option.InputText(browser, "loginForm_login", TestContext.DataRow["login"].ToString());

            //Password
            option.InputText(browser, "loginForm_password", TestContext.DataRow["password"].ToString());

            //Click button Login
            string login = "login-cmp > div > div > div > form > button";
            option.button(browser, browser.JQueryText(login));


            //Select Service
            string service = "ul.services-inline-list > li:nth-child(1) p";
            browser.JQueryWaitForExists(service);
            option.links(browser, browser.JQueryText(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            browser.JQueryWaitForExists(Apply);
            option.button(browser, browser.JQueryText(Apply));

            //Service Location(Serviciul control)
            option.lookup(browser, "TeamId", 2);

            //Applicant Type(Persoana Fizica)
            option.lookup(browser, "ApplyType", 1);

            //IDNP
            option.InputText(browser, "IDNP", TestContext.DataRow["idnp"].ToString());

            //IDNO
            option.InputText(browser, "IDNO", TestContext.DataRow["idno"].ToString());

            //Represented by(IDNP)
            option.InputText(browser, "RepresentedIDNP", TestContext.DataRow["ridnp"].ToString());

            //I Agree
            option.clickLabel(browser, "IsTermsAndConditions-label");

            //Click Next
            string next = "div.basic-commands > button";
            option.button(browser, browser.JQueryText(next));

            //******Individual * ****Personal Data & Address * ***********//
            Playback.Wait(1000);

            //First name
            option.InputText(browser, "ApplicantFirstName", TestContext.DataRow["Fname"].ToString());

            //Serial nr.passport
            option.InputText(browser, "Passport", TestContext.DataRow["Passport"].ToString());

            //Last name
            option.InputText(browser, "ApplicantLastName", TestContext.DataRow["Lname"].ToString());

            //Phone
            option.InputText(browser, "ApplicantPhone", TestContext.DataRow["Phone"].ToString());

            //Middle name
            option.InputText(browser, "ApplicantMiddleName", TestContext.DataRow["Mname"].ToString());

            //Email
            option.InputText(browser, "ApplicantEmail", TestContext.DataRow["Email"].ToString());

            //Birth date
            option.DateSelect(browser, "ApplicantBirthDate", 13);

            //Position
            option.InputText(browser, "ApplicantPosition", TestContext.DataRow["Position"].ToString());

            //Country(Afganistan)
            option.lookup(browser, "ApplicantAddressCountry", 1);

            //District(GAGAUZIA)
            option.lookup(browser, "ApplicantAddressDistrict", 1);

            //City(BAHMUT LOC.C.F.)
            option.lookup(browser, "ApplicantAddressCity", 1);

            //Sector(SEC.BOTANICA)
            option.lookup(browser, "ApplicantAddressSector", 1);

            //Street(bd.Constantin Negruzzi)
            option.lookup(browser, "ApplicantAddressStreet", 1);

            //house
            option.InputText(browser, "ApplicantAddressHouse", TestContext.DataRow["House"].ToString());

            //block
            option.InputText(browser, "ApplicantAddressBlock", TestContext.DataRow["Block"].ToString());

            //Floor
            option.InputText(browser, "ApplicantAddressFloor", TestContext.DataRow["Floor"].ToString());

            //Apartment
            option.InputText(browser, "ApplicantAddressApartment", TestContext.DataRow["Apartment"].ToString());

            //PostalCode
            option.InputText(browser, "ApplicantAddressPostalCode", TestContext.DataRow["PostalCode"].ToString());

            //Address Line 1
            option.InputText(browser, "ApplicantAddressLine1", TestContext.DataRow["Adrline1"].ToString());

            //Address Line 2
            option.InputText(browser, "ApplicantAddressLine2", TestContext.DataRow["Adrline2"].ToString());

            //*******Representative  Data & Address * ******//

            //Power of attorney
            option.InputText(browser, "PowerOfAttorney", TestContext.DataRow["PowerATT"].ToString());

            //First Name
            option.InputText(browser, "RepresentativeFirstName", TestContext.DataRow["repFname"].ToString());

            //Representative Email
            option.InputText(browser, "RepresentativeEmail", TestContext.DataRow["repEmail"].ToString());

            //Last name
            option.InputText(browser, "RepresentativeLastName", TestContext.DataRow["repLname"].ToString());

            //Representative Phone
            option.InputText(browser, "RepresentativePhone", TestContext.DataRow["repPhone"].ToString());

            //Representative IDNP
            option.InputText(browser, "RepresentativeIDNP", TestContext.DataRow["repIdnp"].ToString());

            //Representative Type(Administrator)
            option.Combobox(browser, "RepresentativeType", 0);

            //Country(Africa de Sud)
            option.lookup(browser, "RepresentativeAddressCountry", 2);

            //District(MUN.BALTI)
            option.lookup(browser, "RepresentativeAddressDistrict", 2);

            //City(BUCIUMENI LOC.ST.C.F.)
            option.lookup(browser, "RepresentativeAddressCity", 2);

            //Sector(SEC.BUIUCANI)
            option.lookup(browser, "RepresentativeAddressSector", 2);

            //Street(bd.Cuza - Voda)
            option.lookup(browser, "RepresentativeAddressStreet", 2);

            //house
            option.InputText(browser, "RepresentativeAddressHouse", TestContext.DataRow["repHouse"].ToString());

            //block
            option.InputText(browser, "RepresentativeAddressBlock", TestContext.DataRow["repBlock"].ToString());

            //Floor
            option.InputText(browser, "RepresentativeAddressFloor", TestContext.DataRow["repFloor"].ToString());

            //Apartment
            option.InputText(browser, "RepresentativeAddressApartment", TestContext.DataRow["repApart"].ToString());

            //Postal code
            option.InputText(browser, "RepresentativeAddressPostalCode", TestContext.DataRow["repPcode"].ToString());

            //Address Entrance
            option.InputText(browser, "RepresentativeAddressEntrance", TestContext.DataRow["AddrENT"].ToString());

            //Representative Address Line 1
            option.InputText(browser, "RepresentativeAddressLine1", TestContext.DataRow["repAdrline1"].ToString());

            //Representative Address Line 2
            option.InputText(browser, "RepresentativeAddressLine2", TestContext.DataRow["repAdrline2"].ToString());

            //Click button Next
            browser.JQueryWaitForExists(next);
            option.button(browser, browser.JQueryText(next));

            //******Input Permit Application Form************//

            //Importer
            option.InputText(browser, "Importer", TestContext.DataRow["importer"].ToString());

            //Exporter
            option.InputText(browser, "Exporter", TestContext.DataRow["exporter"].ToString());

            //Importer address
            option.InputText(browser, "ImporterAddress", TestContext.DataRow["iAddress"].ToString());

            //Exporter address
            option.InputText(browser, "ExporterAddress", TestContext.DataRow["eAddress"].ToString());

            //Importer phone
            option.InputText(browser, "ImporterPhone", TestContext.DataRow["iPhone"].ToString());

            //Exporter phone
            option.InputText(browser, "ExporterPhone", TestContext.DataRow["ePhone"].ToString());

            //Importer fax
            option.InputText(browser, "ImporterFax", TestContext.DataRow["iFax"].ToString());

            //Exporter fax
            option.InputText(browser, "ExporterFax", TestContext.DataRow["eFax"].ToString());

            //Transporter
            option.InputText(browser, "Transporter", TestContext.DataRow["Transporter"].ToString());

            //Holder
            option.InputText(browser, "Holder", TestContext.DataRow["Holder"].ToString());

            //Expeditor
            option.InputText(browser, "Expeditor", TestContext.DataRow["Expeditor"].ToString());

            //Entry customs point(Post vamal Leușeni(PVFI, rutier))
            option.lookup(browser, "EntryCustomsPoint", 1);

            //Exit customs point(Post vamal Leușeni(PVFI, rutier))
            option.lookup(browser, "ExitCustomsPoint", 1);

            //Transit route in Moldova
            option.InputText(browser, "TransitRouteMoldova", TestContext.DataRow["TRMD"].ToString());

            //Transport type(Auto)
            option.lookup(browser, "TransportType", 1);

            //Additional Info
            option.InputText(browser, "OtherApplicantInformation", TestContext.DataRow["AddInfo"].ToString());

            //Validity term requested
            option.InputText(browser, "ValidityTermRequested", TestContext.DataRow["ValTReq"].ToString());

            //Importing Country(Africa de Sud)
            option.lookup(browser, "ImportingCountry", 2);

            //Paying Country(Afganistan)
            option.lookup(browser, "PayingCountry", 1);

            //Destination Country(Albania)
            option.lookup(browser, "DestinationCountry", 3);

            //Exporting Country(Africa de Sud)
            option.lookup(browser, "ExportingCountry", 2);

            //Click button Next
            string next1 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next1);
            option.button(browser, browser.JQueryText(next1));

            //*****Supporting Documents************//

            //Click Button Edit(4)
            option.editBtn(browser, 4);

            //Select img and open
            option.selectIMG(browser);

            //title
            option.InputText(browser, "Title", TestContext.DataRow["Title"].ToString());

            //Click Save and Close
            string saveClose = "div.modal-footer div.basic-commands > button:nth-child(2)";
            browser.JQueryWaitForExists(saveClose);
            option.button(browser, browser.JQueryText(saveClose));

            //Click button Next
            string next2 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next2);
            option.button(browser, browser.JQueryText(next2));

            ////Sign the document button
            //string SignDoc = "div.ng-untouched.ng-pristine.ng-invalid > button.btn.btn-primary";
            //browser.JQueryWaitForExists(SignDoc);
            //button(browser, browser.JQueryText(SignDoc));

            //Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next3);
            option.button(browser, browser.JQueryText(next3));

            //*********Confirm Application*************//

            //Playback.Wait(2000);
            //I Agree
            //clickLabel(browser, "1");

            //Request Delivery
            option.lookup(browser, "RequestDelivery", 1);

            //Destination Locality
            //lookup(browser, "DeliveryTeamID", 1);

            //Destination Postal Code
            //InputText(browser, "DeliveryPostalCode", TestContext.DataRow["DesPoCode"].ToString());

            //Destination Address
            //InputText(browser, "DeliveryAddress", TestContext.DataRow["DestAddress"].ToString());

            //Click Confirm
            string confirm = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(confirm);
            option.button(browser, browser.JQueryText(confirm));

            //CaseRember
            string caseNr = "#CaseNumber";
            browser.JQueryWaitForExists(caseNr);
            var caseRember = browser.JQueryVal(caseNr);

            //Click Finish
            string finish = "div.basic-commands > button";
            browser.JQueryWaitForExists(finish);
            option.button(browser, browser.JQueryText(finish));

            //Click Confirm
            string confirm1 = "div.basic-commands > button";
            browser.JQueryWaitForExists(confirm1);
            option.button(browser, browser.JQueryText(confirm1));

            //**************************************//

            ////Click My Cabinet
            //string MyCab = "#main-menu > ul > div > navigator > li:nth-child(3)";
            //browser.JQueryWaitForExists(MyCab);
            //links(browser, browser.JQueryText(MyCab));

            ////Click Submitted
            //string Submitted = "#page-content > container-view > div:nth-child(2) > div > div > div > aside > div > nav > profile-tree > div.hidden-xs > ui-tree > ul > li:nth-child(2) > div > ui-tree > ul > li:nth-child(2)";
            //browser.JQueryWaitForExists(Submitted);
            //links(browser, browser.JQueryText(Submitted));

            //Playback.Wait(5000);
            //MessageBox.Show(caseRember, "CaseNumber of Service");
            //browser.Close();


            //******* MMIP ************//

            //BrowserWindow brows = BrowserWindow.Launch("http://mmip.alfa-xp.com");

            //brows.Maximized = true;

            //InputText(brows, "UserName", TestContext.DataRow["username"].ToString());
            //InputText(brows, "Password", TestContext.DataRow["pass"].ToString());
            //string btnOK = "#loginOK";
            //button(brows, brows.JQueryText(btnOK));


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
            //brows.JQueryWaitForExists(supervisor);
            // option.changeRole(brows, brows.JQueryText(supervisor));


            //brows.JQueryWaitForExists(linkIncTaskSS);
            // option.choose(brows, brows.JQueryText(linkIncTaskSS).ToString());

            // option.CaseClick(brows, caseRember);

            //brows.JQueryWaitForExists(btnNext1);
            // option.Modalbtn(brows, brows.JQueryText(btnNext1));

            //brows.JQueryWaitForExists(btnNext2);
            // option.Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(Send);
            // option.Modalbtn(brows, brows.JQueryText(Send));

            //Playback.Wait(1000);

            ////Specialist
            //clickChangeRole(brows);
            //brows.JQueryWaitForExists(specialist);
            //changeRole(brows, brows.JQueryText(specialist));

            //brows.JQueryWaitForExists(linkIncTaskSS);
            //choose(brows, brows.JQueryText(linkIncTaskSS).ToString());

            //CaseClick(brows, caseRember);

            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(Send1);
            //Modalbtn(brows, brows.JQueryText(Send1));

            //Playback.Wait(1000);


            //CaseClick(brows, caseRember);

            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(Send);
            //Modalbtn(brows, brows.JQueryText(Send));

            //Playback.Wait(1000);

            ////Supervisor
            //clickChangeRole(brows);
            //brows.JQueryWaitForExists(supervisor);
            //changeRole(brows, brows.JQueryText(supervisor));

            //brows.JQueryWaitForExists(linkIncTaskSS);
            //choose(brows, brows.JQueryText(linkIncTaskSS).ToString());

            //CaseClick(brows, caseRember);

            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));

            //txtTextarea(brows, TestContext.DataRow["txtarea1"].ToString());

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(Send1);
            //Modalbtn(brows, brows.JQueryText(Send1));

            //Playback.Wait(1000);

            ////Director
            //clickChangeRole(brows);
            //brows.JQueryWaitForExists(director);
            //changeRole(brows, brows.JQueryText(director));

            //brows.JQueryWaitForExists(linkIncTaskD);
            //choose(brows, brows.JQueryText(linkIncTaskD).ToString());

            //CaseClick(brows, caseRember);

            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));

            //txtTextarea(brows, TestContext.DataRow["txtarea2"].ToString());

            //brows.JQueryWaitForExists(btnNext2);
            //Modalbtn(brows, brows.JQueryText(btnNext2));

            //brows.JQueryWaitForExists(Send1);
            //Modalbtn(brows, brows.JQueryText(Send1));

            //brows.JQueryWaitForExists(btnNext3);
            //Modalbtn(brows, brows.JQueryText(btnNext3));

            //Playback.Wait(1000);
            //brows.JQueryWaitForExists(btnNext1);
            //Modalbtn(brows, brows.JQueryText(btnNext1));
            //Playback.Wait(1000);
            //brows.JQueryWaitForExists(btnClose);
            //Modalbtn(brows, brows.JQueryText(btnClose));

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
