// using Internal;
// // 20/09/2022
// // Algoritma dan struktur data
// using System;
// class program
// {
//     static void Main()
//     {
//         Enemy a = new Enemy("a", 100);
//         Enemy b = new Enemy("b", 200);
//         Enemy c = new Enemy("c", 300);
//         Enemy d = new Enemy("d", 400);
//         Enemy e = new Enemy("e", 500);

//         Enemy[] enemyArray = {
//             a,
//             b,
//             c,
//             d,
//             e
//         };

//         Enemy[] newEnemyArray = new Enemy[enemyArray.Length + 1];
//         for (int i = 0; i < enemyArrar.length; i++)
//         {
//             newEnemyArray[i] = EnemyArray[i];
//         }
//         newEnemyArray[4] = e;
//         List<Enemy> enemyList = new List<Enemy>{
//             a,
//             b,
//             c,
//             d,
//             new Enemy("c", 600)
//         }; 

//         // Console.WriteLine(enemyList);
        


//         Dictionay<string,Enemy> enemyDict = new Dictionay<string, Enemy>
//         {
//             {"a", a},
//             {"b", b},
//             {"c", c},
//             {"d", d},
//             {"e", e},
//         };

//         enemyDict.Add("f", f);
//         Console.WriteLine(enemyDict["c"].Name);
//         enemyDict["e"] = k;
//         Console.WriteLine(enemyDict.ContainsValue(k));
//     }
// }