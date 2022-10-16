int GetUserNumber (string message) {
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int userNumber = GetUserNumber("Введите цифру соответствующую дню недели (от 1 до 7) = ");
int answer = 0;

if (userNumber < 1 || userNumber > 7 ) Console.WriteLine($"Число {userNumber} не соответствует дню недели.");
else {
    if (userNumber > 5 && userNumber < 8) Console.WriteLine($"Цифра {userNumber} соответствует выходному дню.");
    else Console.WriteLine($"Цифра {userNumber} НЕ соответствует выходному дню.");
}
