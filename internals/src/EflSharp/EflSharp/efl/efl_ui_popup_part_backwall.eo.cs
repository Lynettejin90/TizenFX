#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Ui {

/// <summary>Efl UI Popup internal part backwall class</summary>
[Efl.Ui.PopupPartBackwall.NativeMethods]
public class PopupPartBackwall : Efl.Ui.LayoutPart, Efl.IFile
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(PopupPartBackwall))
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
        efl_ui_popup_part_backwall_class_get();
    /// <summary>Initializes a new instance of the <see cref="PopupPartBackwall"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public PopupPartBackwall(Efl.Object parent= null
            ) : base(efl_ui_popup_part_backwall_class_get(), typeof(PopupPartBackwall), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="PopupPartBackwall"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected PopupPartBackwall(System.IntPtr raw) : base(raw)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="PopupPartBackwall"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected PopupPartBackwall(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
    }

    /// <summary>Determine whether backwall is set to repeat events.</summary>
    /// <returns>Whether <c>obj</c> is to repeat events (<c>true</c>) or not (<c>false</c>).</returns>
    virtual public bool GetRepeatEvents() {
         var _ret_var = Efl.Ui.PopupPartBackwall.NativeMethods.efl_ui_popup_part_backwall_repeat_events_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Set whether backwall is to repeat events.
    /// If <c>repeat</c> is <c>true</c>, it will make events on <c>obj</c> to also be repeated for the next lower object in the objects&apos; stack (see <see cref="Efl.Gfx.IStack.GetBelow"/>).
    /// 
    /// If <c>repeat</c> is <c>false</c>, events occurring on <c>obj</c> will be processed only on it.</summary>
    /// <param name="repeat">Whether <c>obj</c> is to repeat events (<c>true</c>) or not (<c>false</c>).</param>
    virtual public void SetRepeatEvents(bool repeat) {
                                 Efl.Ui.PopupPartBackwall.NativeMethods.efl_ui_popup_part_backwall_repeat_events_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),repeat);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Get the mmaped file from where an object will fetch the real data (it must be an <see cref="Eina.File"/>).
    /// (Since EFL 1.22)</summary>
    /// <returns>The handle to the <see cref="Eina.File"/> that will be used</returns>
    virtual public Eina.File GetMmap() {
         var _ret_var = Efl.IFileConcrete.NativeMethods.efl_file_mmap_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Set the mmaped file from where an object will fetch the real data (it must be an <see cref="Eina.File"/>).
    /// If mmap is set during object construction, the object will automatically call <see cref="Efl.IFile.Load"/> during the finalize phase of construction.
    /// (Since EFL 1.22)</summary>
    /// <param name="f">The handle to the <see cref="Eina.File"/> that will be used</param>
    /// <returns>0 on success, error code otherwise</returns>
    virtual public Eina.Error SetMmap(Eina.File f) {
                                 var _ret_var = Efl.IFileConcrete.NativeMethods.efl_file_mmap_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),f);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Retrieve the file path from where an object is to fetch the data.
    /// You must not modify the strings on the returned pointers.
    /// (Since EFL 1.22)</summary>
    /// <returns>The file path.</returns>
    virtual public System.String GetFile() {
         var _ret_var = Efl.IFileConcrete.NativeMethods.efl_file_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Set the file path from where an object will fetch the data.
    /// If file is set during object construction, the object will automatically call <see cref="Efl.IFile.Load"/> during the finalize phase of construction.
    /// (Since EFL 1.22)</summary>
    /// <param name="file">The file path.</param>
    /// <returns>0 on success, error code otherwise</returns>
    virtual public Eina.Error SetFile(System.String file) {
                                 var _ret_var = Efl.IFileConcrete.NativeMethods.efl_file_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),file);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Get the previously-set key which corresponds to the target data within a file.
    /// Some filetypes can contain multiple data streams which are indexed by a key. Use this property for such cases (See for example <see cref="Efl.Ui.Image"/> or <see cref="Efl.Ui.Layout"/>).
    /// 
    /// You must not modify the strings on the returned pointers.
    /// (Since EFL 1.22)</summary>
    /// <returns>The group that the data belongs to. See the class documentation for particular implementations of this interface to see how this property is used.</returns>
    virtual public System.String GetKey() {
         var _ret_var = Efl.IFileConcrete.NativeMethods.efl_file_key_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Set the key which corresponds to the target data within a file.
    /// Some filetypes can contain multiple data streams which are indexed by a key. Use this property for such cases.
    /// (Since EFL 1.22)</summary>
    /// <param name="key">The group that the data belongs to. See the class documentation for particular implementations of this interface to see how this property is used.</param>
    virtual public void SetKey(System.String key) {
                                 Efl.IFileConcrete.NativeMethods.efl_file_key_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),key);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Get the load state of the object.
    /// (Since EFL 1.22)</summary>
    /// <returns><c>true</c> if the object is loaded, <c>false</c> otherwise.</returns>
    virtual public bool GetLoaded() {
         var _ret_var = Efl.IFileConcrete.NativeMethods.efl_file_loaded_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Perform all necessary operations to open and load file data into the object using the <see cref="Efl.IFile.File"/> (or <see cref="Efl.IFile.Mmap"/>) and <see cref="Efl.IFile.Key"/> properties.
    /// In the case where <see cref="Efl.IFile.SetFile"/> has been called on an object, this will internally open the file and call <see cref="Efl.IFile.SetMmap"/> on the object using the opened file handle.
    /// 
    /// Calling <see cref="Efl.IFile.Load"/> on an object which has already performed file operations based on the currently set properties will have no effect.
    /// (Since EFL 1.22)</summary>
    /// <returns>0 on success, error code otherwise</returns>
    virtual public Eina.Error Load() {
         var _ret_var = Efl.IFileConcrete.NativeMethods.efl_file_load_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Perform all necessary operations to unload file data from the object.
    /// In the case where <see cref="Efl.IFile.SetMmap"/> has been externally called on an object, the file handle stored in the object will be preserved.
    /// 
    /// Calling <see cref="Efl.IFile.Unload"/> on an object which is not currently loaded will have no effect.
    /// (Since EFL 1.22)</summary>
    virtual public void Unload() {
         Efl.IFileConcrete.NativeMethods.efl_file_unload_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
         }
    /// <summary>Determine whether backwall is set to repeat events.</summary>
    /// <value>Whether <c>obj</c> is to repeat events (<c>true</c>) or not (<c>false</c>).</value>
    public bool RepeatEvents {
        get { return GetRepeatEvents(); }
        set { SetRepeatEvents(value); }
    }
    /// <summary>Get the mmaped file from where an object will fetch the real data (it must be an <see cref="Eina.File"/>).
    /// (Since EFL 1.22)</summary>
    /// <value>The handle to the <see cref="Eina.File"/> that will be used</value>
    public Eina.File Mmap {
        get { return GetMmap(); }
        set { SetMmap(value); }
    }
    /// <summary>Retrieve the file path from where an object is to fetch the data.
    /// You must not modify the strings on the returned pointers.
    /// (Since EFL 1.22)</summary>
    /// <value>The file path.</value>
    public System.String File {
        get { return GetFile(); }
        set { SetFile(value); }
    }
    /// <summary>Get the previously-set key which corresponds to the target data within a file.
    /// Some filetypes can contain multiple data streams which are indexed by a key. Use this property for such cases (See for example <see cref="Efl.Ui.Image"/> or <see cref="Efl.Ui.Layout"/>).
    /// 
    /// You must not modify the strings on the returned pointers.
    /// (Since EFL 1.22)</summary>
    /// <value>The group that the data belongs to. See the class documentation for particular implementations of this interface to see how this property is used.</value>
    public System.String Key {
        get { return GetKey(); }
        set { SetKey(value); }
    }
    /// <summary>Get the load state of the object.
    /// (Since EFL 1.22)</summary>
    /// <value><c>true</c> if the object is loaded, <c>false</c> otherwise.</value>
    public bool Loaded {
        get { return GetLoaded(); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Ui.PopupPartBackwall.efl_ui_popup_part_backwall_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Ui.LayoutPart.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Elementary);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_ui_popup_part_backwall_repeat_events_get_static_delegate == null)
            {
                efl_ui_popup_part_backwall_repeat_events_get_static_delegate = new efl_ui_popup_part_backwall_repeat_events_get_delegate(repeat_events_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetRepeatEvents") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_popup_part_backwall_repeat_events_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_popup_part_backwall_repeat_events_get_static_delegate) });
            }

            if (efl_ui_popup_part_backwall_repeat_events_set_static_delegate == null)
            {
                efl_ui_popup_part_backwall_repeat_events_set_static_delegate = new efl_ui_popup_part_backwall_repeat_events_set_delegate(repeat_events_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetRepeatEvents") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_ui_popup_part_backwall_repeat_events_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_popup_part_backwall_repeat_events_set_static_delegate) });
            }

            if (efl_file_mmap_get_static_delegate == null)
            {
                efl_file_mmap_get_static_delegate = new efl_file_mmap_get_delegate(mmap_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetMmap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_mmap_get"), func = Marshal.GetFunctionPointerForDelegate(efl_file_mmap_get_static_delegate) });
            }

            if (efl_file_mmap_set_static_delegate == null)
            {
                efl_file_mmap_set_static_delegate = new efl_file_mmap_set_delegate(mmap_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetMmap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_mmap_set"), func = Marshal.GetFunctionPointerForDelegate(efl_file_mmap_set_static_delegate) });
            }

            if (efl_file_get_static_delegate == null)
            {
                efl_file_get_static_delegate = new efl_file_get_delegate(file_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetFile") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_get"), func = Marshal.GetFunctionPointerForDelegate(efl_file_get_static_delegate) });
            }

            if (efl_file_set_static_delegate == null)
            {
                efl_file_set_static_delegate = new efl_file_set_delegate(file_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetFile") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_set"), func = Marshal.GetFunctionPointerForDelegate(efl_file_set_static_delegate) });
            }

            if (efl_file_key_get_static_delegate == null)
            {
                efl_file_key_get_static_delegate = new efl_file_key_get_delegate(key_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetKey") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_key_get"), func = Marshal.GetFunctionPointerForDelegate(efl_file_key_get_static_delegate) });
            }

            if (efl_file_key_set_static_delegate == null)
            {
                efl_file_key_set_static_delegate = new efl_file_key_set_delegate(key_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetKey") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_key_set"), func = Marshal.GetFunctionPointerForDelegate(efl_file_key_set_static_delegate) });
            }

            if (efl_file_loaded_get_static_delegate == null)
            {
                efl_file_loaded_get_static_delegate = new efl_file_loaded_get_delegate(loaded_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetLoaded") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_loaded_get"), func = Marshal.GetFunctionPointerForDelegate(efl_file_loaded_get_static_delegate) });
            }

            if (efl_file_load_static_delegate == null)
            {
                efl_file_load_static_delegate = new efl_file_load_delegate(load);
            }

            if (methods.FirstOrDefault(m => m.Name == "Load") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_load"), func = Marshal.GetFunctionPointerForDelegate(efl_file_load_static_delegate) });
            }

            if (efl_file_unload_static_delegate == null)
            {
                efl_file_unload_static_delegate = new efl_file_unload_delegate(unload);
            }

            if (methods.FirstOrDefault(m => m.Name == "Unload") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_file_unload"), func = Marshal.GetFunctionPointerForDelegate(efl_file_unload_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Ui.PopupPartBackwall.efl_ui_popup_part_backwall_class_get();
        }

        #pragma warning disable CA1707, CS1591, SA1300, SA1600

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_ui_popup_part_backwall_repeat_events_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_ui_popup_part_backwall_repeat_events_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_ui_popup_part_backwall_repeat_events_get_api_delegate> efl_ui_popup_part_backwall_repeat_events_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_popup_part_backwall_repeat_events_get_api_delegate>(Module, "efl_ui_popup_part_backwall_repeat_events_get");

        private static bool repeat_events_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_ui_popup_part_backwall_repeat_events_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).GetRepeatEvents();
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
                return efl_ui_popup_part_backwall_repeat_events_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_ui_popup_part_backwall_repeat_events_get_delegate efl_ui_popup_part_backwall_repeat_events_get_static_delegate;

        
        private delegate void efl_ui_popup_part_backwall_repeat_events_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool repeat);

        
        public delegate void efl_ui_popup_part_backwall_repeat_events_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool repeat);

        public static Efl.Eo.FunctionWrapper<efl_ui_popup_part_backwall_repeat_events_set_api_delegate> efl_ui_popup_part_backwall_repeat_events_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_popup_part_backwall_repeat_events_set_api_delegate>(Module, "efl_ui_popup_part_backwall_repeat_events_set");

        private static void repeat_events_set(System.IntPtr obj, System.IntPtr pd, bool repeat)
        {
            Eina.Log.Debug("function efl_ui_popup_part_backwall_repeat_events_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((PopupPartBackwall)ws.Target).SetRepeatEvents(repeat);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_ui_popup_part_backwall_repeat_events_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), repeat);
            }
        }

        private static efl_ui_popup_part_backwall_repeat_events_set_delegate efl_ui_popup_part_backwall_repeat_events_set_static_delegate;

        
        private delegate Eina.File efl_file_mmap_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.File efl_file_mmap_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_file_mmap_get_api_delegate> efl_file_mmap_get_ptr = new Efl.Eo.FunctionWrapper<efl_file_mmap_get_api_delegate>(Module, "efl_file_mmap_get");

        private static Eina.File mmap_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_file_mmap_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            Eina.File _ret_var = default(Eina.File);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).GetMmap();
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
                return efl_file_mmap_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_file_mmap_get_delegate efl_file_mmap_get_static_delegate;

        
        private delegate Eina.Error efl_file_mmap_set_delegate(System.IntPtr obj, System.IntPtr pd,  Eina.File f);

        
        public delegate Eina.Error efl_file_mmap_set_api_delegate(System.IntPtr obj,  Eina.File f);

        public static Efl.Eo.FunctionWrapper<efl_file_mmap_set_api_delegate> efl_file_mmap_set_ptr = new Efl.Eo.FunctionWrapper<efl_file_mmap_set_api_delegate>(Module, "efl_file_mmap_set");

        private static Eina.Error mmap_set(System.IntPtr obj, System.IntPtr pd, Eina.File f)
        {
            Eina.Log.Debug("function efl_file_mmap_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    Eina.Error _ret_var = default(Eina.Error);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).SetMmap(f);
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
                return efl_file_mmap_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), f);
            }
        }

        private static efl_file_mmap_set_delegate efl_file_mmap_set_static_delegate;

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        private delegate System.String efl_file_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        public delegate System.String efl_file_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_file_get_api_delegate> efl_file_get_ptr = new Efl.Eo.FunctionWrapper<efl_file_get_api_delegate>(Module, "efl_file_get");

        private static System.String file_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_file_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            System.String _ret_var = default(System.String);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).GetFile();
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
                return efl_file_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_file_get_delegate efl_file_get_static_delegate;

        
        private delegate Eina.Error efl_file_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String file);

        
        public delegate Eina.Error efl_file_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String file);

        public static Efl.Eo.FunctionWrapper<efl_file_set_api_delegate> efl_file_set_ptr = new Efl.Eo.FunctionWrapper<efl_file_set_api_delegate>(Module, "efl_file_set");

        private static Eina.Error file_set(System.IntPtr obj, System.IntPtr pd, System.String file)
        {
            Eina.Log.Debug("function efl_file_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    Eina.Error _ret_var = default(Eina.Error);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).SetFile(file);
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
                return efl_file_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), file);
            }
        }

        private static efl_file_set_delegate efl_file_set_static_delegate;

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        private delegate System.String efl_file_key_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        public delegate System.String efl_file_key_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_file_key_get_api_delegate> efl_file_key_get_ptr = new Efl.Eo.FunctionWrapper<efl_file_key_get_api_delegate>(Module, "efl_file_key_get");

        private static System.String key_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_file_key_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            System.String _ret_var = default(System.String);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).GetKey();
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
                return efl_file_key_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_file_key_get_delegate efl_file_key_get_static_delegate;

        
        private delegate void efl_file_key_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String key);

        
        public delegate void efl_file_key_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String key);

        public static Efl.Eo.FunctionWrapper<efl_file_key_set_api_delegate> efl_file_key_set_ptr = new Efl.Eo.FunctionWrapper<efl_file_key_set_api_delegate>(Module, "efl_file_key_set");

        private static void key_set(System.IntPtr obj, System.IntPtr pd, System.String key)
        {
            Eina.Log.Debug("function efl_file_key_set was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
                                    
                try
                {
                    ((PopupPartBackwall)ws.Target).SetKey(key);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_file_key_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), key);
            }
        }

        private static efl_file_key_set_delegate efl_file_key_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_file_loaded_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_file_loaded_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_file_loaded_get_api_delegate> efl_file_loaded_get_ptr = new Efl.Eo.FunctionWrapper<efl_file_loaded_get_api_delegate>(Module, "efl_file_loaded_get");

        private static bool loaded_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_file_loaded_get was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).GetLoaded();
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
                return efl_file_loaded_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_file_loaded_get_delegate efl_file_loaded_get_static_delegate;

        
        private delegate Eina.Error efl_file_load_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Eina.Error efl_file_load_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_file_load_api_delegate> efl_file_load_ptr = new Efl.Eo.FunctionWrapper<efl_file_load_api_delegate>(Module, "efl_file_load");

        private static Eina.Error load(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_file_load was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            Eina.Error _ret_var = default(Eina.Error);
                try
                {
                    _ret_var = ((PopupPartBackwall)ws.Target).Load();
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
                return efl_file_load_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_file_load_delegate efl_file_load_static_delegate;

        
        private delegate void efl_file_unload_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate void efl_file_unload_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_file_unload_api_delegate> efl_file_unload_ptr = new Efl.Eo.FunctionWrapper<efl_file_unload_api_delegate>(Module, "efl_file_unload");

        private static void unload(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_file_unload was called");
            var ws = Efl.Eo.Globals.GetWrapperSupervisor(obj);
            if (ws != null)
            {
            
                try
                {
                    ((PopupPartBackwall)ws.Target).Unload();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        
            }
            else
            {
                efl_file_unload_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_file_unload_delegate efl_file_unload_static_delegate;

        #pragma warning restore CA1707, CS1591, SA1300, SA1600

}
}
}

}

