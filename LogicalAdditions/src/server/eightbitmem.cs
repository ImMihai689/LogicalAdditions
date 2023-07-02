using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace MB
{
    public class eightbitmem : LogicComponent
    {
        bool[,] memory = new bool[4097,8];
        protected override void DoLogicUpdate()
        {
            //Inputs 0-7 - data in
            //Inputs 8 - write
            //Inputs 9-20 - address

            int address = 0;
            if (Inputs[9].On) address += 1;
            if (Inputs[10].On) address += 2;
            if (Inputs[11].On) address += 4;
            if (Inputs[12].On) address += 8;
            if (Inputs[13].On) address += 16;
            if (Inputs[14].On) address += 32;
            if (Inputs[15].On) address += 64;
            if (Inputs[16].On) address += 128;
            if (Inputs[17].On) address += 256;
            if (Inputs[18].On) address += 512;
            if (Inputs[19].On) address += 1024;
            if (Inputs[20].On) address += 2048;


            if (Inputs[5].On)
            {
                
                memory[address, 0] = Inputs[0].On;
                memory[address, 1] = Inputs[1].On;
                memory[address, 2] = Inputs[2].On;
                memory[address, 3] = Inputs[3].On;
                memory[address, 4] = Inputs[4].On;
                memory[address, 5] = Inputs[5].On;
                memory[address, 6] = Inputs[6].On;
                memory[address, 7] = Inputs[7].On;
            }


            Outputs[0].On = memory[address, 0];
            Outputs[1].On = memory[address, 1];
            Outputs[2].On = memory[address, 2];
            Outputs[3].On = memory[address, 3]; 
            Outputs[4].On = memory[address, 4];
            Outputs[5].On = memory[address, 5];
            Outputs[6].On = memory[address, 6];
            Outputs[7].On = memory[address, 7];


        }
    }
}