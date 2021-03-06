#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>Common interface for draggable objects and parts.</summary>
[Efl.Ui.IDragConcrete.NativeMethods]
public interface IDrag : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Gets the draggable object location.</summary>
/// <param name="dx">The x relative position, from 0 to 1.</param>
/// <param name="dy">The y relative position, from 0 to 1.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool GetDragValue(out double dx, out double dy);
    /// <summary>Sets the draggable object location.
/// This places the draggable object at the given location.</summary>
/// <param name="dx">The x relative position, from 0 to 1.</param>
/// <param name="dy">The y relative position, from 0 to 1.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool SetDragValue(double dx, double dy);
    /// <summary>Gets the size of the dradgable object.</summary>
/// <param name="dw">The drag relative width, from 0 to 1.</param>
/// <param name="dh">The drag relative height, from 0 to 1.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool GetDragSize(out double dw, out double dh);
    /// <summary>Sets the size of the draggable object.</summary>
/// <param name="dw">The drag relative width, from 0 to 1.</param>
/// <param name="dh">The drag relative height, from 0 to 1.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool SetDragSize(double dw, double dh);
    /// <summary>Gets the draggable direction.</summary>
/// <returns>The direction(s) premitted for drag.</returns>
Efl.Ui.DragDir GetDragDir();
    /// <summary>Gets the x and y step increments for the draggable object.</summary>
/// <param name="dx">The x step relative amount, from 0 to 1.</param>
/// <param name="dy">The y step relative amount, from 0 to 1.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool GetDragStep(out double dx, out double dy);
    /// <summary>Sets the x,y step increments for a draggable object.</summary>
/// <param name="dx">The x step relative amount, from 0 to 1.</param>
/// <param name="dy">The y step relative amount, from 0 to 1.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool SetDragStep(double dx, double dy);
    /// <summary>Gets the x,y page step increments for the draggable object.</summary>
/// <param name="dx">The x page step increment</param>
/// <param name="dy">The y page step increment</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool GetDragPage(out double dx, out double dy);
    /// <summary>Sets the x,y page step increment values.</summary>
/// <param name="dx">The x page step increment</param>
/// <param name="dy">The y page step increment</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool SetDragPage(double dx, double dy);
    /// <summary>Moves the draggable by <c>dx</c>,<c>dy</c> steps.
/// This moves the draggable part by <c>dx</c>,<c>dy</c> steps where the step increment is the amount set by <see cref="Efl.Ui.IDrag.GetDragStep"/>.
/// 
/// <c>dx</c> and <c>dy</c> can be positive or negative numbers, integer values are recommended.</summary>
/// <param name="dx">The number of steps horizontally.</param>
/// <param name="dy">The number of steps vertically.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool MoveDragStep(double dx, double dy);
    /// <summary>Moves the draggable by <c>dx</c>,<c>dy</c> pages.
