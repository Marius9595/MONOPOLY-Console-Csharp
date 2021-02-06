using System;
using System.Collections.Generic;
using System.Text;

namespace MONOPOLY
{
    public enum TitleDeedSituation { Free, Bought }
    public interface IAbstractTitleDeed
    {

        public void AssignOwner() {}
        public string NAME { get;}
        public double BUYING_COST { get;}
        public double PAYTOOWNER { get ;}
        public TitleDeedSituation SITUATION { get;}
        
    }
}