using _3ClipseGame.Steam.Global.Input.Scripts;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace _3ClipseGame.Steam.Global.Input.HUDInput
{
    public class HUDInputHandler : InputHandler
    {
        #region Serialization

        [Header("HUD Components")] 
        [SerializeField] private GameObject elementalWheel;
        [SerializeField] private UI.Scripts.TabSystem.TabButton mainTab;

        [Header("Events")]
        [SerializeField] private UnityEvent<UI.Scripts.TabSystem.TabButton> switchModeToMenu;
        
        #endregion

        #region Public

        public event UnityAction<UI.Scripts.TabSystem.TabButton> SwitchingModeToMenu
        {
            add => switchModeToMenu.AddListener(value);
            remove => switchModeToMenu.RemoveListener(value);
        }

        #endregion

        #region Initialization

        private HUDInputActions _hudInputActions;

        #endregion

        #region MonoBehaviourMethods

        private void Awake() => _hudInputActions = new HUDInputActions();
        private void OnEnable() => Enable();
        private void OnDisable() => Disable();

        #endregion

        #region PublicMethods

        public override void Enable()
        {
            _hudInputActions.Enable();
            _hudInputActions.HUDActions.Enable();

            _hudInputActions.HUDActions.ToggleMainMenu.started += SwitchModeToMain;

            _hudInputActions.HUDActions.ShowElementalWheel.started += OnToggleElementalWheel;
            _hudInputActions.HUDActions.ShowElementalWheel.canceled += OnToggleElementalWheel;
        }

        public override void Disable()
        {
            _hudInputActions.HUDActions.Disable();
            _hudInputActions.Disable();
        }

        #endregion

        #region PrivateMethods
        
        private void OnToggleElementalWheel(InputAction.CallbackContext context) =>
            elementalWheel.SetActive(context.ReadValueAsButton());

        private void SwitchModeToMain(InputAction.CallbackContext context)
        {
            switchModeToMenu?.Invoke(mainTab);
        }

        #endregion
    }
}
