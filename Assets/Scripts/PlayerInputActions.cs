// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""PlayerMap"",
            ""id"": ""960918f0-938f-4450-964e-1678a2ff1a6a"",
            ""actions"": [
                {
                    ""name"": ""HMovement"",
                    ""type"": ""Value"",
                    ""id"": ""45374e12-8dd4-4df2-bae8-16f398d7bf37"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VMovement"",
                    ""type"": ""Value"",
                    ""id"": ""8dca9322-226f-413b-9798-ba196de6e73f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""XAxis"",
                    ""id"": ""e277b066-68eb-41f8-9b68-b86127673ec3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""963a4247-bacd-455b-8a1f-f06fc4625a38"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2ab1bba5-e548-4448-bb4b-aeb9051504ed"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ZAxis"",
                    ""id"": ""6ba2ad48-e54b-4aaa-8d31-6fd0deaebc04"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""13e570cf-0fed-40b1-bf58-e4a2b2d1b541"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a4b5940f-3dea-4e29-9c43-49f473ec2b70"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""VMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerMap
        m_PlayerMap = asset.FindActionMap("PlayerMap", throwIfNotFound: true);
        m_PlayerMap_HMovement = m_PlayerMap.FindAction("HMovement", throwIfNotFound: true);
        m_PlayerMap_VMovement = m_PlayerMap.FindAction("VMovement", throwIfNotFound: true);
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

    // PlayerMap
    private readonly InputActionMap m_PlayerMap;
    private IPlayerMapActions m_PlayerMapActionsCallbackInterface;
    private readonly InputAction m_PlayerMap_HMovement;
    private readonly InputAction m_PlayerMap_VMovement;
    public struct PlayerMapActions
    {
        private @PlayerActions m_Wrapper;
        public PlayerMapActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HMovement => m_Wrapper.m_PlayerMap_HMovement;
        public InputAction @VMovement => m_Wrapper.m_PlayerMap_VMovement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMapActions instance)
        {
            if (m_Wrapper.m_PlayerMapActionsCallbackInterface != null)
            {
                @HMovement.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnHMovement;
                @HMovement.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnHMovement;
                @HMovement.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnHMovement;
                @VMovement.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnVMovement;
                @VMovement.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnVMovement;
                @VMovement.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnVMovement;
            }
            m_Wrapper.m_PlayerMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HMovement.started += instance.OnHMovement;
                @HMovement.performed += instance.OnHMovement;
                @HMovement.canceled += instance.OnHMovement;
                @VMovement.started += instance.OnVMovement;
                @VMovement.performed += instance.OnVMovement;
                @VMovement.canceled += instance.OnVMovement;
            }
        }
    }
    public PlayerMapActions @PlayerMap => new PlayerMapActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerMapActions
    {
        void OnHMovement(InputAction.CallbackContext context);
        void OnVMovement(InputAction.CallbackContext context);
    }
}
