# CostVisualiser

## Introduction

Welcome to the CostVisualiser program - one of my first self-made projects.

The creation of this project stems from the way that I handle and view my personal finances. For many years, I have always depicted the cost of a large purchase in terms of the number of hours of work it would take me to fully afford that item. For instance, if a new pair of shoes that cost £2,000 caught my eye, and my hourly rate at work was £12/hour, I would view the cost as approximately 167 hours of work.

This perspective never fails to make me think twice about the importance of a purchase - £2,000 is fairly easy to fork out if you have the money (or perhaps more recklessly, a credit card), but realising you would need to work 167 hours to get that money back usually causes the wallet to close again.

As such, I decided it would be appropriate to write software that does all the calculations for me to save time.

## Explanation of functionality

The software first asks for which currency you wish to use - this has no overall impact on the calculation itself (yet), but I decided to include this now purely for design purposes. The software subsequently prompts you to enter your hourly rate and the cost of the item, and calculates the number of hours and minutes you'd need to work to earn the cost of the item.

The calculation that is performed is the cost you specified divided by the hourly rate. This gives us the number of hours required. However, in a real-use scenario, the result is unlikely to be an integer that can be expressed in a user-friendly manner. As such, we need to show the number of full hours required, and also express the remainder in terms of minutes. To do this, we multiply the hours by 60 to get the number of *minutes* required, and then use the modulus operator (%) to find the remainder.

Later on, I decided to implement colour into the final output.

|Colour|Meaning|
|---|---|
|dark green| 25 hours or less required|
|green| 26-50 hours required|
|yellow| 51-75 hours required|
|red| 76-100 hours required|
|dark red| 101 or more hours required|
