//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Game Folders/Scripts/Concretes/Inputs/GameInputs.inputactions
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

namespace UnityEndlessRunnerProject.Inputs
{
    public partial class @GameInputs : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerOnFoot"",
            ""id"": ""fe036360-90da-4efd-a83b-6a08a6f3c963"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dee4fd9d-7844-4fef-b2a4-14097a7258bd"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""95f6a1c8-6b05-4690-ada0-93a424a77644"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""2eb6eee7-437b-4f3c-8e1e-898bc9840ec8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ddcde753-a543-4fa0-b694-68bb96f41f0a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2506b74e-33d3-4941-bfc3-5c429c240772"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bedb1106-72cd-4a58-945d-28df21f38a5b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap(duration=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerOnFoot
            m_PlayerOnFoot = asset.FindActionMap("PlayerOnFoot", throwIfNotFound: true);
            m_PlayerOnFoot_HorizontalMove = m_PlayerOnFoot.FindAction("HorizontalMove", throwIfNotFound: true);
            m_PlayerOnFoot_Jump = m_PlayerOnFoot.FindAction("Jump", throwIfNotFound: true);
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

        // PlayerOnFoot
        private readonly InputActionMap m_PlayerOnFoot;
        private IPlayerOnFootActions m_PlayerOnFootActionsCallbackInterface;
        private readonly InputAction m_PlayerOnFoot_HorizontalMove;
        private readonly InputAction m_PlayerOnFoot_Jump;
        public struct PlayerOnFootActions
        {
            private @GameInputs m_Wrapper;
            public PlayerOnFootActions(@GameInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @HorizontalMove => m_Wrapper.m_PlayerOnFoot_HorizontalMove;
            public InputAction @Jump => m_Wrapper.m_PlayerOnFoot_Jump;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOnFoot; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOnFootActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOnFootActions instance)
            {
                if (m_Wrapper.m_PlayerOnFootActionsCallbackInterface != null)
                {
                    @HorizontalMove.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @HorizontalMove.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnHorizontalMove;
                    @Jump.started -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerOnFootActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_PlayerOnFootActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @HorizontalMove.started += instance.OnHorizontalMove;
                    @HorizontalMove.performed += instance.OnHorizontalMove;
                    @HorizontalMove.canceled += instance.OnHorizontalMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public PlayerOnFootActions @PlayerOnFoot => new PlayerOnFootActions(this);
        public interface IPlayerOnFootActions
        {
            void OnHorizontalMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
    }
}
