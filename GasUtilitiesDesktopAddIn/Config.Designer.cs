//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A4GasUtilities {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using ESRI.ArcGIS.Editor;
    using ESRI.ArcGIS.esriSystem;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "Gas Utility Network Tools";
            }
        }
        
        internal static string AddInID {
            get {
                return "{AF706D91-5AC0-40B2-890A-8B504C2191FA}";
            }
        }
        
        internal static string Company {
            get {
                return "Esri., Inc.";
            }
        }
        
        internal static string Version {
            get {
                return "4.26.2016";
            }
        }
        
        internal static string Description {
            get {
                return "ArcMap tools for Gas Utilities";
            }
        }
        
        internal static string Author {
            get {
                return "Esri., Inc.";
            }
        }
        
        internal static string Date {
            get {
                return "4/26/2016";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'A4GasUtilities_AddLaterals', the id declared for Add-in Button class 'AddLaterals'
            /// </summary>
            internal static string AddLaterals {
                get {
                    return "A4GasUtilities_AddLaterals";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_ConnectionChecker', the id declared for Add-in Button class 'ConnectionChecker'
            /// </summary>
            internal static string ConnectionChecker {
                get {
                    return "A4GasUtilities_ConnectionChecker";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_ConnectSelected', the id declared for Add-in Button class 'ConnectSelected'
            /// </summary>
            internal static string ConnectSelected {
                get {
                    return "A4GasUtilities_ConnectSelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_DisconnectSelected', the id declared for Add-in Button class 'DisconnectSelected'
            /// </summary>
            internal static string DisconnectSelected {
                get {
                    return "A4GasUtilities_DisconnectSelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_RotateSelected', the id declared for Add-in Button class 'RotateSelected'
            /// </summary>
            internal static string RotateSelected {
                get {
                    return "A4GasUtilities_RotateSelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_AdditionalRotate', the id declared for Add-in Button class 'AdditionalRotate'
            /// </summary>
            internal static string AdditionalRotate {
                get {
                    return "A4GasUtilities_AdditionalRotate";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_SplitLines', the id declared for Add-in Button class 'SplitLines'
            /// </summary>
            internal static string SplitLines {
                get {
                    return "A4GasUtilities_SplitLines";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_ExportToExcel', the id declared for Add-in Button class 'ExportToExcel'
            /// </summary>
            internal static string ExportToExcel {
                get {
                    return "A4GasUtilities_ExportToExcel";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_IdentifySelected', the id declared for Add-in Button class 'IdentifySelected'
            /// </summary>
            internal static string IdentifySelected {
                get {
                    return "A4GasUtilities_IdentifySelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_TraceSummaryIsolation', the id declared for Add-in Button class 'TraceSummaryIsolation'
            /// </summary>
            internal static string TraceSummaryIsolation {
                get {
                    return "A4GasUtilities_TraceSummaryIsolation";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_ToggleOperableStatus', the id declared for Add-in Tool class 'ToggleOperableStatus'
            /// </summary>
            internal static string ToggleOperableStatus {
                get {
                    return "A4GasUtilities_ToggleOperableStatus";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_ClearTraceResults', the id declared for Add-in Button class 'ClearTraceResults'
            /// </summary>
            internal static string ClearTraceResults {
                get {
                    return "A4GasUtilities_ClearTraceResults";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_TraceIsolation', the id declared for Add-in Tool class 'TraceIsolation'
            /// </summary>
            internal static string TraceIsolation {
                get {
                    return "A4GasUtilities_TraceIsolation";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_TraceIsolationRerun', the id declared for Add-in Button class 'TraceIsolationRerun'
            /// </summary>
            internal static string TraceIsolationRerun {
                get {
                    return "A4GasUtilities_TraceIsolationRerun";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_AddFlag', the id declared for Add-in Tool class 'AddFlag'
            /// </summary>
            internal static string AddFlag {
                get {
                    return "A4GasUtilities_AddFlag";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_AddBarrier', the id declared for Add-in Tool class 'AddBarrier'
            /// </summary>
            internal static string AddBarrier {
                get {
                    return "A4GasUtilities_AddBarrier";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_RemoveFlagBarrier', the id declared for Add-in Tool class 'RemoveFlagBarrier'
            /// </summary>
            internal static string RemoveFlagBarrier {
                get {
                    return "A4GasUtilities_RemoveFlagBarrier";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_SelectJunctionsByEdgeCount', the id declared for Add-in Button class 'SelectByJunctionEdgeCount'
            /// </summary>
            internal static string SelectByJunctionEdgeCount {
                get {
                    return "A4GasUtilities_SelectJunctionsByEdgeCount";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_EstablishFlowAncillary', the id declared for Add-in Button class 'EstablishFlowAncillary'
            /// </summary>
            internal static string EstablishFlowAncillary {
                get {
                    return "A4GasUtilities_EstablishFlowAncillary";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_EstablishFlowDigitized', the id declared for Add-in Button class 'EstablishFlowDigitized'
            /// </summary>
            internal static string EstablishFlowDigitized {
                get {
                    return "A4GasUtilities_EstablishFlowDigitized";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_BatchLoadBarriers', the id declared for Add-in Button class 'BatchLoadBarriers'
            /// </summary>
            internal static string BatchLoadBarriers {
                get {
                    return "A4GasUtilities_BatchLoadBarriers";
                }
            }
            
            /// <summary>
            /// Returns 'A4GasUtilities_ShowConfigForm', the id declared for Add-in Button class 'ShowConfigForm'
            /// </summary>
            internal static string ShowConfigForm {
                get {
                    return "A4GasUtilities_ShowConfigForm";
                }
            }
            
            /// <summary>
            /// Returns 'Esri_A4GasUtilities_AddLateralsConstructionTool', the id declared for Add-in Tool class 'AddLateralsConstructionTool'
            /// </summary>
            internal static string AddLateralsConstructionTool {
                get {
                    return "Esri_A4GasUtilities_AddLateralsConstructionTool";
                }
            }
            
            /// <summary>
            /// Returns 'Esri_A4GasUtilities_AddPointSplitLine', the id declared for Add-in Tool class 'AddPointSplitLine'
            /// </summary>
            internal static string AddPointSplitLine {
                get {
                    return "Esri_A4GasUtilities_AddPointSplitLine";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
      {
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;
        if (s_app == null)
        {
          IEditor editorHost = Internal.AddInStartupObject.GetHook<IEditor>();
          if (editorHost != null)
            s_app = editorHost.Parent;
        }
      }
      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
  public static IEditor Editor
  {
    get
    {
      UID editorUID = new UID();
      editorUID.Value = "esriEditor.Editor";
      return Application.FindExtensionByCLSID(editorUID) as IEditor;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
