using System;
using System.Runtime.Intrinsics.Arm;
using HomeWork;

Task1 case1 = new("Hello  ");
Task1 case2 = new("Lorem ipsum bla bla");
Task1 case3 = new(" ffdfdf d fdd fd dfdf dfdf ");

Console.WriteLine("=================LastIndexOf ~ START================");

//for char overload (SUCCESS)
Console.WriteLine(case1.LastIndexOf("l") == case1.value.LastIndexOf('l'));

//for char overload (FAIL)
Console.WriteLine(case1.LastIndexOf('z') == case1.value.LastIndexOf('z'));

//for string overload (SUCCESS)
Console.WriteLine(case2.LastIndexOf(" ipsum") == case2.value.LastIndexOf(" ipsum"));

//for string overload (FAIL)
Console.WriteLine(case2.LastIndexOf("xipsum") == case2.value.LastIndexOf("xipsum"));

//hard test
Console.WriteLine(case3.LastIndexOf(" d fdd fd ") == case3.LastIndexOf(" d fdd fd "));

Console.WriteLine("-----------------LastIndexOf ~ END------------------\n\n\n");

//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

Console.WriteLine("=================Contains ~ START================");

//for char overload (SUCCESS)
Console.WriteLine(case1.Contains('e') == case1.value.Contains('e'));
//for char overlad (FAIL)
Console.WriteLine(case1.Contains('z') == case1.value.Contains('z'));

//for string overload (SUCCESS)
Console.WriteLine(case1.Contains("ell") == case1.value.Contains("ell"));
//for stirng overload (FAIL)
Console.WriteLine(case2.Contains("abem") == case2.value.Contains("abem"));


Console.WriteLine("-----------------Contains ~ END------------------\n\n\n");

//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

Console.WriteLine("=================Replace ~ START================");

//case for char (SUCCESS)
Console.WriteLine(case1.Replace('l', 'X') == case1.Replace('l', 'X'));
//case for char (FAIL)
Console.WriteLine(case1.Replace('z', 'X') == case1.Replace('z', 'X'));

Console.WriteLine("-----------------Replace ~ END------------------\n\n\n");

//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+


Console.WriteLine("=================Substring ~ START================");

//case (SUCCESS)
Console.WriteLine(case1.Substring(3) == case1.value.Substring(3));
Console.WriteLine(case2.Substring(3) == case2.value.Substring(3));

//case (FAIl)
//Console.WriteLine(case1.Substring(131) == case1.value.Substring(131));
//Console.WriteLine(case1.Substring(-1) == case1.value.Substring(-1));




Console.WriteLine("-----------------Substring ~ END------------------\n\n\n");

//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+


Console.WriteLine("=================Trim ~ START================");

Console.WriteLine(case3.Trim() == case3.value.Trim());
Console.WriteLine(case2.Trim() == case2.value.Trim());
Console.WriteLine(case1.Trim() == case1.value.Trim());

Console.WriteLine("-----------------Trim ~ END------------------\n\n\n");

//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+


Worker wk1 = new() {
    Name = "Elsevar",
    Experience = 12,
};
Worker wk2 = new() {
    Name = "Murad",
    Experience = 11,
};
Worker wk3 = new()
{
    Name = "Alex",
    Experience = 13,
};


Department dp = new();

dp.AddWorker(wk1).AddWorker(wk2).AddWorker(wk3);
dp.ShowAllWorkers();
Worker sr1 = dp.SearchWorker("Alex");
Worker sr2 = dp.SearchWorker("Alexxxx");

Console.WriteLine(sr1.Name);
Console.WriteLine(sr2?.Name);


