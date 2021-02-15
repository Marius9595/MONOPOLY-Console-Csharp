using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    public enum TitleDeedSituation { Free, Bought }
    public interface IAbstractTitleDeed
    {

        public void AssignOwner(Player player) {}
        public string NAME {get;}
        public double BUYING_COST { get;}
        public double PAYTOOWNER { get ;}
        public double MORTGAGE_VALUE { get; }
        public TitleDeedSituation SITUATION { get;}
        
    }
}