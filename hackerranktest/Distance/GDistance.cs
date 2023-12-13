using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest.Distance
{
    /// <summary>
    /// Find the max distance from a block to a list of desidered facilities
    /// </summary>
    public class GDistance
    {
        protected ExploringList exploring = new ExploringList();
        /// <summary>
        /// Max distance from a block to a list of desidered facilities
        /// </summary>
        /// <param name="myFacilities">desidered facilities</param>
        /// <param name="Blocks">Blocks</param>
        /// <param name="myPosition">position</param>
        /// <returns></returns>
        public int MaxDistanceTo(List<string> myFacilities, List<string>[] Blocks, int myPosition)
        {
            exploring.DesideredItems = myFacilities.ToList();
            var lowerIndex = myPosition;
            var upperIndex = myPosition;
            return ExploreArrayRecursive(myFacilities, Blocks, lowerIndex, upperIndex, myPosition);
        }
        private  int ExploreArrayRecursive(List<string> myFacilities, List<string>[] Blocks, int lowerIndex, int upperIndex, int myPositon)
        {
            if (lowerIndex < 0 && upperIndex >= myFacilities.Count())
            {
                return int.MaxValue;
            }

            if (upperIndex < myFacilities.Count())
            {
                var block = Blocks[upperIndex];
                exploring.AddBlock(block);
                if (exploring.AllFound)
                    return upperIndex-myPositon;
            }

            if (lowerIndex >= 0)
            {
                var block = Blocks[lowerIndex];
                exploring.AddBlock(block);
                if (exploring.AllFound)
                    return myPositon - lowerIndex;
            }

            return ExploreArrayRecursive(myFacilities,Blocks, lowerIndex - 1, upperIndex + 1, myPositon);
        }

    }
}
