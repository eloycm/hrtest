using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace hackerranktest.Distance
{
    public class GDistance
    {
        /// <summary>
        /// Max distance from a block to a list of desidered facilities
        /// </summary>
        /// <param name="myFacilities">desidered facilities</param>
        /// <param name="Blocks">Blocks</param>
        /// <param name="myPosition">position</param>
        /// <returns></returns>
        public int MaxDistanceTo(List<string> myFacilities, List<string>[] Blocks, int myPosition)
        {
            var exploring = new ExploringList();
      
            exploring.DesideredItems = myFacilities.ToList();

            for (int i = myPosition; i < Blocks.Length; i++)
            {
                //up
                var block = Blocks[i];
                exploring.AddBlock(block);
                if (exploring.AllFound)
                    return i - myPosition;

                //down
                if (myPosition - i <= 0)
                    continue;
                block = Blocks[myPosition - i];
                exploring.AddBlock(block);
                if (exploring.AllFound)
                    return myPosition -i;
            }
            return int.MaxValue;
        }
        public int FindBlock(List<string> myFacilities, List<string>[] Blocks)
        {
            var minDistance = int.MaxValue;
            var rs = int.MaxValue;
            for (int i = 0; i < Blocks.Length; i++)
            {
                var distance = MaxDistanceTo(myFacilities, Blocks,i);
                if (minDistance > distance)
                {
                    minDistance = distance;
                    rs= i;
                }
                    
            }

            return rs;

        }

    }
}
