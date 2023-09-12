
/*
   ^ indicates starts with 
	. indicates any one letter or character
	$  - indicates string ends with 
	[] -Range
    () - Group
    +-one or more characters in a row
	 ? -  Optional preceding character match
	\ - escape character
	\n - new line

    \d - Digit
    \D - Non - digit
    \s - White space
    \S non- White space
	\w - alphanumeric\ underscore character (word chars) 
	\W - non word characters
	{x, y} -Repeat low(x) to high(y) (No "y" means at least x, No ", y" means that many
	{x|y} -alternative to x or y
	[^x] -anything but x(where x is whatever character you want]
*/
	
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Diagnostics;

string toSearch = File.ReadAllText("test.txt");
string pattern = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";

MatchCollection matches = Regex.Matches(toSearch, pattern); //find all matches! and what the match is

foreach (Match match in matches)
{
	Console.WriteLine(match.Value);
}
//string pattern = "Tim";
//string pattern2 = "[Tt]im";
//string patternRegex = @"(\s|^)Tim(\s|$)";//space(\s) or first (^)

//string toSearch = "Tim Corey";

//Console.WriteLine("Tim corey: "+Regex.IsMatch("Tim corey", pattern));
//Console.WriteLine("Timothy corey: " + Regex.IsMatch("Timothy corey", pattern));
////returns false and won't find 'tim' unless it's 'Tim'
////Ignore case can be used but not preferred
//Console.WriteLine("Sometimes: " + Regex.IsMatch("Sometimes", pattern, RegexOptions.IgnoreCase));
//Console.WriteLine("tim corey: " + Regex.IsMatch("tim corey", pattern));//case senstive so will return false

////using range in the pattern
//Console.WriteLine();
//Console.WriteLine("Tim corey: " + Regex.IsMatch("Tim corey", pattern2));
//Console.WriteLine("Timothy corey: " + Regex.IsMatch("Timothy corey", pattern2));
//Console.WriteLine("Sometimes: " + Regex.IsMatch("Sometimes", pattern2));//returns true and will find 'tim'
//Console.WriteLine("tim corey: " + Regex.IsMatch("tim corey", pattern2));//will return true

////using regex in the pattern
//Console.WriteLine();
//Console.WriteLine("Tim corey: " + Regex.IsMatch("Tim corey", patternRegex));
//Console.WriteLine("Timothy corey: " + Regex.IsMatch("Timothy corey", patternRegex));
//Console.WriteLine("Always Tim: " + Regex.IsMatch("Always Tim", patternRegex));//returns true and will find 'tim'
//Console.WriteLine("I Am Tim corey: " + Regex.IsMatch("I Am Tim corey", patternRegex));//will return true

//Stopwatch stopwatch = new Stopwatch();
//Regex test = new Regex(patternRegex);

//stopwatch.Start();

//for(int i = 0; i < 100000; i++)
//{
//	//Regex.IsMatch("I am Tim correy", patternRegex);
//	test.IsMatch("I am Tim correy");
//}

//stopwatch.Stop();

//Console.WriteLine($"Time Elapshed in ms: {stopwatch.ElapsedMilliseconds}");