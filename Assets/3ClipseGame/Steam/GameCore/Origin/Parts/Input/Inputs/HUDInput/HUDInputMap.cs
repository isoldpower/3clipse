//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/3ClipseGame/Steam/GameCore/Origin/Parts/Input/Inputs/HUDInput/HUDInputMap.inputactions
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

public partial class @HUDInputMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @HUDInputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HUDInputMap"",
    ""maps"": [
        {
            ""name"": ""HUDActions"",
            ""id"": ""ae8d0ee5-ee0e-4338-8cc4-8911ac11bec3"",
            ""actions"": [
                {
                    ""name"": ""ToggleMainMenu"",
                    ""type"": ""Button"",
                    ""id"": ""20841473-99bd-433a-83a0-4f3524412efb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ShowElementalWheel"",
                    ""type"": ""Button"",
                    ""id"": ""b16af61f-1d5f-4ceb-ac9d-37108dc5da8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LootScrollForward"",
                    ""type"": ""Button"",
                    ""id"": ""b3797aec-0c3c-4b0f-acb2-fd5e466af57f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LootScrollBack"",
                    ""type"": ""Button"",
                    ""id"": ""4e4998ce-7605-4c58-8256-f1c156888ff0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""994e0683-481c-46ae-983c-cca3fd0f6f0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8570186c-a1fe-4951-9bf8-ba491430a5d0"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMainMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2637e3c-cb47-4cbb-b0f1-b1861b10b3fb"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShowElementalWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65b08f2f-1736-4290-85f1-841bd8879ea1"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LootScrollForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f894f43f-2322-4de1-884e-ec564933ab15"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bd4ed1c-6f1c-43a7-af1c-f140491493ce"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LootScrollBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // HUDActions
        m_HUDActions = asset.FindActionMap("HUDActions", throwIfNotFound: true);
        m_HUDActions_ToggleMainMenu = m_HUDActions.FindAction("ToggleMainMenu", throwIfNotFound: true);
        m_HUDActions_ShowElementalWheel = m_HUDActions.FindAction("ShowElementalWheel", throwIfNotFound: true);
        m_HUDActions_LootScrollForward = m_HUDActions.FindAction("LootScrollForward", throwIfNotFound: true);
        m_HUDActions_LootScrollBack = m_HUDActions.FindAction("LootScrollBack", throwIfNotFound: true);
        m_HUDActions_Interact = m_HUDActions.FindAction("Interact", throwIfNotFound: true);
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

    // HUDActions
    private readonly InputActionMap m_HUDActions;
    private IHUDActionsActions m_HUDActionsActionsCallbackInterface;
    private readonly InputAction m_HUDActions_ToggleMainMenu;
    private readonly InputAction m_HUDActions_ShowElementalWheel;
    private readonly InputAction m_HUDActions_LootScrollForward;
    private readonly InputAction m_HUDActions_LootScrollBack;
    private readonly InputAction m_HUDActions_Interact;
    public struct HUDActionsActions
    {
        private @HUDInputMap m_Wrapper;
        public HUDActionsActions(@HUDInputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @ToggleMainMenu => m_Wrapper.m_HUDActions_ToggleMainMenu;
        public InputAction @ShowElementalWheel => m_Wrapper.m_HUDActions_ShowElementalWheel;
        public InputAction @LootScrollForward => m_Wrapper.m_HUDActions_LootScrollForward;
        public InputAction @LootScrollBack => m_Wrapper.m_HUDActions_LootScrollBack;
        public InputAction @Interact => m_Wrapper.m_HUDActions_Interact;
        public InputActionMap Get() { return m_Wrapper.m_HUDActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HUDActionsActions set) { return set.Get(); }
        public void SetCallbacks(IHUDActionsActions instance)
        {
            if (m_Wrapper.m_HUDActionsActionsCallbackInterface != null)
            {
                @ToggleMainMenu.started -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnToggleMainMenu;
                @ToggleMainMenu.performed -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnToggleMainMenu;
                @ToggleMainMenu.canceled -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnToggleMainMenu;
                @ShowElementalWheel.started -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnShowElementalWheel;
                @ShowElementalWheel.performed -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnShowElementalWheel;
                @ShowElementalWheel.canceled -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnShowElementalWheel;
                @LootScrollForward.started -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnLootScrollForward;
                @LootScrollForward.performed -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnLootScrollForward;
                @LootScrollForward.canceled -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnLootScrollForward;
                @LootScrollBack.started -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnLootScrollBack;
                @LootScrollBack.performed -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnLootScrollBack;
                @LootScrollBack.canceled -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnLootScrollBack;
                @Interact.started -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_HUDActionsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_HUDActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ToggleMainMenu.started += instance.OnToggleMainMenu;
                @ToggleMainMenu.performed += instance.OnToggleMainMenu;
                @ToggleMainMenu.canceled += instance.OnToggleMainMenu;
                @ShowElementalWheel.started += instance.OnShowElementalWheel;
                @ShowElementalWheel.performed += instance.OnShowElementalWheel;
                @ShowElementalWheel.canceled += instance.OnShowElementalWheel;
                @LootScrollForward.started += instance.OnLootScrollForward;
                @LootScrollForward.performed += instance.OnLootScrollForward;
                @LootScrollForward.canceled += instance.OnLootScrollForward;
                @LootScrollBack.started += instance.OnLootScrollBack;
                @LootScrollBack.performed += instance.OnLootScrollBack;
                @LootScrollBack.canceled += instance.OnLootScrollBack;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public HUDActionsActions @HUDActions => new HUDActionsActions(this);
    public interface IHUDActionsActions
    {
        void OnToggleMainMenu(InputAction.CallbackContext context);
        void OnShowElementalWheel(InputAction.CallbackContext context);
        void OnLootScrollForward(InputAction.CallbackContext context);
        void OnLootScrollBack(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}