/// This moves the draggable by <c>dx</c>,<c>dy</c> pages. The increment is defined by <see cref="Efl.Ui.IDrag.GetDragPage"/>.
/// 
/// <c>dx</c> and <c>dy</c> can be positive or negative numbers, integer values are recommended.
/// 
/// Warning: Paging is bugged!</summary>
/// <param name="dx">The number of pages horizontally.</param>
/// <param name="dy">The number of pages vertically.</param>
/// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
bool MoveDragPage(double dx, double dy);
                                                /// <summary>Determines the draggable directions (read-only).
    /// The draggable directions are defined in the EDC file, inside the &quot;draggable&quot; section, by the attributes <c>x</c> and <c>y</c>. See the EDC reference documentation for more information.</summary>
    /// <value>The direction(s) premitted for drag.</value>
    Efl.Ui.DragDir DragDir {
        get ;
    }
}
/// <summary>Common interface for draggable objects and parts.</summary>
sealed public class IDragConcrete :
    Efl.Eo.EoWrapper
    , IDrag
    
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(IDragConcrete))
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
        efl_ui_drag_interface_get();
    /// <summary>Initializes a new instance of the <see cref="IDrag"/> class.
    /// Internal usage: This is used when interacting with C code and should not be used directly.</summary>
    private IDragConcrete(System.IntPtr raw) : base(raw)
    {
    }

    /// <summary>Gets the draggable object location.</summary>
    /// <param name="dx">The x relative position, from 0 to 1.</param>
    /// <param name="dy">The y relative position, from 0 to 1.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool GetDragValue(out double dx, out double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_value_get_ptr.Value.Delegate(this.NativeHandle,out dx, out dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Sets the draggable object location.
    /// This places the draggable object at the given location.</summary>
    /// <param name="dx">The x relative position, from 0 to 1.</param>
    /// <param name="dy">The y relative position, from 0 to 1.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool SetDragValue(double dx, double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_value_set_ptr.Value.Delegate(this.NativeHandle,dx, dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Gets the size of the dradgable object.</summary>
    /// <param name="dw">The drag relative width, from 0 to 1.</param>
    /// <param name="dh">The drag relative height, from 0 to 1.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool GetDragSize(out double dw, out double dh) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_size_get_ptr.Value.Delegate(this.NativeHandle,out dw, out dh);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Sets the size of the draggable object.</summary>
    /// <param name="dw">The drag relative width, from 0 to 1.</param>
    /// <param name="dh">The drag relative height, from 0 to 1.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool SetDragSize(double dw, double dh) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_size_set_ptr.Value.Delegate(this.NativeHandle,dw, dh);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Gets the draggable direction.</summary>
    /// <returns>The direction(s) premitted for drag.</returns>
    public Efl.Ui.DragDir GetDragDir() {
         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_dir_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Gets the x and y step increments for the draggable object.</summary>
    /// <param name="dx">The x step relative amount, from 0 to 1.</param>
    /// <param name="dy">The y step relative amount, from 0 to 1.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool GetDragStep(out double dx, out double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_step_get_ptr.Value.Delegate(this.NativeHandle,out dx, out dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Sets the x,y step increments for a draggable object.</summary>
    /// <param name="dx">The x step relative amount, from 0 to 1.</param>
    /// <param name="dy">The y step relative amount, from 0 to 1.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool SetDragStep(double dx, double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_step_set_ptr.Value.Delegate(this.NativeHandle,dx, dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Gets the x,y page step increments for the draggable object.</summary>
    /// <param name="dx">The x page step increment</param>
    /// <param name="dy">The y page step increment</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool GetDragPage(out double dx, out double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_page_get_ptr.Value.Delegate(this.NativeHandle,out dx, out dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Sets the x,y page step increment values.</summary>
    /// <param name="dx">The x page step increment</param>
    /// <param name="dy">The y page step increment</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool SetDragPage(double dx, double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_page_set_ptr.Value.Delegate(this.NativeHandle,dx, dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Moves the draggable by <c>dx</c>,<c>dy</c> steps.
    /// This moves the draggable part by <c>dx</c>,<c>dy</c> steps where the step increment is the amount set by <see cref="Efl.Ui.IDrag.GetDragStep"/>.
    /// 
    /// <c>dx</c> and <c>dy</c> can be positive or negative numbers, integer values are recommended.</summary>
    /// <param name="dx">The number of steps horizontally.</param>
    /// <param name="dy">The number of steps vertically.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool MoveDragStep(double dx, double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_step_move_ptr.Value.Delegate(this.NativeHandle,dx, dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Moves the draggable by <c>dx</c>,<c>dy</c> pages.
    /// This moves the draggable by <c>dx</c>,<c>dy</c> pages. The increment is defined by <see cref="Efl.Ui.IDrag.GetDragPage"/>.
    /// 
    /// <c>dx</c> and <c>dy</c> can be positive or negative numbers, integer values are recommended.
    /// 
    /// Warning: Paging is bugged!</summary>
    /// <param name="dx">The number of pages horizontally.</param>
    /// <param name="dy">The number of pages vertically.</param>
    /// <returns><c>true</c> on success, <c>false</c> otherwise</returns>
    public bool MoveDragPage(double dx, double dy) {
                                                         var _ret_var = Efl.Ui.IDragConcrete.NativeMethods.efl_ui_drag_page_move_ptr.Value.Delegate(this.NativeHandle,dx, dy);
        Eina.Error.RaiseIfUnhandledException();
                                        return _ret_var;
 }
    /// <summary>Determines the draggable directions (read-only).
    /// The draggable directions are defined in the EDC file, inside the &quot;draggable&quot; section, by the attributes <c>x</c> and <c>y</c>. See the EDC reference documentation for more information.</summary>
    /// <value>The direction(s) premitted for drag.</value>
    public Efl.Ui.DragDir DragDir {
        get { return GetDragDir(); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.IDragConcrete.efl_ui_drag_interface_get();
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

            if (efl_ui_drag_value_get_static_delegate == null)
            {
                efl_ui_drag_value_get_static_delegate = new efl_ui_drag_value_get_delegate(drag_value_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetDragValue") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_value_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_value_get_static_delegate) });
            }

            if (efl_ui_drag_value_set_static_delegate == null)
            {
                efl_ui_drag_value_set_static_delegate = new efl_ui_drag_value_set_delegate(drag_value_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetDragValue") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_value_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_value_set_static_delegate) });
            }

            if (efl_ui_drag_size_get_static_delegate == null)
            {
                efl_ui_drag_size_get_static_delegate = new efl_ui_drag_size_get_delegate(drag_size_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetDragSize") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_size_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_size_get_static_delegate) });
            }

            if (efl_ui_drag_size_set_static_delegate == null)
            {
                efl_ui_drag_size_set_static_delegate = new efl_ui_drag_size_set_delegate(drag_size_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetDragSize") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_size_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_size_set_static_delegate) });
            }

            if (efl_ui_drag_dir_get_static_delegate == null)
            {
                efl_ui_drag_dir_get_static_delegate = new efl_ui_drag_dir_get_delegate(drag_dir_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetDragDir") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_dir_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_dir_get_static_delegate) });
            }

            if (efl_ui_drag_step_get_static_delegate == null)
            {
                efl_ui_drag_step_get_static_delegate = new efl_ui_drag_step_get_delegate(drag_step_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetDragStep") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_step_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_step_get_static_delegate) });
            }

            if (efl_ui_drag_step_set_static_delegate == null)
            {
                efl_ui_drag_step_set_static_delegate = new efl_ui_drag_step_set_delegate(drag_step_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetDragStep") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_step_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_step_set_static_delegate) });
            }

            if (efl_ui_drag_page_get_static_delegate == null)
            {
                efl_ui_drag_page_get_static_delegate = new efl_ui_drag_page_get_delegate(drag_page_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetDragPage") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_page_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_page_get_static_delegate) });
            }

            if (efl_ui_drag_page_set_static_delegate == null)
            {
                efl_ui_drag_page_set_static_delegate = new efl_ui_drag_page_set_delegate(drag_page_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetDragPage") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_page_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_page_set_static_delegate) });
            }

            if (efl_ui_drag_step_move_static_delegate == null)
            {
                efl_ui_drag_step_move_static_delegate = new efl_ui_drag_step_move_delegate(drag_step_move);
            }

            if (methods.FirstOrDefault(m => m.Name == "MoveDragStep") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_step_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_step_move_static_delegate) });
            }

            if (efl_ui_drag_page_move_static_delegate == null)
            {
                efl_ui_drag_page_move_static_delegate = new efl_ui_drag_page_move_delegate(drag_page_move);
            }

            if (methods.FirstOrDefault(m => m.Name == "MoveDragPage") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_drag_page_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_drag_page_move_static_delegate) });
            }

            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.IDragConcrete.efl_ui_drag_interface_get();
        }

        #pragma warning disable CA1707, CS1591, SA1300, SA1600

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_value_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double dx,  out double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_value_get_api_delegate(System.IntPtr obj,  out double dx,  out double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_value_get_api_delegate> efl_ui_drag_value_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_value_get_api_delegate>(Module, "efl_ui_drag_value_get");

        private static bool drag_value_get(System.IntPtr obj, System.IntPtr pd, out double dx, out double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_value_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                        dx = default(double);        dy = default(double);                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).GetDragValue(out dx, out dy);
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
                return efl_ui_drag_value_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out dx, out dy);
            }
        }

        private static efl_ui_drag_value_get_delegate efl_ui_drag_value_get_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_value_set_delegate(System.IntPtr obj, System.IntPtr pd,  double dx,  double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_value_set_api_delegate(System.IntPtr obj,  double dx,  double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_value_set_api_delegate> efl_ui_drag_value_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_value_set_api_delegate>(Module, "efl_ui_drag_value_set");

        private static bool drag_value_set(System.IntPtr obj, System.IntPtr pd, double dx, double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_value_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).SetDragValue(dx, dy);
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
                return efl_ui_drag_value_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), dx, dy);
            }
        }

        private static efl_ui_drag_value_set_delegate efl_ui_drag_value_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_size_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double dw,  out double dh);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_size_get_api_delegate(System.IntPtr obj,  out double dw,  out double dh);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_size_get_api_delegate> efl_ui_drag_size_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_size_get_api_delegate>(Module, "efl_ui_drag_size_get");

        private static bool drag_size_get(System.IntPtr obj, System.IntPtr pd, out double dw, out double dh)
        {
            Eina.Log.Debug("function efl_ui_drag_size_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                        dw = default(double);        dh = default(double);                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).GetDragSize(out dw, out dh);
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
                return efl_ui_drag_size_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out dw, out dh);
            }
        }

        private static efl_ui_drag_size_get_delegate efl_ui_drag_size_get_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_size_set_delegate(System.IntPtr obj, System.IntPtr pd,  double dw,  double dh);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_size_set_api_delegate(System.IntPtr obj,  double dw,  double dh);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_size_set_api_delegate> efl_ui_drag_size_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_size_set_api_delegate>(Module, "efl_ui_drag_size_set");

        private static bool drag_size_set(System.IntPtr obj, System.IntPtr pd, double dw, double dh)
        {
            Eina.Log.Debug("function efl_ui_drag_size_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).SetDragSize(dw, dh);
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
                return efl_ui_drag_size_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), dw, dh);
            }
        }

        private static efl_ui_drag_size_set_delegate efl_ui_drag_size_set_static_delegate;

        
        private delegate Efl.Ui.DragDir efl_ui_drag_dir_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Efl.Ui.DragDir efl_ui_drag_dir_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_dir_get_api_delegate> efl_ui_drag_dir_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_dir_get_api_delegate>(Module, "efl_ui_drag_dir_get");

        private static Efl.Ui.DragDir drag_dir_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_drag_dir_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            Efl.Ui.DragDir _ret_var = default(Efl.Ui.DragDir);
                try
                {
                    _ret_var = ((IDrag)ws.Target).GetDragDir();
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
                return efl_ui_drag_dir_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_drag_dir_get_delegate efl_ui_drag_dir_get_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_step_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double dx,  out double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_step_get_api_delegate(System.IntPtr obj,  out double dx,  out double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_step_get_api_delegate> efl_ui_drag_step_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_step_get_api_delegate>(Module, "efl_ui_drag_step_get");

        private static bool drag_step_get(System.IntPtr obj, System.IntPtr pd, out double dx, out double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_step_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                        dx = default(double);        dy = default(double);                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).GetDragStep(out dx, out dy);
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
                return efl_ui_drag_step_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out dx, out dy);
            }
        }

        private static efl_ui_drag_step_get_delegate efl_ui_drag_step_get_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_step_set_delegate(System.IntPtr obj, System.IntPtr pd,  double dx,  double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_step_set_api_delegate(System.IntPtr obj,  double dx,  double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_step_set_api_delegate> efl_ui_drag_step_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_step_set_api_delegate>(Module, "efl_ui_drag_step_set");

        private static bool drag_step_set(System.IntPtr obj, System.IntPtr pd, double dx, double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_step_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).SetDragStep(dx, dy);
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
                return efl_ui_drag_step_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), dx, dy);
            }
        }

        private static efl_ui_drag_step_set_delegate efl_ui_drag_step_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_page_get_delegate(System.IntPtr obj, System.IntPtr pd,  out double dx,  out double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_page_get_api_delegate(System.IntPtr obj,  out double dx,  out double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_page_get_api_delegate> efl_ui_drag_page_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_page_get_api_delegate>(Module, "efl_ui_drag_page_get");

        private static bool drag_page_get(System.IntPtr obj, System.IntPtr pd, out double dx, out double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_page_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                        dx = default(double);        dy = default(double);                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).GetDragPage(out dx, out dy);
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
                return efl_ui_drag_page_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), out dx, out dy);
            }
        }

        private static efl_ui_drag_page_get_delegate efl_ui_drag_page_get_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_page_set_delegate(System.IntPtr obj, System.IntPtr pd,  double dx,  double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_page_set_api_delegate(System.IntPtr obj,  double dx,  double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_page_set_api_delegate> efl_ui_drag_page_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_page_set_api_delegate>(Module, "efl_ui_drag_page_set");

        private static bool drag_page_set(System.IntPtr obj, System.IntPtr pd, double dx, double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_page_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).SetDragPage(dx, dy);
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
                return efl_ui_drag_page_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), dx, dy);
            }
        }

        private static efl_ui_drag_page_set_delegate efl_ui_drag_page_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_step_move_delegate(System.IntPtr obj, System.IntPtr pd,  double dx,  double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_step_move_api_delegate(System.IntPtr obj,  double dx,  double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_step_move_api_delegate> efl_ui_drag_step_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_step_move_api_delegate>(Module, "efl_ui_drag_step_move");

        private static bool drag_step_move(System.IntPtr obj, System.IntPtr pd, double dx, double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_step_move was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).MoveDragStep(dx, dy);
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
                return efl_ui_drag_step_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), dx, dy);
            }
        }

        private static efl_ui_drag_step_move_delegate efl_ui_drag_step_move_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_drag_page_move_delegate(System.IntPtr obj, System.IntPtr pd,  double dx,  double dy);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_drag_page_move_api_delegate(System.IntPtr obj,  double dx,  double dy);

        public static Efl.Eo.FunctionWrapper<efl_ui_drag_page_move_api_delegate> efl_ui_drag_page_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_drag_page_move_api_delegate>(Module, "efl_ui_drag_page_move");

        private static bool drag_page_move(System.IntPtr obj, System.IntPtr pd, double dx, double dy)
        {
            Eina.Log.Debug("function efl_ui_drag_page_move was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((IDrag)ws.Target).MoveDragPage(dx, dy);
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
                return efl_ui_drag_page_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), dx, dy);
            }
        }

        private static efl_ui_drag_page_move_delegate efl_ui_drag_page_move_static_delegate;

        #pragma warning restore CA1707, CS1591, SA1300, SA1600

}
}
}

}

