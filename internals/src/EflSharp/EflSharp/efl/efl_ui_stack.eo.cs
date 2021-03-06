#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

///<summary>Event argument wrapper for event <see cref="Efl.Ui.Stack.LoadedEvt"/>.</summary>
public class StackLoadedEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Ui.StackEventLoaded arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.Stack.UnloadedEvt"/>.</summary>
public class StackUnloadedEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Ui.StackEventUnloaded arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.Stack.ActivatedEvt"/>.</summary>
public class StackActivatedEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Ui.StackEventActivated arg { get; set; }
}
///<summary>Event argument wrapper for event <see cref="Efl.Ui.Stack.DeactivatedEvt"/>.</summary>
public class StackDeactivatedEvt_Args : EventArgs {
    ///<summary>Actual event payload.</summary>
    public Efl.Ui.StackEventDeactivated arg { get; set; }
}
/// <summary>Stack widget.
/// Stack widget arranges objects in stack structure by pushing and poping them.</summary>
[Efl.Ui.Stack.NativeMethods]
public class Stack : Efl.Ui.LayoutBase
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(Stack))
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
        efl_ui_stack_class_get();
    /// <summary>Initializes a new instance of the <see cref="Stack"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    /// <param name="style">The widget style to use. See <see cref="Efl.Ui.Widget.SetStyle"/></param>
    public Stack(Efl.Object parent
            , System.String style = null) : base(efl_ui_stack_class_get(), typeof(Stack), parent)
    {
        if (Efl.Eo.Globals.ParamHelperCheck(style))
        {
            SetStyle(Efl.Eo.Globals.GetParamHelper(style));
        }

        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="Stack"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected Stack(System.IntPtr raw) : base(raw)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="Stack"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected Stack(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
    }

    /// <summary>Called when content is loaded right before transition.</summary>
    public event EventHandler<Efl.Ui.StackLoadedEvt_Args> LoadedEvt
    {
        add
        {
            lock (eventLock)
            {
                Efl.EventCb callerCb = (IntPtr data, ref Efl.Event.NativeStruct evt) =>
                {
                    var obj = Efl.Eo.Globals.WrapperSupervisorPtrToManaged(data).Target;
                    if (obj != null)
                    {
                        Efl.Ui.StackLoadedEvt_Args args = new Efl.Ui.StackLoadedEvt_Args();
                        args.arg =  evt.Info;
                        try
                        {
                            value?.Invoke(obj, args);
                        }
                        catch (Exception e)
                        {
                            Eina.Log.Error(e.ToString());
                            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                        }
                    }
                };

                string key = "_EFL_UI_STACK_EVENT_LOADED";
                AddNativeEventHandler(efl.Libs.Elementary, key, callerCb, value);
            }
        }

        remove
        {
            lock (eventLock)
            {
                string key = "_EFL_UI_STACK_EVENT_LOADED";
                RemoveNativeEventHandler(efl.Libs.Elementary, key, value);
            }
        }
    }
    ///<summary>Method to raise event LoadedEvt.</summary>
    public void OnLoadedEvt(Efl.Ui.StackLoadedEvt_Args e)
    {
        var key = "_EFL_UI_STACK_EVENT_LOADED";
        IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Elementary, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
            return;
        }

        IntPtr info = Marshal.AllocHGlobal(Marshal.SizeOf(e.arg));
        try
        {
            Marshal.StructureToPtr(e.arg, info, false);
            Efl.Eo.Globals.efl_event_callback_call(this.NativeHandle, desc, info);
        }
        finally
        {
            Marshal.FreeHGlobal(info);
        }
    }
    /// <summary>Called when content is unloaded right after being deactivated.</summary>
    public event EventHandler<Efl.Ui.StackUnloadedEvt_Args> UnloadedEvt
    {
        add
        {
            lock (eventLock)
            {
                Efl.EventCb callerCb = (IntPtr data, ref Efl.Event.NativeStruct evt) =>
                {
                    var obj = Efl.Eo.Globals.WrapperSupervisorPtrToManaged(data).Target;
                    if (obj != null)
                    {
                        Efl.Ui.StackUnloadedEvt_Args args = new Efl.Ui.StackUnloadedEvt_Args();
                        args.arg =  evt.Info;
                        try
                        {
                            value?.Invoke(obj, args);
                        }
                        catch (Exception e)
                        {
                            Eina.Log.Error(e.ToString());
                            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                        }
                    }
                };

                string key = "_EFL_UI_STACK_EVENT_UNLOADED";
                AddNativeEventHandler(efl.Libs.Elementary, key, callerCb, value);
            }
        }

        remove
        {
            lock (eventLock)
            {
                string key = "_EFL_UI_STACK_EVENT_UNLOADED";
                RemoveNativeEventHandler(efl.Libs.Elementary, key, value);
            }
        }
    }
    ///<summary>Method to raise event UnloadedEvt.</summary>
    public void OnUnloadedEvt(Efl.Ui.StackUnloadedEvt_Args e)
    {
        var key = "_EFL_UI_STACK_EVENT_UNLOADED";
        IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Elementary, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
            return;
        }

        IntPtr info = Marshal.AllocHGlobal(Marshal.SizeOf(e.arg));
        try
        {
            Marshal.StructureToPtr(e.arg, info, false);
            Efl.Eo.Globals.efl_event_callback_call(this.NativeHandle, desc, info);
        }
        finally
        {
            Marshal.FreeHGlobal(info);
        }
    }
    /// <summary>Called when content is activated right after transition.</summary>
    public event EventHandler<Efl.Ui.StackActivatedEvt_Args> ActivatedEvt
    {
        add
        {
            lock (eventLock)
            {
                Efl.EventCb callerCb = (IntPtr data, ref Efl.Event.NativeStruct evt) =>
                {
                    var obj = Efl.Eo.Globals.WrapperSupervisorPtrToManaged(data).Target;
                    if (obj != null)
                    {
                        Efl.Ui.StackActivatedEvt_Args args = new Efl.Ui.StackActivatedEvt_Args();
                        args.arg =  evt.Info;
                        try
                        {
                            value?.Invoke(obj, args);
                        }
                        catch (Exception e)
                        {
                            Eina.Log.Error(e.ToString());
                            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                        }
                    }
                };

                string key = "_EFL_UI_STACK_EVENT_ACTIVATED";
                AddNativeEventHandler(efl.Libs.Elementary, key, callerCb, value);
            }
        }

        remove
        {
            lock (eventLock)
            {
                string key = "_EFL_UI_STACK_EVENT_ACTIVATED";
                RemoveNativeEventHandler(efl.Libs.Elementary, key, value);
            }
        }
    }
    ///<summary>Method to raise event ActivatedEvt.</summary>
    public void OnActivatedEvt(Efl.Ui.StackActivatedEvt_Args e)
    {
        var key = "_EFL_UI_STACK_EVENT_ACTIVATED";
        IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Elementary, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
            return;
        }

        IntPtr info = Marshal.AllocHGlobal(Marshal.SizeOf(e.arg));
        try
        {
            Marshal.StructureToPtr(e.arg, info, false);
            Efl.Eo.Globals.efl_event_callback_call(this.NativeHandle, desc, info);
        }
        finally
        {
            Marshal.FreeHGlobal(info);
        }
    }
    /// <summary>Called when content is deactivated right after transition.</summary>
    public event EventHandler<Efl.Ui.StackDeactivatedEvt_Args> DeactivatedEvt
    {
        add
        {
            lock (eventLock)
            {
                Efl.EventCb callerCb = (IntPtr data, ref Efl.Event.NativeStruct evt) =>
                {
                    var obj = Efl.Eo.Globals.WrapperSupervisorPtrToManaged(data).Target;
                    if (obj != null)
                    {
                        Efl.Ui.StackDeactivatedEvt_Args args = new Efl.Ui.StackDeactivatedEvt_Args();
                        args.arg =  evt.Info;
                        try
                        {
                            value?.Invoke(obj, args);
                        }
                        catch (Exception e)
                        {
                            Eina.Log.Error(e.ToString());
                            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                        }
                    }
                };

                string key = "_EFL_UI_STACK_EVENT_DEACTIVATED";
                AddNativeEventHandler(efl.Libs.Elementary, key, callerCb, value);
            }
        }

        remove
        {
            lock (eventLock)
            {
                string key = "_EFL_UI_STACK_EVENT_DEACTIVATED";
                RemoveNativeEventHandler(efl.Libs.Elementary, key, value);
            }
        }
    }
    ///<summary>Method to raise event DeactivatedEvt.</summary>
    public void OnDeactivatedEvt(Efl.Ui.StackDeactivatedEvt_Args e)
    {
        var key = "_EFL_UI_STACK_EVENT_DEACTIVATED";
        IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Elementary, key);
        if (desc == IntPtr.Zero)
        {
            Eina.Log.Error($"Failed to get native event {key}");
            return;
        }

        IntPtr info = Marshal.AllocHGlobal(Marshal.SizeOf(e.arg));
        try
        {
            Marshal.StructureToPtr(e.arg, info, false);
            Efl.Eo.Globals.efl_event_callback_call(this.NativeHandle, desc, info);
        }
        finally
        {
            Marshal.FreeHGlobal(info);
        }
    }
    /// <summary>Pushes a new object to the top of the stack and shows it.</summary>
    /// <param name="content">The pushed object which becomes the top content of the stack.</param>
    virtual public void Push(Efl.Canvas.Object content) {
                                 Efl.Ui.Stack.NativeMethods.efl_ui_stack_push_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),content);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Pops the top content from the stack and deletes it.</summary>
    /// <returns>The top content which is removed from the stack.</returns>
    virtual public Efl.Canvas.Object Pop() {
         var _ret_var = Efl.Ui.Stack.NativeMethods.efl_ui_stack_pop_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Inserts an object before the given base content in the stack.</summary>
    /// <param name="base_content"><c>content</c> is inserted before this <c>base_content</c>.</param>
    /// <param name="content">The inserted object in the stack.</param>
    virtual public void InsertBefore(Efl.Canvas.Object base_content, Efl.Canvas.Object content) {
                                                         Efl.Ui.Stack.NativeMethods.efl_ui_stack_insert_before_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),base_content, content);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Inserts an object after the given base content in the stack.</summary>
    /// <param name="base_content"><c>content</c> is inserted after this <c>base_content</c>.</param>
    /// <param name="content">The inserted object in the stack.</param>
    virtual public void InsertAfter(Efl.Canvas.Object base_content, Efl.Canvas.Object content) {
                                                         Efl.Ui.Stack.NativeMethods.efl_ui_stack_insert_after_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),base_content, content);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Inserts an object at the given place in the stack.</summary>
    /// <param name="index">The index of the inserted object in the stack. <c>index</c> begins from bottom to top of the stack. <c>index</c> of the bottom content is 0.</param>
    /// <param name="content">The inserted object in the stack.</param>
    virtual public void InsertAt(int index, Efl.Canvas.Object content) {
                                                         Efl.Ui.Stack.NativeMethods.efl_ui_stack_insert_at_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),index, content);
        Eina.Error.RaiseIfUnhandledException();
                                         }
    /// <summary>Removes the given content in the stack.</summary>
    /// <param name="content">The removed content from the stack.</param>
    virtual public void Remove(Efl.Canvas.Object content) {
                                 Efl.Ui.Stack.NativeMethods.efl_ui_stack_remove_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),content);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Removes a content matched to the given index in the stack.</summary>
    /// <param name="index">The index of the removed object in the stack. <c>index</c> begins from bottom to top of the stack. <c>index</c> of the bottom content is 0.</param>
    virtual public void RemoveAt(int index) {
                                 Efl.Ui.Stack.NativeMethods.efl_ui_stack_remove_at_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),index);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Gets the index of the given content in the stack. The index begins from bottom to top of the stack. The index of the bottom content is 0.</summary>
    /// <param name="content">The content matched to the index to be returned in the stack.</param>
    /// <returns>The index of <c>content</c> in the stack.</returns>
    virtual public int GetIndex(Efl.Canvas.Object content) {
                                 var _ret_var = Efl.Ui.Stack.NativeMethods.efl_ui_stack_index_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),content);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Gets the content matched to the given index in the stack.</summary>
    /// <param name="index">The index of the content to be returned in the stack.</param>
    /// <returns>The content matched to <c>index</c> in the stack.</returns>
    virtual public Efl.Canvas.Object GetContent(int index) {
                                 var _ret_var = Efl.Ui.Stack.NativeMethods.efl_ui_stack_content_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),index);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Gets the top content in the stack.</summary>
    /// <returns>The top content in the stack.</returns>
    virtual public Efl.Canvas.Object Top() {
         var _ret_var = Efl.Ui.Stack.NativeMethods.efl_ui_stack_top_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.Stack.efl_ui_stack_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Ui.LayoutBase.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_stack_push_static_delegate == null)
            {
                efl_ui_stack_push_static_delegate = new efl_ui_stack_push_delegate(push);
            }

            if (methods.FirstOrDefault(m => m.Name == "Push") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_push"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_push_static_delegate) });
            }

            if (efl_ui_stack_pop_static_delegate == null)
            {
                efl_ui_stack_pop_static_delegate = new efl_ui_stack_pop_delegate(pop);
            }

            if (methods.FirstOrDefault(m => m.Name == "Pop") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_pop"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_pop_static_delegate) });
            }

            if (efl_ui_stack_insert_before_static_delegate == null)
            {
                efl_ui_stack_insert_before_static_delegate = new efl_ui_stack_insert_before_delegate(insert_before);
            }

            if (methods.FirstOrDefault(m => m.Name == "InsertBefore") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_insert_before"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_insert_before_static_delegate) });
            }

            if (efl_ui_stack_insert_after_static_delegate == null)
            {
                efl_ui_stack_insert_after_static_delegate = new efl_ui_stack_insert_after_delegate(insert_after);
            }

            if (methods.FirstOrDefault(m => m.Name == "InsertAfter") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_insert_after"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_insert_after_static_delegate) });
            }

            if (efl_ui_stack_insert_at_static_delegate == null)
            {
                efl_ui_stack_insert_at_static_delegate = new efl_ui_stack_insert_at_delegate(insert_at);
            }

            if (methods.FirstOrDefault(m => m.Name == "InsertAt") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_insert_at"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_insert_at_static_delegate) });
            }

            if (efl_ui_stack_remove_static_delegate == null)
            {
                efl_ui_stack_remove_static_delegate = new efl_ui_stack_remove_delegate(remove);
            }

            if (methods.FirstOrDefault(m => m.Name == "Remove") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_remove"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_remove_static_delegate) });
            }

            if (efl_ui_stack_remove_at_static_delegate == null)
            {
                efl_ui_stack_remove_at_static_delegate = new efl_ui_stack_remove_at_delegate(remove_at);
            }

            if (methods.FirstOrDefault(m => m.Name == "RemoveAt") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_remove_at"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_remove_at_static_delegate) });
            }

            if (efl_ui_stack_index_get_static_delegate == null)
            {
                efl_ui_stack_index_get_static_delegate = new efl_ui_stack_index_get_delegate(index_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetIndex") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_index_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_index_get_static_delegate) });
            }

            if (efl_ui_stack_content_get_static_delegate == null)
            {
                efl_ui_stack_content_get_static_delegate = new efl_ui_stack_content_get_delegate(content_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetContent") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_content_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_content_get_static_delegate) });
            }

            if (efl_ui_stack_top_static_delegate == null)
            {
                efl_ui_stack_top_static_delegate = new efl_ui_stack_top_delegate(top);
            }

            if (methods.FirstOrDefault(m => m.Name == "Top") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_stack_top"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_stack_top_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.Stack.efl_ui_stack_class_get();
        }

        #pragma warning disable CA1707, CS1591, SA1300, SA1600

        
        private delegate void efl_ui_stack_push_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        
        public delegate void efl_ui_stack_push_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_push_api_delegate> efl_ui_stack_push_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_push_api_delegate>(Module, "efl_ui_stack_push");

        private static void push(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Object content)
        {
            Eina.Log.Debug("function efl_ui_stack_push was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((Stack)ws.Target).Push(content);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_stack_push_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), content);
            }
        }

        private static efl_ui_stack_push_delegate efl_ui_stack_push_static_delegate;

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Canvas.Object efl_ui_stack_pop_delegate(System.IntPtr obj, System.IntPtr pd);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Canvas.Object efl_ui_stack_pop_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_pop_api_delegate> efl_ui_stack_pop_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_pop_api_delegate>(Module, "efl_ui_stack_pop");

        private static Efl.Canvas.Object pop(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_stack_pop was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            Efl.Canvas.Object _ret_var = default(Efl.Canvas.Object);
                try
                {
                    _ret_var = ((Stack)ws.Target).Pop();
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
                return efl_ui_stack_pop_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_stack_pop_delegate efl_ui_stack_pop_static_delegate;

        
        private delegate void efl_ui_stack_insert_before_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object base_content, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        
        public delegate void efl_ui_stack_insert_before_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object base_content, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_insert_before_api_delegate> efl_ui_stack_insert_before_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_insert_before_api_delegate>(Module, "efl_ui_stack_insert_before");

        private static void insert_before(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Object base_content, Efl.Canvas.Object content)
        {
            Eina.Log.Debug("function efl_ui_stack_insert_before was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            
                try
                {
                    ((Stack)ws.Target).InsertBefore(base_content, content);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_stack_insert_before_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), base_content, content);
            }
        }

        private static efl_ui_stack_insert_before_delegate efl_ui_stack_insert_before_static_delegate;

        
        private delegate void efl_ui_stack_insert_after_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object base_content, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        
        public delegate void efl_ui_stack_insert_after_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object base_content, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_insert_after_api_delegate> efl_ui_stack_insert_after_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_insert_after_api_delegate>(Module, "efl_ui_stack_insert_after");

        private static void insert_after(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Object base_content, Efl.Canvas.Object content)
        {
            Eina.Log.Debug("function efl_ui_stack_insert_after was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            
                try
                {
                    ((Stack)ws.Target).InsertAfter(base_content, content);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_stack_insert_after_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), base_content, content);
            }
        }

        private static efl_ui_stack_insert_after_delegate efl_ui_stack_insert_after_static_delegate;

        
        private delegate void efl_ui_stack_insert_at_delegate(System.IntPtr obj, System.IntPtr pd,  int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        
        public delegate void efl_ui_stack_insert_at_api_delegate(System.IntPtr obj,  int index, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_insert_at_api_delegate> efl_ui_stack_insert_at_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_insert_at_api_delegate>(Module, "efl_ui_stack_insert_at");

        private static void insert_at(System.IntPtr obj, System.IntPtr pd, int index, Efl.Canvas.Object content)
        {
            Eina.Log.Debug("function efl_ui_stack_insert_at was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                                            
                try
                {
                    ((Stack)ws.Target).InsertAt(index, content);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                                        
            }
            else
            {
                efl_ui_stack_insert_at_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), index, content);
            }
        }

        private static efl_ui_stack_insert_at_delegate efl_ui_stack_insert_at_static_delegate;

        
        private delegate void efl_ui_stack_remove_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        
        public delegate void efl_ui_stack_remove_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_remove_api_delegate> efl_ui_stack_remove_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_remove_api_delegate>(Module, "efl_ui_stack_remove");

        private static void remove(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Object content)
        {
            Eina.Log.Debug("function efl_ui_stack_remove was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((Stack)ws.Target).Remove(content);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_stack_remove_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), content);
            }
        }

        private static efl_ui_stack_remove_delegate efl_ui_stack_remove_static_delegate;

        
        private delegate void efl_ui_stack_remove_at_delegate(System.IntPtr obj, System.IntPtr pd,  int index);

        
        public delegate void efl_ui_stack_remove_at_api_delegate(System.IntPtr obj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_remove_at_api_delegate> efl_ui_stack_remove_at_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_remove_at_api_delegate>(Module, "efl_ui_stack_remove_at");

        private static void remove_at(System.IntPtr obj, System.IntPtr pd, int index)
        {
            Eina.Log.Debug("function efl_ui_stack_remove_at was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((Stack)ws.Target).RemoveAt(index);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_stack_remove_at_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), index);
            }
        }

        private static efl_ui_stack_remove_at_delegate efl_ui_stack_remove_at_static_delegate;

        
        private delegate int efl_ui_stack_index_get_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        
        public delegate int efl_ui_stack_index_get_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))] Efl.Canvas.Object content);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_index_get_api_delegate> efl_ui_stack_index_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_index_get_api_delegate>(Module, "efl_ui_stack_index_get");

        private static int index_get(System.IntPtr obj, System.IntPtr pd, Efl.Canvas.Object content)
        {
            Eina.Log.Debug("function efl_ui_stack_index_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    int _ret_var = default(int);
                try
                {
                    _ret_var = ((Stack)ws.Target).GetIndex(content);
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
                return efl_ui_stack_index_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), content);
            }
        }

        private static efl_ui_stack_index_get_delegate efl_ui_stack_index_get_static_delegate;

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Canvas.Object efl_ui_stack_content_get_delegate(System.IntPtr obj, System.IntPtr pd,  int index);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Canvas.Object efl_ui_stack_content_get_api_delegate(System.IntPtr obj,  int index);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_content_get_api_delegate> efl_ui_stack_content_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_content_get_api_delegate>(Module, "efl_ui_stack_content_get");

        private static Efl.Canvas.Object content_get(System.IntPtr obj, System.IntPtr pd, int index)
        {
            Eina.Log.Debug("function efl_ui_stack_content_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    Efl.Canvas.Object _ret_var = default(Efl.Canvas.Object);
                try
                {
                    _ret_var = ((Stack)ws.Target).GetContent(index);
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
                return efl_ui_stack_content_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), index);
            }
        }

        private static efl_ui_stack_content_get_delegate efl_ui_stack_content_get_static_delegate;

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Canvas.Object efl_ui_stack_top_delegate(System.IntPtr obj, System.IntPtr pd);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Canvas.Object efl_ui_stack_top_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_stack_top_api_delegate> efl_ui_stack_top_ptr = new Efl.Eo.FunctionWrapper<efl_ui_stack_top_api_delegate>(Module, "efl_ui_stack_top");

        private static Efl.Canvas.Object top(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_stack_top was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            Efl.Canvas.Object _ret_var = default(Efl.Canvas.Object);
                try
                {
                    _ret_var = ((Stack)ws.Target).Top();
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
                return efl_ui_stack_top_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_stack_top_delegate efl_ui_stack_top_static_delegate;

        #pragma warning restore CA1707, CS1591, SA1300, SA1600

}
}
}

}

