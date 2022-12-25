

using ServiceLayer.Services;
using ServiceLayer.Services.Interface;

ICalculateService service = new CalculateService();
int result = service.GetSumNumbersArray(new int[] { 1, 2, 4, 21, 9, });
Console.WriteLine(result);

int sum = service.GetSumMultiplyAray(new int[] { 1, 2, 4,  5 });

Console.WriteLine(sum);