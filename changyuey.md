#### Name: yueying chang (Stella)
#### Username: changyuey
#### Animal role: Bear
#### Primary project responsibility: Everything with code

### Code discussion
#### 1. A description of the parts of the project you worked on, including a level of input: [ All | Most | Half | Some | Touched ]. Only mentioned touched if it is important to the project overall.
Task | Level of input
------------ | -------------
Item Pickup | All
Dialog System | All
Task System | All
Level Transition | All
Player Control | Half
Abilities | Half
Enemy Patrol and Following | Some
Player Respawn | Some
Moving Platforms | Some

* Because I am the only comp side student, all the new stuff are done by myself, those "Some"/"Half" means I inherited and modified the code from last project.
* I did the abilities of falling slower, colour change, light up, lantern by myself, the scaling and sprint are from the previous guy.

#### 2. A description and link to the most interesting part of code written by you.
##### The moving platform
This is not really code based but still something interesting that I want to mention. The moving platform has a mesh collider itself, and is using the animation to move. However when the player stands on it she should be moving with the platform. There is the script called "AttachPlayer" that is used by the moving platforms to "parent" their positions. The interesting part is the collider, what I did is copy the platform object, and paste another one under it, disable the mesh renderer so that it is invisible, remove the animator, and set the renderer to be abit above the actual platform and tick is trigger. In this way, whenever player is on the platform she will be moving together with platform.

##### Level transition
Our game has 4 levels in total, and player will gain abilities that can be used through the remaining levels. At first I had trouble figuring out how to make the player object consistent, I searched online and found code about keeping the objects not destroyed when loading to another level, but it didn't work for me. So what I did is parse the name of the level, and do corresponding actions when the level start, for example in level 0 player picks up a bow, then when loading level 1, 2, and 3, call the same method of player picking up the bow, it is not the most elegant way to do it but it works well for our game in this scale. 

#### 3. Identification of the section of code you are most proud of - and why you feel that this is particularly good code. (this could be the same as above)
Because of the fact that our game is a story based game, and the fact that I am the only comp side student in the group, the game does not involve a lot of complicated mechanics and coding, instead, there are many story telling involved. 
The diaglog system is something I never tried before, with some help from a tutorial video(https://www.youtube.com/watch?v=_nRzoTzeyxU&t=602s), I was able to create a script that is highly reusable.
I first created a script called "Dialog", this is similar to the concept of an object in java which includes a name and a list of sentences, then the file "instruction" plays a role of diaglog manager, the field in the file includes a Diaglog object, 
and 4 actual canvas assets being the name of NPC, the conversation, the instructions of "press [V] to continue", and a background image that holds the text. Whenever player enters the collider, the Diaglog is triggered and when player presses the button [V],
the system will loop through the sentences array to display the conversation. 

link: https://github.com/Iodachi/Revive/tree/master/Assets/Scripts/Dialogs 

### Learning reflection
#### 1. Reflection on what you have learnt and how you have developed as a programmer in this project.
Through our development we had changed a lot on the player character, as more abilities are added more objects are attached to the character's body, and we had to change the prefab multiple times. The problem occurs when doing this, since some of the scripts need a reference to the player and removign the prefab will result in them being missing. An example would be those killboxs no longer kills player and make her respawn, and those enemies no longer follows the player, etc. This could easily be solved by changing the script to automatically find the player object using methods such as "findObjectOfType", I think I applied this way in some of the scripts and it is alot easier, but I wasn't bothered to change the other scripts. In my future projects I'll definitely take this into consideration and design properly in the beginning so that they are more robust to changes.

As you can see, the code is not heavy at all, instead I spent a lot of time adjusting the canvas, colliders, killboxes and respawn points, etc. Some of them are very repetitive and time consuming, and I think it would work better if I taught the designers to implement them in their levels and save the time for me to do more coding and make the game more fun. Communication is definitely very important when it comes to teamworks, another issue was that some of the moving platforms were too hard for player to pass, and it also had something to do with me communicating with the designers, we only started sitting and working together towards the end of the project and it will definitely be less problematic if we do that earlier.

#### 2. A description of the most important thing you will use from this project in future projects.
Unity is unlike any other programs we learned as computer science students in the university, throughout the development, I was astonished by what Unity can do. For example, the build in NavMesh system that I could not image how to achieve with pure java code.
There are many more amazing features such as the colliders, the lightings, the prefabs, tags, etc. Unity has boardened my eyesight and provides me a way of thinking creatively to achieve many things, and I think this is the most important thing I've learned, I'll definitely explore more features about unity and make use of them, and I'm looking forward to create a tower defence or a duplicate of the game Overcooked in the future.

