using InterfaceImplimentationApp.Models;

namespace InterfaceImplimentationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var man = new Man();
            var boy = new Boy();
            AtThePark(man);
           // AtTheMovie(man);
            AtThePark(boy);
            AtTheMovie(boy);
        }
        static void AtThePark(IManarable manarable)
        {
            manarable.Depart();
            manarable.Wish();
                
        }
        static void AtTheMovie(IEmotionable emotionable)
        {
            emotionable.Cry();  
            emotionable.Laugh();
        }
    }
}
