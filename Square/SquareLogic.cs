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
        {
            this.value = value;
            this.type = type;
        }

        public double Value
        {
            get
            {
                return value;
            }
        }
        public MeasureType Type
        {
            get
            {
                return type;
            }
        }
        public string Verbose()
        {
            string typeVerbose = "";
            switch (this.type)
            {
                case MeasureType.m2:
                    typeVerbose = "m2.";
                    break;
                case MeasureType.га:
                    typeVerbose = "га.";
                    break;
                case MeasureType.а:
                    typeVerbose = "а.";
                    break;
                case MeasureType.д:
                    typeVerbose = "д.";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeVerbose);
        }
        public static SquareLogic operator +(SquareLogic instance, double number)
        {
            // расчитываем новую значение
            var newValue = instance.value + number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var square = new SquareLogic(newValue, instance.type);
            // возвращаем результат
            return square;
        }

        // чтобы можно было добавлять число также слева
        public static SquareLogic operator +(double number, SquareLogic instance)
        {
            // вызываем с правильным порядком аргументов, то есть сначала длина потом число
            // для такого порядка мы определили оператор выше
            return instance + number;
        }
        public static SquareLogic operator *(SquareLogic instance, double number)
        {
            // мне лень по три строчки писать, поэтому я сокращаю код до одной строки
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

        // деление
        public static SquareLogic operator /(SquareLogic instance, double number)
        {
            return new SquareLogic(instance.value / number, instance.type); ;
        }

        public static SquareLogic operator /(double number, SquareLogic instance)
        {
            return instance / number;
        }
        public SquareLogic To(MeasureType newType)
        {
            // по умолчанию новое значение совпадает со старым
            var newValue = this.value;
            // если текущий тип -- это метр
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
            else if (newType == MeasureType.m2) // если новый тип: метр
            {
                switch (this.type) // а тут уже старый тип проверяем
                {
                    case MeasureType.m2:
                        newValue = this.value;
                        break;
                    case MeasureType.га:
                        newValue = this.value * 10000; // кстати это то же код что и выше, только / заменили на *
                        break;
                    case MeasureType.а:
                        newValue = this.value * 100; // и тут / на *
                        break;
                    case MeasureType.д:
                        newValue = this.value * 10925; // и даже тут, просто / на *
                        break;
                }
            }
            else // то есть не в метр и не из метра
            {
                newValue = this.To(MeasureType.m2).To(newType).value;
                // в принципе можно сразу написать 
                // return this.To(MeasureType.m).To(newType);
                // но хорошем тоном считается наличие всего одного return в функции
            }
            return new SquareLogic(newValue, newType);
        }
        public static SquareLogic operator +(SquareLogic instance1, SquareLogic instance2)
        {
            // то есть у текущей длине добавляем число 
            // полученное преобразованием значения второй длины в тип первой длины
            // так как у нас определен operator+(Length instance, double number)
            // то это сработает как ожидается
            return instance1 + instance2.To(instance1.type).value;
        }

        // вычитание двух длин
        public static SquareLogic operator -(SquareLogic instance1, SquareLogic instance2)
        {
            // тут все тоже, только с минусом
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
