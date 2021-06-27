# SolarSystemModel
The program divides the simulation into steps

At each step, the following algorithm is executed
1) Calculation of all forces for each body from the current position
using Newton's law of gravitation.
2) Calculation of acceleration for each body from the sum of forces acting on it using Newton's second law of motion a = F / m.
3) Calculate the change of velocity through acceleration for each body.
4) Calculating the new velocity by adding the change in velocity for each body.
5) Calculating the change in position through velocity for each body.
7. Calculate the new position by adding the change in position for each body.

This algorithm is repeated over and over again.
