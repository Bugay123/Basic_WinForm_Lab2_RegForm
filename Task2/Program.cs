using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    internal static class Program
    {
        /*Створити Windows-проєкт форми Анкета студента. В заголовку
форми вказати назву Лаб. 2, розмістити написи (Label), текстові
поля (TexBox) і кнопки (Button) OK i Close. Властивостям кнопок
призначити можливість реагування на клавіатуру. Вказати при
реєстрації такі дані: Ім’я, Прізвище, Рік народження, Група, Курс.
Ввести дані в текстові поля. При натисненні на кнопку OK
прочитати дані з перевіркою допустимості, і вивести їх в додаткове
текстове багаторядкове поле.*/
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
