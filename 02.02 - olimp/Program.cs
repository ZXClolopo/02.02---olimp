string path = "C:\\Users\\Lolopo\\Desktop\\Кубик Рубика\\input_s1_20.txt";
string path1 = "C:\\Users\\Lolopo\\Desktop\\Кубик Рубика\\output_s1_20.txt";

string[] list = File.ReadAllLines(path);

string[] one = list[0].Split(' ');

int n = Convert.ToInt32(one[0]);
int m = Convert.ToInt32(one[1]);

string[] two = list[1].Split(' ');

int x = Convert.ToInt32(two[0]);
int y = Convert.ToInt32(two[1]);
int z = Convert.ToInt32(two[2]);
Console.WriteLine(x + " " + y + " " + z + "\n");
for (int i = 2; i < m + 2; i++)
{
    string[] any = list[i].Split(' ');

    string A = any[0];
    int K = Convert.ToInt32(any[1]);
    int S = Convert.ToInt32(any[2]);  
    int g = 0;

    if (A == "Z" && K == z)
    {
        z = K;
        if (S == 1)
        {
            g = x;
            x = y;
            y = n + 1 - g;
        }
        if (S == -1)
        {
            g = y;
            y = x;
            x = n + 1 - g;
        }
    }
    if (A == "X" && K == x)
    {
        x = K;
        if (S == 1)
        {
            g = y;
            y = z;
            z = n + 1 - g;
        }
        if (S == -1)
        {
            g = z;
            z = y;
            y = n + 1 - g;
        }
    }
    if (A == "Y" && K == y)
    {
        y = K;
        if (S == 1)
        {
            g = x;
            x = z;
            z = n + 1 - g;
        }
        if (S == -1)
        {
            g = z;
            z = x;
            x = n + 1 - g;
        }
    }
}
Console.WriteLine(x + " " + y + " " + z + "\n");
string[] list1 = File.ReadAllLines(path1);
string[] one1 = list1[0].Split(' ');
Console.WriteLine(String.Join(" ", one1));