int start_number = 106732567, end_number = 152673836;
int root = 0;
bool isSimple = true;
for (int i = start_number; i <= end_number; i++)
{
    root = (int)Math.Sqrt(Math.Sqrt(i));
    isSimple = true;
    if (Math.Pow(root, 4) != i) continue;
    for (int j = 2; j < root/2; j++)
    {
        if(root % j == 0)
        {
            isSimple = false;
            break;
        }
    }
    if(isSimple)
    {
        Console.WriteLine(i + " " + Math.Pow(root, 3));
    }
}