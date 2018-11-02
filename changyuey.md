#### Name: yueying chang
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


#### 3. Identification of the section of code you are most proud of - and why you feel that this is particularly good code. (this could be the same as above)
Because of the fact that our game is a story based game, and the fact that I am the only comp side student in the group, the game does not involve a lot of complicated mechanics and coding, instead, there are many story telling involved. 
The diaglog system is something I never tried before, with some help from a tutorial video(https://www.youtube.com/watch?v=_nRzoTzeyxU&t=602s), I was able to create a script that is highly reusable.
I first created a script called "Dialog", this is similar to the concept of an object in java which includes a name and a list of sentences, then the file "instruction" plays a role of diaglog manager, the field in the file includes a Diaglog object, 
and 4 actual canvas assets being the name of NPC, the conversation, the instructions of "press [V] to continue", and a background image that holds the text. Whenever player enters the collider, the Diaglog is triggered and when player presses the button [V],
the system will loop through the sentences array to display the conversation. 

link: https://github.com/Iodachi/Revive/tree/master/Assets/Scripts/Dialogs 

### Learning reflection
#### 1. Reflection on what you have learnt and how you have developed as a programmer in this project.

#### 2. A description of the most important thing you will use from this project in future projects.
Unity is unlike any other programs we learned as computer science students in the university, throughout the development, I was astonished by what Unity can do. For example, the build in NavMesh system that I could not image how to achieve with pure java code.
There are many more amazing features such as the colliders, the lightings, the prefabs, tags, etc. 

