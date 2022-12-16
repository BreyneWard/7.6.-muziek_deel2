namespace _7._6._muziek_deel2;
class Program
{
    static void Main(string[] args)
    {
        FirstVerse();
        SecondVersePart1();
        SecondVersePart2();
        FirstVerse();
        SecondVersePart1();
        SecondVersePart3();

    }

    // Methods
    static void PlayDo(int freq, int duration, string lyric)
    {
        Console.WriteLine(lyric);
        Console.Beep(freq*264, duration*1000);
    }

    static void PlayRe(int freq, int duration, string lyric)
    {
        Console.WriteLine(lyric);
        Console.Beep(freq * 297, duration * 1000);
    }
    static void PlayMi(int freq, int duration, string lyric)
    {
        Console.WriteLine(lyric);
        Console.Beep(freq * 330, duration * 1000);
    }
    static void PlayFa(int freq, int duration, string lyric)
    {
        Console.WriteLine(lyric);
        Console.Beep(freq * 352, duration * 1000);
    }
    static void PlaySol(int freq, int duration, string lyric)
    {
        Console.WriteLine(lyric);
        Console.Beep(freq * 396, duration * 1000);
    }
    static void PlayLa(int freq, int duration, string lyric)
    {
        Console.WriteLine(lyric);
        Console.Beep(freq * 440, duration * 1000);
    }
    static void PlaySi(int freq, int duration, string lyric)
    {
        Console.WriteLine(lyric);
        Console.Beep(freq * 495, duration * 1000);
    }

    static void FirstVerse()
        {
            for (int i = 0; i < 2; i++)
        {
            PlayMi(1, 1, "jin");
            PlayMi(1, 1, "gle");
            PlayMi(1, 2, "bells");
        }

        PlayMi(1, 1, "jin");
        PlaySol(1, 1, "gle");
        PlayDo(1, 1, "all");
        PlayRe(1, 1, "the");
        PlayMi(1, 4, "way");

        }
    
    static void SecondVersePart1()
    {
        PlayFa(1, 1, "Oh");
        PlayFa(1, 1, "what");
        PlayFa(1, 1, "fun");
        PlayFa(1, 1, "it");
        PlayFa(1, 1, "is");
        PlayMi(1, 1, "to");
        PlayMi(1, 1, "ride");
        PlayMi(1, 1, "in a");
        
    }

    static void SecondVersePart2()
    {
        PlayMi(1, 1, "one");
        PlayRe(1, 1,"horse");
        PlayRe(1, 1, "op-");
        PlayMi(1, 1, "en");
        PlayRe(1, 2,"sleigh");
        PlaySol(1, 2, "");
    }

    static void SecondVersePart3()
    {
        PlaySol(1, 1,"one");
        PlaySol(1, 1,"horse");
        PlayFa(1, 1,"op-");
        PlayRe(1, 1,"en");
        PlayDo(1, 4,"sleigh");
    }


}
