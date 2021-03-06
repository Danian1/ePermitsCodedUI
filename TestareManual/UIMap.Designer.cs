﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestareManual
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// clickContinua
        /// </summary>
        public void clickContinua()
        {
            #region Variable Declarations
            HtmlButton uIContinuăButton = this.UIMSignRezultatsemnătuWindow.UIMSignRezultatsemnătuDocument.UIContinuăButton;
            #endregion

            // Click 'Continuă' button
            Mouse.Click(uIContinuăButton, new Point(47, 18));
        }
        
        /// <summary>
        /// PIN - Use 'PINParams' to pass parameters into this method.
        /// </summary>
        public void PIN()
        {
            #region Variable Declarations
            WinClient uIPleaseenterPINClient = this.UIPleaseenterPINWindow.UIPleaseenterPINClient;
            #endregion

            // Click 'Please enter PIN' client
            Mouse.Click(uIPleaseenterPINClient, new Point(156, 48));

            // Type '11111111' in 'Please enter PIN' client
            Keyboard.SendKeys(uIPleaseenterPINClient, this.PINParams.UIPleaseenterPINClientSendKeys, ModifierKeys.None);

            // Click 'Please enter PIN' client
            Mouse.Click(uIPleaseenterPINClient, new Point(231, 122));
        }
        
        /// <summary>
        /// PIN2 - Use 'PIN2Params' to pass parameters into this method.
        /// </summary>
        public void PIN2()
        {
            #region Variable Declarations
            WinClient uIPleaseenterPINClient = this.UIPleaseenterPINWindow1.UIPleaseenterPINClient;
            #endregion

            // Click 'Please enter PIN' client
            Mouse.Click(uIPleaseenterPINClient, new Point(165, 61));

            // Type '11111111' in 'Please enter PIN' client
            Keyboard.SendKeys(uIPleaseenterPINClient, this.PIN2Params.UIPleaseenterPINClientSendKeys, ModifierKeys.None);

            // Click 'Please enter PIN' client
            Mouse.Click(uIPleaseenterPINClient, new Point(214, 119));
        }
        
        /// <summary>
        /// MSign - Use 'MSignParams' to pass parameters into this method.
        /// </summary>
        public void MSign()
        {
            #region Variable Declarations
            WinControl uIMSignSemnareGoogleChApplication = this.UIMSignSemnareGoogleChWindow.UIMSignSemnareGoogleChApplication;
            WinClient uIPleaseenterPINClient = this.UIPleaseenterPINWindow.UIPleaseenterPINClient;
            #endregion

            // Click 'MSign - Semnare - Google Chrome' Application
            Mouse.Click(uIMSignSemnareGoogleChApplication, new Point(801, 522));

            // Click 'MSign - Semnare - Google Chrome' Application
            Mouse.Click(uIMSignSemnareGoogleChApplication, new Point(855, 456));

            // Click 'Please enter PIN' client
            Mouse.Click(uIPleaseenterPINClient, new Point(179, 55));

            // Type '11111111' in 'Please enter PIN' client
            Keyboard.SendKeys(uIPleaseenterPINClient, this.MSignParams.UIPleaseenterPINClientSendKeys, ModifierKeys.None);

            // Click 'Please enter PIN' client
            Mouse.Click(uIPleaseenterPINClient, new Point(208, 124));
        }
        
        #region Properties
        public virtual PINParams PINParams
        {
            get
            {
                if ((this.mPINParams == null))
                {
                    this.mPINParams = new PINParams();
                }
                return this.mPINParams;
            }
        }
        
        public virtual PIN2Params PIN2Params
        {
            get
            {
                if ((this.mPIN2Params == null))
                {
                    this.mPIN2Params = new PIN2Params();
                }
                return this.mPIN2Params;
            }
        }
        
        public virtual MSignParams MSignParams
        {
            get
            {
                if ((this.mMSignParams == null))
                {
                    this.mMSignParams = new MSignParams();
                }
                return this.mMSignParams;
            }
        }
        
        public UIMSignRezultatsemnătuWindow UIMSignRezultatsemnătuWindow
        {
            get
            {
                if ((this.mUIMSignRezultatsemnătuWindow == null))
                {
                    this.mUIMSignRezultatsemnătuWindow = new UIMSignRezultatsemnătuWindow();
                }
                return this.mUIMSignRezultatsemnătuWindow;
            }
        }
        
        public UIPleaseenterPINWindow UIPleaseenterPINWindow
        {
            get
            {
                if ((this.mUIPleaseenterPINWindow == null))
                {
                    this.mUIPleaseenterPINWindow = new UIPleaseenterPINWindow();
                }
                return this.mUIPleaseenterPINWindow;
            }
        }
        
        public UIPleaseenterPINWindow1 UIPleaseenterPINWindow1
        {
            get
            {
                if ((this.mUIPleaseenterPINWindow1 == null))
                {
                    this.mUIPleaseenterPINWindow1 = new UIPleaseenterPINWindow1();
                }
                return this.mUIPleaseenterPINWindow1;
            }
        }
        
        public UIMSignSemnareGoogleChWindow UIMSignSemnareGoogleChWindow
        {
            get
            {
                if ((this.mUIMSignSemnareGoogleChWindow == null))
                {
                    this.mUIMSignSemnareGoogleChWindow = new UIMSignSemnareGoogleChWindow();
                }
                return this.mUIMSignSemnareGoogleChWindow;
            }
        }
        #endregion
        
        #region Fields
        private PINParams mPINParams;
        
        private PIN2Params mPIN2Params;
        
        private MSignParams mMSignParams;
        
        private UIMSignRezultatsemnătuWindow mUIMSignRezultatsemnătuWindow;
        
        private UIPleaseenterPINWindow mUIPleaseenterPINWindow;
        
        private UIPleaseenterPINWindow1 mUIPleaseenterPINWindow1;
        
        private UIMSignSemnareGoogleChWindow mUIMSignSemnareGoogleChWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'PIN'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class PINParams
    {
        
        #region Fields
        /// <summary>
        /// Type '11111111' in 'Please enter PIN' client
        /// </summary>
        public string UIPleaseenterPINClientSendKeys = "11111111";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'PIN2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class PIN2Params
    {
        
        #region Fields
        /// <summary>
        /// Type '11111111' in 'Please enter PIN' client
        /// </summary>
        public string UIPleaseenterPINClientSendKeys = "11111111";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'MSign'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class MSignParams
    {
        
        #region Fields
        /// <summary>
        /// Type '11111111' in 'Please enter PIN' client
        /// </summary>
        public string UIPleaseenterPINClientSendKeys = "11111111";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMSignRezultatsemnătuWindow : BrowserWindow
    {
        
        public UIMSignRezultatsemnătuWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "MSign - Rezultat semnătură";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("MSign - Rezultat semnătură");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIMSignRezultatsemnătuDocument UIMSignRezultatsemnătuDocument
        {
            get
            {
                if ((this.mUIMSignRezultatsemnătuDocument == null))
                {
                    this.mUIMSignRezultatsemnătuDocument = new UIMSignRezultatsemnătuDocument(this);
                }
                return this.mUIMSignRezultatsemnătuDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIMSignRezultatsemnătuDocument mUIMSignRezultatsemnătuDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMSignRezultatsemnătuDocument : HtmlDocument
    {
        
        public UIMSignRezultatsemnătuDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "MSign - Rezultat semnătură";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/sign/failed/5df4c3cb6e964540b57a2d3419f4816e";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "https://testmsign.gov.md/sign/failed/5df4c3cb6e964540b57a2d3419f4816e";
            this.WindowTitles.Add("MSign - Rezultat semnătură");
            #endregion
        }
        
        #region Properties
        public UIMaincontainerPane UIMaincontainerPane
        {
            get
            {
                if ((this.mUIMaincontainerPane == null))
                {
                    this.mUIMaincontainerPane = new UIMaincontainerPane(this);
                }
                return this.mUIMaincontainerPane;
            }
        }
        
        public HtmlButton UIContinuăButton
        {
            get
            {
                if ((this.mUIContinuăButton == null))
                {
                    this.mUIContinuăButton = new HtmlButton(this);
                    #region Search Criteria
                    this.mUIContinuăButton.SearchProperties[HtmlButton.PropertyNames.Id] = "ok";
                    this.mUIContinuăButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUIContinuăButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Continuă";
                    this.mUIContinuăButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUIContinuăButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUIContinuăButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUIContinuăButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-default\" id=\"ok\" type=\"su";
                    this.mUIContinuăButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "1";
                    this.mUIContinuăButton.WindowTitles.Add("MSign - Rezultat semnătură");
                    #endregion
                }
                return this.mUIContinuăButton;
            }
        }
        #endregion
        
        #region Fields
        private UIMaincontainerPane mUIMaincontainerPane;
        
        private HtmlButton mUIContinuăButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMaincontainerPane : HtmlDiv
    {
        
        public UIMaincontainerPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "main-container";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Semnătura nu a fost aplicată\r\n\r\n \r\n\r\n\r\nC";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=\"main-container\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "11";
            this.WindowTitles.Add("MSign - Rezultat semnătură");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UICerereadesemnarenuafPane
        {
            get
            {
                if ((this.mUICerereadesemnarenuafPane == null))
                {
                    this.mUICerereadesemnarenuafPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUICerereadesemnarenuafPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUICerereadesemnarenuafPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUICerereadesemnarenuafPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Cererea de semnare nu a fost găsită\r\n\r\n ";
                    this.mUICerereadesemnarenuafPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUICerereadesemnarenuafPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "well well-sm well-fog text-center";
                    this.mUICerereadesemnarenuafPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=\"well well-sm well-fog text-center\"";
                    this.mUICerereadesemnarenuafPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "15";
                    this.mUICerereadesemnarenuafPane.WindowTitles.Add("MSign - Rezultat semnătură");
                    #endregion
                }
                return this.mUICerereadesemnarenuafPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUICerereadesemnarenuafPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIPleaseenterPINWindow : WinWindow
    {
        
        public UIPleaseenterPINWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Please enter PIN";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SunAwtFrame";
            this.WindowTitles.Add("Please enter PIN");
            #endregion
        }
        
        #region Properties
        public WinClient UIPleaseenterPINClient
        {
            get
            {
                if ((this.mUIPleaseenterPINClient == null))
                {
                    this.mUIPleaseenterPINClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIPleaseenterPINClient.SearchProperties[WinControl.PropertyNames.Name] = "Please enter PIN";
                    this.mUIPleaseenterPINClient.WindowTitles.Add("Please enter PIN");
                    #endregion
                }
                return this.mUIPleaseenterPINClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIPleaseenterPINClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIPleaseenterPINWindow1 : WinWindow
    {
        
        public UIPleaseenterPINWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Please enter PIN";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SunAwtFrame";
            this.FilterProperties[WinWindow.PropertyNames.OrderOfInvocation] = "2";
            this.WindowTitles.Add("Please enter PIN");
            #endregion
        }
        
        #region Properties
        public WinClient UIPleaseenterPINClient
        {
            get
            {
                if ((this.mUIPleaseenterPINClient == null))
                {
                    this.mUIPleaseenterPINClient = new WinClient(this);
                    #region Search Criteria
                    this.mUIPleaseenterPINClient.SearchProperties[WinControl.PropertyNames.Name] = "Please enter PIN";
                    this.mUIPleaseenterPINClient.WindowTitles.Add("Please enter PIN");
                    #endregion
                }
                return this.mUIPleaseenterPINClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIPleaseenterPINClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIMSignSemnareGoogleChWindow : WinWindow
    {
        
        public UIMSignSemnareGoogleChWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "MSign - Semnare - Google Chrome";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Chrome_WidgetWin_1";
            this.WindowTitles.Add("MSign - Semnare - Google Chrome");
            #endregion
        }
        
        #region Properties
        public WinControl UIMSignSemnareGoogleChApplication
        {
            get
            {
                if ((this.mUIMSignSemnareGoogleChApplication == null))
                {
                    this.mUIMSignSemnareGoogleChApplication = new WinControl(this);
                    #region Search Criteria
                    this.mUIMSignSemnareGoogleChApplication.SearchProperties[UITestControl.PropertyNames.Name] = "MSign - Semnare";
                    this.mUIMSignSemnareGoogleChApplication.SearchProperties[UITestControl.PropertyNames.ControlType] = "Application";
                    this.mUIMSignSemnareGoogleChApplication.WindowTitles.Add("MSign - Semnare - Google Chrome");
                    #endregion
                }
                return this.mUIMSignSemnareGoogleChApplication;
            }
        }
        #endregion
        
        #region Fields
        private WinControl mUIMSignSemnareGoogleChApplication;
        #endregion
    }
}
