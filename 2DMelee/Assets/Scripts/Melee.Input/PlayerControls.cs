// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Melee.Input
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Grounded"",
            ""id"": ""19948a8b-6ce8-4e60-8226-49f09582eed0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a0da33f2-fec0-4809-92e5-ef84c38e2ce4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fb192f18-55f5-4417-af87-57f4aa86716d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""e8f63d83-27e0-48f7-a979-110771694c32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Light Attack"",
                    ""type"": ""Button"",
                    ""id"": ""b129c63f-d6d7-4931-9aa9-165b6c1923a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Heavy Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e8fbc10c-db9e-446b-8e42-ac4ff0f1a5cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""1c8a5fab-98f6-4333-a340-90bf684f8b43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ad"",
                    ""id"": ""3406c46d-b4c5-48a8-986b-08732e24b3de"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b73aff14-8d97-43d7-8310-f2c666d94305"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""898f4910-d13a-4a29-b08c-76604ed604f5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""dpad"",
                    ""id"": ""12034d81-2871-424d-9087-23bf3cfbc8ee"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b0d3a80b-525d-40a6-9e4d-80f9c69ffe46"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fd111c31-adbd-436b-b032-d4e1f6bc7f7f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9f3d1127-fffa-4dac-884e-e360c1974dd5"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6856de1-586a-4811-a617-367bf296d8b9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30371f85-712b-4996-ba27-8baf3460d5c2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""109fd473-044d-48c6-9ac7-53741ade9c66"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f251b5d5-6133-40ea-a107-cd394fb22eec"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff73ea44-ed93-491a-b67c-43f1a0464562"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Light Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77459e78-3096-4a26-b277-d5b169a99482"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Light Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60c44688-50f9-425b-a571-8de6cf49511e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heavy Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7b1223c-51cc-4520-8187-8be80392f96f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Heavy Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""741a3857-e391-4f88-be86-2e2ae62622fe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e4d4d44-ced1-4087-91ef-d076141eec08"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Grounded
            m_Grounded = asset.FindActionMap("Grounded", throwIfNotFound: true);
            m_Grounded_Move = m_Grounded.FindAction("Move", throwIfNotFound: true);
            m_Grounded_Jump = m_Grounded.FindAction("Jump", throwIfNotFound: true);
            m_Grounded_Dash = m_Grounded.FindAction("Dash", throwIfNotFound: true);
            m_Grounded_LightAttack = m_Grounded.FindAction("Light Attack", throwIfNotFound: true);
            m_Grounded_HeavyAttack = m_Grounded.FindAction("Heavy Attack", throwIfNotFound: true);
            m_Grounded_Guard = m_Grounded.FindAction("Guard", throwIfNotFound: true);
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

        // Grounded
        private readonly InputActionMap m_Grounded;
        private IGroundedActions m_GroundedActionsCallbackInterface;
        private readonly InputAction m_Grounded_Move;
        private readonly InputAction m_Grounded_Jump;
        private readonly InputAction m_Grounded_Dash;
        private readonly InputAction m_Grounded_LightAttack;
        private readonly InputAction m_Grounded_HeavyAttack;
        private readonly InputAction m_Grounded_Guard;
        public struct GroundedActions
        {
            private @PlayerControls m_Wrapper;
            public GroundedActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Grounded_Move;
            public InputAction @Jump => m_Wrapper.m_Grounded_Jump;
            public InputAction @Dash => m_Wrapper.m_Grounded_Dash;
            public InputAction @LightAttack => m_Wrapper.m_Grounded_LightAttack;
            public InputAction @HeavyAttack => m_Wrapper.m_Grounded_HeavyAttack;
            public InputAction @Guard => m_Wrapper.m_Grounded_Guard;
            public InputActionMap Get() { return m_Wrapper.m_Grounded; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GroundedActions set) { return set.Get(); }
            public void SetCallbacks(IGroundedActions instance)
            {
                if (m_Wrapper.m_GroundedActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_GroundedActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GroundedActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GroundedActionsCallbackInterface.OnMove;
                    @Jump.started -= m_Wrapper.m_GroundedActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GroundedActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GroundedActionsCallbackInterface.OnJump;
                    @Dash.started -= m_Wrapper.m_GroundedActionsCallbackInterface.OnDash;
                    @Dash.performed -= m_Wrapper.m_GroundedActionsCallbackInterface.OnDash;
                    @Dash.canceled -= m_Wrapper.m_GroundedActionsCallbackInterface.OnDash;
                    @LightAttack.started -= m_Wrapper.m_GroundedActionsCallbackInterface.OnLightAttack;
                    @LightAttack.performed -= m_Wrapper.m_GroundedActionsCallbackInterface.OnLightAttack;
                    @LightAttack.canceled -= m_Wrapper.m_GroundedActionsCallbackInterface.OnLightAttack;
                    @HeavyAttack.started -= m_Wrapper.m_GroundedActionsCallbackInterface.OnHeavyAttack;
                    @HeavyAttack.performed -= m_Wrapper.m_GroundedActionsCallbackInterface.OnHeavyAttack;
                    @HeavyAttack.canceled -= m_Wrapper.m_GroundedActionsCallbackInterface.OnHeavyAttack;
                    @Guard.started -= m_Wrapper.m_GroundedActionsCallbackInterface.OnGuard;
                    @Guard.performed -= m_Wrapper.m_GroundedActionsCallbackInterface.OnGuard;
                    @Guard.canceled -= m_Wrapper.m_GroundedActionsCallbackInterface.OnGuard;
                }
                m_Wrapper.m_GroundedActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Dash.started += instance.OnDash;
                    @Dash.performed += instance.OnDash;
                    @Dash.canceled += instance.OnDash;
                    @LightAttack.started += instance.OnLightAttack;
                    @LightAttack.performed += instance.OnLightAttack;
                    @LightAttack.canceled += instance.OnLightAttack;
                    @HeavyAttack.started += instance.OnHeavyAttack;
                    @HeavyAttack.performed += instance.OnHeavyAttack;
                    @HeavyAttack.canceled += instance.OnHeavyAttack;
                    @Guard.started += instance.OnGuard;
                    @Guard.performed += instance.OnGuard;
                    @Guard.canceled += instance.OnGuard;
                }
            }
        }
        public GroundedActions @Grounded => new GroundedActions(this);
        public interface IGroundedActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
            void OnLightAttack(InputAction.CallbackContext context);
            void OnHeavyAttack(InputAction.CallbackContext context);
            void OnGuard(InputAction.CallbackContext context);
        }
    }
}
