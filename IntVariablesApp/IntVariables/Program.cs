
//Yes 22, 1854 , 33044 - whole numbers
//No 1.2, -6.7, .3.697685

using System.Runtime.CompilerServices;

int age = 0;

age = 43;

int ageInTenYears = age  +10;

/* 
How big can an integer be 2Billion +/-
signed Int32   signed means is it positive or negative
unsigned ints which can hold 4 Billion
unsigned holds 4 billion as it doesnt use a bit to indicate positive or negative
to go larger there are 64 bit Int64 
don't prematurely optimise to high numbers right balance (dont try to be Amazon)
bit 0 or 1
byte 8 bits = 00000000 = 256  (16 bit is not twice as large as 8 bit, 9 bits is. so 64 bit is massively more than 32 bit)
1 (2) possibilities 
11 (4)  can do twice as many with one more bit
000 (8) numbers total
*/

//Console.WriteLine(age.ToString());
Console.WriteLine(age);
Console.WriteLine(ageInTenYears); //this does not modify the original variable
age = age + 10; // this does modify the original value

//have to be really careful with integers and division
//example below 43 /2 should be 21.5 - but it will give the answer as 21 making the original age 42 due to integer and no decimals
Console.WriteLine(age / 2); //due to being pure integers it only provides an integer result not decimals. 




