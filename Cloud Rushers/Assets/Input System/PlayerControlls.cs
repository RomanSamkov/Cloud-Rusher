// GENERATED AUTOMATICALLY FROM 'Assets/Input System/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""FlyerInputMap"",
            ""id"": ""8b194969-ee0a-483d-a777-3c295230d2c8"",
            ""actions"": [
                {
                    ""name"": ""RotateGoalPercent"",
                    ""type"": ""Value"",
                    ""id"": ""c7b04f6e-55e9-4b1b-b778-85f998e926a4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WingSweep"",
                    ""type"": ""Button"",
                    ""id"": ""c6c068d7-301b-4fa2-958a-a8c2663f9487"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stop"",
                    ""type"": ""Button"",
                    ""id"": ""64de85e4-860d-4f4b-9c43-5c09bf9fdae4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action1"",
                    ""type"": ""Button"",
                    ""id"": ""2c13e93f-2ce1-413a-94e9-624b4d99952b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action2"",
                    ""type"": ""Button"",
                    ""id"": ""49ca4a4a-bad3-475f-b12b-17ac8610d2f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action3"",
                    ""type"": ""Button"",
                    ""id"": ""30610f69-e8d1-4e54-afce-7e35ac15e09e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b874b3fb-94ef-4b08-ac11-cb8e840f97c3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateGoalPercent"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11994c30-2a42-4e42-a673-e0f0f358fc14"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9244d26c-7462-4d09-ac88-4b0e8ec7b45c"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60efa13a-0fa7-47c4-9da4-8742607717bb"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d3b755a-66f9-45d8-973c-89d9d951ed20"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WingSweep"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58a415df-5d9a-4cb6-8ee2-21be5b67b20c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FlyerInputMap
        m_FlyerInputMap = asset.FindActionMap("FlyerInputMap", throwIfNotFound: true);
        m_FlyerInputMap_RotateGoalPercent = m_FlyerInputMap.FindAction("RotateGoalPercent", throwIfNotFound: true);
        m_FlyerInputMap_WingSweep = m_FlyerInputMap.FindAction("WingSweep", throwIfNotFound: true);
        m_FlyerInputMap_Stop = m_FlyerInputMap.FindAction("Stop", throwIfNotFound: true);
        m_FlyerInputMap_Action1 = m_FlyerInputMap.FindAction("Action1", throwIfNotFound: true);
        m_FlyerInputMap_Action2 = m_FlyerInputMap.FindAction("Action2", throwIfNotFound: true);
        m_FlyerInputMap_Action3 = m_FlyerInputMap.FindAction("Action3", throwIfNotFound: true);
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

    // FlyerInputMap
    private readonly InputActionMap m_FlyerInputMap;
    private IFlyerInputMapActions m_FlyerInputMapActionsCallbackInterface;
    private readonly InputAction m_FlyerInputMap_RotateGoalPercent;
    private readonly InputAction m_FlyerInputMap_WingSweep;
    private readonly InputAction m_FlyerInputMap_Stop;
    private readonly InputAction m_FlyerInputMap_Action1;
    private readonly InputAction m_FlyerInputMap_Action2;
    private readonly InputAction m_FlyerInputMap_Action3;
    public struct FlyerInputMapActions
    {
        private @PlayerControlls m_Wrapper;
        public FlyerInputMapActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateGoalPercent => m_Wrapper.m_FlyerInputMap_RotateGoalPercent;
        public InputAction @WingSweep => m_Wrapper.m_FlyerInputMap_WingSweep;
        public InputAction @Stop => m_Wrapper.m_FlyerInputMap_Stop;
        public InputAction @Action1 => m_Wrapper.m_FlyerInputMap_Action1;
        public InputAction @Action2 => m_Wrapper.m_FlyerInputMap_Action2;
        public InputAction @Action3 => m_Wrapper.m_FlyerInputMap_Action3;
        public InputActionMap Get() { return m_Wrapper.m_FlyerInputMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlyerInputMapActions set) { return set.Get(); }
        public void SetCallbacks(IFlyerInputMapActions instance)
        {
            if (m_Wrapper.m_FlyerInputMapActionsCallbackInterface != null)
            {
                @RotateGoalPercent.started -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnRotateGoalPercent;
                @RotateGoalPercent.performed -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnRotateGoalPercent;
                @RotateGoalPercent.canceled -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnRotateGoalPercent;
                @WingSweep.started -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnWingSweep;
                @WingSweep.performed -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnWingSweep;
                @WingSweep.canceled -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnWingSweep;
                @Stop.started -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnStop;
                @Stop.performed -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnStop;
                @Stop.canceled -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnStop;
                @Action1.started -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction1;
                @Action1.performed -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction1;
                @Action1.canceled -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction1;
                @Action2.started -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction2;
                @Action2.performed -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction2;
                @Action2.canceled -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction2;
                @Action3.started -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction3;
                @Action3.performed -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction3;
                @Action3.canceled -= m_Wrapper.m_FlyerInputMapActionsCallbackInterface.OnAction3;
            }
            m_Wrapper.m_FlyerInputMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateGoalPercent.started += instance.OnRotateGoalPercent;
                @RotateGoalPercent.performed += instance.OnRotateGoalPercent;
                @RotateGoalPercent.canceled += instance.OnRotateGoalPercent;
                @WingSweep.started += instance.OnWingSweep;
                @WingSweep.performed += instance.OnWingSweep;
                @WingSweep.canceled += instance.OnWingSweep;
                @Stop.started += instance.OnStop;
                @Stop.performed += instance.OnStop;
                @Stop.canceled += instance.OnStop;
                @Action1.started += instance.OnAction1;
                @Action1.performed += instance.OnAction1;
                @Action1.canceled += instance.OnAction1;
                @Action2.started += instance.OnAction2;
                @Action2.performed += instance.OnAction2;
                @Action2.canceled += instance.OnAction2;
                @Action3.started += instance.OnAction3;
                @Action3.performed += instance.OnAction3;
                @Action3.canceled += instance.OnAction3;
            }
        }
    }
    public FlyerInputMapActions @FlyerInputMap => new FlyerInputMapActions(this);
    public interface IFlyerInputMapActions
    {
        void OnRotateGoalPercent(InputAction.CallbackContext context);
        void OnWingSweep(InputAction.CallbackContext context);
        void OnStop(InputAction.CallbackContext context);
        void OnAction1(InputAction.CallbackContext context);
        void OnAction2(InputAction.CallbackContext context);
        void OnAction3(InputAction.CallbackContext context);
    }
}
