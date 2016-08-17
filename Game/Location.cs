using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace Game
{
    class Location
    {
        public List<Location> Locations;
        public string Name;
        public string Description;
        public People NPC;
        public Monster Monster;
        public Chest Loot;
        public Quest Quest { get; set; }

        public Action<Player> Action { get; set; }

        public Action<Player> SelectLocation { get; set; }
    }

    abstract class People
    {
        public string Name;
        public Quest Quest;

        public abstract void Dialogue( Player peasant );

    }

    class Peasant : People
    {
        public override void Dialogue( Player peasant )
        {
            Console.WriteLine( "  Крестьянин: Ты же слышыл легенду про избранного? Интересно, кто это может быть?" );
            Console.Write(
                "  1)Мне-то какая разница? Главное, что не я. И от этого мне не лучше. Пусть я и не избранный, но эти твари похитили моего сына и убили мою жену. И я буду мстить. 2)Хорошо бы узнать. Я, конечно, надеюсь, что я. Но, это маловероятно. Однако, отомстить придётся в любом случае. (Выберите ответ): " );
            String answer = Console.ReadLine();
            switch ( answer )
            {
                case "1":
                    peasant.Karma--;
                    Console.WriteLine(
                        "  Крестьянин: А ты оказывается эгоист, не ожидал я такого. (Начислена отрицательная карма) " +
                        peasant.Karma );
                    break;
                case "2":
                    peasant.Karma++;
                    Console.WriteLine(
                        "  Крестьянин: Вот я так же думаю. А насчёт вероятности... А, чёрт его знает! (Начислена положительная карма) " +
                        peasant.Karma );
                    break;
            }
            Console.WriteLine(
                "  Крестьянин: А ты в армию идти не планируешь? Ах, забыл, у нас никто не хочет в армию. И ты в том числе. Ну, бывай." );
        }

    }

    class Human : People
    {
        public override void Dialogue(Player peasant)
        {
            
        }
    }


    class LocationFactory
    {
        /// <summary>
        /// Дримфолл.
        /// </summary>
        /// <returns></returns>
        public Location CreateDreamfallLocation()
        {
            Location DreamfallLocation = new Location();

            DreamfallLocation.Name = "Дримфолл";
            DreamfallLocation.Description = "Столица одноимённого королевства.";
            var Club = new Weapon();
            Club.Dmg = 5;

            DreamfallLocation.Loot = new Chest() { Weapon = Club };

            DreamfallLocation.NPC = new Peasant();

            DreamfallLocation.Action = player =>
            {
                Console.Write( "  1)Остаться в городе. 2)Выйти из города (Выберите вариант): " );
                String answer2 = Console.ReadLine();
                switch ( answer2 )
                {
                    case "1":
                        Console.WriteLine( "  Немного побродив по городу, вы нашли дубину и отправились в путь." );
                        player.CurrentWeapon = Club;
                        Console.WriteLine( "Текущий урон: " + player.SharedDmg );
                        break;
                    case "2":
                        Console.WriteLine( "  Вы отправились в путь.(Не терпится?)" );
                        Console.WriteLine( "Текущий урон: " + player.SharedDmg );
                        break;
                }
            };

            DreamfallLocation.SelectLocation = player =>
            {
                Console.Write(
                "  Вы слышите стоны и просьбы о помощи. С одной стороны, вам интересно, но с другой, инстинкт самосохранения подсказывает вам, что идти не стоит, так как там может быть засада. Как вы поступите? 1)Пойти. 2)Не идти. (Выберите вариант): " );
                String answer3 = Console.ReadLine();
                switch ( answer3 )
                {
                    case "1":
                        player.Karma = player.Karma + 3;
                        Console.WriteLine(
                            "  Стоны издавал сильно истерзанный, но всё ещё живой человек. Он попросил вас окончить его мучения. Взяв меч, вы окончили его мучения и положили ему в руку меч, следуя традиции. Вы вернулись обратно ко входу в Дримфол (Начислена положительная карма) " +
                            player.Karma );
                        Console.WriteLine(
                            "  Традиция: Если воин погиб с оружием в руках, в следующей жизни его вещи снова будут при нём. Поэтому, ни в коем случае нельзя забирать его меч, так как в следующей жизни вам могут неосознанно отомстить" );
                        break;
                    case "2":
                        player.Karma = player.Karma - 3;
                        Console.WriteLine(
                            "  Вы сделали вид, что не слышали. В этом сыграл роль инстинкт самосохранения. (Начислена отрицательная карма) " +
                            player.Karma );
                        break;
                }
            };

            DreamfallLocation.Quest = new Quest
            {
                Name = "Новый квест: В путь!",
                Description = "Ваше путешествие по Дримфолу начинается",
            };

            DreamfallLocation.Locations = new List<Location> { CreateEnterToDreamfalLocation() };

            return DreamfallLocation;

        }
        /// <summary>
        /// Вход в Дримфолл.
        /// </summary>
        /// <returns></returns>
        public Location CreateEnterToDreamfalLocation()
        {
            Location EnterToDreamfal = new Location();

            EnterToDreamfal.Name = "Вход в Дримфолл";
            EnterToDreamfal.Description = "";

            var loc2 = CreateFirstBattleLocation();
            var loc1 = CreatePlaceWithHumanLocation();

            EnterToDreamfal.Locations = new List<Location>() { loc1, loc2 };

            EnterToDreamfal.SelectLocation = player =>
            {
                Console.Write( "  Вы слышите стоны и просьбы о помощи. С одной стороны, вам интересно, но с другой, инстинкт самосохранения подсказывает вам, что идти не стоит, так как там может быть засада. Как вы поступите? 1)Пойти. 2)Не идти. (Выберите вариант): " );
                String answer3 = Console.ReadLine();
                switch ( answer3 )
                {
                    case "1":
                        player.Karma = player.Karma + 3;
                        player.CurrentLocation = loc1;
                        Console.WriteLine( "  Стоны издавал сильно истерзанный, но всё ещё живой человек. Он попросил вас окончить его мучения. Взяв меч, вы окончили его мучения и положили ему в руку меч, следуя традиции. Вы вернулись обратно ко входу в Дримфол (Начислена положительная карма) " + player.Karma );
                        Console.WriteLine( "  Традиция: Если воин погиб с оружием в руках, в следующей жизни его вещи снова будут при нём. Поэтому, ни в коем случае нельзя забирать его меч, так как в следующей жизни вам могут неосознанно отомстить" );
                        break;
                    case "2":
                        player.Karma = player.Karma - 3;
                        player.CurrentLocation = loc2;
                        Console.WriteLine( "  Вы сделали вид, что не слышали. В этом сыграл роль инстинкт самосохранения. (Начислена отрицательная карма) " + player.Karma );
                        break;
                }
            };

            

            return EnterToDreamfal;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Location CreatePlaceWithHumanLocation()
        {
            Location PlaceWithHuman = new Location();

            PlaceWithHuman.Name = "Место с раненым человеком";
            PlaceWithHuman.Description = "";


            return PlaceWithHuman;

        }

        public Location CreateFirstBattleLocation()
        {
            var ChangedHuman = new Monster("", 30);
            ChangedHuman.Dmg = 3;
            ChangedHuman.Prot = 0;

            Location FirstBattle = new Location();

            FirstBattle.Name = "Первая Битва";
            FirstBattle.Description = "Здесь на героя нападёт монстр";

            FirstBattle.Action = player =>
            {
                Console.WriteLine("  На пути на вас внезапно напал монстр. Защищайтесь!");
                Program.PvE(player, ChangedHuman);
                player.EXP = player.EXP + 10;
                Console.WriteLine("Вы получили 10 ед. опыта. Опыт: " + player.EXP);
            };

            return FirstBattle;

        }

        public Location CreateDivarication1Location()
        {
            Location Divarication1 = new Location();

            Divarication1.Name = "Развилка(1)";
            Divarication1.Description = "Первая развилка";

            Divarication1.Action = player =>
            {

            };

            return Divarication1;

        }

        public Location CreatePlaceWithOldWomanLocation()
        {
            Location PlaceWithOldWoman = new Location();

            PlaceWithOldWoman.Name = "Место нападения на женщину";
            PlaceWithOldWoman.Description = "Здесь на старуху нападёт монстр";

            return PlaceWithOldWoman;

        }

        public Location CreateLakewoodLocation()
        {
            Location Lakewood = new Location();

            Lakewood.Name = "Деревня Лэйквуд";
            Lakewood.Description = "Деревня, которая была построена, чтобы защищать Королевство от монстров. Местный староста может знать что-то о местонахождении главного демона";

            return Lakewood;

        }

    }
}
