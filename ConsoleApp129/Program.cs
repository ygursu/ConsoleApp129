﻿double sayi = 0, yuzde = 0, sonuc = 0;
Console.Write("Sayıyı giriniz:");
sayi = Convert.ToDouble(Console.ReadLine());
Console.Write("Yüzdeyi giriniz:");
yuzde = Convert.ToDouble(Console.ReadLine());
sonuc = (sayi * yuzde) / 100;
Console.WriteLine("Sonuc= {0}", sonuc.ToString());
Console.ReadKey();