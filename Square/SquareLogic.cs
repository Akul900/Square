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
    }
}
