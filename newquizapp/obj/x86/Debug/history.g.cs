﻿#pragma checksum "C:\Users\Gillian\Documents\school projects\newquizapp\newquizapp\history.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "31C22A8829A61C9CEA513EFB90D21330201FF46F0088E5485ECD1BACD8ECDD8D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace newquizapp
{
    partial class history : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // history.xaml line 31
                {
                    this.Subject = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // history.xaml line 36
                {
                    this.Question = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // history.xaml line 41
                {
                    this.Option1 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 5: // history.xaml line 45
                {
                    this.Option2 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 6: // history.xaml line 49
                {
                    this.Option3 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 7: // history.xaml line 53
                {
                    this.Option4 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 8: // history.xaml line 57
                {
                    this.resultbox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // history.xaml line 62
                {
                    this.btnsub = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 10: // history.xaml line 17
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.back;
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
            return returnValue;
        }
    }
}

