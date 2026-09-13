// данные студента для визитки
string studentName = "Цой Игорь Александрович";
string studentGroup = "ИСП-252";
int studentCourse = 2;
string studentSpecialty = "09.02.07";

// Константа: пороговое значение среднего балла для стипендии (по условию заменили на 4.5)
const double minGrate = 4.5;

// Переменные с оценками за 3 работы для подсчета среднего балла
double grade1 = 5;
double grade2 = 4;
double grade3 = 5;

// Арифметический расчёт: средний балл по трём оценкам
double averageGrade = (grade1 + grade2 + grade3) / 3;

// Логический расчёт: положена ли стипендия (сравниваем со значением константы)
bool isStipend = averageGrade >= minGrate;

// Учебных недель осталось в семестре
int weeksLeft = 16;

/* 
Вывод визитки через интерполяцию строк.
 Используем разделители и пустые строки для аккуратного форматирования.
 */
Console.WriteLine("ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine("==========================");
Console.WriteLine($"ФИО: {studentName}");
Console.WriteLine($"Группа: {studentGroup}");
Console.WriteLine($"Курс: {studentCourse}");
Console.WriteLine($"Специальность: {studentSpecialty}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {averageGrade:F2}");
Console.WriteLine($"Стипендия положена (>= {minGrate}): {isStipend}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {weeksLeft}");
Console.WriteLine("==========================");