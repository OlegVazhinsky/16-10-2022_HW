int GetUserNumber (string message) {
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int userNumber = GetUserNumber("Введите трех или более значное число = ");
int answer = 0;

if (userNumber < 100 && userNumber > -100 ) Console.WriteLine($"Число {userNumber} не трех или более значное.");
else {
    if (userNumber > 0) answer = (userNumber % 10);
    else answer =  (-userNumber % 10);
    Console.WriteLine($"Третья цифра числа {userNumber} = {answer}");
}
