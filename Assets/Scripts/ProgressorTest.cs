using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressorTest : MonoBehaviour {
    [SerializeField]
    private float _color;
    private float _previousColor;

    private ProgressorSync _colorSync;

    private void Start() {
        // Get a reference to the color sync component
        _colorSync = GetComponent<ProgressorSync>();
    }

    private void Update() {
        // If the color has changed (via the inspector), call SetColor on the color sync component.
        if (_color != _previousColor) {
            _colorSync.SetSlider(_color);
            _previousColor = _color;
        }
    }
}