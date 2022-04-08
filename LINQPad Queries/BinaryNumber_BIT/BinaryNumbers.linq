<Query Kind="Program" />

void Main()
{
		
	Console.WriteLine($"1234 to  binary => {string.Join(' ', ConvertIntToBinary(1234))}");
	
	Console.WriteLine($"10011010010 to integer => {ConvertBinaryToInt(string.Join("", ConvertIntToBinary(1234)))}");
}

public static int ConvertBinaryToInt(string binary)
{
	int sum = 0;
	int countIn = 0;
	for(int i = binary.Length - 1; i >= 0; i--)
	{
		countIn = (countIn == 0) ? 1 : countIn + countIn;		
		if	(char.GetNumericValue(binary[i]) == 1)
		{
			sum = sum + countIn;
		}		
	}
	return sum;
}


public static int[] ConvertIntToBinary(int num)
{
	Stack<int> s = new Stack<int>();	
	while(num != 0)
	{
		s.Push(num % 2);
		num = num / 2;
	}
	return s.ToArray();
}
