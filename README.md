[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/izsomDyT)
# IT 2030 - Lab 10 - Building the Tic Tac Toe App

## Student Information

**Name:** Danielle Hunter

**Email:** S00828490@acad.tri-c.edu

Place your name and email address above. Students who do not enter their name and email address above will receive NO CREDIT for the lab.

## Introduction

For this project, you will build a single-page app that uses model binding to pass data between controllers and views.

![image](https://github.com/tric2030/it2030_v1_lab10/assets/24532026/ad2ed300-6833-4100-b9d7-099cf82451e5)

![image](https://github.com/tric2030/it2030_v1_lab10/assets/24532026/6352fdc1-38b8-4e28-b727-32fb88993daa)

![image](https://github.com/tric2030/it2030_v1_lab10/assets/24532026/ae6dcbae-a2cd-42ea-8c0c-64d1d696e500)

## Instructions

To receive credit for this lab, you must:

* Accept the GitHub Classroom assignment for this lab
* Write code that meets the specifications (below)
* Commit all code by the due date to your GitHub Classroom repository by the due date

## Specifications

* When the app starts, it should display nine ```<button>``` elements, styled as above to appear as a 3x3 grid. Above the grid, an ```<h2>``` element should say that it’s X’s turn.
* When the user clicks a button, the page should post to the server, where the X or O for that button is saved. 
* When the page reloads, the clicked ```<button>``` element should be marked X or O and should be disabled. In addition, clicking the browser’s Refresh button should redisplay the page, not post the previous click again.
* After each turn, the ```<h2>``` element above the grid should say whose turn it is.
* When there are three Xs or three Os in a line (vertically, horizontally, or diagonally), the game is over and the player with the three marks in a line wins. When this happens, the app should say who won and replace the ```<h2>``` element with a New Game link. 
* When there are no more blank cells but there’s no winner, then the game ends in a tie. When this happens, the app should notify the user and replace the ```<h2>``` element with a New Game link. 
* When the user clicks the New Game link, a new grid of ```<button>``` elements should display. Above the grid, an ```<h2>``` element should say that it’s X’s turn.

## Rubric

* See the assignment in Blackboard for the grading rubric

## References

This lab sourced from Murach’s ASP.NET Core MVC (2nd Edition), 2022, by Mary Delamater and Joel Murach
