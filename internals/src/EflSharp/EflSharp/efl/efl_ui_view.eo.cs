#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>Efl UI view interface</summary>
[Efl.Ui.IViewConcrete.NativeMethods]
public interface IView : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Model that is/will be</summary>
/// <returns>Efl model</returns>
Efl.IModel GetModel();
    /// <summary>Model that is/will be</summary>
/// <param name="model">Efl model</param>
void SetModel(Efl.IModel model);
            /// <summary>Model that is/will be</summary>
    /// <value>Efl model</value>
    Efl.IModel Model {
        get ;
        set ;
    }
}
/// <summary>Efl UI view interface</summary>
sealed public class IViewConcrete :
    Efl.Eo.EoWrapper
    , IView
    
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(IViewConcrete))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_ui_view_interface_get();
    /// <summary>Initializes a new instance of the <see cref="IView"/> class.
    /// Internal usage: This is used when interacting with C code and should not be used directly.</summary>
    private IViewConcrete(System.IntPtr raw) : base(raw)
    {
    }

    /// <summary>Model that is/will be</summary>
    /// <returns>Efl model</returns>
    public Efl.IModel GetModel() {
         var _ret_var = Efl.Ui.IViewConcrete.NativeMethods.efl_ui_view_model_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Model that is/will be</summary>
    /// <param name="model">Efl model</param>
    public void SetModel(Efl.IModel model) {
                                 Efl.Ui.IViewConcrete.NativeMethods.efl_ui_view_model_set_ptr.Value.Delegate(this.NativeHandle,model);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Model that is/will be</summary>
    /// <value>Efl model</value>
    public Efl.IModel Model {
        get { return GetModel(); }
        set { SetModel(value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.IViewConcrete.efl_ui_view_interface_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public class NativeMethods  : Efl.Eo.NativeClass
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Efl);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_view_model_get_static_delegate == null)
            {
                efl_ui_view_model_get_static_delegate = new efl_ui_view_model_get_delegate(model_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetModel") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_view_model_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_view_model_get_static_delegate) });
            }

            if (efl_ui_view_model_set_static_delegate == null)
            {
                efl_ui_view_model_set_static_delegate = new efl_ui_view_model_set_delegate(model_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetModel") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_view_model_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_view_model_set_static_delegate) });
            }

            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.IViewConcrete.efl_ui_view_interface_get();
        }

        #pragma warning disable CA1707, CS1591, SA1300, SA1600

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.IModel efl_ui_view_model_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.IModel efl_ui_view_model_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_view_model_get_api_delegate> efl_ui_view_model_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_view_model_get_api_delegate>(Module, "efl_ui_view_model_get");

        private static Efl.IModel model_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_view_model_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            Efl.IModel _ret_var = default(Efl.IModel);
                try
                {
                    _ret_var = ((IView)ws.Target).GetModel();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_ui_view_model_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_view_model_get_delegate efl_ui_view_model_get_static_delegate;

        
        private delegate void efl_ui_view_model_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.IModel model);

        
        public delegate void efl_ui_view_model_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.IModel model);

        public static Efl.Eo.FunctionWrapper<efl_ui_view_model_set_api_delegate> efl_ui_view_model_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_view_model_set_api_delegate>(Module, "efl_ui_view_model_set");

        private static void model_set(System.IntPtr obj, System.IntPtr pd, Efl.IModel model)
        {
            Eina.Log.Debug("function efl_ui_view_model_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((IView)ws.Target).SetModel(model);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_view_model_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), model);
            }
        }

        private static efl_ui_view_model_set_delegate efl_ui_view_model_set_static_delegate;

        #pragma warning restore CA1707, CS1591, SA1300, SA1600

}
}
}

}

