#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

namespace ActiveView {

/// <summary>Object used by <see cref="Efl.Ui.ActiveView.Container"/> to render an indication of the active view&apos;s position among the rest of the container&apos;s views.
/// An example would be Android&apos;s little dots in the home screen.</summary>
[Efl.Ui.ActiveView.Indicator.NativeMethods]
public abstract class Indicator : Efl.Object
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(Indicator))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
        efl_ui_active_view_indicator_class_get();
    /// <summary>Initializes a new instance of the <see cref="Indicator"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public Indicator(Efl.Object parent= null
            ) : base(efl_ui_active_view_indicator_class_get(), typeof(Indicator), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="Indicator"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected Indicator(System.IntPtr raw) : base(raw)
    {
    }

    [Efl.Eo.PrivateNativeClass]
    private class IndicatorRealized : Indicator
    {
        private IndicatorRealized(IntPtr ptr) : base(ptr)
        {
        }
    }
    /// <summary>Initializes a new instance of the <see cref="Indicator"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected Indicator(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
    }

    /// <summary>This method is called the first time an <see cref="Efl.Ui.ActiveView.Indicator"/> is assigned to an <see cref="Efl.Ui.ActiveView.Container"/>, binding them together.
    /// This call can be used to setup the indicator part of the <c>active_view</c>.
    /// 
    /// The Active View of the container (if there is any) will be informed to the indicator by a later call to <see cref="Efl.Ui.ActiveView.Indicator.UpdatePosition"/>.</summary>
    /// <param name="active_view">The container to bind this indicator to.</param>
    virtual public void Bind(Efl.Ui.ActiveView.Container active_view) {
                                 Efl.Ui.ActiveView.Indicator.NativeMethods.efl_ui_active_view_indicator_bind_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),active_view);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>A <c>subobj</c> has been added at position <c>index</c> in the bound container.
    /// The manager should check the container&apos;s <see cref="Efl.Ui.ActiveView.Container.ActiveIndex"/> since indices might have shifted due to the insertion of the new object.</summary>
    /// <param name="subobj">The new object that has been added to the container.</param>
    /// <param name="index">The index of the new object in the container&apos;s list.</param>
    virtual public void AddContent(Efl.Gfx.IEntity subobj, int index) {
                                                         Efl.Ui.ActiveView.Indicator.NativeMethods.efl_ui_active_view_indicator_content_add_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj, index);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>The <c>subobj</c> at position <c>index</c> in the bound container has been removed.
    /// The manager should check the container&apos;s <see cref="Efl.Ui.ActiveView.Container.ActiveIndex"/> since indices might have shifted due to the removal of the object.</summary>
    /// <param name="subobj">The object being removed from the container.</param>
    /// <param name="index">The index this object had in the container&apos;s list.</param>
    virtual public void DelContent(Efl.Gfx.IEntity subobj, int index) {
                                                         Efl.Ui.ActiveView.Indicator.NativeMethods.efl_ui_active_view_indicator_content_del_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),subobj, index);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>This method tells the indicator that <see cref="Efl.Ui.ActiveView.Container.ActiveIndex"/> has changed in the bound container.
    /// <c>position</c> ranges from -1 to the number of views in the bound container (<see cref="Efl.IContainer.ContentCount"/>). Notice this allows moving to a position before the first view or past the last view, which might happen if the view is thumb-scrolled out-of-bounds. Indicators can choose to render these out-of-bounds positions or not.
    /// 
    /// Fractional values indicate positions in-between two views and should be respected to obtain a smooth transition.</summary>
    /// <param name="position">The index of the active view, or a value in-between views if a transition is currently playing.</param>
    virtual public void UpdatePosition(double position) {
                                 Efl.Ui.ActiveView.Indicator.NativeMethods.efl_ui_active_view_indicator_position_update_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),position);
        Eina.Error.RaiseIfUnhandledException();
                         }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.ActiveView.Indicator.efl_ui_active_view_indicator_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Object.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_active_view_indicator_bind_static_delegate == null)
            {
                efl_ui_active_view_indicator_bind_static_delegate = new efl_ui_active_view_indicator_bind_delegate(bind);
            }

            if (methods.FirstOrDefault(m => m.Name == "Bind") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_active_view_indicator_bind"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_active_view_indicator_bind_static_delegate) });
            }

            if (efl_ui_active_view_indicator_content_add_static_delegate == null)
            {
                efl_ui_active_view_indicator_content_add_static_delegate = new efl_ui_active_view_indicator_content_add_delegate(content_add);
            }

            if (methods.FirstOrDefault(m => m.Name == "AddContent") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_active_view_indicator_content_add"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_active_view_indicator_content_add_static_delegate) });
            }

            if (efl_ui_active_view_indicator_content_del_static_delegate == null)
            {
                efl_ui_active_view_indicator_content_del_static_delegate = new efl_ui_active_view_indicator_content_del_delegate(content_del);
            }

            if (methods.FirstOrDefault(m => m.Name == "DelContent") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_active_view_indicator_content_del"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_active_view_indicator_content_del_static_delegate) });
            }

            if (efl_ui_active_view_indicator_position_update_static_delegate == null)
            {
                efl_ui_active_view_indicator_position_update_static_delegate = new efl_ui_active_view_indicator_position_update_delegate(position_update);
            }

            if (methods.FirstOrDefault(m => m.Name == "UpdatePosition") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_active_view_indicator_position_update"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_active_view_indicator_position_update_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.ActiveView.Indicator.efl_ui_active_view_indicator_class_get();
        }

        #pragma warning disable CA1707, CS1591, SA1300, SA1600

        
        private delegate void efl_ui_active_view_indicator_bind_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Ui.ActiveView.Container active_view);

        
        public delegate void efl_ui_active_view_indicator_bind_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Ui.ActiveView.Container active_view);

        public static Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_bind_api_delegate> efl_ui_active_view_indicator_bind_ptr = new Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_bind_api_delegate>(Module, "efl_ui_active_view_indicator_bind");

        private static void bind(System.IntPtr obj, System.IntPtr pd, Efl.Ui.ActiveView.Container active_view)
        {
            Eina.Log.Debug("function efl_ui_active_view_indicator_bind was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((Indicator)ws.Target).Bind(active_view);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_active_view_indicator_bind_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), active_view);
            }
        }

        private static efl_ui_active_view_indicator_bind_delegate efl_ui_active_view_indicator_bind_static_delegate;

        
        private delegate void efl_ui_active_view_indicator_content_add_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj,  int index);

        
        public delegate void efl_ui_active_view_indicator_content_add_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_content_add_api_delegate> efl_ui_active_view_indicator_content_add_ptr = new Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_content_add_api_delegate>(Module, "efl_ui_active_view_indicator_content_add");

        private static void content_add(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj, int index)
        {
            Eina.Log.Debug("function efl_ui_active_view_indicator_content_add was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            
                try
                {
                    ((Indicator)ws.Target).AddContent(subobj, index);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_active_view_indicator_content_add_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj, index);
            }
        }

        private static efl_ui_active_view_indicator_content_add_delegate efl_ui_active_view_indicator_content_add_static_delegate;

        
        private delegate void efl_ui_active_view_indicator_content_del_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj,  int index);

        
        public delegate void efl_ui_active_view_indicator_content_del_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Gfx.IEntity subobj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_content_del_api_delegate> efl_ui_active_view_indicator_content_del_ptr = new Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_content_del_api_delegate>(Module, "efl_ui_active_view_indicator_content_del");

        private static void content_del(System.IntPtr obj, System.IntPtr pd, Efl.Gfx.IEntity subobj, int index)
        {
            Eina.Log.Debug("function efl_ui_active_view_indicator_content_del was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            
                try
                {
                    ((Indicator)ws.Target).DelContent(subobj, index);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_active_view_indicator_content_del_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), subobj, index);
            }
        }

        private static efl_ui_active_view_indicator_content_del_delegate efl_ui_active_view_indicator_content_del_static_delegate;

        
        private delegate void efl_ui_active_view_indicator_position_update_delegate(System.IntPtr obj, System.IntPtr pd,  double position);

        
        public delegate void efl_ui_active_view_indicator_position_update_api_delegate(System.IntPtr obj,  double position);

        public static Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_position_update_api_delegate> efl_ui_active_view_indicator_position_update_ptr = new Efl.Eo.FunctionWrapper<efl_ui_active_view_indicator_position_update_api_delegate>(Module, "efl_ui_active_view_indicator_position_update");

        private static void position_update(System.IntPtr obj, System.IntPtr pd, double position)
        {
            Eina.Log.Debug("function efl_ui_active_view_indicator_position_update was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((Indicator)ws.Target).UpdatePosition(position);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_active_view_indicator_position_update_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), position);
            }
        }

        private static efl_ui_active_view_indicator_position_update_delegate efl_ui_active_view_indicator_position_update_static_delegate;

        #pragma warning restore CA1707, CS1591, SA1300, SA1600

}
}
}

}

}

