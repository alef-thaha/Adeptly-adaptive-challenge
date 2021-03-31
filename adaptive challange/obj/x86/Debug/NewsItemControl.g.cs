﻿#pragma checksum "C:\Users\alef-pt4023\source\repos\adaptive challange\adaptive challange\NewsItemControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "30E17D3249582D5AF3025FDA1EFDEBEB748BD25ED50950043B3A3B1EAFE66307"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace adaptive_challange
{
    partial class NewsItemControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class NewsItemControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            INewsItemControl_Bindings
        {
            private global::adaptive_challange.NewsItemControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Image obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5SourceDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;

            public NewsItemControl_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 42 && columnNumber == 16)
                {
                    isobj5SourceDisabled = true;
                }
                else if (lineNumber == 44 && columnNumber == 40)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 46 && columnNumber == 40)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 48 && columnNumber == 24)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // NewsItemControl.xaml line 42
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 6: // NewsItemControl.xaml line 44
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 7: // NewsItemControl.xaml line 46
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // NewsItemControl.xaml line 48
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // INewsItemControl_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::adaptive_challange.NewsItemControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::adaptive_challange.NewsItemControl obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_NewsItem(obj.NewsItem, phase);
                    }
                }
            }
            private void Update_NewsItem(global::adaptive_challange.Models.NewsItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_NewsItem_Image(obj.Image, phase);
                        this.Update_NewsItem_Headline(obj.Headline, phase);
                        this.Update_NewsItem_Subhead(obj.Subhead, phase);
                        this.Update_NewsItem_DateLine(obj.DateLine, phase);
                    }
                }
            }
            private void Update_NewsItem_Image(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // NewsItemControl.xaml line 42
                    if (!isobj5SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj5, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_NewsItem_Headline(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // NewsItemControl.xaml line 44
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                    }
                }
            }
            private void Update_NewsItem_Subhead(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // NewsItemControl.xaml line 46
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_NewsItem_DateLine(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // NewsItemControl.xaml line 48
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // NewsItemControl.xaml line 12
                {
                    this.MainPanel = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // NewsItemControl.xaml line 19
                {
                    this.NarrowLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4: // NewsItemControl.xaml line 30
                {
                    this.WideLayout = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // NewsItemControl.xaml line 44
                {
                    this.headline = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // NewsItemControl.xaml line 46
                {
                    this.subhead = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // NewsItemControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    NewsItemControl_obj1_Bindings bindings = new NewsItemControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

