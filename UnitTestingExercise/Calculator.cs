﻿using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // Step 1: Add a reference to your UnitTestingExercise project:

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project



        // Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
        //For Example:
        public int Add(int numOne, int numTwo, int numThree)
        {
            return numOne + numTwo + numThree;
        }


        // Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 


        // Step 4: 
        // Create a Subtract method that accepts 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        // Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method


        // Step 6: 
        // Create a Multiply method that passes 2 integers

        public int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        // Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers

        public int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        // Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
