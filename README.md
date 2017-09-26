# DrummAR

DrummAR is a virtual drumset built for Microsoft HoloLens during HoloHack 2017.

You can checkout DrummAR in action from our [video demo](https://www.youtube.com/watch?v=Zas5JCjQb40&feature=youtu.be).

## How we built it
We created a custom image target using Vuforia, testing several different designs to optimize target recognition. We then used a drum kit asset from Unity, and overlaid collider boxes on each drum head. On collision, each drum plays it's respective sound through a script we wrote in C#. We created sounds for snare drum, hi, medium and low toms, crash and ride cymbal in Ableton.

## Challenges we ran into
- It was hard to find a good image and image size for vuforia to track our target.
- The viewing field of the HoloLens would clip when we got too close to the drums. We had to adjust and test how far away the drumheads could be and still feel natural, while not clipping when our hands were too close.

## Accomplishments that we're proud of
- We are able to accurately and consistently activate drum sounds, fairly realistically.
- We positioned the drums well to create an authentic. simulated drumming experience
- We utilized Vuforia to simulate new gestures, which the HoloLens system didn't support: any type of collision, including tapping, striking

## What we learned
- We learned a lot about vuforia, which we had never used, and now understand what types of images are better targets.
- We also learned more about deploying apps to HoloLens, which we found to be a pretty involved process

## What's next for DrummAR
- We had ideas for incorporating a "performance mode" which involves a live crowd that can simulate real-world high pressure performance situations.
- We want to have support for two hands so that sounds can be created simultaneously, i.e. two different drums on the same beats
- Incorporate sound pedals for the kick drum and hi-hat to make the drum set more complete and authentic.
- We also considered adding more instruments

## Tools/Technology used
- Vuforia
- Unity
- Microsoft-hololens
- Photoshop (graphics)
- Ableton (sound)

