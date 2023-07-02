using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace LA
{
    public class fourbitmem : LogicComponent
    {
        bool[,] memory = new bool[16,4];
        protected override void DoLogicUpdate()
        {
            int address = 0;
            if (Inputs[6].On)
            {
                address += 1;
            }
            if (Inputs[7].On)
            {
                address += 2;
            }
            if (Inputs[8].On)
            {
                address += 4;
            }
            if (Inputs[9].On)
            {
                address += 8;
            }


            if (Inputs[5].On)
            {
                
                memory[address,0] = Inputs[0].On;
                memory[address,1] = Inputs[1].On;
                memory[address,2] = Inputs[2].On;
                memory[address,3] = Inputs[3].On;
            }


            Outputs[0].On = memory[address,0];
            Outputs[1].On = memory[address,1];
            Outputs[2].On = memory[address,2];
            Outputs[3].On = memory[address,3];


        }
    }
}