![Pong Title.png](https://github.com/mwb-wiseman/Pong/blob/main/GDD%20Images/Pong%20Title.png "Pong Title")

## Introduction

This document outlines the plan for the development of a Pong clone. This project is being undertaken for technical learning purposes (C# language, Unity engine), while engaging with the original game's design to create a novel experience.

__Key New Features__

- Physics added to player racket to introduce elements from real-life tennis.

__Key Learning Objectives__

- Scene management
- Simple AI
- Maintain music across multiple menu scenes

***

## GAME DESIGN

#### High Concept

Pong is a 2D versus game with player vs AI and player vs player game modes. Players move their racket up and down to hit the ball and score when the ball hits the opposite edge of the pitch. The first player to score 5 times wins.

#### Summary Overview

The player controls a racket, which they can move up and down to hit a ball moving left and right. The ball bounces off of the top and bottom walls as well as both rackets; the ball speeds up each time a player hits it. A player scores when the ball hits the opposite boundary, and a new round begins. The first to 5, wins.

__Key Features__

- Single- and Multi-player game modes
- Interactive sound

#### Gameplay

__First Minutes__

_Main Menu_

Buttons to start a game with 1 or 2 players, to look at the Controls, or to close the application.

![Pong Menu.png](https://github.com/mwb-wiseman/Pong/blob/main/GDD%20Images/Pong%20Menu.png "Pong Menu")

_In-Game_

After 2 seconds the ball starts moving left or right. The player/s move their rackets up and down to hit the ball, which speeds up on each hit. Where the ball hits the racket determines the angle it bounces back at.

If the ball hits the top or bottom boundary it will bounce. Each player scores if the ball hits the opposite boundary. When a player scores their written score at the top of the screen updates, and a new round starts. After the first round the ball will start in the direction of whichever player conceded the last point.

__Gameflow__

![Pong Gameflow.png](https://github.com/mwb-wiseman/Pong/blob/main/GDD%20Images/Pong%20Gameflow.png "Pong Gameflow")

__Victory Conditions__

First to score 5 times wins.

__Number of Players__

1 or 2 players.

#### Art

![Pong Art 1.png](https://github.com/mwb-wiseman/Pong/blob/main/GDD%20Images/Pong%20Art%201.png "Pong Art 1")

![Pong Art 2.png](https://github.com/mwb-wiseman/Pong/blob/main/GDD%20Images/Pong%20Art%202.png "Pong Art 2")

#### Technical Aspects

Game to be built in Unity for Windows PC.

***

## MARKETING

#### Target Audience

This remake of a classic will appeal to fans of the original, and to a new audience that enjoy a versus experience but haven't played Pong before.

The simplistic design will ensure the game is accessible to a broad audience, with the added appeal of local multiplayer for those wanting to play with their friends.

#### Competitors

Based on classic Pong, the player experience has been most significantly altered by applying physics to the rackets. This introduces mechanical response times to player actions, particularly changes of direction, which enhances the tactical element of the game by placing greater emphasis on shot placement. In turn, this reduces a player's reliance on their existing reflexes and so broadens accessibility.

A similar game currently on the market is Disc Jam, which is an example of a tennis-inspired game aimed at providing a more challenging competitive experience. The most significant addition to the mechanics is the ability to curve your shots, and input being required to catch the disc. While these are good additions for a more competitive demographic, they greatly reduce appeal and accessibility to the more casual gamer Pong is targeted at.

***

## DEVELOPMENT

#### Milestone Schedule

1. Set up basic scene – pitch, player rackets, stationary ball.
2. Player movement and controls. Simple AI.
3. Ball movement
4. Menus (including Start/Restart/Victory functionality)
5. Audio (including multi-scene music functionality)
6. Graphic design
7. Play-test/Code review

#### Resources

1 Junior Developer
Unity (Personal)

#### Schedule

| __Time__ | __Objective__ | __Date completed__ |
| --- | --- | --- |
| Day 1 | Milestone 1 | 09/02/22 |
| Day 2 | Milestone 2 | 10/02/22 |
| Day 3 | Milestone 3 | 11/02/22 |
| Day 4 | Milestone 4 | 14/02/22 |
| Day 5 | “ |  |
| Day 6 | Milestone 5 | 16/02/22 |
| Day 7 | Milestone 6 | 17/02/22 |
| Day 8 | Milestone 7 | 18/02/22 |
| Day 9 | “ |  |
| Day 10 | “ |  |
| Day 11 | “ |  |
| Day 12 | “ | 24/02/22 |
