//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace A4WaterUtilities {
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
                return "Water Utility Network Tools";
            }
        }
        
        internal static string AddInID {
            get {
                return "{FD20EAB0-7ACB-4B35-AA41-753157745FD0}";
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
                return "ArcMap tools for Water, Wastewater and Stormwater";
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
            /// Returns 'A4WaterUtilities_AddLaterals', the id declared for Add-in Button class 'AddLaterals'
            /// </summary>
            internal static string AddLaterals {
                get {
                    return "A4WaterUtilities_AddLaterals";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_AddLateralsFromMain', the id declared for Add-in Button class 'AddLateralsFromMain'
            /// </summary>
            internal static string AddLateralsFromMain {
                get {
                    return "A4WaterUtilities_AddLateralsFromMain";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ConnectionChecker', the id declared for Add-in Button class 'ConnectionChecker'
            /// </summary>
            internal static string ConnectionChecker {
                get {
                    return "A4WaterUtilities_ConnectionChecker";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ConnectSelected', the id declared for Add-in Button class 'ConnectSelected'
            /// </summary>
            internal static string ConnectSelected {
                get {
                    return "A4WaterUtilities_ConnectSelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_DisconnectSelected', the id declared for Add-in Button class 'DisconnectSelected'
            /// </summary>
            internal static string DisconnectSelected {
                get {
                    return "A4WaterUtilities_DisconnectSelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_CreateJumpsOver', the id declared for Add-in Button class 'CreateJumpsOver'
            /// </summary>
            internal static string CreateJumpsOver {
                get {
                    return "A4WaterUtilities_CreateJumpsOver";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_CreateJumpsUnder', the id declared for Add-in Button class 'CreateJumpsUnder'
            /// </summary>
            internal static string CreateJumpsUnder {
                get {
                    return "A4WaterUtilities_CreateJumpsUnder";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ShowLayerWindow', the id declared for Add-in Button class 'ShowLayerWindow'
            /// </summary>
            internal static string ShowLayerWindow {
                get {
                    return "A4WaterUtilities_ShowLayerWindow";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ShowFlowArrows', the id declared for Add-in Button class 'ShowFlowArrows'
            /// </summary>
            internal static string ShowFlowArrows {
                get {
                    return "A4WaterUtilities_ShowFlowArrows";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_FlipLines', the id declared for Add-in Button class 'FlipLines'
            /// </summary>
            internal static string FlipLines {
                get {
                    return "A4WaterUtilities_FlipLines";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_FlipLinesFlow', the id declared for Add-in Button class 'FlipLinesFlow'
            /// </summary>
            internal static string FlipLinesFlow {
                get {
                    return "A4WaterUtilities_FlipLinesFlow";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_RotateSelected', the id declared for Add-in Button class 'RotateSelected'
            /// </summary>
            internal static string RotateSelected {
                get {
                    return "A4WaterUtilities_RotateSelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_AdditionalRotate', the id declared for Add-in Button class 'AdditionalRotate'
            /// </summary>
            internal static string AdditionalRotate {
                get {
                    return "A4WaterUtilities_AdditionalRotate";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_SplitLines', the id declared for Add-in Button class 'SplitLines'
            /// </summary>
            internal static string SplitLines {
                get {
                    return "A4WaterUtilities_SplitLines";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_SetMeasuresOnLines', the id declared for Add-in Button class 'SetMeasuresOnLines'
            /// </summary>
            internal static string SetMeasuresOnLines {
                get {
                    return "A4WaterUtilities_SetMeasuresOnLines";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_MergeGNLines', the id declared for Add-in Button class 'MergeGNLines'
            /// </summary>
            internal static string MergeGNLines {
                get {
                    return "A4WaterUtilities_MergeGNLines";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ExportToExcel', the id declared for Add-in Button class 'ExportToExcel'
            /// </summary>
            internal static string ExportToExcel {
                get {
                    return "A4WaterUtilities_ExportToExcel";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ShowConfigForm', the id declared for Add-in Button class 'ShowConfigForm'
            /// </summary>
            internal static string ShowConfigForm {
                get {
                    return "A4WaterUtilities_ShowConfigForm";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_IdentifySelected', the id declared for Add-in Button class 'IdentifySelected'
            /// </summary>
            internal static string IdentifySelected {
                get {
                    return "A4WaterUtilities_IdentifySelected";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_TraceSummaryIsolation', the id declared for Add-in Button class 'TraceSummaryIsolation'
            /// </summary>
            internal static string TraceSummaryIsolation {
                get {
                    return "A4WaterUtilities_TraceSummaryIsolation";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ToggleOperableStatus', the id declared for Add-in Tool class 'ToggleOperableStatus'
            /// </summary>
            internal static string ToggleOperableStatus {
                get {
                    return "A4WaterUtilities_ToggleOperableStatus";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ClearTraceResults', the id declared for Add-in Button class 'ClearTraceResults'
            /// </summary>
            internal static string ClearTraceResults {
                get {
                    return "A4WaterUtilities_ClearTraceResults";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_TraceIsolation', the id declared for Add-in Tool class 'TraceIsolation'
            /// </summary>
            internal static string TraceIsolation {
                get {
                    return "A4WaterUtilities_TraceIsolation";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_TraceIsolationRerun', the id declared for Add-in Button class 'TraceIsolationRerun'
            /// </summary>
            internal static string TraceIsolationRerun {
                get {
                    return "A4WaterUtilities_TraceIsolationRerun";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_TraceSecondaryIsolation', the id declared for Add-in Button class 'TraceSecondaryIsolation'
            /// </summary>
            internal static string TraceSecondaryIsolation {
                get {
                    return "A4WaterUtilities_TraceSecondaryIsolation";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_TraceUpstream', the id declared for Add-in Tool class 'TraceUpstream'
            /// </summary>
            internal static string TraceUpstream {
                get {
                    return "A4WaterUtilities_TraceUpstream";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_TraceDownstream', the id declared for Add-in Tool class 'TraceDownstream'
            /// </summary>
            internal static string TraceDownstream {
                get {
                    return "A4WaterUtilities_TraceDownstream";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_FlowAccumulation', the id declared for Add-in Button class 'FlowAccumulation'
            /// </summary>
            internal static string FlowAccumulation {
                get {
                    return "A4WaterUtilities_FlowAccumulation";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_FlowAccumulationLoc', the id declared for Add-in Tool class 'FlowAccumulationLoc'
            /// </summary>
            internal static string FlowAccumulationLoc {
                get {
                    return "A4WaterUtilities_FlowAccumulationLoc";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_AddFlag', the id declared for Add-in Tool class 'AddFlag'
            /// </summary>
            internal static string AddFlag {
                get {
                    return "A4WaterUtilities_AddFlag";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_AddBarrier', the id declared for Add-in Tool class 'AddBarrier'
            /// </summary>
            internal static string AddBarrier {
                get {
                    return "A4WaterUtilities_AddBarrier";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_RemoveFlagBarrier', the id declared for Add-in Tool class 'RemoveFlagBarrier'
            /// </summary>
            internal static string RemoveFlagBarrier {
                get {
                    return "A4WaterUtilities_RemoveFlagBarrier";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_SelectJunctionsByEdgeCount', the id declared for Add-in Button class 'SelectByJunctionEdgeCount'
            /// </summary>
            internal static string SelectByJunctionEdgeCount {
                get {
                    return "A4WaterUtilities_SelectJunctionsByEdgeCount";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_ConnectClosests', the id declared for Add-in Button class 'ConnectClosests'
            /// </summary>
            internal static string ConnectClosests {
                get {
                    return "A4WaterUtilities_ConnectClosests";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_SewerProfile', the id declared for Add-in Tool class 'SewerProfile'
            /// </summary>
            internal static string SewerProfile {
                get {
                    return "A4WaterUtilities_SewerProfile";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_EstablishFlowAncillary', the id declared for Add-in Button class 'EstablishFlowAncillary'
            /// </summary>
            internal static string EstablishFlowAncillary {
                get {
                    return "A4WaterUtilities_EstablishFlowAncillary";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_EstablishFlowDigitized', the id declared for Add-in Button class 'EstablishFlowDigitized'
            /// </summary>
            internal static string EstablishFlowDigitized {
                get {
                    return "A4WaterUtilities_EstablishFlowDigitized";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_AttributeTransferLoader', the id declared for Add-in Button class 'AttributeTransferLoaderButton'
            /// </summary>
            internal static string AttributeTransferLoaderButton {
                get {
                    return "A4WaterUtilities_AttributeTransferLoader";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_FlagsBarriersToLayer', the id declared for Add-in Button class 'FlagsBarriersToLayer'
            /// </summary>
            internal static string FlagsBarriersToLayer {
                get {
                    return "A4WaterUtilities_FlagsBarriersToLayer";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_BatchLoadBarriers', the id declared for Add-in Button class 'BatchLoadBarriers'
            /// </summary>
            internal static string BatchLoadBarriers {
                get {
                    return "A4WaterUtilities_BatchLoadBarriers";
                }
            }
            
            /// <summary>
            /// Returns 'A4WaterUtilities_LayerViewer', the id declared for Add-in DockableWindow class 'LayerWindow+AddinImpl'
            /// </summary>
            internal static string LayerWindow {
                get {
                    return "A4WaterUtilities_LayerViewer";
                }
            }
            
            /// <summary>
            /// Returns 'Esri_A4WaterUtilities_AddLateralsConstructionTool', the id declared for Add-in Tool class 'AddLateralsConstructionTool'
            /// </summary>
            internal static string AddLateralsConstructionTool {
                get {
                    return "Esri_A4WaterUtilities_AddLateralsConstructionTool";
                }
            }
            
            /// <summary>
            /// Returns 'Esri_A4WaterUtilities_AddLateralsFromMainPointConstructionTool', the id declared for Add-in Tool class 'AddLateralsFromMainPointConstructionTool'
            /// </summary>
            internal static string AddLateralsFromMainPointConstructionTool {
                get {
                    return "Esri_A4WaterUtilities_AddLateralsFromMainPointConstructionTool";
                }
            }
            
            /// <summary>
            /// Returns 'Esri_A4WaterUtilities_AddPointSplitLine', the id declared for Add-in Tool class 'AddPointSplitLine'
            /// </summary>
            internal static string AddPointSplitLine {
                get {
                    return "Esri_A4WaterUtilities_AddPointSplitLine";
                }
            }
            
            /// <summary>
            /// Returns 'Esri_A4WaterUtilities_ConnectClosestsConstructTool', the id declared for Add-in Tool class 'ConnectClosestsConstructTool'
            /// </summary>
            internal static string ConnectClosestsConstructTool {
                get {
                    return "Esri_A4WaterUtilities_ConnectClosestsConstructTool";
                }
            }
            
            /// <summary>
            /// Returns 'Esri_A4WaterUtilities_AddLineWithEndPoints', the id declared for Add-in Tool class 'AddLineWithEndPoints'
            /// </summary>
            internal static string AddLineWithEndPoints {
                get {
                    return "Esri_A4WaterUtilities_AddLineWithEndPoints";
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
