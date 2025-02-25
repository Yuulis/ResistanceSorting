using System.Collections.Generic;
using UnityEngine;

public class Resistance : MonoBehaviour
{
    public enum Color
    {
        Black,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Gray,
        White,
        Gold,
        Silver,
        None
    }

    public int id;
    public List<Band> bands = new List<Band>();
    public List<Color> bandsColor = new List<Color>();
    public long resistance;
    public double error;
    public int temperatureCoefficient;

    public void SetResistanceData(int id, Color band1, Color band2, Color band3, Color band4, Color band5, Color band6)
    {
        this.id = id;
        bandsColor.Add(band1);
        bandsColor.Add(band2);
        bandsColor.Add(band3);
        bandsColor.Add(band4);
        bandsColor.Add(band5);
        bandsColor.Add(band6);

        SetColor();
        CalculateValues();
    }

    private void SetColor()
    {
        for (int i = 0; i < bandsColor.Count; i++)
        {
            bands[i].SetMaterial((int)bandsColor[i]);
        }
    }

    private void CalculateValues()
    {
        int bandsCnt = 0;
        for (int i = 0; i < bandsColor.Count; i++)
        {
            if (bandsColor[i] != Color.None)
            {
                bandsCnt++;
            }
        }

        switch (bandsCnt)
        {
            case 3:
                resistance = (int)bandsColor[0] * 10 + (int)bandsColor[1];
                resistance *= (int)System.Math.Pow(10, (int)bandsColor[2]);
                error = 0.2;
                temperatureCoefficient = 0;

                OutputData();

                break;

            case 4:
                resistance = (int)bandsColor[0] * 10 + (int)bandsColor[1];
                resistance *= (int)System.Math.Pow(10, (int)bandsColor[2]);
                error = CalculateErrorValue(bandsColor[3]);
                temperatureCoefficient = 0;

                OutputData();

                break;

            case 5:
                resistance = (int)bandsColor[0] * 100 + (int)bandsColor[1] * 10 + (int)bandsColor[2];
                resistance *= (int)System.Math.Pow(10, (int)bandsColor[3]);
                error = CalculateErrorValue(bandsColor[4]);
                temperatureCoefficient = 0;

                OutputData();

                break;

            case 6:
                resistance = (int)bandsColor[0] * 100 + (int)bandsColor[1] * 10 + (int)bandsColor[2];
                resistance *= (int)System.Math.Pow(10, (int)bandsColor[3]);
                error = CalculateErrorValue(bandsColor[4]);
                temperatureCoefficient = CalculateTemperatureCoefficient(bandsColor[5]);

                OutputData();

                break;

            default:
                Debug.LogError("[Resistance Class] Undefined number of bands has detected.");

                break;
        }
    }

    private double CalculateErrorValue(Color band)
    {
        switch (band)
        {
            case Color.Black:
                return 0;
            case Color.Brown:
                return 0.01;
            case Color.Red:
                return 0.02;
            case Color.Orange:
                return 0.0005;
            case Color.Yellow:
                return 0.0002;
            case Color.Green:
                return 0.005;
            case Color.Blue:
                return 0.0025;
            case Color.Violet:
                return 0.001;
            case Color.Gray:
                return 0.0001;
            case Color.White:
                return 0;
            case Color.Gold:
                return 0.05;
            case Color.Silver:
                return 0.1;
            case Color.None:
                return 0.2;
            default:
                Debug.LogError("[Resistance Class] Undefined color band has detected in 'ErrorValue.'");
                return 0;
        }
    }

    private int CalculateTemperatureCoefficient(Color band)
    {
        switch (band)
        {
            case Color.Black:
                return 250;
            case Color.Brown:
                return 100;
            case Color.Red:
                return 50;
            case Color.Orange:
                return 15;
            case Color.Yellow:
                return 25;
            case Color.Green:
                return 20;
            case Color.Blue:
                return 10;
            case Color.Violet:
                return 5;
            case Color.Gray:
                return 1;
            case Color.White:
                return 0;
            case Color.Gold:
                return 0;
            case Color.Silver:
                return 0;
            case Color.None:
                return 0;
            default:
                Debug.LogError("[Resistance Class] Undefined color band has detected in 'TemperatureEfficient.'");
                return 0;
        }
    }

    public void OutputData()
    {
        Debug.Log($"Resistance-{id} : \n Resistance = {resistance} Ω ± {error * 100} % \n Temperature Coefficient = {temperatureCoefficient} ppm/K");
    }
}