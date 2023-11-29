using CheckDomain;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var check = new Main();

var result = check.ViaEmail("ecode10@mauriciojunior.net");

Console.WriteLine("Result email: " + result.ToString());

var result2 = check.ViaName("www.mauriciojunior.net");

Console.WriteLine("Result name: " + result2.ToString());