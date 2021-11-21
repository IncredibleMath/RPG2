//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.1
//     from Assets/Scripts/PlayerControls.inputactions
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

namespace RPG
{
    public partial class @PlayerControls : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Moving"",
            ""id"": ""a6dffc86-1f93-4de7-97a3-5123e3b04b74"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""644266b1-d9a1-472d-975b-5291007768f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""f3db58d9-f540-44c8-9fbd-ff9c2fe814df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""8c188b94-68a1-44e4-9dca-26da13971427"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BattleState"",
                    ""type"": ""Button"",
                    ""id"": ""c7a8e5d5-6194-4171-9710-fb631ddfeb44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""ac1d8747-a7b0-4aaf-8d65-9c5e0c7d2f75"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""5fa2cb13-e4aa-4647-8f6a-8da25d84a2a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""39ee927b-66e7-4d42-8463-fd7dccc18ac8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""275214ac-5a71-4f36-86ca-d6b04b17e903"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e0b8d5cc-4404-4524-9c30-8c4ffc12b1ca"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4b895f5e-2cf1-4591-afa2-5514576e2ae5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""956f931a-196d-41e4-845f-0027ef620724"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""acb87b96-e96b-422a-a1c8-c61908a9b7f6"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f653922c-5cf5-4dc2-a7d6-2b1fbd16dce7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0834750b-359e-4f0b-86f5-aa02616d108e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BattleState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d8da4d0-28f6-43b1-bbe0-81513485d9b8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f22608a3-1fb6-4a9d-ba44-9d2ca10759d7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Battle"",
            ""id"": ""d58362fd-865a-4b3e-af68-5e613889653d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""f07daf2f-9c8e-4493-af8d-f26e338156f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightCombatStance"",
                    ""type"": ""Button"",
                    ""id"": ""fc63f05c-1280-4aba-bb97-b31312d8bc89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MediumCombatStance"",
                    ""type"": ""Button"",
                    ""id"": ""efcb776c-8489-4091-ac55-a9305e454481"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""HardCombatStance"",
                    ""type"": ""Button"",
                    ""id"": ""80886e0b-0df8-42fe-b727-ea34f49e58a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""b375086b-984b-4a53-a93c-ae5be70d12fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""63c72361-a458-4714-afee-3ba2121cca51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ForwardBack"",
                    ""id"": ""4bc37e69-40b9-4f9c-827e-e7c911353c1e"",
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
                    ""id"": ""e31b8a09-5b3e-40c8-ba43-2c21cd2dd67e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""aa4c04c3-ee6c-41ea-a234-641580a919f0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""StepSide"",
                    ""id"": ""8514b701-e5b9-4a07-9d75-bb91bd32dd5e"",
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
                    ""id"": ""c004d9f9-41fe-4435-9efc-b90a0e7a94f7"",
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
                    ""id"": ""ece42e1c-bd1d-4201-9515-201e9a192eeb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7bc9425d-712a-45ea-b920-a671e9a6d869"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightCombatStance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1f38422-5864-414c-a968-8258caf80904"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MediumCombatStance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa0d15f4-0d87-4483-8600-51625d98f563"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HardCombatStance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48353fb2-94ee-4b3d-a668-cbc15c28e7ba"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b87bffa4-a9e2-4c79-b5e5-ea980f2d2fa0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Moving
            m_Moving = asset.FindActionMap("Moving", throwIfNotFound: true);
            m_Moving_Move = m_Moving.FindAction("Move", throwIfNotFound: true);
            m_Moving_Inventory = m_Moving.FindAction("Inventory", throwIfNotFound: true);
            m_Moving_Use = m_Moving.FindAction("Use", throwIfNotFound: true);
            m_Moving_BattleState = m_Moving.FindAction("BattleState", throwIfNotFound: true);
            m_Moving_MousePosition = m_Moving.FindAction("MousePosition", throwIfNotFound: true);
            m_Moving_Pause = m_Moving.FindAction("Pause", throwIfNotFound: true);
            // Battle
            m_Battle = asset.FindActionMap("Battle", throwIfNotFound: true);
            m_Battle_Move = m_Battle.FindAction("Move", throwIfNotFound: true);
            m_Battle_LightCombatStance = m_Battle.FindAction("LightCombatStance", throwIfNotFound: true);
            m_Battle_MediumCombatStance = m_Battle.FindAction("MediumCombatStance", throwIfNotFound: true);
            m_Battle_HardCombatStance = m_Battle.FindAction("HardCombatStance", throwIfNotFound: true);
            m_Battle_Use = m_Battle.FindAction("Use", throwIfNotFound: true);
            m_Battle_Attack = m_Battle.FindAction("Attack", throwIfNotFound: true);
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

