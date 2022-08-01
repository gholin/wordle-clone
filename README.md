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

If you need to update `npm`, you can do so using `npm`! Cool right? After running the following command, after running relaunch your command line editor.

```bash
  $ npm install npm -g
```

---

## Install

```bash
  $ git clone https://gitlab.com/maximumsnow/wordle-react
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

### 1. Separate Data from Code

This project contains two folders. Wordle_API (empty) and wordle-UI (NodeJS Project).
The wordle-UI project contains a set of words within the code to be used for the word being guessed. This means that to add/remove/update the words being used a code file must be edited. This is considered bad practice. If we know data is going to be changed it should be located outside the code so it can be altered without touching code files. This exercise consists of multiple parts.

#### Exercise 1: Part 1

Find the words in the code and create a file in wordle_API containing those words.

#### Exercise 1: Part 2

Using C# create an API in the wordle_API folder that returns a random word from the file created in step 1. Remember to create unit tests for your code where possible.

#### Exercise 1: Part 3

Refactor the API created in Part 2 to accept a query string. If the query string key is "test" and value is **true** then do not return a random word. Instead return a specific word that can be used for testing.

#### Exercise 1: Part 4

Refactor the wordle-UI project to contact the API created in Part 2 and use the word provided by the API as the solution to the puzzle.

---

## Upload your solution to git

Upload your code to your favorite git repository (github, gitlab, bitbucket, etc) and send a link to Rich and Mike.

1. Create a new repo in your favorite git repository
2. Open a command prompt
3. Navigate to the Wordle-React directory
4. Run the following commands with your repo

``` sh
  $ git remote set-url origin your-repo-url
  $ git add .
  $ git commit -am "your commit message"
  $ git push
```