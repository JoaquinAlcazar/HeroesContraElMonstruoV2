using hVSmLib;
using Microsoft.VisualStudio.TestPlatform.Common.Interfaces;

namespace heroesContraMonstruoV2
{
    public class heroesVsMonstruo
    {
        public static void Main(String[] args)
        {
            const string welcomeMSG = "             BIENVENIDO A \n" +
                                      "         HEROES CONTRA EL MONSTRUO\n" +
                                      "                ...¡¡¡¡2!!!!!\n\n\n";
            const string pressToCont = "Pulsa un botón para continuar";
            const string mainMenu = "Bienvenido a Heroes contra el monstruo 2, el mismo juego de batalla contra el monstruo, ahora con diseño modular.\n" +
                "¿Quieres probarte en batalla?\n1.Iniciar una nueva batalla\n2.Salir";
            const string thxForPlay = "¡¡¡Gracias por jugar!!!";
            const string diffSelectMSG = "Selecciona una dificultad\n1.Fácil\n2.Difícil\n3.Personalizada\n4.Aleatoria";
            const string mainMenuFail = "Valor invalido, introduce un valor valido.";
            const string letsGoCreate = "Vamos a personalizar a los personajes";
            const string introduceHP = "Introduce su vida [{0}-{1}]";
            const string introduceDMG = "Introduce su daño [{0}-{1}]";
            const string introduceDMGRed = "Introduce su reducción de daño[{0}-{1}]";
            const string minValAssign = "3 fallos, valor mínimo asignado\n";
            const string daleSabor = "Estos heroes se ven fuertes, pero les falta un poco de personalidad\nDales unos nombres.\n\n" +
                "(El formato para los nombres es el siguiente: 'nombre, nombre, nombre, nombre' sin comillas, separados por comas,\n y en orden Arquera, Barbaro, Mago, Druida, para que el juego los detecte bien)";

            const string preBattleStatsDisplay = "{0}\nVida: {1}\nDaño: {2}\nReducción de daño: {3}%";

            int mainMenuSelect = 0;
            int dificultySelect = 0;


            int attTries = 0;
            int statInput = 0;
            bool statCheck = false;

            string heroesNames;
            string[] namesArray = new string[4];

            string[] monsterNames = {"Estus, el bebesangre", "Gorlock, el destructor", "El devoramundos", "Titán Speakerman"};
            string monsterName = monsterNames[heroesContraMonstruoClass.randomNumberGenerator(0, 2)];

            //stats arquera
            int archerHP = 0;
            int actualArcherHP = 0;
            int archerDamage = 0;
            int archerDamageReduction = 0;
            int archerSkillCD = 0;
            bool archerDefending = false;

            int maxArchHP = 2000;
            int minArchHP = 1500;

            int maxArchDamage = 300;
            int minArchDamage = 200;

            int maxArchDamageReduction = 35;
            int minArchDamageReduction = 25;

            //stats barbaro
            int barbarianHP = 0;
            int actualBarbarianHP = 0;
            int barbarianDamage = 0;
            int barbarianDamageReduction = 0;
            int barbarianSkillCD = 0;
            int barbarianSkillTurns = 0;
            bool barbarianDefending = false;

            int maxBarbHP = 3750;
            int minBarbHP = 3000;

            int maxBarbDamage = 250;
            int minBarbDamage = 150;

            int maxBarbDamageReduction = 45;
            int minBarbDamageReduction = 35;

            //stats maga
            int mageHP = 0;
            int actualMageHP = 0;
            int mageDamage = 0;
            int mageDamageReduction = 0;
            int mageSkillCD = 0;
            bool mageDefending = false;

            int maxMageHP = 1500;
            int minMageHP = 1100;

            int maxMageDamage = 400;
            int minMageDamage = 300;

            int maxMageDamageReduction = 35;
            int minMageDamageReduction = 20;

            //stats druida
            int druidHP = 0;
            int actualDruidHP = 0;
            int druidDamage = 0;
            int druidDamageReduction = 0;
            int druidSkillCD = 0;
            bool druidDefending = false;

            int maxDruiHP = 2500;
            int minDruiHP = 2000;

            int maxDruiDamage = 120;
            int minDruiDamage = 70;

            int maxDruiDamageReduction = 40;
            int minDruiDamageReduction = 25;

            //stats monstruo
            int monsterHP = 0;
            int monsterDamage = 0;
            int monsterDamageReduction = 0;
            int monsterCheck = 0;
            int monsterStagger = 0;

            int maxMonsHP = 10000;
            int minMonsHP = 7000;

            int maxMonsDamage = 400;
            int minMonsDamage = 300;

            int maxMonsDamageReduction = 30;
            int minMonsDamageReduction = 20;

            Console.WriteLine(welcomeMSG);
            Console.WriteLine(pressToCont);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(mainMenu);
            while (mainMenuSelect != 2) {
                while (mainMenuSelect<1 || mainMenuSelect > 2)
                {
                    mainMenuSelect = Convert.ToInt32(Console.ReadLine());
                    if (mainMenuSelect == 2) { 
                        Console.WriteLine(thxForPlay);
                    } else
                    {
                        Console.WriteLine(mainMenuFail);
                    }
                }

                Console.Clear();

                if (mainMenuSelect == 1)
                {
                    //seleccion de dificultad y creacion de personajes
                    Console.WriteLine(diffSelectMSG);
                    while (dificultySelect < 1 || dificultySelect > 4)
                    {
                        dificultySelect = Convert.ToInt32(Console.ReadLine());
                        if (dificultySelect == 1)
                        {
                            archerHP = 2000;
                            actualArcherHP = archerHP;
                            archerDamage = 300;
                            archerDamageReduction = 35;

                            barbarianHP = 3750;
                            actualBarbarianHP = barbarianHP;
                            barbarianDamage = 250;
                            barbarianDamageReduction = 45;

                            mageHP = 1500;
                            actualMageHP = mageHP;
                            mageDamage = 400;
                            mageDamageReduction = 35;


                            druidHP = 2500;
                            actualDruidHP = druidHP;
                            druidDamage = 120;
                            druidDamageReduction = 40;

                            monsterHP = 7000;
                            monsterDamage = 300;
                            monsterDamageReduction = 20;
                        }
                        else if (dificultySelect == 2)
                        {
                            archerHP = 1500;
                            actualArcherHP = archerHP;
                            archerDamage = 200;
                            archerDamageReduction = 25;

                            barbarianHP = 3000;
                            actualBarbarianHP = barbarianHP;
                            barbarianDamage = 150;
                            barbarianDamageReduction = 35;

                            mageHP = 1100;
                            actualMageHP = mageHP;
                            mageDamage = 300;
                            mageDamageReduction = 20;


                            druidHP = 2000;
                            actualDruidHP = druidHP;
                            druidDamage = 70;
                            druidDamageReduction = 25;

                            monsterHP = 10000;
                            monsterDamage = 400;
                            monsterDamageReduction = 30;
                        }
                        else if (dificultySelect == 3)
                        {
                            //creación de la arquera
                            Console.Clear();
                            Console.WriteLine("Vamos a crear a la arquera");

                            Console.WriteLine(introduceHP, minArchHP, maxArchHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minArchHP, maxArchHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    archerHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                archerHP = minArchHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minArchDamage, maxArchDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minArchDamage, maxArchDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    archerDamage = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                archerDamage = minArchDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minArchDamageReduction, maxArchDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minArchDamageReduction, maxArchDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    archerDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                archerDamage = minArchDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();


                            //Creación del barbaro
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos al barbaro");

                            Console.WriteLine(introduceHP, minBarbHP, maxBarbHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minBarbHP, maxBarbHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    barbarianHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                barbarianHP = minBarbHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minBarbDamage, maxBarbDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minBarbDamage, maxBarbDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    barbarianHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                barbarianDamage = minBarbDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minBarbDamageReduction, maxBarbDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minBarbDamageReduction, maxBarbDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    barbarianDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                barbarianDamageReduction = minBarbDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();

                            //Creación de la maga
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos a la maga");

                            Console.WriteLine(introduceHP, minMageHP, maxMageHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMageHP, maxMageHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    mageHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                mageHP = minMageHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minMageDamage, maxMageDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMageDamage, maxMageDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    mageHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                mageDamage = minMageDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minMageDamageReduction, maxMageDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMageDamageReduction, maxMageDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    mageDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                mageDamageReduction = minMageDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();

                            //Creación del druida
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos al druida");

                            Console.WriteLine(introduceHP, minDruiHP, maxDruiHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minDruiHP, maxDruiHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    druidHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                druidHP = minDruiHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minDruiDamage, maxDruiDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minDruiDamage, maxDruiDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    druidHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                druidDamage = minDruiDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minDruiDamageReduction, maxDruiDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minDruiDamageReduction, maxDruiDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    druidDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                druidDamageReduction = minDruiDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();

                            //Creación del monstruo
                            Console.Clear();
                            Console.WriteLine("Ahora crearemos al monstruo");

                            Console.WriteLine(introduceHP, minMonsHP, maxMonsHP);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMonsHP, maxMonsHP);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    monsterHP = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                monsterHP = minMonsHP;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMG, minMonsDamage, maxMonsDamage);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMonsDamage, maxMonsDamage);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    monsterDamage = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                monsterDamage = minMonsDamage;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(introduceDMGRed, minMonsDamageReduction, maxMonsDamageReduction);
                            while (attTries < 3 && !statCheck)
                            {
                                statInput = Convert.ToInt32(Console.ReadLine());
                                statCheck = heroesContraMonstruoClass.statChecker(statInput, minMonsDamageReduction, maxMonsDamageReduction);
                                if (!statCheck)
                                {
                                    Console.WriteLine(mainMenuFail);
                                    attTries++;
                                }
                                else
                                {
                                    monsterDamageReduction = statInput;
                                }
                            }
                            if (attTries == 3)
                            {
                                Console.WriteLine(minValAssign);
                                monsterDamageReduction = minMonsDamageReduction;
                            }
                            attTries = 0;
                            statCheck = false;

                            Console.WriteLine(pressToCont);
                            Console.ReadKey();
                        }
                        else if (dificultySelect == 4)
                        {
                            archerHP = heroesContraMonstruoClass.randomNumberGenerator(minArchHP, maxArchHP);
                            actualArcherHP = archerHP;
                            archerDamage = heroesContraMonstruoClass.randomNumberGenerator(minArchDamage, maxArchDamage);
                            archerDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minArchDamageReduction, maxArchDamageReduction);

                            barbarianHP = heroesContraMonstruoClass.randomNumberGenerator(minBarbHP, maxBarbHP);
                            actualBarbarianHP = barbarianHP;
                            barbarianDamage = heroesContraMonstruoClass.randomNumberGenerator(minBarbDamage, maxBarbDamage);
                            barbarianDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minBarbDamageReduction, maxBarbDamageReduction);

                            mageHP = heroesContraMonstruoClass.randomNumberGenerator(minMageHP, maxMageHP);
                            actualMageHP = mageHP;
                            mageDamage = heroesContraMonstruoClass.randomNumberGenerator(minMageDamage, maxMageDamage);
                            mageDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minMageDamageReduction, maxMageDamageReduction);


                            druidHP = heroesContraMonstruoClass.randomNumberGenerator(minDruiHP, maxDruiHP);
                            actualDruidHP = druidHP;
                            druidDamage = heroesContraMonstruoClass.randomNumberGenerator(minDruiDamage, maxDruiDamage);
                            druidDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minDruiDamageReduction, maxDruiDamageReduction);

                            monsterHP = heroesContraMonstruoClass.randomNumberGenerator(minMonsHP, maxMonsHP);
                            monsterDamage = heroesContraMonstruoClass.randomNumberGenerator(minMonsDamage, maxMonsDamage);
                            monsterDamageReduction = heroesContraMonstruoClass.randomNumberGenerator(minMonsDamageReduction, maxMonsDamageReduction);
                        }
                        else
                        {
                            Console.WriteLine(mainMenuFail);
                        }
                    }

                    //Revisión de stats y selección de nombres
                    Console.Clear();
                    Console.WriteLine(daleSabor);
                    heroesNames = Console.ReadLine();
                    namesArray = heroesContraMonstruoClass.nameArrayGenerator(heroesNames);

                    Console.Clear();
                    Console.WriteLine("Arquera " + preBattleStatsDisplay, namesArray[0], archerHP, archerDamage, archerDamageReduction);
                    Console.WriteLine("\nBárbaro " + preBattleStatsDisplay, namesArray[1], barbarianHP, barbarianDamage, barbarianDamageReduction);
                    Console.WriteLine("\nMaga " + preBattleStatsDisplay, namesArray[2], mageHP, mageDamage, mageDamageReduction);
                    Console.WriteLine("\nDruida " + preBattleStatsDisplay, namesArray[3], druidHP, druidDamage, druidDamageReduction);

                    Console.WriteLine("\n\nTu enemigo: " + preBattleStatsDisplay, monsterName, monsterHP, monsterDamage, monsterDamageReduction);
                    Console.ReadKey();

                    Console.WriteLine("Pulsa cualquier tecla para iniciar la batalla");
                    Console.ReadKey();



                    //Turnos
                }
            }
        }
    }
}