        // Moving
        private readonly InputActionMap m_Moving;
        private IMovingActions m_MovingActionsCallbackInterface;
        private readonly InputAction m_Moving_Move;
        private readonly InputAction m_Moving_Inventory;
        private readonly InputAction m_Moving_Use;
        private readonly InputAction m_Moving_BattleState;
        private readonly InputAction m_Moving_MousePosition;
        private readonly InputAction m_Moving_Pause;
        public struct MovingActions
        {
            private @PlayerControls m_Wrapper;
            public MovingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Moving_Move;
            public InputAction @Inventory => m_Wrapper.m_Moving_Inventory;
            public InputAction @Use => m_Wrapper.m_Moving_Use;
            public InputAction @BattleState => m_Wrapper.m_Moving_BattleState;
            public InputAction @MousePosition => m_Wrapper.m_Moving_MousePosition;
            public InputAction @Pause => m_Wrapper.m_Moving_Pause;
            public InputActionMap Get() { return m_Wrapper.m_Moving; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MovingActions set) { return set.Get(); }
            public void SetCallbacks(IMovingActions instance)
            {
                if (m_Wrapper.m_MovingActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMove;
                    @Inventory.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnInventory;
                    @Inventory.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnInventory;
                    @Inventory.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnInventory;
                    @Use.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnUse;
                    @Use.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnUse;
                    @Use.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnUse;
                    @BattleState.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnBattleState;
                    @BattleState.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnBattleState;
                    @BattleState.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnBattleState;
                    @MousePosition.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnMousePosition;
                    @MousePosition.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnMousePosition;
                    @MousePosition.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnMousePosition;
                    @Pause.started -= m_Wrapper.m_MovingActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_MovingActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_MovingActionsCallbackInterface.OnPause;
                }
                m_Wrapper.m_MovingActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Inventory.started += instance.OnInventory;
                    @Inventory.performed += instance.OnInventory;
                    @Inventory.canceled += instance.OnInventory;
                    @Use.started += instance.OnUse;
                    @Use.performed += instance.OnUse;
                    @Use.canceled += instance.OnUse;
                    @BattleState.started += instance.OnBattleState;
                    @BattleState.performed += instance.OnBattleState;
                    @BattleState.canceled += instance.OnBattleState;
                    @MousePosition.started += instance.OnMousePosition;
                    @MousePosition.performed += instance.OnMousePosition;
                    @MousePosition.canceled += instance.OnMousePosition;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                }
            }
        }
        public MovingActions @Moving => new MovingActions(this);

        // Battle
        private readonly InputActionMap m_Battle;
        private IBattleActions m_BattleActionsCallbackInterface;
        private readonly InputAction m_Battle_Move;
        private readonly InputAction m_Battle_LightCombatStance;
        private readonly InputAction m_Battle_MediumCombatStance;
        private readonly InputAction m_Battle_HardCombatStance;
        private readonly InputAction m_Battle_Use;
        private readonly InputAction m_Battle_Attack;
        public struct BattleActions
        {
            private @PlayerControls m_Wrapper;
            public BattleActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Battle_Move;
            public InputAction @LightCombatStance => m_Wrapper.m_Battle_LightCombatStance;
            public InputAction @MediumCombatStance => m_Wrapper.m_Battle_MediumCombatStance;
            public InputAction @HardCombatStance => m_Wrapper.m_Battle_HardCombatStance;
            public InputAction @Use => m_Wrapper.m_Battle_Use;
            public InputAction @Attack => m_Wrapper.m_Battle_Attack;
            public InputActionMap Get() { return m_Wrapper.m_Battle; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BattleActions set) { return set.Get(); }
            public void SetCallbacks(IBattleActions instance)
            {
                if (m_Wrapper.m_BattleActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnMove;
                    @LightCombatStance.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnLightCombatStance;
                    @LightCombatStance.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnLightCombatStance;
                    @LightCombatStance.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnLightCombatStance;
                    @MediumCombatStance.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnMediumCombatStance;
                    @MediumCombatStance.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnMediumCombatStance;
                    @MediumCombatStance.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnMediumCombatStance;
                    @HardCombatStance.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnHardCombatStance;
                    @HardCombatStance.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnHardCombatStance;
                    @HardCombatStance.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnHardCombatStance;
                    @Use.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnUse;
                    @Use.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnUse;
                    @Use.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnUse;
                    @Attack.started -= m_Wrapper.m_BattleActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_BattleActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_BattleActionsCallbackInterface.OnAttack;
                }
                m_Wrapper.m_BattleActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @LightCombatStance.started += instance.OnLightCombatStance;
                    @LightCombatStance.performed += instance.OnLightCombatStance;
                    @LightCombatStance.canceled += instance.OnLightCombatStance;
                    @MediumCombatStance.started += instance.OnMediumCombatStance;
                    @MediumCombatStance.performed += instance.OnMediumCombatStance;
                    @MediumCombatStance.canceled += instance.OnMediumCombatStance;
                    @HardCombatStance.started += instance.OnHardCombatStance;
                    @HardCombatStance.performed += instance.OnHardCombatStance;
                    @HardCombatStance.canceled += instance.OnHardCombatStance;
                    @Use.started += instance.OnUse;
                    @Use.performed += instance.OnUse;
                    @Use.canceled += instance.OnUse;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                }
            }
        }
        public BattleActions @Battle => new BattleActions(this);
        public interface IMovingActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnInventory(InputAction.CallbackContext context);
            void OnUse(InputAction.CallbackContext context);
            void OnBattleState(InputAction.CallbackContext context);
            void OnMousePosition(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
        }
        public interface IBattleActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnLightCombatStance(InputAction.CallbackContext context);
            void OnMediumCombatStance(InputAction.CallbackContext context);
            void OnHardCombatStance(InputAction.CallbackContext context);
            void OnUse(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
        }
    }
}