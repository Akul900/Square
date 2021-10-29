using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    public enum MeasureType { m2, га, а, д };

    public class SquareLogic
    {
        private double value;
        private MeasureType type;

        public SquareLogic(double value, MeasureType type)
        //метод, который будет выводить нам значение в читаемом виде
        {
            this.value = value;
            this.type = type;
        }
     
        public string Verbose()   // выводит результат
        {
            return String.Format("{0} {1}", this.value, "");
        }
        public static SquareLogic operator +(SquareLogic instance, double number)
        {
            // рассчитываем новое значение
            var newValue = instance.value + number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var square = new SquareLogic(newValue, instance.type);
            // возвращаем результат
            return square;
        }

        // чтобы можно было добавлять число также слева
        public static SquareLogic operator +(double number, SquareLogic instance)
        {
            // вызываем с правильным порядком аргументов, то есть сначала площадь потом число
            // для такого порядка мы определили оператор выше
            return instance + number;
        }
        public static SquareLogic operator *(SquareLogic instance, double number)
        {
            return new SquareLogic(instance.value * number, instance.type); ;
        }

        public static SquareLogic operator *(double number, SquareLogic instance)
        {
            return instance * number;
        }

        // вычитание
        public static SquareLogic operator -(SquareLogic instance, double number)
        {
            return new SquareLogic(instance.value - number, instance.type); ;
        }

        public static SquareLogic operator -(double number, SquareLogic instance)
        {
            return instance - number;
        }

        public SquareLogic To(MeasureType newType)
        {
            // по умолчанию новое значение совпадает со старым
            var newValue = this.value;
            // если текущий тип -- это метр2
            if (this.type == MeasureType.m2)
            {
                // а теперь рассматриваем все другие ситуации
                switch (newType)
                {
                    // если конвертим в метр2, то значение не меняем
                    case MeasureType.m2:
                        newValue = this.value;
                        break;
                    // если в га.
                    case MeasureType.га:
                        newValue = this.value / 10000;
                        break;
                    // если в  а.
                    case MeasureType.а:
                        newValue = this.value / 100;
                        break;
                    // если в десятину
                    case MeasureType.д:
                        newValue = this.value / 10925;
                        break;
                }
            }
            else if (newType == MeasureType.m2) // если новый тип: метр2
            {
                switch (this.type) // а тут уже старый тип проверяем
                {
                    case MeasureType.m2:
                        newValue = this.value;
                        break;
                    case MeasureType.га:
                        newValue = this.value * 10000; 
                        break;
                    case MeasureType.а:
                        newValue = this.value * 100; 
                        break;
                    case MeasureType.д:
                        newValue = this.value * 10925; 
                        break;
                }
            }
            else // то есть не в метр2 и не из метр2
            {
                newValue = this.To(MeasureType.m2).To(newType).value;
            }
            return new SquareLogic(newValue, newType);
        }
        public static SquareLogic operator +(SquareLogic instance1, SquareLogic instance2)
        {
            // то есть к текущей площади добавляем число 
            // полученное преобразованием значения второй площади в тип первой площади
            // так как у нас определен operator+(SquareLogic instance, double number)
            // то это сработает как ожидается
            return instance1 + instance2.To(instance1.type).value;
        }

        // вычитание двух площадей
        public static SquareLogic operator -(SquareLogic instance1, SquareLogic instance2)
        {
            return instance1 - instance2.To(instance1.type).value;
        }

        public static SquareLogic operator *(SquareLogic instance1, SquareLogic instance2)
        {
            
            return instance1 * instance2.To(instance1.type).value;
        }



         public static bool operator >(SquareLogic first, SquareLogic second)
         {

             return first.value > second.To(first.type).value;
         }
         public static bool operator <(SquareLogic first, SquareLogic second)
         {
             return first.value < second.To(first.type).value;
        }
    }

}
