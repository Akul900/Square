using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var measureItems = new string[]
            {
                "m2.",
                "га.",
                "а.",
                "д.",
            };

            // привязываем списки значений к каждому комбобоксу
            cmbFirstType.DataSource = new List<string>(measureItems);
            cmbSecondType.DataSource = new List<string>(measureItems);
            cmbResultType.DataSource = new List<string>(measureItems);
            cmbThirdType.DataSource = new List<string>(measureItems);
            cmbResultType2.DataSource = new List<string>(measureItems);
        }
        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "m2.":
                    measureType = MeasureType.m2;
                    break;
                case "га.":
                    measureType = MeasureType.га;
                    break;
                case "а.":
                    measureType = MeasureType.а;
                    break;
                case "д.":
                    measureType = MeasureType.д;
                    break;
                default:
                    measureType = MeasureType.m2;
                    break;
            }
            return measureType;
        }

        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(txtFirst.Text);
                var secondValue = double.Parse(txtSecond.Text);

                // вместо трех страшных свитчей, три вызова нашей новой функции
                MeasureType firstType = GetMeasureType(cmbFirstType);
                MeasureType secondType = GetMeasureType(cmbSecondType);
                MeasureType resultType = GetMeasureType(cmbResultType);

                // тут сразу тип полученный передаем в момент создания экземпляра класса
                var firstLength = new SquareLogic(firstValue, firstType);
                var secondLength = new SquareLogic(secondValue, secondType);


                SquareLogic sumLength;

                switch (cmbOperation.Text)
                {
                    case "+":
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        sumLength = firstLength - secondLength;
                        break;                
                    default:
                        sumLength = new SquareLogic(0, MeasureType.m2);
                        break;
                }
                if (new SquareLogic(firstLength.Value, firstType) < new SquareLogic(secondLength.Value, secondType))
                {
                    txtResult3.Text = "Меньше";
                }
                else if (new SquareLogic(firstLength.Value, firstType) > new SquareLogic(secondLength.Value, secondType))
                {
                    txtResult3.Text = "Больше";
                }
                else
                {
                    txtResult3.Text = "Равно";
                }

                // тут конвертируем через To(resultType) в указанный тип
                txtResult.Text = sumLength.To(resultType).Verbose();
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }

        private void Calculate2()
        {
            try
            {
                var firstValue = double.Parse(txtThird.Text);
                var secondValue = double.Parse(txtFourth.Text);

                // вместо трех страшных свитчей, три вызова нашей новой функции
                MeasureType firstType = GetMeasureType(cmbThirdType);
              //  MeasureType secondType = GetMeasureType(cmbSecondType);
                MeasureType resultType = GetMeasureType(cmbResultType2);

                // тут сразу тип полученный передаем в момент создания экземпляра класса
                var firstLength = new SquareLogic(firstValue, firstType);
              //  var secondLength = new SquareLogic(secondValue, secondType);

                SquareLogic sumLength;

                switch (cmbOperation2.Text)
                {
                     case "*":
                        sumLength = firstLength * secondValue;
                        break;
                    default:
                        sumLength = new SquareLogic(0, MeasureType.m2);
                        break;
                }

                // тут конвертируем через To(resultType) в указанный тип
                txtResult2.Text = sumLength.To(resultType).Verbose();
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }
        private void onValueChanged(object sender, EventArgs e)
        {
            // вызов функции все тот же
            Calculate();
        }

        private void onValueChanged2(object sender, EventArgs e)
        {
            // вызов функции все тот же
            Calculate2();
        }

    }
}
