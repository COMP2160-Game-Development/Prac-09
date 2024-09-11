//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
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

public partial class @PlayerActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""PuckControl"",
            ""id"": ""3d0d94fd-2a9c-43b0-af50-bae14a4d5617"",
            ""actions"": [
                {
                    ""name"": ""MovePuck"",
                    ""type"": ""Value"",
                    ""id"": ""9e852e9f-d7b2-4bce-8083-12a8f374546f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91811c8b-02e6-4846-b135-18dce3c2fffb"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovePuck"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PuckControl
        m_PuckControl = asset.FindActionMap("PuckControl", throwIfNotFound: true);
        m_PuckControl_MovePuck = m_PuckControl.FindAction("MovePuck", throwIfNotFound: true);
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

    // PuckControl
    private readonly InputActionMap m_PuckControl;
    private IPuckControlActions m_PuckControlActionsCallbackInterface;
    private readonly InputAction m_PuckControl_MovePuck;
    public struct PuckControlActions
    {
        private @PlayerActions m_Wrapper;
        public PuckControlActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePuck => m_Wrapper.m_PuckControl_MovePuck;
        public InputActionMap Get() { return m_Wrapper.m_PuckControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PuckControlActions set) { return set.Get(); }
        public void SetCallbacks(IPuckControlActions instance)
        {
            if (m_Wrapper.m_PuckControlActionsCallbackInterface != null)
            {
                @MovePuck.started -= m_Wrapper.m_PuckControlActionsCallbackInterface.OnMovePuck;
                @MovePuck.performed -= m_Wrapper.m_PuckControlActionsCallbackInterface.OnMovePuck;
                @MovePuck.canceled -= m_Wrapper.m_PuckControlActionsCallbackInterface.OnMovePuck;
            }
            m_Wrapper.m_PuckControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePuck.started += instance.OnMovePuck;
                @MovePuck.performed += instance.OnMovePuck;
                @MovePuck.canceled += instance.OnMovePuck;
            }
        }
    }
    public PuckControlActions @PuckControl => new PuckControlActions(this);
    public interface IPuckControlActions
    {
        void OnMovePuck(InputAction.CallbackContext context);
    }
}