namespace Efl {

namespace Ui {

/// <summary>Information of loaded event.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct StackEventLoaded
{
    /// <summary>Loaded content.</summary>
    public Efl.Canvas.Object Content;
    ///<summary>Constructor for StackEventLoaded.</summary>
    public StackEventLoaded(
        Efl.Canvas.Object Content = default(Efl.Canvas.Object)    )
    {
        this.Content = Content;
    }

    ///<summary>Implicit conversion to the managed representation from a native pointer.</summary>
    ///<param name="ptr">Native pointer to be converted.</param>
    public static implicit operator StackEventLoaded(IntPtr ptr)
    {
        var tmp = (StackEventLoaded.NativeStruct)Marshal.PtrToStructure(ptr, typeof(StackEventLoaded.NativeStruct));
        return tmp;
    }

    #pragma warning disable CS1591

    ///<summary>Internal wrapper for struct StackEventLoaded.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        ///<summary>Internal wrapper for field Content</summary>
        public System.IntPtr Content;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator StackEventLoaded.NativeStruct(StackEventLoaded _external_struct)
        {
            var _internal_struct = new StackEventLoaded.NativeStruct();
            _internal_struct.Content = _external_struct.Content?.NativeHandle ?? System.IntPtr.Zero;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator StackEventLoaded(StackEventLoaded.NativeStruct _internal_struct)
        {
            var _external_struct = new StackEventLoaded();

            _external_struct.Content = (Efl.Canvas.Object) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Content);
            return _external_struct;
        }

    }

