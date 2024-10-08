//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""BumperControl"",
            ""id"": ""3d0d94fd-2a9c-43b0-af50-bae14a4d5617"",
            ""actions"": [
                {
                    ""name"": ""Bump"",
                    ""type"": ""Button"",
                    ""id"": ""47485c87-23d1-45a0-8c51-668c0011c981"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bf70ea04-c620-4833-be36-c1ed84f5e651"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BumperControl
        m_BumperControl = asset.FindActionMap("BumperControl", throwIfNotFound: true);
        m_BumperControl_Bump = m_BumperControl.FindAction("Bump", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // BumperControl
    private readonly InputActionMap m_BumperControl;
    private List<IBumperControlActions> m_BumperControlActionsCallbackInterfaces = new List<IBumperControlActions>();
    private readonly InputAction m_BumperControl_Bump;
    public struct BumperControlActions
    {
        private @PlayerActions m_Wrapper;
        public BumperControlActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bump => m_Wrapper.m_BumperControl_Bump;
        public InputActionMap Get() { return m_Wrapper.m_BumperControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BumperControlActions set) { return set.Get(); }
        public void AddCallbacks(IBumperControlActions instance)
        {
            if (instance == null || m_Wrapper.m_BumperControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BumperControlActionsCallbackInterfaces.Add(instance);
            @Bump.started += instance.OnBump;
            @Bump.performed += instance.OnBump;
            @Bump.canceled += instance.OnBump;
        }

        private void UnregisterCallbacks(IBumperControlActions instance)
        {
            @Bump.started -= instance.OnBump;
            @Bump.performed -= instance.OnBump;
            @Bump.canceled -= instance.OnBump;
        }

        public void RemoveCallbacks(IBumperControlActions instance)
        {
            if (m_Wrapper.m_BumperControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBumperControlActions instance)
        {
            foreach (var item in m_Wrapper.m_BumperControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BumperControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BumperControlActions @BumperControl => new BumperControlActions(this);
    public interface IBumperControlActions
    {
        void OnBump(InputAction.CallbackContext context);
    }
}
