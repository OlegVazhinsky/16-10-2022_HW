int GetUserNumber (string message) {
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int userNumber = GetUserNumber("Введите трехзначное число = ");
int answer = 0;

if ((userNumber < 100 && userNumber > -99) || userNumber > 999 || userNumber < -999) Console.WriteLine($"Число {userNumber} не трехзначное.");
else {
    if (userNumber > 0) answer = (userNumber % 100) / 10;
    else answer =  (-userNumber % 100) / 10;
    Console.WriteLine($"Вторая цифра числа {userNumber} = {answer}");
}
