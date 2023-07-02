using LogicAPI.Server.Components;
using LogicAPI.Server;
using LogicLog;
using LogicWorld.Server.Circuitry;

namespace LA
{
    public class sixteenbitmem : LogicComponent
    {
        bool[,] memory = new bool[65537, 16];
        protected override void DoLogicUpdate()
        {
            //Inputs 0-15 - data in
            //Inputs 16 - write
            //Inputs 17-32 - address

            int address = 0;
            if (Inputs[17].On) address += 1;
            if (Inputs[18].On) address += 2;
            if (Inputs[19].On) address += 4;
            if (Inputs[20].On) address += 8;
            if (Inputs[21].On) address += 16;
            if (Inputs[22].On) address += 32;
            if (Inputs[23].On) address += 64;
            if (Inputs[24].On) address += 128;
            if (Inputs[25].On) address += 256;
            if (Inputs[26].On) address += 512;
            if (Inputs[27].On) address += 1024;
            if (Inputs[28].On) address += 2048;
            if (Inputs[29].On) address += 4096;
            if (Inputs[30].On) address += 8192;
            if (Inputs[31].On) address += 16384;
            if (Inputs[32].On) address += 32768;


            if (Inputs[16].On)
            {
                
                memory[address, 0] = Inputs[0].On;
                memory[address, 1] = Inputs[1].On;
                memory[address, 2] = Inputs[2].On;
                memory[address, 3] = Inputs[3].On;
                memory[address, 4] = Inputs[4].On;
                memory[address, 5] = Inputs[5].On;
                memory[address, 6] = Inputs[6].On;
                memory[address, 7] = Inputs[7].On;
                memory[address, 8] = Inputs[8].On;
                memory[address, 9] = Inputs[9].On;
                memory[address, 10] = Inputs[10].On;
                memory[address, 11] = Inputs[11].On;
                memory[address, 12] = Inputs[12].On;
                memory[address, 13] = Inputs[13].On;
                memory[address, 14] = Inputs[14].On;
                memory[address, 15] = Inputs[15].On;
            }


            Outputs[0].On = memory[address,0];
            Outputs[1].On = memory[address,1];
            Outputs[2].On = memory[address,2];
            Outputs[3].On = memory[address,3];
            Outputs[4].On = memory[address, 4];
            Outputs[5].On = memory[address, 5];
            Outputs[6].On = memory[address, 6];
            Outputs[7].On = memory[address, 7];
            Outputs[8].On = memory[address, 8];
            Outputs[9].On = memory[address, 9];
            Outputs[10].On = memory[address, 10];
            Outputs[11].On = memory[address, 11];
            Outputs[12].On = memory[address, 12];
            Outputs[13].On = memory[address, 13];
            Outputs[14].On = memory[address, 14];
            Outputs[15].On = memory[address, 15];


        }
    }
}