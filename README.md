# Wordle-React

A Wordle clone made with React.

---

## Requirements

You will need a modern web browser, NodeJS, and NPM to run this project.
To complete the exercises it is recommended that you have an IDE for C# and JavaScript.

### Node

- #### Node installation on Windows

   Go to the [official Node.js website](https://nodejs.org/) and download the installer.
Also, be sure to have `git` available in your PATH, `npm` might need it (You can find git [here](https://git-scm.com/)).

- #### Node installation on Ubuntu

  You can install nodejs and npm easily with apt install, just run the following commands.

```bash
  $ sudo apt install nodejs
  $ sudo apt install npm
```

- #### Other Operating Systems
  
  You can find more information about the installation on the [official Node.js website](https://nodejs.org/) and the [official NPM website](https://npmjs.org/).

If the installation was successful, you should be able to run the following command.

```bash
  $ node --version
  v18.1.0

  $ npm --version
  8.8.0
```

If you need to update `npm`, you can do so using `npm`! Cool right? After running the following command, relaunch your command line editor.

```bash
  $ npm install npm -g
```

---

## Install

```bash
  $ git clone https://github.com/maximumsnow/wordle-clone
  $ cd wordle-react/wordle-UI
  $ npm install
```

## Running the project

```bash
  $ cd wordle-react/wordle-UI
  $ npm start
```

## How to Play

Guess the **WORDLE** in six tries.

Each guess must consist of 5 letters. Use the keyboard to add letters and hit the enter button to submit.

After each guess, the color of the tiles will change to show how close your guess was to the word.

If the tile is green the letter is in the correct spot.

If the tile is blue the letter is correct but in the wrong spot.

If the tile is grey the letter is not in the wordle.

---

## Exercises

### 1. Create a test plan outline

To complete this exercise create a bullted list of test descriptions for tests you would run if you were testing this application.

### 2. Write a manual test

Write a manaual test for losing a game. Start at navigating to the page and end at the "Sorry, you lose!" dialog. Include any data you feel is required for a good test case.

### 3. Automate the test from step 2

Using a test automation framework of your choice automate the manual test created in step 2.

### 4. Create an automation test for winning the game

Using a query string you can specify the word that will be used in the game. The query string is test and if its value is a 5 letter string it should be set as the word for the game. For example if I wanted to specify the word for the game to be "drink" I would add **/?test=drink** to the end of application URL (e.g. [http://localhost:3000/?test=drink](http://localhost:3000/?test=drink)).
