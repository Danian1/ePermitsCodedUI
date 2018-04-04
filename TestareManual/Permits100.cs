﻿using Microsoft.VisualStudio.TestTools.UITesting;
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

            string page6 = "ul.ngx-pagination > li:nth-child(6) > a";
            browser.JQueryWaitForExists(page6);
            option.Modalbtn(browser, browser.JQueryText(page6));

            string page7 = "ul.ngx-pagination > li:nth-child(7) > a";
            browser.JQueryWaitForExists(page7);
            option.Modalbtn(browser, browser.JQueryText(page7));

            //Select Service
            string service = "ul.services-inline-list > li:nth-child(13) p";
            browser.JQueryWaitForExists(service);
            option.links(browser, browser.JQueryText(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            browser.JQueryWaitForExists(Apply);
            option.button(browser, browser.JQueryText(Apply));


            //****************** 1 - FORM ****************//
            //Service Location(Serviciul control)
             option.lookup(browser, "TeamId", 2);

            //Applicant Type(Persoana Juridica)
             option.lookup(browser, "ApplyType", 1);

            //IDNP
             option.InputText(browser, "IDNP", TestContext.DataRow["idnp"].ToString());

            //IDNO
             option.InputText(browser, "IDNO", TestContext.DataRow["idno"].ToString());

            ////Represented by(IDNP)
            // option.InputText(browser, "RepresentedIDNP", TestContext.DataRow["ridnp"].ToString());

            //I Agree
            option.clickLabel(browser, "IsTermsAndConditions-label");

            //Click Next
            string next = "div.basic-commands > button";
            option.button(browser, browser.JQueryText(next));


            //****************** 2 - FORM ****************//

            //Legal form(Întreprindere colectivă)
             option.lookup(browser, "LegalForm", 2);

            //Date of Decision on Registration
            option.DateSelect(browser, "RegCertificateDate", 13);

            //Legal Entity name *
             option.InputText(browser, "LegalEntityName", TestContext.DataRow["LegEnName"].ToString());

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


            //Serial nr.passport
             option.InputText(browser, "Passport", TestContext.DataRow["Passport"].ToString());

            //First name
             option.InputText(browser, "ApplicantFirstName", TestContext.DataRow["Fname"].ToString());

            //Power of attorney 
             option.InputText(browser, "PowerOfAttorney", TestContext.DataRow["PowerATT"].ToString());

            //Last name
             option.InputText(browser, "ApplicantLastName", TestContext.DataRow["Lname"].ToString());

            //Position
             option.InputText(browser, "ApplicantPosition", TestContext.DataRow["Position"].ToString());

            //Middle name
             option.InputText(browser, "ApplicantMiddleName", TestContext.DataRow["Mname"].ToString());

            //Email
             option.InputText(browser, "ApplicantEmail", TestContext.DataRow["Email"].ToString());

            //Birth date
            option.DateSelect(browser, "ApplicantBirthDate", 13);

            //Phone
             option.InputText(browser, "ApplicantPhone", TestContext.DataRow["Phone"].ToString());

            //Country(Africa de Sud)
             option.lookup(browser, "RepresentativeAddressCountry", 2);

            //Sector(SEC.BUIUCANI)
             option.lookup(browser, "RepresentativeAddressSector", 2);

            //house
             option.InputText(browser, "RepresentativeAddressHouse", TestContext.DataRow["repHouse"].ToString());

            //District(MUN.BALTI)
             option.lookup(browser, "RepresentativeAddressDistrict", 2);

            //Floor
             option.InputText(browser, "RepresentativeAddressFloor", TestContext.DataRow["repFloor"].ToString());

            //City(BUCIUMENI LOC.ST.C.F.)
             option.lookup(browser, "RepresentativeAddressCity", 2);

            //Apartment
             option.InputText(browser, "RepresentativeAddressApartment", TestContext.DataRow["repApart"].ToString());

            //Street(bd. Cuza-Voda)
             option.lookup(browser, "RepresentativeAddressStreet", 2);

            //block
             option.InputText(browser, "RepresentativeAddressBlock", TestContext.DataRow["repBlock"].ToString());

            //Address Entrance 
             option.InputText(browser, "RepresentativeAddressEntrance", TestContext.DataRow["AddrENT"].ToString());

            //Postal code 
             option.InputText(browser, "RepresentativeAddressPostalCode", TestContext.DataRow["repPcode"].ToString());

            //Representative Address Line 1 
             option.InputText(browser, "RepresentativeAddressLine1", TestContext.DataRow["repAdrline1"].ToString());

            //Representative Address Line 2  
             option.InputText(browser, "RepresentativeAddressLine2", TestContext.DataRow["repAdrline2"].ToString());

            //Click button Next
            browser.JQueryWaitForExists(next);
            option.button(browser, browser.JQueryText(next));

            //Activity Type *
             option.lookup(browser, "ActivityType", 1);

            //Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            browser.JQueryWaitForExists(addProduct);
            option.button(browser, browser.JQueryText(addProduct));

            //Name 
             option.InputText(browser, "Name", TestContext.DataRow["name"].ToString());

            //District *
             option.lookup(browser, "DistrictId", 2);

            //City
             option.lookup(browser, "CityId", 2);

            //Sector
             option.lookup(browser, "SectorId", 2);

            //Street
             option.lookup(browser, "StreetId", 2);

            //House
             option.InputText(browser, "House", TestContext.DataRow["fHouse"].ToString());

            //Block
             option.InputText(browser, "Block", TestContext.DataRow["fBlock"].ToString());

            //Apartment
             option.InputText(browser, "Apartment", TestContext.DataRow["fApartm"].ToString());

            //Active *
            option.Combobox(browser, "Active", 0);

            string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            browser.JQueryWaitForExists(saveCl);
            option.button(browser, browser.JQueryText(saveCl));

            Playback.Wait(1000);

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

            Playback.Wait(1000);

            //Click button Next
            string next2 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next2);
            option.button(browser, browser.JQueryText(next2));

            //Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            browser.JQueryWaitForExists(next3);
            option.button(browser, browser.JQueryText(next3));

            //Request Delivery 
             option.lookup(browser, "RequestDelivery", 1);

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

            browser.Close();

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