    #pragma warning restore CS1591

}

}

}

namespace Efl {

namespace Ui {

/// <summary>Information of unloaded event.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct StackEventUnloaded
{
    /// <summary>Unloaded content.</summary>
    public Efl.Canvas.Object Content;
    ///<summary>Constructor for StackEventUnloaded.</summary>
    public StackEventUnloaded(
        Efl.Canvas.Object Content = default(Efl.Canvas.Object)    )
    {
        this.Content = Content;
    }

    ///<summary>Implicit conversion to the managed representation from a native pointer.</summary>
    ///<param name="ptr">Native pointer to be converted.</param>
    public static implicit operator StackEventUnloaded(IntPtr ptr)
    {
        var tmp = (StackEventUnloaded.NativeStruct)Marshal.PtrToStructure(ptr, typeof(StackEventUnloaded.NativeStruct));
        return tmp;
    }

    #pragma warning disable CS1591

    ///<summary>Internal wrapper for struct StackEventUnloaded.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        ///<summary>Internal wrapper for field Content</summary>
        public System.IntPtr Content;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator StackEventUnloaded.NativeStruct(StackEventUnloaded _external_struct)
        {
            var _internal_struct = new StackEventUnloaded.NativeStruct();
            _internal_struct.Content = _external_struct.Content?.NativeHandle ?? System.IntPtr.Zero;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator StackEventUnloaded(StackEventUnloaded.NativeStruct _internal_struct)
        {
            var _external_struct = new StackEventUnloaded();

            _external_struct.Content = (Efl.Canvas.Object) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Content);
            return _external_struct;
        }

    }

