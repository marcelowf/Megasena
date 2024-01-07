# Megasena Simulator with Statistical Analysis

This C# project is a simple simulator for the Megasena lottery game with basic statistical analysis.

## Overview

The `Processing` class in this project allows users to simulate playing Megasena by generating random lottery numbers, allowing the user to input their own numbers, and then comparing the results.

## Usage

To use the simulator, follow these steps:

1. Run the program.
2. Enter the size of your bet (number of numbers to choose).
3. Enter your bet numbers one by one when prompted.
4. The simulator will generate random lottery numbers, compare them with your bet, and display the results.

## Code Structure

- `Processing` class: Contains methods for simulating the Megasena game.
  - `MegasenaProcessing()`: The main method to run the simulation.
  - `SortearValores()`: Generates random lottery numbers.
  - `ApostarValores()`: Takes user input for their bet.
  - `CompararResultado()`: Compares bet numbers with the generated numbers.
  - `PrintLista()`: Helper method to print arrays.

## How to Run

Compile and run the program using:

`dotnet run`
