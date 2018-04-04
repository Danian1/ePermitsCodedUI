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
    public class Options
    {
        public Options()
        {

        }

        [TestMethod]
        public void Option()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        }

        public void CTS(UITestControl parent)
        {
            var btnV = new HtmlButton(parent);
            btnV.SearchProperties.Add(HtmlButton.PropertyNames.TagInstance, "2");
            Mouse.Click(btnV);

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
        public void choose(UITestControl parent, string text)
        {
            var btn = new HtmlLabel(parent);
            btn.SearchProperties.Add(HtmlLabel.PropertyNames.InnerText, text);
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
        public void editBtn(UITestControl parent, int pos)
        {
            var edit = new HtmlButton(parent);
            edit.SearchProperties.Add(HtmlButton.PropertyNames.TagInstance, pos.ToString());
            edit.WaitForControlExist();
            Mouse.Click(edit);

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
        public void clickLabel(UITestControl parent, string id)
        {
            var lab = new HtmlSpan(parent);
            lab.SearchProperties.Add(HtmlSpan.PropertyNames.Id, id);
            Mouse.Click(lab);
        }
        public void clickChangeRole(UITestControl parent)
        {
            var role = new HtmlHyperlink(parent);
            role.SearchProperties.Add(HtmlHyperlink.PropertyNames.TagName, "A");
            role.SearchProperties.Add(HtmlHyperlink.PropertyNames.AbsolutePath, "App_Role()");
            role.WaitForControlExist(2000);
            role.WaitForControlReady();
            Mouse.Click(role);
        }
        public void changeRole(UITestControl parent, string name)
        {
            var chRole = new HtmlRadioButton(parent);
            chRole.SearchProperties.Add(HtmlRadioButton.PropertyNames.Value, name);
            chRole.WaitForControlExist();
            Mouse.Click(chRole);
        }
        public void CaseClick(UITestControl parent, string text)
        {
            var cases = new HtmlCell(parent);
            cases.SearchProperties.Add(HtmlCell.PropertyNames.InnerText, text);
            cases.WaitForControlExist();
            Mouse.Click(cases);
            Mouse.DoubleClick(cases);
        }
        public void Modalbtn(UITestControl parent, string text)
        {
            var nextBTN = new HtmlCustom(parent);
            nextBTN.SearchProperties.Add(HtmlCustom.PropertyNames.TagName, "A");
            nextBTN.SearchProperties.Add(HtmlCustom.PropertyNames.InnerText, text);
            nextBTN.WaitForControlExist();
            Mouse.Click(nextBTN);
        }
        public void txtTextarea(UITestControl parent, string text)
        {
            var textarea = new HtmlTextArea(parent);
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
