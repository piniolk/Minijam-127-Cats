//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""ab5e7451-b4ce-4f7a-bc5e-e9dc18a87153"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""5d8cb6de-8a75-4f91-94bf-3762a1ed0293"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d14ff515-0c92-42ee-8310-264b38d6f163"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""84a5d026-3ba4-4d3a-98c0-a4bcf89d07a4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6abaa135-3cf1-4654-a1ae-cc6dfbb8f5a3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ded8131-ca41-4162-859b-4cee3ce804d1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c12f0a35-d4e3-496b-879e-d94f66b7d4a4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""CutSceneControl"",
            ""id"": ""c05ba7ed-9076-4f33-acf1-59a5e01758ed"",
            ""actions"": [
                {
                    ""name"": ""CutSceneEnd"",
                    ""type"": ""Button"",
                    ""id"": ""88b04782-2b9f-42f1-88aa-a44a134db9d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5de8e4cc-a629-4a8a-b5e4-5ce33d389fa1"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CutSceneEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9db3a46-8072-4f7f-a573-8512e3057551"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CutSceneEnd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Test"",
            ""id"": ""7bbdf3a7-b26b-414f-a587-2212ed513f3f"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Value"",
                    ""id"": ""85fc3f47-6f30-4f09-a819-c181bbe6cf9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b72991b-6012-43f0-b767-b801616a4c5b"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_Walk = m_PlayerControl.FindAction("Walk", throwIfNotFound: true);
        // CutSceneControl
        m_CutSceneControl = asset.FindActionMap("CutSceneControl", throwIfNotFound: true);
        m_CutSceneControl_CutSceneEnd = m_CutSceneControl.FindAction("CutSceneEnd", throwIfNotFound: true);
        // Test
        m_Test = asset.FindActionMap("Test", throwIfNotFound: true);
        m_Test_Newaction = m_Test.FindAction("New action", throwIfNotFound: true);
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

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_Walk;
    public struct PlayerControlActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_PlayerControl_Walk;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnWalk;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);

    // CutSceneControl
    private readonly InputActionMap m_CutSceneControl;
    private ICutSceneControlActions m_CutSceneControlActionsCallbackInterface;
    private readonly InputAction m_CutSceneControl_CutSceneEnd;
    public struct CutSceneControlActions
    {
        private @PlayerControls m_Wrapper;
        public CutSceneControlActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CutSceneEnd => m_Wrapper.m_CutSceneControl_CutSceneEnd;
        public InputActionMap Get() { return m_Wrapper.m_CutSceneControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CutSceneControlActions set) { return set.Get(); }
        public void SetCallbacks(ICutSceneControlActions instance)
        {
            if (m_Wrapper.m_CutSceneControlActionsCallbackInterface != null)
            {
                @CutSceneEnd.started -= m_Wrapper.m_CutSceneControlActionsCallbackInterface.OnCutSceneEnd;
                @CutSceneEnd.performed -= m_Wrapper.m_CutSceneControlActionsCallbackInterface.OnCutSceneEnd;
                @CutSceneEnd.canceled -= m_Wrapper.m_CutSceneControlActionsCallbackInterface.OnCutSceneEnd;
            }
            m_Wrapper.m_CutSceneControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CutSceneEnd.started += instance.OnCutSceneEnd;
                @CutSceneEnd.performed += instance.OnCutSceneEnd;
                @CutSceneEnd.canceled += instance.OnCutSceneEnd;
            }
        }
    }
    public CutSceneControlActions @CutSceneControl => new CutSceneControlActions(this);

    // Test
    private readonly InputActionMap m_Test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_Test_Newaction;
    public struct TestActions
    {
        private @PlayerControls m_Wrapper;
        public TestActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Test_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_TestActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public TestActions @Test => new TestActions(this);
    public interface IPlayerControlActions
    {
        void OnWalk(InputAction.CallbackContext context);
    }
    public interface ICutSceneControlActions
    {
        void OnCutSceneEnd(InputAction.CallbackContext context);
    }
    public interface ITestActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
