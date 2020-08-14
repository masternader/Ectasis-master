using System.Collections;
using System.Collections.Generic;
using Leap.Unity.Attributes;
using Leap.Unity.Interaction.Internal;
using Leap.Unity.Interaction;
using UnityEngine;
using Normal.Realtime;

public class ProgressorSync : RealtimeComponent
{
    
    [SerializeField]
    public InteractionSlider slider;   //Assign the UI slider of your scene in this slot 

    private ProgressorModel _model;

    private ProgressorModel model
    {
        set
        {
            if (_model != null)
            {
                // Unregister from events
                _model.progressorSliderDidChange -= ProgressDidChange;
            }

            // Store the model
            _model = value;

            if (_model != null)
            {
                // Update the slider to match the current value of the model in the room.
                UpdateProgressor();

                // Register for events so we'll know if the color changes later
                _model.progressorSliderDidChange += ProgressDidChange;
            }
        }
    }

    // This method fires whenever someone changes the 'progressorSlider' value on the model. We'll use this method to update the slider in our scene to match.
    private void ProgressDidChange(ProgressorModel model, float value)
    {
        Debug.Log("Progress changed");
        UpdateProgressor();
    }
    
    private void UpdateProgressor() {
        slider.HorizontalSliderValue =_model.progressorSlider;
    }
    
    public void SetSlider(float value) {
        if (_model == null) {
            return;
        }

        // Update the model. This will fire ProgressDidChange() on all of the other clients, which will instruct them to update their copy of the slider.
        _model.progressorSlider = value;
        Debug.Log("call set slider");
    }
}
