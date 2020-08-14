using UnityEngine;
using UnityEngine.UI;
using InteractionEngineUtility;
using Leap.Unity.Attributes;
using Leap.Unity.Interaction.Internal;
using Leap.Unity.Interaction;
using Leap.Unity.Space;
using System;
using System.Collections.Generic;
 
 public class ControlAnimation : MonoBehaviour
 {
    private Animator anim;

    public InteractionSlider slider;   //Assign the UI slider of your scene in this slot 

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
        anim.Play("cubeanimTest", -1, slider.normalizedHorizontalValue);
        // Debug.Log("SLider value" + slider.normalizedHorizontalValue);
    }

 }

//  using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Normal.Realtime;
// using Doozy.Engine.Progress;

// public class ProgressorSync : RealtimeComponent
// {
//     [SerializeField]
//     private Progressor _progressor;

//     private ProgressorModel _model;

//     private ProgressorModel model
//     {
//         set
//         {
//             if (_model != null)
//             {
//                 // Unregister from events
//                 _model.progressorSliderDidChange -= ProgressDidChange;
//             }

//             // Store the model
//             _model = value;

//             if (_model != null)
//             {
//                 // Update the slider to match the current value of the model in the room.
//                 UpdateProgressor();

//                 // Register for events so we'll know if the color changes later
//                 _model.progressorSliderDidChange += ProgressDidChange;
//             }
//         }
//     }

//     // This method fires whenever someone changes the 'progressorSlider' value on the model. We'll use this method to update the slider in our scene to match.
//     private void ProgressDidChange(ProgressorModel model, float value)
//     {
//         UpdateProgressor();
//     }

//     private void UpdateProgressor()
//     {
//         _progressor.SetValue(_model.progressorSlider);
//     }

//     public void SliderUIValueDidChange(float value) {
//         // Update the model. This will fire ProgressDidChange() on all of the other clients, which will instruct them to update their copy of the slider.
//         _model.progressorSlider = value;
//     }
// }