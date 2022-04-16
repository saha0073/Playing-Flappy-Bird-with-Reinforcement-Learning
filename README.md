# Playing-Flappy-Bird-with-Reinforcement-Learning-in-Unity

Playing-Flappy-Bird-with-Reinforcement-Learning-in-Unity

![title-pic](https://github.com/saha0073/Playing-Flappy-Bird-with-Reinforcement-Learning-in-Unity/blob/main/Capture_211.PNG)

This repo contains Flappy Bird game project in which a neural network has been trained to play Flappy Bird game by itself using reinforcement learning (RL). Unity ML-Agent package has been used to implement the reinforcement cycle, give rewards based on the actions and teach the neural network to play the game. The trained neural network was able to attain a high score of 211 in the Flappy Bird game.     

## Techniques Used
* GameEngine: Unity3D 20.3
* Modeling Techniques: Reinforcement Learning, Machine Learning
* Tech Stack: C#
* Packages: ML-Agents Release 10, ML-Agents Extensions Release 10
* Unity tools: Ray Perception Sensor 3D, UI, Prefab, GameManager, Sprites, etc


## Demo of playing Flappy Bird with RL!
* The`./Recordings` folder contains several recordings during the game play, like as shown below. 
<p align="center"><img src="https://github.com/saha0073/Playing-Flappy-Bird-with-Reinforcement-Learning-in-Unity/blob/main/Recordings/ezgif.com-gif-maker.gif" style="width:80%"\></p>


## To Run the Unity application
* Clone this repo, and open the project in Unity. Here Unity 20.3 has been used.
* Please make sure the project have ML-Agents Release 10 (1.6.0-preview), and Input System 1.1.0-preview.3 within the package manager. In case ML-Agents don't function correctly you can follow this nice article by [T Suzuki](https://dev.to/tsuz/run-unity-ml-agents-examples-on-mac-52p6).
* Now open the SampleScene_AgentSetup from the Scenes folder, please check that `Flappy_11-04 (NN Model)` is loaded in the Behaviour Parameters section of the Environment/Player gameobject. Now hit play and the trained model should play the Flappy Bird game.


## The logic for adding rewards during the training
* If the bird hits the upper and lower obstacle the agent gets a -ve reward of 1.0f.
* If the bird passes within the gap between the upper & lower obstacles it gets a +ve reward of 0.5f.
* If the bird goes up above the upper obstacle or comes down below the lower obstacle the agent again gets a -ve reward of 1.0f.

The performance of network can be further improved with a few modifications, such as adjusting the Raycaster, tuning the input variables.

If you have any questions please feel free to connect with me on [Linkedin](https://www.linkedin.com/in/subhodip-saha-li/). Happy Learning!




