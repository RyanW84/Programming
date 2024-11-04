
//Doubles can have a decimal point 1, 23, 43

double averageAge;

averageAge = (42 + 21 + 62) / 3;        // This assumes integer result as whole numbers used . Net 6 will treat all as Doubles
//averageAge = (42.2 + 21 + 62) / 3;    // This will treat as doubles and give a result with a decimal

                                        /// Doubles are the most used type in maths
                                        /// Do not use doubles when it comes to Money - more precision required!

                                        // dividing integers truncates the result (cuts off the decimal result)

Console.WriteLine(averageAge);

//Math.                                 // Math library with many different options

averageAge = (2.0 / 3);                 // Without the 2.0 it gives 0 - with the decimal place it gives 0.66666
Console.WriteLine(averageAge);



