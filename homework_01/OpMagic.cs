using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_01
{
    internal class OpMagic 
    {
        //Pri pohledu na UML diagram se jedna o pomerne matouci tridu
        //V diagramu je vyznacena asociace mezi touto tridou a rozhranim IOperation (mozna se puvodne melo jednat o vyznaceni implementace), nicmene ve vyctu atributu tridy OpMagic neni zavedena reference na IOperation
        //Jelikoz je v diagramu i u trid OpSub a OpAdd implementace zakreslovana jako dedicnost (misto prerusovane cary pouzivane pro implementaci je pouzita cara plna pouzivana pro dedicnost), je v teto tride vytvorena zavislost misto asociace
        //Diky tomu odpovida vycet atributu a metod s diagramem
        public int Execute(int a, int b)
        {
            IOperation operation1 = new OpAdd();
            IOperation operation2 = new OpSub();
            return operation1.Execute(operation2.Execute(a, a), operation2.Execute(b, b));
        }
    }
}
