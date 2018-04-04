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
            Helper option = new Helper("Chrome", "http://epermits.alfa-xp.com/#/login", true);

            //Username
            option.InputText("loginForm_login", TestContext.DataRow["login"].ToString());

            //Password
             option.InputText("loginForm_password", TestContext.DataRow["password"].ToString());

            //Click button Login
            string login = "login-cmp > div > div > div > form > button";
            option.button(option.Text(login));

            string page6 = "ul.ngx-pagination > li:nth-child(6) > a";
            option.WaitForExists(page6);
            option.Modalbtn(option.Text(page6));

            string page7 = "ul.ngx-pagination > li:nth-child(7) > a";
            option.WaitForExists(page7);
            option.Modalbtn(option.Text(page7));

            //Select Service
            string service = "ul.services-inline-list > li:nth-child(13) p";
            option.WaitForExists(service);
            option.links(option.Text(service));

            //Click button Apply
            string Apply = "div.access-service > button";
            option.WaitForExists(Apply);
            option.button(option.Text(Apply));


            //****************** 1 - FORM ****************//
            //Service Location(Serviciul control)
             option.lookup("TeamId", 2);

            //Applicant Type(Persoana Juridica)
             option.lookup("ApplyType", 1);

            //IDNP
             option.InputText("IDNP", TestContext.DataRow["idnp"].ToString());

            //IDNO
             option.InputText("IDNO", TestContext.DataRow["idno"].ToString());

            ////Represented by(IDNP)
            // option.InputText("RepresentedIDNP", TestContext.DataRow["ridnp"].ToString());

            //I Agree
            option.clickLabel("IsTermsAndConditions-label");

            //Click Next
            string next = "div.basic-commands > button";
            option.button(option.Text(next));


            //****************** 2 - FORM ****************//

            //Legal form(Întreprindere colectivă)
             option.lookup("LegalForm", 2);

            //Date of Decision on Registration
            option.DateSelect("RegCertificateDate", 13);

            //Legal Entity name *
             option.InputText("LegalEntityName", TestContext.DataRow["LegEnName"].ToString());

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


            //Serial nr.passport
             option.InputText("Passport", TestContext.DataRow["Passport"].ToString());

            //First name
             option.InputText("ApplicantFirstName", TestContext.DataRow["Fname"].ToString());

            //Power of attorney 
             option.InputText("PowerOfAttorney", TestContext.DataRow["PowerATT"].ToString());

            //Last name
             option.InputText("ApplicantLastName", TestContext.DataRow["Lname"].ToString());

            //Position
             option.InputText("ApplicantPosition", TestContext.DataRow["Position"].ToString());

            //Middle name
             option.InputText("ApplicantMiddleName", TestContext.DataRow["Mname"].ToString());

            //Email
             option.InputText("ApplicantEmail", TestContext.DataRow["Email"].ToString());

            //Birth date
            option.DateSelect("ApplicantBirthDate", 13);

            //Phone
             option.InputText("ApplicantPhone", TestContext.DataRow["Phone"].ToString());

            //Country(Africa de Sud)
             option.lookup("RepresentativeAddressCountry", 2);

            //Sector(SEC.BUIUCANI)
             option.lookup("RepresentativeAddressSector", 2);

            //house
             option.InputText("RepresentativeAddressHouse", TestContext.DataRow["repHouse"].ToString());

            //District(MUN.BALTI)
             option.lookup("RepresentativeAddressDistrict", 2);

            //Floor
             option.InputText("RepresentativeAddressFloor", TestContext.DataRow["repFloor"].ToString());

            //City(BUCIUMENI LOC.ST.C.F.)
             option.lookup("RepresentativeAddressCity", 2);

            //Apartment
             option.InputText("RepresentativeAddressApartment", TestContext.DataRow["repApart"].ToString());

            //Street(bd. Cuza-Voda)
             option.lookup("RepresentativeAddressStreet", 2);

            //block
             option.InputText("RepresentativeAddressBlock", TestContext.DataRow["repBlock"].ToString());

            //Address Entrance 
             option.InputText("RepresentativeAddressEntrance", TestContext.DataRow["AddrENT"].ToString());

            //Postal code 
             option.InputText("RepresentativeAddressPostalCode", TestContext.DataRow["repPcode"].ToString());

            //Representative Address Line 1 
             option.InputText("RepresentativeAddressLine1", TestContext.DataRow["repAdrline1"].ToString());

            //Representative Address Line 2  
             option.InputText("RepresentativeAddressLine2", TestContext.DataRow["repAdrline2"].ToString());

            //Click button Next
            option.WaitForExists(next);
            option.button(option.Text(next));

            //Activity Type *
             option.lookup("ActivityType", 1);

            //Click Add Product
            string addProduct = "div.panel-header.grid-header button";
            option.WaitForExists(addProduct);
            option.button(option.Text(addProduct));

            //Name 
             option.InputText("Name", TestContext.DataRow["name"].ToString());

            //District *
             option.lookup("DistrictId", 2);

            //City
             option.lookup("CityId", 2);

            //Sector
             option.lookup("SectorId", 2);

            //Street
             option.lookup("StreetId", 2);

            //House
             option.InputText("House", TestContext.DataRow["fHouse"].ToString());

            //Block
             option.InputText("Block", TestContext.DataRow["fBlook"].ToString());

            //Apartment
             option.InputText("Apartment", TestContext.DataRow["fApartm"].ToString());

            //Active *
            option.Combobox("Active", 0);

            string saveCl = "div.modal-footer div.basic-commands > button:nth-child(2)";
            option.WaitForExists(saveCl);
            option.button(option.Text(saveCl));

            Playback.Wait(1000);

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

            Playback.Wait(1000);

            //Click button Next
            string next2 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next2);
            option.button(option.Text(next2));

            //Click button Next
            string next3 = "div.process-buttons.pull-right > div > button:nth-child(2)";
            option.WaitForExists(next3);
            option.button(option.Text(next3));

            //Request Delivery 
             option.lookup("RequestDelivery", 1);

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
