// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;


  class Temperature
{
    double temperature;
    public Temperature(double temperature)
    {
        this.temperature = temperature;
    }
    public  static int GreaterCount(List<Temperature> list, double min)
    {
        int count = 0;
        foreach (Temperature temp in list)
        {
            if(temp.temperature >= min)
            {
                Console.WriteLine(temp.temperature);
                count++;
            }
        }
        return count;
    }
    public static int GreaterCount(IEnumerable eble,double min)
    {
        int count = 0;
        foreach (Temperature temp in eble)
        {
            if (temp.temperature >= min)
            {
                Console.WriteLine(temp.temperature);
                count++;
            }
        }
        return count;
    }
    public static void Main()
    {
        Temperature temperature1 = new Temperature(26);
        Temperature temperature2 = new Temperature(35);
        Temperature temperature3 = new Temperature(20);
        Temperature temperature4 = new Temperature(25);
        Temperature temperature5 = new Temperature(27);
        Temperature temperature6 = new Temperature(22);
        List<Temperature> Temps = new List<Temperature>();
        Temps.Add(temperature1);
        Temps.Add(temperature2);
        Temps.Add(temperature3);
        Temps.Add(temperature4);
        Temps.Add(temperature5);
        Temps.Add(temperature6);
        Console.WriteLine("Enter the number Temperature min");
        double temperature = double.Parse(Console.ReadLine());
        Console.WriteLine("=======================");
        GreaterCount(Temps, temperature);


        double[] doubles = new double[10];
        Console.WriteLine("Enter the number Temperature min");
        double temperatureMin = double.Parse(Console.ReadLine());
        GreaterCount(doubles,temperatureMin);
    }
}



    

    

