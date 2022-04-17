using System.Collections;
using System.Collections.Generic;
using UnityEndlessRunnerProject.Abstracts.Inputs;
using UnityEngine;
using UnityEngine.InputSystem;

namespace  UnityEndlessRunnerProject.Inputs
{
    public class InputReader : IInputReader
    {
        PlayerInput _playerInput;
        public float Horizontal { get; private set; }
        public bool IsJump { get; private set; }

        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;
            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;//performed eventi butona basıp çektiğinde tetiklenir.
            _playerInput.currentActionMap.actions[1].started+=  OnJump ; //started eventi butona basma anı
            _playerInput.currentActionMap.actions[1].canceled+=  OnJump ; //canceled eventi butondan çıkış anı

        }

        private void OnJump(InputAction.CallbackContext context)
        {
            IsJump = context.ReadValueAsButton();
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }
    }
}


