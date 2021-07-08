using System;

// Functions can provide default values for their parameters
void PrintWithPrefix(string theStr, string prefix = ""){
    Console.WriteLine($"{prefix} {theStr}");
}

// Test the default parameters
PrintWithPrefix("Hello There!");
PrintWithPrefix("Hello There!", ">: ");

// Call with named params
PrintWithPrefix(prefix: "% ", theStr: "Hello There!");
