﻿#pragma checksum "C:\Users\DELL\Documents\s_2017\236604-504s_2017\avi\avi\App1\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FC65EB4E9D0812C95BC02260DDF80437"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.comboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 32 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.comboBox).SelectionChanged += this.comboBox_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.history = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.history).Click += this.history_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.tbError = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.loading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 5:
                {
                    this.cbNormal = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.cb75 = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.cb5 = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.cb25 = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 9:
                {
                    this.cbClick = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 10:
                {
                    this.chooseFile = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 27 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.chooseFile).Click += this.chooseFile_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.practice = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 28 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.practice).Click += this.practice_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.btnConnect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnConnect).Click += this.btnConnect_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.tbConnectStatus = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.UserScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15:
                {
                    this.logOut = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.logOut).Click += this.logOut_Click;
                    #line default
                }
                break;
            case 16:
                {
                    this.UserBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

