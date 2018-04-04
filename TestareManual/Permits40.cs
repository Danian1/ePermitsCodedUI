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


            string page3 = "ul.ngx-pagination > li:nth-child(4) > a";
            browser.JQueryWaitForExists(page3);
            option.Modalbtn(browser, browser.JQueryText(page3));

            //Select Service
            string service = "ul.services-inline-list > li:nth-child(11) p";
            browser.JQueryWaitForExists(service);
            option.links(browser, browser.JQueryText(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            browser.JQueryWaitForExists(Apply);
            option.button(browser, browser.JQueryText(Apply));

            //****************** 1 - FORM ****************//
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

            //****************** 2 - FORM ****************//

            Playback.Wait(2000);
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

            //*******Representative  Data&Address*******//

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

            //Street(bd. Cuza-Voda)
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


            //****************** 3 - FORM ****************//
            //Exporter
             option.InputText(browser, "Exporter", TestContext.DataRow["exporter"].ToString());

            //Exporter Reg. Date
            option.DateSelect(browser, "RegDateExporter", 4);

            //Exporter address 
             option.InputText(browser, "ExporterAddress", TestContext.DataRow["eAddress"].ToString());

            //Exporter Reg. No. 
             option.InputText(browser, "RegNumberExporter", TestContext.DataRow["regNrExp"].ToString());

            //Exporter phone
             option.InputText(browser, "ExporterPhone", TestContext.DataRow["ePhone"].ToString());

            //Registration Com. No.
             option.InputText(browser, "RegNumberCom", TestContext.DataRow["regNrCom"].ToString());

            //Exporter fax
             option.InputText(browser, "ExporterFax", TestContext.DataRow["eFax"].ToString());

            //Registration date at MEI
            option.DateSelect(browser, "RegDateME", 23);

            //Supplier 
             option.InputText(browser, "Supplier", TestContext.DataRow["supplier"].ToString());

            //External partner  
             option.InputText(browser, "ExternalPartner", TestContext.DataRow["ExPartner"].ToString());

            //Requested validity term, days 
             option.InputText(browser, "ValidityTermRequested", TestContext.DataRow["ValTReq"].ToString());

            //Entry customs point(Post vamal Leușeni (PVFI, rutier)) 
             option.lookup(browser, "ExitCustomsPoint", 1);

            //Additional Info
             option.InputText(browser, "OtherApplicantInformation", TestContext.DataRow["Other"].ToString());

            //Bank name
             option.InputText(browser, "BankName", TestContext.DataRow["BankName"].ToString());

            //Bank account number (IBAN)
             option.InputText(browser, "BankAccountNumber", TestContext.DataRow["BankAccNr"].ToString());

            //Bank code
             option.InputText(browser, "BankCode", TestContext.DataRow["BankCode"].ToString());

            //Paying Country(Afganistan)
             option.lookup(browser, "PayingCountry", 1);

            //Importing Country(Africa de Sud)
             option.lookup(browser, "ImportingCountry", 2);

            //Destination Country(Albania)
             option.lookup(browser, "DestinationCountry", 3);

            //Delivery conditions
             option.InputText(browser, "DeliveryConditions", TestContext.DataRow["DCondit"].ToString());

            //Conditions of payment
             option.InputText(browser, "PaymentConditions", TestContext.DataRow["PaymentCond"].ToString());

            //Payment currency
             option.lookup(browser, "PaymentCurrency", 1);

            //Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            browser.JQueryWaitForExists(addProduct);
            option.button(browser, browser.JQueryText(addProduct));

            //Quantity
             option.InputText(browser, "Quantity", TestContext.DataRow["Quantify"].ToString());

            //Control list number(Reactori nucleari)
             option.lookup(browser, "ControlListNumber", 1);

            //Product Name
             option.InputText(browser, "CommercialName", TestContext.DataRow["CommName"].ToString());

            //QuantityUnits(mie l)
             option.lookup(browser, "QuantityUnits", 2);

            //Code(ex.170199)
             option.lookup(browser, "Code", 2);

            //Value CIF
             option.InputText(browser, "ValueCIF", TestContext.DataRow["ValueCIF"].ToString());

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