    #pragma warning restore CS1591

}

}

}

namespace Efl {

namespace Ui {

/// <summary>Information of activated event.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct StackEventActivated
{
    /// <summary>Activated content.</summary>
    public Efl.Canvas.Object Content;
    ///<summary>Constructor for StackEventActivated.</summary>
    public StackEventActivated(
        Efl.Canvas.Object Content = default(Efl.Canvas.Object)    )
    {
        this.Content = Content;
    }

    ///<summary>Implicit conversion to the managed representation from a native pointer.</summary>
    ///<param name="ptr">Native pointer to be converted.</param>
    public static implicit operator StackEventActivated(IntPtr ptr)
    {
        var tmp = (StackEventActivated.NativeStruct)Marshal.PtrToStructure(ptr, typeof(StackEventActivated.NativeStruct));
        return tmp;
    }

    #pragma warning disable CS1591

    ///<summary>Internal wrapper for struct StackEventActivated.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        ///<summary>Internal wrapper for field Content</summary>
        public System.IntPtr Content;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator StackEventActivated.NativeStruct(StackEventActivated _external_struct)
        {
            var _internal_struct = new StackEventActivated.NativeStruct();
            _internal_struct.Content = _external_struct.Content?.NativeHandle ?? System.IntPtr.Zero;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator StackEventActivated(StackEventActivated.NativeStruct _internal_struct)
        {
            var _external_struct = new StackEventActivated();

            _external_struct.Content = (Efl.Canvas.Object) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Content);
            return _external_struct;
        }

    }

