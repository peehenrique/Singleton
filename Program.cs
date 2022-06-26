using Singleton;

var factory = SmartPhoneFactory.GetFactory();

Console.WriteLine(factory.MakeSmartPhoneApple());
Console.WriteLine(factory.MakeSmartPhoneApple());
Console.WriteLine(factory.MakeSmartPhoneSamsung());
Console.WriteLine(factory.MakeSmartPhoneSamsung());
Console.WriteLine(factory.MakeSmartPhoneXiaomi());
Console.WriteLine(factory.MakeSmartPhoneXiaomi());
Console.WriteLine(factory.MakeSmartPhoneXiaomi());

Console.WriteLine(factory.GenerateReport());