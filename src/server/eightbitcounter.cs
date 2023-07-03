using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace LA
{
    public class eightbitcounter : LogicComponent
    {
        int count = 0;
        
        protected override void DoLogicUpdate()
        {
            if (Inputs[9].On)
            {
                count++;

                for (int i = 0; i < 8; i++)
                {
                    Outputs[i].On = ((count >> i) & 1) > 0;
                }
            }

            if (Inputs[8].On)
            {
                int newCount = 0;
                if (Inputs[0].On) newCount += 1;
                if (Inputs[1].On) newCount += 2;
                if (Inputs[2].On) newCount += 4;
                if (Inputs[3].On) newCount += 8;
                if (Inputs[4].On) newCount += 16;
                if (Inputs[5].On) newCount += 32;
                if (Inputs[6].On) newCount += 64;
                if (Inputs[7].On) newCount -= 128;

                count = newCount;


                for (int i = 0; i < 8; i++)
                {
                    Outputs[i].On = ((newCount >> i) & 1) > 0;
                }
            }
        }
    }
}