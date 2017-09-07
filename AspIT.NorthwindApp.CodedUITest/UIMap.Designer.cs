﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace AspIT.NorthwindApp.CodedUITest
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Selects an employee, changes the first name and then presses the save button
        /// </summary>
        public void EditEmployeeTest1()
        {
            #region Variable Declarations
            WpfControl uIItemDataItem = this.UIEmployeeOverwatchWindow.UIEmployeeListTable.UIItemDataItem;
            WpfEdit uIFirstNameTbEdit = this.UIEmployeeOverwatchWindow.UIPersonligeoplysningeGroup.UIFirstNameTbEdit;
            WpfButton uIGemændringerButton = this.UIEmployeeOverwatchWindow.UIGemændringerButton;
            #endregion

            // Click DataItem
            Mouse.Click(uIItemDataItem, new Point(1265, 42));

            // Click 'firstNameTb' text box
            Mouse.Click(uIFirstNameTbEdit, new Point(49, 6));

            // Type 'Control + {Back}' in 'firstNameTb' text box
            Keyboard.SendKeys(uIFirstNameTbEdit, this.EditEmployeeTest1Params.UIFirstNameTbEditSendKeys, ModifierKeys.Control);

            // Type 'Paulie' in 'firstNameTb' text box
            uIFirstNameTbEdit.Text = this.EditEmployeeTest1Params.UIFirstNameTbEditText;

            // Type '{Enter}' in 'firstNameTb' text box
            Keyboard.SendKeys(uIFirstNameTbEdit, this.EditEmployeeTest1Params.UIFirstNameTbEditSendKeys1, ModifierKeys.None);

            // Click 'Gem ændringer' button
            Mouse.Click(uIGemændringerButton, new Point(43, 12));
        }
        
        /// <summary>
        /// Selects an employee, changes some data and then presses the save button
        /// </summary>
        public void EditEmployeeTest2()
        {
            #region Variable Declarations
            WpfControl uIItemDataItem1 = this.UIEmployeeOverwatchWindow.UIEmployeeListTable.UIItemDataItem1;
            WpfDatePicker uIBirthDatePickerDatePicker = this.UIEmployeeOverwatchWindow.UIPersonligeoplysningeGroup.UIBirthDatePickerDatePicker;
            WpfEdit uICountryTbEdit = this.UIEmployeeOverwatchWindow.UIPersonligeoplysningeGroup.UICountryTbEdit;
            WpfEdit uITitleTbEdit = this.UIEmployeeOverwatchWindow.UIAndreoplysningerGroup.UITitleTbEdit;
            WpfButton uIGemændringerButton = this.UIEmployeeOverwatchWindow.UIGemændringerButton;
            #endregion

            // Click DataItem numbered 3 in 'employeeList' table
            Mouse.Click(uIItemDataItem1, new Point(631, 34));

            // Select '14-Aug-1963' in 'birthDatePicker' date picker
            uIBirthDatePickerDatePicker.DateAsString = this.EditEmployeeTest2Params.UIBirthDatePickerDatePickerDateAsString;

            // Type 'UK' in 'countryTb' text box
            uICountryTbEdit.Text = this.EditEmployeeTest2Params.UICountryTbEditText;

            // Type 'Marketing' in 'titleTb' text box
            uITitleTbEdit.Text = this.EditEmployeeTest2Params.UITitleTbEditText;

            // Click 'Gem ændringer' button
            Mouse.Click(uIGemændringerButton, new Point(15, 17));
        }
        
        #region Properties
        public virtual EditEmployeeTest1Params EditEmployeeTest1Params
        {
            get
            {
                if ((this.mEditEmployeeTest1Params == null))
                {
                    this.mEditEmployeeTest1Params = new EditEmployeeTest1Params();
                }
                return this.mEditEmployeeTest1Params;
            }
        }
        
        public virtual EditEmployeeTest2Params EditEmployeeTest2Params
        {
            get
            {
                if ((this.mEditEmployeeTest2Params == null))
                {
                    this.mEditEmployeeTest2Params = new EditEmployeeTest2Params();
                }
                return this.mEditEmployeeTest2Params;
            }
        }
        
        public UIEmployeeOverwatchWindow UIEmployeeOverwatchWindow
        {
            get
            {
                if ((this.mUIEmployeeOverwatchWindow == null))
                {
                    this.mUIEmployeeOverwatchWindow = new UIEmployeeOverwatchWindow();
                }
                return this.mUIEmployeeOverwatchWindow;
            }
        }
        #endregion
        
        #region Fields
        private EditEmployeeTest1Params mEditEmployeeTest1Params;
        
        private EditEmployeeTest2Params mEditEmployeeTest2Params;
        
        private UIEmployeeOverwatchWindow mUIEmployeeOverwatchWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EditEmployeeTest1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class EditEmployeeTest1Params
    {
        
        #region Fields
        /// <summary>
        /// Type 'Control + {Back}' in 'firstNameTb' text box
        /// </summary>
        public string UIFirstNameTbEditSendKeys = "{Back}";
        
        /// <summary>
        /// Type 'Paulie' in 'firstNameTb' text box
        /// </summary>
        public string UIFirstNameTbEditText = "Paulie";
        
        /// <summary>
        /// Type '{Enter}' in 'firstNameTb' text box
        /// </summary>
        public string UIFirstNameTbEditSendKeys1 = "{Enter}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'EditEmployeeTest2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class EditEmployeeTest2Params
    {
        
        #region Fields
        /// <summary>
        /// Select '14-Aug-1963' in 'birthDatePicker' date picker
        /// </summary>
        public string UIBirthDatePickerDatePickerDateAsString = "14-Aug-1963";
        
        /// <summary>
        /// Type 'UK' in 'countryTb' text box
        /// </summary>
        public string UICountryTbEditText = "UK";
        
        /// <summary>
        /// Type 'Marketing' in 'titleTb' text box
        /// </summary>
        public string UITitleTbEditText = "Marketing";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIEmployeeOverwatchWindow : WpfWindow
    {
        
        public UIEmployeeOverwatchWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Employee Overwatch";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Employee Overwatch");
            #endregion
        }
        
        #region Properties
        public UIEmployeeListTable UIEmployeeListTable
        {
            get
            {
                if ((this.mUIEmployeeListTable == null))
                {
                    this.mUIEmployeeListTable = new UIEmployeeListTable(this);
                }
                return this.mUIEmployeeListTable;
            }
        }
        
        public UIPersonligeoplysningeGroup UIPersonligeoplysningeGroup
        {
            get
            {
                if ((this.mUIPersonligeoplysningeGroup == null))
                {
                    this.mUIPersonligeoplysningeGroup = new UIPersonligeoplysningeGroup(this);
                }
                return this.mUIPersonligeoplysningeGroup;
            }
        }
        
        public WpfButton UIGemændringerButton
        {
            get
            {
                if ((this.mUIGemændringerButton == null))
                {
                    this.mUIGemændringerButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIGemændringerButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "editBtn";
                    this.mUIGemændringerButton.WindowTitles.Add("Employee Overwatch");
                    #endregion
                }
                return this.mUIGemændringerButton;
            }
        }
        
        public UIAndreoplysningerGroup UIAndreoplysningerGroup
        {
            get
            {
                if ((this.mUIAndreoplysningerGroup == null))
                {
                    this.mUIAndreoplysningerGroup = new UIAndreoplysningerGroup(this);
                }
                return this.mUIAndreoplysningerGroup;
            }
        }
        #endregion
        
        #region Fields
        private UIEmployeeListTable mUIEmployeeListTable;
        
        private UIPersonligeoplysningeGroup mUIPersonligeoplysningeGroup;
        
        private WpfButton mUIGemændringerButton;
        
        private UIAndreoplysningerGroup mUIAndreoplysningerGroup;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIEmployeeListTable : WpfTable
    {
        
        public UIEmployeeListTable(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTable.PropertyNames.AutomationId] = "employeeList";
            this.WindowTitles.Add("Employee Overwatch");
            #endregion
        }
        
        #region Properties
        public WpfControl UIItemDataItem
        {
            get
            {
                if ((this.mUIItemDataItem == null))
                {
                    this.mUIItemDataItem = new WpfControl(this);
                    #region Search Criteria
                    this.mUIItemDataItem.SearchProperties[WpfControl.PropertyNames.ControlType] = "DataItem";
                    this.mUIItemDataItem.WindowTitles.Add("Employee Overwatch");
                    #endregion
                }
                return this.mUIItemDataItem;
            }
        }
        
        public WpfControl UIItemDataItem1
        {
            get
            {
                if ((this.mUIItemDataItem1 == null))
                {
                    this.mUIItemDataItem1 = new WpfControl(this);
                    #region Search Criteria
                    this.mUIItemDataItem1.SearchProperties[WpfControl.PropertyNames.ControlType] = "DataItem";
                    this.mUIItemDataItem1.SearchProperties[WpfControl.PropertyNames.Instance] = "3";
                    this.mUIItemDataItem1.WindowTitles.Add("Employee Overwatch");
                    #endregion
                }
                return this.mUIItemDataItem1;
            }
        }
        #endregion
        
        #region Fields
        private WpfControl mUIItemDataItem;
        
        private WpfControl mUIItemDataItem1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIPersonligeoplysningeGroup : WpfGroup
    {
        
        public UIPersonligeoplysningeGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfGroup.PropertyNames.AutomationId] = "groupBox";
            this.WindowTitles.Add("Employee Overwatch");
            #endregion
        }
        
        #region Properties
        public WpfEdit UIFirstNameTbEdit
        {
            get
            {
                if ((this.mUIFirstNameTbEdit == null))
                {
                    this.mUIFirstNameTbEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUIFirstNameTbEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "firstNameTb";
                    this.mUIFirstNameTbEdit.WindowTitles.Add("Employee Overwatch");
                    #endregion
                }
                return this.mUIFirstNameTbEdit;
            }
        }
        
        public WpfDatePicker UIBirthDatePickerDatePicker
        {
            get
            {
                if ((this.mUIBirthDatePickerDatePicker == null))
                {
                    this.mUIBirthDatePickerDatePicker = new WpfDatePicker(this);
                    #region Search Criteria
                    this.mUIBirthDatePickerDatePicker.SearchProperties[WpfDatePicker.PropertyNames.AutomationId] = "birthDatePicker";
                    this.mUIBirthDatePickerDatePicker.WindowTitles.Add("Employee Overwatch");
                    #endregion
                }
                return this.mUIBirthDatePickerDatePicker;
            }
        }
        
        public WpfEdit UICountryTbEdit
        {
            get
            {
                if ((this.mUICountryTbEdit == null))
                {
                    this.mUICountryTbEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUICountryTbEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "countryTb";
                    this.mUICountryTbEdit.WindowTitles.Add("Employee Overwatch");
                    #endregion
                }
                return this.mUICountryTbEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUIFirstNameTbEdit;
        
        private WpfDatePicker mUIBirthDatePickerDatePicker;
        
        private WpfEdit mUICountryTbEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIAndreoplysningerGroup : WpfGroup
    {
        
        public UIAndreoplysningerGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfGroup.PropertyNames.AutomationId] = "groupBox1";
            this.WindowTitles.Add("Employee Overwatch");
            #endregion
        }
        
        #region Properties
        public WpfEdit UITitleTbEdit
        {
            get
            {
                if ((this.mUITitleTbEdit == null))
                {
                    this.mUITitleTbEdit = new WpfEdit(this);
                    #region Search Criteria
                    this.mUITitleTbEdit.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "titleTb";
                    this.mUITitleTbEdit.WindowTitles.Add("Employee Overwatch");
                    #endregion
                }
                return this.mUITitleTbEdit;
            }
        }
        #endregion
        
        #region Fields
        private WpfEdit mUITitleTbEdit;
        #endregion
    }
}
