using System.Collections.Generic;
internal class Program
{

    const TerritoryLength = Enum.getNames(typeof(TerritoryName)).Length;

    public readonly new HashSet<HashSet<TerritoryName>> Connections = new HashSet<HashSet<TerritoryName>>{new HashSet<TerritoryName> {TerritoryName.Poop, TerritoryName.Butt},
                                                                                                          new HashSet<TerritoryName> {TerritoryName.Poop, TerritoryName.Peepee}
    };

    public readonly enum Country{
        Russia,
        Germany,
        Austria,
        Italy,
        England,
        France,
        Turkey,
        None
    }

    public readonly enum TerritoryType{
        Land,
        Sea,
        SupplyCenter,
        StartingSupplyCenter
    }

    public readonly enum MoveAction{
        Convoy,
        Hold,
        Move,
        Support
        
    }

    public readonly enum TerritoryName{
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

        public void GetAction(){
            return this.action;
        }

        public Move clone(){
            return new Move(this.action, this.origin, this.target);
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

        //Constructor with Move input
        public Territory(TerritoryName name, Country occupation, Country ownership, TerritoryType territoryType, Move move){
            this.name = name;
            this.occupation = occupation;
            this.ownership = ownership;
            this.territoryType = territoryType;
            this.move = move;
        }

        public TerritoryName getName(){
            return this.name;
        }

        public TerritoryName getMove(){
            return this.move;
        }

        public Territory clone(){
            return new Territory(this.name, this.occupation, this.ownership, this.territoryType, this.move.clone());
        }

    }


    //This function deep clones a Territory List
    public List<Territory> CloneTerritoryList(List<Territory> territories){
        int counter = 0;
        List<Territory> ret = new List<Territory>();
        for(counter = 0; counter < territories.Count; counter++){
            ret.Add(territories[counter].clone());
        }
        return ret;
    }

    public Class CheckClass{



        public static (List<string> log, List<Territory> newState) CheckTerritory(List<Territory> oldTerritories){
              List<string> log = new List<string>();
              List<Territory> newState = new List<Territory>();
              List<Territory> territories = CloneTerritoryList(oldTerritories);
              territories.Sort((ter1, ter2) => ter1.getMove().GetAction() - ter2.getMove().GetAction()); //sorts the list so that the convoys are checked first

              While(newState.Count != TerritoryLength){
                
                  switch(territories[0]){
                  
                      case MoveAction.Convoy:
                        
                      break;
                      case MoveAction.Hold:
                          
                          break; //fuck you
                      case MoveAction.Move:
                          
                          break;
                    }  
                }

        }

    }


    private static void Main(string[] args)
    {
        

        
    }
}
