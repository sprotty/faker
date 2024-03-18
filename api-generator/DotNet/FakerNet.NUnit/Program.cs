// See https://aka.ms/new-console-template for more information
using FakerNet;
using FakerNet.NUnit;
using System.Diagnostics;
using System.Globalization;

var faker = new Faker();
for (int len = 1; len < 50; len++)
    for (int i = 0; i < 50; i++)
        Debug.WriteLine(faker.Internet.Username(len, len));
//Debug.WriteLine(faker.Internet.Username(new IntegerRange(10, 50)));
//(new Test_Address()).Test_CitySuffix_Execute();
//Console.WriteLine("Hello, World!");
//var fakerDefault = new FakerNet.Faker();
//var fakerEnGb = new FakerNet.Faker(new CultureInfo("en-GB"));

//Console.WriteLine(fakerEnGb.Address.City());
////Console.WriteLine(faker.Name.Name());
//Console.WriteLine(fakerEnGb.Address.CountryByCode("US"));
//Console.WriteLine(fakerEnGb.Address.CountryNameToCode("United States"));

//Console.WriteLine(fakerEnGb.Address.Postcode());
//Console.WriteLine(fakerEnGb.Address.Latitude());
//Console.WriteLine(fakerDefault.Address.Postcode());
//Console.WriteLine(fakerDefault.Artist.Name());