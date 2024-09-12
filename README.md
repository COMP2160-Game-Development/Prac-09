# COMP2160 Game Development – Prac Week 10

## Topics covered:
* Rigidbody Physics
* Update vs FixedUpdate
* Collisions

## Non-Discussion Question
There is no discussion question today. Happy coding!

<img src="images/codingdog.gif" alt="a happy dog coding. Image source: https://es.pixilart.com/art/coding-dogo-sr2712ab0b35ecd" width="300" />

## Today's Task
In this practical, you will be creating a technical prototype of a rising and falling platform to better understand how Unity's physics engine works. Technical prototypes are an important part of game development, and involve experimenting with different approaches to solve a problem. They are also a great way to uncover new techniques and approaches that you may use later.

Next week, you will be putting what you learnt this week into action to create a game using the physics engine. So, complete this practical (or at least the half-mark) before starting Week 10. Hae fun!

You can check out an implementation of this technical prototype here: https://uncanny-machines.itch.io/comp2160-week-09-sample

### The project
The framework for today implements the general environment, including a "BumperPrefab" object which includes the following components:
* Floor: A cube with a texture and a Collider, but no Rigidbody. It is therefore static and does not move.
* Bumper: A cube with a texture and a Collider and a Rigidbody. Examine the Rigidbody component in the Inspector, with reference to the Rigidbody Scripting Reference: https://docs.unity3d.com/ScriptReference/Rigidbody.html. Make sure you know what is going on.
* Label: A world-space canvas with a Text object. We will edit this text so can see which physics implementation is which.

There is also a PlayerActions 

## Step 1 – Adding Forces (20 min) 
We will use our first Bumper prefab to begin experimenting with movement. Our goal is to have the "Bumper" move upwards when the player presses the space bar, and then move back down on its own.

Up to now, we've moved everything using the transform component. While this is suitable for games that do not simulate physics, if we wanted to have our bumper react to other objects and external forces (like gravity), we need to start using the Physics engine. For this, we will be using the Rigidbody in non-kinematic mode, and normal Colliders over Triggers.

Create a new script for our Bumper object. Remember to give it a meaningful name. I will be referring to it as the `Bumper` script throughout this sheet for clarity.


Play the game and note how the paddle moves and how it interacts with the walls and the puck. This current set up is invalid. The paddle has a collider but no rigidbody, i.e. it is a static collider. Static colliders should not be moved, as  Unity does not guarantee correct behaviour when you move a static collider. If we want to move an object using its transform, it should have a kinematic rigidbody.

Add the directive ```[RequireComponent(typeof(Rigidbody))]``` to the ControlPuck script so that it forces you to have a rigidbody on the paddle.

Rather than relying on the designer to make the rigidbody kinematic in the editor, we can do it directly in code. In the Start method set the isKinematic field on the rigidbody to true:

```
private Rigidbody rigidbody;
```
...
```
Start()
{
    rigidbody = GetComponent<Rigidbody>();
    rigidbody.isKinematic = true;
}
```

This is generally good practice: If your code expects a component to exist and be configured in a particular way, it is better to force this in code rather than rely on remembering to do it in the editor.

Play this version of the game. How does the kinematic rigidbody interact with static and dynamic objects in the scene?

### Checkpoint! Save, commit and push your work now


## Step 2 – Add Physics Materials & Constraints
At the moment, the puck moves with the default settings for friction and bounciness, which are not very suitable for the game.

Create separate [Physics Materials](https://docs.unity3d.com/2021.3/Documentation/Manual/class-PhysicMaterial.html) for the floor, walls, puck and paddle and attach them to the colliders for each. You may remember doing this in COMP1150.

Experiment with the settings until the puck moves smoothly with low friction and bounces off the walls in an appropriate way.

At the moment it is possible to make the puck bounce off the table. We probably don’t want this in the game. Add appropriate constraints to the puck’s rigidbody to keep it flat on the table.

### Checkpoint! Save, commit and push your work now

## Step 3 – Experiment with Paddle physics
We’re going to experiment with different ways of moving the paddle using rigidbody physics rather than transform. Rather than providing you with the solution for each, we will be giving you the links to documentation and asking you to implement solutions in each one. 

Don't worry if some of your results are a bit weird - this is about stepping outside of your comfort zone and experimenting. This is where you become a true game developer!

Disable the isKinematic flag on the paddle. 

Make five copies of the paddle control script. Rename their file and class names as follows, and implement the corresponding control schemes:

* <b>Position:</b> Move the paddle to the mouse position using [rigidbody.position](https://docs.unity3d.com/ScriptReference/Rigidbody-position.html).

* <b>MovePosition:</b> Move the paddle to the mouse position using [rigidbody.MovePosition()](https://docs.unity3d.com/ScriptReference/Rigidbody.MovePosition.html).

* <b>Velocity:</b> Move the paddle towards the mouse position at a fixed velocity using [rigidbody.velocity](https://docs.unity3d.com/ScriptReference/Rigidbody-velocity.html).

* <b>AddForce:</b> Add a force to accelerate the paddle towards the mouse position using [rigidbody.AddForce()](https://docs.unity3d.com/ScriptReference/Rigidbody.AddForce.html).

* <b>Impulse:</b> When the player clicks the mouse, add an impulse to move the paddle towards the mouse position using rigidbody.AddForce() with [ForceMode.Impulse](https://docs.unity3d.com/ScriptReference/ForceMode.Impulse.html). 

Play the game using each of these controllers. Can you explain the behaviour of each? Which is the most appropriate for this game and why?

Explore how the other parameters on the paddle’s rigidbody component (mass, drag, collision detection mode, etc) affect each version. Try and find your optimal puck movement.

## Checkpoint! Save, commit and push your work now

### To receive half marks for today, show your tutor:

* Your five scripts, each with different methods of moving the puck.
* Your findings from experimenting with each, and which one you think is best.
* Any changes you made to the paddle's rigidbody component or script to get it moving right.

### Step 4 - Sound Effects
We want to add a sound effect when the puck collides with something.

Use the [Chiptone tool](https://sfbgames.itch.io/chiptone) to generate an appropriate sound effect. When you’ve made something you like, download it and add it to your project.

Add an [AudioSource](https://docs.unity3d.com/Manual/class-AudioSource.html) to the puck which plays this effect. Make sure you disable looping and Play on Awake.

Add a script to the puck that detects a collision event and tells the Audio Source component to play. 

Using the data in the Collision object, change the volume of the sound effect so it varies depending on the strength of the collision. (Hint: check the docs for [Collision](https://docs.unity3d.com/ScriptReference/Collision.html)!)


## Prac complete! Save, commit and push your work now

### To receive full marks for today, show your tutor:

* Your working audio on collision between puck and other objects.
* How you are modulating volume based on collision strength.






