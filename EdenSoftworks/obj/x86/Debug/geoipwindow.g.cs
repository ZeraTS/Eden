﻿#pragma checksum "C:\Users\sinis\source\repos\EdenSoftworks\EdenSoftworks\geoipwindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "172C91B663C9412CEAABA787EDC91ACBF7F85D73788962C466F043A13845E389"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdenSoftworks
{
    partial class geoipwindow : 
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
            case 2: // geoipwindow.xaml line 15
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Button_Click;
                }
                break;
            case 3: // geoipwindow.xaml line 91
                {
                    global::Microsoft.UI.Xaml.Controls.TabView element3 = (global::Microsoft.UI.Xaml.Controls.TabView)(target);
                    ((global::Microsoft.UI.Xaml.Controls.TabView)element3).AddTabButtonClick += this.TabView_AddTabButtonClick;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)element3).TabCloseRequested += this.TabView_TabCloseRequested;
                    ((global::Microsoft.UI.Xaml.Controls.TabView)element3).Loaded += this.TabView_Loaded;
                }
                break;
            case 4: // geoipwindow.xaml line 61
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element4 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element4).Click += this.MenuFlyoutItem_Click;
                }
                break;
            case 5: // geoipwindow.xaml line 67
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element5 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element5).Click += this.MenuFlyoutItem_Click_1;
                }
                break;
            case 6: // geoipwindow.xaml line 73
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element6 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element6).Click += this.MenuFlyoutItem_Click_2;
                }
                break;
            case 7: // geoipwindow.xaml line 79
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element7 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element7).Click += this.MenuFlyoutItem_Click_3;
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

