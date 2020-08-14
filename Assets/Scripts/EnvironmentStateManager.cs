using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EnvironmentStateManager : MonoBehaviour
{
    public enum ButtonState {
        INIT,
        FOREST,
        MOUNTAIN
    }

    protected ButtonState State = ButtonState.INIT;

    public GameObject initPanel;
    public GameObject forestPanel;
    public GameObject mountainPanel;

    void clearPanels() {
        this.initPanel.SetActive(false);
        this.forestPanel.SetActive(false);
        this.mountainPanel.SetActive(false);
    }

    // event handler for state
    public void UpdateState(ButtonState state) {
        Debug.Log("Ping");
        this.clearPanels();
        if (state == ButtonState.INIT) {
            this.initPanel.SetActive(true);
        }
        if (state == ButtonState.FOREST) {
            this.forestPanel.SetActive(true);
        }
        if (state == ButtonState.MOUNTAIN) {
            this.mountainPanel.SetActive(true);
        }
    }
}
