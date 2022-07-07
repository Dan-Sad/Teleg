using System;
using System.Collections.Generic;
using System.Text;

namespace Teleg
{
    interface ILanguageQuestion
    {
        public string CurrentZone { get; }
        public string Color { get; }
        public string Likeon { get; }
        public string Language { get; }
       
        //For menu
        public string Menu { get; }
        public string Fourty { get; }
        public string Cover { get; }
        public string Ecology { get; }
        public string Feels { get; }
        public string Limit { get; }
        public string Process { get; }
        public string States { get; }
        public string Stimul { get; }
        public string Style { get; }
        public string Zona { get; }

    //For system
    public string ChooseMore { get; }
    }

    interface ILanguageButton
    {
        //For system
        public string Return { get; }
        public string Next { get; }
        public string NoMatters { get; }
        public string ChoseOfRecomennd { get; }
        public string Result { get; }
        public string Apply { get; }
        public string Ready { get; }


        //For Menu
        public string Fourty { get; }
        public string Cover { get; }
        public string Ecology { get; }
        public string Feels { get; }
        public string Limit { get; }
        public string Process { get; }
        public string States { get; }
        public string Stimul { get; }
        public string Style { get; }
        public string Zona { get; }

        //Cover
        public string Water { get; }
        public string Clean { get; }
        public string Silicon { get; }
        public string Oil { get; }

        //Ecology
        public string Battery { get; }
        public string Vegan { get; }
        public string Factory { get; }

        //Feels

        public string Wight { get; }
        public string Depth { get; }
        public string Suction { get; }
        public string Tingling { get; }
        public string Pushers { get; }
        public string Pulsators { get; }
        public string Smoothness { get; }
        public string Texture { get; }
        public string Heating { get; }
        public string Massage { get; }

        //Fourty

        
        public string Distant { get; }
        public string Ergonomic { get; }
        public string SmallDiametr { get; }
        public string Bandage { get; }
        public string Power { get; }
        public string Vacuum { get; }





        //Limit
        public string WithoutHand { get; }

        //Process

        public string Search { get; }
        public string Point { get; }
        public string MixOrgasm { get; }
        public string Pillow { get; }
        public string NewTech { get; }
        public string Boy { get; }
        public string Girl { get; }
        public string Public { get; }

        //Stimul
        public string Soft { get; }
        public string Fast { get; }
        public string Slow { get; }


        //Style
        public string Natural { get; }
        public string Steal { get; }

        //Zona
        public string Outside { get; }
        public string Inside { get; }
        public string Mix { get; }

        //CurrentZone

        public string Clitor { get; }
        public string Vagina { get; }
        public string Anal { get; }
        public string Combination { get; }

        //Color
        public string White { get; }
        public string Black { get; }
        public string Red { get; }
        public string Green { get; }
        public string Blue { get; }
        public string Yellow { get; }
        public string Gray { get; }
        public string Pink { get; }
        public string Violent { get; }
        public string Dark { get; }
        public string Metal { get; }
        public string Light { get; }
        public string Gentle { get; }
        public string Bright { get; }

        //Likeon 

        public string Space { get; }
        public string Usually { get; }
        public string Minimalism { get; }
        public string Animal { get; }
        public string Child { get; }
        public string Realistic { get; }


        //Language
        public string LanguageRUS { get; }
        public string LanguageENG { get; }

       
    }
}
