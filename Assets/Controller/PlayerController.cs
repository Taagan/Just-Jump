// GENERATED AUTOMATICALLY FROM 'Assets/Controller/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""5cc0b395-6ceb-4dee-be85-b1902d111244"",
            ""actions"": [
                {
                    ""name"": ""BottomJump"",
                    ""type"": ""Button"",
                    ""id"": ""0c9d4815-b9ab-4a60-90b3-29b233c02a6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleJump"",
                    ""type"": ""Button"",
                    ""id"": ""37479695-e030-46a4-85fc-ffe7588bdc68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TopJump"",
                    ""type"": ""Button"",
                    ""id"": ""56536971-7bdc-4cf6-8c3b-8fb9fb092966"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1550dd47-c97c-4bfd-ba6c-bae2beb01732"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BottomJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe02a1d1-1352-460c-a31b-9cfeaca87432"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BottomJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b44908f4-b042-4202-8ef1-567c3e916b96"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""055ac468-774a-40c7-b80d-f7e012828564"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4dfc912-961a-464a-9d7a-fba975858551"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2947ec02-1483-4a22-a5a7-f5d01b3463e0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43d5afdc-5b39-480b-ab84-29640bb33066"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49bc8b58-2c57-4f81-9801-222e32768ac4"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37832ac8-f95e-4714-8109-1116cb035df4"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TopJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1d0b643-e39b-42ad-b05e-1f2bd6888277"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TopJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca1b11c9-e9a6-4ad4-a365-c8973bdba422"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TopJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95718556-4ef4-41e1-ae00-36edd98e5768"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TopJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_BottomJump = m_Gameplay.FindAction("BottomJump", throwIfNotFound: true);
        m_Gameplay_MiddleJump = m_Gameplay.FindAction("MiddleJump", throwIfNotFound: true);
        m_Gameplay_TopJump = m_Gameplay.FindAction("TopJump", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_BottomJump;
    private readonly InputAction m_Gameplay_MiddleJump;
    private readonly InputAction m_Gameplay_TopJump;
    public struct GameplayActions
    {
        private @PlayerController m_Wrapper;
        public GameplayActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @BottomJump => m_Wrapper.m_Gameplay_BottomJump;
        public InputAction @MiddleJump => m_Wrapper.m_Gameplay_MiddleJump;
        public InputAction @TopJump => m_Wrapper.m_Gameplay_TopJump;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @BottomJump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBottomJump;
                @BottomJump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBottomJump;
                @BottomJump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBottomJump;
                @MiddleJump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMiddleJump;
                @MiddleJump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMiddleJump;
                @MiddleJump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMiddleJump;
                @TopJump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTopJump;
                @TopJump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTopJump;
                @TopJump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTopJump;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @BottomJump.started += instance.OnBottomJump;
                @BottomJump.performed += instance.OnBottomJump;
                @BottomJump.canceled += instance.OnBottomJump;
                @MiddleJump.started += instance.OnMiddleJump;
                @MiddleJump.performed += instance.OnMiddleJump;
                @MiddleJump.canceled += instance.OnMiddleJump;
                @TopJump.started += instance.OnTopJump;
                @TopJump.performed += instance.OnTopJump;
                @TopJump.canceled += instance.OnTopJump;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnBottomJump(InputAction.CallbackContext context);
        void OnMiddleJump(InputAction.CallbackContext context);
        void OnTopJump(InputAction.CallbackContext context);
    }
}
