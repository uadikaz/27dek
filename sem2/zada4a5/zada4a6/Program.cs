﻿// zada4a 6
Console.Write("Введи трехзначное число число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра в числе -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры в числе нет");
}