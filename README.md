# i-like-to-move-it-move-it
Exercise 5 of the "Intermediate Object-Oriented Programming for Unity Games" course of the "C# Programming for Unity Game Development" Specialization by the University of Colorado via Coursera

## Description

Problem 1 – Add green ball child class and prefab

Drag the sprite for the green ball onto the Hierarchy window, rename it to GreenBall, and add a Rigidbody 2D component to it. Drag it onto the prefabs folder in the Project window to turn it into a prefab.

Create a new GreenBall script in the scripts folder and drag the script onto the prefab. Open the script in your IDE.

Add a documentation comment at the top of the class and make the GreenBallGreenBall class a child class of the BallBall class.

There are 3 important things to note about the BallBall class:

    The impulseVectorimpulseVector field is protected so child classes can see it and change its value

    The StartStart method is virtual and protected so child classes can see it and override it

    The PrintMessagePrintMessage method is virtual and protected so child classes can see it and override it

We're going to make the green ball move up instead of left and print a different message.

Go back to the GreenBallGreenBall class. Add the keywords overrideoverride and protectedprotected before voidvoid for the StartStart method. In the StartStart method, change the x and y components of the impulseVectorimpulseVector field so the ball will go straight up. Add the following line of code next: base ⁣ ⁣. ⁣ ⁣Start ⁣ ⁣();base.Start();. This calls the StartStart method in the parent class.

Delete the UpdateUpdate method.

Override the PrintMessagePrintMessage method to print a new message.

When the StartStart method in the GreenBallGreenBall class is called by the Unity engine, it sets the impulseVectorimpulseVector field and calls the StartStart method in the BallBall class. That method gets the ball moving, then calls the PrintMessagePrintMessage method that you overrode in the GreenBallGreenBall class.

The calls to the StartStart method and the PrintMessagePrintMessage method behave in class-specific ways -- polymorphism in action!

Problem 2 – Add red ball child class and prefab

Drag the sprite for the red ball onto the Hierarchy window, rename it to RedBall, and add a Rigidbody 2D component to it. Drag it onto the prefabs folder in the Project window to turn it into a prefab.

Create a new RedBall script in the scripts folder and drag the script onto the prefab. Open the script in your IDE.

Add a documentation comment at the top of the class and make the RedBallRedBall class a child class of the BallBall class.

We're going to make the red ball move left just like the ball does, but it will print a different message.

Delete the StartStart and UpdateUpdate methods.

Override the PrintMessagePrintMessage method to print a new message.

When the StartStart method in the RedBallRedBall class is called by the Unity engine, it calls the StartStart method that the RedBallRedBall class inherited from the BallBall class. That method gets the ball moving, then calls the PrintMessagePrintMessage method that you overrode in the RedBallRedBall class.

Problem 3 – Add a ball spawner

Delete all the ball game objects from the Hierarchy window. Create a new BallSpawner script in the scripts folder and drag the script onto the main camera. Open the script in your IDE.

Add a documentation comment at the top of the class and add fields for the three ball prefabs and a spawn timer. Populate the prefab fields in the Inspector.

Add code to the StartStart method to add a Timer component (put it in the field you just declared), set its duration to 1 second, and run it.

Add code to the UpdateUpdate method to check if the spawn timer is finished. If it is, re-run the spawn timer and randomly spawn one of the 3 balls.

## Getting Started

n/a

### Dependencies

* Windows 10
* Microsoft Visual Studio
* .NET
* Unity

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/i-like-to-move-it-move-it)

### Executing program

n/a

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

Problem provided by the _University of Colorado_ and _Coursera_
