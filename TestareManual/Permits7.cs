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
            BrowserWindow.CurrentBrowser = "Chrome";

            //start Coded UI testing
            BrowserWindow browser = BrowserWindow.Launch("http://epermits.alfa-xp.com/#/login");
            browser.Maximized = true;

            //Username
            InputText(browser, "loginForm_login", TestContext.DataRow["login"].ToString());

            //Password
            InputText(browser, "loginForm_password", TestContext.DataRow["password"].ToString());

            //Click button Login
            string login = "login-cmp > div > div > div > form > button";
            button(browser, browser.JQueryText(login));


            //Select Service
            string service = "ul.services-inline-list > li:nth-child(7) p";
            browser.JQueryWaitForExists(service);
            links(browser, browser.JQueryText(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            browser.JQueryWaitForExists(Apply);
            button(browser, browser.JQueryText(Apply));

            //****************** 1 - FORM ****************//
            //Service Location(Serviciul control)
            lookup(browser, "TeamId", 2);

            //Applicant Type(Persoana Fizica)
            lookup(browser, "ApplyType", 1);

            //IDNP
            InputText(browser, "IDNP", TestContext.DataRow["idnp"].ToString());

            //IDNO
            InputText(browser, "IDNO", TestContext.DataRow["idno"].ToString());

            //Represented by(IDNP)
            InputText(browser, "RepresentedIDNP", TestContext.DataRow["ridnp"].ToString());

            //I Agree
            clickLabel(browser, "IsTermsAndConditions-label");

            //Click Next
            string next = "div.basic-commands > button";
            button(browser, browser.JQueryText(next));

            //****************** 2 - FORM ****************//

            Playback.Wait(2000);
            //First name
            InputText(browser, "ApplicantFirstName", TestContext.DataRow["Fname"].ToString());

            //Serial nr.passport
            InputText(browser, "Passport", TestContext.DataRow["Passport"].ToString());

            //Last name
            InputText(browser, "ApplicantLastName", TestContext.DataRow["Lname"].ToString());

            //Phone
            InputText(browser, "ApplicantPhone", TestContext.DataRow["Phone"].ToString());

            //Middle name
            InputText(browser, "ApplicantMiddleName", TestContext.DataRow["Mname"].ToString());

            //Email
            InputText(browser, "ApplicantEmail", TestContext.DataRow["Email"].ToString());

            //Birth date
            DateSelect(browser, "ApplicantBirthDate", 13);

            //Position
            InputText(browser, "ApplicantPosition", TestContext.DataRow["Position"].ToString());

            //Country(Afganistan)
            lookup(browser, "ApplicantAddressCountry", 1);

            //District(GAGAUZIA)
            lookup(browser, "ApplicantAddressDistrict", 1);

            //City(BAHMUT LOC.C.F.)
            lookup(browser, "ApplicantAddressCity", 1);

            //Sector(SEC.BOTANICA)
            lookup(browser, "ApplicantAddressSector", 1);

            //Street(bd.Constantin Negruzzi)
            lookup(browser, "ApplicantAddressStreet", 1);

            //house
            InputText(browser, "ApplicantAddressHouse", TestContext.DataRow["House"].ToString());

            //block
            InputText(browser, "ApplicantAddressBlock", TestContext.DataRow["Block"].ToString());

            //Floor
            InputText(browser, "ApplicantAddressFloor", TestContext.DataRow["Floor"].ToString());

            //Apartment
            InputText(browser, "ApplicantAddressApartment", TestContext.DataRow["Apartment"].ToString());

            //PostalCode
            InputText(browser, "ApplicantAddressPostalCode", TestContext.DataRow["PostalCode"].ToString());

            //Address Line 1 
            InputText(browser, "ApplicantAddressLine1", TestContext.DataRow["Adrline1"].ToString());

            //Address Line 2 
            InputText(browser, "ApplicantAddressLine2", TestContext.DataRow["Adrline2"].ToString());

            //*******Representative  Data&Address*******//

            //Power of attorney 
            InputText(browser, "PowerOfAttorney", TestContext.DataRow["PowerATT"].ToString());

            //First Name
            InputText(browser, "RepresentativeFirstName", TestContext.DataRow["repFname"].ToString());

            //Representative Email
            InputText(browser, "RepresentativeEmail", TestContext.DataRow["repEmail"].ToString());

            //Last name
            InputText(browser, "RepresentativeLastName", TestContext.DataRow["repLname"].ToString());

            //Representative Phone 
            InputText(browser, "RepresentativePhone", TestContext.DataRow["repPhone"].ToString());

            //Representative IDNP
            InputText(browser, "RepresentativeIDNP", TestContext.DataRow["repIdnp"].ToString());

            //Representative Type(Administrator)
            Combobox(browser, "RepresentativeType", 0);

            //Country(Africa de Sud)
            lookup(browser, "RepresentativeAddressCountry", 2);

            //District(MUN.BALTI)
            lookup(browser, "RepresentativeAddressDistrict", 2);

            //City(BUCIUMENI LOC.ST.C.F.)
            lookup(browser, "RepresentativeAddressCity", 2);

            //Sector(SEC.BUIUCANI)
            lookup(browser, "RepresentativeAddressSector", 2);

            //Street(bd. Cuza-Voda)
            lookup(browser, "RepresentativeAddressStreet", 2);

            //house
            InputText(browser, "RepresentativeAddressHouse", TestContext.DataRow["repHouse"].ToString());

            //block
            InputText(browser, "RepresentativeAddressBlock", TestContext.DataRow["repBlock"].ToString());

            //Floor
            InputText(browser, "RepresentativeAddressFloor", TestContext.DataRow["repFloor"].ToString());

            //Apartment
            InputText(browser, "RepresentativeAddressApartment", TestContext.DataRow["repApart"].ToString());

            //Postal code 
            InputText(browser, "RepresentativeAddressPostalCode", TestContext.DataRow["repPcode"].ToString());

            //Address Entrance 
            InputText(browser, "RepresentativeAddressEntrance", TestContext.DataRow["AddrENT"].ToString());

            //Representative Address Line 1 
            InputText(browser, "RepresentativeAddressLine1", TestContext.DataRow["repAdrline1"].ToString());

            //Representative Address Line 2  
            InputText(browser, "RepresentativeAddressLine2", TestContext.DataRow["repAdrline2"].ToString());

            //Click button Next
            browser.JQueryWaitForExists(next);
            button(browser, browser.JQueryText(next));


            Playback.Wait(1000);
            //****************** 3 - FORM ****************//

            //Authorization number
            InputText(browser, "AuthorizationNumber", TestContext.DataRow["AuthNR"].ToString());

            //Authorization date
            DateSelect(browser, "AuthorizationDate", 13);

            //Period of export from
            DateSelect(browser, "PeriodExportFrom", 13);

            //Period of export to
            DateSelect(browser, "PeriodExportTo", 13);

            //Destination Company
            InputText(browser, "DestinationCompany", TestContext.DataRow["DestCompany"].ToString());

            //Number of Authorization for transportation
            InputText(browser, "NumberAuthTransportation", TestContext.DataRow["NrAuthTR"].ToString());

            //Destination Country
            lookup(browser, "DestinationCountry", 2);

            //Date of Authorization for transportation
            DateSelect(browser, "DateAuthTransportation", 23);

            //Customs point
            InputText(browser, "CustomsPoint", TestContext.DataRow["CsPoint"].ToString());

            //Chief of commercial unit
            InputText(browser, "CheifCommercialUnit", TestContext.DataRow["ChComUnit"].ToString());

            //Route
            InputText(browser, "Route", TestContext.DataRow["Route"].ToString());

            //Notes
            InputText(browser, "Notes", TestContext.DataRow["Notes"].ToString());

            //Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            browser.JQueryWaitForExists(addProduct);
            button(browser, browser.JQueryText(addProduct));

            Playback.Wait(1000);

            //Product Name
            InputText(browser, "CommercialName", TestContext.DataRow["CommName"].ToString());

            //Package Name
            InputText(browser, "PackageName", TestContext.DataRow["PackageName"].ToString());

            //Quantity
            InputText(browser, "Quantity", TestContext.DataRow["Quantify"].ToString());

            //QuantityUnits
            lookup(browser, "QuantityUnits", 2);

            //ExportedBy
            InputText(browser, "ExportedBy", TestContext.DataRow["ExportBy"].ToString());

            //ProducedBy
            InputText(browser, "ProducedBy", TestContext.DataRow["ProdBy"].ToString());

            string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            browser.JQueryWaitForExists(saveCl);
            button(browser, browser.JQueryText(saveCl));

            Playback.Wait(1000);

            //Click button Next
            string next1 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next1);
            button(browser, browser.JQueryText(next1));

            //Click button Next
            string next2 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next2);
            button(browser, browser.JQueryText(next2));

            //Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next3);
            button(browser, browser.JQueryText(next3));

            //Request Delivery 
            lookup(browser, "RequestDelivery", 1);

            //Click Confirm
            string confirm = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(confirm);
            button(browser, browser.JQueryText(confirm));

            //Click Next
            string Next4 = "div.process-buttons.pull-right > div > button.btn.btn-default.process-button.btn-primary";
            browser.JQueryWaitForExists(Next4);
            button(browser, browser.JQueryText(Next4));

            //CaseRember
            string caseNr = "#CaseNumber";
            browser.JQueryWaitForExists(caseNr);
            var caseRember = browser.JQueryVal(caseNr);

            //Click Finish
            string finish = "div.basic-commands > button";
            browser.JQueryWaitForExists(finish);
            button(browser, browser.JQueryText(finish));

            //Click Confirm
            string confirm1 = "div.basic-commands > button";
            browser.JQueryWaitForExists(confirm1);
            button(browser, browser.JQueryText(confirm1));


            browser.Close();
        }

        public void InputText(UITestControl parent, string id, string text)
        {
            var input = new HtmlEdit(parent);
            input.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            input.WaitForControlExist(1000);
            input.Text = text;
        }
        public void button(UITestControl parent, string text)
        {
            var btn = new HtmlButton(parent);
            btn.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, text);
            btn.WaitForControlExist(1000);
            Mouse.Click(btn);
        }
        public void links(UITestControl parent, string text)
        {
            var link = new HtmlHyperlink(parent);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, text);
            Mouse.Click(link);
        }
        public void lookup(UITestControl parent, string id, int row)
        {
            var spn = new HtmlEdit(parent);
            spn.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            spn.WaitForControlExist();
            Mouse.Click(spn);

            var text = new HtmlCell(parent);
            text.SearchProperties.Add(HtmlCell.PropertyNames.RowIndex, row.ToString());
            text.WaitForControlExist();
            Mouse.DoubleClick(text);
        }
        public void DateSelect(UITestControl parent, string id, int data)
        {
            var dataB = new HtmlEdit(parent);
            dataB.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            dataB.WaitForControlExist(1000);
            Mouse.Click(dataB);

            var slData = new HtmlCell(parent);
            slData.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, data.ToString());
            slData.WaitForControlExist(1000);
            Mouse.Click(slData);
        }
        public void Combobox(UITestControl parent, string id, int value)
        {
            var combo = new HtmlComboBox(parent);
            combo.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            combo.WaitForControlExist(1000);
            combo.SelectedIndex = value;
        }
        public void clickLabel(UITestControl parent, string id)
        {
            var lab = new HtmlSpan(parent);
            lab.SearchProperties.Add(HtmlSpan.PropertyNames.Id, id);
            Mouse.Click(lab);
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
