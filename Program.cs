internal class Program
{

    public readonly new HashSet<HashSet<TerritoryName>> Connections = new HashSet<HashSet<TerritoryName>>{new HashSet<TerritoryName> {TerritoryName.Poop, TerritoryName.Butt},
                                                                                                          new HashSet<TerritoryName> {TerritoryName.Poop, TerritoryName.Peepee}
    };

    public enum Country{
        Russia,
        Germany,
        Austria,
        Italy,
        England,
        France,
        Turkey,
        None
    }

    public enum TerritoryType{
        Land,
        Sea,
        SupplyCenter,
        StartingSupplyCenter
    }

    public enum MoveAction{
        Hold,
        Move,
        Support,
        Convoy
    }

    public enum TerritoryName{
        Poop,
        Butt,
        Peepee
    }

    class Move{
        private MoveAction action;
        private TerritoryName origin;
        private TerritoryName target;

        public Move(MoveAction action, TerritoryName origin, TerritoryName target){
            this.action = action;
            this.origin = origin;
            this.target = target;
        }
    }

    class Territory {
        //Parameters
        private readonly TerritoryName name;
        private Country occupation;
        private Country ownership;
        private readonly TerritoryType territoryType;
        private Move move;

        //Basic constructor
        public Territory(TerritoryName name, Country occupation, Country ownership, TerritoryType territoryType){
            this.name = name;
            this.occupation = occupation;
            this.ownership = ownership;
            this.territoryType = territoryType;
            this.move = new Move(MoveAction.Hold, name, name);
        }

        public TerritoryName getName(){
            return this.name;
        }

    }



    private static void Main(string[] args)
    {
        

        
    }
}