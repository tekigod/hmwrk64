﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны двa неотрицательных числа m и n
// m = 3, n = 2 -> A(m,n) = 29

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");

int Akkermanfunction = Ack(m, n);

Console.Write($"Функция Аккермана = {Akkermanfunction} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}