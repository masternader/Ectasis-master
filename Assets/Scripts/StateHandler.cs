using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StateHandler : MonoBehaviour
{
    public EnvironmentStateManager stateManager;
    public EnvironmentStateManager.ButtonState state = EnvironmentStateManager.ButtonState.INIT;
    public void invokeStateHandler() {
        stateManager.UpdateState(this.state);
    }
}
