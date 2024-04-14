//massivlar
int[] myArray  = {15, 60, 10, 23, 20};

int minVal = myArray[0];
int maxVal = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < minVal)
    {
        minVal = myArray[i];
    }
    if (myArray[i] > maxVal)
    {
        maxVal = myArray[i];
    }
}

Console.WriteLine($"Eng kichik qiymati: {minVal}\nEng aktta qiymati: {maxVal}\nIkki qiymatni ko'paytmasi: {minVal * maxVal}");