    #pragma warning restore CS1591

}

}

}

namespace Efl {

namespace Ui {

/// <summary>Information of deactivated event.</summary>
[StructLayout(LayoutKind.Sequential)]
public struct StackEventDeactivated
{
    /// <summary>Deactivated content.</summary>
    public Efl.Canvas.Object Content;
    ///<summary>Constructor for StackEventDeactivated.</summary>
    public StackEventDeactivated(
        Efl.Canvas.Object Content = default(Efl.Canvas.Object)    )
    {
        this.Content = Content;
    }

    ///<summary>Implicit conversion to the managed representation from a native pointer.</summary>
    ///<param name="ptr">Native pointer to be converted.</param>
    public static implicit operator StackEventDeactivated(IntPtr ptr)
    {
        var tmp = (StackEventDeactivated.NativeStruct)Marshal.PtrToStructure(ptr, typeof(StackEventDeactivated.NativeStruct));
        return tmp;
    }

    #pragma warning disable CS1591

    ///<summary>Internal wrapper for struct StackEventDeactivated.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        ///<summary>Internal wrapper for field Content</summary>
        public System.IntPtr Content;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator StackEventDeactivated.NativeStruct(StackEventDeactivated _external_struct)
        {
            var _internal_struct = new StackEventDeactivated.NativeStruct();
            _internal_struct.Content = _external_struct.Content?.NativeHandle ?? System.IntPtr.Zero;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator StackEventDeactivated(StackEventDeactivated.NativeStruct _internal_struct)
        {
            var _external_struct = new StackEventDeactivated();

            _external_struct.Content = (Efl.Canvas.Object) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Content);
            return _external_struct;
        }

    }

    #pragma warning restore CS1591

}

}

}

