using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._10
{
    internal class Staf

    {
        internal static Work ReturnPerson(string name)
        {
            switch (name)
            {
                case "Борис":
                    return Boris;
                case "Рашид":
                    return Rashid;
                case "Ильхам":
                    return Ilham;
                case "Оркадий":
                    return Orkadiy;
                case "Володя":
                    return Volodya;
                case "Ильшат":
                    return Ilshat;
                case "Иваныч":
                    return Ivanich;
                case "Илья":
                    return Ilya;
                case "Витя":
                    return Vitya;
                case "Женя":
                    return Zhenya;
                case "Сергей":
                    return Sergey;
                case "Ляйсан":
                    return Laysan;
                case "Марат":
                    return Marat;
                case "Дина":
                    return Dina;
                case "Ильдар":
                    return Ildar;
                case "Антон":
                    return Anton;
            }
            return new Work("None");
        }

        internal static Work Boris = new Work("Борис", 1, "superiors");
        internal static Work Rashid = new Work("Рашид", 2, "superiors");
        internal static Work Ilham = new Work("Ильхам", 2, "superiors");
        internal static Work Orkadiy = new Work("Аркадий", 3, "superiors");
        internal static Work Volodya = new Work("Володя", 3, "superiors");
        internal static Work Ilshat = new Work("Ильшат", 4, "system");
        internal static Work Ivanich = new Work("Иваныч", 5, "system");
        internal static Work Ilya = new Work("Илья", 6, "system");
        internal static Work Vitya = new Work("Витя", 6, "system");
        internal static Work Zhenya = new Work("Женя", 6, "system");
        internal static Work Sergey = new Work("Сергей", 5, "development");
        internal static Work Laysan = new Work("Ляйсан", 5, "development");
        internal static Work Marat = new Work("Марат", 6, "development");
        internal static Work Dina = new Work("Дина", 6, "development");
        internal static Work Ildar = new Work("Ильдар", 6, "development");
        internal static Work Anton = new Work("Антон", 6, "development");
    }
}
