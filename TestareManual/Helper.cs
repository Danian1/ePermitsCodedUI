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
    public class Helper
    {
        private BrowserWindow browser;
        private TestContext testContext;

        public Helper(string targetBrowser, string uri, Boolean maximized, TestContext testContext)
        {
            BrowserWindow.CurrentBrowser = targetBrowser;
            BrowserWindow browser = BrowserWindow.Launch(uri);
            browser.Maximized = true;
            this.browser = browser;
            this.testContext = testContext;
        }

        [TestMethod]
        public void Option()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        public string metadata(string metaName)
        {
            return this.testContext.DataRow[metaName].ToString();
        }

        public string Text(string selector)
        {
            return this.browser.JQueryText(selector);
        }

        public string Value(string selector)
        {
            return this.browser.JQueryVal(selector);
        }

        public void WaitForExists(string selector)
        {
            this.browser.JQueryWaitForExists(selector);
        }

        public void CTS()
        {
            var btnV = new HtmlButton(this.browser);
            btnV.SearchProperties.Add(HtmlButton.PropertyNames.TagInstance, "2");
            Mouse.Click(btnV);

        }

        public void InputText(string id, string text)
        {

            var input = new HtmlEdit(this.browser);
            input.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            input.WaitForControlExist(1000);
            if (input.Text == "")
            {
                input.Text = text;
            }
        }

        public void button(string text)
        {
            var btn = new HtmlButton(this.browser);
            btn.SearchProperties.Add(HtmlButton.PropertyNames.InnerText, text);
            btn.WaitForControlExist(1000);
            Mouse.Click(btn);
        }

        public void choose(string text)
        {
            var btn = new HtmlLabel(this.browser);
            btn.SearchProperties.Add(HtmlLabel.PropertyNames.InnerText, text);
            btn.WaitForControlExist(1000);
            Mouse.Click(btn);
        }

        public void links(string text)
        {
            var link = new HtmlHyperlink(this.browser);
            link.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, text);
            Mouse.Click(link);
        }

        public void lookup(string id, int row)
        {
            var spn = new HtmlEdit(this.browser);
            spn.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            spn.WaitForControlExist();
            Mouse.Click(spn);

            var text = new HtmlCell(this.browser);
            text.SearchProperties.Add(HtmlCell.PropertyNames.RowIndex, row.ToString());
            text.WaitForControlExist();
            Mouse.DoubleClick(text);
        }

        public void DateSelect(string id, int data)
        {
            var dataB = new HtmlEdit(this.browser);
            dataB.SearchProperties.Add(HtmlEdit.PropertyNames.Id, id);
            dataB.WaitForControlExist(1000);
            Mouse.Click(dataB);

            var slData = new HtmlCell(this.browser);
            slData.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, data.ToString());
            slData.WaitForControlExist(1000);
            Mouse.Click(slData);
        }

        public void Combobox(string id, int value)
        {
            var combo = new HtmlComboBox(this.browser);
            combo.SearchProperties.Add(HtmlComboBox.PropertyNames.Id, id);
            combo.WaitForControlExist(1000);
            combo.SelectedIndex = value;
        }

        public void editBtn(int pos)
        {
            var edit = new HtmlButton(this.browser);
            edit.SearchProperties.Add(HtmlButton.PropertyNames.TagInstance, pos.ToString());
            edit.WaitForControlExist();
            Mouse.Click(edit);

        }

        public void selectIMG()
        {
            var btnChoose = new HtmlLabel(this.browser);
            btnChoose.SearchProperties.Add(HtmlLabel.PropertyNames.TagInstance, "6");
            btnChoose.WaitForControlExist();
            Mouse.Click(btnChoose);

            string x = this.testContext.DeploymentDirectory;
            string[] rows = PathIMG(x);
            String TestProjectPath = rows[0].ToString() + @"TestareManual\Resources\test.jpg";

            WinWindow UploadWindow = new WinWindow();
            UploadWindow.SearchProperties.Add("Name", "Open");
            UploadWindow.WaitForControlExist();

            WinEdit File = new WinEdit(UploadWindow);
            File.SearchProperties.Add("Name", "File name:");
            File.Text = TestProjectPath;

            Keyboard.SendKeys("{Enter}");
        }

        private static string[] PathIMG(string x) => x.Split(new string[] { "TestResults" }, options: StringSplitOptions.None);

        public void clickLabel(string id)
        {
            var lab = new HtmlSpan(this.browser);
            lab.SearchProperties.Add(HtmlSpan.PropertyNames.Id, id);
            Mouse.Click(lab);
        }

        public void clickChangeRole()
        {
            var role = new HtmlHyperlink(this.browser);
            role.SearchProperties.Add(HtmlHyperlink.PropertyNames.TagName, "A");
            role.SearchProperties.Add(HtmlHyperlink.PropertyNames.AbsolutePath, "App_Role()");
            role.WaitForControlExist(2000);
            role.WaitForControlReady();
            Mouse.Click(role);
        }

        public void changeRole(string name)
        {
            var chRole = new HtmlRadioButton(this.browser);
            chRole.SearchProperties.Add(HtmlRadioButton.PropertyNames.Value, name);
            chRole.WaitForControlExist();
            Mouse.Click(chRole);
        }

        public void CaseClick(string text)
        {
            var cases = new HtmlCell(this.browser);
            cases.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, text);
            cases.WaitForControlExist();
            Mouse.Click(cases);
            Mouse.DoubleClick(cases);
        }

        public void Modalbtn(string text)
        {
            var nextBTN = new HtmlCustom(this.browser);
            nextBTN.SearchProperties.Add(HtmlCustom.PropertyNames.TagName, "A");
            nextBTN.SearchProperties.Add(HtmlCustom.PropertyNames.InnerText, text);
            nextBTN.WaitForControlExist();
            Mouse.Click(nextBTN);
        }

        public void txtTextarea(string text)
        {
            var textarea = new HtmlTextArea(this.browser);
            textarea.SearchProperties.Add(HtmlTextArea.PropertyNames.TagName, "TEXTAREA");
            textarea.SearchProperties.Add(HtmlTextArea.PropertyNames.Class, "fm");
            textarea.WaitForControlExist();
            textarea.Text = text;
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
