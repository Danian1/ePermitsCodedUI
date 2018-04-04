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
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class Permits100
    {
        public Permits100()
        {
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\DataEpermits.csv", "DataEpermits#csv", DataAccessMethod.Sequential),
        DeploymentItem("DataEpermits.csv")]
        [TestMethod]
        public void Permit100()
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

            string page7 = "ul.ngx-pagination > li:nth-child(7) > a";
            browser.JQueryWaitForExists(page7);
            btnPage(browser, browser.JQueryText(page7));

            //Select Service
            string service = "ul.services-inline-list > li:nth-child(13) p";
            browser.JQueryWaitForExists(service);
            links(browser, browser.JQueryText(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            browser.JQueryWaitForExists(Apply);
            button(browser, browser.JQueryText(Apply));


            //****************** 1 - FORM ****************//
            //Service Location(Serviciul control)
            lookup(browser, "TeamId", 2);

            //Applicant Type(Persoana Juridica)
            lookup(browser, "ApplyType", 1);

            //IDNP
            InputText(browser, "IDNP", TestContext.DataRow["idnp"].ToString());

            //IDNO
            InputText(browser, "IDNO", TestContext.DataRow["idno"].ToString());

            ////Represented by(IDNP)
            //InputText(browser, "RepresentedIDNP", TestContext.DataRow["ridnp"].ToString());

            //I Agree
            clickLabel(browser, "IsTermsAndConditions-label");

            //Click Next
            string next = "div.basic-commands > button";
            button(browser, browser.JQueryText(next));


            //****************** 2 - FORM ****************//

            //Legal form(Întreprindere colectivă)
            lookup(browser, "LegalForm", 2);

            //Date of Decision on Registration
            DateSelect(browser, "RegCertificateDate", 13);

            //Legal Entity name *
            InputText(browser, "LegalEntityName", TestContext.DataRow["LegEnName"].ToString());

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


            //Serial nr.passport
            InputText(browser, "Passport", TestContext.DataRow["Passport"].ToString());

            //First name
            InputText(browser, "ApplicantFirstName", TestContext.DataRow["Fname"].ToString());

            //Power of attorney 
            InputText(browser, "PowerOfAttorney", TestContext.DataRow["PowerATT"].ToString());

            //Last name
            InputText(browser, "ApplicantLastName", TestContext.DataRow["Lname"].ToString());

            //Position
            InputText(browser, "ApplicantPosition", TestContext.DataRow["Position"].ToString());

            //Middle name
            InputText(browser, "ApplicantMiddleName", TestContext.DataRow["Mname"].ToString());

            //Email
            InputText(browser, "ApplicantEmail", TestContext.DataRow["Email"].ToString());

            //Birth date
            DateSelect(browser, "ApplicantBirthDate", 13);

            //Phone
            InputText(browser, "ApplicantPhone", TestContext.DataRow["Phone"].ToString());

            //Country(Africa de Sud)
            lookup(browser, "RepresentativeAddressCountry", 2);

            //Sector(SEC.BUIUCANI)
            lookup(browser, "RepresentativeAddressSector", 2);

            //house
            InputText(browser, "RepresentativeAddressHouse", TestContext.DataRow["repHouse"].ToString());

            //District(MUN.BALTI)
            lookup(browser, "RepresentativeAddressDistrict", 2);

            //Floor
            InputText(browser, "RepresentativeAddressFloor", TestContext.DataRow["repFloor"].ToString());

            //City(BUCIUMENI LOC.ST.C.F.)
            lookup(browser, "RepresentativeAddressCity", 2);

            //Apartment
            InputText(browser, "RepresentativeAddressApartment", TestContext.DataRow["repApart"].ToString());

            //Street(bd. Cuza-Voda)
            lookup(browser, "RepresentativeAddressStreet", 2);

            //block
            InputText(browser, "RepresentativeAddressBlock", TestContext.DataRow["repBlock"].ToString());

            //Address Entrance 
            InputText(browser, "RepresentativeAddressEntrance", TestContext.DataRow["AddrENT"].ToString());

            //Postal code 
            InputText(browser, "RepresentativeAddressPostalCode", TestContext.DataRow["repPcode"].ToString());

            //Representative Address Line 1 
            InputText(browser, "RepresentativeAddressLine1", TestContext.DataRow["repAdrline1"].ToString());

            //Representative Address Line 2  
            InputText(browser, "RepresentativeAddressLine2", TestContext.DataRow["repAdrline2"].ToString());

            //Click button Next
            browser.JQueryWaitForExists(next);
            button(browser, browser.JQueryText(next));

            //Activity Type *
            lookup(browser, "ActivityType", 1);

            //Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            browser.JQueryWaitForExists(addProduct);
            button(browser, browser.JQueryText(addProduct));

            //Name 
            InputText(browser, "Name", TestContext.DataRow["name"].ToString());

            //District *
            lookup(browser, "DistrictId", 2);

            //City
            lookup(browser, "CityId", 2);

            //Sector
            lookup(browser, "SectorId", 2);

            //Street
            lookup(browser, "StreetId", 2);

            //House
            InputText(browser, "House", TestContext.DataRow["fHouse"].ToString());

            //Block
            InputText(browser, "Block", TestContext.DataRow["fBlock"].ToString());

            //Apartment
            InputText(browser, "Apartment", TestContext.DataRow["fApartm"].ToString());

            //Active *
            Combobox(browser, "Active", 0);

            string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            browser.JQueryWaitForExists(saveCl);
            button(browser, browser.JQueryText(saveCl));

            Playback.Wait(1000);

            //Click button Next
            string next1 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next1);
            button(browser, browser.JQueryText(next1));

            //*****Supporting Documents************//

            //Click Button Edit(4)
            editBtn(browser, 4);

            //Select img and open
            selectIMG(browser);

            //title
            InputText(browser, "Title", TestContext.DataRow["Title"].ToString());

            //Click Save and Close
            string saveClose = "div.modal-footer div.basic-commands > button:nth-child(2)";
            browser.JQueryWaitForExists(saveClose);
            button(browser, browser.JQueryText(saveClose));

            Playback.Wait(1000);

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
        public void btnPage(UITestControl parent, string page)
        {
            var btn = new HtmlCustom(parent);
            btn.SearchProperties.Add(HtmlCustom.PropertyNames.TagName, "A");
            btn.SearchProperties.Add(HtmlCustom.PropertyNames.InnerText, page);
            Mouse.Click(btn);
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
        public void editBtn(UITestControl parent, int pos)
        {
            var edit = new HtmlButton(parent);
            edit.SearchProperties.Add(HtmlButton.PropertyNames.TagInstance, pos.ToString());
            edit.WaitForControlExist();
            Mouse.Click(edit);

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
        public void selectIMG(UITestControl parent)
        {
            var btnChoose = new HtmlLabel(parent);
            btnChoose.SearchProperties.Add(HtmlLabel.PropertyNames.TagInstance, "6");
            btnChoose.WaitForControlExist();
            Mouse.Click(btnChoose);

            string x = TestContext.DeploymentDirectory;
            string[] rows = x.Split(new string[] { "TestResults" }, StringSplitOptions.None);
            String TestProjectPath = rows[0].ToString() + @"TestareManual\Resources\test.jpg";

            WinWindow UploadWindow = new WinWindow();
            UploadWindow.SearchProperties.Add("Name", "Open");
            UploadWindow.WaitForControlExist();

            WinEdit File = new WinEdit(UploadWindow);
            File.SearchProperties.Add("Name", "File name:");
            File.Text = TestProjectPath;

            Keyboard.SendKeys("{Enter}");
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
