﻿

#pragma checksum "C:\udem\finalv1\Libreria\SplitPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8FE8862EBF14D9885F6F63595B1D3BCE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libreria
{
    partial class SplitPage : global::Libreria.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 66 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ItemListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 50 "..\..\SplitPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


