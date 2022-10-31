using RoleplayGame.Encounters;
using RoleplayGame.Characters;
using RoleplayGame.Items;
using System;
namespace RoleplayGame.Scenarios
{
    public class EscenarioParteVI : IScenario
    {
        public EncounterType EncuentroTipo {get;set;}
        public Character personaje1 {get;set;}
        public Character personaje2 {get;set;}
        public Character personaje3 {get;set;}

        public void Setup()
        {
            this.EncuentroTipo = EncounterType.Attack;

            this.personaje1 = new Elf("Pedrito");
            this.personaje1.AddItem(new EspadaFuego());
            this.personaje1.AddItem(new BataInvisibilidad());

            this.personaje2 = new Troll("Pablo");
            this.personaje2.AddItem(new PelotaMesi());
            this.personaje2.AddItem(new EscudoLatinoAmerica());
            this.personaje2.AddItem(new EscudoLatinoAmerica());
            this.personaje2.AddItem(new EscudoLatinoAmerica());

            this.personaje3 = new Wizard("Paulinho");
            GuanteleteDelInfinito guantelete = new GuanteleteDelInfinito();
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            guantelete.AgregarGema(new Gema());
            this.personaje3.AddItem(guantelete);

            
            
        }

        public void Run()
        {
            EncounterFactory.GetEncounter(this.EncuentroTipo, this.personaje1, this.personaje2);

            if (this.personaje1.IsDead)
            {
                Console.WriteLine($"{this.personaje1.Name} murió a manos de {this.personaje2.Name}");
                this.personaje2.Curar();
                EncounterFactory.GetEncounter(this.EncuentroTipo, this.personaje2,this.personaje3);
                if (this.personaje2.IsDead)
                {
                    Console.WriteLine($"{this.personaje2.Name} murió a manos de {this.personaje3.Name}");
                    Console.WriteLine($"{this.personaje3.Name} Ganó el encuentro");
                }
                else
                {
                    Console.WriteLine($"{this.personaje3.Name} murió a manos de {this.personaje2.Name}");
                    Console.WriteLine($"{this.personaje2.Name} Ganó el encuentro");

                }
            }
            else
            {
                Console.WriteLine($"{this.personaje2.Name} murió a manos de {this.personaje1.Name}");
                this.personaje1.Curar();
                EncounterFactory.GetEncounter(EncounterType.Attack, this.personaje1,this.personaje3);
                if (this.personaje1.IsDead)
                {
                    Console.WriteLine($"{this.personaje1.Name} murió a manos de {this.personaje3.Name}");
                    Console.WriteLine($"{this.personaje3.Name} Ganó el encuentro");
                }
                else
                {
                    Console.WriteLine($"{this.personaje3.Name} murió a manos de {this.personaje1.Name}");
                    Console.WriteLine($"{this.personaje1.Name} Ganó el encuentro");

                }

            }
            
        }
    }
}