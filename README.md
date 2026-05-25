# Package Express Shipping Quote Console App

This repository contains a C# console application that calculates a shipping quote for a package based on its weight and dimensions.

## What the program does

The application:
- Displays the required welcome message.
- Prompts the user for package weight, width, height, and length.
- Rejects packages that weigh more than 50.
- Rejects packages whose total dimensions are greater than 50.
- Calculates the shipping quote using this formula:

`(width * height * length * weight) / 100`

- Displays the final quote as a dollar amount with two decimal places.
- Ends with a thank-you message.

## Example output

```text
Welcome to Package Express. Please follow the instructions below.
Please enter the package weight:
40
Please enter the package width:
10
Please enter the package height:
12
Please enter the package length:
11
Your estimated total for shipping this package is: $528.00
Thank you!
```

## Files

- `Program.cs` - the fully commented C# source code for the console application.

## Output check

I checked the current `Program.cs` and the program output matches the assignment text exactly for:
- the welcome message
- the input prompts
- the overweight error message
- the oversized package error message
- the final quote format shown in the example
- the `Thank you!` closing line
