// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1061;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");


// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
// }
//  Console.WriteLine($"Сумма баллов за сданные работы: {sum}");



// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++) {
//     for (int j = i + 1; j < groupIds.Length; j++) {
//         if (groupIds[i] == groupIds[j]) {
//             hasDuplicates = true;
//             Console.WriteLine($"Найдены совпадающие номера: {groupIds[i]} и {groupIds[j]}");
//             break;
//         }
//     }
//     if (hasDuplicates) {
//         break;
//     }
// }

// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");


int days = 5;
int lessonsPerDay = 6;
bool found = false;
for (int day = 1; day <= days && !found; day++)
{
    for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
    {
        bool isFree = (day == 3 && lesson == 4);

        if (isFree)
        {
            Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
            found = true;
            break;
        }
    }
}

if (!found)
{
    Console.WriteLine("Свободных слотов нет");
}