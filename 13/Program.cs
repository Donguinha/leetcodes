
string roman = "CDLXXVI";

RomanToInt(roman);

public int RomanToInt(string s)
{
    int roman = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == 'C')
            if (s[i + 1] == '')



    }
}

I             1
V             5
X             10
L             50
C             100
D             500
M             1000