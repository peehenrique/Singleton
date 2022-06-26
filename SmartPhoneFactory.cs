namespace Singleton;

public class SmartPhoneFactory
{
    public static SmartPhoneFactory Factory;
    protected int TotalSmartsApple;
    protected int TotalSmartsSamsung;
    protected int TotalSmartsXiaomi;
    
    protected SmartPhoneFactory()
    {
        
    }

    public string MakeSmartPhoneApple()
    {
        return $"SmartPhone Apple # {TotalSmartsApple++} criado.";
    }
    
    public string MakeSmartPhoneSamsung()
    {
        return $"SmartPhone Samsung # {TotalSmartsSamsung++} criado.";
    }
    
    public string MakeSmartPhoneXiaomi()
    {
        return $"SmartPhone Xiaomi # {TotalSmartsXiaomi++} criado.";
    }

    public string GenerateReport()
    {
        return $"Total SmartPhone Apple: {TotalSmartsApple} \n Total SmartPhone Samsung: {TotalSmartsSamsung} \n Total SmartPhone Xiaomi: {TotalSmartsXiaomi}";
    }

    public static SmartPhoneFactory GetFactory()
    {
        if (Factory is null)
        {
            Factory = new SmartPhoneFactory();
        }

        return Factory;
    }
}