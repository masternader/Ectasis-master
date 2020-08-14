# Ecstasis

Submitted to MIT Reality Hack 2020 [Devpost Submission](https://devpost.com/software/ecstasis)

## Problem 

Palliative and hospice care refer to an interdisciplinary medical caregiving approach aimed at optimizing quality of life, mitigating suffering from the stress of terminal illness and providing comfort and care to patients and their families to acceptance and undergo a transformation of perception. 

According to WHO, each year an estimated 40 million people are in need of palliative care. The global need for palliative care will continue to grow as a result of the rising burden of noncommunicable diseases and ageing populations. Early palliative and hospice care reduces unnecessary hospital admissions and the use of health services. 

Virtual Embodiment has been proven to be an effective clinical and therapeutic application of virtual reality as a therapy (Bourdin, P. 2017). But therein lies a problem: virtualization of patients by therapists using head-mounted virtual reality devices effectively diminishes the social connection between them. The strong bonds therapists spend months developing with their patients becomes threatened by a new care paradigm that deemphasizes human interaction in favor of “dosed” or “autoplay” therapy.

More information on palliative care and its dynamic socio economic challenges can be found here: https://www.who.int/news-room/fact-sheets/detail/palliative-care

## Solution

Virtual reality (VR) and virtual embodiment (VE) have been demonstrated to be therapeutically effective tools for helping to cope with the reality of transitional palliative and hospice care (Bourdin, P. 2017). Current clinical therapy standards are confined in the main to relief by sedation, rarely indicating more than access to support groups and professionals should the patient request it. Effective therapies for near end of life patients narrow drastically. Virtual Reality and Virtual Embodiment provides a powerful vehicle for the transition into hospice care through immersion, the therapeutically viable engine that drives the heart of a convincing VR experience.

In order to solve the problem of encouraging potential disconnects and gaps in care, and to leverage the power of VR, several strategies have been explored 


Ecstasis (ecstasy) is an immersive VR journey that reconnects the relationship

 reduces stress of patients in need of palliative care allowing them to cope with their illnesses with a more positive mindset.

Therapists personalizing the experience based on the patient’s needs 
An out of body experience (OBE) “is the experience in which a person seems to be awake and to see his body and the world from a location outside the physical body”. Fear of death was found to be lower in the experimental group that underwent Virtual OBE. (Bourdin, 1) 

Bourdin, P., Barberia, I., Oliva, R. and Slater, M. (2017). A Virtual Out-of-Body Experience Reduces Fear of Death.

## What it does

Therapist takes a patient on a real-time immersive and responsive journey in VR. The clinician has access to a hand’s free control system UI that allows them to set the environment, control movement and embody various digital assets to further enhance the relationship between therapist and patient. The intent of the experience is to take the patient on an immersive journey that results in an out of body (OBE) experience. It is through these immersive journeys, personally tailored by the therapist based on each patients care needs. 
The therapist’s digital avatar accompanies the patient in their immersive VR journey. At the very end of the experience, the patient is put in a virtual out of body experience.
Careful consideration of biometric feedback will allow the therapist to disseminate the OBE with maximum effectiveness because it will be synchronized to the exact moment that patient proprioception has been primed for the OBE.
Ecstasis creates an increasingly immersive cascade of visuotactile techniques that are injected into the experience and controlled by the clinician in real-time based on analysis of biomarkers that indicate “readiness”, what we call the subjects suggestibility for the therapy. 
Once a patient is qualified to be a suitable candidate for VR therapy, a licensed therapist from the hospice care team will work closely with the patient to enable a custom virtual out of body experience (VOBE)
VR Therapy is effective, however, there tends to be a sense of isolation, especially in a therapeutic context. Ecstasis restores experience of guided therapy by allowing the therapist to read the patient while controlling the immersive VR experience in real time while encouraging the therapists engagement in real time. An OBE is created by a systematic manipulation of audiovisual cues to elicit “avatarization” the embodiment of patient into our digital model by giving them full control over this new avatar.

## How we built it

We built this in two parts, a VR application with the Oculus Quest and an AR component using Project North Star headset.
We setup a Project North Star headset with an Intel Real Sense for 6DOF tracking and a Leap Motion for hand tracking, and created a movable user interface to control the state of the VR experience. This interface would then translate into controlling the flow of the experience, such as triggering the out of body experience or slowing down the experience for the user.

## Challenges we ran into

We first tried to set up the North Star headset using the newly released SteamVR drivers and use a Vive tracker to track head position. This proved to be very difficult, with problems arising from the tracker’s transform being off as well as SteamVR failing to build on our computer. We eventually switched to the RealSense camera which took us only a half hour of setup and worked wonderfully.
Triggering animations based on Leap Motion APIs proved difficult. We tried to use the Doozy UI library to help configure these actions, but we unable to install the Unity Package along with Leap Motion plugin. We resolved this by writing code to sync the animations with the Leap Motion’s Slider state. We synced it between both the elements in the project and across the network using the NormalCore library. 
Another problem we faced was integrating both headsets into the same Unity project. We had gotten NormCore to create a full multiplayer environment but once we added the other headset package it fell apart. We ran into this too soon to the deadline and left us without being able to demonstrate the two parts working in tandem.


## Accomplishments that we're proud of

We are proud of having one of only two working North Star project headsets and took on the incredibly daunting task of integrating this already prototypical headset into a Scene with a VR device. We also helped give input to both the newly released SteamVR plugin for North Star and the NormalAPI, which will help both of the projects mature in the future.

## What we learned

We learned how to develop on the Project North Star as well as working with the SDKs of RealSense, Leap Motion, and SteamVR. We learned many teamwork skills to break down and prioritize our tasks and design what interactions we would create, both physically and virtually.


## Citations

Nhpco.org. (2019). NHPCO Facts Figures. [online] Available at: https://www.nhpco.org/wp-content/uploads/2019/07/2018_NHPCO_Facts_Figures.pdf [Accessed 19 Jan. 2020].

Bourdin, P., Barberia, I., Oliva, R. and Slater, M. (2017). A Virtual Out-of-Body Experience Reduces Fear of Death.

